Public Class frmPong
  'Sound file strings
  Dim PaddleHit As New System.Media.SoundPlayer
  Dim Wall As New System.Media.SoundPlayer
  Dim Missed As New System.Media.SoundPlayer
  Dim Cheering As New System.Media.SoundPlayer
  Dim MyRandom As New Random
  'Ball information
  Dim BallRect As Drawing.Rectangle, BallSize As Integer = 40
  Dim BallImage As Drawing.Image
  Dim BlankBrush As Drawing.Brush
  Dim XStart As Integer, YStart As Integer
  Dim XSpeed As Integer, YSpeed As Integer
  Dim SpeedUnit As Integer
  Dim XDir As Integer, YDir As Integer
  'Paddle information
  Dim PaddleRect1 As Drawing.Rectangle, PaddleRect2 As Drawing.Rectangle
  Dim PaddleW As Integer = 5, PaddleH As Integer = 60
  Dim YStartPaddle1 As Integer, YStartPaddle2 As Integer
  Dim XPaddle1 As Integer, XPaddle2 As Integer
  Dim PaddleIncrement As Integer
  'Field information
  Dim Field As Drawing.Graphics
  'Game play info
  Dim Score1 As Integer, Score2 As Integer
  Dim Paused As Boolean
  'Number of points to win
  Const WIN As Integer = 10
  'Number of bounces before speed increases
  Const BOUNCE As Integer = 10
  Dim NumBounce As Integer

  Private Sub frmPong_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'dispose of objects
    Field.Dispose()
    BallImage.Dispose()
    BlankBrush.Dispose()
  End Sub

  Private Sub frmPong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    Field.FillRectangle(BlankBrush, PaddleRect1)
    Field.FillRectangle(BlankBrush, PaddleRect2)
    'move paddles
    Select Case e.KeyCode
      'Player 1 Motion
      Case Keys.A
        If (PaddleRect1.Top - PaddleIncrement) > 0 Then
          PaddleRect1.Y -= PaddleIncrement
        End If
      Case Keys.Z
        If (PaddleRect1.Bottom + PaddleIncrement) < pnlField.ClientSize.Height Then
          PaddleRect1.Y += PaddleIncrement
        End If
        'Player 2 Motion
      Case Keys.K
        If (PaddleRect2.Top - PaddleIncrement) > 0 Then
          PaddleRect2.Y -= PaddleIncrement
        End If
      Case Keys.M
        If (PaddleRect2.Bottom + PaddleIncrement) < pnlField.ClientSize.Height Then
          PaddleRect2.Y += PaddleIncrement
        End If
    End Select
    Field.FillRectangle(Brushes.Red, PaddleRect1)
    Field.FillRectangle(Brushes.Red, PaddleRect2)
  End Sub

  Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'Load sound files 
    PaddleHit.SoundLocation = Application.StartupPath + "\paddle.wav"
    Missed.SoundLocation = Application.StartupPath + "\missed.wav"
    Wall.SoundLocation = Application.StartupPath + "\wallhit.wav"
    Cheering.SoundLocation = Application.StartupPath + "\cheering.wav"
    PaddleHit.LoadAsync()
    Missed.LoadAsync()
    Wall.LoadAsync()
    Cheering.Load()
    'Establish graphics regions
    Field = pnlField.CreateGraphics
    BallImage = Drawing.Image.FromFile(Application.StartupPath + "\ball.wmf")
    'Initialize ball and paddle locations
    XStart = CInt(0.5 * (pnlField.ClientSize.Width - BallSize))
    YStart = CInt(0.5 * (pnlField.ClientSize.Height - BallSize))
    BallRect = New Rectangle(XStart, YStart, BallSize, BallSize)
    XPaddle1 = 5
    XPaddle2 = pnlField.ClientSize.Width - PaddleW - 5
    YStartPaddle1 = CInt(0.5 * (pnlField.ClientSize.Height - PaddleH))
    YStartPaddle2 = YStartPaddle1
    PaddleRect1 = New Rectangle(XPaddle1, YStartPaddle1, PaddleW, PaddleH)
    PaddleRect2 = New Rectangle(XPaddle2, YStartPaddle2, PaddleW, PaddleH)
    BlankBrush = New Drawing.SolidBrush(pnlField.BackColor)
    'Get ready to play
    Paused = False
    btnNew.Focus()
  End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
    'New game code
    'Reset scores
    txtScore1.Text = "0"
    txtScore2.Text = "0"
    Score1 = 0
    Score2 = 0
    'Reset ball (you might adjust xspeed and the timer interval if things
    'move too fast or too slow
    SpeedUnit = 1
    XSpeed = 4 * SpeedUnit
    YSpeed = XSpeed
    Call ResetBall()
    'Reset paddles
    Field.Clear(pnlField.BackColor)
    PaddleIncrement = 5
    NumBounce = 0
    Call ResetPaddles()
    btnNew.Enabled = False
    btnPause.Text = "&Pause"
    Paused = False
    btnPause.Enabled = True
    btnExit.Enabled = False
    timGame.Enabled = True
    Me.Focus()
  End Sub

  Private Sub btnPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPause.Click
    If Not (Paused) Then
      timGame.Enabled = False
      btnNew.Enabled = True
      btnExit.Enabled = True
      Paused = True
      btnPause.Text = "&Restart"
    Else
      timGame.Enabled = True
      btnNew.Enabled = False
      btnExit.Enabled = False
      Paused = False
      btnPause.Text = "&Pause"
    End If
    Me.Focus()
  End Sub

  Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
    'end game
    Me.Close()
  End Sub
 
  Private Sub timGame_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timGame.Tick
    'Main routine
    Dim XInc As Integer, YInc As Integer
    Dim Collision1 As Rectangle, Collision2 As Rectangle
    Dim Collision As Rectangle
    Static Previous As Rectangle
    'If paused, do nothing
    If Paused Then
      Exit Sub
    End If
    'Determine ball motion increments
    XInc = XDir * XSpeed
    YInc = YDir * YSpeed
    'Ball hits top wall
    If (BallRect.Top + YInc) < 0 Then
      YDir = -YDir
      YInc = YDir * YSpeed
      Wall.Play()
    End If
    'Ball hits bottom wall
    If (BallRect.Bottom + YInc) > pnlField.ClientSize.Height Then
      YDir = -YDir
      YInc = YDir * YSpeed
      Wall.Play()
    End If
    'Ball goes past right wall - Player 1 scores
    If BallRect.Left > pnlField.ClientSize.Width Then
      Call UpdateScore(1)
    End If
    'Ball goes past left wall - Player 2 scores
    If BallRect.Right < 0 Then
      Call UpdateScore(2)
    End If
    'Check if either paddle and ball collided
    Collision1 = Rectangle.Intersect(BallRect, PaddleRect1)
    Collision2 = Rectangle.Intersect(BallRect, PaddleRect2)
    'Move ball
    Field.FillRectangle(BlankBrush, BallRect)
    BallRect.X += XInc
    BallRect.Y += YInc
    Field.DrawImage(BallImage, BallRect)
    'If paddle hit, redraw paddle
    If Not (Collision1.IsEmpty) Then
      Field.FillRectangle(Brushes.Red, PaddleRect1)
      Collision = Collision1
    ElseIf Not (Collision2.IsEmpty) Then
      Field.FillRectangle(Brushes.Red, PaddleRect2)
      Collision = Collision2
    End If
    'If we hit a paddle, change ball direction
    If Not (Collision.IsEmpty) And Previous.IsEmpty Then
      NumBounce = NumBounce + 1
      If NumBounce = BOUNCE Then
        NumBounce = 0
        XSpeed = XSpeed + SpeedUnit
        YSpeed = YSpeed + SpeedUnit
      End If
      XDir = -XDir
      PaddleHit.Play()
    End If
    Previous = Collision
  End Sub
  Private Sub ResetPaddles()
    'Reposition paddles
    PaddleRect1.Y = YStartPaddle1
    PaddleRect2.Y = YStartPaddle2
    Field.FillRectangle(Brushes.Red, PaddleRect1)
    Field.FillRectangle(Brushes.Red, PaddleRect2)
  End Sub

  Private Sub UpdateScore(ByVal Player As Integer)
    Dim Winner As Integer
    Dim SSize As SizeF
    Winner = 0
    'Update scores and see if game over
    timGame.Enabled = False
    Missed.Play()
    Select Case Player
      Case 1
        Score1 += 1
        txtScore1.Text = Format(Score1, "#0")
        txtScore1.Refresh()
        If Score1 = WIN Then
          Winner = 1
        End If
      Case 2
        Score2 += 1
        txtScore2.Text = Format(Score2, "#0")
        txtScore2.Refresh()
        If Score2 = WIN Then
          Winner = 2
        End If
    End Select
    If Winner = 0 Then
      Call ResetBall()
      timGame.Enabled = True
    Else
      btnPause.Enabled = False
      Cheering.Play()
      SSize = New SizeF()
      SSize = Field.MeasureString("Game Over", Me.Font)
      Field.DrawString("Game Over", Me.Font, Brushes.Red, CInt(0.5 * (pnlField.ClientSize.Width - SSize.Width)), CInt(0.5 * (pnlField.ClientSize.Height - SSize.Height)))
      btnNew.Enabled = True
      btnExit.Enabled = True
      btnNew.Focus()
    End If
  End Sub

  Private Sub ResetBall()
    'Set random directions (1 or -1)
    XDir = 2 * MyRandom.Next(2) - 1
    YDir = 2 * MyRandom.Next(2) - 1
    BallRect.X = XStart
    BallRect.Y = YStart
  End Sub


End Class
