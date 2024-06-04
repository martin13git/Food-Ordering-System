Imports System.Data.SqlClient

Public Class admin_forgotpassword
    Private Sub admin_forgotpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateAdminPassword(adminID As Integer)
        ' Get the values from the controls
        Dim dob As Date = DateTimePicker1.Value.Date ' Get only the date portion
        Dim newPassword As String = TextBox2.Text.Trim()
        Dim confirmPassword As String = TextBox3.Text.Trim()

        Try
            ' SQL query to fetch dob and password from admin table using adminID
            Dim query As String = "SELECT dob, password FROM admin WHERE adminID = @adminID"

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameter to the command
                    cmd.Parameters.AddWithValue("@adminID", adminID)

                    ' Open the connection
                    conn.Open()

                    ' Execute the query and read the results
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Get the dob and password from the database
                            Dim dobFromDb As Date = Convert.ToDateTime(reader("dob")).Date ' Get only the date portion
                            Dim passwordFromDb As String = reader("password").ToString()

                            ' Compare dob and passwords
                            If dobFromDb <> dob Then
                                MessageBox.Show("DOB does not match.")
                                Return
                            End If

                            If newPassword <> confirmPassword Then
                                MessageBox.Show("New passwords do not match.")
                                Return
                            End If
                        Else
                            MessageBox.Show("No admin found with the provided admin ID.")
                            Return
                        End If

                        ' Close the data reader before executing another query
                        reader.Close()
                    End Using

                    ' Update the password in the database
                    Dim updateQuery As String = "UPDATE admin SET password = @newPassword WHERE adminID = @adminID"

                    ' Create SqlCommand for updating the password
                    Using updateCmd As New SqlCommand(updateQuery, conn)
                        ' Add parameters to the update command
                        updateCmd.Parameters.AddWithValue("@newPassword", newPassword)
                        updateCmd.Parameters.AddWithValue("@adminID", adminID)

                        ' Execute the update query
                        updateCmd.ExecuteNonQuery()
                    End Using

                    ' Show success message
                    MessageBox.Show("Password updated successfully!")
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminID As Integer
        If Integer.TryParse(TextBox1.Text, adminID) Then
            UpdateAdminPassword(adminID)
        Else
            MessageBox.Show("Please enter a valid admin ID.")
        End If
    End Sub
End Class