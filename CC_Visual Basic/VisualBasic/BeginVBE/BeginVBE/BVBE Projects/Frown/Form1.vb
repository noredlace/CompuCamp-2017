Public Class Form1
  Dim GameOver As Boolean, WhoseTurn As Integer
  Dim Dice1 As Integer, Dice2 As Integer
  Dim YouScore As Integer, ComputerScore As Integer
  Dim YouTotal As Integer, ComputerTotal As Integer
  Dim MyRandom As New Random
  Const WIN As Integer = 100
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Initialize dice to frowns
    lblMessage.Text = "Click New Game To Start"
    picDice1.Image = picDots1.Image
    picDice2.Image = picDots1.Image
    btnNew.Focus()
  End Sub
  Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    'Start new game
    GameOver = False
    lblMessage.Text = ""
    btnNew.Enabled = False
    btnStop.Enabled = True
    YouScore = 0
    lblYouScore.Text = ""
    ComputerScore = 0
    lblComputerScore.Text = ""
    YouTotal = 0
    lblYouTotal.Text = "0"
    ComputerTotal = 0
    lblComputerTotal.Text = "0"
    If MyRandom.Next(100) < 50 Then
      'Computer goes first
      WhoseTurn = 0
      lblComputerScore.Text = "0"
      lblMessage.Text = "I'll roll first."
      'must call instead of performclick since button is not
      'enabeld
      Call btnRoll_Click(Nothing, Nothing)
    Else
      'You go first
      WhoseTurn = 1
      lblYouScore.Text = "0"
      lblMessage.Text = "You roll first."
      btnRoll.Enabled = True
      btnRoll.Focus()
    End If
  End Sub
  Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
    'Stop current game
    timComputer.Enabled = False
    btnNew.Enabled = True
    btnStop.Enabled = False
    btnRoll.Enabled = False
    btnPass.Enabled = False
    If Not (GameOver) Then
      lblMessage.Text = "Game Stopped"
    End If
    btnNew.Focus()
  End Sub
  Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click
    'Dice rolling
    Dim Dice1 As Integer, Dice2 As Integer
    'Roll Dice 1 and set display
    Dice1 = MyRandom.Next(6) + 1
    Select Case Dice1
      Case 1
        picDice1.Image = picDots1.Image
      Case 2
        picDice1.Image = picDots2.Image
      Case 3
        picDice1.Image = picDots3.Image
      Case 4
        picDice1.Image = picDots4.Image
      Case 5
        picDice1.Image = picDots5.Image
      Case 6
        picDice1.Image = picDots6.Image
    End Select
    'Roll Dice 2 and set display
    Dice2 = MyRandom.Next(6) + 1
    Select Case Dice2
      Case 1
        picDice2.Image = picDots1.Image
      Case 2
        picDice2.Image = picDots2.Image
      Case 3
        picDice2.Image = picDots3.Image
      Case 4
        picDice2.Image = picDots4.Image
      Case 5
        picDice2.Image = picDots5.Image
      Case 6
        picDice2.Image = picDots6.Image
    End Select
    picDice1.Refresh()
    picDice2.Refresh()
    If WhoseTurn = 0 Then
      'Computer rolled
      If Dice1 > 1 And Dice2 > 1 Then
        'No frowns
        ComputerScore = ComputerScore + Dice1 + Dice2
        lblComputerScore.Text = Format(ComputerScore, "0")
        timComputer.Enabled = True
        lblMessage.Text = lblMessage.Text + " Let me think ..."
        Exit Sub
      ElseIf Dice1 = 1 And Dice2 = 1 Then
        'Two frowns - lose everything - must pass
        lblMessage.Text = lblMessage.Text + ControlChars.CrLf + "I lost all my points!" + ControlChars.CrLf + "Your turn."
        ComputerTotal = 0
        lblComputerTotal.Text = "0"
      Else
        'One frown - must pass
        lblMessage.Text = lblMessage.Text + ControlChars.CrLf + "I lost my turn." + ControlChars.CrLf + "Your turn."
      End If
      ComputerScore = 0
      lblComputerScore.Text = ""
      WhoseTurn = 1
      btnRoll.Enabled = True
      btnRoll.Focus()
    Else
      'You rolled
      lblMessage.Text = "Still your turn."
      btnPass.Enabled = True
      If Dice1 > 1 And Dice2 > 1 Then
        'No frowns
        YouScore = YouScore + Dice1 + Dice2
        lblYouScore.Text = Format(YouScore, "0")
      ElseIf Dice1 = 1 And Dice2 = 1 Then
        'Two frowns - lose everything - must pass
        YouScore = 0
        YouTotal = 0
        lblMessage.Text = "You lost everything." + ControlChars.CrLf + "You must pass to me."
        btnRoll.Enabled = False
        btnPass.Focus()
      Else
        'One frown - must pass
        YouScore = 0
        lblMessage.Text = "You lost your turn." + ControlChars.CrLf + "You must pass to me."
        btnRoll.Enabled = False
        btnPass.Focus()
      End If
    End If
  End Sub
  Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
    'You passed dice to computer
    btnRoll.Enabled = False
    btnPass.Enabled = False
    WhoseTurn = 0
    YouTotal = YouTotal + YouScore
    YouScore = 0
    lblYouScore.Text = ""
    lblYouTotal.Text = Format(YouTotal, "0")
    If YouTotal >= WIN Then
      GameOver = True
      lblMessage.Text = "You win!!"
      btnStop.PerformClick()
    Else
      lblMessage.Text = "I'll roll now."
      'call btnroll routine, we can't use performclick method
      'since button is not enabled at this point
      Call btnRoll_Click(Nothing, Nothing)
    End If
  End Sub
  Private Sub timComputer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timComputer.Tick
    Dim V As Integer
    Dim Odds As Single
    'Computer turn - decide wheter to roll again or pass
    timComputer.Enabled = False
    V = ComputerScore + ComputerTotal
    If V >= WIN Then
      'Computer wins!
      GameOver = True
      lblComputerTotal.Text = Format(V, "0")
      lblMessage.Text = "I win!!"
      btnStop.PerformClick()
      Exit Sub
    ElseIf WIN - YouTotal <= 10 Then
      'If you are close to win, computer rolls again
      lblMessage.Text = "I'll roll again."
      Call btnRoll_Click(Nothing, Nothing)
    Else
      If ComputerTotal >= YouTotal Then
        'If computer already ahead, less likely to roll again
        Odds = ComputerScore / 30
      ElseIf V < YouTotal Then
        'If computer behind, more likely
        Odds = ComputerScore / 50
      Else
        Odds = ComputerScore / 40
      End If
      If CSng(MyRandom.Next(100) / 100) > Odds Then
        lblMessage.Text = "I'll roll again."
        Call btnRoll_Click(Nothing, Nothing)
      Else
        'Stick with roll and pass
        lblMessage.Text = "I pass to you." + ControlChars.CrLf + "Your turn."
        ComputerScore = 0
        ComputerTotal = V
        lblComputerTotal.Text = Format(ComputerTotal, "0")
        lblComputerScore.Text = ""
        WhoseTurn = 1
        btnRoll.Enabled = True
        btnRoll.Focus()
      End If
    End If
  End Sub

End Class
