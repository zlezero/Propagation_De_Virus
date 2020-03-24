Public Class Form_Personne

    Private WithEvents _Personne As Personne = Nothing

    Public Sub New(ByRef Personne As Personne)
        InitializeComponent()
        _Personne = Personne
    End Sub

    Private Sub Form_Personne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_GUI()
    End Sub
    Private Sub Button_Personne_ViewLogs_Click(sender As Object, e As EventArgs) Handles Button_Personne_ViewLogs.Click
        Dim FormLogs As New Form_Personne_Logs(_Personne)
        FormLogs.Show(Me)
    End Sub

    Private Sub Load_GUI()
        Label_Personne_ID.Text = "ID : " + _Personne.Id.ToString()
        Label_Personne_Position.Text = "Position : X = " + _Personne.Pos.X.ToString() + " / Y = " + _Personne.Pos.Y.ToString()
        Label_Personne_PositionDomicile.Text = "Position domicile : X = " + _Personne.Pos_Domicile.X.ToString() + " / Y = " + _Personne.Pos_Domicile.Y.ToString()
        Label_Personne_Etat.Text = "Etat : " + _Personne.Etat.ToString()
        Label_Personne_Immunise.Text = "Immunisé : " + If(_Personne.Immunite, "Oui", "Non")
        Text = "Personne n°" + _Personne.Id.ToString()
    End Sub

    Delegate Sub dLoadGUI()

    Private Sub Personne_Changee() Handles _Personne.Etat_Change
        If Visible Then
            Me.Invoke(New dLoadGUI(AddressOf Load_GUI))
        End If
    End Sub

    Public Property Personne As Personne
        Get
            Return _Personne
        End Get
        Set(value As Personne)
            _Personne = value
        End Set
    End Property

End Class