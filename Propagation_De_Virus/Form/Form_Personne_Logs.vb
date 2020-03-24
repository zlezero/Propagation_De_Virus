Public Class Form_Personne_Logs

    Private WithEvents _Personne As Personne

    Public Sub New(ByRef Personne As Personne)
        InitializeComponent()
        _Personne = Personne
        Show_Full_Log()
        Text = "Logs de la personne n°" + Personne.Id.ToString()
    End Sub

    Private Sub Show_Full_Log()
        Clear_Log()
        For Each ligneLog In _Personne.Logs
            ListBox_Logs_Personne.Items.Add(ligneLog)
        Next
        ListBox_Logs_Personne.TopIndex = ListBox_Logs_Personne.Items.Count - 1
    End Sub

    Private Sub Update_Log()
        For I As Integer = ListBox_Logs_Personne.Items.Count To _Personne.Logs.Count - 1
            ListBox_Logs_Personne.Items.Add(_Personne.Logs(I))
        Next
        ListBox_Logs_Personne.TopIndex = ListBox_Logs_Personne.Items.Count - 1
    End Sub

    Private Sub Clear_Log()
        ListBox_Logs_Personne.Items.Clear()
    End Sub

    Delegate Sub dUpdateLog()

    Private Sub Log_Update() Handles _Personne.Log_Change
        If Me.Visible Then
            If ListBox_Logs_Personne.Items.Count = 0 Then
                Try
                    Me.Invoke(New dUpdateLog(AddressOf Show_Full_Log))
                Catch ex As Exception
                End Try
            Else
                Try
                    Me.Invoke(New dUpdateLog(AddressOf Update_Log))
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

End Class