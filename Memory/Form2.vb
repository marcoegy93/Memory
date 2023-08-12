Imports System.ComponentModel

Public Class Form2

    Public nbCarre As Integer = 0
    Public nbPartieJouee As Integer = 0
    Dim LabelClique As Label
    Public tempsCarre As Date
    Public TempsRestant As Date
    Dim Tempspasse As Date
    Dim Random As New Random
    Dim compteurCartesRetournées = 0
    Public theme As String = "Images"
    Dim StockCartesRetournees(3) As Label
    Dim nombres() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}
    Dim pause As Integer = 0
    Dim tabImage() As Image


    Dim tabName() As String = {"Card0", "Card1", "Card2", "Card3", "Card4", "Card0", "Card1", "Card2", "Card3", "Card4", "Card0", "Card1", "Card2", "Card3", "Card4", "Card0", "Card1", "Card2", "Card3", "Card4"}

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ChiffreImage = 0
        pause_btn.Enabled = False
        pause_btn.Visible = False 'par défaut, il n'y a pas de bouton pause
        choix() 'on charge les choix fait dans le menu options
        MelangerCartes() 'on mélange les cartes(tableau de nombres)
        'toutes les cartes sont retournés et un nombre est attribué à chaque carte
        For Each label As Label In TableLayoutPanelLabelImage.Controls
            label.Image = Image.FromFile(theme & "/BackCard.png")
            label.Name = "BackCard"
            label.Tag = ChiffreImage
            ChiffreImage += 1
        Next
        'on charge les cartes avec le thème choisi
        tabImage = {Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png"),
        Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png"),
        Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png"),
        Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png")}
    End Sub

    Private Sub AssignerImage(LabelImage As Label)
        Dim randomNumber As Integer = nombres(LabelImage.Tag) 'on attribue à une image un  numéro du tableau nombres() qui a étéb mélangé au chargement
        LabelImage.Image = tabImage(randomNumber) 'on lui assgine une image dans le tableau des images
        LabelImage.Name = tabName(randomNumber) ''on lui assgine le nom correspondant dans le tableau des noms

    End Sub

    Private Sub Abandon_btn_Click(sender As Object, e As EventArgs) Handles Abandon_btn.Click 'abandonne le jeu
        'arrête les deux timers
        Timer1.Stop()
        Timer2.Stop()
        Dim s As String = MsgBox("Voulez-vous abandonner la partie en cours ?",
        MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmation") 'msgBox pour confirmation d'abandon
        If (s = vbYes) Then
            'on enregistre les données du joueur s'il a découvert au moins 1 carré
            If nbCarre < 5 And nbCarre > 0 Then
                MsgBox("Tu as abandonné... mais tu as découvert " & nbCarre & " carré(s) en " & tempsCarre & " seconde(s) !", MsgBoxStyle.Information, "Score")
                Module1.enregistrement(Form1.ComboBoxNom, nbCarre, tempsCarre, nbPartieJouee)
                Me.Close()
                Form1.Show()
                'on enregistre les données du joueur même s'il n'a décourvert aucun carré
            ElseIf nbCarre = 0 Then
                MsgBox("Tu as abandonné...", MsgBoxStyle.Critical, "Abandon")
                Module1.enregistrement(Form1.ComboBoxNom, nbCarre, Tempspasse, nbPartieJouee)
                Me.Close()
                Form1.Show()
            End If
        ElseIf s = vbNo Then 'sinon si on appuie sur Non, on redémarre les deux timers
            Timer1.Start()
            Timer2.Start()
        End If
    End Sub




    Private Sub Joueur(sender As Object, e As EventArgs) Handles Joueur_label.VisibleChanged
        Joueur_label.Text = "Joueur : " & Form1.ComboBoxNom.Text 'on affiche le nom du joueur
    End Sub

    Sub EchangerPositionNombres(nombres As Integer(), i As Integer, j As Integer) 'on échange de postion les nombres dans la tableau nombres entre eux
        Dim temp
        temp = nombres(i)
        nombres(i) = nombres(j)
        nombres(j) = temp
    End Sub

    Sub MelangerCartes() 'on mélange notre tableau de nombres
        For i = 0 To nombres.Length - 1
            EchangerPositionNombres(nombres, i, Random.Next(0, nombres.Length - 1))
        Next
    End Sub

    Private Sub LabelCarte_Click(sender As Object, e As EventArgs) Handles LabelCarte1.Click, LabelCarte2.Click, LabelCarte3.Click, LabelCarte4.Click, LabelCarte5.Click, LabelCarte6.Click, LabelCarte7.Click, LabelCarte8.Click, LabelCarte9.Click, LabelCarte10.Click, LabelCarte11.Click, LabelCarte12.Click, LabelCarte13.Click, LabelCarte14.Click, LabelCarte15.Click, LabelCarte16.Click, LabelCarte17.Click, LabelCarte18.Click, LabelCarte19.Click, LabelCarte20.Click
        pause_btn.Enabled = True 'active le bouton pause à l'appui sur une carte
        If LabelTimer.Visible <> False Then 'Si le timer n'est pas désactivé, on démarre le timer
            Timer1.Start()
        End If
        Timer2.Start() 'on démarre en parrallèle le timer2 qui va enregistrer le temps passé sur le temps sans devoir faire de soustractions sur le timer 1
        AssignerImage(sender) 'on assigne à un label une image et un numéro spécifique
        LabelClique = sender 'LabelClique prend la valur du nouveau label sur lequel on a appuyé
        comparaison(sender) 'on compare lles cartes entre elles

    End Sub

    Private Sub comparaison(LabelImage As Label)
        CompteurCartes(LabelImage) 'on compte le nombre de cartes retournées
        If StockCartesRetournees(1) IsNot Nothing Then 'évite une NullReferenceException
            If StockCartesRetournees(0).Name <> StockCartesRetournees(1).Name Then
                CompareDeuxCartes() 'on compare les deux cartes retournées
                Exit Sub
            End If
        End If
        If StockCartesRetournees(2) IsNot Nothing Then 'évite une NullReferenceException
            If StockCartesRetournees(1).Name <> StockCartesRetournees(2).Name Then
                CompareTroisCartes() 'on compare les trois cartes retournées(seulement la 2 et la 3, si on arrive à là, les cartes 1 et 2 sont identiques)
                Exit Sub
            End If
        End If
        If StockCartesRetournees(3) IsNot Nothing Then 'évite une NullReferenceException
            If StockCartesRetournees(2).Name <> StockCartesRetournees(3).Name Then
                CompareQuatreCartes() 'on compare les quatre cartes retournées(seulement la 3 et la 4, si on arrive à là, les cartes 1,2 et 3 sont identiques)
                Exit Sub
            Else
                CarreComplete() 'enregistre le nouveau carrés complétés et désactive les labels
            End If
        End If

    End Sub

    Private Sub CompareDeuxCartes()
        Task.Delay(400).Wait() 'appelle un timer externe pour marquer un temps de 400ms avant de retourner les cartes
        RetournerCarte() 'retoune toutes les cartes activés
        compteurCartesRetournées = 0 'remet le compteur de cartes retournées à 0
        'remet le tableau à Nothing
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
    End Sub

    Private Sub CompareQuatreCartes()
        Task.Delay(400).Wait() 'appelle un timer externe pour marquer un temps de 400ms avant de retourner les cartes
        RetournerCarte() 'retoune toutes les cartes activés
        compteurCartesRetournées = 0 'remet le compteur de cartes retournées à 0
        'remet le tableau à Nothing
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
        StockCartesRetournees(2) = Nothing
        StockCartesRetournees(3) = Nothing
    End Sub

    Private Sub CompareTroisCartes()
        Task.Delay(400).Wait() 'appelle un timer externe pour marquer un temps de 400ms avant de retourner les cartes
        RetournerCarte() 'retoune toutes les cartes activés
        compteurCartesRetournées = 0 'remet le compteur de cartes retournées à 0
        'remet le tableau à Nothing
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
        StockCartesRetournees(2) = Nothing
    End Sub

    Private Sub CarreComplete()
        'si les cartes sont pareils, on désactive tous les labels
        StockCartesRetournees(0).Enabled = False
        StockCartesRetournees(1).Enabled = False
        StockCartesRetournees(2).Enabled = False
        StockCartesRetournees(3).Enabled = False
        nbCarre += 1 'on incrémente le nombre de carrésq trouvés
        tempsCarre = Tempspasse 'on enregistre le temps qu'il a mis à trouver ce nouveau carré
        'on remet les cases du tableau à Nothing et le compteur de cartes retournées à 0
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
        StockCartesRetournees(2) = Nothing
        StockCartesRetournees(3) = Nothing
        compteurCartesRetournées = 0
        'si le nombre de carrés trouvés est de 5, on affiche une msgBox avec nombre de carrés trouvés et en combien de temps
        If nbCarre = 5 Then
            Timer1.Stop()
            MsgBox("Tu as gagné mon ami(e) ! " & "Tu as découvert " & nbCarre & " carré(s) en " & tempsCarre & " secondes !", MsgBoxStyle.Information, "Gagné")
            tempsCarre = Format(tempsCarre, "HH:mm:ss")
            Module1.enregistrement(Form1.ComboBoxNom, nbCarre, tempsCarre, nbPartieJouee) 'on enregistre les données du joueur
            Me.Close() 'on ferme le form du jeu
            Form1.Show() 'on affiche le form d'accueil
        End If
    End Sub

    Private Sub CompteurCartes(LabelImage As Label) 'compteur qui indique la carte que l'on retourne est la combientième
        'si le compteur vaut 0, c'est que c'est la première carte qu'on retourne, et on la stocke dans le tableau StockCartesRetournees à la position 0
        If compteurCartesRetournées = 0 Then
            StockCartesRetournees(0) = LabelImage
            compteurCartesRetournées += 1 'on incrémente le compteur
            'si le compteur vaut 1, c'est que c'est la deuxième carte qu'on retourne, et on la stocke dans le tableau StockCartesRetournees à la position 1
        ElseIf compteurCartesRetournées = 1 Then
            StockCartesRetournees(1) = LabelImage
            compteurCartesRetournées += 1 'on incrémente le compteur
            'si on rappuie sur la même carte, on remet à Nothing la case que l'on vient de remplir et on remet le compteur à la valeur avant incrémentation
            If StockCartesRetournees(0).Tag = StockCartesRetournees(1).Tag Then
                StockCartesRetournees(1) = Nothing
                compteurCartesRetournées = 1 'on incrémente le compteur
            End If
            'si le compteur vaut 2, c'est que c'est la troisième carte qu'on retourne, et on la stocke dans le tableau StockCartesRetournees à la position 2
        ElseIf compteurCartesRetournées = 2 Then
            StockCartesRetournees(2) = LabelImage
            compteurCartesRetournées += 1 'on incrémente le compteur
            'si on rappuie sur la même carte, on remet à Nothing la case que l'on vient de remplir et on remet le compteur à la valeur avant incrémentation
            If StockCartesRetournees(1).Tag = StockCartesRetournees(2).Tag Or StockCartesRetournees(0).Tag = StockCartesRetournees(2).Tag Then
                StockCartesRetournees(2) = Nothing
                compteurCartesRetournées = 2
            End If
            'si le compteur vaut 3, c'est que c'est la deuxième carte qu'on retourne, et on la stocke dans le tableau StockCartesRetournees à la position 3
        ElseIf compteurCartesRetournées = 3 Then
            StockCartesRetournees(3) = LabelImage
            'si on rappuie sur la même carte, on remet à Nothing la case que l'on vient de remplir, et on remet le compteur à la valeur avant incrémentation
            If StockCartesRetournees(2).Tag = StockCartesRetournees(3).Tag Or StockCartesRetournees(1).Tag = StockCartesRetournees(3).Tag Or StockCartesRetournees(0).Tag = StockCartesRetournees(3).Tag Then
                StockCartesRetournees(3) = Nothing
                compteurCartesRetournées = 3
            End If
        End If
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'Timer sur le jeu qui défile
        TempsRestant = DateAdd("s", -1, TempsRestant) 'enlève une seonde à chaque fois
        LabelTimer.Text = Format(TempsRestant, "HH:mm:ss") 'le timer a un format HH:mm:ss
        tempsCarre = Format(tempsCarre, "HH:mm:ss") 'le temps qui enregistre le temps pour le nombre de carrés trouvés a un format HH:mm:ss

        If TempsRestant < #00:00:20# Then 's'il reste 20 secondes, le temps se met en rouge
            LabelTimer.ForeColor = Color.Red
            If TempsRestant = #00:00:00# Then 'si le temps est fini, on arrête les deux timers
                Timer1.Stop()
                Timer1.Enabled = False
                Timer2.Stop()
                Timer2.Enabled = False
                If nbCarre < 5 And nbCarre > 0 Then 'si le joueur a découvert  entre 1 et 4 carrés, on affiche une MsgBox spécifique
                    'celle-ci lui indique le nombre de carrés trouvés en combien de temps
                    MsgBox("Tu as découvert " & nbCarre & " carré(s) en " & tempsCarre & " secondes !", MsgBoxStyle.Information, "Score")
                    Module1.enregistrement(Form1.ComboBoxNom, nbCarre, tempsCarre, nbPartieJouee) 'on enregistre les données du joueur
                    Me.Close() 'on ferme le form du jeu
                    Form1.Show() 'on affiche le formulaire d'accueil
                ElseIf nbCarre = 0 Then
                    'si le joueur a découvert  0 carrés, on affiche une MsgBox spécifique
                    'celle-ci lui indique qu'il n'a trouvé aucun carrés et on enregistre cette fois-ci le temps écoulé du timer
                    'car il faut qu'il se retrouve en bas du classement des scores.
                    MsgBox("Tu as perdu. Tu n'as découvert aucun carré en " & Tempspasse, MsgBoxStyle.Critical, "Perdu")
                    Module1.enregistrement(Form1.ComboBoxNom, nbCarre, Tempspasse, nbPartieJouee) 'on enregistre les données du joueur
                    Me.Close() 'on ferme le form du jeu
                    Form1.Show() 'on affiche le formulaire d'accueil
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'Timer qui enregistre le temps à trouver les cartes
        Tempspasse = DateAdd("s", +1, Tempspasse)
        Tempspasse = Format(Tempspasse, "HH:mm:ss")
    End Sub

    Private Sub RetournerCarte() 'retourne toutes les cartes qui sont activés
        For Each control As Label In TableLayoutPanelLabelImage.Controls
            If control.Enabled Then
                control.Image = Image.FromFile(theme & "/BackCard.png")
                control.Name = "BackCard"
            End If
        Next

    End Sub

    Private Sub choix() 'charge les choix faits dans le form des options
        'par défaut, le temps est de 1 minute
        TempsRestant = #0:01:00#
        LabelTimer.Text = "00:01:00"
        If Form4.OneMinuteAndHalf_rdButton.Checked Then 'si le radiobutton OneMinuteAndHalf est coché, on aura un temps de jeu de 1min30s
            TempsRestant = #0:01:30#
            LabelTimer.Text = "00:01:30"
        ElseIf Form4.OneMinute_rdbutton.Checked Then 'si le radiobutton OneMinute est coché, on aura un temps de jeu de 1min00s
            TempsRestant = #0:01:00#
            LabelTimer.Text = "00:01:00"
        ElseIf Form4.trente_secondes_rdbutton.Checked Then 'si le radiobutton trente_secondes est coché, on aura un temps de jeu de 0min30s
            TempsRestant = #0:00:30#
            LabelTimer.Text = "00:00:30"
            'si le radiobutton time_desactivate est coché, on aura un temps désactivé, mais on comptera tout de même
            'le temps qu'il a pris pour l'enregistrer
        ElseIf Form4.time_desactivate_rdbutton.Checked Then
            Timer1.Enabled = False
            LabelTimer.Visible = False
            temps_label.Text = "-Temps désactivé"
        End If
        'si le radiobutton theme_defaut est coché, les cartes seront celles par défaut donné par le professeur
        If Form4.theme_defaut_rdbutton.Checked Then
            theme = "Images"
            'si le radiobutton themeNoel est coché, les cartes auront comme theme celui de Noel
        ElseIf Form4.themeNoel_rdbutton.Checked Then
            theme = "ImagesNoel"
            'si le radiobutton theme_harry_potter est coché, les cartes auront comme theme celui de Harry Potter
        ElseIf Form4.theme_harry_potter_rdbutton.Checked Then
            theme = "HarryPotter"
            'si le radiobutton theme_foot est coché, les cartes auront comme theme celui du football avec comme cartes les têtes
            'de joueurs connus : Messi, Zidane, Ronaldo, Mbappé, Maradonna
        ElseIf Form4.theme_foot_rdbutton.Checked Then
            theme = "Football"
        End If
        If Form4.CheckBoxPause.Checked Then
            pause_btn.Visible = True
        End If
    End Sub

    Private Sub pause_btn_Click(sender As Object, e As EventArgs) Handles pause_btn.Click 'met une pause sur le jeu
        'on utilise un compteur. Si ce compteur modulo 2 = 0, cela veut dire qu'on est en pause, et qu'il faut redémarrer le timer et 
        'réactiver les cartes
        pause += 1
        If pause Mod 2 = 0 Then
            For Each label As Label In TableLayoutPanelLabelImage.Controls
                label.Enabled = True
            Next
            Timer1.Start()
            Timer2.Start()

        Else
            'Sinon cela veut dire que nous ne sommes pas en pause, et qu'il faut arrêter le timer et 
            'désactiver les cartes
            For Each label As Label In TableLayoutPanelLabelImage.Controls
                label.Enabled = False
            Next
            Timer1.Stop()
            Timer2.Stop()
        End If
    End Sub
End Class