Public Class mini_inscription
    Dim commande(3) As String

    Private Sub Cmd_Click(sender As Object, e As EventArgs) Handles cmd.Click
        rendu.Visible = True

        commande(0) = nom.Text
        commande(1) = prenom.Text
        commande(2) = desg.Text
        commande(3) = quartier.Text
        rendu.Rows.Add(commande(0), commande(1), commande(2), commande(3))




    End Sub

    Private Sub Mini_inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rendu.Visible = False
    End Sub

    Private Sub rendu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles rendu.CellContentClick

    End Sub
End Class