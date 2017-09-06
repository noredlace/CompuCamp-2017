Partial Public Class frmPong
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtScore1 = New System.Windows.Forms.TextBox()
    Me.btnNew = New System.Windows.Forms.Button()
    Me.btnPause = New System.Windows.Forms.Button()
    Me.btnExit = New System.Windows.Forms.Button()
    Me.txtScore2 = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.pnlField = New System.Windows.Forms.Panel()
    Me.timGame = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(22, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(77, 24)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Player 1"
    '
    'txtScore1
    '
    Me.txtScore1.BackColor = System.Drawing.Color.White
    Me.txtScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtScore1.Location = New System.Drawing.Point(12, 33)
    Me.txtScore1.Multiline = True
    Me.txtScore1.Name = "txtScore1"
    Me.txtScore1.ReadOnly = True
    Me.txtScore1.Size = New System.Drawing.Size(100, 36)
    Me.txtScore1.TabIndex = 1
    Me.txtScore1.TabStop = False
    Me.txtScore1.Text = "0"
    Me.txtScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnNew
    '
    Me.btnNew.BackColor = System.Drawing.SystemColors.Control
    Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNew.Location = New System.Drawing.Point(122, 41)
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Size = New System.Drawing.Size(98, 24)
    Me.btnNew.TabIndex = 2
    Me.btnNew.Text = "&New Game"
    Me.btnNew.UseVisualStyleBackColor = False
    '
    'btnPause
    '
    Me.btnPause.BackColor = System.Drawing.SystemColors.Control
    Me.btnPause.Enabled = False
    Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPause.Location = New System.Drawing.Point(227, 42)
    Me.btnPause.Name = "btnPause"
    Me.btnPause.Size = New System.Drawing.Size(98, 24)
    Me.btnPause.TabIndex = 3
    Me.btnPause.Text = "&Pause"
    Me.btnPause.UseVisualStyleBackColor = False
    '
    'btnExit
    '
    Me.btnExit.BackColor = System.Drawing.SystemColors.Control
    Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExit.Location = New System.Drawing.Point(332, 42)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(98, 24)
    Me.btnExit.TabIndex = 4
    Me.btnExit.Text = "E&xit"
    Me.btnExit.UseVisualStyleBackColor = False
    '
    'txtScore2
    '
    Me.txtScore2.BackColor = System.Drawing.Color.White
    Me.txtScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtScore2.Location = New System.Drawing.Point(437, 33)
    Me.txtScore2.Multiline = True
    Me.txtScore2.Name = "txtScore2"
    Me.txtScore2.ReadOnly = True
    Me.txtScore2.Size = New System.Drawing.Size(100, 36)
    Me.txtScore2.TabIndex = 6
    Me.txtScore2.TabStop = False
    Me.txtScore2.Text = "0"
    Me.txtScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(448, 9)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(77, 24)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Player 2"
    '
    'pnlField
    '
    Me.pnlField.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.pnlField.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.pnlField.Location = New System.Drawing.Point(12, 76)
    Me.pnlField.Name = "pnlField"
    Me.pnlField.Size = New System.Drawing.Size(525, 326)
    Me.pnlField.TabIndex = 7
    '
    'timGame
    '
    Me.timGame.Interval = 40
    '
    'frmPong
    '
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(552, 410)
    Me.Controls.Add(Me.pnlField)
    Me.Controls.Add(Me.txtScore2)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnPause)
    Me.Controls.Add(Me.btnNew)
    Me.Controls.Add(Me.txtScore1)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.Name = "frmPong"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "The Original Video Game - Pong!"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtScore1 As System.Windows.Forms.TextBox
  Friend WithEvents btnNew As System.Windows.Forms.Button
  Friend WithEvents btnPause As System.Windows.Forms.Button
  Friend WithEvents btnExit As System.Windows.Forms.Button
  Friend WithEvents txtScore2 As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents pnlField As System.Windows.Forms.Panel
  Friend WithEvents timGame As System.Windows.Forms.Timer

End Class
