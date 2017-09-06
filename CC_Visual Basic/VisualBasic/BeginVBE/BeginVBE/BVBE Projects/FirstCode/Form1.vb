Public Class Form1

    Dim deposit As Integer
    Dim weeks As Integer
    Dim savings As Integer

    Private Sub txtDep_TextChanged(sender As Object, e As EventArgs) Handles txtDep.TextChanged

    End Sub

    Private Sub txtWks_TextChanged(sender As Object, e As EventArgs) Handles txtWks.TextChanged

    End Sub

    Private Sub txtSav_TextChanged(sender As Object, e As EventArgs) Handles txtSav.TextChanged

    End Sub

    Private Sub btnComp_Click(sender As Object, e As EventArgs) Handles btnComp.Click
        deposit = Val(txtDep.Text)
        weeks = Val(txtWks.Text)
        savings = deposit * weeks
        txtSav.Text = "$" & Str(savings)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
