Public Class Form1
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    txtColor.BackColor = Drawing.Color.FromArgb(nudRed.Value, nudGreen.Value, nudBlue.Value)
  End Sub


  Private Sub nudRed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudRed.ValueChanged
    txtColor.BackColor = Drawing.Color.FromArgb(nudRed.Value, nudGreen.Value, nudBlue.Value)
  End Sub

  Private Sub nudGreen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudGreen.ValueChanged
    txtColor.BackColor = Drawing.Color.FromArgb(nudRed.Value, nudGreen.Value, nudBlue.Value)
  End Sub

  Private Sub nudBlue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudBlue.ValueChanged
    txtColor.BackColor = Drawing.Color.FromArgb(nudRed.Value, nudGreen.Value, nudBlue.Value)
  End Sub

End Class
