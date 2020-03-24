<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Personne
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
        Me.Label_Personne_ID = New System.Windows.Forms.Label()
        Me.GroupBox_Personne_Informations = New System.Windows.Forms.GroupBox()
        Me.Label_Personne_Immunise = New System.Windows.Forms.Label()
        Me.Label_Personne_PositionDomicile = New System.Windows.Forms.Label()
        Me.Label_Personne_Etat = New System.Windows.Forms.Label()
        Me.Label_Personne_Position = New System.Windows.Forms.Label()
        Me.GroupBox_Personne_Informations.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Personne_ID
        '
        Me.Label_Personne_ID.AutoSize = True
        Me.Label_Personne_ID.Location = New System.Drawing.Point(19, 34)
        Me.Label_Personne_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Personne_ID.Name = "Label_Personne_ID"
        Me.Label_Personne_ID.Size = New System.Drawing.Size(25, 16)
        Me.Label_Personne_ID.TabIndex = 0
        Me.Label_Personne_ID.Text = "Id :"
        '
        'GroupBox_Personne_Informations
        '
        Me.GroupBox_Personne_Informations.Controls.Add(Me.Label_Personne_Immunise)
        Me.GroupBox_Personne_Informations.Controls.Add(Me.Label_Personne_PositionDomicile)
        Me.GroupBox_Personne_Informations.Controls.Add(Me.Label_Personne_Etat)
        Me.GroupBox_Personne_Informations.Controls.Add(Me.Label_Personne_Position)
        Me.GroupBox_Personne_Informations.Controls.Add(Me.Label_Personne_ID)
        Me.GroupBox_Personne_Informations.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_Personne_Informations.Name = "GroupBox_Personne_Informations"
        Me.GroupBox_Personne_Informations.Size = New System.Drawing.Size(275, 187)
        Me.GroupBox_Personne_Informations.TabIndex = 1
        Me.GroupBox_Personne_Informations.TabStop = False
        Me.GroupBox_Personne_Informations.Text = "Informations"
        '
        'Label_Personne_Immunise
        '
        Me.Label_Personne_Immunise.AutoSize = True
        Me.Label_Personne_Immunise.Location = New System.Drawing.Point(19, 147)
        Me.Label_Personne_Immunise.Name = "Label_Personne_Immunise"
        Me.Label_Personne_Immunise.Size = New System.Drawing.Size(71, 16)
        Me.Label_Personne_Immunise.TabIndex = 4
        Me.Label_Personne_Immunise.Text = "Immunisé :"
        '
        'Label_Personne_PositionDomicile
        '
        Me.Label_Personne_PositionDomicile.AutoSize = True
        Me.Label_Personne_PositionDomicile.Location = New System.Drawing.Point(19, 91)
        Me.Label_Personne_PositionDomicile.Name = "Label_Personne_PositionDomicile"
        Me.Label_Personne_PositionDomicile.Size = New System.Drawing.Size(116, 16)
        Me.Label_Personne_PositionDomicile.TabIndex = 3
        Me.Label_Personne_PositionDomicile.Text = "Position domicile :"
        '
        'Label_Personne_Etat
        '
        Me.Label_Personne_Etat.AutoSize = True
        Me.Label_Personne_Etat.Location = New System.Drawing.Point(19, 119)
        Me.Label_Personne_Etat.Name = "Label_Personne_Etat"
        Me.Label_Personne_Etat.Size = New System.Drawing.Size(40, 16)
        Me.Label_Personne_Etat.TabIndex = 2
        Me.Label_Personne_Etat.Text = "Etat : "
        '
        'Label_Personne_Position
        '
        Me.Label_Personne_Position.AutoSize = True
        Me.Label_Personne_Position.Location = New System.Drawing.Point(19, 63)
        Me.Label_Personne_Position.Name = "Label_Personne_Position"
        Me.Label_Personne_Position.Size = New System.Drawing.Size(62, 16)
        Me.Label_Personne_Position.TabIndex = 1
        Me.Label_Personne_Position.Text = "Position :"
        '
        'Form_Personne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 216)
        Me.Controls.Add(Me.GroupBox_Personne_Informations)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form_Personne"
        Me.Text = "Personne n°0"
        Me.GroupBox_Personne_Informations.ResumeLayout(False)
        Me.GroupBox_Personne_Informations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Personne_ID As Label
    Friend WithEvents GroupBox_Personne_Informations As GroupBox
    Friend WithEvents Label_Personne_Position As Label
    Friend WithEvents Label_Personne_Etat As Label
    Friend WithEvents Label_Personne_PositionDomicile As Label
    Friend WithEvents Label_Personne_Immunise As Label
End Class
