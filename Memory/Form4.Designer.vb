<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TextBoxEmplacement = New System.Windows.Forms.TextBox()
        Me.modify_emplacement_btn = New System.Windows.Forms.Button()
        Me.emplacement_actuel_label = New System.Windows.Forms.Label()
        Me.CheckBoxPause = New System.Windows.Forms.CheckBox()
        Me.ActivatePauseLabel = New System.Windows.Forms.Label()
        Me.choixThemeLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.theme_foot_rdbutton = New System.Windows.Forms.RadioButton()
        Me.theme_harry_potter_rdbutton = New System.Windows.Forms.RadioButton()
        Me.theme_defaut_rdbutton = New System.Windows.Forms.RadioButton()
        Me.themeNoel_rdbutton = New System.Windows.Forms.RadioButton()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.time_desactivate_rdbutton = New System.Windows.Forms.RadioButton()
        Me.trente_secondes_rdbutton = New System.Windows.Forms.RadioButton()
        Me.OneMinute_rdbutton = New System.Windows.Forms.RadioButton()
        Me.OneMinuteAndHalf_rdButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.choix_temps_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxEmplacement
        '
        Me.TextBoxEmplacement.Enabled = False
        Me.TextBoxEmplacement.Location = New System.Drawing.Point(222, 364)
        Me.TextBoxEmplacement.Name = "TextBoxEmplacement"
        Me.TextBoxEmplacement.Size = New System.Drawing.Size(617, 22)
        Me.TextBoxEmplacement.TabIndex = 34
        '
        'modify_emplacement_btn
        '
        Me.modify_emplacement_btn.Location = New System.Drawing.Point(222, 397)
        Me.modify_emplacement_btn.Name = "modify_emplacement_btn"
        Me.modify_emplacement_btn.Size = New System.Drawing.Size(294, 33)
        Me.modify_emplacement_btn.TabIndex = 33
        Me.modify_emplacement_btn.Text = "Modifier l'emplacement du fichier"
        Me.modify_emplacement_btn.UseVisualStyleBackColor = True
        '
        'emplacement_actuel_label
        '
        Me.emplacement_actuel_label.AutoSize = True
        Me.emplacement_actuel_label.Location = New System.Drawing.Point(54, 364)
        Me.emplacement_actuel_label.Name = "emplacement_actuel_label"
        Me.emplacement_actuel_label.Size = New System.Drawing.Size(147, 17)
        Me.emplacement_actuel_label.TabIndex = 32
        Me.emplacement_actuel_label.Text = "Emplacement actuel : "
        '
        'CheckBoxPause
        '
        Me.CheckBoxPause.AutoSize = True
        Me.CheckBoxPause.Location = New System.Drawing.Point(305, 312)
        Me.CheckBoxPause.Name = "CheckBoxPause"
        Me.CheckBoxPause.Size = New System.Drawing.Size(119, 21)
        Me.CheckBoxPause.TabIndex = 31
        Me.CheckBoxPause.Text = "Bouton Pause"
        Me.CheckBoxPause.UseVisualStyleBackColor = True
        '
        'ActivatePauseLabel
        '
        Me.ActivatePauseLabel.AutoSize = True
        Me.ActivatePauseLabel.Location = New System.Drawing.Point(219, 312)
        Me.ActivatePauseLabel.Name = "ActivatePauseLabel"
        Me.ActivatePauseLabel.Size = New System.Drawing.Size(59, 17)
        Me.ActivatePauseLabel.TabIndex = 30
        Me.ActivatePauseLabel.Text = "Activer :"
        '
        'choixThemeLabel
        '
        Me.choixThemeLabel.AutoSize = True
        Me.choixThemeLabel.Location = New System.Drawing.Point(40, 253)
        Me.choixThemeLabel.Name = "choixThemeLabel"
        Me.choixThemeLabel.Size = New System.Drawing.Size(238, 17)
        Me.choixThemeLabel.TabIndex = 29
        Me.choixThemeLabel.Text = "Choisissez un thème de votre choix :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.theme_foot_rdbutton)
        Me.GroupBox2.Controls.Add(Me.theme_harry_potter_rdbutton)
        Me.GroupBox2.Controls.Add(Me.theme_defaut_rdbutton)
        Me.GroupBox2.Controls.Add(Me.themeNoel_rdbutton)
        Me.GroupBox2.Location = New System.Drawing.Point(296, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 63)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'theme_foot_rdbutton
        '
        Me.theme_foot_rdbutton.AutoSize = True
        Me.theme_foot_rdbutton.Location = New System.Drawing.Point(360, 21)
        Me.theme_foot_rdbutton.Name = "theme_foot_rdbutton"
        Me.theme_foot_rdbutton.Size = New System.Drawing.Size(127, 21)
        Me.theme_foot_rdbutton.TabIndex = 4
        Me.theme_foot_rdbutton.TabStop = True
        Me.theme_foot_rdbutton.Text = "Thème Football"
        Me.theme_foot_rdbutton.UseVisualStyleBackColor = True
        '
        'theme_harry_potter_rdbutton
        '
        Me.theme_harry_potter_rdbutton.AutoSize = True
        Me.theme_harry_potter_rdbutton.Location = New System.Drawing.Point(521, 21)
        Me.theme_harry_potter_rdbutton.Name = "theme_harry_potter_rdbutton"
        Me.theme_harry_potter_rdbutton.Size = New System.Drawing.Size(154, 21)
        Me.theme_harry_potter_rdbutton.TabIndex = 3
        Me.theme_harry_potter_rdbutton.TabStop = True
        Me.theme_harry_potter_rdbutton.Text = "Thème Harry Potter"
        Me.theme_harry_potter_rdbutton.UseVisualStyleBackColor = True
        '
        'theme_defaut_rdbutton
        '
        Me.theme_defaut_rdbutton.AutoSize = True
        Me.theme_defaut_rdbutton.Location = New System.Drawing.Point(15, 21)
        Me.theme_defaut_rdbutton.Name = "theme_defaut_rdbutton"
        Me.theme_defaut_rdbutton.Size = New System.Drawing.Size(142, 21)
        Me.theme_defaut_rdbutton.TabIndex = 2
        Me.theme_defaut_rdbutton.TabStop = True
        Me.theme_defaut_rdbutton.Text = "Thème par défaut"
        Me.theme_defaut_rdbutton.UseVisualStyleBackColor = True
        '
        'themeNoel_rdbutton
        '
        Me.themeNoel_rdbutton.AutoSize = True
        Me.themeNoel_rdbutton.Location = New System.Drawing.Point(196, 21)
        Me.themeNoel_rdbutton.Name = "themeNoel_rdbutton"
        Me.themeNoel_rdbutton.Size = New System.Drawing.Size(126, 21)
        Me.themeNoel_rdbutton.TabIndex = 1
        Me.themeNoel_rdbutton.TabStop = True
        Me.themeNoel_rdbutton.Text = "Thème de Noël"
        Me.themeNoel_rdbutton.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(857, 447)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(183, 30)
        Me.back_btn.TabIndex = 28
        Me.back_btn.Text = "Revenir en arrière"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'time_desactivate_rdbutton
        '
        Me.time_desactivate_rdbutton.AutoSize = True
        Me.time_desactivate_rdbutton.Location = New System.Drawing.Point(398, 21)
        Me.time_desactivate_rdbutton.Name = "time_desactivate_rdbutton"
        Me.time_desactivate_rdbutton.Size = New System.Drawing.Size(89, 21)
        Me.time_desactivate_rdbutton.TabIndex = 3
        Me.time_desactivate_rdbutton.TabStop = True
        Me.time_desactivate_rdbutton.Text = "désactivé"
        Me.time_desactivate_rdbutton.UseVisualStyleBackColor = True
        '
        'trente_secondes_rdbutton
        '
        Me.trente_secondes_rdbutton.AutoSize = True
        Me.trente_secondes_rdbutton.Location = New System.Drawing.Point(15, 21)
        Me.trente_secondes_rdbutton.Name = "trente_secondes_rdbutton"
        Me.trente_secondes_rdbutton.Size = New System.Drawing.Size(65, 21)
        Me.trente_secondes_rdbutton.TabIndex = 2
        Me.trente_secondes_rdbutton.TabStop = True
        Me.trente_secondes_rdbutton.Text = "00:30"
        Me.trente_secondes_rdbutton.UseVisualStyleBackColor = True
        '
        'OneMinute_rdbutton
        '
        Me.OneMinute_rdbutton.AutoSize = True
        Me.OneMinute_rdbutton.Location = New System.Drawing.Point(139, 21)
        Me.OneMinute_rdbutton.Name = "OneMinute_rdbutton"
        Me.OneMinute_rdbutton.Size = New System.Drawing.Size(57, 21)
        Me.OneMinute_rdbutton.TabIndex = 1
        Me.OneMinute_rdbutton.TabStop = True
        Me.OneMinute_rdbutton.Text = "1:00"
        Me.OneMinute_rdbutton.UseVisualStyleBackColor = True
        '
        'OneMinuteAndHalf_rdButton
        '
        Me.OneMinuteAndHalf_rdButton.AutoSize = True
        Me.OneMinuteAndHalf_rdButton.Location = New System.Drawing.Point(247, 21)
        Me.OneMinuteAndHalf_rdButton.Name = "OneMinuteAndHalf_rdButton"
        Me.OneMinuteAndHalf_rdButton.Size = New System.Drawing.Size(57, 21)
        Me.OneMinuteAndHalf_rdButton.TabIndex = 0
        Me.OneMinuteAndHalf_rdButton.TabStop = True
        Me.OneMinuteAndHalf_rdButton.Text = "1:30"
        Me.OneMinuteAndHalf_rdButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.time_desactivate_rdbutton)
        Me.GroupBox1.Controls.Add(Me.trente_secondes_rdbutton)
        Me.GroupBox1.Controls.Add(Me.OneMinute_rdbutton)
        Me.GroupBox1.Controls.Add(Me.OneMinuteAndHalf_rdButton)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 81)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'choix_temps_label
        '
        Me.choix_temps_label.AutoSize = True
        Me.choix_temps_label.Location = New System.Drawing.Point(51, 152)
        Me.choix_temps_label.Name = "choix_temps_label"
        Me.choix_temps_label.Size = New System.Drawing.Size(241, 17)
        Me.choix_temps_label.TabIndex = 27
        Me.choix_temps_label.Text = "Choisissez un temps de votre choix : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 54)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Options de jeu"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEmplacement)
        Me.Controls.Add(Me.modify_emplacement_btn)
        Me.Controls.Add(Me.emplacement_actuel_label)
        Me.Controls.Add(Me.CheckBoxPause)
        Me.Controls.Add(Me.ActivatePauseLabel)
        Me.Controls.Add(Me.choixThemeLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.choix_temps_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxEmplacement As TextBox
    Friend WithEvents modify_emplacement_btn As Button
    Friend WithEvents emplacement_actuel_label As Label
    Friend WithEvents CheckBoxPause As CheckBox
    Friend WithEvents ActivatePauseLabel As Label
    Friend WithEvents choixThemeLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents theme_foot_rdbutton As RadioButton
    Friend WithEvents theme_harry_potter_rdbutton As RadioButton
    Friend WithEvents theme_defaut_rdbutton As RadioButton
    Friend WithEvents themeNoel_rdbutton As RadioButton
    Friend WithEvents back_btn As Button
    Friend WithEvents time_desactivate_rdbutton As RadioButton
    Friend WithEvents trente_secondes_rdbutton As RadioButton
    Friend WithEvents OneMinute_rdbutton As RadioButton
    Friend WithEvents OneMinuteAndHalf_rdButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents choix_temps_label As Label
    Friend WithEvents Label1 As Label
End Class
