Public Class Form_Options

    Private _Options As Parametres

    Sub New(ByRef Options As Parametres)

        InitializeComponent()
        _Options = Options


        Load_GUI()

    End Sub

    Private Sub Load_GUI()

        'Proba infections
        NumericUpDown_Options_ProbaInfections.Value = _Options.Proba_Infection

        MsgBox(_Options.Proba_Symptomes)
        'Proba symptomes
        NumericUpDown_Options_ProbaSymptomes.Value = _Options.Proba_Symptomes

    End Sub

    Private Sub Button_Options_ResetDefault_Click(sender As Object, e As EventArgs) Handles Button_Options_ResetDefault.Click
        _Options.Load_Default_Value()
        Load_GUI()
    End Sub

    Private Sub NumericUpDown_Options_ProbaInfections_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Options_ProbaInfections.ValueChanged

    End Sub

End Class