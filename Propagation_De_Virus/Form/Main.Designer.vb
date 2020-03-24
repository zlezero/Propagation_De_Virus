<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel_Main_Render = New System.Windows.Forms.Panel()
        Me.GroupBox_Main_Controles = New System.Windows.Forms.GroupBox()
        Me.Button_Main_Stop = New System.Windows.Forms.Button()
        Me.Button_Main_Pause = New System.Windows.Forms.Button()
        Me.Button_Main_Launch = New System.Windows.Forms.Button()
        Me.MenuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox_Main_Compteurs = New System.Windows.Forms.GroupBox()
        Me.Label_Main_Compteurs_Valeur_Deces = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_Deces = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_Valeur_SHFo = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_SHFo = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_Valeur_SHFa = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_SHFa = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_Valeur_SNH = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_SNH = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_Valeur_A = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_A = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_Valeur_NI = New System.Windows.Forms.Label()
        Me.Label_Main_Compteurs_NI = New System.Windows.Forms.Label()
        Me.Button_Main_SimulateOneTurn = New System.Windows.Forms.Button()
        Me.ToolTip_Main = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox_Main_Controles.SuspendLayout()
        Me.MenuStrip_Main.SuspendLayout()
        Me.GroupBox_Main_Compteurs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Main_Render
        '
        Me.Panel_Main_Render.Location = New System.Drawing.Point(47, 59)
        Me.Panel_Main_Render.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_Main_Render.Name = "Panel_Main_Render"
        Me.Panel_Main_Render.Size = New System.Drawing.Size(989, 406)
        Me.Panel_Main_Render.TabIndex = 0
        '
        'GroupBox_Main_Controles
        '
        Me.GroupBox_Main_Controles.Controls.Add(Me.Button_Main_SimulateOneTurn)
        Me.GroupBox_Main_Controles.Controls.Add(Me.Button_Main_Stop)
        Me.GroupBox_Main_Controles.Controls.Add(Me.Button_Main_Pause)
        Me.GroupBox_Main_Controles.Controls.Add(Me.Button_Main_Launch)
        Me.GroupBox_Main_Controles.Location = New System.Drawing.Point(47, 508)
        Me.GroupBox_Main_Controles.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Main_Controles.Name = "GroupBox_Main_Controles"
        Me.GroupBox_Main_Controles.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Main_Controles.Size = New System.Drawing.Size(586, 123)
        Me.GroupBox_Main_Controles.TabIndex = 1
        Me.GroupBox_Main_Controles.TabStop = False
        Me.GroupBox_Main_Controles.Text = "Contrôles"
        '
        'Button_Main_Stop
        '
        Me.Button_Main_Stop.Enabled = False
        Me.Button_Main_Stop.Location = New System.Drawing.Point(448, 47)
        Me.Button_Main_Stop.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Main_Stop.Name = "Button_Main_Stop"
        Me.Button_Main_Stop.Size = New System.Drawing.Size(113, 33)
        Me.Button_Main_Stop.TabIndex = 2
        Me.Button_Main_Stop.Text = "Stop"
        Me.Button_Main_Stop.UseVisualStyleBackColor = True
        '
        'Button_Main_Pause
        '
        Me.Button_Main_Pause.Enabled = False
        Me.Button_Main_Pause.Location = New System.Drawing.Point(175, 47)
        Me.Button_Main_Pause.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Main_Pause.Name = "Button_Main_Pause"
        Me.Button_Main_Pause.Size = New System.Drawing.Size(113, 33)
        Me.Button_Main_Pause.TabIndex = 1
        Me.Button_Main_Pause.Text = "Pause"
        Me.Button_Main_Pause.UseVisualStyleBackColor = True
        '
        'Button_Main_Launch
        '
        Me.Button_Main_Launch.Location = New System.Drawing.Point(33, 47)
        Me.Button_Main_Launch.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Main_Launch.Name = "Button_Main_Launch"
        Me.Button_Main_Launch.Size = New System.Drawing.Size(113, 33)
        Me.Button_Main_Launch.TabIndex = 0
        Me.Button_Main_Launch.Text = "Lancer"
        Me.Button_Main_Launch.UseVisualStyleBackColor = True
        '
        'MenuStrip_Main
        '
        Me.MenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.LogToolStripMenuItem})
        Me.MenuStrip_Main.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_Main.Name = "MenuStrip_Main"
        Me.MenuStrip_Main.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip_Main.Size = New System.Drawing.Size(1073, 24)
        Me.MenuStrip_Main.TabIndex = 2
        Me.MenuStrip_Main.Text = "Main_MenuStrip"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'GroupBox_Main_Compteurs
        '
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_Valeur_Deces)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_Deces)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_Valeur_SHFo)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_SHFo)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_Valeur_SHFa)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_SHFa)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_Valeur_SNH)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_SNH)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_Valeur_A)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_A)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_Valeur_NI)
        Me.GroupBox_Main_Compteurs.Controls.Add(Me.Label_Main_Compteurs_NI)
        Me.GroupBox_Main_Compteurs.Location = New System.Drawing.Point(640, 508)
        Me.GroupBox_Main_Compteurs.Name = "GroupBox_Main_Compteurs"
        Me.GroupBox_Main_Compteurs.Size = New System.Drawing.Size(396, 123)
        Me.GroupBox_Main_Compteurs.TabIndex = 3
        Me.GroupBox_Main_Compteurs.TabStop = False
        Me.GroupBox_Main_Compteurs.Text = "Compteurs"
        '
        'Label_Main_Compteurs_Valeur_Deces
        '
        Me.Label_Main_Compteurs_Valeur_Deces.AutoSize = True
        Me.Label_Main_Compteurs_Valeur_Deces.ForeColor = System.Drawing.Color.Black
        Me.Label_Main_Compteurs_Valeur_Deces.Location = New System.Drawing.Point(316, 69)
        Me.Label_Main_Compteurs_Valeur_Deces.Name = "Label_Main_Compteurs_Valeur_Deces"
        Me.Label_Main_Compteurs_Valeur_Deces.Size = New System.Drawing.Size(15, 16)
        Me.Label_Main_Compteurs_Valeur_Deces.TabIndex = 11
        Me.Label_Main_Compteurs_Valeur_Deces.Text = "0"
        '
        'Label_Main_Compteurs_Deces
        '
        Me.Label_Main_Compteurs_Deces.AutoSize = True
        Me.Label_Main_Compteurs_Deces.ForeColor = System.Drawing.Color.Black
        Me.Label_Main_Compteurs_Deces.Location = New System.Drawing.Point(311, 47)
        Me.Label_Main_Compteurs_Deces.Name = "Label_Main_Compteurs_Deces"
        Me.Label_Main_Compteurs_Deces.Size = New System.Drawing.Size(54, 16)
        Me.Label_Main_Compteurs_Deces.TabIndex = 10
        Me.Label_Main_Compteurs_Deces.Text = "Décès :"
        Me.ToolTip_Main.SetToolTip(Me.Label_Main_Compteurs_Deces, "Décédé")
        '
        'Label_Main_Compteurs_Valeur_SHFo
        '
        Me.Label_Main_Compteurs_Valeur_SHFo.AutoSize = True
        Me.Label_Main_Compteurs_Valeur_SHFo.ForeColor = System.Drawing.Color.Magenta
        Me.Label_Main_Compteurs_Valeur_SHFo.Location = New System.Drawing.Point(263, 69)
        Me.Label_Main_Compteurs_Valeur_SHFo.Name = "Label_Main_Compteurs_Valeur_SHFo"
        Me.Label_Main_Compteurs_Valeur_SHFo.Size = New System.Drawing.Size(15, 16)
        Me.Label_Main_Compteurs_Valeur_SHFo.TabIndex = 9
        Me.Label_Main_Compteurs_Valeur_SHFo.Text = "0"
        '
        'Label_Main_Compteurs_SHFo
        '
        Me.Label_Main_Compteurs_SHFo.AutoSize = True
        Me.Label_Main_Compteurs_SHFo.ForeColor = System.Drawing.Color.Magenta
        Me.Label_Main_Compteurs_SHFo.Location = New System.Drawing.Point(257, 47)
        Me.Label_Main_Compteurs_SHFo.Name = "Label_Main_Compteurs_SHFo"
        Me.Label_Main_Compteurs_SHFo.Size = New System.Drawing.Size(43, 16)
        Me.Label_Main_Compteurs_SHFo.TabIndex = 8
        Me.Label_Main_Compteurs_SHFo.Text = "SHFo"
        Me.ToolTip_Main.SetToolTip(Me.Label_Main_Compteurs_SHFo, "Infecté symptomatique hospitalisé fortement")
        '
        'Label_Main_Compteurs_Valeur_SHFa
        '
        Me.Label_Main_Compteurs_Valeur_SHFa.AutoSize = True
        Me.Label_Main_Compteurs_Valeur_SHFa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Main_Compteurs_Valeur_SHFa.Location = New System.Drawing.Point(206, 69)
        Me.Label_Main_Compteurs_Valeur_SHFa.Name = "Label_Main_Compteurs_Valeur_SHFa"
        Me.Label_Main_Compteurs_Valeur_SHFa.Size = New System.Drawing.Size(15, 16)
        Me.Label_Main_Compteurs_Valeur_SHFa.TabIndex = 7
        Me.Label_Main_Compteurs_Valeur_SHFa.Text = "0"
        '
        'Label_Main_Compteurs_SHFa
        '
        Me.Label_Main_Compteurs_SHFa.AutoSize = True
        Me.Label_Main_Compteurs_SHFa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Main_Compteurs_SHFa.Location = New System.Drawing.Point(201, 47)
        Me.Label_Main_Compteurs_SHFa.Name = "Label_Main_Compteurs_SHFa"
        Me.Label_Main_Compteurs_SHFa.Size = New System.Drawing.Size(43, 16)
        Me.Label_Main_Compteurs_SHFa.TabIndex = 6
        Me.Label_Main_Compteurs_SHFa.Text = "SHFa"
        Me.ToolTip_Main.SetToolTip(Me.Label_Main_Compteurs_SHFa, "Infecté symptomatique hospitalisé faiblement")
        '
        'Label_Main_Compteurs_Valeur_SNH
        '
        Me.Label_Main_Compteurs_Valeur_SNH.AutoSize = True
        Me.Label_Main_Compteurs_Valeur_SNH.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label_Main_Compteurs_Valeur_SNH.Location = New System.Drawing.Point(150, 69)
        Me.Label_Main_Compteurs_Valeur_SNH.Name = "Label_Main_Compteurs_Valeur_SNH"
        Me.Label_Main_Compteurs_Valeur_SNH.Size = New System.Drawing.Size(15, 16)
        Me.Label_Main_Compteurs_Valeur_SNH.TabIndex = 5
        Me.Label_Main_Compteurs_Valeur_SNH.Text = "0"
        '
        'Label_Main_Compteurs_SNH
        '
        Me.Label_Main_Compteurs_SNH.AutoSize = True
        Me.Label_Main_Compteurs_SNH.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label_Main_Compteurs_SNH.Location = New System.Drawing.Point(144, 47)
        Me.Label_Main_Compteurs_SNH.Name = "Label_Main_Compteurs_SNH"
        Me.Label_Main_Compteurs_SNH.Size = New System.Drawing.Size(37, 16)
        Me.Label_Main_Compteurs_SNH.TabIndex = 4
        Me.Label_Main_Compteurs_SNH.Text = "SNH"
        Me.ToolTip_Main.SetToolTip(Me.Label_Main_Compteurs_SNH, "Infecté symptomatique non hospitalisé")
        '
        'Label_Main_Compteurs_Valeur_A
        '
        Me.Label_Main_Compteurs_Valeur_A.AutoSize = True
        Me.Label_Main_Compteurs_Valeur_A.ForeColor = System.Drawing.Color.Red
        Me.Label_Main_Compteurs_Valeur_A.Location = New System.Drawing.Point(95, 69)
        Me.Label_Main_Compteurs_Valeur_A.Name = "Label_Main_Compteurs_Valeur_A"
        Me.Label_Main_Compteurs_Valeur_A.Size = New System.Drawing.Size(15, 16)
        Me.Label_Main_Compteurs_Valeur_A.TabIndex = 3
        Me.Label_Main_Compteurs_Valeur_A.Text = "0"
        '
        'Label_Main_Compteurs_A
        '
        Me.Label_Main_Compteurs_A.AutoSize = True
        Me.Label_Main_Compteurs_A.ForeColor = System.Drawing.Color.Red
        Me.Label_Main_Compteurs_A.Location = New System.Drawing.Point(95, 47)
        Me.Label_Main_Compteurs_A.Name = "Label_Main_Compteurs_A"
        Me.Label_Main_Compteurs_A.Size = New System.Drawing.Size(17, 16)
        Me.Label_Main_Compteurs_A.TabIndex = 2
        Me.Label_Main_Compteurs_A.Text = "A"
        Me.ToolTip_Main.SetToolTip(Me.Label_Main_Compteurs_A, "Infecté asymptotique")
        '
        'Label_Main_Compteurs_Valeur_NI
        '
        Me.Label_Main_Compteurs_Valeur_NI.AutoSize = True
        Me.Label_Main_Compteurs_Valeur_NI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Main_Compteurs_Valeur_NI.Location = New System.Drawing.Point(37, 69)
        Me.Label_Main_Compteurs_Valeur_NI.Name = "Label_Main_Compteurs_Valeur_NI"
        Me.Label_Main_Compteurs_Valeur_NI.Size = New System.Drawing.Size(15, 16)
        Me.Label_Main_Compteurs_Valeur_NI.TabIndex = 1
        Me.Label_Main_Compteurs_Valeur_NI.Text = "0"
        '
        'Label_Main_Compteurs_NI
        '
        Me.Label_Main_Compteurs_NI.AutoSize = True
        Me.Label_Main_Compteurs_NI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Main_Compteurs_NI.Location = New System.Drawing.Point(36, 47)
        Me.Label_Main_Compteurs_NI.Name = "Label_Main_Compteurs_NI"
        Me.Label_Main_Compteurs_NI.Size = New System.Drawing.Size(21, 16)
        Me.Label_Main_Compteurs_NI.TabIndex = 0
        Me.Label_Main_Compteurs_NI.Text = "NI"
        Me.ToolTip_Main.SetToolTip(Me.Label_Main_Compteurs_NI, "Non infecté")
        '
        'Button_Main_SimulateOneTurn
        '
        Me.Button_Main_SimulateOneTurn.Enabled = False
        Me.Button_Main_SimulateOneTurn.Location = New System.Drawing.Point(315, 47)
        Me.Button_Main_SimulateOneTurn.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Main_SimulateOneTurn.Name = "Button_Main_SimulateOneTurn"
        Me.Button_Main_SimulateOneTurn.Size = New System.Drawing.Size(113, 33)
        Me.Button_Main_SimulateOneTurn.TabIndex = 3
        Me.Button_Main_SimulateOneTurn.Text = "Simuler un tour"
        Me.Button_Main_SimulateOneTurn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 645)
        Me.Controls.Add(Me.GroupBox_Main_Compteurs)
        Me.Controls.Add(Me.GroupBox_Main_Controles)
        Me.Controls.Add(Me.Panel_Main_Render)
        Me.Controls.Add(Me.MenuStrip_Main)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip_Main
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Propagation de Virus"
        Me.GroupBox_Main_Controles.ResumeLayout(False)
        Me.MenuStrip_Main.ResumeLayout(False)
        Me.MenuStrip_Main.PerformLayout()
        Me.GroupBox_Main_Compteurs.ResumeLayout(False)
        Me.GroupBox_Main_Compteurs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Main_Render As Panel
    Friend WithEvents GroupBox_Main_Controles As GroupBox
    Friend WithEvents MenuStrip_Main As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Main_Launch As Button
    Friend WithEvents Button_Main_Stop As Button
    Friend WithEvents Button_Main_Pause As Button
    Friend WithEvents GroupBox_Main_Compteurs As GroupBox
    Friend WithEvents Label_Main_Compteurs_Valeur_Deces As Label
    Friend WithEvents Label_Main_Compteurs_Deces As Label
    Friend WithEvents Label_Main_Compteurs_Valeur_SHFo As Label
    Friend WithEvents Label_Main_Compteurs_SHFo As Label
    Friend WithEvents Label_Main_Compteurs_Valeur_SHFa As Label
    Friend WithEvents Label_Main_Compteurs_SHFa As Label
    Friend WithEvents Label_Main_Compteurs_Valeur_SNH As Label
    Friend WithEvents Label_Main_Compteurs_SNH As Label
    Friend WithEvents Label_Main_Compteurs_Valeur_A As Label
    Friend WithEvents Label_Main_Compteurs_A As Label
    Friend WithEvents Label_Main_Compteurs_Valeur_NI As Label
    Friend WithEvents Label_Main_Compteurs_NI As Label
    Friend WithEvents LogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Main_SimulateOneTurn As Button
    Friend WithEvents ToolTip_Main As ToolTip
End Class
