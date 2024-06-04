Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AdminLogin
    Public admin_id_now As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userId As Integer
        If Not Integer.TryParse(TextBox1.Text, userId) Then
            MessageBox.Show("Invalid user id. Please enter a valid integer.")
            Return
        End If

        Dim password As String = TextBox2.Text

        Try
            ' Fetch password from the database based on the user id
            Dim dbPassword As String = ""
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT password FROM [admin] WHERE adminID = @userId"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    conn.Open()
                    dbPassword = Convert.ToString(cmd.ExecuteScalar())
                End Using
            End Using

            ' Check if the entered password matches the fetched password
            If password = dbPassword Then
                admin_id_now = userId
                MessageBox.Show("Login successful!")
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
                admin_dashboard.Show()
            Else
                MessageBox.Show("Invalid user id or password.")
            End If

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        LandingPage.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        admin_forgotpassword.Show()
    End Sub
End Class