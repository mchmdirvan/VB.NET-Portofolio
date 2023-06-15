Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Hasil_Nama.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hasil_Nama.Text = Masukan_Nama.Text

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_DoubleClick(sender As Object, e As EventArgs) Handles Label2.DoubleClick
        Hasil_Nama.Text = Masukan_Nama.Text

    End Sub

    Private Sub Masukan_Nama_TextChanged(sender As Object, e As EventArgs) Handles Masukan_Nama.TextChanged
        Hasil_Nama.Text = Masukan_Nama.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hasil_Nama.Text = ""
        Masukan_Nama.Text = ""
        Masukan_Nama.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
