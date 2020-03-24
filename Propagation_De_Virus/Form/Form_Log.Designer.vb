<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Log
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
        Me.Button_Log_ClearLog = New System.Windows.Forms.Button()
        Me.ListBox_Log_TexteLog = New System.Windows.Forms.ListBox()
        Me.Button_Log_Save = New System.Windows.Forms.Button()
        Me.SaveFileDialog_Log = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Button_Log_ClearLog
        '
        Me.Button_Log_ClearLog.Location = New System.Drawing.Point(16, 381)
        Me.Button_Log_ClearLog.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Log_ClearLog.Name = "Button_Log_ClearLog"
        Me.Button_Log_ClearLog.Size = New System.Drawing.Size(538, 28)
        Me.Button_Log_ClearLog.TabIndex = 1
        Me.Button_Log_ClearLog.Text = "Effacer"
        Me.Button_Log_ClearLog.UseVisualStyleBackColor = True
        '
        'ListBox_Log_TexteLog
        '
        Me.ListBox_Log_TexteLog.FormattingEnabled = True
        Me.ListBox_Log_TexteLog.ItemHeight = 16
        Me.ListBox_Log_TexteLog.Location = New System.Drawing.Point(16, 12)
        Me.ListBox_Log_TexteLog.Name = "ListBox_Log_TexteLog"
        Me.ListBox_Log_TexteLog.Size = New System.Drawing.Size(539, 356)
        Me.ListBox_Log_TexteLog.TabIndex = 2
        '
        'Button_Log_Save
        '
        Me.Button_Log_Save.Enabled = False
        Me.Button_Log_Save.Location = New System.Drawing.Point(16, 417)
        Me.Button_Log_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Log_Save.Name = "Button_Log_Save"
        Me.Button_Log_Save.Size = New System.Drawing.Size(538, 28)
        Me.Button_Log_Save.TabIndex = 3
        Me.Button_Log_Save.Text = "Enregistrer"
        Me.Button_Log_Save.UseVisualStyleBackColor = True
        '
        'SaveFileDialog_Log
        '
        Me.SaveFileDialog_Log.DefaultExt = "txt"
        Me.SaveFileDialog_Log.Filter = "Fichier texte|*.txt|Tous les fichiers|*.*"
        Me.SaveFileDialog_Log.Title = "Enregistrer les logs"
        '
        'Form_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 452)
        Me.Controls.Add(Me.Button_Log_Save)
        Me.Controls.Add(Me.ListBox_Log_TexteLog)
        Me.Controls.Add(Me.Button_Log_ClearLog)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form_Log"
        Me.Text = "Log"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Log_ClearLog As Button
    Friend WithEvents ListBox_Log_TexteLog As ListBox
    Friend WithEvents Button_Log_Save As Button
    Friend WithEvents SaveFileDialog_Log As SaveFileDialog
End Class
