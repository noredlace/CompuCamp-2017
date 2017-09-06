Public Class Form1
  Dim TheNumber As Integer
  Dim MyGuess As Integer
  Dim MyRandom As New Random


 
  Private Sub btnPick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPick.Click
    If btnPick.Text = "Pick Number" Then
      'Get new number and set controls
      TheNumber = MyRandom.Next(101)
      txtMessage.Text = "I'm thinking of a number between 0 and 100"
      nudGuess.Value = 50
      nudGuess.Enabled = True
      btnCheck.Enabled = True
      btnPick.Text = "Show Answer"
    Else
      'Just show the answer and re-set controls
      txtMessage.Text = "The answer is" + Str(TheNumber)
      nudGuess.Value = TheNumber
      nudGuess.Enabled = False
      btnCheck.Enabled = False
      btnPick.Text = "Pick Number"
    End If
  End Sub

  Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
    'Guess is the updown control value
    MyGuess = nudGuess.Value
    If MyGuess = TheNumber Then
      'Correct guess
      txtMessage.Text = "That's it!!"
      nudGuess.Enabled = False
      btnCheck.Enabled = False
      btnPick.Text = "Pick Number"
    ElseIf MyGuess < TheNumber Then
      'Guess is too low
      txtMessage.Text = "Too low!"
    Else
      'Guess is too high
      txtMessage.Text = "Too high!"
    End If
  End Sub

  Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    Me.Close()
  End Sub
End Class
