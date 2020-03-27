Imports SFML.System
Imports SFML.Window

Public Class Main

    Private WithEvents _RenderWindow As SFML.Graphics.RenderWindow
    Private _Thread_Graphics As Threading.Thread

    Private _Jeu As Game
    Private _Parametres As Parametres

    Private _Carre As New SFML.Graphics.RectangleShape(New SFML.System.Vector2f(2, 2))
    Private _Ligne As New SFML.Graphics.RectangleShape(New SFML.System.Vector2f(150, 2))

    Private _OptionsForm As Form_Options = Nothing

    Private _LastClickTime As Date = Nothing

    Public Event Simulation_Lancee As EventHandler
    Public Event Simulation_Pause As EventHandler
    Public Event Simultation_Unpause As EventHandler

    Delegate Sub dMajGuiCompteur()
    Delegate Sub dNewFormPersonne(ByRef Personne As Personne)

#Region "Window Event"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_RenderWindow()
        Panel_Main_Render.Select()
        _Parametres = New Parametres()
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _Thread_Graphics IsNot Nothing AndAlso _Thread_Graphics.ThreadState Then

            If _Jeu IsNot Nothing Then
                _Jeu.Pause = False
                _Jeu.Quitter = True
            End If

            If _RenderWindow.IsOpen Then
                _RenderWindow.Close()
            End If
            _Thread_Graphics.Abort()

        End If
    End Sub

#End Region

#Region "Control Event"
    Private Sub Button_Main_Launch_Click(sender As Object, e As EventArgs) Handles Button_Main_Launch.Click

        _Jeu = New Game(Panel_Main_Render.Width, Panel_Main_Render.Height, _Parametres)

        RaiseEvent Simulation_Lancee(Me, New EventArgs)

        _Thread_Graphics = New Threading.Thread(AddressOf Thread_Graphics)
        _Thread_Graphics.Name = "Thread Graphics"
        _Thread_Graphics.Start()

        Button_Main_Launch.Enabled = False
        Button_Main_Pause.Enabled = True
        Button_Main_Stop.Enabled = True

    End Sub
    Private Sub Button_Main_Pause_Click(sender As Object, e As EventArgs) Handles Button_Main_Pause.Click

        If _Jeu.Pause Then
            _Jeu.Pause = False
            Button_Main_Pause.Text = "Pause"
            Button_Main_SimulateOneTurn.Enabled = False
            RaiseEvent Simultation_Unpause(Me, New EventArgs)
        Else
            _Jeu.Pause = True
            Button_Main_Pause.Text = "Reprendre"
            Button_Main_SimulateOneTurn.Enabled = True
            RaiseEvent Simulation_Pause(Me, New EventArgs)
        End If

    End Sub

    Private Sub Button_Main_Stop_Click(sender As Object, e As EventArgs) Handles Button_Main_Stop.Click

        If _Jeu.Pause Then
            Button_Main_Pause.Text = "Pause"
        End If

        _Jeu.Quitter = True
        Button_Main_Launch.Enabled = True
        Button_Main_Pause.Enabled = False
        Button_Main_Stop.Enabled = False
        Button_Main_SimulateOneTurn.Enabled = False

    End Sub

    Private Sub Button_Main_SimulateOneTurn_Click(sender As Object, e As EventArgs) Handles Button_Main_SimulateOneTurn.Click
        _Jeu.SimulerOneTurn = True
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click

        _OptionsForm = New Form_Options(_Parametres)
        _OptionsForm.Show()

    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        Form_Log.Show()
    End Sub

    Public Sub Maj_GUI_Compteur()

        For Each Compteur In _Jeu.Correspondance_Compteurs_Label
            Compteur.Value.Text = _Jeu.Compteurs(Compteur.Key)
        Next

    End Sub

    Private Sub Init_RenderWindow()
        _RenderWindow = New SFML.Graphics.RenderWindow(Panel_Main_Render.Handle)
        _RenderWindow.SetActive(False)
        _RenderWindow.SetFramerateLimit(60)
        _RenderWindow.SetKeyRepeatEnabled(False)
    End Sub

#End Region

#Region "Graphics"
    Private Sub Thread_Graphics()

        While _RenderWindow.IsOpen

            If Not _Jeu.Pause Or _Jeu.SimulerOneTurn Then
                _Jeu.Next_Turn()
                Me.Invoke(New dMajGuiCompteur(AddressOf Maj_GUI_Compteur))
            End If

            If _Parametres.ShowGraphics Then
                Draw_Graphics()
                _RenderWindow.Display()
                _RenderWindow.Clear()
            End If

            _RenderWindow.DispatchEvents()
            Threading.Thread.Sleep(0.01)

            If _Jeu.Quitter Then
                _RenderWindow.Clear()
                Exit While
            End If

        End While

    End Sub
    Private Sub Draw_Graphics()

        For Each Personne In _Jeu.Population

            _Carre.Position = Personne.Pos

            Select Case Personne.Etat
                Case Statut_Infection.NON_INFECTE
                    _Carre.FillColor = SFML.Graphics.Color.Green
                Case Statut_Infection.INFECTE_ASYMPTOTIQUE
                    _Carre.FillColor = SFML.Graphics.Color.Red
                Case Statut_Infection.INFECTE_SYMPTOMATIQUE_NH
                    _Carre.FillColor = SFML.Graphics.Color.Cyan
                Case Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FAIBLE
                    _Carre.FillColor = SFML.Graphics.Color.Yellow
                Case Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FORT
                    _Carre.FillColor = SFML.Graphics.Color.Magenta
                Case Statut_Infection.INFECTE_DECEDE
                    _Carre.FillColor = SFML.Graphics.Color.White
            End Select

            If Personne.Etat <> Statut_Infection.INFECTE_DECEDE Then

                _RenderWindow.Draw(_Carre)

                If Personne.Delta <> Nothing Then
                    _Ligne.Position = Personne.Delta
                End If

            End If

        Next

    End Sub

    Public Sub Clear_Screen()
        _RenderWindow.Clear()
    End Sub

    Private Sub Mouse_Click(ByVal sender As Object, ByVal e As MouseButtonEventArgs) Handles _RenderWindow.MouseButtonPressed

        If _Jeu.Pause = True And e.Button = Mouse.Button.Left Then

            Dim TimeNow As Date = Date.Now
            Dim MousePosition As Vector2i = Mouse.GetPosition(_RenderWindow)

            If _LastClickTime <> Nothing AndAlso TimeNow.Subtract(_LastClickTime).Milliseconds < 350 Then
                _Jeu.Add_Infecte(MousePosition)
                'MsgBox("Infecté ajouté !")
            Else

                For Each Personne In _Jeu.Population
                    If (Personne.Pos.X <= MousePosition.X + 3 And Personne.Pos.X >= MousePosition.X - 3) And (Personne.Pos.Y <= MousePosition.Y + 3 And Personne.Pos.Y >= MousePosition.Y - 3) Then
                        Me.Invoke(New dNewFormPersonne(AddressOf New_FormPersonne), Personne)
                        Exit For
                    End If
                Next

            End If

            _LastClickTime = Date.Now

        End If

    End Sub

    Private Sub New_FormPersonne(ByRef Personne As Personne)
        Dim Form_Pers As New Form_Personne(Personne)
        Form_Pers.Show(Me)
    End Sub


#End Region

    Public Property Jeu As Game
        Get
            Return _Jeu
        End Get
        Set(value As Game)
            _Jeu = value
        End Set
    End Property

End Class
