Public Class Form1
  Dim StartTime As Date ' Time when Start clicked

  Private Sub btnStartStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartStop.Click
        'Starting timer?

        If btnStartStop.Text = "Start" Then
      'Reset Text on Start/Stop button
      btnStartStop.Text = "Stop"
      'Start timer and get starting time
      timDisplay.Enabled = True
      StartTime = Now
    Else
      'Stop timer
      timDisplay.Enabled = False
      'Disable Start/Stop button, enable Reset button
      btnStartStop.Enabled = False
      btnReset.Enabled = True
    End If
  End Sub

  Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
    'Reset display to zero
    txtTime.Text = "00:00:00"
    'Reset button Text and enable Start, disable Reset
    btnStartStop.Text = "Start"
    btnStartStop.Enabled = True
    btnReset.Enabled = False
  End Sub


  Private Sub timDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timDisplay.Tick
    Dim Hours As Integer, Minutes As Integer, Seconds As Integer
    Dim ElapsedTime As Integer
    'Determine elapsed time since Start was clicked
    ElapsedTime = DateDiff(DateInterval.Second, StartTime, Now)
    'Break elapsed time down into hours, minutes, and seconds
    Hours = Int(ElapsedTime / 3600)
    Minutes = Int((ElapsedTime - Hours * 3600) / 60)
    Seconds = Int(ElapsedTime - Hours * 3600 - Minutes * 60)
    'Display time in label box
    txtTime.Text = Format(Hours, "00") & ":" & Format(Minutes, "00") & ":" & Format(Seconds, "00")
  End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
