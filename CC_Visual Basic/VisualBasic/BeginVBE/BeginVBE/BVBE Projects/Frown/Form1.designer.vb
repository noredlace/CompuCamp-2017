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
    Me.components = New System.ComponentModel.Container()
    Me.grpYou = New System.Windows.Forms.GroupBox()
    Me.lblYouTotal = New System.Windows.Forms.Label()
    Me.lblYouScore = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.grpComputer = New System.Windows.Forms.GroupBox()
    Me.lblComputerTotal = New System.Windows.Forms.Label()
    Me.lblComputerScore = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.grpChoice = New System.Windows.Forms.GroupBox()
    Me.btnStop = New System.Windows.Forms.Button()
    Me.btnNew = New System.Windows.Forms.Button()
    Me.picDots1 = New System.Windows.Forms.PictureBox()
    Me.picDots2 = New System.Windows.Forms.PictureBox()
    Me.picDots3 = New System.Windows.Forms.PictureBox()
    Me.picDots4 = New System.Windows.Forms.PictureBox()
    Me.picDots5 = New System.Windows.Forms.PictureBox()
    Me.picDots6 = New System.Windows.Forms.PictureBox()
    Me.timComputer = New System.Windows.Forms.Timer(Me.components)
    Me.lblMessage = New System.Windows.Forms.Label()
    Me.picDice1 = New System.Windows.Forms.PictureBox()
    Me.picDice2 = New System.Windows.Forms.PictureBox()
    Me.btnRoll = New System.Windows.Forms.Button()
    Me.btnPass = New System.Windows.Forms.Button()
    Me.grpDice = New System.Windows.Forms.GroupBox()
    Me.grpYou.SuspendLayout()
    Me.grpComputer.SuspendLayout()
    Me.grpChoice.SuspendLayout()
    CType(Me.picDots1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDots2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDots3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDots4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDots5, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDots6, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDice1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDice2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpDice.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpYou
    '
    Me.grpYou.BackColor = System.Drawing.Color.Blue
    Me.grpYou.Controls.Add(Me.lblYouTotal)
    Me.grpYou.Controls.Add(Me.lblYouScore)
    Me.grpYou.Controls.Add(Me.Label2)
    Me.grpYou.Controls.Add(Me.Label1)
    Me.grpYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpYou.ForeColor = System.Drawing.Color.Yellow
    Me.grpYou.Location = New System.Drawing.Point(15, 14)
    Me.grpYou.Name = "grpYou"
    Me.grpYou.Size = New System.Drawing.Size(248, 120)
    Me.grpYou.TabIndex = 0
    Me.grpYou.TabStop = False
    Me.grpYou.Text = "You"
    '
    'lblYouTotal
    '
    Me.lblYouTotal.BackColor = System.Drawing.Color.White
    Me.lblYouTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblYouTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblYouTotal.ForeColor = System.Drawing.Color.Black
    Me.lblYouTotal.Location = New System.Drawing.Point(120, 64)
    Me.lblYouTotal.Name = "lblYouTotal"
    Me.lblYouTotal.Size = New System.Drawing.Size(106, 37)
    Me.lblYouTotal.TabIndex = 3
    Me.lblYouTotal.Text = "0"
    Me.lblYouTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblYouScore
    '
    Me.lblYouScore.BackColor = System.Drawing.Color.White
    Me.lblYouScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblYouScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblYouScore.ForeColor = System.Drawing.Color.Black
    Me.lblYouScore.Location = New System.Drawing.Point(120, 20)
    Me.lblYouScore.Name = "lblYouScore"
    Me.lblYouScore.Size = New System.Drawing.Size(106, 37)
    Me.lblYouScore.TabIndex = 2
    Me.lblYouScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(7, 64)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(106, 37)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Total Score"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(7, 20)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(106, 37)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Score This Turn"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'grpComputer
    '
    Me.grpComputer.BackColor = System.Drawing.Color.Blue
    Me.grpComputer.Controls.Add(Me.lblComputerTotal)
    Me.grpComputer.Controls.Add(Me.lblComputerScore)
    Me.grpComputer.Controls.Add(Me.Label6)
    Me.grpComputer.Controls.Add(Me.Label5)
    Me.grpComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpComputer.ForeColor = System.Drawing.Color.Yellow
    Me.grpComputer.Location = New System.Drawing.Point(15, 141)
    Me.grpComputer.Name = "grpComputer"
    Me.grpComputer.Size = New System.Drawing.Size(248, 120)
    Me.grpComputer.TabIndex = 4
    Me.grpComputer.TabStop = False
    Me.grpComputer.Text = "Computer"
    '
    'lblComputerTotal
    '
    Me.lblComputerTotal.BackColor = System.Drawing.Color.White
    Me.lblComputerTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblComputerTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblComputerTotal.ForeColor = System.Drawing.Color.Black
    Me.lblComputerTotal.Location = New System.Drawing.Point(120, 64)
    Me.lblComputerTotal.Name = "lblComputerTotal"
    Me.lblComputerTotal.Size = New System.Drawing.Size(106, 37)
    Me.lblComputerTotal.TabIndex = 3
    Me.lblComputerTotal.Text = "0"
    Me.lblComputerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblComputerScore
    '
    Me.lblComputerScore.BackColor = System.Drawing.Color.White
    Me.lblComputerScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblComputerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblComputerScore.ForeColor = System.Drawing.Color.Black
    Me.lblComputerScore.Location = New System.Drawing.Point(120, 20)
    Me.lblComputerScore.Name = "lblComputerScore"
    Me.lblComputerScore.Size = New System.Drawing.Size(106, 37)
    Me.lblComputerScore.TabIndex = 2
    Me.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.ForeColor = System.Drawing.Color.White
    Me.Label6.Location = New System.Drawing.Point(7, 64)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(106, 37)
    Me.Label6.TabIndex = 1
    Me.Label6.Text = "Total Score"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.White
    Me.Label5.Location = New System.Drawing.Point(7, 20)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(106, 37)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Score This Turn"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'grpChoice
    '
    Me.grpChoice.BackColor = System.Drawing.Color.Yellow
    Me.grpChoice.Controls.Add(Me.btnStop)
    Me.grpChoice.Controls.Add(Me.btnNew)
    Me.grpChoice.Location = New System.Drawing.Point(154, 268)
    Me.grpChoice.Name = "grpChoice"
    Me.grpChoice.Size = New System.Drawing.Size(224, 51)
    Me.grpChoice.TabIndex = 6
    Me.grpChoice.TabStop = False
    '
    'btnStop
    '
    Me.btnStop.BackColor = System.Drawing.SystemColors.Control
    Me.btnStop.Enabled = False
    Me.btnStop.Location = New System.Drawing.Point(117, 14)
    Me.btnStop.Name = "btnStop"
    Me.btnStop.Size = New System.Drawing.Size(91, 29)
    Me.btnStop.TabIndex = 1
    Me.btnStop.Text = "Stop Game"
    Me.btnStop.UseVisualStyleBackColor = False
    '
    'btnNew
    '
    Me.btnNew.BackColor = System.Drawing.SystemColors.Control
    Me.btnNew.Location = New System.Drawing.Point(19, 14)
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Size = New System.Drawing.Size(91, 29)
    Me.btnNew.TabIndex = 0
    Me.btnNew.Text = "New Game"
    Me.btnNew.UseVisualStyleBackColor = False
    '
    'picDots1
    '
    Me.picDots1.Image = Global.Frown.My.Resources.Resources.FROWN
    Me.picDots1.Location = New System.Drawing.Point(388, 268)
    Me.picDots1.Name = "picDots1"
    Me.picDots1.Size = New System.Drawing.Size(26, 24)
    Me.picDots1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDots1.TabIndex = 7
    Me.picDots1.TabStop = False
    Me.picDots1.Visible = False
    '
    'picDots2
    '
    Me.picDots2.Image = Global.Frown.My.Resources.Resources.DICE2
    Me.picDots2.Location = New System.Drawing.Point(421, 268)
    Me.picDots2.Name = "picDots2"
    Me.picDots2.Size = New System.Drawing.Size(26, 24)
    Me.picDots2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDots2.TabIndex = 8
    Me.picDots2.TabStop = False
    Me.picDots2.Visible = False
    '
    'picDots3
    '
    Me.picDots3.Image = Global.Frown.My.Resources.Resources.DICE3
    Me.picDots3.Location = New System.Drawing.Point(454, 267)
    Me.picDots3.Name = "picDots3"
    Me.picDots3.Size = New System.Drawing.Size(26, 24)
    Me.picDots3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDots3.TabIndex = 9
    Me.picDots3.TabStop = False
    Me.picDots3.Visible = False
    '
    'picDots4
    '
    Me.picDots4.Image = Global.Frown.My.Resources.Resources.DICE4
    Me.picDots4.Location = New System.Drawing.Point(388, 297)
    Me.picDots4.Name = "picDots4"
    Me.picDots4.Size = New System.Drawing.Size(26, 24)
    Me.picDots4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDots4.TabIndex = 10
    Me.picDots4.TabStop = False
    Me.picDots4.Visible = False
    '
    'picDots5
    '
    Me.picDots5.Image = Global.Frown.My.Resources.Resources.DICE5
    Me.picDots5.Location = New System.Drawing.Point(421, 297)
    Me.picDots5.Name = "picDots5"
    Me.picDots5.Size = New System.Drawing.Size(26, 24)
    Me.picDots5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDots5.TabIndex = 11
    Me.picDots5.TabStop = False
    Me.picDots5.Visible = False
    '
    'picDots6
    '
    Me.picDots6.Image = Global.Frown.My.Resources.Resources.DICE6
    Me.picDots6.Location = New System.Drawing.Point(454, 297)
    Me.picDots6.Name = "picDots6"
    Me.picDots6.Size = New System.Drawing.Size(26, 24)
    Me.picDots6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDots6.TabIndex = 12
    Me.picDots6.TabStop = False
    Me.picDots6.Visible = False
    '
    'timComputer
    '
    Me.timComputer.Interval = 2000
    '
    'lblMessage
    '
    Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMessage.Location = New System.Drawing.Point(12, 22)
    Me.lblMessage.Name = "lblMessage"
    Me.lblMessage.Size = New System.Drawing.Size(178, 61)
    Me.lblMessage.TabIndex = 0
    Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'picDice1
    '
    Me.picDice1.BackColor = System.Drawing.Color.Green
    Me.picDice1.Location = New System.Drawing.Point(16, 100)
    Me.picDice1.Name = "picDice1"
    Me.picDice1.Size = New System.Drawing.Size(83, 83)
    Me.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDice1.TabIndex = 1
    Me.picDice1.TabStop = False
    '
    'picDice2
    '
    Me.picDice2.BackColor = System.Drawing.Color.Green
    Me.picDice2.Location = New System.Drawing.Point(107, 100)
    Me.picDice2.Name = "picDice2"
    Me.picDice2.Size = New System.Drawing.Size(83, 83)
    Me.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picDice2.TabIndex = 2
    Me.picDice2.TabStop = False
    '
    'btnRoll
    '
    Me.btnRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.btnRoll.Enabled = False
    Me.btnRoll.Location = New System.Drawing.Point(22, 197)
    Me.btnRoll.Name = "btnRoll"
    Me.btnRoll.Size = New System.Drawing.Size(75, 30)
    Me.btnRoll.TabIndex = 3
    Me.btnRoll.Text = "Roll Dice"
    Me.btnRoll.UseVisualStyleBackColor = False
    '
    'btnPass
    '
    Me.btnPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.btnPass.Enabled = False
    Me.btnPass.Location = New System.Drawing.Point(115, 197)
    Me.btnPass.Name = "btnPass"
    Me.btnPass.Size = New System.Drawing.Size(75, 30)
    Me.btnPass.TabIndex = 4
    Me.btnPass.Text = "Pass Dice"
    Me.btnPass.UseVisualStyleBackColor = False
    '
    'grpDice
    '
    Me.grpDice.BackColor = System.Drawing.Color.Red
    Me.grpDice.Controls.Add(Me.btnPass)
    Me.grpDice.Controls.Add(Me.btnRoll)
    Me.grpDice.Controls.Add(Me.picDice2)
    Me.grpDice.Controls.Add(Me.picDice1)
    Me.grpDice.Controls.Add(Me.lblMessage)
    Me.grpDice.Location = New System.Drawing.Point(281, 15)
    Me.grpDice.Name = "grpDice"
    Me.grpDice.Size = New System.Drawing.Size(205, 245)
    Me.grpDice.TabIndex = 5
    Me.grpDice.TabStop = False
    '
    'Form1
    '
    Me.ClientSize = New System.Drawing.Size(502, 333)
    Me.Controls.Add(Me.picDots6)
    Me.Controls.Add(Me.picDots5)
    Me.Controls.Add(Me.picDots4)
    Me.Controls.Add(Me.picDots3)
    Me.Controls.Add(Me.picDots2)
    Me.Controls.Add(Me.picDots1)
    Me.Controls.Add(Me.grpChoice)
    Me.Controls.Add(Me.grpDice)
    Me.Controls.Add(Me.grpComputer)
    Me.Controls.Add(Me.grpYou)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Frown"
    Me.grpYou.ResumeLayout(False)
    Me.grpComputer.ResumeLayout(False)
    Me.grpChoice.ResumeLayout(False)
    CType(Me.picDots1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDots2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDots3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDots4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDots5, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDots6, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDice1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDice2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpDice.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grpYou As System.Windows.Forms.GroupBox
  Friend WithEvents lblYouTotal As System.Windows.Forms.Label
  Friend WithEvents lblYouScore As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents grpComputer As System.Windows.Forms.GroupBox
  Friend WithEvents lblComputerTotal As System.Windows.Forms.Label
  Friend WithEvents lblComputerScore As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents grpChoice As System.Windows.Forms.GroupBox
  Friend WithEvents btnStop As System.Windows.Forms.Button
  Friend WithEvents btnNew As System.Windows.Forms.Button
  Friend WithEvents picDots1 As System.Windows.Forms.PictureBox
  Friend WithEvents picDots2 As System.Windows.Forms.PictureBox
  Friend WithEvents picDots3 As System.Windows.Forms.PictureBox
  Friend WithEvents picDots4 As System.Windows.Forms.PictureBox
  Friend WithEvents picDots5 As System.Windows.Forms.PictureBox
  Friend WithEvents picDots6 As System.Windows.Forms.PictureBox
  Friend WithEvents timComputer As System.Windows.Forms.Timer
  Friend WithEvents lblMessage As System.Windows.Forms.Label
  Friend WithEvents picDice1 As System.Windows.Forms.PictureBox
  Friend WithEvents picDice2 As System.Windows.Forms.PictureBox
  Friend WithEvents btnRoll As System.Windows.Forms.Button
  Friend WithEvents btnPass As System.Windows.Forms.Button
  Friend WithEvents grpDice As System.Windows.Forms.GroupBox

End Class
