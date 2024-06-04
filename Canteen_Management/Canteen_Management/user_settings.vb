Public Class user_settings
    Private Sub user_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None ' Set form border style to None to remove title bar
        panel.Dock = DockStyle.Fill ' Dock the form to fill the panel
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchpanel(user_profile)
        Button2.BackColor = Color.White
        Button1.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchpanel(user_changepassword)
        Button1.BackColor = Color.White
        Button2.BackColor = Color.CornflowerBlue
    End Sub
End Class