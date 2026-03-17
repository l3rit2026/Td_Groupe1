Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BntModifier.Click
        Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre1 As Double
        Dim nombre2 As Double
        Dim resultat As Double

        nombre1 = CDbl(nb1.Text)
        nombre2 = CDbl(nb2.Text)
        resultat = nombre1 + nombre2

        MessageBox.Show("La somme est : " & resultat)
    End Sub
End Class
