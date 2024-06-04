Public Class user_dashboard
    Private Sub user_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        switchpanel(user_orders)
        PictureBox1.BackColor = Color.CornflowerBlue
        PictureBox2.BackColor = Me.BackColor
        PictureBox3.BackColor = Me.BackColor
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        switchpanel(user_ordering)
        PictureBox1.BackColor = Me.BackColor
        PictureBox2.BackColor = Color.CornflowerBlue
        PictureBox3.BackColor = Me.BackColor
        user_orders.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        switchpanel(user_settings)
        PictureBox1.BackColor = Me.BackColor
        PictureBox2.BackColor = Me.BackColor
        PictureBox3.BackColor = Color.CornflowerBlue
        user_orders.Close()
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class