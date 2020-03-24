<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Options
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Options_ResetDefault = New System.Windows.Forms.Button()
        Me.GroupBox_Options_Proba = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_Options_ProbaMort = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaMort = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_ProbaComplications = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaComplications = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_ProbaHopital = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaHopital = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_ProbaSymptomes = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaSymptomes = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_ProbaInfections = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaInfections = New System.Windows.Forms.Label()
        Me.GroupBox_Options_Constantes = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_Options_TaillePop = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_TaillePop = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_Amplitude = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_Amplitude = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_Rayon = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_Rayon = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_ZoneInfection = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ZoneInfection = New System.Windows.Forms.Label()
        Me.CheckBox_Options_Confinement = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Options_ProbaGuerison = New System.Windows.Forms.GroupBox()
        Me.ListBox_Options_ProbaGuerisons_Etat = New System.Windows.Forms.ListBox()
        Me.NumericUpDown_Options_ProbaGuerison = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaGuerison = New System.Windows.Forms.Label()
        Me.GroupBox_Options_Proba.SuspendLayout()
        CType(Me.NumericUpDown_Options_ProbaMort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_ProbaComplications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_ProbaHopital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_ProbaSymptomes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_ProbaInfections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Options_Constantes.SuspendLayout()
        CType(Me.NumericUpDown_Options_TaillePop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_Amplitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_Rayon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_ZoneInfection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Options_ProbaGuerison.SuspendLayout()
        CType(Me.NumericUpDown_Options_ProbaGuerison, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Options_ResetDefault
        '
        Me.Button_Options_ResetDefault.Location = New System.Drawing.Point(289, 217)
        Me.Button_Options_ResetDefault.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Options_ResetDefault.Name = "Button_Options_ResetDefault"
        Me.Button_Options_ResetDefault.Size = New System.Drawing.Size(329, 28)
        Me.Button_Options_ResetDefault.TabIndex = 0
        Me.Button_Options_ResetDefault.Text = "Restaurer les paramètres initiaux"
        Me.Button_Options_ResetDefault.UseVisualStyleBackColor = True
        '
        'GroupBox_Options_Proba
        '
        Me.GroupBox_Options_Proba.Controls.Add(Me.NumericUpDown_Options_ProbaMort)
        Me.GroupBox_Options_Proba.Controls.Add(Me.Label_Options_ProbaMort)
        Me.GroupBox_Options_Proba.Controls.Add(Me.NumericUpDown_Options_ProbaComplications)
        Me.GroupBox_Options_Proba.Controls.Add(Me.Label_Options_ProbaComplications)
        Me.GroupBox_Options_Proba.Controls.Add(Me.NumericUpDown_Options_ProbaHopital)
        Me.GroupBox_Options_Proba.Controls.Add(Me.Label_Options_ProbaHopital)
        Me.GroupBox_Options_Proba.Controls.Add(Me.NumericUpDown_Options_ProbaSymptomes)
        Me.GroupBox_Options_Proba.Controls.Add(Me.Label_Options_ProbaSymptomes)
        Me.GroupBox_Options_Proba.Controls.Add(Me.NumericUpDown_Options_ProbaInfections)
        Me.GroupBox_Options_Proba.Controls.Add(Me.Label_Options_ProbaInfections)
        Me.GroupBox_Options_Proba.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_Options_Proba.Name = "GroupBox_Options_Proba"
        Me.GroupBox_Options_Proba.Size = New System.Drawing.Size(270, 189)
        Me.GroupBox_Options_Proba.TabIndex = 1
        Me.GroupBox_Options_Proba.TabStop = False
        Me.GroupBox_Options_Proba.Text = "Probabilités"
        '
        'NumericUpDown_Options_ProbaMort
        '
        Me.NumericUpDown_Options_ProbaMort.DecimalPlaces = 3
        Me.NumericUpDown_Options_ProbaMort.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Options_ProbaMort.Location = New System.Drawing.Point(192, 146)
        Me.NumericUpDown_Options_ProbaMort.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Options_ProbaMort.Name = "NumericUpDown_Options_ProbaMort"
        Me.NumericUpDown_Options_ProbaMort.Size = New System.Drawing.Size(58, 22)
        Me.NumericUpDown_Options_ProbaMort.TabIndex = 11
        '
        'Label_Options_ProbaMort
        '
        Me.Label_Options_ProbaMort.AutoSize = True
        Me.Label_Options_ProbaMort.Location = New System.Drawing.Point(16, 148)
        Me.Label_Options_ProbaMort.Name = "Label_Options_ProbaMort"
        Me.Label_Options_ProbaMort.Size = New System.Drawing.Size(115, 16)
        Me.Label_Options_ProbaMort.TabIndex = 10
        Me.Label_Options_ProbaMort.Text = "Probabilités mort :"
        '
        'NumericUpDown_Options_ProbaComplications
        '
        Me.NumericUpDown_Options_ProbaComplications.DecimalPlaces = 3
        Me.NumericUpDown_Options_ProbaComplications.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Options_ProbaComplications.Location = New System.Drawing.Point(192, 118)
        Me.NumericUpDown_Options_ProbaComplications.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Options_ProbaComplications.Name = "NumericUpDown_Options_ProbaComplications"
        Me.NumericUpDown_Options_ProbaComplications.Size = New System.Drawing.Size(58, 22)
        Me.NumericUpDown_Options_ProbaComplications.TabIndex = 9
        '
        'Label_Options_ProbaComplications
        '
        Me.Label_Options_ProbaComplications.AutoSize = True
        Me.Label_Options_ProbaComplications.Location = New System.Drawing.Point(16, 120)
        Me.Label_Options_ProbaComplications.Name = "Label_Options_ProbaComplications"
        Me.Label_Options_ProbaComplications.Size = New System.Drawing.Size(172, 16)
        Me.Label_Options_ProbaComplications.TabIndex = 8
        Me.Label_Options_ProbaComplications.Text = "Probabilités complications :"
        '
        'NumericUpDown_Options_ProbaHopital
        '
        Me.NumericUpDown_Options_ProbaHopital.DecimalPlaces = 3
        Me.NumericUpDown_Options_ProbaHopital.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Options_ProbaHopital.Location = New System.Drawing.Point(192, 90)
        Me.NumericUpDown_Options_ProbaHopital.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Options_ProbaHopital.Name = "NumericUpDown_Options_ProbaHopital"
        Me.NumericUpDown_Options_ProbaHopital.Size = New System.Drawing.Size(58, 22)
        Me.NumericUpDown_Options_ProbaHopital.TabIndex = 7
        '
        'Label_Options_ProbaHopital
        '
        Me.Label_Options_ProbaHopital.AutoSize = True
        Me.Label_Options_ProbaHopital.Location = New System.Drawing.Point(16, 92)
        Me.Label_Options_ProbaHopital.Name = "Label_Options_ProbaHopital"
        Me.Label_Options_ProbaHopital.Size = New System.Drawing.Size(129, 16)
        Me.Label_Options_ProbaHopital.TabIndex = 6
        Me.Label_Options_ProbaHopital.Text = "Probabilités hopital :"
        '
        'NumericUpDown_Options_ProbaSymptomes
        '
        Me.NumericUpDown_Options_ProbaSymptomes.DecimalPlaces = 3
        Me.NumericUpDown_Options_ProbaSymptomes.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Options_ProbaSymptomes.Location = New System.Drawing.Point(192, 62)
        Me.NumericUpDown_Options_ProbaSymptomes.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Options_ProbaSymptomes.Name = "NumericUpDown_Options_ProbaSymptomes"
        Me.NumericUpDown_Options_ProbaSymptomes.Size = New System.Drawing.Size(58, 22)
        Me.NumericUpDown_Options_ProbaSymptomes.TabIndex = 5
        '
        'Label_Options_ProbaSymptomes
        '
        Me.Label_Options_ProbaSymptomes.AutoSize = True
        Me.Label_Options_ProbaSymptomes.Location = New System.Drawing.Point(16, 63)
        Me.Label_Options_ProbaSymptomes.Name = "Label_Options_ProbaSymptomes"
        Me.Label_Options_ProbaSymptomes.Size = New System.Drawing.Size(159, 16)
        Me.Label_Options_ProbaSymptomes.TabIndex = 3
        Me.Label_Options_ProbaSymptomes.Text = "Probabilités symptomes :"
        '
        'NumericUpDown_Options_ProbaInfections
        '
        Me.NumericUpDown_Options_ProbaInfections.DecimalPlaces = 3
        Me.NumericUpDown_Options_ProbaInfections.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Options_ProbaInfections.Location = New System.Drawing.Point(192, 34)
        Me.NumericUpDown_Options_ProbaInfections.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Options_ProbaInfections.Name = "NumericUpDown_Options_ProbaInfections"
        Me.NumericUpDown_Options_ProbaInfections.Size = New System.Drawing.Size(58, 22)
        Me.NumericUpDown_Options_ProbaInfections.TabIndex = 2
        '
        'Label_Options_ProbaInfections
        '
        Me.Label_Options_ProbaInfections.AutoSize = True
        Me.Label_Options_ProbaInfections.Location = New System.Drawing.Point(16, 36)
        Me.Label_Options_ProbaInfections.Name = "Label_Options_ProbaInfections"
        Me.Label_Options_ProbaInfections.Size = New System.Drawing.Size(138, 16)
        Me.Label_Options_ProbaInfections.TabIndex = 0
        Me.Label_Options_ProbaInfections.Text = "Probabilités infection :"
        '
        'GroupBox_Options_Constantes
        '
        Me.GroupBox_Options_Constantes.Controls.Add(Me.NumericUpDown_Options_TaillePop)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.Label_Options_TaillePop)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.NumericUpDown_Options_Amplitude)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.Label_Options_Amplitude)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.NumericUpDown_Options_Rayon)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.Label_Options_Rayon)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.NumericUpDown_Options_ZoneInfection)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.Label_Options_ZoneInfection)
        Me.GroupBox_Options_Constantes.Controls.Add(Me.CheckBox_Options_Confinement)
        Me.GroupBox_Options_Constantes.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox_Options_Constantes.Name = "GroupBox_Options_Constantes"
        Me.GroupBox_Options_Constantes.Size = New System.Drawing.Size(270, 189)
        Me.GroupBox_Options_Constantes.TabIndex = 2
        Me.GroupBox_Options_Constantes.TabStop = False
        Me.GroupBox_Options_Constantes.Text = "Constantes"
        '
        'NumericUpDown_Options_TaillePop
        '
        Me.NumericUpDown_Options_TaillePop.Location = New System.Drawing.Point(181, 149)
        Me.NumericUpDown_Options_TaillePop.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown_Options_TaillePop.Name = "NumericUpDown_Options_TaillePop"
        Me.NumericUpDown_Options_TaillePop.Size = New System.Drawing.Size(72, 22)
        Me.NumericUpDown_Options_TaillePop.TabIndex = 8
        '
        'Label_Options_TaillePop
        '
        Me.Label_Options_TaillePop.AutoSize = True
        Me.Label_Options_TaillePop.Location = New System.Drawing.Point(16, 152)
        Me.Label_Options_TaillePop.Name = "Label_Options_TaillePop"
        Me.Label_Options_TaillePop.Size = New System.Drawing.Size(142, 16)
        Me.Label_Options_TaillePop.TabIndex = 7
        Me.Label_Options_TaillePop.Text = "Population de départ  :"
        '
        'NumericUpDown_Options_Amplitude
        '
        Me.NumericUpDown_Options_Amplitude.Location = New System.Drawing.Point(181, 121)
        Me.NumericUpDown_Options_Amplitude.Name = "NumericUpDown_Options_Amplitude"
        Me.NumericUpDown_Options_Amplitude.Size = New System.Drawing.Size(72, 22)
        Me.NumericUpDown_Options_Amplitude.TabIndex = 6
        '
        'Label_Options_Amplitude
        '
        Me.Label_Options_Amplitude.AutoSize = True
        Me.Label_Options_Amplitude.Location = New System.Drawing.Point(16, 124)
        Me.Label_Options_Amplitude.Name = "Label_Options_Amplitude"
        Me.Label_Options_Amplitude.Size = New System.Drawing.Size(159, 16)
        Me.Label_Options_Amplitude.TabIndex = 5
        Me.Label_Options_Amplitude.Text = "Amplitude déplacement  :"
        '
        'NumericUpDown_Options_Rayon
        '
        Me.NumericUpDown_Options_Rayon.Location = New System.Drawing.Point(181, 95)
        Me.NumericUpDown_Options_Rayon.Name = "NumericUpDown_Options_Rayon"
        Me.NumericUpDown_Options_Rayon.Size = New System.Drawing.Size(72, 22)
        Me.NumericUpDown_Options_Rayon.TabIndex = 4
        '
        'Label_Options_Rayon
        '
        Me.Label_Options_Rayon.AutoSize = True
        Me.Label_Options_Rayon.Location = New System.Drawing.Point(16, 96)
        Me.Label_Options_Rayon.Name = "Label_Options_Rayon"
        Me.Label_Options_Rayon.Size = New System.Drawing.Size(57, 16)
        Me.Label_Options_Rayon.TabIndex = 3
        Me.Label_Options_Rayon.Text = "Rayon  :"
        '
        'NumericUpDown_Options_ZoneInfection
        '
        Me.NumericUpDown_Options_ZoneInfection.Location = New System.Drawing.Point(181, 67)
        Me.NumericUpDown_Options_ZoneInfection.Name = "NumericUpDown_Options_ZoneInfection"
        Me.NumericUpDown_Options_ZoneInfection.Size = New System.Drawing.Size(72, 22)
        Me.NumericUpDown_Options_ZoneInfection.TabIndex = 2
        '
        'Label_Options_ZoneInfection
        '
        Me.Label_Options_ZoneInfection.AutoSize = True
        Me.Label_Options_ZoneInfection.Location = New System.Drawing.Point(16, 68)
        Me.Label_Options_ZoneInfection.Name = "Label_Options_ZoneInfection"
        Me.Label_Options_ZoneInfection.Size = New System.Drawing.Size(97, 16)
        Me.Label_Options_ZoneInfection.TabIndex = 1
        Me.Label_Options_ZoneInfection.Text = "Zone infection :"
        '
        'CheckBox_Options_Confinement
        '
        Me.CheckBox_Options_Confinement.AutoSize = True
        Me.CheckBox_Options_Confinement.Location = New System.Drawing.Point(19, 32)
        Me.CheckBox_Options_Confinement.Name = "CheckBox_Options_Confinement"
        Me.CheckBox_Options_Confinement.Size = New System.Drawing.Size(101, 20)
        Me.CheckBox_Options_Confinement.TabIndex = 0
        Me.CheckBox_Options_Confinement.Text = "Confinement"
        Me.CheckBox_Options_Confinement.UseVisualStyleBackColor = True
        '
        'GroupBox_Options_ProbaGuerison
        '
        Me.GroupBox_Options_ProbaGuerison.Controls.Add(Me.Label_Options_ProbaGuerison)
        Me.GroupBox_Options_ProbaGuerison.Controls.Add(Me.NumericUpDown_Options_ProbaGuerison)
        Me.GroupBox_Options_ProbaGuerison.Controls.Add(Me.ListBox_Options_ProbaGuerisons_Etat)
        Me.GroupBox_Options_ProbaGuerison.Location = New System.Drawing.Point(288, 12)
        Me.GroupBox_Options_ProbaGuerison.Name = "GroupBox_Options_ProbaGuerison"
        Me.GroupBox_Options_ProbaGuerison.Size = New System.Drawing.Size(330, 189)
        Me.GroupBox_Options_ProbaGuerison.TabIndex = 3
        Me.GroupBox_Options_ProbaGuerison.TabStop = False
        Me.GroupBox_Options_ProbaGuerison.Text = "Probabilités guérison"
        '
        'ListBox_Options_ProbaGuerisons_Etat
        '
        Me.ListBox_Options_ProbaGuerisons_Etat.FormattingEnabled = True
        Me.ListBox_Options_ProbaGuerisons_Etat.HorizontalScrollbar = True
        Me.ListBox_Options_ProbaGuerisons_Etat.ItemHeight = 16
        Me.ListBox_Options_ProbaGuerisons_Etat.Location = New System.Drawing.Point(6, 24)
        Me.ListBox_Options_ProbaGuerisons_Etat.Name = "ListBox_Options_ProbaGuerisons_Etat"
        Me.ListBox_Options_ProbaGuerisons_Etat.Size = New System.Drawing.Size(173, 148)
        Me.ListBox_Options_ProbaGuerisons_Etat.TabIndex = 0
        '
        'NumericUpDown_Options_ProbaGuerison
        '
        Me.NumericUpDown_Options_ProbaGuerison.DecimalPlaces = 4
        Me.NumericUpDown_Options_ProbaGuerison.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown_Options_ProbaGuerison.Location = New System.Drawing.Point(210, 86)
        Me.NumericUpDown_Options_ProbaGuerison.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Options_ProbaGuerison.Name = "NumericUpDown_Options_ProbaGuerison"
        Me.NumericUpDown_Options_ProbaGuerison.Size = New System.Drawing.Size(72, 22)
        Me.NumericUpDown_Options_ProbaGuerison.TabIndex = 3
        '
        'Label_Options_ProbaGuerison
        '
        Me.Label_Options_ProbaGuerison.AutoSize = True
        Me.Label_Options_ProbaGuerison.Location = New System.Drawing.Point(189, 49)
        Me.Label_Options_ProbaGuerison.Name = "Label_Options_ProbaGuerison"
        Me.Label_Options_ProbaGuerison.Size = New System.Drawing.Size(129, 16)
        Me.Label_Options_ProbaGuerison.TabIndex = 4
        Me.Label_Options_ProbaGuerison.Text = "Probabilité de l'état :"
        '
        'Form_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 408)
        Me.Controls.Add(Me.GroupBox_Options_ProbaGuerison)
        Me.Controls.Add(Me.GroupBox_Options_Constantes)
        Me.Controls.Add(Me.GroupBox_Options_Proba)
        Me.Controls.Add(Me.Button_Options_ResetDefault)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form_Options"
        Me.Text = "Options"
        Me.GroupBox_Options_Proba.ResumeLayout(False)
        Me.GroupBox_Options_Proba.PerformLayout()
        CType(Me.NumericUpDown_Options_ProbaMort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_ProbaComplications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_ProbaHopital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_ProbaSymptomes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_ProbaInfections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Options_Constantes.ResumeLayout(False)
        Me.GroupBox_Options_Constantes.PerformLayout()
        CType(Me.NumericUpDown_Options_TaillePop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_Amplitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_Rayon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_ZoneInfection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Options_ProbaGuerison.ResumeLayout(False)
        Me.GroupBox_Options_ProbaGuerison.PerformLayout()
        CType(Me.NumericUpDown_Options_ProbaGuerison, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Options_ResetDefault As Button
    Friend WithEvents GroupBox_Options_Proba As GroupBox
    Friend WithEvents Label_Options_ProbaInfections As Label
    Friend WithEvents NumericUpDown_Options_ProbaInfections As NumericUpDown
    Friend WithEvents NumericUpDown_Options_ProbaSymptomes As NumericUpDown
    Friend WithEvents Label_Options_ProbaSymptomes As Label
    Friend WithEvents NumericUpDown_Options_ProbaComplications As NumericUpDown
    Friend WithEvents Label_Options_ProbaComplications As Label
    Friend WithEvents NumericUpDown_Options_ProbaHopital As NumericUpDown
    Friend WithEvents Label_Options_ProbaHopital As Label
    Friend WithEvents NumericUpDown_Options_ProbaMort As NumericUpDown
    Friend WithEvents Label_Options_ProbaMort As Label
    Friend WithEvents GroupBox_Options_Constantes As GroupBox
    Friend WithEvents CheckBox_Options_Confinement As CheckBox
    Friend WithEvents Label_Options_ZoneInfection As Label
    Friend WithEvents NumericUpDown_Options_ZoneInfection As NumericUpDown
    Friend WithEvents NumericUpDown_Options_Rayon As NumericUpDown
    Friend WithEvents Label_Options_Rayon As Label
    Friend WithEvents NumericUpDown_Options_Amplitude As NumericUpDown
    Friend WithEvents Label_Options_Amplitude As Label
    Friend WithEvents NumericUpDown_Options_TaillePop As NumericUpDown
    Friend WithEvents Label_Options_TaillePop As Label
    Friend WithEvents GroupBox_Options_ProbaGuerison As GroupBox
    Friend WithEvents ListBox_Options_ProbaGuerisons_Etat As ListBox
    Friend WithEvents Label_Options_ProbaGuerison As Label
    Friend WithEvents NumericUpDown_Options_ProbaGuerison As NumericUpDown
End Class
