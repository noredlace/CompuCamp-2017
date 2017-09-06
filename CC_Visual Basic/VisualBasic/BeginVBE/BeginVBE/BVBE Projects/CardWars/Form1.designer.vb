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
    Me.pnlPlayer = New System.Windows.Forms.Panel
    Me.lblPlayer = New System.Windows.Forms.Label
    Me.picPlayer = New System.Windows.Forms.PictureBox
    Me.pnlComputer = New System.Windows.Forms.Panel
    Me.lblComputer = New System.Windows.Forms.Label
    Me.picComputer = New System.Windows.Forms.PictureBox
    Me.lblYou = New System.Windows.Forms.Label
    Me.txtYouScore = New System.Windows.Forms.TextBox
    Me.txtCompScore = New System.Windows.Forms.TextBox
    Me.lblComp = New System.Windows.Forms.Label
    Me.txtOver = New System.Windows.Forms.TextBox
    Me.btnNew = New System.Windows.Forms.Button
    Me.btnExit = New System.Windows.Forms.Button
    Me.picHeart = New System.Windows.Forms.PictureBox
    Me.picDiamond = New System.Windows.Forms.PictureBox
    Me.picClub = New System.Windows.Forms.PictureBox
    Me.picSpade = New System.Windows.Forms.PictureBox
    Me.pnlPlayer.SuspendLayout()
    CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlComputer.SuspendLayout()
    CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picHeart, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDiamond, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picClub, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picSpade, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlPlayer
    '
    Me.pnlPlayer.BackColor = System.Drawing.Color.White
    Me.pnlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlPlayer.Controls.Add(Me.lblPlayer)
    Me.pnlPlayer.Controls.Add(Me.picPlayer)
    Me.pnlPlayer.Location = New System.Drawing.Point(97, 10)
    Me.pnlPlayer.Name = "pnlPlayer"
    Me.pnlPlayer.Size = New System.Drawing.Size(87, 116)
    Me.pnlPlayer.TabIndex = 0
    '
    'lblPlayer
    '
    Me.lblPlayer.AutoSize = True
    Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPlayer.Location = New System.Drawing.Point(25, 80)
    Me.lblPlayer.Name = "lblPlayer"
    Me.lblPlayer.Size = New System.Drawing.Size(0, 0)
    Me.lblPlayer.TabIndex = 1
    Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'picPlayer
    '
    Me.picPlayer.Location = New System.Drawing.Point(22, 15)
    Me.picPlayer.Name = "picPlayer"
    Me.picPlayer.Size = New System.Drawing.Size(41, 49)
    Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picPlayer.TabIndex = 0
    Me.picPlayer.TabStop = False
    '
    'pnlComputer
    '
    Me.pnlComputer.BackColor = System.Drawing.Color.White
    Me.pnlComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlComputer.Controls.Add(Me.lblComputer)
    Me.pnlComputer.Controls.Add(Me.picComputer)
    Me.pnlComputer.Location = New System.Drawing.Point(97, 138)
    Me.pnlComputer.Name = "pnlComputer"
    Me.pnlComputer.Size = New System.Drawing.Size(87, 116)
    Me.pnlComputer.TabIndex = 1
    '
    'lblComputer
    '
    Me.lblComputer.AutoSize = True
    Me.lblComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblComputer.Location = New System.Drawing.Point(26, 80)
    Me.lblComputer.Name = "lblComputer"
    Me.lblComputer.Size = New System.Drawing.Size(0, 0)
    Me.lblComputer.TabIndex = 3
    Me.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'picComputer
    '
    Me.picComputer.Location = New System.Drawing.Point(23, 17)
    Me.picComputer.Name = "picComputer"
    Me.picComputer.Size = New System.Drawing.Size(41, 49)
    Me.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picComputer.TabIndex = 2
    Me.picComputer.TabStop = False
    '
    'lblYou
    '
    Me.lblYou.AutoSize = True
    Me.lblYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblYou.Location = New System.Drawing.Point(16, 10)
    Me.lblYou.Name = "lblYou"
    Me.lblYou.Size = New System.Drawing.Size(33, 20)
    Me.lblYou.TabIndex = 2
    Me.lblYou.Text = "You"
    Me.lblYou.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtYouScore
    '
    Me.txtYouScore.AutoSize = False
    Me.txtYouScore.BackColor = System.Drawing.Color.White
    Me.txtYouScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtYouScore.Location = New System.Drawing.Point(16, 31)
    Me.txtYouScore.Multiline = True
    Me.txtYouScore.Name = "txtYouScore"
    Me.txtYouScore.ReadOnly = True
    Me.txtYouScore.Size = New System.Drawing.Size(63, 29)
    Me.txtYouScore.TabIndex = 3
    Me.txtYouScore.Text = "0"
    Me.txtYouScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtCompScore
    '
    Me.txtCompScore.AutoSize = False
    Me.txtCompScore.BackColor = System.Drawing.Color.White
    Me.txtCompScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCompScore.Location = New System.Drawing.Point(16, 159)
    Me.txtCompScore.Multiline = True
    Me.txtCompScore.Name = "txtCompScore"
    Me.txtCompScore.ReadOnly = True
    Me.txtCompScore.Size = New System.Drawing.Size(63, 29)
    Me.txtCompScore.TabIndex = 5
    Me.txtCompScore.Text = "0"
    Me.txtCompScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblComp
    '
    Me.lblComp.AutoSize = True
    Me.lblComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblComp.Location = New System.Drawing.Point(16, 138)
    Me.lblComp.Name = "lblComp"
    Me.lblComp.Size = New System.Drawing.Size(74, 20)
    Me.lblComp.TabIndex = 4
    Me.lblComp.Text = "Computer"
    Me.lblComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtOver
    '
    Me.txtOver.AutoSize = False
    Me.txtOver.BackColor = System.Drawing.Color.White
    Me.txtOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOver.ForeColor = System.Drawing.Color.Red
    Me.txtOver.Location = New System.Drawing.Point(202, 12)
    Me.txtOver.Multiline = True
    Me.txtOver.Name = "txtOver"
    Me.txtOver.ReadOnly = True
    Me.txtOver.Size = New System.Drawing.Size(107, 95)
    Me.txtOver.TabIndex = 6
    Me.txtOver.Text = "Game Over"
    Me.txtOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnNew
    '
    Me.btnNew.Location = New System.Drawing.Point(202, 114)
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Size = New System.Drawing.Size(107, 23)
    Me.btnNew.TabIndex = 7
    Me.btnNew.Text = "New Game"
    '
    'btnExit
    '
    Me.btnExit.Location = New System.Drawing.Point(202, 144)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(107, 23)
    Me.btnExit.TabIndex = 8
    Me.btnExit.Text = "Exit"
    '
    'picHeart
    '
    Me.picHeart.AutoSize = True
    Me.picHeart.Image = CardWars.My.Resources.Resources.Heart
    Me.picHeart.Location = New System.Drawing.Point(202, 174)
    Me.picHeart.Name = "picHeart"
    Me.picHeart.Size = New System.Drawing.Size(16, 16)
    Me.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picHeart.TabIndex = 9
    Me.picHeart.TabStop = False
    Me.picHeart.Visible = False
    '
    'picDiamond
    '
    Me.picDiamond.AutoSize = True
    Me.picDiamond.Image = CardWars.My.Resources.Resources.Diamond
    Me.picDiamond.Location = New System.Drawing.Point(270, 174)
    Me.picDiamond.Name = "picDiamond"
    Me.picDiamond.Size = New System.Drawing.Size(16, 16)
    Me.picDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picDiamond.TabIndex = 10
    Me.picDiamond.TabStop = False
    Me.picDiamond.Visible = False
    '
    'picClub
    '
    Me.picClub.AutoSize = True
    Me.picClub.Image = CardWars.My.Resources.Resources.Club
    Me.picClub.Location = New System.Drawing.Point(202, 213)
    Me.picClub.Name = "picClub"
    Me.picClub.Size = New System.Drawing.Size(16, 16)
    Me.picClub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picClub.TabIndex = 11
    Me.picClub.TabStop = False
    Me.picClub.Visible = False
    '
    'picSpade
    '
    Me.picSpade.AutoSize = True
    Me.picSpade.Image = CardWars.My.Resources.Resources.Spade
    Me.picSpade.Location = New System.Drawing.Point(270, 213)
    Me.picSpade.Name = "picSpade"
    Me.picSpade.Size = New System.Drawing.Size(16, 16)
    Me.picSpade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picSpade.TabIndex = 12
    Me.picSpade.TabStop = False
    Me.picSpade.Visible = False
    '
    'Form1
    '
    Me.ClientSize = New System.Drawing.Size(322, 266)
    Me.Controls.Add(Me.picSpade)
    Me.Controls.Add(Me.picClub)
    Me.Controls.Add(Me.picDiamond)
    Me.Controls.Add(Me.picHeart)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnNew)
    Me.Controls.Add(Me.txtOver)
    Me.Controls.Add(Me.txtCompScore)
    Me.Controls.Add(Me.lblComp)
    Me.Controls.Add(Me.txtYouScore)
    Me.Controls.Add(Me.lblYou)
    Me.Controls.Add(Me.pnlComputer)
    Me.Controls.Add(Me.pnlPlayer)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Card Wars"
    Me.pnlPlayer.ResumeLayout(False)
    Me.pnlPlayer.PerformLayout()
    CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlComputer.ResumeLayout(False)
    Me.pnlComputer.PerformLayout()
    CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picHeart, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDiamond, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picClub, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picSpade, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents pnlPlayer As System.Windows.Forms.Panel
  Friend WithEvents lblPlayer As System.Windows.Forms.Label
  Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
  Friend WithEvents pnlComputer As System.Windows.Forms.Panel
  Friend WithEvents lblComputer As System.Windows.Forms.Label
  Friend WithEvents picComputer As System.Windows.Forms.PictureBox
  Friend WithEvents lblYou As System.Windows.Forms.Label
  Friend WithEvents txtYouScore As System.Windows.Forms.TextBox
  Friend WithEvents txtCompScore As System.Windows.Forms.TextBox
  Friend WithEvents lblComp As System.Windows.Forms.Label
  Friend WithEvents txtOver As System.Windows.Forms.TextBox
  Friend WithEvents btnNew As System.Windows.Forms.Button
  Friend WithEvents btnExit As System.Windows.Forms.Button
  Friend WithEvents picHeart As System.Windows.Forms.PictureBox
  Friend WithEvents picDiamond As System.Windows.Forms.PictureBox
  Friend WithEvents picClub As System.Windows.Forms.PictureBox
  Friend WithEvents picSpade As System.Windows.Forms.PictureBox

End Class
