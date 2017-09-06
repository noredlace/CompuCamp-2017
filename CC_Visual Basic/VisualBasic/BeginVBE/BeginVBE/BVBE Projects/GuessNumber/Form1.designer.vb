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
    Me.nudGuess = New System.Windows.Forms.NumericUpDown()
    Me.btnCheck = New System.Windows.Forms.Button()
    Me.txtMessage = New System.Windows.Forms.TextBox()
    Me.btnPick = New System.Windows.Forms.Button()
    Me.btnExit = New System.Windows.Forms.Button()
    CType(Me.nudGuess, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'nudGuess
    '
    Me.nudGuess.BackColor = System.Drawing.Color.White
    Me.nudGuess.Enabled = False
    Me.nudGuess.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudGuess.ForeColor = System.Drawing.Color.Red
    Me.nudGuess.Location = New System.Drawing.Point(89, 86)
    Me.nudGuess.Name = "nudGuess"
    Me.nudGuess.ReadOnly = True
    Me.nudGuess.Size = New System.Drawing.Size(120, 32)
    Me.nudGuess.TabIndex = 0
    Me.nudGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.nudGuess.Value = New Decimal(New Integer() {50, 0, 0, 0})
    '
    'btnCheck
    '
    Me.btnCheck.BackColor = System.Drawing.SystemColors.Control
    Me.btnCheck.Enabled = False
    Me.btnCheck.Location = New System.Drawing.Point(89, 125)
    Me.btnCheck.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.btnCheck.Name = "btnCheck"
    Me.btnCheck.Size = New System.Drawing.Size(120, 28)
    Me.btnCheck.TabIndex = 2
    Me.btnCheck.Text = "Check Answer"
    Me.btnCheck.UseVisualStyleBackColor = False
    '
    'txtMessage
    '
    Me.txtMessage.BackColor = System.Drawing.Color.White
    Me.txtMessage.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMessage.ForeColor = System.Drawing.Color.Blue
    Me.txtMessage.Location = New System.Drawing.Point(15, 11)
    Me.txtMessage.Multiline = True
    Me.txtMessage.Name = "txtMessage"
    Me.txtMessage.Size = New System.Drawing.Size(263, 68)
    Me.txtMessage.TabIndex = 3
    Me.txtMessage.TabStop = False
    Me.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnPick
    '
    Me.btnPick.BackColor = System.Drawing.SystemColors.Control
    Me.btnPick.Location = New System.Drawing.Point(15, 155)
    Me.btnPick.Name = "btnPick"
    Me.btnPick.Size = New System.Drawing.Size(108, 29)
    Me.btnPick.TabIndex = 4
    Me.btnPick.Text = "Pick Number"
    Me.btnPick.UseVisualStyleBackColor = False
    '
    'btnExit
    '
    Me.btnExit.BackColor = System.Drawing.SystemColors.Control
    Me.btnExit.Location = New System.Drawing.Point(172, 155)
    Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(108, 29)
    Me.btnExit.TabIndex = 5
    Me.btnExit.Text = "Exit"
    Me.btnExit.UseVisualStyleBackColor = False
    '
    'Form1
    '
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(292, 190)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnPick)
    Me.Controls.Add(Me.txtMessage)
    Me.Controls.Add(Me.btnCheck)
    Me.Controls.Add(Me.nudGuess)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Guess the Number"
    CType(Me.nudGuess, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents nudGuess As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnCheck As System.Windows.Forms.Button
  Friend WithEvents txtMessage As System.Windows.Forms.TextBox
  Friend WithEvents btnPick As System.Windows.Forms.Button
  Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
