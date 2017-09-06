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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpBread = New System.Windows.Forms.GroupBox()
        Me.rdoRye = New System.Windows.Forms.RadioButton()
        Me.rdoWheat = New System.Windows.Forms.RadioButton()
        Me.rdoWhite = New System.Windows.Forms.RadioButton()
        Me.grpCheese = New System.Windows.Forms.GroupBox()
        Me.rdoSwiss = New System.Windows.Forms.RadioButton()
        Me.rdoAmerican = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.grpMeats = New System.Windows.Forms.GroupBox()
        Me.chkSalami = New System.Windows.Forms.CheckBox()
        Me.chkPastrami = New System.Windows.Forms.CheckBox()
        Me.chkTurkey = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkRoastBeef = New System.Windows.Forms.CheckBox()
        Me.grpCondiments = New System.Windows.Forms.GroupBox()
        Me.chkPickles = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.grpBread.SuspendLayout()
        Me.grpCheese.SuspendLayout()
        Me.grpMeats.SuspendLayout()
        Me.grpCondiments.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBread
        '
        Me.grpBread.BackColor = System.Drawing.SystemColors.Control
        Me.grpBread.Controls.Add(Me.rdoRye)
        Me.grpBread.Controls.Add(Me.rdoWheat)
        Me.grpBread.Controls.Add(Me.rdoWhite)
        Me.grpBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBread.Location = New System.Drawing.Point(10, 11)
        Me.grpBread.Name = "grpBread"
        Me.grpBread.Size = New System.Drawing.Size(129, 110)
        Me.grpBread.TabIndex = 0
        Me.grpBread.TabStop = False
        Me.grpBread.Text = "Bread"
        '
        'rdoRye
        '
        Me.rdoRye.AutoSize = True
        Me.rdoRye.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRye.Location = New System.Drawing.Point(16, 83)
        Me.rdoRye.Name = "rdoRye"
        Me.rdoRye.Size = New System.Drawing.Size(63, 24)
        Me.rdoRye.TabIndex = 2
        Me.rdoRye.Text = "Rye"
        '
        'rdoWheat
        '
        Me.rdoWheat.AutoSize = True
        Me.rdoWheat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWheat.Location = New System.Drawing.Point(16, 54)
        Me.rdoWheat.Name = "rdoWheat"
        Me.rdoWheat.Size = New System.Drawing.Size(82, 24)
        Me.rdoWheat.TabIndex = 1
        Me.rdoWheat.Text = "Wheat"
        '
        'rdoWhite
        '
        Me.rdoWhite.AutoSize = True
        Me.rdoWhite.Checked = True
        Me.rdoWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWhite.Location = New System.Drawing.Point(16, 27)
        Me.rdoWhite.Name = "rdoWhite"
        Me.rdoWhite.Size = New System.Drawing.Size(77, 24)
        Me.rdoWhite.TabIndex = 0
        Me.rdoWhite.TabStop = True
        Me.rdoWhite.Text = "White"
        '
        'grpCheese
        '
        Me.grpCheese.BackColor = System.Drawing.SystemColors.Control
        Me.grpCheese.Controls.Add(Me.rdoSwiss)
        Me.grpCheese.Controls.Add(Me.rdoAmerican)
        Me.grpCheese.Controls.Add(Me.rdoNone)
        Me.grpCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCheese.Location = New System.Drawing.Point(146, 11)
        Me.grpCheese.Name = "grpCheese"
        Me.grpCheese.Size = New System.Drawing.Size(129, 110)
        Me.grpCheese.TabIndex = 3
        Me.grpCheese.TabStop = False
        Me.grpCheese.Text = "Cheese"
        '
        'rdoSwiss
        '
        Me.rdoSwiss.AutoSize = True
        Me.rdoSwiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSwiss.Location = New System.Drawing.Point(10, 83)
        Me.rdoSwiss.Name = "rdoSwiss"
        Me.rdoSwiss.Size = New System.Drawing.Size(79, 24)
        Me.rdoSwiss.TabIndex = 2
        Me.rdoSwiss.Text = "Swiss"
        '
        'rdoAmerican
        '
        Me.rdoAmerican.AutoSize = True
        Me.rdoAmerican.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAmerican.Location = New System.Drawing.Point(10, 54)
        Me.rdoAmerican.Name = "rdoAmerican"
        Me.rdoAmerican.Size = New System.Drawing.Size(105, 24)
        Me.rdoAmerican.TabIndex = 1
        Me.rdoAmerican.Text = "American"
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Checked = True
        Me.rdoNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNone.Location = New System.Drawing.Point(10, 27)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(73, 24)
        Me.rdoNone.TabIndex = 0
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(285, 15)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(74, 25)
        Me.lblOrder.TabIndex = 4
        Me.lblOrder.Text = "Order:"
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(285, 36)
        Me.txtOrder.Multiline = True
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOrder.Size = New System.Drawing.Size(124, 134)
        Me.txtOrder.TabIndex = 5
        '
        'grpMeats
        '
        Me.grpMeats.BackColor = System.Drawing.SystemColors.Control
        Me.grpMeats.Controls.Add(Me.chkSalami)
        Me.grpMeats.Controls.Add(Me.chkPastrami)
        Me.grpMeats.Controls.Add(Me.chkTurkey)
        Me.grpMeats.Controls.Add(Me.chkHam)
        Me.grpMeats.Controls.Add(Me.chkRoastBeef)
        Me.grpMeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMeats.Location = New System.Drawing.Point(13, 138)
        Me.grpMeats.Name = "grpMeats"
        Me.grpMeats.Size = New System.Drawing.Size(125, 142)
        Me.grpMeats.TabIndex = 6
        Me.grpMeats.TabStop = False
        Me.grpMeats.Text = "Meats"
        '
        'chkSalami
        '
        Me.chkSalami.AutoSize = True
        Me.chkSalami.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalami.Location = New System.Drawing.Point(13, 121)
        Me.chkSalami.Name = "chkSalami"
        Me.chkSalami.Size = New System.Drawing.Size(86, 24)
        Me.chkSalami.TabIndex = 4
        Me.chkSalami.Text = "Salami"
        '
        'chkPastrami
        '
        Me.chkPastrami.AutoSize = True
        Me.chkPastrami.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPastrami.Location = New System.Drawing.Point(13, 97)
        Me.chkPastrami.Name = "chkPastrami"
        Me.chkPastrami.Size = New System.Drawing.Size(102, 24)
        Me.chkPastrami.TabIndex = 3
        Me.chkPastrami.Text = "Pastrami"
        '
        'chkTurkey
        '
        Me.chkTurkey.AutoSize = True
        Me.chkTurkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTurkey.Location = New System.Drawing.Point(13, 73)
        Me.chkTurkey.Name = "chkTurkey"
        Me.chkTurkey.Size = New System.Drawing.Size(85, 24)
        Me.chkTurkey.TabIndex = 2
        Me.chkTurkey.Text = "Turkey"
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHam.Location = New System.Drawing.Point(13, 51)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(71, 24)
        Me.chkHam.TabIndex = 1
        Me.chkHam.Text = "Ham"
        '
        'chkRoastBeef
        '
        Me.chkRoastBeef.AutoSize = True
        Me.chkRoastBeef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRoastBeef.Location = New System.Drawing.Point(13, 27)
        Me.chkRoastBeef.Name = "chkRoastBeef"
        Me.chkRoastBeef.Size = New System.Drawing.Size(119, 24)
        Me.chkRoastBeef.TabIndex = 0
        Me.chkRoastBeef.Text = "Roast Beef"
        '
        'grpCondiments
        '
        Me.grpCondiments.BackColor = System.Drawing.SystemColors.Control
        Me.grpCondiments.Controls.Add(Me.chkPickles)
        Me.grpCondiments.Controls.Add(Me.chkOnions)
        Me.grpCondiments.Controls.Add(Me.chkTomato)
        Me.grpCondiments.Controls.Add(Me.chkLettuce)
        Me.grpCondiments.Controls.Add(Me.chkMayo)
        Me.grpCondiments.Controls.Add(Me.chkMustard)
        Me.grpCondiments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondiments.Location = New System.Drawing.Point(152, 138)
        Me.grpCondiments.Name = "grpCondiments"
        Me.grpCondiments.Size = New System.Drawing.Size(112, 167)
        Me.grpCondiments.TabIndex = 7
        Me.grpCondiments.TabStop = False
        Me.grpCondiments.Text = "Condiments"
        '
        'chkPickles
        '
        Me.chkPickles.AutoSize = True
        Me.chkPickles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPickles.Location = New System.Drawing.Point(10, 145)
        Me.chkPickles.Name = "chkPickles"
        Me.chkPickles.Size = New System.Drawing.Size(89, 24)
        Me.chkPickles.TabIndex = 5
        Me.chkPickles.Text = "Pickles"
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnions.Location = New System.Drawing.Point(10, 121)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(88, 24)
        Me.chkOnions.TabIndex = 4
        Me.chkOnions.Text = "Onions"
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTomato.Location = New System.Drawing.Point(10, 97)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(91, 24)
        Me.chkTomato.TabIndex = 3
        Me.chkTomato.Text = "Tomato"
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLettuce.Location = New System.Drawing.Point(10, 73)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(91, 24)
        Me.chkLettuce.TabIndex = 2
        Me.chkLettuce.Text = "Lettuce"
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMayo.Location = New System.Drawing.Point(10, 50)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(124, 24)
        Me.chkMayo.TabIndex = 1
        Me.chkMayo.Text = "Mayonnaise"
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMustard.Location = New System.Drawing.Point(10, 26)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(96, 24)
        Me.chkMustard.TabIndex = 0
        Me.chkMustard.Text = "Mustard"
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.SystemColors.Control
        Me.btnOrder.Location = New System.Drawing.Point(313, 186)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 8
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(313, 216)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(290, 259)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 26)
        Me.txtCost.TabIndex = 10
        '
        'Form1
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(421, 312)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.grpCondiments)
        Me.Controls.Add(Me.grpMeats)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.grpCheese)
        Me.Controls.Add(Me.grpBread)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sandwich Maker"
        Me.grpBread.ResumeLayout(False)
        Me.grpBread.PerformLayout()
        Me.grpCheese.ResumeLayout(False)
        Me.grpCheese.PerformLayout()
        Me.grpMeats.ResumeLayout(False)
        Me.grpMeats.PerformLayout()
        Me.grpCondiments.ResumeLayout(False)
        Me.grpCondiments.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBread As System.Windows.Forms.GroupBox
  Friend WithEvents rdoRye As System.Windows.Forms.RadioButton
  Friend WithEvents rdoWheat As System.Windows.Forms.RadioButton
  Friend WithEvents rdoWhite As System.Windows.Forms.RadioButton
  Friend WithEvents grpCheese As System.Windows.Forms.GroupBox
  Friend WithEvents rdoSwiss As System.Windows.Forms.RadioButton
  Friend WithEvents rdoAmerican As System.Windows.Forms.RadioButton
  Friend WithEvents rdoNone As System.Windows.Forms.RadioButton
  Friend WithEvents lblOrder As System.Windows.Forms.Label
  Friend WithEvents txtOrder As System.Windows.Forms.TextBox
  Friend WithEvents grpMeats As System.Windows.Forms.GroupBox
  Friend WithEvents chkSalami As System.Windows.Forms.CheckBox
  Friend WithEvents chkPastrami As System.Windows.Forms.CheckBox
  Friend WithEvents chkTurkey As System.Windows.Forms.CheckBox
  Friend WithEvents chkHam As System.Windows.Forms.CheckBox
  Friend WithEvents chkRoastBeef As System.Windows.Forms.CheckBox
  Friend WithEvents grpCondiments As System.Windows.Forms.GroupBox
  Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
  Friend WithEvents chkPickles As System.Windows.Forms.CheckBox
  Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
  Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
  Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
  Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
  Friend WithEvents btnOrder As System.Windows.Forms.Button
  Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtCost As TextBox
End Class
