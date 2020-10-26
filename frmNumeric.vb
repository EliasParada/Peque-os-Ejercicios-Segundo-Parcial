Public Class frmNumeric
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nupNumero.Maximum = nupNumero.Maximum + 5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nupNumero.Maximum = nupNumero.Maximum - 5
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nupNumero.Minimum = nupNumero.Minimum + 5
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nupNumero.Minimum = nupNumero.Minimum - 5
    End Sub
End Class