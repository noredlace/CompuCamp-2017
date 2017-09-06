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
    Me.txtFromValue = New System.Windows.Forms.TextBox
    Me.txtToValue = New System.Windows.Forms.TextBox
    Me.grpConvert = New System.Windows.Forms.GroupBox
    Me.rdoDec3 = New System.Windows.Forms.RadioButton
    Me.rdoDec4 = New System.Windows.Forms.RadioButton
    Me.rdoDec5 = New System.Windows.Forms.RadioButton
    Me.rdoDec2 = New System.Windows.Forms.RadioButton
    Me.rdoDec1 = New System.Windows.Forms.RadioButton
    Me.rdoDec0 = New System.Windows.Forms.RadioButton
    Me.dudToUnit = New System.Windows.Forms.DomainUpDown
    Me.dudFromUnit = New System.Windows.Forms.DomainUpDown
    Me.grpConvert.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtFromValue
    '
    Me.txtFromValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtFromValue.Location = New System.Drawing.Point(4, 13)
    Me.txtFromValue.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.txtFromValue.Name = "txtFromValue"
    Me.txtFromValue.Size = New System.Drawing.Size(128, 26)
    Me.txtFromValue.TabIndex = 0
    Me.txtFromValue.Text = "0"
    Me.txtFromValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtToValue
    '
    Me.txtToValue.BackColor = System.Drawing.Color.White
    Me.txtToValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtToValue.Location = New System.Drawing.Point(4, 40)
    Me.txtToValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
    Me.txtToValue.Name = "txtToValue"
    Me.txtToValue.ReadOnly = True
    Me.txtToValue.Size = New System.Drawing.Size(128, 26)
    Me.txtToValue.TabIndex = 1
    Me.txtToValue.TabStop = False
    Me.txtToValue.Text = "0"
    Me.txtToValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'grpConvert
    '
    Me.grpConvert.Controls.Add(Me.rdoDec3)
    Me.grpConvert.Controls.Add(Me.rdoDec4)
    Me.grpConvert.Controls.Add(Me.rdoDec5)
    Me.grpConvert.Controls.Add(Me.rdoDec2)
    Me.grpConvert.Controls.Add(Me.rdoDec1)
    Me.grpConvert.Controls.Add(Me.rdoDec0)
    Me.grpConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpConvert.Location = New System.Drawing.Point(51, 82)
    Me.grpConvert.Name = "grpConvert"
    Me.grpConvert.Size = New System.Drawing.Size(201, 96)
    Me.grpConvert.TabIndex = 4
    Me.grpConvert.TabStop = False
    Me.grpConvert.Text = "Number of Decimals"
    '
    'rdoDec3
    '
    Me.rdoDec3.AutoSize = True
    Me.rdoDec3.Location = New System.Drawing.Point(115, 23)
    Me.rdoDec3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.rdoDec3.Name = "rdoDec3"
    Me.rdoDec3.Size = New System.Drawing.Size(29, 20)
    Me.rdoDec3.TabIndex = 5
    Me.rdoDec3.Text = "3"
    '
    'rdoDec4
    '
    Me.rdoDec4.AutoSize = True
    Me.rdoDec4.Location = New System.Drawing.Point(115, 47)
    Me.rdoDec4.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.rdoDec4.Name = "rdoDec4"
    Me.rdoDec4.Size = New System.Drawing.Size(29, 20)
    Me.rdoDec4.TabIndex = 4
    Me.rdoDec4.Text = "4"
    '
    'rdoDec5
    '
    Me.rdoDec5.AutoSize = True
    Me.rdoDec5.Location = New System.Drawing.Point(115, 71)
    Me.rdoDec5.Name = "rdoDec5"
    Me.rdoDec5.Size = New System.Drawing.Size(29, 20)
    Me.rdoDec5.TabIndex = 3
    Me.rdoDec5.Text = "5"
    '
    'rdoDec2
    '
    Me.rdoDec2.AutoSize = True
    Me.rdoDec2.Location = New System.Drawing.Point(12, 71)
    Me.rdoDec2.Name = "rdoDec2"
    Me.rdoDec2.Size = New System.Drawing.Size(29, 20)
    Me.rdoDec2.TabIndex = 2
    Me.rdoDec2.Text = "2"
    '
    'rdoDec1
    '
    Me.rdoDec1.AutoSize = True
    Me.rdoDec1.Location = New System.Drawing.Point(12, 47)
    Me.rdoDec1.Name = "rdoDec1"
    Me.rdoDec1.Size = New System.Drawing.Size(29, 20)
    Me.rdoDec1.TabIndex = 1
    Me.rdoDec1.Text = "1"
    '
    'rdoDec0
    '
    Me.rdoDec0.AutoSize = True
    Me.rdoDec0.Checked = True
    Me.rdoDec0.Location = New System.Drawing.Point(12, 23)
    Me.rdoDec0.Name = "rdoDec0"
    Me.rdoDec0.Size = New System.Drawing.Size(29, 20)
    Me.rdoDec0.TabIndex = 0
    Me.rdoDec0.TabStop = True
    Me.rdoDec0.Text = "0"
    '
    'dudToUnit
    '
    Me.dudToUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dudToUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dudToUnit.Location = New System.Drawing.Point(139, 40)
    Me.dudToUnit.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.dudToUnit.Name = "dudToUnit"
    Me.dudToUnit.Size = New System.Drawing.Size(155, 26)
    Me.dudToUnit.TabIndex = 6
    Me.dudToUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'dudFromUnit
    '
    Me.dudFromUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dudFromUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dudFromUnit.Location = New System.Drawing.Point(139, 13)
    Me.dudFromUnit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
    Me.dudFromUnit.Name = "dudFromUnit"
    Me.dudFromUnit.Size = New System.Drawing.Size(155, 26)
    Me.dudFromUnit.TabIndex = 7
    Me.dudFromUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(298, 184)
    Me.Controls.Add(Me.dudFromUnit)
    Me.Controls.Add(Me.dudToUnit)
    Me.Controls.Add(Me.grpConvert)
    Me.Controls.Add(Me.txtToValue)
    Me.Controls.Add(Me.txtFromValue)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Units Conversion"
    Me.grpConvert.ResumeLayout(False)
    Me.grpConvert.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtFromValue As System.Windows.Forms.TextBox
  Friend WithEvents txtToValue As System.Windows.Forms.TextBox
  Friend WithEvents grpConvert As System.Windows.Forms.GroupBox
  Friend WithEvents rdoDec3 As System.Windows.Forms.RadioButton
  Friend WithEvents rdoDec4 As System.Windows.Forms.RadioButton
  Friend WithEvents rdoDec5 As System.Windows.Forms.RadioButton
  Friend WithEvents rdoDec2 As System.Windows.Forms.RadioButton
  Friend WithEvents rdoDec1 As System.Windows.Forms.RadioButton
  Friend WithEvents rdoDec0 As System.Windows.Forms.RadioButton
  Friend WithEvents dudToUnit As System.Windows.Forms.DomainUpDown
  Friend WithEvents dudFromUnit As System.Windows.Forms.DomainUpDown

End Class
