<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Temps_total_label = New System.Windows.Forms.Label()
        Me.LBTempsCumul = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TempsMin_label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nom_label = New System.Windows.Forms.Label()
        Me.Label_Recherche_Joueur = New System.Windows.Forms.Label()
        Me.Rechercher_btn = New System.Windows.Forms.Button()
        Me.ComboBoxRecherche = New System.Windows.Forms.ComboBox()
        Me.DuPlusFortAuPlusNul_btn = New System.Windows.Forms.Button()
        Me.duPlusNulAuPlusFort_btn = New System.Windows.Forms.Button()
        Me.Retour_btn = New System.Windows.Forms.Button()
        Me.LBPartie = New System.Windows.Forms.ListBox()
        Me.LBTemps = New System.Windows.Forms.ListBox()
        Me.LBCarre = New System.Windows.Forms.ListBox()
        Me.LBNom = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Temps_total_label
        '
        Me.Temps_total_label.AutoSize = True
        Me.Temps_total_label.Location = New System.Drawing.Point(961, 85)
        Me.Temps_total_label.Name = "Temps_total_label"
        Me.Temps_total_label.Size = New System.Drawing.Size(198, 17)
        Me.Temps_total_label.TabIndex = 48
        Me.Temps_total_label.Text = "Temps total passé sur le jeu : "
        '
        'LBTempsCumul
        '
        Me.LBTempsCumul.FormattingEnabled = True
        Me.LBTempsCumul.ItemHeight = 16
        Me.LBTempsCumul.Location = New System.Drawing.Point(1004, 131)
        Me.LBTempsCumul.Name = "LBTempsCumul"
        Me.LBTempsCumul.Size = New System.Drawing.Size(120, 116)
        Me.LBTempsCumul.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(742, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Nombre de parties jouées : "
        '
        'TempsMin_label
        '
        Me.TempsMin_label.AutoSize = True
        Me.TempsMin_label.Location = New System.Drawing.Point(535, 85)
        Me.TempsMin_label.Name = "TempsMin_label"
        Me.TempsMin_label.Size = New System.Drawing.Size(168, 17)
        Me.TempsMin_label.TabIndex = 45
        Me.TempsMin_label.Text = "Temps minimum réalisé : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nombre de carrés trouvés : "
        '
        'Nom_label
        '
        Me.Nom_label.AutoSize = True
        Me.Nom_label.Location = New System.Drawing.Point(77, 85)
        Me.Nom_label.Name = "Nom_label"
        Me.Nom_label.Size = New System.Drawing.Size(109, 17)
        Me.Nom_label.TabIndex = 43
        Me.Nom_label.Text = "Nom du joueur :"
        '
        'Label_Recherche_Joueur
        '
        Me.Label_Recherche_Joueur.AutoSize = True
        Me.Label_Recherche_Joueur.Location = New System.Drawing.Point(20, 359)
        Me.Label_Recherche_Joueur.Name = "Label_Recherche_Joueur"
        Me.Label_Recherche_Joueur.Size = New System.Drawing.Size(154, 17)
        Me.Label_Recherche_Joueur.TabIndex = 42
        Me.Label_Recherche_Joueur.Text = "Rechercher un joueur :"
        '
        'Rechercher_btn
        '
        Me.Rechercher_btn.Location = New System.Drawing.Point(336, 355)
        Me.Rechercher_btn.Name = "Rechercher_btn"
        Me.Rechercher_btn.Size = New System.Drawing.Size(121, 24)
        Me.Rechercher_btn.TabIndex = 41
        Me.Rechercher_btn.Text = "Rechercher"
        Me.Rechercher_btn.UseVisualStyleBackColor = True
        '
        'ComboBoxRecherche
        '
        Me.ComboBoxRecherche.FormattingEnabled = True
        Me.ComboBoxRecherche.Location = New System.Drawing.Point(193, 355)
        Me.ComboBoxRecherche.Name = "ComboBoxRecherche"
        Me.ComboBoxRecherche.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxRecherche.TabIndex = 40
        '
        'DuPlusFortAuPlusNul_btn
        '
        Me.DuPlusFortAuPlusNul_btn.Location = New System.Drawing.Point(916, 272)
        Me.DuPlusFortAuPlusNul_btn.Name = "DuPlusFortAuPlusNul_btn"
        Me.DuPlusFortAuPlusNul_btn.Size = New System.Drawing.Size(243, 32)
        Me.DuPlusFortAuPlusNul_btn.TabIndex = 39
        Me.DuPlusFortAuPlusNul_btn.Text = "Du plus fort au plus nul"
        Me.DuPlusFortAuPlusNul_btn.UseVisualStyleBackColor = True
        '
        'duPlusNulAuPlusFort_btn
        '
        Me.duPlusNulAuPlusFort_btn.Location = New System.Drawing.Point(642, 272)
        Me.duPlusNulAuPlusFort_btn.Name = "duPlusNulAuPlusFort_btn"
        Me.duPlusNulAuPlusFort_btn.Size = New System.Drawing.Size(268, 32)
        Me.duPlusNulAuPlusFort_btn.TabIndex = 38
        Me.duPlusNulAuPlusFort_btn.Text = "Du plus nul au plus fort"
        Me.duPlusNulAuPlusFort_btn.UseVisualStyleBackColor = True
        '
        'Retour_btn
        '
        Me.Retour_btn.Location = New System.Drawing.Point(998, 353)
        Me.Retour_btn.Name = "Retour_btn"
        Me.Retour_btn.Size = New System.Drawing.Size(161, 26)
        Me.Retour_btn.TabIndex = 37
        Me.Retour_btn.Text = "Revenir en arrière"
        Me.Retour_btn.UseVisualStyleBackColor = True
        '
        'LBPartie
        '
        Me.LBPartie.FormattingEnabled = True
        Me.LBPartie.ItemHeight = 16
        Me.LBPartie.Location = New System.Drawing.Point(779, 131)
        Me.LBPartie.Name = "LBPartie"
        Me.LBPartie.Size = New System.Drawing.Size(122, 116)
        Me.LBPartie.TabIndex = 36
        '
        'LBTemps
        '
        Me.LBTemps.FormattingEnabled = True
        Me.LBTemps.ItemHeight = 16
        Me.LBTemps.Location = New System.Drawing.Point(560, 131)
        Me.LBTemps.Name = "LBTemps"
        Me.LBTemps.Size = New System.Drawing.Size(122, 116)
        Me.LBTemps.TabIndex = 35
        '
        'LBCarre
        '
        Me.LBCarre.FormattingEnabled = True
        Me.LBCarre.ItemHeight = 16
        Me.LBCarre.Location = New System.Drawing.Point(295, 131)
        Me.LBCarre.Name = "LBCarre"
        Me.LBCarre.Size = New System.Drawing.Size(153, 116)
        Me.LBCarre.TabIndex = 34
        '
        'LBNom
        '
        Me.LBNom.FormattingEnabled = True
        Me.LBNom.ItemHeight = 16
        Me.LBNom.Location = New System.Drawing.Point(55, 131)
        Me.LBNom.Name = "LBNom"
        Me.LBNom.Size = New System.Drawing.Size(159, 116)
        Me.LBNom.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(816, 54)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Scores des différents joueurs"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Temps_total_label)
        Me.Controls.Add(Me.LBTempsCumul)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TempsMin_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nom_label)
        Me.Controls.Add(Me.Label_Recherche_Joueur)
        Me.Controls.Add(Me.Rechercher_btn)
        Me.Controls.Add(Me.ComboBoxRecherche)
        Me.Controls.Add(Me.DuPlusFortAuPlusNul_btn)
        Me.Controls.Add(Me.duPlusNulAuPlusFort_btn)
        Me.Controls.Add(Me.Retour_btn)
        Me.Controls.Add(Me.LBPartie)
        Me.Controls.Add(Me.LBTemps)
        Me.Controls.Add(Me.LBCarre)
        Me.Controls.Add(Me.LBNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Temps_total_label As Label
    Friend WithEvents LBTempsCumul As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TempsMin_label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Nom_label As Label
    Friend WithEvents Label_Recherche_Joueur As Label
    Friend WithEvents Rechercher_btn As Button
    Friend WithEvents ComboBoxRecherche As ComboBox
    Friend WithEvents DuPlusFortAuPlusNul_btn As Button
    Friend WithEvents duPlusNulAuPlusFort_btn As Button
    Friend WithEvents Retour_btn As Button
    Friend WithEvents LBPartie As ListBox
    Friend WithEvents LBTemps As ListBox
    Friend WithEvents LBCarre As ListBox
    Friend WithEvents LBNom As ListBox
    Friend WithEvents Label1 As Label
End Class
