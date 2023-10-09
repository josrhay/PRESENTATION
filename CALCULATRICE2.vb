Imports System.Globalization
Imports System.Reflection.Metadata.Ecma335

Public Class CALCULATRICE2
    'declaration des variables globales
    Dim val1 As Double
    Dim val2 As Double
    Dim val3 As Double
    Dim r As Double
    Dim x1 As Double
    Dim x2 As Double
    Dim nombre1 As Double
    Dim nombre2 As Double
    Dim OPERATEUR As String
    Dim OPERATEUR1 As String
    Dim OPERATEUR2 As String
    Dim OPERATEUR3 As String
    Dim OPERATEUR4 As String
    Dim OPERATEUR5 As String
    Dim OPERATEUR6 As String
    Dim cov As Integer = 0
    Private Sub Zero_Click(sender As Object, e As EventArgs) Handles zero.Click

        Dim nbre As String = "0" 'declaration de la variable locale

        'on stocke la variable nobre et le contenu de la zone de texte 
        'dans la zone de texte pour eviter qu'au prochain click 
        'la valeur du click precedent ne soit effacer
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Un_Click(sender As Object, e As EventArgs) Handles un.Click
        Dim nbre As String = "1"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Deux_Click(sender As Object, e As EventArgs) Handles deux.Click
        Dim nbre As String = "2"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Trois_Click(sender As Object, e As EventArgs) Handles trois.Click
        Dim nbre As String = "3"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Quatre_Click(sender As Object, e As EventArgs) Handles quatre.Click
        Dim nbre As String = "4"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Cinq_Click(sender As Object, e As EventArgs) Handles cinq.Click
        Dim nbre As String = "5"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Six_Click(sender As Object, e As EventArgs) Handles six.Click
        Dim nbre As String = "6"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Sept_Click(sender As Object, e As EventArgs) Handles sept.Click
        Dim nbre As String = "7"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Huit_Click(sender As Object, e As EventArgs) Handles huit.Click
        Dim nbre As String = "8"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Neuf_Click(sender As Object, e As EventArgs) Handles neuf.Click
        Dim nbre As String = "9"
        result.Text = result.Text & nbre.ToString
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Dim plu As String = "" 'pour afficher le virde lors du click sur le button  
        OPERATEUR = "+" 'pour l 'utiliser lors de la contion
        nombre1 = Val(result.Text) 'conversion et recuperation du premier nbre entrez
        result.Text = plu.ToString 'afficher le vire


    End Sub

    Private Sub Moins_Click(sender As Object, e As EventArgs) Handles moins.Click
        nombre1 = Val(result.Text)
        Dim moi As String = ""
        OPERATEUR1 = "-"
        result.Text = moi.ToString
    End Sub

    Private Sub Fois_Click(sender As Object, e As EventArgs) Handles fois.Click
        Dim foi As String = ""
        OPERATEUR2 = "x"
        nombre1 = Val(result.Text)
        result.Text = foi.ToString
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles division.Click
        Dim foi As String = ""
        OPERATEUR3 = "/"
        nombre1 = Val(result.Text)
        result.Text = foi.ToString
    End Sub

    Private Sub Egale_Click(sender As Object, e As EventArgs) Handles egale.Click
        If OPERATEUR = "+" Then
            addition(nombre1, nombre2) 'appel de la fonction addition 
        ElseIf OPERATEUR1 = "-" Then
            soustration(nombre1, nombre2) 'appel de la fonction soustration
        ElseIf OPERATEUR2 = "x" Then
            multiplication(nombre1, nombre2) 'appel de la fonction multiplication
        ElseIf OPERATEUR3 = "/" Then
            ladivision(nombre1, nombre2) 'appel de kla fonction ladivision
        ElseIf OPERATEUR4 = "√" Then
            racinecarer(nombre1) 'appel de la fonction racine carrer
        ElseIf OPERATEUR5 = "mod" Then
            Modul(nombre1, nombre2)
        ElseIf OPERATEUR6 = "sin" Then
            sinus(nombre1)
        ElseIf OPERATEUR6 = "cos" Then
            cosinus(nombre1)
        ElseIf OPERATEUR6 = "tan" Then
            tang(nombre1)
        ElseIf OPERATEUR6 = "log" Then
            logarithmique(nombre1)
        ElseIf OPERATEUR6 = "exp" Then
            expo(nombre1)
        End If
    End Sub
    Function Addition(ByVal nombre1 As Double, ByVal nombre2 As Double) As Integer

        OPERATEUR = "+"
        Dim f As Double
        nombre2 = Val(result.Text)
        f = nombre1 + nombre2
        result.Text = f.ToString
        Return f
    End Function
    Function Soustration(ByVal nombre1 As Double, ByVal nombre2 As Double) As Integer

        OPERATEUR1 = "-"
        Dim f As Double
        nombre2 = Val(result.Text)
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
    Function Multiplication(ByVal nombre1 As Integer, ByVal nombre2 As Integer) As Integer

        OPERATEUR2 = "x"
        Dim f As Double
        nombre2 = Val(result.Text) 'conversion et recuperation du deuxieme nombre entree
        f = nombre1 * nombre2
        result.Text = f.ToString
        Return f
    End Function

    Function Ladivision(ByVal nombre1 As Integer, ByVal nombre2 As Integer) As Double

        OPERATEUR3 = "/"
        Dim f As Double
        nombre2 = Val(result.Text)
        f = nombre1 / nombre2
        result.Text = f.ToString
        Return f
    End Function
    Function Racinecarer(ByVal nombre1 As Double) As Double

        OPERATEUR3 = "√"
        Dim f As Double
        f = Math.Sqrt(nombre1)
        result.Text = f.ToString
        Return f
    End Function

    Function sinus(ByVal nombre1 As Double) As Double

        OPERATEUR6 = "sin"
        Dim f As Double
        f = Math.Sin(nombre1)
        result.Text = f.ToString
        Return f
    End Function

    Function logarithmique(ByVal nombre1 As Double) As Double

        OPERATEUR6 = "log"
        Dim f As Double
        f = Math.Log(nombre1)
        result.Text = f.ToString
        Return f
    End Function

    Function cosinus(ByVal nombre1 As Double) As Double

        OPERATEUR6 = "cos"
        Dim f As Double
        f = Math.Cos(nombre1)
        result.Text = f.ToString
        Return f
    End Function

    Function tang(ByVal nombre1 As Double) As Double

        OPERATEUR6 = "tan"
        Dim f As Double
        f = Math.Tan(nombre1)
        result.Text = f.ToString
        Return f
    End Function

    Function expo(ByVal nombre1 As Double) As Double

        OPERATEUR6 = "exp"
        Dim f As Double
        f = Math.Exp(nombre1)
        result.Text = f.ToString
        Return f
    End Function
    Function Modul(ByVal nombre1 As Integer, ByVal nombre2 As Integer) As Double
        OPERATEUR5 = "mod"
        Dim f As Double
        nombre2 = Double.Parse(result.Text)
        f = nombre1 Mod nombre2
        result.Text = f.ToString
        Return f
    End Function


    Private Sub Effacer_Click(sender As Object, e As EventArgs) Handles effacer.Click
        result.Clear() 'lors du click sur le button click afficher la variable 
        result.Select()
    End Sub

    Private Sub Point_Click(sender As Object, e As EventArgs) Handles point.Click
        Dim point As String = "."
        result.Text = result.Text & point.ToString
    End Sub

    Private Sub Carrer_Click(sender As Object, e As EventArgs) Handles carrer.Click
        nombre1 = Double.Parse(result.Text)
        Dim moi As String = ""
        OPERATEUR4 = "√"
        result.Text = moi.ToString
    End Sub

    Private Sub Modulo_Click(sender As Object, e As EventArgs) Handles modulo.Click
        nombre1 = Double.Parse(result.Text)
        Dim modd As String = ""
        OPERATEUR5 = "mod"
        result.Text = modd.ToString
    End Sub

    Private Sub sin_Click(sender As Object, e As EventArgs) Handles sin.Click
        nombre1 = Double.Parse(result.Text)
        Dim sinus As String = ""
        OPERATEUR6 = "sin"
        result.Text = sinus.ToString
    End Sub

    Private Sub cos_Click(sender As Object, e As EventArgs) Handles cos.Click
        nombre1 = Double.Parse(result.Text)
        Dim cossinus As String = ""
        OPERATEUR6 = "cos"
        result.Text = cossinus.ToString
    End Sub

    Private Sub tan_Click(sender As Object, e As EventArgs) Handles tan.Click
        nombre1 = Double.Parse(result.Text)
        Dim tang As String = ""
        OPERATEUR6 = "tan"
        result.Text = tang.ToString
    End Sub

    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click
        nombre1 = Double.Parse(result.Text)
        Dim loga As String = ""
        OPERATEUR6 = "log"
        result.Text = loga.ToString
    End Sub

    Private Sub exp_Click(sender As Object, e As EventArgs) Handles exp.Click
        nombre1 = Double.Parse(result.Text)
        Dim expo As String = ""
        OPERATEUR6 = "exp"
        result.Text = expo.ToString
    End Sub

    Private Sub CALCULATRICE2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scientifique.Visible = False
        equation.Visible = False
    End Sub

    Private Sub ScientifiqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientifiqueToolStripMenuItem.Click
        scientifique.Visible = True
        equation.Visible = False
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub calculer_Click(sender As Object, e As EventArgs) Handles calculer.Click
        val1 = Double.Parse(a.Text)
        val2 = Double.Parse(b.Text)
        val3 = Double.Parse(c.Text)
        If val1 = 0 Then
            If val2 = 0 Then
                Dim msg1 As String = "resolution impossible"
                MsgBox(Prompt:=msg1)
                If vbOK Then
                    a.Clear()
                    b.Clear()
                    c.Clear()
                    resulta.Clear()
                    a.Select()
                End If

            Else

                r = -val3 / val2
                resulta.Text = r
            End If

        Else
            Dim D As Double
            D = (val2 * val2) - 4 * (val1 * val3)

            discriminat.Text = D

            If D = 0 Then
                r = -val2 / 2 * val1
                resulta.Text = r

            ElseIf D > 0 Then
                x1 = -val2 + Math.Sqrt(D) / (2 * val1)
                x2 = -val2 - Math.Sqrt(D) / (2 * val1)

                resulta.Text = x1 & " " & "et " & x2

            Else
                Dim msg1 As String = "solution inexistante dans R"
                MsgBox(Prompt:=msg1)
            End If
        End If
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        equation.Visible = False
        scientifique.Visible = False
    End Sub

    Private Sub EquationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquationToolStripMenuItem.Click
        equation.Visible = True
    End Sub

    Private Sub quitter_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Dim titre As String = "question"
        Dim msg As String = "ETES VOUS SUR DE VOULOIR QUITTER ? "
        Dim result = MessageBox.Show(msg, titre, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        If result = DialogResult.Cancel Then
            equation.Visible = True
        Else
            equation.Visible = False
        End If
    End Sub

    Private Sub clean_Click(sender As Object, e As EventArgs) Handles clean.Click
        a.Clear()
        b.Clear()
        c.Clear()
        result.Clear()
        discriminat.Text = "..."
        a.Select()
    End Sub
End Class