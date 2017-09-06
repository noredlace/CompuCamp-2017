Public Class Form1
  Dim AdjStmtBalance As Single ' adjusted statement balance
  Dim AdjChkBalance As Single 'adjusted checkbook balance
  Private Sub btnStmtBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStmtBalance.Click
    'Read entered statement balance
    AdjStmtBalance = Val(txtStmtBalance.Text)
    'Disable balance, enable deposit and check
    btnStmtBalance.Enabled = False
    btnStmtDeposit.Enabled = True
    btnStmtCheck.Enabled = True
    txtStmtBalance.ReadOnly = True
    txtStmtDeposit.ReadOnly = False
    txtStmtCheck.ReadOnly = False
    btnStmtDeposit.Focus()
  End Sub
  Private Sub btnStmtDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStmtDeposit.Click
    'Account for uncredited deposit
    AdjStmtBalance = AdjStmtBalance + Val(txtStmtDeposit.Text)
    txtAdjStmtBalance.Text = "$" & Format(AdjStmtBalance, "0.00")
  End Sub
  Private Sub btnStmtCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStmtCheck.Click
    'Account for outstanding check
    AdjStmtBalance = AdjStmtBalance - Val(txtStmtCheck.Text)
    txtAdjStmtBalance.Text = "$" & Format(AdjStmtBalance, "0.00")
  End Sub
  Private Sub btnStmtReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStmtReset.Click
    'Reset statement values to defaults
    AdjStmtBalance = 0
    txtStmtBalance.Text = "0"
    txtStmtDeposit.Text = "0"
    txtStmtCheck.Text = "0"
    txtAdjStmtBalance.Text = "0"
    btnStmtBalance.Enabled = True
    btnStmtDeposit.Enabled = False
    btnStmtCheck.Enabled = False
    txtStmtBalance.ReadOnly = False
    txtStmtDeposit.ReadOnly = True
    txtStmtCheck.ReadOnly = True
    btnStmtBalance.Focus()
  End Sub
  Private Sub btnChkBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkBalance.Click
    'Read entered checkbook balance
    AdjChkBalance = Val(txtChkBalance.Text)
    'Disable balance, enabled deposit and charge
    btnChkBalance.Enabled = False
    btnChkDeposit.Enabled = True
    btnChkCharge.Enabled = True
    txtChkBalance.ReadOnly = True
    txtChkDeposit.ReadOnly = False
    txtChkCharge.readonly = False
    btnChkDeposit.Focus()
  End Sub
  Private Sub btnChkDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkDeposit.Click
    'Account for unrecorded deposit
    AdjChkBalance = AdjChkBalance + Val(txtChkDeposit.Text)
    txtAdjChkBalance.Text = "$" & Format(AdjChkBalance, "0.00")
  End Sub
  Private Sub btnChkCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkCharge.Click
    'Account for service charge
    AdjChkBalance = AdjChkBalance - Val(txtChkCharge.Text)
    txtAdjChkBalance.Text = "$" & Format(AdjChkBalance, "0.00")
  End Sub

  Private Sub btnChkReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkReset.Click
    'Reset all checkbook values to defaults
    AdjChkBalance = 0
    txtChkBalance.Text = "0"
    txtChkDeposit.Text = "0"
    txtChkCharge.Text = "0"
    txtAdjChkBalance.Text = "0"
    btnChkBalance.Enabled = True
    btnChkDeposit.Enabled = False
    btnChkCharge.Enabled = False
    txtChkBalance.ReadOnly = False
    txtChkDeposit.ReadOnly = True
    txtChkCharge.ReadOnly = True
    btnChkBalance.Focus()
  End Sub

End Class
