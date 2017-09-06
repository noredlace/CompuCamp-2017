Public Class Form1
  Dim BallSize As Integer
  Dim BallX(5) As Integer
  Dim BallY(5) As Integer
  Dim BallSpeed(5) As Integer
  Dim ArrowSize As Integer
  Dim ArrowX As Integer
  Dim MyGraphics As Graphics
  Dim BlankBrush As Brush
  Dim MyRandom As New Random

  Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    MyGraphics.Dispose()
    BlankBrush.Dispose()
  End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Erase arrow at old location
        MyGraphics.FillRectangle(BlankBrush, ArrowX, pnlBeachBalls.Height - ArrowSize, ArrowSize, ArrowSize)
        'Check for F key (left) and J key (right) and compute arrow position
        If e.KeyCode = Keys.Left Then
            ArrowX = ArrowX - 10
        ElseIf e.KeyCode = Keys.Right Then
            ArrowX = ArrowX + 10
        End If
        'Position arrow
        MyGraphics.DrawImage(picArrow.Image, ArrowX, pnlBeachBalls.Height - ArrowSize, ArrowSize, ArrowSize)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim X As Integer
    Dim I As Integer
    'Have the balls spread across the panel with 20 pixels borders
    BallSize = Int((pnlBeachBalls.Width - 6 * 20) / 5)
    X = 10
    For I = 1 To 5
      BallX(I) = X
      X = X + BallSize + 20
    Next
    'Make arrow one-half the ball size
    ArrowSize = Int(BallSize / 2)
    MyGraphics = pnlBeachBalls.CreateGraphics
    BlankBrush = New SolidBrush(pnlBeachBalls.BackColor)
    'Give form focus
    Me.Focus()
  End Sub

  Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    'Stop the program
    Me.Close()
  End Sub

  Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
    Dim I As Integer
    If btnStart.Text = "Start" Then
      'New Game
      MyGraphics.Clear(pnlBeachBalls.BackColor)
      txtOver.Visible = False
      btnStart.Text = "Stop"
      btnExit.Enabled = False
      txtScore.Text = "0"
      'set each ball off top of panel and give new speed
      For I = 1 To 5
        BallY(I) = -BallSize
        BallSpeed(I) = Int(Rnd() * 4) + 3
      Next I
      'Set arrow near center
      ArrowX = Int(pnlBeachBalls.Width / 2)
      MyGraphics.DrawImage(picArrow.Image, ArrowX, pnlBeachBalls.Height - ArrowSize, ArrowSize, ArrowSize)
      'Give form focus so it can accept KeyDown events
      Me.Focus()
    Else
      'Game stopped
      txtOver.Visible = True
      btnStart.Text = "Start"
      btnExit.Enabled = True
    End If
    'Toggle timers
    timBalls.Enabled = Not (timBalls.Enabled)
    timGame.Enabled = Not (timGame.Enabled)
  End Sub

  Private Sub timGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timGame.Tick
    '60 seconds have elapsed - stop game
    timBalls.Enabled = False
    timGame.Enabled = False
    txtOver.Visible = True
    btnStart.Text = "Start"
    btnExit.Enabled = True
  End Sub

  Private Sub timBalls_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timBalls.Tick
    Dim I As Integer
        For I = 1 To 5
            'erase ball
            MyGraphics.FillRectangle(BlankBrush, BallX(I), BallY(I), BallSize, BallSize)
            'move ball
            BallY(I) = BallY(I) + BallSpeed(I)
            'check if ball has popped 
            If (BallY(I) + BallSize) > (pnlBeachBalls.Height - ArrowSize) Then
                If BallX(I) < ArrowX Then
                    If (BallX(I) + BallSize) > (ArrowX + ArrowSize) Then
                        'Ball has popped
                        'Increase score - move back to top
                        Beep()
                        txtScore.Text = Str(Val(txtScore.Text) + 1)
                        BallY(I) = -BallSize
                        BallSpeed(I) = MyRandom.Next(4) + 3
                    End If
                End If
            End If
            'check for moving off bottom
            If (BallY(I) + BallSize) > pnlBeachBalls.Height Then
                'Ball reaches bottom without popping
                'Move back to top with new speed
                BallY(I) = -BallSize
                BallSpeed(I) = MyRandom.Next(4) + 3
            End If
            'redraw ball at new location, redraw arrow too
            MyGraphics.DrawImage(picBall.Image, BallX(I), BallY(I), BallSize, BallSize)
        Next I
        Me.Focus()
    End Sub
End Class
