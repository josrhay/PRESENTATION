Public Class gestion_des_etudiants
    Dim listeetudiant(10) As Tetudiant
    Dim i As Integer = 1
    Dim t As String = " "
    Dim enregistrement(5)
    Dim ind As Integer
    Private Sub gestion_des_etudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conteneur.Visible = False
        i = 1
    End Sub

    Private Sub nouveau_Click(sender As Object, e As EventArgs) Handles nouveau.Click
        nouv()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        conteneur.Visible = True
        enregistrement(0) = matricule.Text
        enregistrement(1) = nom.Text
        enregistrement(2) = prenon.Text
        enregistrement(3) = annee.Text
        enregistrement(4) = spe.Text
        enregistrement(5) = sexe.Text
        conteneur.Rows.Add(enregistrement(0), enregistrement(1), enregistrement(2), enregistrement(3), enregistrement(4), enregistrement(5))

        'autre facon de de socker les elements dans le tablea
    End Sub

    Private Sub delate_Click(sender As Object, e As EventArgs) Handles delate.Click

        Dim titre As String = "Question"
        Dim msg As String = "ETES VOUS SUR DE VOULOIR SUPPRIMER ? "
        Dim result = MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            nom.Clear()
            prenon.Clear()
            annee.Clear()
            spe.Text = t
            sexe.Text = t
            matricule.Clear()
            matricule.Select()

        End If

        listeetudiant(i).matricule = matricule.Text
        listeetudiant(i).nom = nom.Text
        listeetudiant(i).prenom = prenon.Text
        listeetudiant(i).annee = annee.Text
        listeetudiant(i).specialite = spe.Text
        listeetudiant(i).sexe = sexe.Text

    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        Me.conteneur.DataSource = Nothing
    End Sub

    Private Sub precedant_Click(sender As Object, e As EventArgs) Handles precedant.Click
        If ind = 1 Then
            MsgBox("plus de case avant celle-ci")
        Else
            ind = ind - 1
            afficher()
        End If
    End Sub
    Sub nouv()
        nom.Clear()
        prenon.Clear()
        annee.Clear()
        spe.Text = t
        sexe.Text = t
        matricule.Clear()
        matricule.Select()
    End Sub
    Sub afficher()
        nom.Text = listeetudiant(ind).nom
        matricule.Text = listeetudiant(ind).matricule
        prenon.Text = listeetudiant(ind).prenom
        annee.Text = listeetudiant(ind).annee
        sexe.Text = listeetudiant(ind).sexe
        spe.Text = listeetudiant(ind).specialite
    End Sub

    Private Sub debut_Click(sender As Object, e As EventArgs) Handles debut.Click
        ind = 1
        afficher()
    End Sub

    Private Sub suivant_Click(sender As Object, e As EventArgs) Handles suivant.Click
        If ind = i - 1 Then
            MsgBox("plus de case apres celle-ci !")
        Else
            ind = ind + 1
            afficher()
        End If
    End Sub

    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click

    End Sub
End Class