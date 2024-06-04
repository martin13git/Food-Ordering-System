Imports System.Data.SqlClient

Public Class user_create_acc
    Private Sub user_create_acc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.UseSystemPasswordChar = True
        TextBox5.UseSystemPasswordChar = True
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Allow only alphabets and control characters
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Allow only alphabets and control characters
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Allow only digits and control characters
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        LandingPage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve values from text boxes and date picker
        Dim name As String = TextBox1.Text
        Dim dob As Date = DateTimePicker1.Value.Date ' Only the date part
        Dim city As String = TextBox2.Text
        Dim phone As String = TextBox3.Text
        Dim password As String = TextBox4.Text
        Dim reEnteredPassword As String = TextBox5.Text

        Try
            ' Validate the inputs
            If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(city) OrElse String.IsNullOrWhiteSpace(phone) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(reEnteredPassword) Then
                MessageBox.Show("All fields are required.")
                Return
            End If

            ' Validate the passwords
            If password <> reEnteredPassword Then
                MessageBox.Show("Passwords do not match.")
                Return
            End If

            ' Validate the phone number (Indian phone number validation)
            If Not System.Text.RegularExpressions.Regex.IsMatch(phone, "^[6-9]\d{9}$") Then
                MessageBox.Show("Please enter a valid Indian phone number.")
                Return
            End If

            ' Insert data into the database and fetch the generated Id
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO [user] (dob, phone, city, password, name) OUTPUT INSERTED.Id VALUES (@dob, @phone, @city, @password, @name)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@dob", dob)
                    cmd.Parameters.AddWithValue("@phone", phone)
                    cmd.Parameters.AddWithValue("@city", city)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@name", name)

                    conn.Open()
                    Dim newId As Integer = CInt(cmd.ExecuteScalar())
                    MessageBox.Show("User added successfully! New User Id: " & newId)
                End Using
            End Using
            Me.Close()
            LandingPage.Show()

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Toggle the UseSystemPasswordChar property of TextBox4
        If CheckBox1.Checked Then
            TextBox4.UseSystemPasswordChar = False
        Else
            TextBox4.UseSystemPasswordChar = True
        End If
    End Sub
End Class