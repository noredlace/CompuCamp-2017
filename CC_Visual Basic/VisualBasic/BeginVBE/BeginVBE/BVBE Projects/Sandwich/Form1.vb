Public Class Form1
  Dim BreadChoice As Integer
  Dim CheeseChoice As Integer
  Dim NumberMeats As Integer
    Dim NumberCondiments As Integer
    Dim Cost As Single


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Initialize bread and cheese choices
    BreadChoice = 1
        CheeseChoice = 0
    End Sub

  Private Sub rdoWhite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWhite.CheckedChanged
    'White bread selected
    BreadChoice = 1
  End Sub

  Private Sub rdoWheat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWheat.CheckedChanged
    'Wheat bread selected
    BreadChoice = 2
  End Sub

  Private Sub rdoRye_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRye.CheckedChanged
    'Rye bread selected
    BreadChoice = 3
  End Sub

  Private Sub rdoNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNone.CheckedChanged
    'No cheese selected
    CheeseChoice = 0
  End Sub

  Private Sub rdoAmerican_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoAmerican.CheckedChanged
    'American cheese selected
    CheeseChoice = 1
  End Sub

  Private Sub rdoSwiss_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSwiss.CheckedChanged
    'Swiss cheese selected
    CheeseChoice = 2
  End Sub

  Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
    'Start Text with bread type
    txtOrder.Text = "Sandwich Order:" & ControlChars.CrLf
    Select Case BreadChoice
      Case 1
        txtOrder.Text = txtOrder.Text & "White Bread" & ControlChars.CrLf
      Case 2
        txtOrder.Text = txtOrder.Text & "Wheat Bread" & ControlChars.CrLf
      Case 3
        txtOrder.Text = txtOrder.Text & "Rye Bread" & ControlChars.CrLf
    End Select
    'Add and count meats
    NumberMeats = 0
    If chkRoastBeef.Checked Then
      NumberMeats = NumberMeats + 1
      txtOrder.Text = txtOrder.Text & "Roast Beef" & ControlChars.CrLf
    End If
    If chkHam.Checked Then
      NumberMeats = NumberMeats + 1
      txtOrder.Text = txtOrder.Text & "Ham" & ControlChars.CrLf
    End If
    If chkTurkey.Checked Then
      NumberMeats = NumberMeats + 1
      txtOrder.Text = txtOrder.Text & "Turkey" & ControlChars.CrLf
    End If
    If chkPastrami.Checked Then
      NumberMeats = NumberMeats + 1
      txtOrder.Text = txtOrder.Text & "Pastrami" & ControlChars.CrLf
    End If
    If chkSalami.Checked Then
      NumberMeats = NumberMeats + 1
      txtOrder.Text = txtOrder.Text & "Salami" & ControlChars.CrLf
    End If
    'If no meats picked, say so
    If NumberMeats = 0 Then
      txtOrder.Text = txtOrder.Text & "No Meat" & ControlChars.CrLf
    End If
    'Add cheese type
    Select Case CheeseChoice
      Case 0
        txtOrder.Text = txtOrder.Text & "No Cheese" & ControlChars.CrLf
      Case 1
        txtOrder.Text = txtOrder.Text & "American Cheese" & ControlChars.CrLf
      Case 2
        txtOrder.Text = txtOrder.Text & "Swiss Cheese" & ControlChars.CrLf
    End Select
    'Finally, add  and count condiments
    NumberCondiments = 0
    If chkMustard.Checked Then
      NumberCondiments = NumberCondiments + 1
      txtOrder.Text = txtOrder.Text & "Mustard" & ControlChars.CrLf
    End If
    If chkMayo.Checked Then
      NumberCondiments = NumberCondiments + 1
      txtOrder.Text = txtOrder.Text & "Mayonnaise" & ControlChars.CrLf
    End If
    If chkLettuce.Checked Then
      NumberCondiments = NumberCondiments + 1
      txtOrder.Text = txtOrder.Text & "Lettuce" & ControlChars.CrLf
    End If
    If chkTomato.Checked Then
      NumberCondiments = NumberCondiments + 1
      txtOrder.Text = txtOrder.Text & "Tomato" & ControlChars.CrLf
    End If
    If chkOnions.Checked Then
      NumberCondiments = NumberCondiments + 1
      txtOrder.Text = txtOrder.Text & "Onions" & ControlChars.CrLf
    End If
    If chkPickles.Checked Then
      NumberCondiments = NumberCondiments + 1
      txtOrder.Text = txtOrder.Text & "Pickles" & ControlChars.CrLf
    End If
        'If no condiments picked, say so
        If NumberCondiments = 0 Then
            txtOrder.Text = txtOrder.Text & "No Condiments" & ControlChars.CrLf
        End If
        Cost = 3.95
        If NumberMeats < 2 Then
            Cost = Cost + Cost * 0.08
            txtCost.Text = txtCost.Text & Format(Cost, "$0.00")
        Else
            Cost = Cost + (NumberMeats - 1) * 0.75
            Cost = Cost + Cost * 0.08
            txtCost.Text = txtCost.Text & Format(Cost, "$0.00")
        End If
    End Sub

  Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
    'Set bread to white
    BreadChoice = 1
    rdoWhite.Checked = True
    'Clear all meat choices
    chkRoastBeef.Checked = False
    chkHam.Checked = False
    chkTurkey.Checked = False
    chkPastrami.Checked = False
    chkSalami.Checked = False
    'Set cheese to none
    CheeseChoice = 0
    rdoNone.Checked = True
    'Clear all condiment choices
    chkMustard.Checked = False
    chkMayo.Checked = False
    chkLettuce.Checked = False
    chkTomato.Checked = False
    chkOnions.Checked = False
    chkPickles.Checked = False
        'Clear text box
        txtOrder.Text = ""
        txtCost.Text = ""
    End Sub

    Private Sub txtOrder_TextChanged(sender As Object, e As EventArgs) Handles txtOrder.TextChanged

    End Sub
End Class
