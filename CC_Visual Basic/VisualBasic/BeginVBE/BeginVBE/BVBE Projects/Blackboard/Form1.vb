Public Class Form1
  Dim MousePress As Boolean
  Dim XLast As Integer, YLast As Integer
  Dim MyGraphics As Graphics
  Dim MyPen As Pen

  Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    MyGraphics.Dispose()
    MyPen.Dispose()
  End Sub

  Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'Create graphics and pen objects
    MyGraphics = pnlBlackboard.CreateGraphics
    MyPen = New Pen(Color.Gray, 1)
    'Initialize the eight radio button colors 
    rdoGray.BackColor = Color.Gray
    rdoBlue.BackColor = Color.Blue
    rdoGreen.BackColor = Color.LightGreen
    rdoCyan.BackColor = Color.Cyan
    rdoRed.BackColor = Color.Red
    rdoMagenta.BackColor = Color.Magenta
    rdoYellow.BackColor = Color.Yellow
    rdoWhite.BackColor = Color.White
    'Set initial color
    rdoGray.Checked = True
    MousePress = False
  End Sub

  Private Sub rdoGray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoGray.CheckedChanged
    'Gray 
    MyPen.Color = rdoGray.BackColor
  End Sub

  Private Sub rdoBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBlue.CheckedChanged
    'Blue
    MyPen.Color = rdoBlue.BackColor
  End Sub

  Private Sub rdoGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoGreen.CheckedChanged
    'Green
    MyPen.Color = rdoGreen.BackColor
  End Sub

  Private Sub rdoCyan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCyan.CheckedChanged
    'Cyan
    MyPen.Color = rdoCyan.BackColor
  End Sub

  Private Sub rdoRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRed.CheckedChanged
    'Red 
    MyPen.Color = rdoRed.BackColor
  End Sub

  Private Sub rdoMagenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoMagenta.CheckedChanged
    'Magenta 
    MyPen.Color = rdoMagenta.BackColor
  End Sub

  Private Sub rdoYellow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoYellow.CheckedChanged
    'Yellow
    MyPen.Color = rdoYellow.BackColor
  End Sub

  Private Sub rdoWhite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWhite.CheckedChanged
    'White
    MyPen.Color = rdoWhite.BackColor
  End Sub

  Private Sub btnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErase.Click
    'Clear the blackboard
    MyGraphics.Clear(pnlBlackboard.BackColor)
  End Sub

  Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    Me.Close()
  End Sub

  Private Sub pnlBlackboard_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBlackboard.MouseDown
    'Start drawing if left click
    If e.Button = MouseButtons.Left Then
      MousePress = True
      XLast = e.X
      YLast = e.Y
    End If
  End Sub

  Private Sub pnlBlackboard_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBlackboard.MouseMove
    'Draw a line if drawing
    If MousePress Then
      MyGraphics.DrawLine(MyPen, XLast, YLast, e.X, e.Y)
      XLast = e.X
      YLast = e.Y
    End If
  End Sub

    Private Sub pnlBlackboard_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlBlackboard.MouseUp
        'Finish line
        If e.Button = MouseButtons.Left Then
            MyGraphics.DrawLine(MyPen, XLast, YLast, e.X, e.Y)
            MousePress = False
        End If
    End Sub
End Class
