Public Class Form1
  Dim BallY As Integer, BallDir As Integer

  Private Sub chkBurger_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBurger.CheckedChanged
    'Make burger appear/disappear
    If picBurger.Visible Then
      picBurger.Visible = False
    Else
      picBurger.Visible = True
    End If
  End Sub

  Private Sub chkHotDog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHotDog.CheckedChanged
    'Make hot dog appear/disappear
    If picHotDog.Visible Then
      picHotDog.Visible = False
    Else
      picHotDog.Visible = True
    End If
  End Sub

  Private Sub chkFries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFries.CheckedChanged
    'Make fries appear/disappear
    If picFries.Visible Then
      picFries.Visible = False
    Else
      picFries.Visible = True
    End If
  End Sub

  Private Sub chkSoup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSoup.CheckedChanged
    'Make soup appear/disappear
    If picSoup.Visible Then
            picSoup.Visible = True
        Else
      picSoup.Visible = True
    End If
  End Sub

  Private Sub chkPopcorn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPopcorn.CheckedChanged
    'Make popcorn appear/disappear
    If picPopcorn.Visible Then
      picPopcorn.Visible = False
    Else
      picPopcorn.Visible = True
    End If
  End Sub

  Private Sub chkPizza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPizza.CheckedChanged
    'Make pizza appear/disappear
    If picPizza.Visible Then
      picPizza.Visible = False
    Else
      picPizza.Visible = True
    End If
  End Sub

  Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'Initialize form color and ball position
    rdoBlue.PerformClick()
    BallY = 0
    picMyBall.Top = 0
    BallDir = 1
    'Draw ball
    Form1_Paint(Nothing, Nothing)
  End Sub

  Private Sub rdoBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBlue.CheckedChanged
    'Change form color to blue
    Me.BackColor = Color.Blue
  End Sub

  Private Sub rdoRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRed.CheckedChanged
    'Change form color to red
    Me.BackColor = Color.Red
  End Sub

  Private Sub rdoGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoGreen.CheckedChanged
    'Change form color to green
    Me.BackColor = Color.Green
  End Sub

  Private Sub rdoBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBlack.CheckedChanged
    'Change form color to black
    Me.BackColor = Color.Black
  End Sub

  Private Sub btnBall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBall.Click
    'Start/stop timer 
    If timBall.Enabled = True Then
      timBall.Enabled = False
      btnBall.Text = "Start"
    Else
      timBall.Enabled = True
      btnBall.Text = "Stop"
    End If
  End Sub

  Private Sub timBall_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timBall.Tick
    'Position ball
    'compute ball position
    BallY = BallY + BallDir * pnlBall.ClientSize.Height / 50
    'Check for bounce
    If BallY < 0 Then
      Beep()
      BallY = 0
      BallDir = 1
    ElseIf BallY > pnlBall.ClientSize.Height - picMyBall.Height Then
      Beep()
      BallY = pnlBall.ClientSize.Height - picMyBall.Height
      BallDir = -1
    End If
    'Draw ball
    Form1_Paint(Nothing, Nothing)
  End Sub

  Private Sub btnBeep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeep.Click
    'Make beeping sound
    Beep()
  End Sub

  Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim MyGraphics As Drawing.Graphics
    Dim RectDest As Drawing.Rectangle
    MyGraphics = pnlBall.CreateGraphics
    RectDest = New Rectangle(0.5 * (pnlBall.ClientSize.Width - picMyBall.Width), BallY, picMyBall.Width, picMyBall.Height)
    MyGraphics.Clear(pnlBall.BackColor)
    MyGraphics.DrawImage(picMyBall.Image, RectDest)
    MyGraphics.Dispose()
  End Sub
End Class
