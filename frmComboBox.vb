Public Class frmComboBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbxNacion.Items.Add(cbxNacion.Text)
        MessageBox.Show("Enviado.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Enviado.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Enviado.")
    End Sub
End Class