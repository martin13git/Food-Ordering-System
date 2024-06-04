Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class user_profile
    Private Sub user_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUserDetails(LandingPage.user_id_now)
    End Sub

    Private Sub FetchUserDetails(userId As Integer)
        Try
            ' SQL query to fetch name, dob, phone, and city from user table using Id
            Dim query As String = "SELECT name, dob, phone, city FROM [user] WHERE Id = @Id"

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameter to the command
                    cmd.Parameters.AddWithValue("@Id", userId)

                    ' Open the connection
                    conn.Open()

                    ' Execute the query and read the results
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Set the fetched data to the respective controls
                            TextBox2.Text = reader("name").ToString()
                            DateTimePicker1.Value = Convert.ToDateTime(reader("dob"))
                            TextBox3.Text = reader("city").ToString()
                            TextBox4.Text = reader("phone").ToString()
                        Else
                            MessageBox.Show("No user found with the provided Id.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Validate input fields
        If Not ValidateInputs() Then
            Return
        End If

        ' Update details in the database
        Try
            Dim id As Integer = LandingPage.user_id_now
            Dim name As String = TextBox2.Text
            Dim city As String = TextBox3.Text
            Dim phone As String = TextBox4.Text
            Dim dob As Date = DateTimePicker1.Value.Date ' Only the date part

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE [user] SET name = @name, city = @city, phone = @phone, dob = @dob WHERE Id = @id"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@city", city)
                    cmd.Parameters.AddWithValue("@phone", phone)
                    cmd.Parameters.AddWithValue("@dob", dob)
                    cmd.Parameters.AddWithValue("@id", id)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Details updated successfully.")
                    Else
                        MessageBox.Show("No records updated. Please check the user ID.")
                    End If
                End Using
            End Using

            ' Refresh the DataGridView
            FetchUserDetails(LandingPage.user_id_now)

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating details: " & ex.Message)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate input fields
        If String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please enter all details")
            Return False
        End If

        ' Validate phone number (Indian phone number validation)
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextBox4.Text, "^[6-9]\d{9}$") Then
            MessageBox.Show("Please enter a valid Indian phone number.")
            Return False
        End If

        ' Validation successful
        Return True
    End Function
End Class