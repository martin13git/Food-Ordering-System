Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class admin_menuview
    Private Sub admin_menuview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDataGridView()
    End Sub

    Private Sub PopulateDataGridView()
        Try
            ' Define SQL query to fetch data from the menu table
            Dim query As String = "SELECT item_id, item, category, price FROM menu"

            ' Create SqlConnection and SqlDataAdapter
            Using conn As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter(query, conn)
                    ' Create DataSet to hold the data
                    Dim dataSet As New DataSet()

                    ' Fill the DataSet with data from the database
                    adapter.Fill(dataSet, "menu")

                    ' Bind the DataSet to the DataGridView
                    DataGridView1.DataSource = dataSet.Tables("menu")

                    ' Set column names
                    DataGridView1.Columns(0).HeaderText = "ID"
                    DataGridView1.Columns(1).HeaderText = "Item"
                    DataGridView1.Columns(2).HeaderText = "Category"
                    DataGridView1.Columns(3).HeaderText = "Price"
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

            ' Display data in respective fields
            TextBox1.Text = selectedRow.Cells("item_id").Value.ToString()
            TextBox2.Text = selectedRow.Cells("item").Value.ToString()
            ComboBox1.SelectedItem = selectedRow.Cells("category").Value.ToString()
            TextBox3.Text = selectedRow.Cells("price").Value.ToString()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate other fields
        If Not ValidateInputs() Then
            Return
        End If

        Try
            ' Prepare SQL query for checking if item_id exists
            Dim queryExist As String = "SELECT COUNT(*) FROM menu WHERE item_id = @item_id"
            Dim item_id As Integer = 0
            If Not String.IsNullOrEmpty(TextBox1.Text) Then
                item_id = Convert.ToInt32(TextBox1.Text)
            End If

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Check if item_id exists
                Using cmdExist As New SqlCommand(queryExist, conn)
                    cmdExist.Parameters.AddWithValue("@item_id", item_id)
                    Dim count As Integer = Convert.ToInt32(cmdExist.ExecuteScalar())

                    If count > 0 Then
                        ' Update existing record
                        Dim queryUpdate As String = "UPDATE menu SET item = @item, category = @category, price = @price WHERE item_id = @item_id"
                        Using cmdUpdate As New SqlCommand(queryUpdate, conn)
                            cmdUpdate.Parameters.AddWithValue("@item", TextBox2.Text)
                            cmdUpdate.Parameters.AddWithValue("@category", ComboBox1.SelectedItem.ToString())
                            cmdUpdate.Parameters.AddWithValue("@price", Convert.ToSingle(TextBox3.Text))
                            cmdUpdate.Parameters.AddWithValue("@item_id", item_id)
                            cmdUpdate.ExecuteNonQuery()
                            MessageBox.Show("Item updated successfully.")
                        End Using
                    Else
                        ' Insert new record
                        Dim queryInsert As String = "INSERT INTO menu (item, category, price) VALUES ( @item, @category, @price)"
                        Using cmdInsert As New SqlCommand(queryInsert, conn)
                            cmdInsert.Parameters.AddWithValue("@item", TextBox2.Text)
                            cmdInsert.Parameters.AddWithValue("@category", ComboBox1.SelectedItem.ToString())
                            cmdInsert.Parameters.AddWithValue("@price", Convert.ToSingle(TextBox3.Text))
                            cmdInsert.ExecuteNonQuery()
                            MessageBox.Show("New item added successfully.")
                        End Using
                    End If
                End Using
            End Using

            ' Refresh the DataGridView
            PopulateDataGridView()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            ComboBox1.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating details: " & ex.Message)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate other fields
        If String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(ComboBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Item, Category, and Price are required.")
            Return False
        End If

        ' Validate price (float)
        Dim price As Single
        If Not Single.TryParse(TextBox3.Text, price) Then
            MessageBox.Show("Please enter a valid price.")
            Return False
        End If

        ' Validation successful
        Return True
    End Function


End Class