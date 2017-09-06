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
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.timDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.White
        Me.txtTime.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(13, 13)
        Me.txtTime.Multiline = True
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(173, 43)
        Me.txtTime.TabIndex = 0
        Me.txtTime.TabStop = False
        Me.txtTime.Text = "00:00:00"
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStartStop
        '
        Me.btnStartStop.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.Location = New System.Drawing.Point(45, 63)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(104, 39)
        Me.btnStartStop.TabIndex = 1
        Me.btnStartStop.Text = "Start"
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(45, 109)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 39)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        '
        'timDisplay
        '
        Me.timDisplay.Interval = 1000
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(205, 160)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.txtTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
  Friend WithEvents btnStartStop As System.Windows.Forms.Button
  Friend WithEvents btnReset As System.Windows.Forms.Button
  Friend WithEvents timDisplay As System.Windows.Forms.Timer

End Class
