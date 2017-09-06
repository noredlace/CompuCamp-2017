Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDep = New System.Windows.Forms.TextBox()
        Me.txtWks = New System.Windows.Forms.TextBox()
        Me.txtSav = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnComp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDep
        '
        Me.txtDep.Location = New System.Drawing.Point(250, 28)
        Me.txtDep.Name = "txtDep"
        Me.txtDep.Size = New System.Drawing.Size(100, 20)
        Me.txtDep.TabIndex = 0
        '
        'txtWks
        '
        Me.txtWks.Location = New System.Drawing.Point(250, 97)
        Me.txtWks.Name = "txtWks"
        Me.txtWks.Size = New System.Drawing.Size(100, 20)
        Me.txtWks.TabIndex = 1
        '
        'txtSav
        '
        Me.txtSav.Location = New System.Drawing.Point(250, 163)
        Me.txtSav.Name = "txtSav"
        Me.txtSav.Size = New System.Drawing.Size(100, 20)
        Me.txtSav.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Weekly Deposit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of Weeks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Savings"
        '
        'btnComp
        '
        Me.btnComp.Location = New System.Drawing.Point(111, 198)
        Me.btnComp.Name = "btnComp"
        Me.btnComp.Size = New System.Drawing.Size(75, 23)
        Me.btnComp.TabIndex = 6
        Me.btnComp.Text = "Compute"
        Me.btnComp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(250, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(440, 245)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnComp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSav)
        Me.Controls.Add(Me.txtWks)
        Me.Controls.Add(Me.txtDep)
        Me.Name = "Form1"
        Me.Text = "My First Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDep As TextBox
    Friend WithEvents txtWks As TextBox
    Friend WithEvents txtSav As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnComp As Button
    Friend WithEvents btnExit As Button
End Class
