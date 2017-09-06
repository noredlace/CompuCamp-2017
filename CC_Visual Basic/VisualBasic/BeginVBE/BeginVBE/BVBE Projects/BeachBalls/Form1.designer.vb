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
    Me.components = New System.ComponentModel.Container
    Me.pnlBeachBalls = New System.Windows.Forms.Panel
    Me.lblHead = New System.Windows.Forms.Label
    Me.txtScore = New System.Windows.Forms.TextBox
    Me.txtOver = New System.Windows.Forms.TextBox
    Me.btnStart = New System.Windows.Forms.Button
    Me.btnExit = New System.Windows.Forms.Button
    Me.timBalls = New System.Windows.Forms.Timer(Me.components)
    Me.timGame = New System.Windows.Forms.Timer(Me.components)
    Me.picBall = New System.Windows.Forms.PictureBox
    Me.picArrow = New System.Windows.Forms.PictureBox
    CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picArrow, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlBeachBalls
    '
    Me.pnlBeachBalls.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.pnlBeachBalls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlBeachBalls.Location = New System.Drawing.Point(9, 8)
    Me.pnlBeachBalls.Name = "pnlBeachBalls"
    Me.pnlBeachBalls.Size = New System.Drawing.Size(409, 278)
    Me.pnlBeachBalls.TabIndex = 0
    '
    'lblHead
    '
    Me.lblHead.AutoSize = True
    Me.lblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHead.Location = New System.Drawing.Point(436, 9)
    Me.lblHead.Name = "lblHead"
    Me.lblHead.Size = New System.Drawing.Size(110, 20)
    Me.lblHead.TabIndex = 1
    Me.lblHead.Text = "Balls Popped"
    Me.lblHead.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'txtScore
    '
    Me.txtScore.BackColor = System.Drawing.Color.White
    Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtScore.ForeColor = System.Drawing.Color.Blue
    Me.txtScore.Location = New System.Drawing.Point(436, 33)
    Me.txtScore.Name = "txtScore"
    Me.txtScore.ReadOnly = True
    Me.txtScore.Size = New System.Drawing.Size(100, 43)
    Me.txtScore.TabIndex = 2
    Me.txtScore.Text = "0"
    Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtOver
    '
    Me.txtOver.AutoSize = False
    Me.txtOver.BackColor = System.Drawing.Color.White
    Me.txtOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOver.ForeColor = System.Drawing.Color.Red
    Me.txtOver.Location = New System.Drawing.Point(436, 75)
    Me.txtOver.Multiline = True
    Me.txtOver.Name = "txtOver"
    Me.txtOver.ReadOnly = True
    Me.txtOver.Size = New System.Drawing.Size(100, 108)
    Me.txtOver.TabIndex = 3
    Me.txtOver.Text = "Game Over"
    Me.txtOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnStart
    '
    Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.btnStart.Location = New System.Drawing.Point(449, 190)
    Me.btnStart.Name = "btnStart"
    Me.btnStart.Size = New System.Drawing.Size(75, 23)
    Me.btnStart.TabIndex = 4
    Me.btnStart.Text = "Start"
    Me.btnStart.UseVisualStyleBackColor = False
    '
    'btnExit
    '
    Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.btnExit.Location = New System.Drawing.Point(449, 229)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(75, 23)
    Me.btnExit.TabIndex = 5
    Me.btnExit.Text = "Exit"
    Me.btnExit.UseVisualStyleBackColor = False
    '
    'timBalls
    '
    '
    'timGame
    '
    Me.timGame.Interval = 60000
    '
    'picBall
    '
    Me.picBall.Image = BeachBalls.My.Resources.Resources.BALL
    Me.picBall.Location = New System.Drawing.Point(442, 263)
    Me.picBall.Name = "picBall"
    Me.picBall.Size = New System.Drawing.Size(32, 23)
    Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picBall.TabIndex = 6
    Me.picBall.TabStop = False
    Me.picBall.Visible = False
    '
    'picArrow
    '
    Me.picArrow.Image = BeachBalls.My.Resources.Resources.ARROW
    Me.picArrow.Location = New System.Drawing.Point(506, 263)
    Me.picArrow.Name = "picArrow"
    Me.picArrow.Size = New System.Drawing.Size(32, 23)
    Me.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picArrow.TabIndex = 7
    Me.picArrow.TabStop = False
    Me.picArrow.Visible = False
    '
    'Form1
    '
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(555, 298)
    Me.Controls.Add(Me.picArrow)
    Me.Controls.Add(Me.picBall)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnStart)
    Me.Controls.Add(Me.txtOver)
    Me.Controls.Add(Me.txtScore)
    Me.Controls.Add(Me.lblHead)
    Me.Controls.Add(Me.pnlBeachBalls)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Beach Balls"
    CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picArrow, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents pnlBeachBalls As System.Windows.Forms.Panel
  Friend WithEvents lblHead As System.Windows.Forms.Label
  Friend WithEvents txtScore As System.Windows.Forms.TextBox
  Friend WithEvents txtOver As System.Windows.Forms.TextBox
  Friend WithEvents btnStart As System.Windows.Forms.Button
  Friend WithEvents btnExit As System.Windows.Forms.Button
  Friend WithEvents timBalls As System.Windows.Forms.Timer
  Friend WithEvents timGame As System.Windows.Forms.Timer
  Friend WithEvents picBall As System.Windows.Forms.PictureBox
  Friend WithEvents picArrow As System.Windows.Forms.PictureBox

End Class
