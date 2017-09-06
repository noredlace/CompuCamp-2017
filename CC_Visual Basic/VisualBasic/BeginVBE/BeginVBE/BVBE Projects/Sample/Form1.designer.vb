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
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.chkPizza = New System.Windows.Forms.CheckBox()
    Me.chkPopcorn = New System.Windows.Forms.CheckBox()
    Me.chkSoup = New System.Windows.Forms.CheckBox()
    Me.chkFries = New System.Windows.Forms.CheckBox()
    Me.chkHotDog = New System.Windows.Forms.CheckBox()
    Me.chkBurger = New System.Windows.Forms.CheckBox()
    Me.picBurger = New System.Windows.Forms.PictureBox()
    Me.picHotDog = New System.Windows.Forms.PictureBox()
    Me.picFries = New System.Windows.Forms.PictureBox()
    Me.picPizza = New System.Windows.Forms.PictureBox()
    Me.picPopcorn = New System.Windows.Forms.PictureBox()
    Me.picSoup = New System.Windows.Forms.PictureBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.nudPick = New System.Windows.Forms.NumericUpDown()
    Me.txtInput = New System.Windows.Forms.TextBox()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.rdoBlack = New System.Windows.Forms.RadioButton()
    Me.rdoGreen = New System.Windows.Forms.RadioButton()
    Me.rdoBlue = New System.Windows.Forms.RadioButton()
    Me.rdoRed = New System.Windows.Forms.RadioButton()
    Me.btnBeep = New System.Windows.Forms.Button()
    Me.timBall = New System.Windows.Forms.Timer(Me.components)
    Me.pnlBall = New System.Windows.Forms.Panel()
    Me.picMyBall = New System.Windows.Forms.PictureBox()
    Me.btnBall = New System.Windows.Forms.Button()
    Me.GroupBox1.SuspendLayout()
    CType(Me.picBurger, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picHotDog, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picFries, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picPopcorn, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picSoup, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox2.SuspendLayout()
    CType(Me.nudPick, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox3.SuspendLayout()
    Me.pnlBall.SuspendLayout()
    CType(Me.picMyBall, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GroupBox1.Controls.Add(Me.chkPizza)
    Me.GroupBox1.Controls.Add(Me.chkPopcorn)
    Me.GroupBox1.Controls.Add(Me.chkSoup)
    Me.GroupBox1.Controls.Add(Me.chkFries)
    Me.GroupBox1.Controls.Add(Me.chkHotDog)
    Me.GroupBox1.Controls.Add(Me.chkBurger)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(105, 182)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Food"
    '
    'chkPizza
    '
    Me.chkPizza.AutoSize = True
    Me.chkPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkPizza.Location = New System.Drawing.Point(8, 154)
    Me.chkPizza.Name = "chkPizza"
    Me.chkPizza.Size = New System.Drawing.Size(59, 20)
    Me.chkPizza.TabIndex = 5
    Me.chkPizza.Text = "Pizza"
    '
    'chkPopcorn
    '
    Me.chkPopcorn.AutoSize = True
    Me.chkPopcorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkPopcorn.Location = New System.Drawing.Point(8, 127)
    Me.chkPopcorn.Name = "chkPopcorn"
    Me.chkPopcorn.Size = New System.Drawing.Size(78, 20)
    Me.chkPopcorn.TabIndex = 4
    Me.chkPopcorn.Text = "Popcorn"
    '
    'chkSoup
    '
    Me.chkSoup.AutoSize = True
    Me.chkSoup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkSoup.Location = New System.Drawing.Point(8, 100)
    Me.chkSoup.Name = "chkSoup"
    Me.chkSoup.Size = New System.Drawing.Size(59, 20)
    Me.chkSoup.TabIndex = 3
    Me.chkSoup.Text = "Soup"
    '
    'chkFries
    '
    Me.chkFries.AutoSize = True
    Me.chkFries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkFries.Location = New System.Drawing.Point(8, 73)
    Me.chkFries.Name = "chkFries"
    Me.chkFries.Size = New System.Drawing.Size(57, 20)
    Me.chkFries.TabIndex = 2
    Me.chkFries.Text = "Fries"
    '
    'chkHotDog
    '
    Me.chkHotDog.AutoSize = True
    Me.chkHotDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkHotDog.Location = New System.Drawing.Point(8, 46)
    Me.chkHotDog.Name = "chkHotDog"
    Me.chkHotDog.Size = New System.Drawing.Size(75, 20)
    Me.chkHotDog.TabIndex = 1
    Me.chkHotDog.Text = "Hot dog"
    '
    'chkBurger
    '
    Me.chkBurger.AutoSize = True
    Me.chkBurger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkBurger.Location = New System.Drawing.Point(8, 22)
    Me.chkBurger.Name = "chkBurger"
    Me.chkBurger.Size = New System.Drawing.Size(67, 20)
    Me.chkBurger.TabIndex = 0
    Me.chkBurger.Text = "Burger"
    '
    'picBurger
    '
    Me.picBurger.Image = Global.Sample.My.Resources.Resources.burger
    Me.picBurger.Location = New System.Drawing.Point(115, 9)
    Me.picBurger.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.picBurger.Name = "picBurger"
    Me.picBurger.Size = New System.Drawing.Size(98, 87)
    Me.picBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picBurger.TabIndex = 1
    Me.picBurger.TabStop = False
    Me.picBurger.Visible = False
    '
    'picHotDog
    '
    Me.picHotDog.Image = Global.Sample.My.Resources.Resources.hotdog
    Me.picHotDog.Location = New System.Drawing.Point(220, 9)
    Me.picHotDog.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.picHotDog.Name = "picHotDog"
    Me.picHotDog.Size = New System.Drawing.Size(98, 87)
    Me.picHotDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picHotDog.TabIndex = 2
    Me.picHotDog.TabStop = False
    Me.picHotDog.Visible = False
    '
    'picFries
    '
    Me.picFries.Image = Global.Sample.My.Resources.Resources.fries
    Me.picFries.Location = New System.Drawing.Point(325, 9)
    Me.picFries.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.picFries.Name = "picFries"
    Me.picFries.Size = New System.Drawing.Size(98, 87)
    Me.picFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picFries.TabIndex = 3
    Me.picFries.TabStop = False
    Me.picFries.Visible = False
    '
    'picPizza
    '
    Me.picPizza.Image = Global.Sample.My.Resources.Resources.pizza
    Me.picPizza.Location = New System.Drawing.Point(325, 98)
    Me.picPizza.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.picPizza.Name = "picPizza"
    Me.picPizza.Size = New System.Drawing.Size(98, 87)
    Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picPizza.TabIndex = 6
    Me.picPizza.TabStop = False
    Me.picPizza.Visible = False
    '
    'picPopcorn
    '
    Me.picPopcorn.Image = Global.Sample.My.Resources.Resources.popcorn
    Me.picPopcorn.Location = New System.Drawing.Point(220, 98)
    Me.picPopcorn.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.picPopcorn.Name = "picPopcorn"
    Me.picPopcorn.Size = New System.Drawing.Size(98, 87)
    Me.picPopcorn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picPopcorn.TabIndex = 5
    Me.picPopcorn.TabStop = False
    Me.picPopcorn.Visible = False
    '
    'picSoup
    '
    Me.picSoup.Image = Global.Sample.My.Resources.Resources.soup
    Me.picSoup.Location = New System.Drawing.Point(115, 98)
    Me.picSoup.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.picSoup.Name = "picSoup"
    Me.picSoup.Size = New System.Drawing.Size(98, 87)
    Me.picSoup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picSoup.TabIndex = 4
    Me.picSoup.TabStop = False
    Me.picSoup.Visible = False
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.GroupBox2.Controls.Add(Me.nudPick)
    Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(8, 197)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(193, 70)
    Me.GroupBox2.TabIndex = 7
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Pick a Number"
    '
    'nudPick
    '
    Me.nudPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudPick.Location = New System.Drawing.Point(24, 25)
    Me.nudPick.Name = "nudPick"
    Me.nudPick.Size = New System.Drawing.Size(145, 26)
    Me.nudPick.TabIndex = 0
    Me.nudPick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtInput
    '
    Me.txtInput.Location = New System.Drawing.Point(11, 278)
    Me.txtInput.Multiline = True
    Me.txtInput.Name = "txtInput"
    Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtInput.Size = New System.Drawing.Size(243, 89)
    Me.txtInput.TabIndex = 8
    '
    'GroupBox3
    '
    Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.GroupBox3.Controls.Add(Me.rdoBlack)
    Me.GroupBox3.Controls.Add(Me.rdoGreen)
    Me.GroupBox3.Controls.Add(Me.rdoBlue)
    Me.GroupBox3.Controls.Add(Me.rdoRed)
    Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox3.Location = New System.Drawing.Point(211, 197)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(193, 70)
    Me.GroupBox3.TabIndex = 8
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Color"
    '
    'rdoBlack
    '
    Me.rdoBlack.AutoSize = True
    Me.rdoBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoBlack.Location = New System.Drawing.Point(102, 44)
    Me.rdoBlack.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.rdoBlack.Name = "rdoBlack"
    Me.rdoBlack.Size = New System.Drawing.Size(60, 20)
    Me.rdoBlack.TabIndex = 3
    Me.rdoBlack.Text = "Black"
    '
    'rdoGreen
    '
    Me.rdoGreen.AutoSize = True
    Me.rdoGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoGreen.Location = New System.Drawing.Point(102, 22)
    Me.rdoGreen.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.rdoGreen.Name = "rdoGreen"
    Me.rdoGreen.Size = New System.Drawing.Size(63, 20)
    Me.rdoGreen.TabIndex = 2
    Me.rdoGreen.Text = "Green"
    '
    'rdoBlue
    '
    Me.rdoBlue.AutoSize = True
    Me.rdoBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoBlue.Location = New System.Drawing.Point(19, 44)
    Me.rdoBlue.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.rdoBlue.Name = "rdoBlue"
    Me.rdoBlue.Size = New System.Drawing.Size(53, 20)
    Me.rdoBlue.TabIndex = 1
    Me.rdoBlue.Text = "Blue"
    '
    'rdoRed
    '
    Me.rdoRed.AutoSize = True
    Me.rdoRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoRed.Location = New System.Drawing.Point(19, 22)
    Me.rdoRed.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.rdoRed.Name = "rdoRed"
    Me.rdoRed.Size = New System.Drawing.Size(52, 20)
    Me.rdoRed.TabIndex = 0
    Me.rdoRed.Text = "Red"
    '
    'btnBeep
    '
    Me.btnBeep.BackColor = System.Drawing.SystemColors.Control
    Me.btnBeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBeep.Location = New System.Drawing.Point(286, 302)
    Me.btnBeep.Name = "btnBeep"
    Me.btnBeep.Size = New System.Drawing.Size(97, 40)
    Me.btnBeep.TabIndex = 9
    Me.btnBeep.Text = "Beep!"
    Me.btnBeep.UseVisualStyleBackColor = False
    '
    'timBall
    '
    '
    'pnlBall
    '
    Me.pnlBall.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.pnlBall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.pnlBall.Controls.Add(Me.picMyBall)
    Me.pnlBall.Location = New System.Drawing.Point(439, 13)
    Me.pnlBall.Name = "pnlBall"
    Me.pnlBall.Size = New System.Drawing.Size(58, 329)
    Me.pnlBall.TabIndex = 10
    '
    'picMyBall
    '
    Me.picMyBall.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.picMyBall.Image = Global.Sample.My.Resources.Resources.ball
    Me.picMyBall.Location = New System.Drawing.Point(10, 153)
    Me.picMyBall.Name = "picMyBall"
    Me.picMyBall.Size = New System.Drawing.Size(34, 35)
    Me.picMyBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picMyBall.TabIndex = 0
    Me.picMyBall.TabStop = False
    Me.picMyBall.Visible = False
    '
    'btnBall
    '
    Me.btnBall.BackColor = System.Drawing.SystemColors.Control
    Me.btnBall.Location = New System.Drawing.Point(443, 349)
    Me.btnBall.Name = "btnBall"
    Me.btnBall.Size = New System.Drawing.Size(54, 27)
    Me.btnBall.TabIndex = 11
    Me.btnBall.Text = "Start"
    Me.btnBall.UseVisualStyleBackColor = False
    '
    'Form1
    '
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(509, 379)
    Me.Controls.Add(Me.btnBall)
    Me.Controls.Add(Me.pnlBall)
    Me.Controls.Add(Me.btnBeep)
    Me.Controls.Add(Me.GroupBox3)
    Me.Controls.Add(Me.txtInput)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.picPizza)
    Me.Controls.Add(Me.picPopcorn)
    Me.Controls.Add(Me.picSoup)
    Me.Controls.Add(Me.picFries)
    Me.Controls.Add(Me.picHotDog)
    Me.Controls.Add(Me.picBurger)
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Beginning Visual Basic Express - Sample"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.picBurger, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picHotDog, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picFries, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picPopcorn, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picSoup, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox2.ResumeLayout(False)
    CType(Me.nudPick, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.pnlBall.ResumeLayout(False)
    CType(Me.picMyBall, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents chkPizza As System.Windows.Forms.CheckBox
  Friend WithEvents chkPopcorn As System.Windows.Forms.CheckBox
  Friend WithEvents chkSoup As System.Windows.Forms.CheckBox
  Friend WithEvents chkFries As System.Windows.Forms.CheckBox
  Friend WithEvents chkHotDog As System.Windows.Forms.CheckBox
  Friend WithEvents chkBurger As System.Windows.Forms.CheckBox
  Friend WithEvents picBurger As System.Windows.Forms.PictureBox
  Friend WithEvents picHotDog As System.Windows.Forms.PictureBox
  Friend WithEvents picFries As System.Windows.Forms.PictureBox
  Friend WithEvents picPizza As System.Windows.Forms.PictureBox
  Friend WithEvents picPopcorn As System.Windows.Forms.PictureBox
  Friend WithEvents picSoup As System.Windows.Forms.PictureBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents nudPick As System.Windows.Forms.NumericUpDown
  Friend WithEvents txtInput As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
  Friend WithEvents rdoBlack As System.Windows.Forms.RadioButton
  Friend WithEvents rdoGreen As System.Windows.Forms.RadioButton
  Friend WithEvents rdoBlue As System.Windows.Forms.RadioButton
  Friend WithEvents btnBeep As System.Windows.Forms.Button
  Friend WithEvents timBall As System.Windows.Forms.Timer
  Friend WithEvents pnlBall As System.Windows.Forms.Panel
  Friend WithEvents btnBall As System.Windows.Forms.Button
  Friend WithEvents picMyBall As System.Windows.Forms.PictureBox

End Class
