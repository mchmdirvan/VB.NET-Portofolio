Public Class FORM_MENU
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click

    End Sub

    Private Sub FORM_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EXITToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem1.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = vbYes Then
            Me.Close()

        End If
    End Sub

    Private Sub PERKENALANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERKENALANToolStripMenuItem.Click
        Dim buka_form1 As New Form1
        buka_form1.MdiParent = Me
        buka_form1.Show()
    End Sub

    Private Sub PERHITUNGANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERHITUNGANToolStripMenuItem.Click
        Dim buka_form2 As New Form2
        buka_form2.MdiParent = Me
        buka_form2.Show()
    End Sub

    Private Sub BELANJAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BELANJAToolStripMenuItem.Click
        Dim buka_form3 As New Form3
        buka_form3.MdiParent = Me
        buka_form3.Show()
    End Sub

    Private Sub INPUTDATAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INPUTDATAToolStripMenuItem.Click
        Dim buka_form4 As New Form4
        buka_form4.MdiParent = Me
        buka_form4.Show()
    End Sub

    Private Sub EXITToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem2.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = vbYes Then
            Me.Close()

        End If
    End Sub

    Private Sub FORMLOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMLOGINToolStripMenuItem.Click
        Dim buka_form5 As New FORM_LOGIN
        buka_form5.MdiParent = Me
        buka_form5.Show()
    End Sub

    Private Sub LISTVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTVIEWToolStripMenuItem.Click
        Dim buka_form6 As New Form6
        buka_form6.MdiParent = Me
        buka_form6.Show()
    End Sub

    Private Sub LAPORANPENJUALANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LAPORANPENJUALANToolStripMenuItem.Click
        Dim buka_form7 As New Form7
        buka_form7.MdiParent = Me
        buka_form7.Show()
    End Sub

    Private Sub NIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NIMToolStripMenuItem.Click
        Dim buka_form8 As New Form8
        buka_form8.MdiParent = Me
        buka_form8.Show()
    End Sub

    Private Sub TAGIHANPDAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TAGIHANPDAMToolStripMenuItem.Click
        Dim buka_form9 As New Form9
        buka_form9.MdiParent = Me
        buka_form9.Show()
    End Sub

    Private Sub QUIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUIZToolStripMenuItem.Click
        Dim buka_form10 As New Form10
        buka_form10.MdiParent = Me
        buka_form10.Show()
    End Sub

    Private Sub UJIANTENGAHSEMESTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UJIANTENGAHSEMESTERToolStripMenuItem.Click
        Dim buka_formUTS As New Form_UTS
        buka_formUTS.MdiParent = Me
        buka_formUTS.Show()
    End Sub
End Class