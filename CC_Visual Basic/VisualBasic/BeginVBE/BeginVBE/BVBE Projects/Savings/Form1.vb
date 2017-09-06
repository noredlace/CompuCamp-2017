Public Class Form1
  Dim Deposit As Integer
  Dim Weeks As Integer
  Dim Total As Integer
    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Deposit = Val(txtDeposit.Text)
        Weeks = Val(txtWeeks.Text)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    Me.Close()
  End Sub

End Class
