Public Class Form1
  Dim XTurn As Boolean ' if True, it's X's turn
  Dim SquareClicked As TextBox ' tells which text box is clicked
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'make it X's turn
    XTurn = True
  End Sub
  Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
    'Clear board
    txtTopLeft.Text = ""
    txtTopMiddle.Text = ""
    txtTopRight.Text = ""
    txtMiddleLeft.Text = ""
    txtMiddleMiddle.Text = ""
    txtMiddleRight.Text = ""
    txtBottomLeft.Text = ""
    txtBottomMiddle.Text = ""
    txtBottomRight.Text = ""
    'Make it X's turn
    XTurn = True
    txtMessage.Text = "X's Turn"
  End Sub
  Private Sub Mark_Square()
    'Place mark in SquareClicked (if none there already)
    If SquareClicked.Text = "" Then
      If XTurn Then
        SquareClicked.Text = "X"
        XTurn = False
        txtMessage.Text = "O's Turn"
      Else
        SquareClicked.Text = "O"
        XTurn = True
        txtMessage.Text = "X's Turn"
      End If
    End If
  End Sub
  Private Sub txtTopLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTopLeft.Click
    SquareClicked = txtTopLeft
    Call Mark_Square()
  End Sub
  Private Sub txtTopMiddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTopMiddle.Click
    SquareClicked = txtTopMiddle
    Call Mark_Square()
  End Sub
  Private Sub txtTopRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTopRight.Click
    SquareClicked = txtTopRight
    Call Mark_Square()
  End Sub
  Private Sub txtMiddleLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiddleLeft.Click
    SquareClicked = txtMiddleLeft
    Call Mark_Square()
  End Sub
  Private Sub txtMiddleMiddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiddleMiddle.Click
    SquareClicked = txtMiddleMiddle
    Call Mark_Square()
  End Sub
  Private Sub txtMiddleRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiddleRight.Click
    SquareClicked = txtMiddleRight
    Call Mark_Square()
  End Sub
  Private Sub txtBottomLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBottomLeft.Click
    SquareClicked = txtBottomLeft
    Call Mark_Square()
  End Sub
  Private Sub txtBottomMiddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBottomMiddle.Click
    SquareClicked = txtBottomMiddle
    Call Mark_Square()
  End Sub
  Private Sub txtBottomRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBottomRight.Click
    SquareClicked = txtBottomRight
    Call Mark_Square()
  End Sub
End Class
