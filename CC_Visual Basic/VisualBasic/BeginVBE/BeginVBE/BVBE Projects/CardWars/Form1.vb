Public Class Form1
  Dim CardNumber(52) As Integer
  Dim CardIndex As Integer

  Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    'Procedure level variables
    Dim TempValue As Integer
    Dim LoopCounter As Integer
    Dim ItemPicked As Integer
    Dim Remaining As Integer
    Dim MyRandom As New Random
    Dim YourNumber As Integer ' Your card number
    Dim ComputerNumber As Integer ' Computer card number
    If btnNew.Text = "New Game" Then
      'New game clicked
      txtOver.Visible = False
      btnNew.Text = "Next Card"
      btnExit.Text = "Stop"
      'Zero out scores
      txtYouScore.Text = "0"
      txtCompScore.Text = "0"
      'Shuffle cards using one card shuffle code
      'Initialize CardNumbers
      For LoopCounter = 1 To 52
        CardNumber(LoopCounter) = LoopCounter
      Next LoopCounter
      'Work through Remaining values
      'Start at 52 and swap one value
      'at each For/Next loop step
      'After each step, Remaining is decreased by 1
      For Remaining = 52 To 2 Step -1
        'Pick item at random
        ItemPicked = MyRandom.Next(Remaining) + 1
        'Swap picked item with bottom item
        TempValue = CardNumber(Remaining)
        CardNumber(Remaining) = CardNumber(ItemPicked)
        CardNumber(ItemPicked) = TempValue
      Next Remaining
      'Set CardIndex to one
      CardIndex = 1
    End If
    'Display cards
    'Display your card's suit
    'Determine your card's number for comparisons
    Select Case CardNumber(CardIndex)
      Case 1 To 13
        picPlayer.Image = picHeart.Image
        YourNumber = CardNumber(CardIndex)
      Case 14 To 26
        picPlayer.Image = picDiamond.Image
        YourNumber = CardNumber(CardIndex) - 13
      Case 27 To 39
        picPlayer.Image = picClub.Image
        YourNumber = CardNumber(CardIndex) - 26
      Case 40 To 52
        picPlayer.Image = picSpade.Image
        YourNumber = CardNumber(CardIndex) - 39
    End Select
    'Display your card's value
    Select Case YourNumber
      Case 1 To 9
        lblPlayer.Text = Str(YourNumber + 1) + " "
      Case 10
        lblPlayer.Text = "J"
      Case 11
        lblPlayer.Text = "Q"
      Case 12
        lblPlayer.Text = "K"
      Case 13
        lblPlayer.Text = "A"
    End Select
    'Display computer's card suit
    'Determine computer's number for comparisons
    Select Case CardNumber(CardIndex + 26)
      Case 1 To 13
        picComputer.Image = picHeart.Image
        ComputerNumber = CardNumber(CardIndex + 26)
      Case 14 To 26
        picComputer.Image = picDiamond.Image
        ComputerNumber = CardNumber(CardIndex + 26) - 13
      Case 27 To 39
        picComputer.Image = picClub.Image
        ComputerNumber = CardNumber(CardIndex + 26) - 26
      Case 40 To 52
        picComputer.Image = picSpade.Image
        ComputerNumber = CardNumber(CardIndex + 26) - 39
    End Select
    'Display computer card's value
    Select Case ComputerNumber
      Case 1 To 9
        lblComputer.Text = Str(ComputerNumber + 1) + " "
      Case 10
        lblComputer.Text = "J"
      Case 11
        lblComputer.Text = "Q"
      Case 12
        lblComputer.Text = "K"
      Case 13
        lblComputer.Text = "A"
    End Select
    'Compare displayed cards
    If YourNumber > ComputerNumber Then
      'You win
      txtYouScore.Text = Str(Val(txtYouScore.Text) + 2)
    ElseIf ComputerNumber > YourNumber Then
      'Computer win
      txtCompScore.Text = Str(Val(txtCompScore.Text) + 2)
    Else
      'A Tie!
      txtYouScore.Text = Str(Val(txtYouScore.Text) + 1)
      txtCompScore.Text = Str(Val(txtCompScore.Text) + 1)
    End If
    CardIndex = CardIndex + 1
    'Check to see if all cards have been used
    If CardIndex > 26 Then
      'Game over
      txtOver.Visible = True
      btnNew.Text = "New Game"
      btnExit.Text = "Exit"
    End If
  End Sub

  Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    If btnExit.Text = "Exit" Then
      'Stop program
      Me.Close()
    Else
      'Stop game
      txtOver.Visible = True
      btnExit.Text = "Exit"
      btnNew.Text = "New Game"
    End If
  End Sub
End Class
