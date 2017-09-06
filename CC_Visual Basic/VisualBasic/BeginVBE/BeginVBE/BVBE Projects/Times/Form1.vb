Public Class Form1
  Dim Product As Integer
  Dim NumProb As Integer
  Dim NumRight As Integer
  Dim MyRandom As New Random
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Initialize variables
    NumProb = 0
    NumRight = 0
    'display the first problem
    btnNext.PerformClick()
  End Sub
  Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
    'Generate next multiplication problem
    Dim Number1 As Integer
    Dim Number2 As Integer
    txtAnswer.Text = ""
    lblMessage.Text = ""
    NumProb = NumProb + 1
    'Generate random numbers for factors
    Number1 = MyRandom.Next(10)
    Number2 = MyRandom.Next(10)
    lblNum1.Text = Format(Number1, "0")
    lblNum2.Text = Format(Number2, "0")
    'Find product
    Product = Number1 * Number2
    btnNext.Enabled = False
    txtAnswer.Focus()
  End Sub
  Private Sub txtAnswer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer.KeyPress
    Dim Ans As Integer
    'Check for number only input and for return key
    If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = ControlChars.Back Then
      e.Handled = False
    ElseIf e.KeyChar = ControlChars.Cr Then
      'Check answer and update score
      Ans = Val(txtAnswer.Text)
      If Ans = Product Then
        NumRight = NumRight + 1
        lblMessage.Text = "That's correct!"
      Else
        lblMessage.Text = "Answer is " + Format(Product, "0")
      End If
      lblScore.Text = Format(100 * (NumRight / NumProb), "0") + "%"
      btnNext.Enabled = True
      btnNext.Focus()
    Else
      e.Handled = True
    End If
  End Sub

End Class
