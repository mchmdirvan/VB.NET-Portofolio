Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtMottoHidup_TextChanged(sender As Object, e As EventArgs) Handles txtMottoHidup.TextChanged

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim jenis_kelamin As String = ""
        If rdoLakiLaki.Checked = True Then
            jenis_kelamin = " Laki-Laki"
        ElseIf rdoPerempuan.Checked = True Then
            jenis_kelamin = " Perempuan "
        End If
        Dim hobi As String = ""
        If chkBuku.Checked Then
            hobi = hobi + " Baca Buku "
        End If
        If chkFilm.Checked Then
            hobi = hobi + " Nonton film "
        End If

        If chkInternet.Checked Then
            hobi = hobi + " Internet"
        End If
        If chkMusik.Checked Then
            hobi = hobi + " Dengan Musik "
        End If
        If chkSport.Checked Then
            hobi = hobi + " Olah Raga "
        End If
        If chkBelanja.Checked Then
            hobi = hobi + " shopping "
        End If
        dlgInfo.Show()

        dlgInfo.txtInfo.Text = " Nama : " + txtnama.Text + vbCrLf _
            + " Tanggal Lahir : " + timTanggalLahir.Text + vbCrLf _
            + " Jenis Kelamin : " + jenis_kelamin + vbCrLf _
            + " Agama : " + cboAgama.Text + vbCrLf _
            + " Pekerjaan : " + lstPekerjaan.Text + vbCrLf _
            + " Hobi : " + hobi + vbCrLf _
            + " Kendaraan : " + lstKendaraan.Text + vbCrLf _
            + " Motto Hidup : " + txtMottoHidup.Text
    End Sub

    Private Sub istPekerjaan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPekerjaan.SelectedIndexChanged

    End Sub
End Class