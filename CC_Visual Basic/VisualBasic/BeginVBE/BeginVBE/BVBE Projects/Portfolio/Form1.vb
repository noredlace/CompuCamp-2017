Public Class Form1
  Dim NumberStocks As Integer
  Dim CurrentStock As Integer
  Dim StockDate(25) As Date
  Dim StockName(25) As String
  Dim StockPrice(25) As Double
  Dim StockShares(25) As Integer
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Load Stock Information
    NumberStocks = 5
    StockDate(1) = "02/01/1999" : StockName(1) = "Big Deal"
    StockPrice(1) = 10 : StockShares(1) = 100
    StockDate(2) = "03/01/1999" : StockName(2) = "Web Winner"
    StockPrice(2) = 20 : StockShares(2) = 300
    StockDate(3) = "04/01/1999" : StockName(3) = "Little Blue"
    StockPrice(3) = 15 : StockShares(3) = 200
    StockDate(4) = "05/01/1999" : StockName(4) = "My Company"
    StockPrice(4) = 40 : StockShares(4) = 400
    StockDate(5) = "05/01/2000" : StockName(5) = "Your Company"
    StockPrice(5) = 30 : StockShares(5) = 200
    txtTodayDate.Text = Format(Today, "MM/dd/yyyy")
    CurrentStock = 1
    Me.Show()
    Call ShowStock()
  End Sub
  Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
    'display previous stock
    If CurrentStock <> 1 Then
      CurrentStock = CurrentStock - 1
      Call ShowStock()
    End If
  End Sub
  Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
    'display next stock
    If CurrentStock <> NumberStocks Then
      CurrentStock = CurrentStock + 1
      Call ShowStock()
    End If
  End Sub
  Private Sub ShowStock()
    'Change displayed stock
    grpStock.Text = StockName(CurrentStock)
    txtDate.Text = StockDate(CurrentStock)
    txtPrice.Text = StockPrice(CurrentStock)
    txtShares.Text = StockShares(CurrentStock)
    txtPaid.Text = Format(StockPrice(CurrentStock) * StockShares(CurrentStock), "0.00")
    'Allow computation of return
    txtToday.Text = ""
    txtValue.Text = "0.00"
    txtReturn.Text = "0.00%"
    txtToday.Focus()
  End Sub
  Private Sub txtToday_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtToday.KeyPress
    'Only allow numbers,decimal backspace
    If e.KeyChar = ControlChars.Cr Then
      'If Return key pressed, then click the compute button
      btnReturn.PerformClick()
    ElseIf (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back Then
      e.Handled = False
    Else
      e.Handled = True
    End If
  End Sub
  Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
    'compute todays value and percent return
    Dim P As Double, V As Double, R As Double
    P = Val(txtToday.Text)
    V = P * StockShares(CurrentStock)
    txtValue.Text = Format(V, "0.00")
    'Daily increase
    R = (V / Val(txtPaid.Text) - 1) / DateDiff(DateInterval.Day, StockDate(CurrentStock), Today)
    'Yearly return
    R = 100 * (365 * R)
    txtReturn.Text = Format(R, "0.00") & "%"
  End Sub
End Class
