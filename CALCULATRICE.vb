Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CALCULATRICE


    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim total As Double
        'modifier
        nbr1 = Integer.Parse(a.Text) 'cette ligne permet de convertir le contenu de la zone de texte en 
        'nombre et le stocke en suite dans la variable nbre1
        nbr2 = Integer.Parse(b.Text)
        total = nbr1 + nbr2
        'Cette ligne permet d'ifficher l'operation nbre1 + nbre2 saisir 
        'par l'utilisateur et le stocker dans r
        r.Text = nbr1 & "+" & nbr2 & "=" & total.ToString


    End Sub

    Private Sub moins_Click(sender As Object, e As EventArgs) Handles moins.Click
        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim total As Integer
        'modifier
        nbr1 = Integer.Parse(a.Text)
        nbr2 = Integer.Parse(b.Text)
        total = nbr1 - nbr2
        r.Text = nbr1 & "-" & nbr2 & "=" & total.ToString

    End Sub

    Private Sub fois_Click(sender As Object, e As EventArgs) Handles fois.Click
        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim total As Integer
        'modifier
        nbr1 = Integer.Parse(a.Text)
        nbr2 = Integer.Parse(b.Text)
        total = nbr1 * nbr2
        r.Text = nbr1 & "x" & nbr2 & "=" & total.ToString
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim total As Integer
        'modifier
        nbr1 = Integer.Parse(a.Text)
        nbr2 = Integer.Parse(b.Text)
        total = nbr1 / nbr2
        r.Text = nbr1 & "/" & nbr2 & "=" & total.ToString
    End Sub


End Class