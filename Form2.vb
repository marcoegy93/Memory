Imports System.ComponentModel

Public Class Form2

    Public nbCarre As Integer = 0
    Public nbPartieJouee As Integer = 0
    Dim LabelClique As Label
    Public tempsCarre As Date
    Public TempsRestant As Date
    Dim Tempspasse As Date
    Dim Random As New Random
    Dim Locked As Boolean = False
    Dim compteur = 0
    Public theme As String = "Images"
    Dim StockCartesRetournees(3) As Label
    Dim nombres() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}
    Dim pause As Integer = 0
    Dim tabImage() As Image


    Dim tabName() As String = {"Card0", "Card1", "Card2", "Card3", "Card4", "Card0", "Card1", "Card2", "Card3", "Card4", "Card0", "Card1", "Card2", "Card3", "Card4", "Card0", "Card1", "Card2", "Card3", "Card4"}

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ChiffreImage = 0
        pause_btn.Enabled = False
        pause_btn.Visible = False
        choix()
        MelangerCartes()
        For Each label As Label In TableLayoutPanelLabelImage.Controls
            label.Image = Image.FromFile(theme & "/BackCard.png")
            label.Name = "BackCard"
            label.Tag = ChiffreImage
            ChiffreImage += 1
        Next
        tabImage = {Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png"),
        Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png"),
        Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png"),
        Image.FromFile(theme & "/Card0.png"), Image.FromFile(theme & "/Card1.png"), Image.FromFile(theme & "/Card2.png"), Image.FromFile(theme & "/Card3.png"), Image.FromFile(theme & "/Card4.png")}
    End Sub

    Private Sub AssignerImage(LabelImage As Label)

        Dim iconLabel As Label = TryCast(LabelImage, Label)
        If iconLabel IsNot Nothing Then
            Dim randomNumber As Integer = nombres(LabelImage.Tag)
            iconLabel.Image = tabImage(randomNumber)
            iconLabel.Name = tabName(randomNumber)
            LabelImage.Image = iconLabel.Image
            LabelImage.Name = iconLabel.Name
        End If

    End Sub

    Private Sub Abandon_btn_Click(sender As Object, e As EventArgs) Handles Abandon_btn.Click
        Timer1.Stop()
        Dim s As String = MsgBox("Voulez-vous abandonner la partie en cours ?",
        MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmation")
        If (s = vbYes) Then
            Timer1.Stop()
            Timer1.Enabled = False

            If nbCarre < 5 And nbCarre > 0 Then
                MsgBox("tu as abandonné...mais tu as découvert " & nbCarre & " carré(s) en " & tempsCarre & " secondes !", MsgBoxStyle.Information, "Score")
                Module1.enregistrement(Form1.ComboBoxNom, nbCarre, tempsCarre, nbPartieJouee)
                Me.Close()
                Form1.Show()
            ElseIf nbCarre = 0 Then
                MsgBox("tu as abandonné...", MsgBoxStyle.Critical, "Abandon direct")
                Module1.enregistrement(Form1.ComboBoxNom, nbCarre, "00:00:00", nbPartieJouee)
                Me.Close()
                Form1.Show()
            End If
        ElseIf s = vbNo Then
            Timer1.Start()
        End If
    End Sub




    Private Sub Joueur(sender As Object, e As EventArgs) Handles Joueur_label.VisibleChanged
        Joueur_label.Text = "Joueur : " & Form1.ComboBoxNom.Text
    End Sub

    Sub EchangerPositionNombres(nombres As Integer(), i As Integer, j As Integer)
        Dim temp
        temp = nombres(i)
        nombres(i) = nombres(j)
        nombres(j) = temp
    End Sub

    Sub MelangerCartes()
        For i = 0 To nombres.Length - 1
            EchangerPositionNombres(nombres, i, Random.Next(0, nombres.Length - 1))
        Next
    End Sub

    Private Sub LabelCarte_Click(sender As Object, e As EventArgs) Handles LabelCarte1.Click, LabelCarte2.Click, LabelCarte3.Click, LabelCarte4.Click, LabelCarte5.Click, LabelCarte6.Click, LabelCarte7.Click, LabelCarte8.Click, LabelCarte9.Click, LabelCarte10.Click, LabelCarte11.Click, LabelCarte12.Click, LabelCarte13.Click, LabelCarte14.Click, LabelCarte15.Click, LabelCarte16.Click, LabelCarte17.Click, LabelCarte18.Click, LabelCarte19.Click, LabelCarte20.Click
        pause_btn.Enabled = True
        If Locked Then
            Exit Sub
        End If
        If LabelTimer.Visible <> False Then
            Timer1.Start()
        End If
        Timer2.Start()
        AssignerImage(sender)
        LabelClique = sender
        comparaison(sender)

    End Sub

    Private Sub comparaison(LabelImage As Label)
        Locked = True
        CompteurCartes(LabelImage)
        If StockCartesRetournees(1) IsNot Nothing Then
            If StockCartesRetournees(0).Name <> StockCartesRetournees(1).Name Then
                CompareDeuxCartes()
                Exit Sub
            End If
        End If
        If StockCartesRetournees(2) IsNot Nothing Then
            If StockCartesRetournees(1).Name <> StockCartesRetournees(2).Name Then
                CompareTroisCartes()
                Exit Sub
            End If
        End If
        If StockCartesRetournees(3) IsNot Nothing Then
            If StockCartesRetournees(2).Name <> StockCartesRetournees(3).Name Then
                CompareQuatreCartes()
                Exit Sub
            Else
                CarreComplete()
            End If
        End If
        Locked = False

    End Sub

    Private Sub CompareDeuxCartes()
        Timer3.Interval = 400
        Timer3.Start()
        compteur = 0
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
    End Sub

    Private Sub CompareQuatreCartes()
        Timer3.Start()
        compteur = 0
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
        StockCartesRetournees(2) = Nothing
        StockCartesRetournees(3) = Nothing
    End Sub

    Private Sub CompareTroisCartes()
        Timer3.Interval = 400
        Timer3.Start()
        compteur = 0
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
        StockCartesRetournees(2) = Nothing
    End Sub

    Private Sub CarreComplete()
        StockCartesRetournees(0).Enabled = False
        StockCartesRetournees(1).Enabled = False
        StockCartesRetournees(2).Enabled = False
        StockCartesRetournees(3).Enabled = False
        nbCarre += 1
        tempsCarre = Tempspasse
        StockCartesRetournees(0) = Nothing
        StockCartesRetournees(1) = Nothing
        StockCartesRetournees(2) = Nothing
        StockCartesRetournees(3) = Nothing
        compteur = 0
        If nbCarre = 5 Then
            Timer1.Stop()
            MsgBox("Tu as gagné mon ami ! " & "Tu as découvert " & nbCarre & " carré(s) en " & tempsCarre & " secondes !", MsgBoxStyle.Information, "Gagné")
            tempsCarre = Format(tempsCarre, "HH:mm:ss")
            Module1.enregistrement(Form1.ComboBoxNom, nbCarre, tempsCarre, nbPartieJouee)
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub CompteurCartes(LabelImage As Label)
        If compteur = 0 Then
            StockCartesRetournees(0) = LabelImage
            compteur += 1
        ElseIf compteur = 1 Then
            StockCartesRetournees(1) = LabelImage
            compteur += 1
            If StockCartesRetournees(0).Tag = StockCartesRetournees(1).Tag Then
                StockCartesRetournees(1) = Nothing
                compteur = 1
            End If
        ElseIf compteur = 2 Then
            StockCartesRetournees(2) = LabelImage
            compteur += 1
            If StockCartesRetournees(1).Tag = StockCartesRetournees(2).Tag Or StockCartesRetournees(0).Tag = StockCartesRetournees(2).Tag Then
                StockCartesRetournees(2) = Nothing
                compteur = 2
            End If
        ElseIf compteur = 3 Then
            StockCartesRetournees(3) = LabelImage
            If StockCartesRetournees(2).Tag = StockCartesRetournees(3).Tag Or StockCartesRetournees(1).Tag = StockCartesRetournees(3).Tag Or StockCartesRetournees(0).Tag = StockCartesRetournees(3).Tag Then
                StockCartesRetournees(3) = Nothing
                compteur = 3
            End If
        End If
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TempsRestant = DateAdd("s", -1, TempsRestant)
        LabelTimer.Text = Format(TempsRestant, "HH:mm:ss")
        tempsCarre = Format(tempsCarre, "HH:mm:ss")

        If TempsRestant < #00:00:20# Then
            LabelTimer.ForeColor = Color.Red
            If TempsRestant = #00:00:00# Then
                Timer1.Stop()
                Timer1.Enabled = False
                If nbCarre < 5 And nbCarre > 0 Then
                    MsgBox("Tu as découvert " & nbCarre & " carré(s) en " & tempsCarre & " secondes !", MsgBoxStyle.Information, "Score")
                    Module1.enregistrement(Form1.ComboBoxNom, nbCarre, tempsCarre, nbPartieJouee)
                    Me.Close()
                    Form1.Show()
                ElseIf nbCarre = 0 Then
                    MsgBox("Tu as perdu", MsgBoxStyle.Critical, "Perdu")
                    Module1.enregistrement(Form1.ComboBoxNom, nbCarre, "00:00:00", nbPartieJouee)
                    Me.Close()
                    Form1.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Tempspasse = DateAdd("s", +1, Tempspasse)
        Tempspasse = Format(Tempspasse, "HH:mm:ss")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        For Each control As Label In TableLayoutPanelLabelImage.Controls
            If control.Enabled Then
                control.Image = Image.FromFile(theme & "/BackCard.png")
                control.Name = "BackCard"
            End If
        Next
        Locked = False

    End Sub


    Private Sub choix()
        TempsRestant = #0:01:00#
        LabelTimer.Text = "00:01:00"
        If Form4.OneMinuteAndHalf_rdButton.Checked Then
            TempsRestant = #0:01:30#
            LabelTimer.Text = "00:01:30"
        ElseIf Form4.OneMinute_rdbutton.Checked Then
            TempsRestant = #0:01:00#
            LabelTimer.Text = "00:01:00"
        ElseIf Form4.trente_secondes_rdbutton.Checked Then
            TempsRestant = #0:00:30#
            LabelTimer.Text = "00:00:30"
        ElseIf Form4.time_desactivate_rdbutton.Checked Then
            Timer1.Enabled = False
            LabelTimer.Visible = False
            temps_label.Text = "-Temps désactivé"
        End If
        If Form4.theme_defaut_rdbutton.Checked Then
            theme = "Images"
        ElseIf Form4.themeNoel_rdbutton.Checked Then
            theme = "ImagesNoel"
        ElseIf Form4.theme_harry_potter_rdbutton.Checked Then
            theme = "HarryPotter"
        ElseIf Form4.theme_foot_rdbutton.Checked Then
            theme = "Football"
        End If
        If Form4.CheckBoxPause.Checked Then
            pause_btn.Visible = True
        End If
    End Sub

    Private Sub pause_btn_Click(sender As Object, e As EventArgs) Handles pause_btn.Click
        pause += 1
        If pause Mod 2 = 0 Then
            Timer1.Start()
            Timer2.Start()
        Else
            Timer1.Stop()
            Timer2.Stop()
        End If
    End Sub
End Class