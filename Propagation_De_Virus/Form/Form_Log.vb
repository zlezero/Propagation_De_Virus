Imports System.IO
Public Class Form_Log

    Private _Closing As Boolean = False

    Private WithEvents _Game As Game
    Private WithEvents _Main As Main

    Private Sub Form_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Game = Main.Jeu
        _Main = Main
    End Sub
    Private Sub Form_Log_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If Me.Visible Then

            If _Game Is Nothing Then
                _Game = Main.Jeu
            End If

            If _Game IsNot Nothing Then
                If _Game.Pause Then
                    Show_Full_Log()
                End If
            End If

        End If

    End Sub

    Private Sub ListBox_Log_TexteLog_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox_Log_TexteLog.MouseDoubleClick

        Try
            If ListBox_Log_TexteLog.SelectedIndex <> -1 Then
                Dim Form_Personne As New Form_Personne(_Game.Population(ListBox_Log_TexteLog.Items(ListBox_Log_TexteLog.SelectedIndex).ToString().Split(" ")(1)))
                Form_Personne.Show()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button_Log_ClearLog_Click(sender As Object, e As EventArgs) Handles Button_Log_ClearLog.Click
        Clear_Log()
    End Sub

    Private Sub Button_Log_Save_Click(sender As Object, e As EventArgs) Handles Button_Log_Save.Click
        If SaveFileDialog_Log.ShowDialog() = DialogResult.OK Then
            Save_Log(SaveFileDialog_Log.FileName)
        End If
    End Sub

    Private Sub Form_Log_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _Closing = True
    End Sub

    Private Sub Clear_Log()
        ListBox_Log_TexteLog.Items.Clear()
    End Sub

    Private Sub Show_Full_Log()
        Clear_Log()
        For Each ligneLog In _Game.Log
            ListBox_Log_TexteLog.Items.Add(ligneLog)
        Next
        ListBox_Log_TexteLog.TopIndex = ListBox_Log_TexteLog.Items.Count - 1
    End Sub

    Private Sub Update_Log()
        For I As Integer = ListBox_Log_TexteLog.Items.Count To _Game.Log.Count - 1
            ListBox_Log_TexteLog.Items.Add(_Game.Log(I))
        Next
        ListBox_Log_TexteLog.TopIndex = ListBox_Log_TexteLog.Items.Count - 1
    End Sub

    Delegate Sub dShowLog()

    Private Sub Log_Modifie() Handles _Game.Log_Modifie
        If Me.Visible Then
            If ListBox_Log_TexteLog.Items.Count = 0 Then
                If Not _Closing Then
                    Try
                        Me.Invoke(New dShowLog(AddressOf Show_Full_Log))
                    Catch ex As Exception
                    End Try
                End If
            Else
                If Not _Closing Then
                    Try
                        Me.Invoke(New dShowLog(AddressOf Update_Log))
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Save_Log(ByVal FileName As String)
        If FileName <> "" Then
            Try

                Dim SW As New StreamWriter(FileName)

                For Each ligne In ListBox_Log_TexteLog.Items
                    SW.WriteLine(ligne)
                Next

                SW.Flush()
                SW.Close()

                MsgBox("Les logs ont été enregistrés avec succès !", MsgBoxStyle.Information, "Enregistrement des logs")

            Catch ex As Exception
                MsgBox("Une erreur est survenue lors de l'enregistrement des logs : " & ex.Message, MsgBoxStyle.Critical, "Erreur")
            End Try
        End If
    End Sub

    Private Sub Simulation_Pause() Handles _Main.Simulation_Pause
        Button_Log_Save.Enabled = True
    End Sub

    Private Sub Simulation_Unpause() Handles _Main.Simultation_Unpause
        Button_Log_Save.Enabled = False
    End Sub

    Private Sub Simulation_Lancee() Handles _Main.Simulation_Lancee
        If _Game Is Nothing Then
            _Game = Main.Jeu
        End If
    End Sub

End Class