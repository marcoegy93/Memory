Imports System.ComponentModel
Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Retour_btn.Click 'ferme le form et revient au form 1
        Me.Hide()
        Form1.Show()
    End Sub

    'on sinchronise les listbox dans le menu scores en fonction de l'index selectionné dans une des listBox
    'on affiche à chaque le nom du joueur correspondant dans la comboBoxRecherche
    Private Sub LBNom_(sender As Object, e As EventArgs) Handles LBNom.SelectedIndexChanged
        LBCarre.SelectedIndex = LBNom.SelectedIndex
        LBTemps.SelectedIndex = LBNom.SelectedIndex
        LBPartie.SelectedIndex = LBNom.SelectedIndex
        LBTempsCumul.SelectedIndex = LBNom.SelectedIndex
        If LBNom.SelectedItem <> Nothing Then 'evite nullReferenceException
            ComboBoxRecherche.Text = LBNom.SelectedItem.ToString
        End If
    End Sub

    Private Sub LBCarre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBCarre.SelectedIndexChanged
        LBNom.SelectedIndex = LBCarre.SelectedIndex
        LBTemps.SelectedIndex = LBCarre.SelectedIndex
        LBPartie.SelectedIndex = LBCarre.SelectedIndex
        LBTempsCumul.SelectedIndex = LBCarre.SelectedIndex
        If LBNom.SelectedItem <> Nothing Then 'evite nullReferenceException
            ComboBoxRecherche.Text = LBNom.SelectedItem.ToString
        End If
    End Sub

    Private Sub LBTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBTemps.SelectedIndexChanged
        LBNom.SelectedIndex = LBTemps.SelectedIndex
        LBCarre.SelectedIndex = LBTemps.SelectedIndex
        LBPartie.SelectedIndex = LBTemps.SelectedIndex
        LBTempsCumul.SelectedItem = LBTemps.SelectedIndex
        If LBNom.SelectedItem <> Nothing Then 'evite nullReferenceException
            ComboBoxRecherche.Text = LBNom.SelectedItem.ToString
        End If
    End Sub

    Private Sub LBParties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBPartie.SelectedIndexChanged
        LBNom.SelectedIndex = LBPartie.SelectedIndex
        LBCarre.SelectedIndex = LBPartie.SelectedIndex
        LBTemps.SelectedIndex = LBPartie.SelectedIndex
        LBTempsCumul.SelectedIndex = LBPartie.SelectedIndex
        If LBNom.SelectedItem <> Nothing Then 'evite nullReferenceException
            ComboBoxRecherche.Text = LBNom.SelectedItem.ToString
        End If
    End Sub

    Private Sub LBTempsCumul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBTempsCumul.SelectedIndexChanged
        LBNom.SelectedIndex = LBTempsCumul.SelectedIndex
        LBCarre.SelectedIndex = LBTempsCumul.SelectedIndex
        LBTemps.SelectedIndex = LBTempsCumul.SelectedIndex
        LBPartie.SelectedIndex = LBTempsCumul.SelectedIndex
        If LBNom.SelectedItem <> Nothing Then 'evite nullReferenceException
            ComboBoxRecherche.Text = LBNom.SelectedItem.ToString
        End If

    End Sub

    'tri du plus nul au plus fort les joueurs
    Private Sub duPlusNulAuPlusFort_Click(sender As Object, e As EventArgs) Handles duPlusNulAuPlusFort_btn.Click
        Dim tmp
        For i = 0 To LBCarre.Items.Count - 1
            For j = 0 To LBCarre.Items.Count - 1
                If LBCarre.Items.Item(j) > LBCarre.Items.Item(i) Then
                    tmp = LBCarre.Items.Item(i)
                    LBCarre.Items.Item(i) = LBCarre.Items.Item(j)
                    LBCarre.Items.Item(j) = tmp
                    tmp = echangePosition(i, j)
                ElseIf LBCarre.Items.Item(j) = LBCarre.Items.Item(i) And LBTemps.Items.Item(j) < LBTemps.Items.Item(i) Then
                    tmp = echangePosition(i, j)
                End If
            Next
        Next

    End Sub

    'tri du plus fort au plus nul les joueurs
    Private Sub DuPlusFortAuPlusNul_btn_Click(sender As Object, e As EventArgs) Handles DuPlusFortAuPlusNul_btn.Click
        Dim tmp
        For i = 0 To LBCarre.Items.Count - 1
            For j = 0 To LBCarre.Items.Count - 1
                If LBCarre.Items.Item(j) < LBCarre.Items.Item(i) Then
                    tmp = LBCarre.Items.Item(i)
                    LBCarre.Items.Item(i) = LBCarre.Items.Item(j)
                    LBCarre.Items.Item(j) = tmp
                    tmp = echangePosition(i, j)
                ElseIf LBCarre.Items.Item(j) = LBCarre.Items.Item(i) And LBTemps.Items.Item(j) > LBTemps.Items.Item(i) Then
                    tmp = echangePosition(i, j)
                End If
            Next
        Next

    End Sub

    'échange la position du joueur,avec toutes ses stats avec 
    Private Function echangePosition(i As Integer, j As Integer) As Object
        Dim tmp = LBNom.Items.Item(i)
        LBNom.Items.Item(i) = LBNom.Items.Item(j)
        LBNom.Items.Item(j) = tmp
        tmp = LBTemps.Items.Item(i)
        LBTemps.Items.Item(i) = LBTemps.Items.Item(j)
        LBTemps.Items.Item(j) = tmp
        tmp = LBPartie.Items.Item(i)
        LBPartie.Items.Item(i) = LBPartie.Items.Item(j)
        LBPartie.Items.Item(j) = tmp
        tmp = LBTempsCumul.Items.Item(i)
        LBTempsCumul.Items.Item(i) = LBTempsCumul.Items.Item(j)
        LBTempsCumul.Items.Item(j) = tmp
        Return tmp
    End Function

    'affiche les statistiques du joueur recherché via une MsgBox
    Private Sub Rechercher_btn_Click(sender As Object, e As EventArgs) Handles Rechercher_btn.Click
        For i = 0 To LBNom.Items.Count - 1
            If ComboBoxRecherche.Text.Equals(LBNom.Items.Item(i)) Then
                MsgBox("Nom : " & LBNom.Items.Item(i) & vbCrLf & "Nombre de carrés trouvés : " & LBCarre.Items.Item(i) & vbCrLf & "Temps minimum : " &
                       LBTemps.Items.Item(i) & vbCrLf & "Nombre de partie jouées : " & LBPartie.Items.Item(i) & vbCrLf & "Temps de jeu cumulé : " & LBTempsCumul.Items.Item(i))
            End If

        Next


    End Sub

End Class
