Imports System.Reflection.Metadata.Ecma335

Public Class CALCULATRICE2
    'declaration des variables globales

    Dim nombre1 As Double
    Dim nombre2 As Double
    Dim OPERATEUR As String
    Dim OPERATEUR1 As String
    Dim OPERATEUR2 As String
    Dim OPERATEUR3 As String
    Dim cov As Integer = 0
    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click

        Dim nbre As Integer = 0 'declaration de la variable locale

        'on stocke la variable nobre et le contenu de la zone de texte 
        'dans la zone de texte pour eviter qu'au prochain click 
        'la valeur du click precedent ne soit effacer
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub un_Click(sender As Object, e As EventArgs) Handles un.Click
        Dim nbre As Integer = 1
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub deux_Click(sender As Object, e As EventArgs) Handles deux.Click
        Dim nbre As Integer = 2
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub trois_Click(sender As Object, e As EventArgs) Handles trois.Click
        Dim nbre As Integer = 3
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub quatre_Click(sender As Object, e As EventArgs) Handles quatre.Click
        Dim nbre As Integer = 4
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub cinq_Click(sender As Object, e As EventArgs) Handles cinq.Click
        Dim nbre As Integer = 5
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        Dim nbre As Integer = 6
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub sept_Click(sender As Object, e As EventArgs) Handles sept.Click
        Dim nbre As Integer = 7
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub huit_Click(sender As Object, e As EventArgs) Handles huit.Click
        Dim nbre As Integer = 8
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub neuf_Click(sender As Object, e As EventArgs) Handles neuf.Click
        Dim nbre As Integer = 9
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Dim plu As String = "" 'pour afficher le virde lors du click sur le button  
        OPERATEUR = "+" 'pour l'utiliser lors de la contion
        nombre1 = Double.Parse(result.Text) 'conversion et recuperation du premier nbre entrez
        result.Text = plu.ToString 'afficher le vire


    End Sub

    Private Sub moins_Click(sender As Object, e As EventArgs) Handles moins.Click
        nombre1 = Double.Parse(result.Text)
        Dim moi As String = ""
        OPERATEUR1 = "-"
        result.Text = moi.ToString
    End Sub

    Private Sub fois_Click(sender As Object, e As EventArgs) Handles fois.Click
        Dim foi As String = ""
        OPERATEUR2 = "x"
        nombre1 = Double.Parse(result.Text)
        result.Text = foi.ToString
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        Dim foi As String = ""
        OPERATEUR3 = "/"
        nombre1 = Double.Parse(result.Text)
        result.Text = foi.ToString
    End Sub

    Private Sub egale_Click(sender As Object, e As EventArgs) Handles egale.Click
        If OPERATEUR = "+" Then
            addition(nombre1, nombre2) 'appel de la fonction addition 
        ElseIf OPERATEUR1 = "-" Then
            soustration(nombre1, nombre2) 'appel de la fonction soustration
        ElseIf OPERATEUR2 = "x" Then
            multiplication(nombre1, nombre2) 'appel de la fonction multiplication
        ElseIf OPERATEUR3 = "/" Then
            ladivision(nombre1, nombre2) 'appel de kla fonction ladivision
        End If
    End Sub
    Function addition(ByVal nombre1 As Integer, ByVal nombre2 As Integer) As Integer

        OPERATEUR = "+"
        Dim f As Double
        nombre2 = Double.Parse(result.Text)
        f = nombre1 + nombre2
        result.Text = f.ToString 'stocker le resultat de l'addition
        Return f
    End Function
    Function soustration(ByVal nombre1 As Integer, ByVal nombre2 As Integer) As Integer

        OPERATEUR1 = "-"
        Dim f As Double
        nombre2 = Double.Parse(result.Text)
        f = nombre1 - nombre2
        result.Text = f.ToString
        Return f
    End Function
    ''' <summary>
    ''' ma function permet de soustraire deux chiffres entres par 
    ''' l'utiisateur a partir des buttons
    ''' </summary>
    ''' <param name="nombre1">premiere valeur a soustraire</param>
    ''' <param name="nombre2">deuxieme valeur a soustraire</param>
    ''' <returns></returns>
    Function multiplication(ByVal nombre1 As Integer, ByVal nombre2 As Integer) As Integer

        OPERATEUR2 = "x"
        Dim f As Double
        nombre2 = Double.Parse(result.Text)
        f = nombre1 * nombre2
        result.Text = f.ToString
        Return f
    End Function

    Function ladivision(ByVal nombre1 As Integer, ByVal nombre2 As Integer) As Integer

        OPERATEUR3 = "/"
        Dim f As Double
        nombre2 = Double.Parse(result.Text)
        f = nombre1 / nombre2
        result.Text = f.ToString
        Return f
    End Function

    Private Sub effacer_Click(sender As Object, e As EventArgs) Handles effacer.Click
        result.Clear() 'lors du click sur le button click afficher la variable 

    End Sub

    Private Sub point_Click(sender As Object, e As EventArgs) Handles point.Click

    End Sub
End Class