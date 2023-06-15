Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_namabarang.Select()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_harga.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.txt_namabarang.Text = ""
        Me.txt_harga.Text = ""
        Me.txt_jumlah.Text = ""
        Me.txt_subtotal.Text = ""
        Me.txt_discount.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(Me.txt_harga.Text) = False Then
            MsgBox("Masukan Angka", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If IsNumeric(Me.txt_jumlah.Text) = False Then
            MsgBox("Masukan Angka", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim Xsubtotal As Double = 0
        Xsubtotal = Val(Me.txt_harga.Text) * Val(txt_jumlah.Text)
        Me.txt_subtotal.Text = Xsubtotal


        If Me.Discount.Checked = True Then
            Me.txt_discount.Text = Val(txt_subtotal.Text) * 10 / 100
        End If
        If Me.Tidak_Discount.Checked = True Then
            Me.txt_discount.Text = 0
        End If

        Me.txt_total.Text = Val(Me.txt_subtotal.Text) - Val(Me.txt_discount.Text)


    End Sub

    Private Sub txt_namabarang_TextChanged(sender As Object, e As EventArgs) Handles txt_namabarang.TextChanged

    End Sub

    Private Sub txt_namabarang_ReadOnlyChanged(sender As Object, e As EventArgs) Handles txt_namabarang.ReadOnlyChanged

    End Sub

    Private Sub txt_namabarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_namabarang.KeyDown
        If e.KeyCode = Keys.Return Then Me.txt_harga.Focus()

    End Sub

    Private Sub txt_harga_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_harga.KeyDown
        If e.KeyCode = Keys.Return Then Me.txt_jumlah.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = vbYes Then
            Me.Close()

        End If
    End Sub

    Private Sub txt_subtotal_TextChanged(sender As Object, e As EventArgs) Handles txt_subtotal.TextChanged
        txt_subtotal.Enabled = False
    End Sub

    Private Sub txt_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_discount.TextChanged
        txt_discount.Enabled = False
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
        txt_total.Enabled = False
    End Sub
End Class