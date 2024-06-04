Public Class admin_dashboard
    Private Sub admin_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None ' Set form border style to None to remove title bar
        panel.Dock = DockStyle.Fill ' Dock the form to fill the panel
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        switchpanel(admin_userview)
        PictureBox1.BackColor = Color.CornflowerBlue
        PictureBox2.BackColor = Me.BackColor
        PictureBox3.BackColor = Me.BackColor
        PictureBox4.BackColor = Me.BackColor
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        switchpanel(admin_menuview)
        PictureBox1.BackColor = Me.BackColor
        PictureBox2.BackColor = Color.CornflowerBlue
        PictureBox3.BackColor = Me.BackColor
        PictureBox4.BackColor = Me.BackColor
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        switchpanel(admin_orderview)
        PictureBox1.BackColor = Me.BackColor
        PictureBox2.BackColor = Me.BackColor
        PictureBox3.BackColor = Color.CornflowerBlue
        PictureBox4.BackColor = Me.BackColor
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        switchpanel(admin_settings)
        PictureBox1.BackColor = Me.BackColor
        PictureBox2.BackColor = Me.BackColor
        PictureBox3.BackColor = Me.BackColor
        PictureBox4.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            Me.Close()
            AdminLogin.Show()
        End If
    End Sub
End Class