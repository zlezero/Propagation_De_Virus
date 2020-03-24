<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Personne_Logs
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
        Me.ListBox_Logs_Personne = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox_Logs_Personne
        '
        Me.ListBox_Logs_Personne.FormattingEnabled = True
        Me.ListBox_Logs_Personne.HorizontalScrollbar = True
        Me.ListBox_Logs_Personne.ItemHeight = 16
        Me.ListBox_Logs_Personne.Location = New System.Drawing.Point(16, 15)
        Me.ListBox_Logs_Personne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox_Logs_Personne.Name = "ListBox_Logs_Personne"
        Me.ListBox_Logs_Personne.Size = New System.Drawing.Size(413, 244)
        Me.ListBox_Logs_Personne.TabIndex = 0
        '
        'Form_Personne_Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 280)
        Me.Controls.Add(Me.ListBox_Logs_Personne)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form_Personne_Logs"
        Me.Text = "Logs de la personne n°0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox_Logs_Personne As ListBox
End Class
