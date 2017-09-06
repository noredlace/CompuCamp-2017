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
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtWeeks = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDepositHeading = New System.Windows.Forms.Label()
        Me.lblTotalHeading = New System.Windows.Forms.Label()
        Me.lblInterestHeading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(164, 14)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 26)
        Me.txtDeposit.TabIndex = 3
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeeks
        '
        Me.txtWeeks.Location = New System.Drawing.Point(143, 43)
        Me.txtWeeks.Name = "txtWeeks"
        Me.txtWeeks.Size = New System.Drawing.Size(100, 26)
        Me.txtWeeks.TabIndex = 4
        Me.txtWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(143, 72)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.Control
        Me.btnCompute.Location = New System.Drawing.Point(39, 106)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(85, 31)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(143, 106)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 31)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblDepositHeading
        '
        Me.lblDepositHeading.AutoSize = True
        Me.lblDepositHeading.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositHeading.Location = New System.Drawing.Point(10, 14)
        Me.lblDepositHeading.Name = "lblDepositHeading"
        Me.lblDepositHeading.Size = New System.Drawing.Size(148, 23)
        Me.lblDepositHeading.TabIndex = 0
        Me.lblDepositHeading.Text = "Weekly Deposit"
        '
        'lblTotalHeading
        '
        Me.lblTotalHeading.AutoSize = True
        Me.lblTotalHeading.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHeading.Location = New System.Drawing.Point(12, 72)
        Me.lblTotalHeading.Name = "lblTotalHeading"
        Me.lblTotalHeading.Size = New System.Drawing.Size(126, 23)
        Me.lblTotalHeading.TabIndex = 2
        Me.lblTotalHeading.Text = "Total Savings"
        '
        'lblInterestHeading
        '
        Me.lblInterestHeading.AutoSize = True
        Me.lblInterestHeading.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestHeading.Location = New System.Drawing.Point(10, 43)
        Me.lblInterestHeading.Name = "lblInterestHeading"
        Me.lblInterestHeading.Size = New System.Drawing.Size(168, 23)
        Me.lblInterestHeading.TabIndex = 8
        Me.lblInterestHeading.Text = "Number of Weeks"
        '
        'Form1
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(449, 205)
        Me.Controls.Add(Me.lblInterestHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtWeeks)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.lblTotalHeading)
        Me.Controls.Add(Me.lblDepositHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
  Friend WithEvents txtWeeks As System.Windows.Forms.TextBox
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents btnCompute As System.Windows.Forms.Button
  Friend WithEvents btnExit As System.Windows.Forms.Button
  Friend WithEvents lblDepositHeading As System.Windows.Forms.Label
  Friend WithEvents lblTotalHeading As System.Windows.Forms.Label
  Friend WithEvents lblInterestHeading As System.Windows.Forms.Label

End Class
