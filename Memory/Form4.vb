Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'au chargement du form, le temps est par défaut 1min et le thème choisi est celui par défaut
        OneMinute_rdbutton.Checked = True
        theme_defaut_rdbutton.Checked = True

    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click 'cache le form et ouvre le form1
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub modify_emplacement_Click(sender As Object, e As EventArgs) Handles modify_emplacement_btn.Click
        'ouvre une boite de dialogue où on doit choisir le nouvel emplacement du fichier de sauvegarde
        Using folder As New FolderBrowserDialog
            If folder.ShowDialog() = DialogResult.OK Then
                System.IO.File.Delete(Module1.emplacement & "SaveStatsPlayers") 'supprime l'ancien fichier de sauvegarde dans l'ancien emplacement. Ca evite d'avoir plusieurs fichiiers de sauvegarde à différents endroit
                Module1.emplacement = folder.SelectedPath & "\"
                TextBoxEmplacement.Text = Module1.emplacement

            End If
        End Using
    End Sub

    Private Sub TextBoxEmplacement_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmplacement.VisibleChanged
        'affiche dans une textBox le chemin choisi
        TextBoxEmplacement.Text = Module1.emplacement
    End Sub


End Class