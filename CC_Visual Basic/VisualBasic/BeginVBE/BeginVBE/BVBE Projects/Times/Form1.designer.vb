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
    Me.lblNum1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblNum2 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.lblScore = New System.Windows.Forms.Label
    Me.lblMessage = New System.Windows.Forms.Label
    Me.txtAnswer = New System.Windows.Forms.TextBox
    Me.btnNext = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'lblNum1
    '
    Me.lblNum1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNum1.Location = New System.Drawing.Point(13, 13)
    Me.lblNum1.Name = "lblNum1"
    Me.lblNum1.Size = New System.Drawing.Size(96, 91)
    Me.lblNum1.TabIndex = 0
    Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(116, 13)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(62, 91)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "x"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblNum2
    '
    Me.lblNum2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNum2.Location = New System.Drawing.Point(188, 13)
    Me.lblNum2.Name = "lblNum2"
    Me.lblNum2.Size = New System.Drawing.Size(96, 91)
    Me.lblNum2.TabIndex = 2
    Me.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label4
    '
    Me.Label4.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(291, 13)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(61, 91)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "="
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(13, 111)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(96, 34)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Score:"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblScore
    '
    Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblScore.Location = New System.Drawing.Point(13, 152)
    Me.lblScore.Name = "lblScore"
    Me.lblScore.Size = New System.Drawing.Size(96, 53)
    Me.lblScore.TabIndex = 5
    Me.lblScore.Text = "0%"
    Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblMessage
    '
    Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMessage.Location = New System.Drawing.Point(116, 111)
    Me.lblMessage.Name = "lblMessage"
    Me.lblMessage.Size = New System.Drawing.Size(337, 53)
    Me.lblMessage.TabIndex = 6
    Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtAnswer
    '
    Me.txtAnswer.AutoSize = False
    Me.txtAnswer.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnswer.Location = New System.Drawing.Point(361, 13)
    Me.txtAnswer.MaxLength = 2
    Me.txtAnswer.Multiline = True
    Me.txtAnswer.Name = "txtAnswer"
    Me.txtAnswer.Size = New System.Drawing.Size(92, 91)
    Me.txtAnswer.TabIndex = 7
    Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnNext
    '
    Me.btnNext.Location = New System.Drawing.Point(220, 177)
    Me.btnNext.Name = "btnNext"
    Me.btnNext.Size = New System.Drawing.Size(131, 27)
    Me.btnNext.TabIndex = 8
    Me.btnNext.Text = "Next Problem"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(473, 214)
    Me.Controls.Add(Me.btnNext)
    Me.Controls.Add(Me.txtAnswer)
    Me.Controls.Add(Me.lblMessage)
    Me.Controls.Add(Me.lblScore)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.lblNum2)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lblNum1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Times Tables"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lblNum1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblNum2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents lblScore As System.Windows.Forms.Label
  Friend WithEvents lblMessage As System.Windows.Forms.Label
  Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
  Friend WithEvents btnNext As System.Windows.Forms.Button

End Class
