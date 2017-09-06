Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.txtStmtBalance = New System.Windows.Forms.TextBox
    Me.txtStmtDeposit = New System.Windows.Forms.TextBox
    Me.btnStmtBalance = New System.Windows.Forms.Button
    Me.btnStmtDeposit = New System.Windows.Forms.Button
    Me.btnStmtCheck = New System.Windows.Forms.Button
    Me.txtStmtCheck = New System.Windows.Forms.TextBox
    Me.btnStmtReset = New System.Windows.Forms.Button
    Me.txtAdjStmtBalance = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.btnChkBalance = New System.Windows.Forms.Button
    Me.txtChkBalance = New System.Windows.Forms.TextBox
    Me.btnChkDeposit = New System.Windows.Forms.Button
    Me.txtChkDeposit = New System.Windows.Forms.TextBox
    Me.btnChkCharge = New System.Windows.Forms.Button
    Me.txtChkCharge = New System.Windows.Forms.TextBox
    Me.btnChkReset = New System.Windows.Forms.Button
    Me.txtAdjChkBalance = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'txtStmtBalance
    '
    Me.txtStmtBalance.Location = New System.Drawing.Point(150, 21)
    Me.txtStmtBalance.Name = "txtStmtBalance"
    Me.txtStmtBalance.TabIndex = 0
    Me.txtStmtBalance.Text = "0"
    Me.txtStmtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtStmtDeposit
    '
    Me.txtStmtDeposit.BackColor = System.Drawing.Color.White
    Me.txtStmtDeposit.Location = New System.Drawing.Point(150, 71)
    Me.txtStmtDeposit.Name = "txtStmtDeposit"
    Me.txtStmtDeposit.ReadOnly = True
    Me.txtStmtDeposit.TabIndex = 1
    Me.txtStmtDeposit.TabStop = False
    Me.txtStmtDeposit.Text = "0"
    Me.txtStmtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnStmtBalance
    '
    Me.btnStmtBalance.Location = New System.Drawing.Point(15, 21)
    Me.btnStmtBalance.Name = "btnStmtBalance"
    Me.btnStmtBalance.Size = New System.Drawing.Size(126, 43)
    Me.btnStmtBalance.TabIndex = 8
    Me.btnStmtBalance.Text = "Enter Statement Balance"
    '
    'btnStmtDeposit
    '
    Me.btnStmtDeposit.Enabled = False
    Me.btnStmtDeposit.Location = New System.Drawing.Point(15, 71)
    Me.btnStmtDeposit.Name = "btnStmtDeposit"
    Me.btnStmtDeposit.Size = New System.Drawing.Size(126, 43)
    Me.btnStmtDeposit.TabIndex = 9
    Me.btnStmtDeposit.Text = "Add Uncredited Deposit"
    '
    'btnStmtCheck
    '
    Me.btnStmtCheck.Enabled = False
    Me.btnStmtCheck.Location = New System.Drawing.Point(15, 122)
    Me.btnStmtCheck.Name = "btnStmtCheck"
    Me.btnStmtCheck.Size = New System.Drawing.Size(126, 43)
    Me.btnStmtCheck.TabIndex = 11
    Me.btnStmtCheck.Text = "Subtract Outstanding Check"
    '
    'txtStmtCheck
    '
    Me.txtStmtCheck.BackColor = System.Drawing.Color.White
    Me.txtStmtCheck.Location = New System.Drawing.Point(150, 122)
    Me.txtStmtCheck.Name = "txtStmtCheck"
    Me.txtStmtCheck.ReadOnly = True
    Me.txtStmtCheck.TabIndex = 10
    Me.txtStmtCheck.TabStop = False
    Me.txtStmtCheck.Text = "0"
    Me.txtStmtCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnStmtReset
    '
    Me.btnStmtReset.Location = New System.Drawing.Point(86, 210)
    Me.btnStmtReset.Name = "btnStmtReset"
    Me.btnStmtReset.Size = New System.Drawing.Size(126, 43)
    Me.btnStmtReset.TabIndex = 13
    Me.btnStmtReset.Text = "Reset Statement Values"
    '
    'txtAdjStmtBalance
    '
    Me.txtAdjStmtBalance.BackColor = System.Drawing.Color.White
    Me.txtAdjStmtBalance.Location = New System.Drawing.Point(150, 172)
    Me.txtAdjStmtBalance.Name = "txtAdjStmtBalance"
    Me.txtAdjStmtBalance.ReadOnly = True
    Me.txtAdjStmtBalance.TabIndex = 12
    Me.txtAdjStmtBalance.TabStop = False
    Me.txtAdjStmtBalance.Text = "0"
    Me.txtAdjStmtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(41, 171)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(100, 31)
    Me.Label1.TabIndex = 14
    Me.Label1.Text = "Adjusted Statement Balance"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'btnChkBalance
    '
    Me.btnChkBalance.Location = New System.Drawing.Point(400, 21)
    Me.btnChkBalance.Name = "btnChkBalance"
    Me.btnChkBalance.Size = New System.Drawing.Size(126, 43)
    Me.btnChkBalance.TabIndex = 16
    Me.btnChkBalance.Text = "Enter Checkbook Balance"
    '
    'txtChkBalance
    '
    Me.txtChkBalance.Location = New System.Drawing.Point(293, 21)
    Me.txtChkBalance.Name = "txtChkBalance"
    Me.txtChkBalance.TabIndex = 15
    Me.txtChkBalance.Text = "0"
    Me.txtChkBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnChkDeposit
    '
    Me.btnChkDeposit.Enabled = False
    Me.btnChkDeposit.Location = New System.Drawing.Point(400, 71)
    Me.btnChkDeposit.Name = "btnChkDeposit"
    Me.btnChkDeposit.Size = New System.Drawing.Size(126, 43)
    Me.btnChkDeposit.TabIndex = 18
    Me.btnChkDeposit.Text = "Add Uncredited Deposit"
    '
    'txtChkDeposit
    '
    Me.txtChkDeposit.BackColor = System.Drawing.Color.White
    Me.txtChkDeposit.Location = New System.Drawing.Point(293, 71)
    Me.txtChkDeposit.Name = "txtChkDeposit"
    Me.txtChkDeposit.ReadOnly = True
    Me.txtChkDeposit.TabIndex = 17
    Me.txtChkDeposit.TabStop = False
    Me.txtChkDeposit.Text = "0"
    Me.txtChkDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnChkCharge
    '
    Me.btnChkCharge.Enabled = False
    Me.btnChkCharge.Location = New System.Drawing.Point(400, 121)
    Me.btnChkCharge.Name = "btnChkCharge"
    Me.btnChkCharge.Size = New System.Drawing.Size(126, 43)
    Me.btnChkCharge.TabIndex = 20
    Me.btnChkCharge.Text = "Subtract Charge / Forgotten Check"
    '
    'txtChkCharge
    '
    Me.txtChkCharge.BackColor = System.Drawing.Color.White
    Me.txtChkCharge.Location = New System.Drawing.Point(293, 121)
    Me.txtChkCharge.Name = "txtChkCharge"
    Me.txtChkCharge.ReadOnly = True
    Me.txtChkCharge.TabIndex = 19
    Me.txtChkCharge.TabStop = False
    Me.txtChkCharge.Text = "0"
    Me.txtChkCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnChkReset
    '
    Me.btnChkReset.Location = New System.Drawing.Point(341, 210)
    Me.btnChkReset.Name = "btnChkReset"
    Me.btnChkReset.Size = New System.Drawing.Size(126, 43)
    Me.btnChkReset.TabIndex = 22
    Me.btnChkReset.Text = "Reset Checkbook Values"
    '
    'txtAdjChkBalance
    '
    Me.txtAdjChkBalance.BackColor = System.Drawing.Color.White
    Me.txtAdjChkBalance.Location = New System.Drawing.Point(293, 171)
    Me.txtAdjChkBalance.Name = "txtAdjChkBalance"
    Me.txtAdjChkBalance.ReadOnly = True
    Me.txtAdjChkBalance.TabIndex = 21
    Me.txtAdjChkBalance.TabStop = False
    Me.txtAdjChkBalance.Text = "0"
    Me.txtAdjChkBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(400, 171)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(109, 31)
    Me.Label2.TabIndex = 23
    Me.Label2.Text = "Adjusted Checkbook Balance"
    '
    'Label3
    '
    Me.Label3.BackColor = System.Drawing.Color.Black
    Me.Label3.Location = New System.Drawing.Point(266, 22)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(10, 229)
    Me.Label3.TabIndex = 24
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(542, 263)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.btnChkReset)
    Me.Controls.Add(Me.txtAdjChkBalance)
    Me.Controls.Add(Me.btnChkCharge)
    Me.Controls.Add(Me.txtChkCharge)
    Me.Controls.Add(Me.btnChkDeposit)
    Me.Controls.Add(Me.txtChkDeposit)
    Me.Controls.Add(Me.btnChkBalance)
    Me.Controls.Add(Me.txtChkBalance)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnStmtReset)
    Me.Controls.Add(Me.txtAdjStmtBalance)
    Me.Controls.Add(Me.btnStmtCheck)
    Me.Controls.Add(Me.txtStmtCheck)
    Me.Controls.Add(Me.btnStmtDeposit)
    Me.Controls.Add(Me.btnStmtBalance)
    Me.Controls.Add(Me.txtStmtDeposit)
    Me.Controls.Add(Me.txtStmtBalance)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Checkbook Balancer"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtStmtBalance As System.Windows.Forms.TextBox
  Friend WithEvents txtStmtDeposit As System.Windows.Forms.TextBox
  Friend WithEvents btnStmtBalance As System.Windows.Forms.Button
  Friend WithEvents btnStmtDeposit As System.Windows.Forms.Button
  Friend WithEvents btnStmtCheck As System.Windows.Forms.Button
  Friend WithEvents txtStmtCheck As System.Windows.Forms.TextBox
  Friend WithEvents btnStmtReset As System.Windows.Forms.Button
  Friend WithEvents txtAdjStmtBalance As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnChkBalance As System.Windows.Forms.Button
  Friend WithEvents txtChkBalance As System.Windows.Forms.TextBox
  Friend WithEvents btnChkDeposit As System.Windows.Forms.Button
  Friend WithEvents txtChkDeposit As System.Windows.Forms.TextBox
  Friend WithEvents btnChkCharge As System.Windows.Forms.Button
  Friend WithEvents txtChkCharge As System.Windows.Forms.TextBox
  Friend WithEvents btnChkReset As System.Windows.Forms.Button
  Friend WithEvents txtAdjChkBalance As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
