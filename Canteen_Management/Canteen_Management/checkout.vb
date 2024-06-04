Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class checkout
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "UPI" Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Decimal = user_ordering.total_amount
        Dim totalQty As Integer = user_ordering.total_items

        ' Assuming you have userID from the context
        Dim userID As Integer = LandingPage.user_id_now
        Dim orderId As Integer = InsertOrder(userID, totalQty, total)

        ' Optionally, you can use the returned orderId for further processing
    End Sub

    Private Function InsertOrder(userID As Integer, noofitems As Integer, totalamount As Decimal) As Integer
        Dim orderId As Integer = -1

        Try
            ' SQL query to insert a new order and return the inserted order_id
            Dim query As String = "INSERT INTO [order] (user_id, no_of_items, amount) " &
                              "VALUES (@userID, @noofitems, @totalamount); " &
                              "SELECT SCOPE_IDENTITY();"

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@userID", userID)
                    cmd.Parameters.AddWithValue("@noofitems", noofitems)
                    cmd.Parameters.AddWithValue("@totalamount", totalamount)

                    ' Open the connection, execute the query and fetch the order_id
                    conn.Open()
                    orderId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            ' Show success message with order_id
            MessageBox.Show("Order inserted successfully! Order ID: " & orderId)
            Me.Close()
            user_ordering.Close()
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Return orderId
    End Function

    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Amount Payable: " & user_ordering.total_amount
    End Sub
End Class