Public Class Form1
  Private Sub btnShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShrink.Click
    'Shrink the form
    'Decrease the form height by 10 pixels
    Me.Height = Me.Height - 10
    'Decrease the form width by 10 pixels
    Me.Width = Me.Width - 10
  End Sub
  Private Sub btnGrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrow.Click
    'Grow the form
    'Increase the form height by 10 pixels
    Me.Height = Me.Height + 10
    'Increase the form width by 10 pixels
    Me.Width = Me.Width + 10
  End Sub
  Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click
    'Make form red
    Me.BackColor = Color.Red
  End Sub
  Private Sub btnBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlue.Click
    'Make form blue
    Me.BackColor = Color.Blue
  End Sub
  Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
    'Hide all buttons but btnShow
    btnGrow.Visible = False
    btnShrink.Visible = False
    btnHide.Visible = False
    btnRed.Visible = False
    btnBlue.Visible = False
    'Show btnShow button
    btnShow.Visible = True
  End Sub
  Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
    'Show all buttons but btnShow
    btnGrow.Visible = True
    btnShrink.Visible = True
    btnHide.Visible = True
    btnRed.Visible = True
    btnBlue.Visible = True
    'Hide btnShow button
    btnShow.Visible = False
  End Sub
  Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
    'Grow the form
    'Increase the form height by 10 pixels
    Me.Height = Me.Height + 10
    'Increase the form width by 10 pixels
    Me.Width = Me.Width + 10
  End Sub
End Class
