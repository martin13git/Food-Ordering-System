Imports System.Data.SqlClient

Public Class admin_orderview
    Private Sub admin_orderview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchAllOrders()
    End Sub
    Private Sub FetchAllOrders()
        Try
            ' SQL query to fetch all records from the order table
            Dim query As String = "SELECT order_id, user_id, no_of_items, amount FROM [order]"

            ' Create a DataTable to hold the query results
            Dim ordersTable As New DataTable()

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Open the connection
                    conn.Open()

                    ' Execute the query and load the results into the DataTable
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ordersTable.Load(reader)
                    End Using
                End Using
            End Using

            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = ordersTable

            ' Set the column names
            DataGridView1.Columns("order_id").HeaderText = "Order ID"
            DataGridView1.Columns("user_id").HeaderText = "User ID"
            DataGridView1.Columns("no_of_items").HeaderText = "No of Items"
            DataGridView1.Columns("amount").HeaderText = "Amount"
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class