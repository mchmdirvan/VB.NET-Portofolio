Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_hasil.Text = Val(txt_nilai1.Text) + Val(txt_nilai2.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_hasil.Text = Val(txt_nilai1.Text) - Val(txt_nilai2.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_hasil.Text = Val(txt_nilai1.Text) * Val(txt_nilai2.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_hasil.Text = Val(txt_nilai1.Text) / Val(txt_nilai2.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_nilai1.Text = ""
        txt_nilai2.Text = ""
        txt_hasil.Text = ""

        txt_nilai1.Focus()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = vbYes Then
            Me.Close()

        End If
    End Sub

    Private Sub PERHITUNGAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_hasil_TextChanged(sender As Object, e As EventArgs) Handles txt_hasil.TextChanged
        txt_hasil.Enabled = False
    End Sub
End Class