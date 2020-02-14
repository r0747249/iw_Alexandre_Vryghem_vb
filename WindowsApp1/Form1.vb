Public Class Flow_Free
    Public dimensie As Integer = 5 ' de groote van het veld
    Public hoogte As Integer = 500 / dimensie ' de hoogte en de breedte van elk vakje
    Public aantal_kleuren As Integer = 5 ' max 16
    Dim rnd As Random = New Random
    Dim kleuren() As Color = {Color.Blue, Color.Yellow, Color.Green, Color.Red, Color.HotPink, Color.Purple, Color.White, Color.Orange, Color.Gray, Color.Brown, Color.Turquoise, Color.Beige, Color.Indigo, Color.Khaki, Color.Violet, Color.AliceBlue}
    Dim matrix(dimensie + 1, dimensie + 1) As Label ' aanmaken matrix van 5x5
    Public buren_i As New List(Of Integer)
    Public buren_j As New List(Of Integer)
    Dim v As Integer
    Dim w As Integer
    Dim verzameling_kop_en_staart As New List(Of Point)
    Dim aantal_elementen_gekleurd As Integer = 0
    Dim de_buren_opgelost As New List(Of Point)
    Dim aantal_buren_verbonden As Integer = 0
    Public tijdtimer As Integer = 0
    Public tijdhighscore As Integer = 1000
    Public new_highscore As Boolean = False


    Public Sub rooster_aanmaken()
        Panel.Controls.Clear()
        For m As Integer = 0 To dimensie - 1
            For n As Integer = 0 To dimensie - 1
                matrix(m, n) = New Label With {
                    .BackColor = Color.Black,
                    .Name = m & "." & n,
                    .Size = New Size(hoogte, hoogte),
                    .Location = New Point(100 + (m * (hoogte + (hoogte / 40))), 20 + (n * (hoogte + (hoogte / 40)))) ' 100+((h2+h3)*m) met 100 de plaats tussen de rand en de labels en h2 en h3 de plaats tussen de labels onderling
                }
                Panel.Controls.Add(matrix(m, n))
                AddHandler matrix(m, n).MouseDown, AddressOf Label_MouseDown ' bindt mousedown aan de functie label_mousedown
                AddHandler matrix(m, n).MouseUp, AddressOf Label_MouseUp
                AddHandler matrix(m, n).MouseEnter, AddressOf Label_MouseEnter
            Next
        Next
    End Sub ' rooster aanmaken

    ' load
    Private Sub Flow_Free_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rooster_aanmaken()
    End Sub

    Public Sub Start_button_Click(sender As Object, e As EventArgs) Handles Start_button.Click
        Timer1.Start()
        aantal_kleuren = CInt(TextBoxAantalKleuren.Text)
        dimensie = CInt(TextBoxDimensie.Text)
        ReDim matrix(dimensie + 1, dimensie + 1)
        hoogte = 500 / dimensie
        rooster_aanmaken()
        Start_Flow_Free()
    End Sub ' oproeper

    Public Sub Start_Flow_Free()
Start:  Timer.Start() ' + interval van 1000 miliseconden instellen
        TextBoxTimer_seconden.Clear()
        TextBoxTimer_minuten.Clear()
        TextBoxTimer_uren.Clear()
        For m As Integer = 0 To dimensie - 1
            For n As Integer = 0 To dimensie - 1
                matrix(m, n).BackColor = Color.Black
            Next
        Next ' om alles terug zwart te maken
        'gegevens weer herstellen
        verzameling_kop_en_staart.Clear()
        de_buren_opgelost.Clear()
        aantal_buren_verbonden = 0
        aantal_elementen_gekleurd = 0
        tijdtimer = 0


        Dim a As Integer = 0 ' variabele om de while loop x aantal keren uit te voeren
        Dim k As Integer = 0 ' neemt steeds de volgende kleur in de array

        While a <= dimensie And k < aantal_kleuren
restart:    Dim i As Integer = rnd.Next(0, dimensie - 1)
            Dim j As Integer = rnd.Next(0, dimensie - 1)

            ' checkt als het vakje nog geen kleur heeft en kleurt de buur
            If matrix(j, i).BackColor = Color.Black Then
                matrix(j, i).BackColor = kleuren(k) ' een random punt wordt de kop in een kleur
                matrix(j, i).BackColor = kleuren(k)
                'matrix(j, i).Text = "kop"
                verzameling_kop_en_staart.Add(New Point(j, i)) 'de kop in verzameling_kop_en_staart zetten

                buren(i, j) ' oproepen van de functie buren
buren_check:    If buren_i.Count = 0 Then
                    matrix(verzameling_kop_en_staart(verzameling_kop_en_staart.Count - 1).X, verzameling_kop_en_staart(verzameling_kop_en_staart.Count - 1).Y).Text = "staart2"
                    verzameling_kop_en_staart.RemoveAt(verzameling_kop_en_staart.Count - 1) ' de hoogste index van de lijst verwijderen
                    GoTo restart
                End If

                Dim r As Integer = rnd.Next(0, buren_i.Count - 1)

                ' gaat kijken als er een buur wel zwart is
                Dim test As Boolean = False
                For test_nog_zwarte_buren As Integer = 0 To buren_i.Count - 1
                    If matrix(buren_j(test_nog_zwarte_buren), buren_i(test_nog_zwarte_buren)).BackColor = Color.Black Then
                        r = test_nog_zwarte_buren
                        test = True
                    End If
                Next ' gaat checken als er nog zwarte vakjes zijn en als er nog zijn is "test" true en anders is het false en dan moet dat punt verwijdert worden vn de lijst van de elemeenten die zich moen uitbreiden
                If test = False Then
                    ' remove i en j van de lijst van kop en staart die groter kunne worden
                    buren_i.Remove(r)
                    buren_j.Remove(r)
                    GoTo buren_check
                End If

                While matrix(buren_j(r), buren_i(r)).BackColor <> Color.Black
                    r = rnd.Next(0, buren_i.Count - 1)
                End While

                matrix(buren_j(r), buren_i(r)).BackColor = kleuren(k) ' een van de buren wordt de staart in dezelfde kleur
                'matrix(buren_j(r), buren_i(r)).Text = "staart"

                verzameling_kop_en_staart.Add(New Point(buren_j(r), buren_i(r)))

                a = a + 1
                k = k + 1
            End If
        End While ' gaat een kleur en zijn buur op het bord plaatsen

begin:  While verzameling_kop_en_staart.Count > 0
            w = rnd.Next(0, verzameling_kop_en_staart.Count - 1)
            buren(verzameling_kop_en_staart(w).X, verzameling_kop_en_staart(w).Y) ' buren vand die label bepalen

            Dim test2 As Boolean = False
            Dim buur As Integer = 0
            While buur <> buren_i.Count
                If matrix(buren_i(buur), buren_j(buur)).BackColor = Color.Black Then
                    test2 = True
                    buur += 1 ' volgend buur test
                Else
                    buren_i.RemoveAt(buur)
                    buren_j.RemoveAt(buur)
                    'buur = 0 ' zodat geen element overslaat
                End If
            End While

            If test2 = False Then
                de_buren_opgelost.Add(verzameling_kop_en_staart(w))
                matrix(verzameling_kop_en_staart(w).X, verzameling_kop_en_staart(w).Y).Text = "laatste"
                de_buren_opgelost.Add(New Point(verzameling_kop_en_staart(w).X, verzameling_kop_en_staart(w).Y))
                verzameling_kop_en_staart.RemoveAt(w) ' "fouten" staarten en koppen verwijderen(die dat niet meer uitgebrerid kunnen worden)
                If verzameling_kop_en_staart.Count > 0 Then
                    GoTo begin
                End If ' eig niet nuttig
                GoTo begin ' test
            End If

            If verzameling_kop_en_staart.Count = 0 Then
                GoTo begin
            End If


            Dim gekleurd As Boolean = False
            Dim een_buur As Integer = rnd.Next(0, buren_i.Count - 1)
            While gekleurd = False
                If matrix(buren_i(een_buur), buren_j(een_buur)).BackColor = Color.Black Then
                    matrix(buren_i(een_buur), buren_j(een_buur)).BackColor = matrix(verzameling_kop_en_staart(w).X, verzameling_kop_en_staart(w).Y).BackColor
                    matrix(verzameling_kop_en_staart(w).X, verzameling_kop_en_staart(w).Y).Text = "tussen"
                    verzameling_kop_en_staart.RemoveAt(w)
                    verzameling_kop_en_staart.Add(New Point(buren_i(een_buur), buren_j(een_buur)))
                    gekleurd = True
                End If
            End While ' de puntjes uit elkaar halen
        End While

        For m As Integer = 0 To dimensie - 1
            For n As Integer = 0 To dimensie - 1
                If matrix(m, n).BackColor = Color.Black Then
                    GoTo Start
                End If
            Next
        Next ' checkt dat er geen zwarte vakjes meer zijn

        For m As Integer = 0 To dimensie - 1
            For n As Integer = 0 To dimensie - 1
                If matrix(m, n).Text <> "laatste" Then
                    matrix(m, n).BackColor = Color.Black
                End If
            Next
        Next ' om alles behalve de kop en staart terug zwart te maken

    End Sub 'main


    ' Timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        TextBoxTimer_seconden.Text = TextBoxTimer_seconden.Text + 1
        tijdtimer += 1

        If new_highscore = True Then
            TextBoxHighscore_seconden.Text = tijdhighscore
        End If

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTimer_seconden.TextChanged
        ' zorgt ervoor dat elke keer dat er een nummer is in de timer dat er een 0 voor staat
        If (TextBoxTimer_seconden.TextLength < 2) Then
            TextBoxTimer_seconden.Text = "0" + TextBoxTimer_seconden.Text
        End If

        If (TextBoxTimer_minuten.TextLength < 2) Then
            TextBoxTimer_minuten.Text = "0" + TextBoxTimer_minuten.Text
        End If

        If (TextBoxTimer_uren.TextLength < 2) Then
            TextBoxTimer_uren.Text = "0" + TextBoxTimer_uren.Text
        End If

        ' bewerkingen om seconden om te zetten naar minuten en uren
        If CInt(TextBoxTimer_seconden.Text >= 60) Then
            TextBoxTimer_minuten.Text = TextBoxTimer_minuten.Text + 1
            TextBoxTimer_seconden.Text = TextBoxTimer_seconden.Text - 60
            If CInt(TextBoxTimer_minuten.Text >= 60) Then
                TextBoxTimer_uren.Text = TextBoxTimer_uren.Text + 1
                TextBoxTimer_minuten.Text = TextBoxTimer_minuten.Text - 60
            End If
        End If
    End Sub

    Private Sub TextBoxHighscore_seconden_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHighscore_seconden.TextChanged
        ' zorgt ervoor dat elke keer dat er een nummer is in de timer dat er een 0 voor staat
        If (TextBoxHighscore_seconden.TextLength < 2) Then
            TextBoxHighscore_seconden.Text = "0" + TextBoxHighscore_seconden.Text
        End If

        If (TextBoxHighscore_minuten.TextLength < 2) Then
            TextBoxHighscore_minuten.Text = "0" + TextBoxHighscore_minuten.Text
        End If

        If (TextBoxHighscore_uren.TextLength < 2) Then
            TextBoxHighscore_uren.Text = "0" + TextBoxHighscore_uren.Text
        End If

        ' bewerkingen om seconden om te zetten naar minuten en uren
        If CInt(TextBoxHighscore_seconden.Text >= 60) Then
            TextBoxHighscore_minuten.Text = TextBoxHighscore_minuten.Text + 1
            TextBoxHighscore_seconden.Text = TextBoxHighscore_seconden.Text - 60
            If CInt(TextBoxHighscore_minuten.Text >= 60) Then
                TextBoxHighscore_uren.Text = TextBoxHighscore_uren.Text + 1
                TextBoxHighscore_minuten.Text = TextBoxHighscore_minuten.Text - 60
            End If
        End If
    End Sub


    'MouseEvents
    Dim label_backcolor As Color
    Dim muis_down As Boolean = False
    Dim muis_up As Boolean = False
    Dim c As Point
    Dim vakjes() As Point
    Dim r As Integer = 0
    Dim buren_gekleurd_vakje As New List(Of Point)
    ' MouseEnter
    Dim gekleurde_vakjes As New List(Of Point)
    Dim verbonden As Boolean = False
    Private Sub Label_MouseEnter(ByVal label As Label, e As EventArgs)
        If muis_down = True And label.BackColor = Color.Black Then ' wanneer het een leeg vakje is

            label.BackColor = label_backcolor ' je gaat da vakje kleuren met dezelfde kleur als het vakje waarop je eerst hebt geklikt

            For m As Integer = 0 To dimensie - 1
                For n As Integer = 0 To dimensie - 1
                    If matrix(m, n).Location = label.Location Then
                        gekleurde_vakjes.Add(New Point(m, n))
                        aantal_elementen_gekleurd += 1
                    End If
                Next
            Next ' gaat de elementen saven in een lijst die je net hebt gekleurd

        ElseIf muis_down = True And label.BackColor = label_backcolor And label.Text = "laatste" Then ' wanneeer het een kop of staart is
            verbonden = True
            muis_down = False

            'ElseIf muis_down = True And label.BackColor = label_backcolor And label.Text = "tussen" Then

            '    If label.Location = gekleurde_vakjes(gekleurde_vakjes.Count - 2) Then ' voorlaatste vakje
            '        matrix(gekleurde_vakjes(gekleurde_vakjes.Count - 1).X, gekleurde_vakjes(gekleurde_vakjes.Count - 1).Y).BackColor = Color.Black
            '        gekleurde_vakjes.RemoveAt(gekleurde_vakjes.Count - 1)
            '    End If

        Else 'als het geen zwart vakje is of geen kop of staart
            For aantal As Integer = 0 To gekleurde_vakjes.Count - 1
                matrix(gekleurde_vakjes(aantal).X, gekleurde_vakjes(aantal).Y).BackColor = Color.Black
            Next
            muis_down = False

        End If ' wanneer je sleept in een ander vakje en dat die een kleur bevat gebeuren er verschillende dingen

        If muis_down = False Then
            gekleurde_vakjes.Clear()
        End If

    End Sub

    ' MouseDown
    Private Sub Label_MouseDown(ByVal label As Label, e As EventArgs)
        label.Capture = False
        muis_up = False
        If label.BackColor <> Color.Black Then
            muis_down = True
            label_backcolor = label.BackColor ' de kleur waarop je klikt onthouden en in een variabele zetten
        End If
    End Sub

    ' MouseUp
    Private Sub Label_MouseUp(ByVal label As Label, e As EventArgs)
        muis_down = False
        muis_up = True


        For aantal As Integer = 0 To gekleurde_vakjes.Count - 1
            matrix(gekleurde_vakjes(aantal).X, gekleurde_vakjes(aantal).Y).BackColor = Color.Black
            aantal_elementen_gekleurd -= 1
        Next 'weer zwart kleuren van de vakjes  wanneer je ze niet goed hebt verbonden

        If verbonden = True Then
            aantal_buren_verbonden += 1
        End If

        If muis_up = True Then
            Dim zwarte_vakjes As Boolean = False

            For m As Integer = 0 To dimensie - 1
                For n As Integer = 0 To dimensie - 1
                    If label.BackColor = Color.Black Then
                        zwarte_vakjes = True
                    End If
                Next
            Next

            If zwarte_vakjes = True And aantal_buren_verbonden = aantal_kleuren And muis_up = True Then
                Dim resultaat1 As DialogResult = MessageBox.Show("U heeft dit level niet juist opgelost" & Environment.NewLine & "Wilt u dit level opnieuw spelen of niet?", "Resultaat", MessageBoxButtons.YesNo)
                Timer.Stop()
                If resultaat1 = DialogResult.Yes Then
                    For m As Integer = 0 To dimensie - 1
                        For n As Integer = 0 To dimensie - 1
                            If matrix(m, n).Text <> "laatste" Then
                                matrix(m, n).BackColor = Color.Black
                            End If
                        Next
                    Next ' om alles terug zwart te maken
                    aantal_elementen_gekleurd = 0
                    aantal_buren_verbonden = 0 ' toch handmatig opnieuw instellen omdat de functie flow free niet opniew wordt opgeroepen en dus worden de basiswaarden niet hersteld

                    tijdtimer = 0
                    TextBoxTimer_seconden.Clear()
                    TextBoxTimer_minuten.Clear()
                    TextBoxTimer_uren.Clear()
                    Timer.Start()
                ElseIf resultaat1 = DialogResult.No Then
                    Start_Flow_Free()
                    tijdtimer = 0
                End If
                muis_up = False
            ElseIf zwarte_vakjes = False And aantal_buren_verbonden = aantal_kleuren And muis_up = True Then
                Timer.Stop()
                Dim resultaat As DialogResult = MessageBox.Show("Gefeliciteerd u heeft het level juist opgelost!!!" & Environment.NewLine & "Oplostijd: " & TextBoxTimer_uren.Text & ":" & TextBoxTimer_minuten.Text & ":" & TextBoxTimer_seconden.Text & Environment.NewLine & "Wilt u een nieuw level spelen?", "Resultaat", MessageBoxButtons.YesNo) ' MessageBoxIcon.Question
                If tijdtimer < tijdhighscore Then
                    tijdhighscore = tijdtimer
                    new_highscore = True ' er voor zorgen dat een highscore komt
                End If

                If resultaat = DialogResult.Yes Then
                    Start_Flow_Free() ' opnieuw uitvoeren
                ElseIf resultaat = DialogResult.No Then
                    ' niks doen
                End If
                tijdtimer = 0
                muis_up = False
            End If ' wanneer level juist is

        End If
        verbonden = False

    End Sub

    ' buren bepalen
    Public Sub buren(i As Integer, j As Integer)
        buren_i.Clear() ' anders worden er gewoon elementen bij opgeteld
        buren_j.Clear()
        If j = 0 Then
            If i = 0 Then
                ' rechts
                buren_i.Add(i)
                buren_j.Add(j + 1)
                ' onder
                buren_i.Add(i + 1)
                buren_j.Add(j)
            ElseIf i = dimensie - 1 Then
                ' rechts
                buren_i.Add(i)
                buren_j.Add(j + 1)
                ' boven
                buren_i.Add(i - 1)
                buren_j.Add(j)
            Else
                ' rechts
                buren_i.Add(i)
                buren_j.Add(j + 1)
                ' onder
                buren_i.Add(i + 1)
                buren_j.Add(j)
                ' boven
                buren_i.Add(i - 1)
                buren_j.Add(j)
            End If
        End If ' eerste kolom
        If i = 0 Then
            If j <> 0 And j <> dimensie - 1 Then
                ' links
                buren_i.Add(i)
                buren_j.Add(j - 1)
                ' rechts
                buren_i.Add(i)
                buren_j.Add(j + 1)
                ' onder
                buren_i.Add(i + 1)
                buren_j.Add(j)
            End If
        End If ' eerste rij
        If i = dimensie - 1 Then ' laatste rij
            If j = dimensie - 1 Then
                ' links
                buren_i.Add(i)
                buren_j.Add(j - 1)
                ' boven
                buren_i.Add(i - 1)
                buren_j.Add(j)
            ElseIf j <> 0 And j <> dimensie - 1 Then
                ' rechts
                buren_i.Add(i)
                buren_j.Add(j + 1)
                ' links
                buren_i.Add(i)
                buren_j.Add(j - 1)
                ' boven
                buren_i.Add(i - 1)
                buren_j.Add(j)
            End If
        End If ' laatste rij
        If j = dimensie - 1 Then
            If i <> 0 And i <> dimensie - 1 Then
                ' links
                buren_i.Add(i)
                buren_j.Add(j - 1)
                ' onder
                buren_i.Add(i + 1)
                buren_j.Add(j)
                ' boven
                buren_i.Add(i - 1)
                buren_j.Add(j)

            ElseIf i = 0 Then
                ' links
                buren_i.Add(i)
                buren_j.Add(j - 1)
                ' onder
                buren_i.Add(i + 1)
                buren_j.Add(j)
            End If
        End If ' laatste kolom
        If i > 0 And j > 0 And i < dimensie - 1 And j < dimensie - 1 Then
            ' rechts
            buren_i.Add(i)
            buren_j.Add(j + 1)
            ' links
            buren_i.Add(i)
            buren_j.Add(j - 1)
            ' boven
            buren_i.Add(i - 1)
            buren_j.Add(j)
            ' onder
            buren_i.Add(i + 1)
            buren_j.Add(j)
        End If ' elementen in het midden
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For m As Integer = 0 To dimensie - 1
            For n As Integer = 0 To dimensie - 1
                matrix(m, n).ForeColor = matrix(m, n).BackColor
            Next
        Next 'om de tekst te verwijderen uit de labels
    End Sub
End Class

' Bronnen:
' de afbeelding van flow free heb ik van het internet gehaald
' resultaat = dialogbox.yes/.no is gebaseerd op informatie van docs.microsoft (ik heb dit wel bewerkt maar infor over messagebox heb ik daar geleerd)
' ik heb voor de timer ook een video gekeken op YouTube