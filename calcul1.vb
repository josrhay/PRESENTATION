Public Class calcul1
    Private Sub a_TextChanged(sender As Object, e As EventArgs) Handles a.TextChanged


    End Sub
    Private Sub b_TextChanged(sender As Object, e As EventArgs) Handles b.TextChanged

    End Sub
    Private Sub valider_Click(sender As Object, e As EventArgs) Handles valider.Click

        Dim nbr1 As Integer
        Dim age As Integer
        'modifier
        nbr1 = Integer.Parse(a.Text)


        '  b.Text = nbr1.ToString
        age = 2023 - nbr1

        b.Text = "Daphne a" + " " + age.ToString + " " + "ans"












        ' a.Text = "variable a"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class