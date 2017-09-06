Public Class Form1

  Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
    Dim Loan As Single
    Dim Interest As Single
    Dim Months As Integer
    Dim Payment As Single
    Dim Multiplier As Single
    'Read text boxes
    Loan = Val(txtLoan.Text)
    Interest = Val(txtInterest.Text)
    Months = Val(txtMonths.Text)
    'Compute interest multiplier
    Multiplier = (1 + Interest / 1200) ^ Months
    'Compute payment
    Payment = Loan * Interest * Multiplier / (1200 * (Multiplier - 1))
    txtPayment.Text = "$" & Format(Payment, "0.00")
  End Sub
End Class
