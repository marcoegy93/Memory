Module Module1
    Public emplacement As String = Application.StartupPath & "\"
    Dim NouveauTempsCumul
    Public Sub chargement()

        If IO.File.Exists(emplacement & "SaveStatsPlayers") Then

            Dim lecture As New IO.StreamReader(emplacement & "SaveStatsPlayers")

            While (lecture.Peek() > -1)
                Dim arrSplitStrings() = Split(lecture.ReadLine, "******************")
                Form1.ComboBoxNom.Items.Add(arrSplitStrings(0))
                Form3.LBNom.Items.Add(arrSplitStrings(0))
                Form3.LBCarre.Items.Add(arrSplitStrings(1))
                Form3.LBTemps.Items.Add(arrSplitStrings(2))
                Form3.LBPartie.Items.Add(arrSplitStrings(3))
                Form3.LBTempsCumul.Items.Add(arrSplitStrings(4))

            End While
            lecture.Close()
        End If
    End Sub

    Public Sub Ecriture()

        Dim stw As New IO.StreamWriter(emplacement & "SaveStatsPlayers")

        Dim i As Integer

        For i = 0 To Form3.LBNom.Items.Count - 1
            Dim LigneAEcrire = Form3.LBNom.Items.Item(i) & "******************" & Form3.LBCarre.Items.Item(i) & "******************" & Form3.LBTemps.Items.Item(i) & "******************" & Form3.LBPartie.Items.Item(i) & "******************" & Form3.LBTempsCumul.Items.Item(i)
            stw.WriteLine(LigneAEcrire)
        Next

        stw.Close()
    End Sub

    Public Sub enregistrement(ComboBoxNom As ComboBox, nbCarre As Integer, temps As String, nbPartieJouee As Integer)
        Dim index As Integer = Form3.LBNom.Items.IndexOf(Form1.ComboBoxNom.Text)
        If Not Form3.LBNom.Items.Contains(Form1.ComboBoxNom.Text) Then
            For i As Integer = 0 To Form3.LBNom.Items.Count - 1
                If Form3.LBNom.Items(i).ToString.Equals("") Then
                    Form3.LBNom.Items.RemoveAt((i))
                End If
            Next
            Form3.LBNom.Items.Add(ComboBoxNom.Text)
            Form3.LBCarre.Items.Add(nbCarre)
            Form3.LBTemps.Items.Add(temps)
            Form3.LBPartie.Items.Add(1)
            Form3.LBTempsCumul.Items.Add(temps)
            Form1.ComboBoxNom.Items.Add(ComboBoxNom.Text)
        Else
            For i = 0 To Form3.LBCarre.Items.Count - 1
                If i = index Then
                    If Form3.LBCarre.Items.Item(i) < nbCarre Then
                        Form3.LBCarre.Items.Item(i) = nbCarre
                        Form3.LBTemps.Items.Item(i) = temps

                    ElseIf Form3.LBCarre.Items.Item(i) = nbCarre And Form3.LBTemps.Items.Item(i) > temps Then
                        Form3.LBTemps.Items.Item(i) = temps
                    End If
                End If
            Next
            For k = 0 To Form3.LBPartie.Items.Count - 1
                If k = index Then
                    Form3.LBPartie.Items.Item(k) += 1
                End If
            Next
            For j = 0 To Form3.LBTempsCumul.Items.Count - 1
                If j = index Then
                    Form3.LBTempsCumul.Items.Item(j) = DecomposeDate(Form3.LBTempsCumul.Items.Item(j), temps)
                End If
            Next
        End If
        Form2.Hide()
        Form1.Show()
    End Sub


    Private Function DecomposeDate(TempsCumulActuel As String, TempsEffectue As String)
        Dim SplitTempsCumul() = Split(TempsCumulActuel.ToString, ":")      ' arrSplitStrings1 will be an array from 0 To 8. 
        Dim SplitTempsEffectue() = Split(TempsEffectue.ToString, ":")

        Dim SecondeTempsCumul As Integer = CInt(SplitTempsCumul(2))
        Dim MinuteTempsCumul As Integer = CInt(SplitTempsCumul(1))
        Dim HeureTempsCumul As Integer = CInt(SplitTempsCumul(0))
        Dim SecondeTempsEffectue As Integer = CInt(SplitTempsEffectue(2))
        Dim MinuteTempsEffectue As Integer = CInt(SplitTempsEffectue(1))
        Dim HeureTempsEffectue As Integer = CInt(SplitTempsCumul(0))
        Dim AdditionSeconde = SecondeTempsCumul + SecondeTempsEffectue
        Dim AddtionMinute = MinuteTempsCumul + MinuteTempsEffectue
        Dim AddtionHeure = HeureTempsCumul + HeureTempsEffectue
        If AdditionSeconde > 59 Then
            AdditionSeconde -= 60
            AddtionMinute += 1
            If AddtionMinute > 59 Then
                AddtionMinute -= 60
                AddtionHeure += 1
            End If
        End If

        NouveauTempsCumul = Format(AddtionHeure, "00") & ":" & Format(AddtionMinute, "00") & ":" & Format(AdditionSeconde, "00")
        Return NouveauTempsCumul
    End Function
End Module

