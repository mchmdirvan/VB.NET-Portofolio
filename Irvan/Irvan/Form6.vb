Public Class Form6

    Sub Buat_Tabel()
        LV.Columns.Add("Nomor Pokok", 80, HorizontalAlignment.Center)
        LV.Columns.Add("Nama Lengkap", 150, HorizontalAlignment.Left)
        LV.Columns.Add("Jenjang", 100, HorizontalAlignment.Center)
        LV.Columns.Add("Jurusan", 150, HorizontalAlignment.Center)
        LV.View = View.Details
        LV.GridLines = True
        LV.FullRowSelect = True
        LV.BackColor = Color.LightSkyBlue
    End Sub
    Sub isi_tabel()
        Dim isi As New ListViewItem
        isi.Text = NPM.Text
        isi.SubItems.Add(Nama.Text)
        isi.SubItems.Add(Jenjang.Text)
        isi.SubItems.Add(Jurusan.Text)
        LV.Items.Add(isi)
    End Sub
    Sub Bersih()
        NPM.Text = ""
        Nama.Text = ""
        Jenjang.Text = ""
        Jurusan.Text = ""
        NPM.Focus()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buat_Tabel()
        NPM.Focus()
        Jenjang.Items.Add("S1")
        Jenjang.Items.Add("D3")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call isi_tabel()
        Call Bersih()
        NPM.Focus()
    End Sub

    Private Sub Jenjang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Jenjang.SelectedIndexChanged
        Jurusan.Items.Clear()
        If Jenjang.Text = "S1" Then
            Jurusan.Text = ""
            Jurusan.Items.Add("Teknik Informatika")
            Jurusan.Items.Add("Sistem Informasi")
        ElseIf Jenjang.Text = "D3" Then
            Jurusan.Text = ""
            Jurusan.Items.Add("Management Informatika")
            Jurusan.Items.Add("Komputerisasi Akuntasi")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = vbYes Then
            Me.Close()
        Else
            MsgBox("Silahkan Lanjut")
            NPM.Focus()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hapus_baris As String
        hapus_baris = MessageBox.Show("Apakah anda ingin menghapus baris ini?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hapus_baris = vbYes Then
            LV.Items.Clear()
            NPM.Focus()
            Me.Close()
        Else
            MsgBox("Silahkan Lanjut")
            NPM.Focus()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hapus_semua As String
        hapus_semua = MessageBox.Show("Apakah anda ingin menghapus semua?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hapus_semua = vbYes Then
            LV.Items.Clear()
            NPM.Focus()
            Me.Close()
        Else
            MsgBox("Silahkan Lanjut")
            NPM.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Bersih()
    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV.SelectedIndexChanged

    End Sub
End Class