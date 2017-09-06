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
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtLoan = New System.Windows.Forms.TextBox
    Me.txtInterest = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtMonths = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtPayment = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.btnCompute = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 17)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(71, 14)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Loan Amount"
    '
    'txtLoan
    '
    Me.txtLoan.Location = New System.Drawing.Point(140, 17)
    Me.txtLoan.Name = "txtLoan"
    Me.txtLoan.TabIndex = 1
    Me.txtLoan.Text = "0"
    Me.txtLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtInterest
    '
    Me.txtInterest.Location = New System.Drawing.Point(140, 44)
    Me.txtInterest.Name = "txtInterest"
    Me.txtInterest.TabIndex = 3
    Me.txtInterest.Text = "0"
    Me.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 44)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(77, 14)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Yearly Interest"
    '
    'txtMonths
    '
    Me.txtMonths.Location = New System.Drawing.Point(140, 71)
    Me.txtMonths.Name = "txtMonths"
    Me.txtMonths.TabIndex = 5
    Me.txtMonths.Text = "0"
    Me.txtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 71)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(97, 14)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Number of Months"
    '
    'txtPayment
    '
    Me.txtPayment.BackColor = System.Drawing.Color.White
    Me.txtPayment.Location = New System.Drawing.Point(140, 98)
    Me.txtPayment.Name = "txtPayment"
    Me.txtPayment.ReadOnly = True
    Me.txtPayment.TabIndex = 7
    Me.txtPayment.TabStop = False
    Me.txtPayment.Text = "0"
    Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 98)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(92, 14)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Monthly Payment"
    '
    'btnCompute
    '
    Me.btnCompute.Location = New System.Drawing.Point(61, 127)
    Me.btnCompute.Name = "btnCompute"
    Me.btnCompute.Size = New System.Drawing.Size(131, 28)
    Me.btnCompute.TabIndex = 8
    Me.btnCompute.Text = "Compute Payment"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(252, 164)
    Me.Controls.Add(Me.btnCompute)
    Me.Controls.Add(Me.txtPayment)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtMonths)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtInterest)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtLoan)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Loan Calculator"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtLoan As System.Windows.Forms.TextBox
  Friend WithEvents txtInterest As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtMonths As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtPayment As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents btnCompute As System.Windows.Forms.Button

End Class
