<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtPScore = New System.Windows.Forms.TextBox()
        Me.txtCScore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Player = New System.Windows.Forms.Label()
        Me.lblPnum = New System.Windows.Forms.Label()
        Me.picPlayerSuits = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCnum = New System.Windows.Forms.Label()
        Me.picComSuits = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.picSpade = New System.Windows.Forms.PictureBox()
        Me.picDiamond = New System.Windows.Forms.PictureBox()
        Me.picClubs = New System.Windows.Forms.PictureBox()
        Me.picHeart = New System.Windows.Forms.PictureBox()
        Me.picClear = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayerSuits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picComSuits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiamond, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClubs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPScore
        '
        Me.txtPScore.Location = New System.Drawing.Point(98, 172)
        Me.txtPScore.Name = "txtPScore"
        Me.txtPScore.Size = New System.Drawing.Size(100, 26)
        Me.txtPScore.TabIndex = 0
        '
        'txtCScore
        '
        Me.txtCScore.Location = New System.Drawing.Point(98, 341)
        Me.txtCScore.Name = "txtCScore"
        Me.txtCScore.Size = New System.Drawing.Size(100, 26)
        Me.txtCScore.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Computer"
        '
        'Player
        '
        Me.Player.AutoSize = True
        Me.Player.Location = New System.Drawing.Point(94, 134)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(52, 20)
        Me.Player.TabIndex = 3
        Me.Player.Text = "Player"
        '
        'lblPnum
        '
        Me.lblPnum.AutoSize = True
        Me.lblPnum.Location = New System.Drawing.Point(79, 214)
        Me.lblPnum.Name = "lblPnum"
        Me.lblPnum.Size = New System.Drawing.Size(51, 20)
        Me.lblPnum.TabIndex = 4
        Me.lblPnum.Text = "label3"
        '
        'picPlayerSuits
        '
        Me.picPlayerSuits.Location = New System.Drawing.Point(52, 59)
        Me.picPlayerSuits.Name = "picPlayerSuits"
        Me.picPlayerSuits.Size = New System.Drawing.Size(100, 100)
        Me.picPlayerSuits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayerSuits.TabIndex = 8
        Me.picPlayerSuits.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPnum)
        Me.Panel1.Controls.Add(Me.picPlayerSuits)
        Me.Panel1.Location = New System.Drawing.Point(373, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 297)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCnum)
        Me.Panel2.Controls.Add(Me.picComSuits)
        Me.Panel2.Location = New System.Drawing.Point(373, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 297)
        Me.Panel2.TabIndex = 10
        '
        'lblCnum
        '
        Me.lblCnum.AutoSize = True
        Me.lblCnum.Location = New System.Drawing.Point(79, 214)
        Me.lblCnum.Name = "lblCnum"
        Me.lblCnum.Size = New System.Drawing.Size(57, 20)
        Me.lblCnum.TabIndex = 4
        Me.lblCnum.Text = "Label4"
        '
        'picComSuits
        '
        Me.picComSuits.Location = New System.Drawing.Point(52, 59)
        Me.picComSuits.Name = "picComSuits"
        Me.picComSuits.Size = New System.Drawing.Size(100, 100)
        Me.picComSuits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComSuits.TabIndex = 8
        Me.picComSuits.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(697, 202)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(133, 44)
        Me.btnPlay.TabIndex = 11
        Me.btnPlay.Text = "New Game"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(697, 263)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(133, 46)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(629, 12)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(255, 186)
        Me.txtInfo.TabIndex = 13
        '
        'picSpade
        '
        Me.picSpade.Image = CType(resources.GetObject("picSpade.Image"), System.Drawing.Image)
        Me.picSpade.Location = New System.Drawing.Point(640, 457)
        Me.picSpade.Name = "picSpade"
        Me.picSpade.Size = New System.Drawing.Size(100, 100)
        Me.picSpade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSpade.TabIndex = 15
        Me.picSpade.TabStop = False
        Me.picSpade.Visible = False
        '
        'picDiamond
        '
        Me.picDiamond.Image = CType(resources.GetObject("picDiamond.Image"), System.Drawing.Image)
        Me.picDiamond.Location = New System.Drawing.Point(784, 318)
        Me.picDiamond.Name = "picDiamond"
        Me.picDiamond.Size = New System.Drawing.Size(100, 100)
        Me.picDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDiamond.TabIndex = 16
        Me.picDiamond.TabStop = False
        Me.picDiamond.Visible = False
        '
        'picClubs
        '
        Me.picClubs.Image = CType(resources.GetObject("picClubs.Image"), System.Drawing.Image)
        Me.picClubs.Location = New System.Drawing.Point(784, 457)
        Me.picClubs.Name = "picClubs"
        Me.picClubs.Size = New System.Drawing.Size(100, 100)
        Me.picClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClubs.TabIndex = 17
        Me.picClubs.TabStop = False
        Me.picClubs.Visible = False
        '
        'picHeart
        '
        Me.picHeart.Image = CType(resources.GetObject("picHeart.Image"), System.Drawing.Image)
        Me.picHeart.Location = New System.Drawing.Point(640, 318)
        Me.picHeart.Name = "picHeart"
        Me.picHeart.Size = New System.Drawing.Size(100, 100)
        Me.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeart.TabIndex = 18
        Me.picHeart.TabStop = False
        Me.picHeart.Visible = False
        '
        'picClear
        '
        Me.picClear.Location = New System.Drawing.Point(713, 384)
        Me.picClear.Name = "picClear"
        Me.picClear.Size = New System.Drawing.Size(100, 100)
        Me.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClear.TabIndex = 19
        Me.picClear.TabStop = False
        Me.picClear.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 634)
        Me.Controls.Add(Me.picClear)
        Me.Controls.Add(Me.picHeart)
        Me.Controls.Add(Me.picClubs)
        Me.Controls.Add(Me.picDiamond)
        Me.Controls.Add(Me.picSpade)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCScore)
        Me.Controls.Add(Me.txtPScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlayerSuits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picComSuits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiamond, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClubs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPScore As TextBox
    Friend WithEvents txtCScore As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Player As Label
    Friend WithEvents lblPnum As Label
    Friend WithEvents picPlayerSuits As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCnum As Label
    Friend WithEvents picComSuits As PictureBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents picSpade As PictureBox
    Friend WithEvents picDiamond As PictureBox
    Friend WithEvents picClubs As PictureBox
    Friend WithEvents picHeart As PictureBox
    Friend WithEvents picClear As PictureBox
End Class
