Public Class FORM_LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_user.Text = "IRVAN" And txt_password.Text = "12345" Then
            FORM_MENU.Show()
            Me.Hide()
        Else
            If txt_user.Text = "MOCHAMAD" And txt_password.Text = "54321" Then
                FORM_MENU.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username & Password anda salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Return Then Me.Button1.Focus()
    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_user.Select()
    End Sub
End Class