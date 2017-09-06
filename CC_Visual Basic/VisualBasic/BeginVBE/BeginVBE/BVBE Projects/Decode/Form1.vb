Public Class Form1
  Dim GameOver As Boolean
  Dim MyGuess As String
  Dim ComputerCode As String
  Dim ComputerNumbers(4) As String
  Dim MyRandom As New Random
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    lblMessage.Text = "Click New Game"
    btnNew.Focus()
  End Sub
  Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    Dim NArray(10) As String
    Dim T As Integer
    Dim I As Integer, J As Integer
    'Start new game
    btnStop.Enabled = True
    GameOver = False
    lblMessage.Text = ""
    txtGuesses.Text = ""
    txtGuess.Text = ""
    btnNew.Enabled = False
    'Choose code using modified version of card shuffling routine
    'Order all digits initially
    ComputerCode = ""
    For I = 1 To 10 : NArray(I) = I - 1 : Next I
    'J is number of integers remaining
    For J = 10 To 7 Step -1
      I = MyRandom.Next(J) + 1
      ComputerNumbers(11 - J) = NArray(I)
      ComputerCode = ComputerCode & NArray(I)
      T = NArray(J)
      NArray(J) = NArray(I)
      NArray(I) = T
    Next J
    lblMessage.Text = "I have a 4 digit code." & ControlChars.CrLf & "Try to guess it."
    grpGuess.Visible = True
    txtGuess.Focus()
  End Sub
  Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
    'Stop current game
    grpGuess.Visible = False
    btnNew.Enabled = True
    btnStop.Enabled = False
    If Not (GameOver) Then
      lblMessage.Text = "Game Stopped" & ControlChars.CrLf & "My code was - " & ComputerCode
    End If
    btnNew.Focus()
  End Sub
  Private Sub txtGuess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuess.KeyPress
    'Allow numbers only
    If e.KeyChar = ControlChars.Cr Then
      btnCheck.PerformClick()
    ElseIf (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = ControlChars.Back Then
      e.Handled = False
    Else
      e.Handled = True
    End If
  End Sub
  Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
    Dim W As String
    Dim WNumbers(4) As String
    Dim I As Integer, J As Integer, K1 As Integer, K2 As Integer
    Dim Distinct As Boolean
    'Check your guess
    W = txtGuess.Text
    'Check length validity
    If Len(W) <> 4 Then
      lblMessage.Text = "Guess must have 4 numbers ..." & ControlChars.CrLf & "Try again!"
      txtGuess.Focus()
      Exit Sub
    Else
      'Get numbers and make sure they are distinct
      Distinct = True
      For I = 1 To 4
        WNumbers(I) = Mid(W, I, 1)
        If I <> 1 Then
          For J = I - 1 To 1 Step -1
            If WNumbers(I) = WNumbers(J) Then
              Distinct = False
            End If
          Next J
        End If
      Next I
      If Not (Distinct) Then
        lblMessage.Text = "Numbers must all be different ..." & ControlChars.CrLf & "Try again!"
        txtGuess.Focus()
        Exit Sub
      End If
      If W = ComputerCode Then
        lblMessage.Text = "Congratulations!" & ControlChars.CrLf & "That's my code - " & ComputerCode
        GameOver = True
        btnStop.PerformClick()
        Exit Sub
      Else
        'Compute score
        K1 = 0
        K2 = 0
        For I = 1 To 4
          For J = 1 To 4
            If WNumbers(J) = ComputerNumbers(I) Then K1 = K1 + 1
          Next J
          If WNumbers(I) = ComputerNumbers(I) Then K2 = K2 + 1
        Next I
        lblMessage.Text = "Your guess - " & W & ControlChars.CrLf & Format(K1, "0") & " digit(s) correct" & ControlChars.CrLf & Format(K2, "0") & " digit(s) in proper place"
        txtGuesses.Text = W & "   " & Format(K1, "0") & "/" & Format(K2, "0") & ControlChars.CrLf & txtGuesses.Text
        txtGuess.Text = ""
        txtGuess.Focus()
      End If
    End If
  End Sub


End Class
