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
    Me.lblMessage = New System.Windows.Forms.Label()
    Me.grpGuess = New System.Windows.Forms.GroupBox()
    Me.btnCheck = New System.Windows.Forms.Button()
    Me.txtGuess = New System.Windows.Forms.TextBox()
    Me.grpChoice = New System.Windows.Forms.GroupBox()
    Me.btnStop = New System.Windows.Forms.Button()
    Me.btnNew = New System.Windows.Forms.Button()
    Me.grpGuesses = New System.Windows.Forms.GroupBox()
    Me.txtGuesses = New System.Windows.Forms.TextBox()
    Me.grpGuess.SuspendLayout()
    Me.grpChoice.SuspendLayout()
    Me.grpGuesses.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblMessage
    '
    Me.lblMessage.BackColor = System.Drawing.Color.White
    Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMessage.ForeColor = System.Drawing.Color.Blue
    Me.lblMessage.Location = New System.Drawing.Point(15, 11)
    Me.lblMessage.Name = "lblMessage"
    Me.lblMessage.Size = New System.Drawing.Size(184, 93)
    Me.lblMessage.TabIndex = 0
    Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'grpGuess
    '
    Me.grpGuess.BackColor = System.Drawing.Color.Red
    Me.grpGuess.Controls.Add(Me.btnCheck)
    Me.grpGuess.Controls.Add(Me.txtGuess)
    Me.grpGuess.Location = New System.Drawing.Point(15, 111)
    Me.grpGuess.Name = "grpGuess"
    Me.grpGuess.Size = New System.Drawing.Size(184, 78)
    Me.grpGuess.TabIndex = 1
    Me.grpGuess.TabStop = False
    Me.grpGuess.Visible = False
    '
    'btnCheck
    '
    Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.btnCheck.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCheck.Location = New System.Drawing.Point(21, 49)
    Me.btnCheck.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.btnCheck.Name = "btnCheck"
    Me.btnCheck.Size = New System.Drawing.Size(148, 23)
    Me.btnCheck.TabIndex = 1
    Me.btnCheck.Text = "Check Guess"
    Me.btnCheck.UseVisualStyleBackColor = False
    '
    'txtGuess
    '
    Me.txtGuess.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtGuess.Location = New System.Drawing.Point(21, 15)
    Me.txtGuess.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.txtGuess.MaxLength = 4
    Me.txtGuess.Name = "txtGuess"
    Me.txtGuess.Size = New System.Drawing.Size(148, 31)
    Me.txtGuess.TabIndex = 0
    Me.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'grpChoice
    '
    Me.grpChoice.BackColor = System.Drawing.Color.Red
    Me.grpChoice.Controls.Add(Me.btnStop)
    Me.grpChoice.Controls.Add(Me.btnNew)
    Me.grpChoice.Location = New System.Drawing.Point(15, 196)
    Me.grpChoice.Name = "grpChoice"
    Me.grpChoice.Size = New System.Drawing.Size(184, 45)
    Me.grpChoice.TabIndex = 2
    Me.grpChoice.TabStop = False
    '
    'btnStop
    '
    Me.btnStop.BackColor = System.Drawing.SystemColors.Control
    Me.btnStop.Enabled = False
    Me.btnStop.Location = New System.Drawing.Point(94, 16)
    Me.btnStop.Name = "btnStop"
    Me.btnStop.Size = New System.Drawing.Size(75, 23)
    Me.btnStop.TabIndex = 1
    Me.btnStop.Text = "Stop"
    Me.btnStop.UseVisualStyleBackColor = False
    '
    'btnNew
    '
    Me.btnNew.BackColor = System.Drawing.SystemColors.Control
    Me.btnNew.Location = New System.Drawing.Point(12, 16)
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Size = New System.Drawing.Size(75, 23)
    Me.btnNew.TabIndex = 0
    Me.btnNew.Text = "New Game"
    Me.btnNew.UseVisualStyleBackColor = False
    '
    'grpGuesses
    '
    Me.grpGuesses.BackColor = System.Drawing.Color.Red
    Me.grpGuesses.Controls.Add(Me.txtGuesses)
    Me.grpGuesses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpGuesses.ForeColor = System.Drawing.Color.Yellow
    Me.grpGuesses.Location = New System.Drawing.Point(219, 8)
    Me.grpGuesses.Name = "grpGuesses"
    Me.grpGuesses.Size = New System.Drawing.Size(159, 243)
    Me.grpGuesses.TabIndex = 3
    Me.grpGuesses.TabStop = False
    Me.grpGuesses.Text = "Your Guesses"
    '
    'txtGuesses
    '
    Me.txtGuesses.BackColor = System.Drawing.Color.White
    Me.txtGuesses.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtGuesses.Location = New System.Drawing.Point(11, 20)
    Me.txtGuesses.Multiline = True
    Me.txtGuesses.Name = "txtGuesses"
    Me.txtGuesses.ReadOnly = True
    Me.txtGuesses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtGuesses.Size = New System.Drawing.Size(142, 217)
    Me.txtGuesses.TabIndex = 0
    Me.txtGuesses.TabStop = False
    '
    'Form1
    '
    Me.ClientSize = New System.Drawing.Size(390, 259)
    Me.Controls.Add(Me.grpGuesses)
    Me.Controls.Add(Me.grpChoice)
    Me.Controls.Add(Me.grpGuess)
    Me.Controls.Add(Me.lblMessage)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Decode"
    Me.grpGuess.ResumeLayout(False)
    Me.grpGuess.PerformLayout()
    Me.grpChoice.ResumeLayout(False)
    Me.grpGuesses.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lblMessage As System.Windows.Forms.Label
  Friend WithEvents grpGuess As System.Windows.Forms.GroupBox
  Friend WithEvents btnCheck As System.Windows.Forms.Button
  Friend WithEvents txtGuess As System.Windows.Forms.TextBox
  Friend WithEvents grpChoice As System.Windows.Forms.GroupBox
  Friend WithEvents btnStop As System.Windows.Forms.Button
  Friend WithEvents btnNew As System.Windows.Forms.Button
  Friend WithEvents grpGuesses As System.Windows.Forms.GroupBox
  Friend WithEvents txtGuesses As System.Windows.Forms.TextBox

End Class
