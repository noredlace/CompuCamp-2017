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
    Me.txtMessage = New System.Windows.Forms.TextBox
    Me.txtTopLeft = New System.Windows.Forms.TextBox
    Me.txtMiddleLeft = New System.Windows.Forms.TextBox
    Me.txtBottomLeft = New System.Windows.Forms.TextBox
    Me.txtTopMiddle = New System.Windows.Forms.TextBox
    Me.txtMiddleMiddle = New System.Windows.Forms.TextBox
    Me.txtBottomMiddle = New System.Windows.Forms.TextBox
    Me.txtTopRight = New System.Windows.Forms.TextBox
    Me.txtMiddleRight = New System.Windows.Forms.TextBox
    Me.txtBottomRight = New System.Windows.Forms.TextBox
    Me.TextBox11 = New System.Windows.Forms.TextBox
    Me.TextBox12 = New System.Windows.Forms.TextBox
    Me.TextBox13 = New System.Windows.Forms.TextBox
    Me.TextBox14 = New System.Windows.Forms.TextBox
    Me.btnReset = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'txtMessage
    '
    Me.txtMessage.AutoSize = False
    Me.txtMessage.BackColor = System.Drawing.Color.White
    Me.txtMessage.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMessage.Location = New System.Drawing.Point(17, 11)
    Me.txtMessage.Multiline = True
    Me.txtMessage.Name = "txtMessage"
    Me.txtMessage.ReadOnly = True
    Me.txtMessage.Size = New System.Drawing.Size(208, 43)
    Me.txtMessage.TabIndex = 0
    Me.txtMessage.TabStop = False
    Me.txtMessage.Text = "X's Turn"
    Me.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtTopLeft
    '
    Me.txtTopLeft.AutoSize = False
    Me.txtTopLeft.BackColor = System.Drawing.SystemColors.Control
    Me.txtTopLeft.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTopLeft.ForeColor = System.Drawing.Color.Blue
    Me.txtTopLeft.Location = New System.Drawing.Point(17, 61)
    Me.txtTopLeft.Multiline = True
    Me.txtTopLeft.Name = "txtTopLeft"
    Me.txtTopLeft.ReadOnly = True
    Me.txtTopLeft.Size = New System.Drawing.Size(53, 52)
    Me.txtTopLeft.TabIndex = 1
    Me.txtTopLeft.TabStop = False
    Me.txtTopLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtMiddleLeft
    '
    Me.txtMiddleLeft.AutoSize = False
    Me.txtMiddleLeft.BackColor = System.Drawing.SystemColors.Control
    Me.txtMiddleLeft.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMiddleLeft.ForeColor = System.Drawing.Color.Blue
    Me.txtMiddleLeft.Location = New System.Drawing.Point(17, 137)
    Me.txtMiddleLeft.Multiline = True
    Me.txtMiddleLeft.Name = "txtMiddleLeft"
    Me.txtMiddleLeft.ReadOnly = True
    Me.txtMiddleLeft.Size = New System.Drawing.Size(53, 52)
    Me.txtMiddleLeft.TabIndex = 2
    Me.txtMiddleLeft.TabStop = False
    Me.txtMiddleLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtBottomLeft
    '
    Me.txtBottomLeft.AutoSize = False
    Me.txtBottomLeft.BackColor = System.Drawing.SystemColors.Control
    Me.txtBottomLeft.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBottomLeft.ForeColor = System.Drawing.Color.Blue
    Me.txtBottomLeft.Location = New System.Drawing.Point(17, 213)
    Me.txtBottomLeft.Multiline = True
    Me.txtBottomLeft.Name = "txtBottomLeft"
    Me.txtBottomLeft.ReadOnly = True
    Me.txtBottomLeft.Size = New System.Drawing.Size(53, 52)
    Me.txtBottomLeft.TabIndex = 3
    Me.txtBottomLeft.TabStop = False
    Me.txtBottomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtTopMiddle
    '
    Me.txtTopMiddle.AutoSize = False
    Me.txtTopMiddle.BackColor = System.Drawing.SystemColors.Control
    Me.txtTopMiddle.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTopMiddle.ForeColor = System.Drawing.Color.Blue
    Me.txtTopMiddle.Location = New System.Drawing.Point(95, 61)
    Me.txtTopMiddle.Multiline = True
    Me.txtTopMiddle.Name = "txtTopMiddle"
    Me.txtTopMiddle.ReadOnly = True
    Me.txtTopMiddle.Size = New System.Drawing.Size(53, 52)
    Me.txtTopMiddle.TabIndex = 4
    Me.txtTopMiddle.TabStop = False
    Me.txtTopMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtMiddleMiddle
    '
    Me.txtMiddleMiddle.AutoSize = False
    Me.txtMiddleMiddle.BackColor = System.Drawing.SystemColors.Control
    Me.txtMiddleMiddle.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMiddleMiddle.ForeColor = System.Drawing.Color.Blue
    Me.txtMiddleMiddle.Location = New System.Drawing.Point(95, 137)
    Me.txtMiddleMiddle.Multiline = True
    Me.txtMiddleMiddle.Name = "txtMiddleMiddle"
    Me.txtMiddleMiddle.ReadOnly = True
    Me.txtMiddleMiddle.Size = New System.Drawing.Size(53, 52)
    Me.txtMiddleMiddle.TabIndex = 5
    Me.txtMiddleMiddle.TabStop = False
    Me.txtMiddleMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtBottomMiddle
    '
    Me.txtBottomMiddle.AutoSize = False
    Me.txtBottomMiddle.BackColor = System.Drawing.SystemColors.Control
    Me.txtBottomMiddle.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBottomMiddle.ForeColor = System.Drawing.Color.Blue
    Me.txtBottomMiddle.Location = New System.Drawing.Point(95, 213)
    Me.txtBottomMiddle.Multiline = True
    Me.txtBottomMiddle.Name = "txtBottomMiddle"
    Me.txtBottomMiddle.ReadOnly = True
    Me.txtBottomMiddle.Size = New System.Drawing.Size(53, 52)
    Me.txtBottomMiddle.TabIndex = 6
    Me.txtBottomMiddle.TabStop = False
    Me.txtBottomMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtTopRight
    '
    Me.txtTopRight.AutoSize = False
    Me.txtTopRight.BackColor = System.Drawing.SystemColors.Control
    Me.txtTopRight.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTopRight.ForeColor = System.Drawing.Color.Blue
    Me.txtTopRight.Location = New System.Drawing.Point(172, 61)
    Me.txtTopRight.Multiline = True
    Me.txtTopRight.Name = "txtTopRight"
    Me.txtTopRight.ReadOnly = True
    Me.txtTopRight.Size = New System.Drawing.Size(53, 52)
    Me.txtTopRight.TabIndex = 7
    Me.txtTopRight.TabStop = False
    Me.txtTopRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtMiddleRight
    '
    Me.txtMiddleRight.AutoSize = False
    Me.txtMiddleRight.BackColor = System.Drawing.SystemColors.Control
    Me.txtMiddleRight.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMiddleRight.ForeColor = System.Drawing.Color.Blue
    Me.txtMiddleRight.Location = New System.Drawing.Point(172, 137)
    Me.txtMiddleRight.Multiline = True
    Me.txtMiddleRight.Name = "txtMiddleRight"
    Me.txtMiddleRight.ReadOnly = True
    Me.txtMiddleRight.Size = New System.Drawing.Size(53, 52)
    Me.txtMiddleRight.TabIndex = 8
    Me.txtMiddleRight.TabStop = False
    Me.txtMiddleRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtBottomRight
    '
    Me.txtBottomRight.AutoSize = False
    Me.txtBottomRight.BackColor = System.Drawing.SystemColors.Control
    Me.txtBottomRight.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBottomRight.ForeColor = System.Drawing.Color.Blue
    Me.txtBottomRight.Location = New System.Drawing.Point(172, 213)
    Me.txtBottomRight.Multiline = True
    Me.txtBottomRight.Name = "txtBottomRight"
    Me.txtBottomRight.ReadOnly = True
    Me.txtBottomRight.Size = New System.Drawing.Size(53, 52)
    Me.txtBottomRight.TabIndex = 9
    Me.txtBottomRight.TabStop = False
    Me.txtBottomRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'TextBox11
    '
    Me.TextBox11.AutoSize = False
    Me.TextBox11.BackColor = System.Drawing.Color.Black
    Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox11.Location = New System.Drawing.Point(77, 61)
    Me.TextBox11.Multiline = True
    Me.TextBox11.Name = "TextBox11"
    Me.TextBox11.ReadOnly = True
    Me.TextBox11.Size = New System.Drawing.Size(10, 204)
    Me.TextBox11.TabIndex = 10
    Me.TextBox11.TabStop = False
    Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'TextBox12
    '
    Me.TextBox12.AutoSize = False
    Me.TextBox12.BackColor = System.Drawing.Color.Black
    Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox12.Location = New System.Drawing.Point(155, 61)
    Me.TextBox12.Multiline = True
    Me.TextBox12.Name = "TextBox12"
    Me.TextBox12.ReadOnly = True
    Me.TextBox12.Size = New System.Drawing.Size(10, 204)
    Me.TextBox12.TabIndex = 11
    Me.TextBox12.TabStop = False
    Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'TextBox13
    '
    Me.TextBox13.AutoSize = False
    Me.TextBox13.BackColor = System.Drawing.Color.Black
    Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox13.Location = New System.Drawing.Point(17, 120)
    Me.TextBox13.Multiline = True
    Me.TextBox13.Name = "TextBox13"
    Me.TextBox13.ReadOnly = True
    Me.TextBox13.Size = New System.Drawing.Size(208, 10)
    Me.TextBox13.TabIndex = 12
    Me.TextBox13.TabStop = False
    Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'TextBox14
    '
    Me.TextBox14.AutoSize = False
    Me.TextBox14.BackColor = System.Drawing.Color.Black
    Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox14.Location = New System.Drawing.Point(17, 196)
    Me.TextBox14.Multiline = True
    Me.TextBox14.Name = "TextBox14"
    Me.TextBox14.ReadOnly = True
    Me.TextBox14.Size = New System.Drawing.Size(208, 10)
    Me.TextBox14.TabIndex = 13
    Me.TextBox14.TabStop = False
    Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnReset
    '
    Me.btnReset.Location = New System.Drawing.Point(77, 272)
    Me.btnReset.Name = "btnReset"
    Me.btnReset.Size = New System.Drawing.Size(88, 23)
    Me.btnReset.TabIndex = 14
    Me.btnReset.Text = "Reset Game"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(244, 303)
    Me.Controls.Add(Me.btnReset)
    Me.Controls.Add(Me.TextBox12)
    Me.Controls.Add(Me.TextBox11)
    Me.Controls.Add(Me.txtBottomRight)
    Me.Controls.Add(Me.txtMiddleRight)
    Me.Controls.Add(Me.txtTopRight)
    Me.Controls.Add(Me.txtBottomMiddle)
    Me.Controls.Add(Me.txtMiddleMiddle)
    Me.Controls.Add(Me.txtTopMiddle)
    Me.Controls.Add(Me.txtBottomLeft)
    Me.Controls.Add(Me.txtMiddleLeft)
    Me.Controls.Add(Me.txtTopLeft)
    Me.Controls.Add(Me.txtMessage)
    Me.Controls.Add(Me.TextBox13)
    Me.Controls.Add(Me.TextBox14)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Tic-Tac-Toe"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtMessage As System.Windows.Forms.TextBox
  Friend WithEvents txtTopLeft As System.Windows.Forms.TextBox
  Friend WithEvents txtMiddleLeft As System.Windows.Forms.TextBox
  Friend WithEvents txtBottomLeft As System.Windows.Forms.TextBox
  Friend WithEvents txtTopMiddle As System.Windows.Forms.TextBox
  Friend WithEvents txtMiddleMiddle As System.Windows.Forms.TextBox
  Friend WithEvents txtBottomMiddle As System.Windows.Forms.TextBox
  Friend WithEvents txtTopRight As System.Windows.Forms.TextBox
  Friend WithEvents txtMiddleRight As System.Windows.Forms.TextBox
  Friend WithEvents txtBottomRight As System.Windows.Forms.TextBox
  Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
  Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
