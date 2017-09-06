Public Class Form1
    Dim cards(52) As Integer
    Dim temp, loopcounter, itempicked, remaining, yournum, compnum, cardindex As Integer
    Dim myrandom As New Random


    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If btnPlay.Text = "New Game" Then
            btnPlay.Text = "Next Card"
            btnReset.Enabled = True
            btnReset.Text = "Stop"
            txtCScore.Text = "0"
            txtPScore.Text = "0"
            For loopcounter = 1 To 52
                cards(loopcounter) = loopcounter
                ' txtInfo.Text = txtInfo.Text & cards(loopcounter) & ControlChars.CrLf
            Next loopcounter
            For remaining = 52 To 2 Step -1
                itempicked = myrandom.Next(remaining) + 1
                temp = cards(itempicked)
                cards(itempicked) = cards(remaining)
                cards(remaining) = temp
            Next remaining
            cardindex = 1
        End If
        For loopcounter = 1 To 52
            txtInfo.Text = txtInfo.Text & Str(loopcounter) & ": " & cards(loopcounter) & ControlChars.CrLf

        Next loopcounter
        Select Case cards(cardindex)
            Case 1 To 13 'hearts
                picPlayerSuits.Image = picHeart.Image
                yournum = cards(cardindex)
            Case 14 To 26 'diamonds
                picPlayerSuits.Image = picDiamond.Image
                yournum = cards(cardindex) - 13
            Case 27 To 39 'spades
                picPlayerSuits.Image = picSpade.Image
                yournum = cards(cardindex) - 26
            Case 40 To 52 'clubs
                picPlayerSuits.Image = picClubs.Image
                yournum = cards(cardindex) - 39
        End Select

        Select Case yournum
            Case 1 To 9
                lblPnum.Text = Str(yournum + 1) + ""
            Case 10
                lblPnum.Text = "Jack"
            Case 11
                lblPnum.Text = "Queen"
            Case 12
                lblPnum.Text = "King"
            Case 13
                lblPnum.Text = "Ace"
        End Select

        'computer
        Select Case cards(cardindex + 26)
            Case 1 To 13 'hearts
                picComSuits.Image = picHeart.Image
                compnum = cards(cardindex + 26)
            Case 14 To 26 'diamonds
                picComSuits.Image = picDiamond.Image
                compnum = cards(cardindex + 26) - 13
            Case 27 To 39 'spades
                picComSuits.Image = picSpade.Image
                compnum = cards(cardindex + 26) - 26
            Case 40 To 52 'clubs
                picComSuits.Image = picClubs.Image
                compnum = cards(cardindex + 26) - 39
        End Select
        Select Case compnum
            Case 1 To 9
                lblCnum.Text = Str(compnum + 1) + ""
            Case 10
                lblCnum.Text = "Jack"
            Case 11
                lblCnum.Text = "Queen"
            Case 12
                lblCnum.Text = "King"
            Case 13
                lblCnum.Text = "Ace"
        End Select
        If yournum > compnum Then
            txtPScore.Text = Str(Val(txtPScore.Text) + 2)
        ElseIf yournum < compnum Then
            txtCScore.Text = Str(Val(txtCScore.Text) + 2)
        End If

        cardindex = cardindex + 1
        If cardindex > 26 Then

            btnPlay.Enabled = False

            If Str(txtCScore.Text) < Str(txtPScore.Text) Then
                txtInfo.Text = "Player Won!"
            ElseIf Str(txtCScore.Text) > Str(txtPScore.Text) Then
                txtInfo.Text = "CPU Won :("
            Else
                txtInfo.Text = "Tie lol"
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If btnReset.Text = "Stop" Then
            btnPlay.Enabled = False
            btnReset.Text = "Reset"
        Else
            btnReset.Text = "Stop"
            btnPlay.Text = "New Game"
            btnPlay.Enabled = True
            btnReset.Enabled = False
            txtPScore.Text = ""
            txtCScore.Text = ""
            lblCnum.Text = ""
            lblPnum.Text = ""
            picComSuits.Image = picClear.Image
            picPlayerSuits.Image = picClear.Image

        End If
    End Sub


End Class
