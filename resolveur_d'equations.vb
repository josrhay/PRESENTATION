Public Class resolveur_d_equations
    Dim val1 As Double
    Dim val2 As Double
    Dim val3 As Double
    Dim r As Double
    Dim x1 As Double
    Dim x2 As Double
    Private Sub a_TextChanged(sender As Object, e As EventArgs) Handles a.TextChanged

        val1 = Double.Parse(a.Text)
    End Sub

    Private Sub b_TextChanged(sender As Object, e As EventArgs) Handles b.TextChanged
        val2 = Double.Parse(b.Text)
    End Sub

    Private Sub c_TextChanged(sender As Object, e As EventArgs) Handles c.TextChanged
        val3 = Double.Parse(c.Text)
    End Sub

    Private Sub calculer_Click(sender As Object, e As EventArgs) Handles calculer.Click

        If val1 = 0 Then
            If val2 = 0 Then
                Dim msg1 As String = "resolution impossible"
                MsgBox(Prompt:=msg1)
                If vbOK Then
                    a.Clear()
                    b.Clear()
                    c.Clear()
                    a.Select()
                End If

            Else

                r = -val3 / val2
                result.Text = r
            End If

        Else
            Dim D As Double
            D = (val2 * val2) - 4 * (val1 * val3)

            discriminat.Text = D

            If D = 0 Then
                r = -val2 / 2 * val1
                result.Text = r

            ElseIf D > 0 Then
                x1 = -val2 + Math.Sqrt(D) / (2 * val1)
                x2 = -val2 - Math.Sqrt(D) / (2 * val1)

                result.Text = x1 & "et " & x2

            Else
                Dim msg1 As String = "solution inexistante dans R"
                MsgBox(Prompt:=msg1)
            End If
        End If
    End Sub

    Private Sub quitter_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Dim msg1 As String = "ETES VOUS SUR DE VOULOIR QUITTER ?"
        MsgBox(Prompt:=msg1)
        a.Clear()
        b.Clear()
        c.Clear()
        a.Select()
    End Sub
End Class