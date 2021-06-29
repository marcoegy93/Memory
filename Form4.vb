Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OneMinute_rdbutton.Checked = True
        theme_defaut_rdbutton.Checked = True

    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub modify_emplacement_Click(sender As Object, e As EventArgs) Handles modify_emplacement_btn.Click

        Using folder As New FolderBrowserDialog
            If folder.ShowDialog() = DialogResult.OK Then
                Module1.emplacement = folder.SelectedPath & "\"
                TextBoxEmplacement.Text = Module1.emplacement
            End If
        End Using
    End Sub

    Private Sub TextBoxEmplacement_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmplacement.VisibleChanged
        TextBoxEmplacement.Text = Module1.emplacement
    End Sub
End Class