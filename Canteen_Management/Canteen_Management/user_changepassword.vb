Imports System.Data.SqlClient

Public Class user_changepassword
    Private Sub user_changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdatePassword(adminID As Integer)
        ' Get the values from the text boxes
        Dim oldPassword As String = TextBox1.Text.Trim()
        Dim newPassword As String = TextBox4.Text.Trim()
        Dim confirmPassword As String = TextBox5.Text.Trim()

        ' Check if the new passwords match
        If newPassword <> confirmPassword Then
            MessageBox.Show("New passwords do not match.")
            Return
        End If

        Try
            ' SQL query to verify the old password
            Dim verifyQuery As String = "SELECT COUNT(*) FROM [user] WHERE Id = @adminID AND password = @oldPassword"

            ' SQL query to update the password
            Dim updateQuery As String = "UPDATE [user] SET password = @newPassword WHERE Id = @adminID"

            ' Create SqlConnection and SqlCommand for verification
            Using conn As New SqlConnection(connectionString)
                Using verifyCmd As New SqlCommand(verifyQuery, conn)
                    ' Add parameters to the verify command
                    verifyCmd.Parameters.AddWithValue("@adminID", adminID)
                    verifyCmd.Parameters.AddWithValue("@oldPassword", oldPassword)

                    ' Open the connection
                    conn.Open()

                    ' Execute the verify query
                    Dim count As Integer = Convert.ToInt32(verifyCmd.ExecuteScalar())

                    ' Check if the old password is correct
                    If count = 0 Then
                        MessageBox.Show("Old password is incorrect.")
                        Return
                    End If

                    ' Create SqlCommand for updating the password
                    Using updateCmd As New SqlCommand(updateQuery, conn)
                        ' Add parameters to the update command
                        updateCmd.Parameters.AddWithValue("@newPassword", newPassword)
                        updateCmd.Parameters.AddWithValue("@adminID", adminID)

                        ' Execute the update query
                        updateCmd.ExecuteNonQuery()
                    End Using
                End Using
            End Using

            ' Show success message
            MessageBox.Show("Password updated successfully!" & vbCrLf & "Please login again!")
            user_dashboard.Close()
            LandingPage.Show()

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adminID As Integer = LandingPage.user_id_now
        UpdatePassword(adminID)
    End Sub
End Class