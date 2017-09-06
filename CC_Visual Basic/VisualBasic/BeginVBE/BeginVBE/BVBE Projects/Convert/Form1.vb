Public Class Form1
  Dim Units(7) As String
  Dim NumDecimals As Integer
  Dim Conversions(7, 7) As Double
  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim I As Integer
    'Establish conversion factors - stored in two dimensional array
    'or table - the first number is the table row, the second number
    'the table column
    Conversions(1, 1) = 1.0# 'in to in
    Conversions(1, 2) = 1 / 12 'in to ft
    Conversions(1, 3) = 1 / 36 'in to yd
    Conversions(1, 4) = (1 / 12) / 5280 'in to mi
    Conversions(1, 5) = 2.54 'in to cm
    Conversions(1, 6) = 2.54 / 100 'in to m
    Conversions(1, 7) = 2.54 / 100000 'in to km
    For I = 1 To 7
      Conversions(2, I) = 12 * Conversions(1, I)
      Conversions(3, I) = 36 * Conversions(1, I)
      Conversions(4, I) = 5280 * (12 * Conversions(1, I))
      Conversions(5, I) = Conversions(1, I) / 2.54
      Conversions(6, I) = 100 * Conversions(1, I) / 2.54
      Conversions(7, I) = 100000 * (Conversions(1, I) / 2.54)
    Next I
    'Initialize variables
    Units(1) = "inches (in)"
    Units(2) = "feet (ft)"
    Units(3) = "yards (yd)"
    Units(4) = "miles (mi)"
    Units(5) = "centimeters (cm)"
    Units(6) = "meters (m)"
    Units(7) = "kilometers (km)"
    For I = 0 To 6
      dudFromUnit.Items.Add(Units(I + 1))
      dudToUnit.Items.Add(Units(I + 1))
    Next I
    dudFromUnit.SelectedIndex = 0
    dudToUnit.SelectedIndex = 0
    NumDecimals = 0
    'Put cursor in text box
    txtFromValue.Focus()
  End Sub
  Private Sub txtFromValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFromValue.KeyPress
    'Numbers and decimal point only
    If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back Then
      e.Handled = False
    Else
      e.Handled = True
    End If
  End Sub
  Private Sub txtFromValue_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFromValue.TextChanged
    Call UpdateDisplay()
  End Sub
  Private Sub UpdateDisplay()
    Dim V As Double
    'Do unit conversion
    V = Conversions(dudFromUnit.SelectedIndex + 1, dudToUnit.SelectedIndex + 1) * Val(txtFromValue.Text)
    Select Case NumDecimals
      Case 0
        txtToValue.Text = Format(V, "0")
      Case 1
        txtToValue.Text = Format(V, "0.0")
      Case 2
        txtToValue.Text = Format(V, "0.00")
      Case 3
        txtToValue.Text = Format(V, "0.000")
      Case 4
        txtToValue.Text = Format(V, "0.0000")
      Case 5
        txtToValue.Text = Format(V, "0.00000")
    End Select
    txtFromValue.Focus()
  End Sub
  Private Sub dudFromUnit_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dudFromUnit.SelectedItemChanged
    Call UpdateDisplay()
  End Sub
  Private Sub dudToUnit_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dudToUnit.SelectedItemChanged
    Call UpdateDisplay()
  End Sub
  Private Sub rdoDec0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDec0.CheckedChanged
    NumDecimals = 0
    Call UpdateDisplay()
  End Sub

  Private Sub rdoDec1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDec1.CheckedChanged
    NumDecimals = 1
    Call UpdateDisplay()
  End Sub

  Private Sub rdoDec2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDec2.CheckedChanged
    NumDecimals = 2
    Call UpdateDisplay()
  End Sub

  Private Sub rdoDec3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDec3.CheckedChanged
    NumDecimals = 3
    Call UpdateDisplay()
  End Sub

  Private Sub rdoDec4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDec4.CheckedChanged
    NumDecimals = 4
    Call UpdateDisplay()
  End Sub


  Private Sub rdoDec5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDec5.CheckedChanged
    NumDecimals = 5
    Call UpdateDisplay()
  End Sub

End Class
