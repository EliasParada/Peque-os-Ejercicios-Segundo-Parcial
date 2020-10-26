Public Class frmEvento
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseHover
        MessageBox.Show("El cursos esta sobre el control.")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTextChange.TextChanged
        lblTextChange.Text = txtTextChange.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("El botón fue clickeado.")
    End Sub
End Class