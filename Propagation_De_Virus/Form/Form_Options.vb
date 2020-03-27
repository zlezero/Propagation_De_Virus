Public Class Form_Options

    Private _Options As Parametres

    Sub New(ByRef Options As Parametres)

        InitializeComponent()
        _Options = Options

        Load_GUI()

    End Sub

    Private Sub Load_GUI()

        'Proba
        NumericUpDown_Options_ProbaInfections.Value = _Options.Proba_Infection
        NumericUpDown_Options_ProbaSymptomes.Value = _Options.Proba_Symptomes
        NumericUpDown_Options_ProbaHopital.Value = _Options.Proba_Hopital
        NumericUpDown_Options_ProbaComplications.Value = _Options.Proba_Complications
        NumericUpDown_Options_ProbaMort.Value = _Options.Proba_Mort

        'Constantes
        NumericUpDown_Options_ZoneInfection.Value = _Options.Zone_Infection
        NumericUpDown_Options_Rayon.Value = _Options.Rayon
        NumericUpDown_Options_Amplitude.Value = _Options.Amplitude_Deplacement
        NumericUpDown_Options_TaillePop.Value = _Options.TaillePop

        CheckBox_Options_Confinement.Checked = _Options.Confinement

        'Proba guerion
        ListBox_Options_ProbaGuerisons_Etat.Items.Clear()
        For Each Etat As Statut_Infection In System.Enum.GetValues(GetType(Statut_Infection))
            If Etat > 0 And Etat < 5 Then
                ListBox_Options_ProbaGuerisons_Etat.Items.Add(Etat)
            End If
        Next

        ListBox_Options_ProbaGuerisons_Etat.SelectedIndex = 0

        'Vitesse Simu
        NumericUpDown_Options_VitesseSimulation.Value = _Options.VitesseSimulation
        CheckBox_Options_ShowGraphics.Checked = _Options.ShowGraphics

    End Sub

    Private Sub Button_Options_ResetDefault_Click(sender As Object, e As EventArgs) Handles Button_Options_ResetDefault.Click
        _Options.Load_Default_Value()
        Load_GUI()
    End Sub

    Private Sub NumericUpDown_Options_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Options_ProbaInfections.ValueChanged, NumericUpDown_Options_ProbaSymptomes.ValueChanged, NumericUpDown_Options_ProbaHopital.ValueChanged, NumericUpDown_Options_ProbaInfections.ValueChanged, NumericUpDown_Options_ProbaMort.ValueChanged, NumericUpDown_Options_ZoneInfection.ValueChanged, NumericUpDown_Options_Rayon.ValueChanged, NumericUpDown_Options_Amplitude.ValueChanged, NumericUpDown_Options_TaillePop.ValueChanged, NumericUpDown_Options_VitesseSimulation.ValueChanged

        Select Case CType(sender, NumericUpDown).GetHashCode
            Case NumericUpDown_Options_ProbaInfections.GetHashCode
                _Options.Proba_Infection = NumericUpDown_Options_ProbaInfections.Value
            Case NumericUpDown_Options_ProbaSymptomes.GetHashCode
                _Options.Proba_Symptomes = NumericUpDown_Options_ProbaSymptomes.Value
            Case NumericUpDown_Options_ProbaHopital.GetHashCode
                _Options.Proba_Hopital = NumericUpDown_Options_ProbaHopital.Value
            Case NumericUpDown_Options_ProbaComplications.GetHashCode
                _Options.Proba_Complications = NumericUpDown_Options_ProbaComplications.Value
            Case NumericUpDown_Options_ProbaMort.GetHashCode
                _Options.Proba_Mort = NumericUpDown_Options_ProbaMort.Value
            Case NumericUpDown_Options_ZoneInfection.GetHashCode
                _Options.Zone_Infection = NumericUpDown_Options_ZoneInfection.Value
            Case NumericUpDown_Options_Rayon.GetHashCode
                _Options.Rayon = NumericUpDown_Options_Rayon.Value
            Case NumericUpDown_Options_Amplitude.GetHashCode
                _Options.Amplitude_Deplacement = NumericUpDown_Options_Amplitude.Value
            Case NumericUpDown_Options_TaillePop.GetHashCode
                _Options.TaillePop = NumericUpDown_Options_TaillePop.Value
            Case NumericUpDown_Options_VitesseSimulation.GetHashCode
                _Options.VitesseSimulation = NumericUpDown_Options_VitesseSimulation.Value
        End Select

    End Sub

    Private Sub CheckBox_Options_Confinement_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Options_Confinement.CheckedChanged
        _Options.Confinement = CheckBox_Options_Confinement.Checked
    End Sub

    Private Sub ListBox_Options_ProbaGuerisons_Etat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Options_ProbaGuerisons_Etat.SelectedIndexChanged
        If ListBox_Options_ProbaGuerisons_Etat.SelectedIndex <> -1 Then
            NumericUpDown_Options_ProbaGuerison.Value = _Options.Proba_Guerison(ListBox_Options_ProbaGuerisons_Etat.SelectedIndex + 1)
        End If
    End Sub

    Private Sub NumericUpDown_Options_ProbaGuerison_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Options_ProbaGuerison.ValueChanged
        If ListBox_Options_ProbaGuerisons_Etat.SelectedIndex <> -1 Then
            _Options.Proba_Guerison(ListBox_Options_ProbaGuerisons_Etat.SelectedIndex + 1) = NumericUpDown_Options_ProbaGuerison.Value
        End If
    End Sub

    Private Sub CheckBox_Options_ShowGraphics_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Options_ShowGraphics.CheckedChanged
        _Options.ShowGraphics = CheckBox_Options_ShowGraphics.Checked
    End Sub

End Class