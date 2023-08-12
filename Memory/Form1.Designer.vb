<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Quitter_btn = New System.Windows.Forms.Button()
        Me.Scores_btn = New System.Windows.Forms.Button()
        Me.Options_btn = New System.Windows.Forms.Button()
        Me.Jouer_btn = New System.Windows.Forms.Button()
        Me.Entrez_nom_label = New System.Windows.Forms.Label()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.concentration_game = New System.Windows.Forms.Label()
        Me.quatre_memory_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Quitter_btn
        '
        Me.Quitter_btn.Location = New System.Drawing.Point(166, 313)
        Me.Quitter_btn.Name = "Quitter_btn"
        Me.Quitter_btn.Size = New System.Drawing.Size(75, 33)
        Me.Quitter_btn.TabIndex = 39
        Me.Quitter_btn.Text = "Quitter"
        Me.Quitter_btn.UseVisualStyleBackColor = True
        '
        'Scores_btn
        '
        Me.Scores_btn.Location = New System.Drawing.Point(166, 269)
        Me.Scores_btn.Name = "Scores_btn"
        Me.Scores_btn.Size = New System.Drawing.Size(75, 38)
        Me.Scores_btn.TabIndex = 38
        Me.Scores_btn.Text = "Scores"
        Me.Scores_btn.UseVisualStyleBackColor = True
        '
        'Options_btn
        '
        Me.Options_btn.Location = New System.Drawing.Point(166, 228)
        Me.Options_btn.Name = "Options_btn"
        Me.Options_btn.Size = New System.Drawing.Size(75, 35)
        Me.Options_btn.TabIndex = 37
        Me.Options_btn.Text = "Options"
        Me.Options_btn.UseVisualStyleBackColor = True
        '
        'Jouer_btn
        '
        Me.Jouer_btn.Enabled = False
        Me.Jouer_btn.Location = New System.Drawing.Point(166, 188)
        Me.Jouer_btn.Name = "Jouer_btn"
        Me.Jouer_btn.Size = New System.Drawing.Size(75, 34)
        Me.Jouer_btn.TabIndex = 36
        Me.Jouer_btn.Text = "Jouer"
        Me.Jouer_btn.UseVisualStyleBackColor = True
        '
        'Entrez_nom_label
        '
        Me.Entrez_nom_label.AutoSize = True
        Me.Entrez_nom_label.Location = New System.Drawing.Point(36, 130)
        Me.Entrez_nom_label.Name = "Entrez_nom_label"
        Me.Entrez_nom_label.Size = New System.Drawing.Size(124, 17)
        Me.Entrez_nom_label.TabIndex = 35
        Me.Entrez_nom_label.Text = "Entrez votre nom :"
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(166, 127)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(233, 24)
        Me.ComboBoxNom.TabIndex = 34
        '
        'concentration_game
        '
        Me.concentration_game.AutoSize = True
        Me.concentration_game.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.concentration_game.Location = New System.Drawing.Point(234, 75)
        Me.concentration_game.Name = "concentration_game"
        Me.concentration_game.Size = New System.Drawing.Size(145, 17)
        Me.concentration_game.TabIndex = 33
        Me.concentration_game.Text = "a concentration game"
        '
        'quatre_memory_label
        '
        Me.quatre_memory_label.AutoSize = True
        Me.quatre_memory_label.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quatre_memory_label.Location = New System.Drawing.Point(30, 21)
        Me.quatre_memory_label.Name = "quatre_memory_label"
        Me.quatre_memory_label.Size = New System.Drawing.Size(263, 54)
        Me.quatre_memory_label.TabIndex = 32
        Me.quatre_memory_label.Text = "4 Memory"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 422)
        Me.Controls.Add(Me.Quitter_btn)
        Me.Controls.Add(Me.Scores_btn)
        Me.Controls.Add(Me.Options_btn)
        Me.Controls.Add(Me.Jouer_btn)
        Me.Controls.Add(Me.Entrez_nom_label)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.concentration_game)
        Me.Controls.Add(Me.quatre_memory_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Quitter_btn As Button
    Friend WithEvents Scores_btn As Button
    Friend WithEvents Options_btn As Button
    Friend WithEvents Jouer_btn As Button
    Friend WithEvents Entrez_nom_label As Label
    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents concentration_game As Label
    Friend WithEvents quatre_memory_label As Label
End Class
