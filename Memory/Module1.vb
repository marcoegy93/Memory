Module Module1
    Public emplacement As String = Application.StartupPath & "\"
    Dim NouveauTempsCumul
    Public Sub chargement() 'charge les différentes données dans les listbox du formulaire des scores et les différents nom de joueurs dans la comboBox

        'vérifie si un fichier SavesStatsPlayers existe à l'emplacement de démarrage de l'application ou à l'emplacement spécifié dans le menu des options
        If IO.File.Exists(emplacement & "SaveStatsPlayers") Then
            'lit le fichier SaveStatsPlayers à l'emplacement renseigné
            Dim lecture As New IO.StreamReader(emplacement & "SaveStatsPlayers")

            While (lecture.Peek() > -1) 'lit le fichier ligne par ligne
                Dim arrSplitStrings() = Split(lecture.ReadLine, "******************") 'sépare les données des joueurs par le split "******************"
                Form1.ComboBoxNom.Items.Add(arrSplitStrings(0)) 'On ajoute à la comboBoxNom l'élement splité dans un tableau à la position 0
                Form3.ComboBoxRecherche.Items.Add(arrSplitStrings(0)) 'On ajoute à la comboBoxNRecherche l'élement splité dans un tableau à la position 0
                Form3.LBNom.Items.Add(arrSplitStrings(0)) 'On ajoute à la ListBox des noms l'élement splité dans un tableau à la position 1
                Form3.LBCarre.Items.Add(arrSplitStrings(1)) 'On ajoute à la ListBox des carrés trouvés l'élement splité dans un tableau à la position 1
                Form3.LBTemps.Items.Add(arrSplitStrings(2)) 'On ajoute à la ListBox des temps l'élement splité dans un tableau à la position 2
                Form3.LBPartie.Items.Add(arrSplitStrings(3)) 'On ajoute à la ListBox du nombre de parties jouées l'élement splité dans un tableau à la position 3
                Form3.LBTempsCumul.Items.Add(arrSplitStrings(4)) 'On ajoute à la ListBox du temps cumulé sur le jeu l'élement splité dans un tableau à la position 4

            End While
            lecture.Close() 'on ferme le streamReader
        End If
    End Sub

    Public Sub chargementOptions() 'charge le chemin de sauvegarde spécifié la dernière fois
        If IO.File.Exists(Application.StartupPath & "\SaveEmplacement") Then
            Dim lecture As New IO.StreamReader(Application.StartupPath & "\SaveEmplacement")
            emplacement = lecture.ReadLine
            lecture.Close() 'on ferme le streamReader
        End If
    End Sub

    Public Sub EcritureOptions() 'ecrit le nouveau fichier de sauvegarde spécifié dans le fichier "SaveEmplacement"
        Dim stw As New IO.StreamWriter(Application.StartupPath & "\SaveEmplacement")
        stw.WriteLine(emplacement)
        stw.Close() 'on ferme le StreamWriter
    End Sub





    Public Sub Ecriture() 'ecrit dans le fichier de sauvegarde les différentes données nécessaires à l'enregistrement des joueurs

        Dim stw As New IO.StreamWriter(emplacement & "SaveStatsPlayers")

        Dim i As Integer
        'pour chaque ligne dans la listBox des noms, on ecrit 
        'dans le fichier de sauvegarde nom, nombre de carrés trouvées,
        'temps minimum réalisé à trouver ces carrés, le nombre de parties jouées, et le temps cumé sur le jeu
        'toutes ces données sont séparés par le split "******************"
        For i = 0 To Form3.LBNom.Items.Count - 1
            Dim LigneAEcrire = Form3.LBNom.Items.Item(i) & "******************" & Form3.LBCarre.Items.Item(i) & "******************" & Form3.LBTemps.Items.Item(i) & "******************" & Form3.LBPartie.Items.Item(i) & "******************" & Form3.LBTempsCumul.Items.Item(i)
            stw.WriteLine(LigneAEcrire)
        Next

        stw.Close() 'on ferme le StreamWriter
    End Sub

    'on enregistre les différentes données à la fin d'une partie
    Public Sub enregistrement(ComboBoxNom As ComboBox, nbCarre As Integer, temps As String, nbPartieJouee As Integer)
        Dim index As Integer = Form3.LBNom.Items.IndexOf(Form1.ComboBoxNom.Text)
        'on regarde si le nom du joueur est contenu dans la listBox des noms, autrement dit
        's'il a déjà joué au jeu et que son nom est enregistré
        's'il ne l'est pas, on enregistre les données en tant que nouveau joueur
        If Not Form3.LBNom.Items.Contains(Form1.ComboBoxNom.Text) Then
            For i As Integer = 0 To Form3.LBNom.Items.Count - 1
                If Form3.LBNom.Items(i).ToString.Equals("") Then 'par défaut, on a un nom vide dans la comboboxNom, donc on l'a enlevé
                    Form3.LBNom.Items.RemoveAt((i))
                End If
            Next
            Form3.LBNom.Items.Add(ComboBoxNom.Text) 'On enregistre le nom du joueur dans listBox des noms
            Form3.LBCarre.Items.Add(nbCarre) 'on enregistre le nombre de carrés trouvés
            Form3.LBTemps.Items.Add(temps) 'on enregistre le temps minimum réalisé
            Form3.LBPartie.Items.Add(1) 'on enregistre 1 car c'est sa première partie
            Form3.LBTempsCumul.Items.Add(temps) 'on enregistre un temps équivalent au temps minimum réalisé car c'est la première fois qu'il joue
            Form1.ComboBoxNom.Items.Add(ComboBoxNom.Text) 'on enregistre le nom du joueur dans la comboBox dans le form d'accueil
            Form3.ComboBoxRecherche.Items.Add(ComboBoxNom.Text) 'on enregistre le nom du joueur dans la comboBoxRecherche dans le form des scores
        Else 'sinon on met  à jour les statistiques de ce joueur
            For i = 0 To Form3.LBCarre.Items.Count - 1
                If i = index Then
                    'si le nombre de carrés trouvés est meilleur que sa partie précédente, on l'enregistre avec le nouveau temps
                    If Form3.LBCarre.Items.Item(i) < nbCarre Then
                        Form3.LBCarre.Items.Item(i) = nbCarre
                        Form3.LBTemps.Items.Item(i) = temps
                        'si le nombre de carrés trouvés est identique à la partie précédente, mais que
                        'le temps est plus petit que le précédent, on enregistre ce nouveau temps
                    ElseIf Form3.LBCarre.Items.Item(i) = nbCarre And Form3.LBTemps.Items.Item(i) > temps Then
                        Form3.LBTemps.Items.Item(i) = temps
                    End If
                End If
            Next
            For k = 0 To Form3.LBPartie.Items.Count - 1
                If k = index Then
                    Form3.LBPartie.Items.Item(k) += 1 'on incrémente le nombre de parties jouées, autrement dit, on enregsitre la partie jouée
                End If
            Next
            For j = 0 To Form3.LBTempsCumul.Items.Count - 1
                If j = index Then
                    'on additionne le temps cumulé avec le nouveau temps réalisé grâce à la méthode DecomposeDate
                    Form3.LBTempsCumul.Items.Item(j) = DecomposeDate(Form3.LBTempsCumul.Items.Item(j), temps)
                End If
            Next
        End If
        Form2.Hide()
        Form1.Show()
    End Sub


    Private Function DecomposeDate(TempsCumulActuel As String, TempsEffectue As String) 'on additionne le temps cumulé avec le nouveau temps réalisé
        Dim SplitTempsCumul() = Split(TempsCumulActuel.ToString, ":") 'On split le temps cumulé en trois(heures,minutes,secondes) avec le slit ":"
        Dim SplitTempsEffectue() = Split(TempsEffectue.ToString, ":") 'On split le temps réalisé en trois(heures,minutes,secondes) avec le slit ":"

        Dim SecondeTempsCumul As Integer = CInt(SplitTempsCumul(2)) 'les secondes du temps cumulé prennent la valeur de SplitTempsCumul(2), casté en Integer
        Dim MinuteTempsCumul As Integer = CInt(SplitTempsCumul(1)) 'les minutes du temps cumulé prennent la valeur de SplitTempsCumul(1), casté en Integer
        Dim HeureTempsCumul As Integer = CInt(SplitTempsCumul(0)) 'les heures du temps cumulé prennent la valeur de SplitTempsCumul(0), casté en Integer
        Dim SecondeTempsEffectue As Integer = CInt(SplitTempsEffectue(2)) 'les secondes du temps réalisé prennent la valeur de SplitTempsEffectue(2), casté en Integer
        Dim MinuteTempsEffectue As Integer = CInt(SplitTempsEffectue(1)) 'les minutes du temps réalisé prennent la valeur de SplitTempsEffectue(1), casté en Integer
        Dim HeureTempsEffectue As Integer = CInt(SplitTempsCumul(0)) 'les heures du temps réalisé prennent la valeur de SplitTempsEffectue(0), casté en Integer
        Dim AdditionSeconde = SecondeTempsCumul + SecondeTempsEffectue 'on additonne les secondes du temps cumulé avec les secondes du temps effectué
        Dim AddtionMinute = MinuteTempsCumul + MinuteTempsEffectue 'on additonne les minutes du temps cumulé avec les minutes du temps effectué
        Dim AddtionHeure = HeureTempsCumul + HeureTempsEffectue 'on additonne les heures du temps cumulé avec les heures du temps effectué
        'si le temps des secondes additonnés dépasse strictement 59 secondes, on enlève 60 secondes et on incrémente les minutes
        If AdditionSeconde > 59 Then
            AdditionSeconde -= 60
            AddtionMinute += 1
            'si le temps des minutes additonnés dépasse strictement 59 minutes, on enlève 60 secondes et on incrémente les heures
            If AddtionMinute > 59 Then
                AddtionMinute -= 60
                AddtionHeure += 1
            End If
        End If

        NouveauTempsCumul = Format(AddtionHeure, "00") & ":" & Format(AddtionMinute, "00") & ":" & Format(AdditionSeconde, "00")
        Return NouveauTempsCumul 'on retourne le nouveau temps cumulé
    End Function
End Module

