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
        Me.pnlBlackboard = New System.Windows.Forms.Panel()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.rdoWhite = New System.Windows.Forms.RadioButton()
        Me.rdoYellow = New System.Windows.Forms.RadioButton()
        Me.rdoMagenta = New System.Windows.Forms.RadioButton()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoCyan = New System.Windows.Forms.RadioButton()
        Me.rdoGreen = New System.Windows.Forms.RadioButton()
        Me.rdoBlue = New System.Windows.Forms.RadioButton()
        Me.rdoGray = New System.Windows.Forms.RadioButton()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBlackboard
        '
        Me.pnlBlackboard.BackColor = System.Drawing.Color.Black
        Me.pnlBlackboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBlackboard.Location = New System.Drawing.Point(12, 13)
        Me.pnlBlackboard.Name = "pnlBlackboard"
        Me.pnlBlackboard.Size = New System.Drawing.Size(386, 313)
        Me.pnlBlackboard.TabIndex = 0
        '
        'grpColor
        '
        Me.grpColor.BackColor = System.Drawing.Color.Black
        Me.grpColor.Controls.Add(Me.rdoWhite)
        Me.grpColor.Controls.Add(Me.rdoYellow)
        Me.grpColor.Controls.Add(Me.rdoMagenta)
        Me.grpColor.Controls.Add(Me.rdoRed)
        Me.grpColor.Controls.Add(Me.rdoCyan)
        Me.grpColor.Controls.Add(Me.rdoGreen)
        Me.grpColor.Controls.Add(Me.rdoBlue)
        Me.grpColor.Controls.Add(Me.rdoGray)
        Me.grpColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpColor.ForeColor = System.Drawing.Color.White
        Me.grpColor.Location = New System.Drawing.Point(405, 4)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(120, 224)
        Me.grpColor.TabIndex = 1
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color"
        '
        'rdoWhite
        '
        Me.rdoWhite.AutoSize = True
        Me.rdoWhite.Location = New System.Drawing.Point(14, 194)
        Me.rdoWhite.Name = "rdoWhite"
        Me.rdoWhite.Size = New System.Drawing.Size(127, 29)
        Me.rdoWhite.TabIndex = 7
        Me.rdoWhite.Text = "               "
        '
        'rdoYellow
        '
        Me.rdoYellow.AutoSize = True
        Me.rdoYellow.Location = New System.Drawing.Point(14, 170)
        Me.rdoYellow.Name = "rdoYellow"
        Me.rdoYellow.Size = New System.Drawing.Size(127, 29)
        Me.rdoYellow.TabIndex = 6
        Me.rdoYellow.Text = "               "
        '
        'rdoMagenta
        '
        Me.rdoMagenta.AutoSize = True
        Me.rdoMagenta.Location = New System.Drawing.Point(14, 146)
        Me.rdoMagenta.Name = "rdoMagenta"
        Me.rdoMagenta.Size = New System.Drawing.Size(127, 29)
        Me.rdoMagenta.TabIndex = 5
        Me.rdoMagenta.Text = "               "
        '
        'rdoRed
        '
        Me.rdoRed.AutoSize = True
        Me.rdoRed.Location = New System.Drawing.Point(14, 122)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(127, 29)
        Me.rdoRed.TabIndex = 4
        Me.rdoRed.Text = "               "
        '
        'rdoCyan
        '
        Me.rdoCyan.AutoSize = True
        Me.rdoCyan.Location = New System.Drawing.Point(14, 98)
        Me.rdoCyan.Name = "rdoCyan"
        Me.rdoCyan.Size = New System.Drawing.Size(127, 29)
        Me.rdoCyan.TabIndex = 3
        Me.rdoCyan.Text = "               "
        '
        'rdoGreen
        '
        Me.rdoGreen.AutoSize = True
        Me.rdoGreen.Location = New System.Drawing.Point(14, 74)
        Me.rdoGreen.Name = "rdoGreen"
        Me.rdoGreen.Size = New System.Drawing.Size(127, 29)
        Me.rdoGreen.TabIndex = 2
        Me.rdoGreen.Text = "               "
        '
        'rdoBlue
        '
        Me.rdoBlue.AutoSize = True
        Me.rdoBlue.Location = New System.Drawing.Point(14, 50)
        Me.rdoBlue.Name = "rdoBlue"
        Me.rdoBlue.Size = New System.Drawing.Size(127, 29)
        Me.rdoBlue.TabIndex = 1
        Me.rdoBlue.Text = "               "
        '
        'rdoGray
        '
        Me.rdoGray.AutoSize = True
        Me.rdoGray.Location = New System.Drawing.Point(14, 22)
        Me.rdoGray.Name = "rdoGray"
        Me.rdoGray.Size = New System.Drawing.Size(127, 29)
        Me.rdoGray.TabIndex = 0
        Me.rdoGray.Text = "               "
        '
        'btnErase
        '
        Me.btnErase.Location = New System.Drawing.Point(407, 240)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(117, 21)
        Me.btnErase.TabIndex = 2
        Me.btnErase.Text = "Erase"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(407, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 21)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(533, 340)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.pnlBlackboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blackboard Fun"
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBlackboard As System.Windows.Forms.Panel
  Friend WithEvents grpColor As System.Windows.Forms.GroupBox
  Friend WithEvents rdoWhite As System.Windows.Forms.RadioButton
  Friend WithEvents rdoYellow As System.Windows.Forms.RadioButton
  Friend WithEvents rdoMagenta As System.Windows.Forms.RadioButton
  Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
  Friend WithEvents rdoCyan As System.Windows.Forms.RadioButton
  Friend WithEvents rdoGreen As System.Windows.Forms.RadioButton
  Friend WithEvents rdoBlue As System.Windows.Forms.RadioButton
  Friend WithEvents rdoGray As System.Windows.Forms.RadioButton
  Friend WithEvents btnErase As System.Windows.Forms.Button
  Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
