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
    Me.txtColor = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.nudRed = New System.Windows.Forms.NumericUpDown
    Me.nudGreen = New System.Windows.Forms.NumericUpDown
    Me.Label2 = New System.Windows.Forms.Label
    Me.nudBlue = New System.Windows.Forms.NumericUpDown
    Me.Label3 = New System.Windows.Forms.Label
    CType(Me.nudRed, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtColor
    '
    Me.txtColor.BackColor = System.Drawing.Color.White
    Me.txtColor.Location = New System.Drawing.Point(11, 13)
    Me.txtColor.Multiline = True
    Me.txtColor.Name = "txtColor"
    Me.txtColor.ReadOnly = True
    Me.txtColor.Size = New System.Drawing.Size(266, 120)
    Me.txtColor.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.SystemColors.Control
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.Red
    Me.Label1.Location = New System.Drawing.Point(13, 140)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(18, 21)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "R"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'nudRed
    '
    Me.nudRed.BackColor = System.Drawing.Color.White
    Me.nudRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudRed.ForeColor = System.Drawing.Color.Red
    Me.nudRed.Location = New System.Drawing.Point(35, 140)
    Me.nudRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudRed.Name = "nudRed"
    Me.nudRed.ReadOnly = True
    Me.nudRed.Size = New System.Drawing.Size(58, 26)
    Me.nudRed.TabIndex = 2
    Me.nudRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'nudGreen
    '
    Me.nudGreen.BackColor = System.Drawing.Color.White
    Me.nudGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudGreen.ForeColor = System.Drawing.Color.Green
    Me.nudGreen.Location = New System.Drawing.Point(125, 140)
    Me.nudGreen.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
    Me.nudGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudGreen.Name = "nudGreen"
    Me.nudGreen.ReadOnly = True
    Me.nudGreen.Size = New System.Drawing.Size(58, 26)
    Me.nudGreen.TabIndex = 4
    Me.nudGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.SystemColors.Control
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.Green
    Me.Label2.Location = New System.Drawing.Point(100, 140)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(19, 21)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "G"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'nudBlue
    '
    Me.nudBlue.BackColor = System.Drawing.Color.White
    Me.nudBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudBlue.ForeColor = System.Drawing.Color.Blue
    Me.nudBlue.Location = New System.Drawing.Point(213, 140)
    Me.nudBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudBlue.Name = "nudBlue"
    Me.nudBlue.ReadOnly = True
    Me.nudBlue.Size = New System.Drawing.Size(58, 26)
    Me.nudBlue.TabIndex = 6
    Me.nudBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.SystemColors.Control
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.Blue
    Me.Label3.Location = New System.Drawing.Point(190, 140)
    Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(17, 21)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "B"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Form1
    '

    Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(292, 181)
    Me.Controls.Add(Me.nudBlue)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.nudGreen)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.nudRed)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtColor)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "RGB Colors"
    CType(Me.nudRed, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtColor As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents nudRed As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudGreen As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents nudBlue As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
