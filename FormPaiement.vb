Public Class FormPaiement
    Private Sub FormPaiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Code d'initialisation si nécessaire
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Paiement enregistré avec succès !", "Confirmation")
    End Sub
End Class
