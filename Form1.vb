Imports System.ComponentModel

Public Class Form1
    Dim s As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargement()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim s As String = MsgBox("Voulez-vous quitter l'application ?",
        MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmation")
        If (s = vbYes) Then
            Ecriture()
        ElseIf s = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ComboBoxNom_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxNom.TextUpdate
        If (ComboBoxNom.Text.Length >= 3) Then
            Jouer_btn.Enabled = True
        Else
            Jouer_btn.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Jouer_btn_Click(sender As Object, e As EventArgs) Handles Jouer_btn.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Quitter_btn_Click(sender As Object, e As EventArgs) Handles Quitter_btn.Click
        Me.Close()
    End Sub

    Private Sub Scores_btn_Click(sender As Object, e As EventArgs) Handles Scores_btn.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub ComboBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.SelectedIndexChanged
        Jouer_btn.Enabled = True
    End Sub

    Private Sub Options_btn_Click(sender As Object, e As EventArgs) Handles Options_btn.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class

