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
        Me.NumericUpDown_Options_ProbaSymptomes = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaSymptomes = New System.Windows.Forms.Label()
        Me.NumericUpDown_Options_ProbaInfections = New System.Windows.Forms.NumericUpDown()
        Me.Label_Options_ProbaInfections = New System.Windows.Forms.Label()
        Me.GroupBox_Options_Proba.SuspendLayout()
        CType(Me.NumericUpDown_Options_ProbaSymptomes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Options_ProbaInfections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Options_ResetDefault
        '
        Me.Button_Options_ResetDefault.Location = New System.Drawing.Point(12, 208)
        Me.Button_Options_ResetDefault.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Options_ResetDefault.Name = "Button_Options_ResetDefault"
        Me.Button_Options_ResetDefault.Size = New System.Drawing.Size(270, 28)
        Me.Button_Options_ResetDefault.TabIndex = 0
        Me.Button_Options_ResetDefault.Text = "Restaurer les paramètres initiaux"
        Me.Button_Options_ResetDefault.UseVisualStyleBackColor = True
        '
        'GroupBox_Options_Proba
        '
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
        'NumericUpDown_Options_ProbaSymptomes
        '
        Me.NumericUpDown_Options_ProbaSymptomes.DecimalPlaces = 3
        Me.NumericUpDown_Options_ProbaSymptomes.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Options_ProbaSymptomes.Location = New System.Drawing.Point(181, 67)
        Me.NumericUpDown_Options_ProbaSymptomes.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Options_ProbaSymptomes.Name = "NumericUpDown_Options_ProbaSymptomes"
        Me.NumericUpDown_Options_ProbaSymptomes.Size = New System.Drawing.Size(55, 22)
        Me.NumericUpDown_Options_ProbaSymptomes.TabIndex = 5
        '
        'Label_Options_ProbaSymptomes
        '
        Me.Label_Options_ProbaSymptomes.AutoSize = True
        Me.Label_Options_ProbaSymptomes.Location = New System.Drawing.Point(16, 68)
        Me.Label_Options_ProbaSymptomes.Name = "Label_Options_ProbaSymptomes"
        Me.Label_Options_ProbaSymptomes.Size = New System.Drawing.Size(159, 16)
        Me.Label_Options_ProbaSymptomes.TabIndex = 3
        Me.Label_Options_ProbaSymptomes.Text = "Probabilités symptomes :"
        '
        'NumericUpDown_Options_ProbaInfections
        '
        Me.NumericUpDown_Options_ProbaInfections.DecimalPlaces = 3
        Me.NumericUpDown_Options_ProbaInfections.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_Options_ProbaInfections.Location = New System.Drawing.Point(160, 34)
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
        'Form_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 248)
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
        CType(Me.NumericUpDown_Options_ProbaSymptomes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Options_ProbaInfections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Options_ResetDefault As Button
    Friend WithEvents GroupBox_Options_Proba As GroupBox
    Friend WithEvents Label_Options_ProbaInfections As Label
    Friend WithEvents NumericUpDown_Options_ProbaInfections As NumericUpDown
    Friend WithEvents NumericUpDown_Options_ProbaSymptomes As NumericUpDown
    Friend WithEvents Label_Options_ProbaSymptomes As Label
End Class
