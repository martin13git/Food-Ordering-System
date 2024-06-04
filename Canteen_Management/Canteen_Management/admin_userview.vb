Imports System.Data.SqlClient

Public Class admin_userview
    Private Sub admin_userview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDataGridView()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Validate input fields
        If Not ValidateInputs() Then
            Return
        End If

        ' Update details in the database
        Try
            Dim id As Integer = Convert.ToInt32(TextBox1.Text)
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
            PopulateDataGridView()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

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


    Private Sub PopulateDataGridView()
        Try
            ' Define SQL query to fetch Id, name, dob, city, and phone from user table
            Dim query As String = "SELECT Id, name, dob, city, phone FROM [user]"

            ' Create SqlConnection and SqlDataAdapter
            Using conn As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter(query, conn)
                    ' Create DataSet to hold the data
                    Dim dataSet As New DataSet()

                    ' Fill the DataSet with data from the database
                    adapter.Fill(dataSet, "user")

                    ' Bind the DataSet to the DataGridView
                    DataGridView1.DataSource = dataSet.Tables("user")

                    ' Set column names
                    DataGridView1.Columns(0).HeaderText = "ID"
                    DataGridView1.Columns(1).HeaderText = "Name"
                    DataGridView1.Columns(2).HeaderText = "DOB"
                    DataGridView1.Columns(3).HeaderText = "City"
                    DataGridView1.Columns(4).HeaderText = "Phone"
                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not the header row
        If e.RowIndex >= 0 Then
            ' Retrieve data from the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Populate TextBoxes and DateTimePicker with the selected row data
            TextBox1.Text = selectedRow.Cells("ID").Value.ToString()
            TextBox2.Text = selectedRow.Cells("Name").Value.ToString()
            TextBox3.Text = selectedRow.Cells("City").Value.ToString()
            TextBox4.Text = selectedRow.Cells("Phone").Value.ToString()
            DateTimePicker1.Value = CDate(selectedRow.Cells("DOB").Value)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user_create_acc.Show()
    End Sub
End Class