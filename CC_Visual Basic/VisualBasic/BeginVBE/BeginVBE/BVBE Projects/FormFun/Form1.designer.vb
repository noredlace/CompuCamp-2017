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
    Me.btnShrink = New System.Windows.Forms.Button()
    Me.btnGrow = New System.Windows.Forms.Button()
    Me.btnHide = New System.Windows.Forms.Button()
    Me.btnRed = New System.Windows.Forms.Button()
    Me.btnBlue = New System.Windows.Forms.Button()
    Me.btnShow = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'btnShrink
    '
    Me.btnShrink.BackColor = System.Drawing.SystemColors.Control
    Me.btnShrink.Location = New System.Drawing.Point(13, 5)
    Me.btnShrink.Name = "btnShrink"
    Me.btnShrink.Size = New System.Drawing.Size(107, 33)
    Me.btnShrink.TabIndex = 0
    Me.btnShrink.Text = "Shrink Form"
    Me.btnShrink.UseVisualStyleBackColor = False
    '
    'btnGrow
    '
    Me.btnGrow.BackColor = System.Drawing.SystemColors.Control
    Me.btnGrow.Location = New System.Drawing.Point(13, 45)
    Me.btnGrow.Name = "btnGrow"
    Me.btnGrow.Size = New System.Drawing.Size(107, 33)
    Me.btnGrow.TabIndex = 1
    Me.btnGrow.Text = "Grow Form"
    Me.btnGrow.UseVisualStyleBackColor = False
    '
    'btnHide
    '
    Me.btnHide.BackColor = System.Drawing.SystemColors.Control
    Me.btnHide.Location = New System.Drawing.Point(13, 85)
    Me.btnHide.Name = "btnHide"
    Me.btnHide.Size = New System.Drawing.Size(107, 33)
    Me.btnHide.TabIndex = 2
    Me.btnHide.Text = "Hide Buttons"
    Me.btnHide.UseVisualStyleBackColor = False
    '
    'btnRed
    '
    Me.btnRed.BackColor = System.Drawing.SystemColors.Control
    Me.btnRed.Location = New System.Drawing.Point(127, 5)
    Me.btnRed.Name = "btnRed"
    Me.btnRed.Size = New System.Drawing.Size(107, 33)
    Me.btnRed.TabIndex = 5
    Me.btnRed.Text = "Red Form"
    Me.btnRed.UseVisualStyleBackColor = False
    '
    'btnBlue
    '
    Me.btnBlue.BackColor = System.Drawing.SystemColors.Control
    Me.btnBlue.Location = New System.Drawing.Point(127, 45)
    Me.btnBlue.Name = "btnBlue"
    Me.btnBlue.Size = New System.Drawing.Size(107, 33)
    Me.btnBlue.TabIndex = 4
    Me.btnBlue.Text = "Blue Form"
    Me.btnBlue.UseVisualStyleBackColor = False
    '
    'btnShow
    '
    Me.btnShow.BackColor = System.Drawing.SystemColors.Control
    Me.btnShow.Location = New System.Drawing.Point(127, 85)
    Me.btnShow.Name = "btnShow"
    Me.btnShow.Size = New System.Drawing.Size(107, 33)
    Me.btnShow.TabIndex = 3
    Me.btnShow.Text = "Show Buttons"
    Me.btnShow.UseVisualStyleBackColor = False
    Me.btnShow.Visible = False
    '
    'Form1
    '
    Me.ClientSize = New System.Drawing.Size(249, 127)
    Me.Controls.Add(Me.btnRed)
    Me.Controls.Add(Me.btnBlue)
    Me.Controls.Add(Me.btnShow)
    Me.Controls.Add(Me.btnHide)
    Me.Controls.Add(Me.btnGrow)
    Me.Controls.Add(Me.btnShrink)
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Form Fun"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnShrink As System.Windows.Forms.Button
  Friend WithEvents btnGrow As System.Windows.Forms.Button
  Friend WithEvents btnHide As System.Windows.Forms.Button
  Friend WithEvents btnRed As System.Windows.Forms.Button
  Friend WithEvents btnBlue As System.Windows.Forms.Button
  Friend WithEvents btnShow As System.Windows.Forms.Button

End Class
