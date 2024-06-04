Imports System.Data.SqlClient

Public Class user_orders
    Private Sub user_orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchOrdersForUser(LandingPage.user_id_now)
    End Sub
    Private Sub FetchOrdersForUser(userId As Integer)
        Try
            ' SQL query to fetch order_id, no_of_items, and amount where user_id matches
            Dim query As String = "SELECT order_id, no_of_items, amount FROM [order] WHERE user_id = @userId"

            ' Create a DataTable to hold the query results
            Dim ordersTable As New DataTable()

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@userId", userId)

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
            DataGridView1.Columns("no_of_items").HeaderText = "No of Items"
            DataGridView1.Columns("amount").HeaderText = "Amount"
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class