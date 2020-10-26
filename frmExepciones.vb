Public Class frmExepciones
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            lblRes.Text = txtNumRes1.Text - txtNumRes2.Text
        Catch ex As Exception
            MessageBox.Show("Ingrese números")
        End Try
    End Sub
End Class