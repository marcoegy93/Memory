Imports System.ComponentModel

Public Class Form1
    Dim s As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementOptions() 'charge l'emplacement du fichier spécifié la dernière fois
        chargement() 'charge les différentes données dans les listbox du formulaire des scores et les différents nom de joueurs dans la comboBox

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim s As String = MsgBox("Voulez-vous quitter l'application ?",
        MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmation") 'affiche une msgBox de confiramtion de fermeture
        If (s = vbYes) Then
            EcritureOptions() 'écrit le chemin d'accès du fichier de sauvegarde pour ne pas avoir la sauvegarde qui se remet par défaut à chaque démarrage de jeu
            Ecriture() 'ecrit dans le fichier de sauvegarde les différentes données nécessaires à l'enregistrement des joueurs

        ElseIf s = vbNo Then
            e.Cancel = True 'si l'on appuie sur non, la fermeture est annulée et l'enregistrement n'est pas effectué
        End If
    End Sub

    Public Sub ComboBoxNom_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxNom.TextUpdate
        If (ComboBoxNom.Text.Length >= 3) Then 'si la longueur du nom tapé est supérieur à 3 caractères, on active le bouton Jouer sinon il rest désactivé
            Jouer_btn.Enabled = True
        Else
            Jouer_btn.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom.KeyPress
        If Asc(e.KeyChar) = 13 Then 'si on appuie sur la touche entrée, le formulaire se masque, et le formulaire de jeu s'ouvre
            e.Handled = True
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Jouer_btn_Click(sender As Object, e As EventArgs) Handles Jouer_btn.Click
        Me.Hide() 'si on appuie sur le bouton Jouer, le formulaire se masque, et le formulaire de jeu s'ouvre
        Form2.Show()
    End Sub

    Private Sub Quitter_btn_Click(sender As Object, e As EventArgs) Handles Quitter_btn.Click
        Me.Close() ' si on appuie sur le bouton Quitter, on ferme le formulaire, et cela a pour effet d'activer l'évènement Me.Closing
    End Sub

    Private Sub Scores_btn_Click(sender As Object, e As EventArgs) Handles Scores_btn.Click
        Me.Hide() 'cache le form1 et affiche affiche le form des scores
        Form3.Show()
    End Sub

    Private Sub ComboBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.SelectedIndexChanged
        Jouer_btn.Enabled = True 'si on sélectionne un nom dans la comboBox, le bouton Jouer s'actgive car il est forcément constitué de plus de 3 caractères
    End Sub

    Private Sub Options_btn_Click(sender As Object, e As EventArgs) Handles Options_btn.Click
        Me.Hide() 'si on appuie sur le bouton Options, le form1 se masque et le form des Options apparaît
        Form4.Show()
    End Sub
End Class

