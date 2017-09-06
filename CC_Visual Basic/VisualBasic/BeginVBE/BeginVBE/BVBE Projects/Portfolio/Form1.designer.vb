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
    Me.grpStock = New System.Windows.Forms.GroupBox
    Me.btnNext = New System.Windows.Forms.Button
    Me.btnPrevious = New System.Windows.Forms.Button
    Me.txtPaid = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtShares = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtPrice = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtDate = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.grpValue = New System.Windows.Forms.GroupBox
    Me.btnReturn = New System.Windows.Forms.Button
    Me.txtValue = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtReturn = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.txtToday = New System.Windows.Forms.TextBox
    Me.Label7 = New System.Windows.Forms.Label
    Me.txtTodayDate = New System.Windows.Forms.TextBox
    Me.Label8 = New System.Windows.Forms.Label
    Me.grpStock.SuspendLayout()
    Me.grpValue.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpStock
    '
    Me.grpStock.Controls.Add(Me.btnNext)
    Me.grpStock.Controls.Add(Me.btnPrevious)
    Me.grpStock.Controls.Add(Me.txtPaid)
    Me.grpStock.Controls.Add(Me.Label4)
    Me.grpStock.Controls.Add(Me.txtShares)
    Me.grpStock.Controls.Add(Me.Label3)
    Me.grpStock.Controls.Add(Me.txtPrice)
    Me.grpStock.Controls.Add(Me.Label2)
    Me.grpStock.Controls.Add(Me.txtDate)
    Me.grpStock.Controls.Add(Me.Label1)
    Me.grpStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpStock.Location = New System.Drawing.Point(17, 13)
    Me.grpStock.Name = "grpStock"
    Me.grpStock.Size = New System.Drawing.Size(222, 177)
    Me.grpStock.TabIndex = 0
    Me.grpStock.TabStop = False
    Me.grpStock.Text = "This Stock"
    '
    'btnNext
    '
    Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNext.Location = New System.Drawing.Point(120, 145)
    Me.btnNext.Name = "btnNext"
    Me.btnNext.TabIndex = 9
    Me.btnNext.Text = "Next"
    '
    'btnPrevious
    '
    Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPrevious.Location = New System.Drawing.Point(27, 145)
    Me.btnPrevious.Name = "btnPrevious"
    Me.btnPrevious.TabIndex = 8
    Me.btnPrevious.Text = "Previous"
    '
    'txtPaid
    '
    Me.txtPaid.BackColor = System.Drawing.Color.White
    Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPaid.Location = New System.Drawing.Point(110, 111)
    Me.txtPaid.Name = "txtPaid"
    Me.txtPaid.ReadOnly = True
    Me.txtPaid.TabIndex = 7
    Me.txtPaid.TabStop = False
    Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(7, 114)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(56, 14)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Price Paid"
    '
    'txtShares
    '
    Me.txtShares.BackColor = System.Drawing.Color.White
    Me.txtShares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtShares.Location = New System.Drawing.Point(110, 84)
    Me.txtShares.Name = "txtShares"
    Me.txtShares.ReadOnly = True
    Me.txtShares.TabIndex = 5
    Me.txtShares.TabStop = False
    Me.txtShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(7, 87)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(96, 14)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Number of Shares"
    '
    'txtPrice
    '
    Me.txtPrice.BackColor = System.Drawing.Color.White
    Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPrice.Location = New System.Drawing.Point(110, 57)
    Me.txtPrice.Name = "txtPrice"
    Me.txtPrice.ReadOnly = True
    Me.txtPrice.TabIndex = 3
    Me.txtPrice.TabStop = False
    Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(7, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(63, 14)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Price/Share"
    '
    'txtDate
    '
    Me.txtDate.BackColor = System.Drawing.Color.White
    Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDate.Location = New System.Drawing.Point(110, 30)
    Me.txtDate.Name = "txtDate"
    Me.txtDate.ReadOnly = True
    Me.txtDate.TabIndex = 1
    Me.txtDate.TabStop = False
    Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(7, 33)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(85, 14)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Date Purchased"
    '
    'grpValue
    '
    Me.grpValue.Controls.Add(Me.btnReturn)
    Me.grpValue.Controls.Add(Me.txtValue)
    Me.grpValue.Controls.Add(Me.Label5)
    Me.grpValue.Controls.Add(Me.txtReturn)
    Me.grpValue.Controls.Add(Me.Label6)
    Me.grpValue.Controls.Add(Me.txtToday)
    Me.grpValue.Controls.Add(Me.Label7)
    Me.grpValue.Controls.Add(Me.txtTodayDate)
    Me.grpValue.Controls.Add(Me.Label8)
    Me.grpValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpValue.Location = New System.Drawing.Point(267, 13)
    Me.grpValue.Name = "grpValue"
    Me.grpValue.Size = New System.Drawing.Size(222, 177)
    Me.grpValue.TabIndex = 10
    Me.grpValue.TabStop = False
    Me.grpValue.Text = "Current Value"
    '
    'btnReturn
    '
    Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnReturn.Location = New System.Drawing.Point(49, 145)
    Me.btnReturn.Name = "btnReturn"
    Me.btnReturn.Size = New System.Drawing.Size(132, 23)
    Me.btnReturn.TabIndex = 9
    Me.btnReturn.Text = "Compute Return"
    '
    'txtValue
    '
    Me.txtValue.BackColor = System.Drawing.Color.White
    Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtValue.Location = New System.Drawing.Point(110, 111)
    Me.txtValue.Name = "txtValue"
    Me.txtValue.ReadOnly = True
    Me.txtValue.TabIndex = 7
    Me.txtValue.TabStop = False
    Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(7, 114)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(76, 14)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Today's Value"
    '
    'txtReturn
    '
    Me.txtReturn.BackColor = System.Drawing.Color.White
    Me.txtReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtReturn.Location = New System.Drawing.Point(110, 84)
    Me.txtReturn.Name = "txtReturn"
    Me.txtReturn.ReadOnly = True
    Me.txtReturn.TabIndex = 5
    Me.txtReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(7, 87)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(73, 14)
    Me.Label6.TabIndex = 4
    Me.Label6.Text = "Yearly Return"
    '
    'txtToday
    '
    Me.txtToday.BackColor = System.Drawing.Color.White
    Me.txtToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtToday.Location = New System.Drawing.Point(110, 57)
    Me.txtToday.Name = "txtToday"
    Me.txtToday.TabIndex = 3
    Me.txtToday.TabStop = False
    Me.txtToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(7, 60)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 14)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "Today's Price"
    '
    'txtTodayDate
    '
    Me.txtTodayDate.BackColor = System.Drawing.Color.White
    Me.txtTodayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTodayDate.Location = New System.Drawing.Point(110, 30)
    Me.txtTodayDate.Name = "txtTodayDate"
    Me.txtTodayDate.ReadOnly = True
    Me.txtTodayDate.TabIndex = 1
    Me.txtTodayDate.TabStop = False
    Me.txtTodayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(7, 33)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(70, 14)
    Me.Label8.TabIndex = 0
    Me.Label8.Text = "Today's Date"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(506, 197)
    Me.Controls.Add(Me.grpValue)
    Me.Controls.Add(Me.grpStock)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Portfolio"
    Me.grpStock.ResumeLayout(False)
    Me.grpStock.PerformLayout()
    Me.grpValue.ResumeLayout(False)
    Me.grpValue.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grpStock As System.Windows.Forms.GroupBox
  Friend WithEvents txtDate As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnNext As System.Windows.Forms.Button
  Friend WithEvents btnPrevious As System.Windows.Forms.Button
  Friend WithEvents txtPaid As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtShares As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtPrice As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents grpValue As System.Windows.Forms.GroupBox
  Friend WithEvents btnReturn As System.Windows.Forms.Button
  Friend WithEvents txtValue As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtReturn As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtToday As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtTodayDate As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
