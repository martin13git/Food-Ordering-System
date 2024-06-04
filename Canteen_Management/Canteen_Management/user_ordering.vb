Imports System.Data.SqlClient

Public Class user_ordering
    Public total_amount As Decimal
    Public total_items As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer

        If Integer.TryParse(TextBox2.Text, number) AndAlso number > 0 Then
            ' Decrement the number by 1
            number -= 1
            ' Update TextBox2 with the new value
            TextBox2.Text = number.ToString()
        End If

        Try
            ' Parse numbers from TextBoxes
            Dim number1 As Integer
            Dim number2 As Integer
            If Integer.TryParse(TextBox1.Text, number1) AndAlso Integer.TryParse(TextBox2.Text, number2) Then
                ' Multiply the numbers
                Dim result As Integer = number1 * number2
                ' Display the result in Label5
                Label5.Text = "Amount: " & result.ToString()
            End If
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim number As Integer

        If Integer.TryParse(TextBox2.Text, number) Then
            ' Decrement the number by 1
            number += 1
            ' Update TextBox2 with the new value
            TextBox2.Text = number.ToString()
        End If

        Try
            ' Parse numbers from TextBoxes
            Dim number1 As Integer
            Dim number2 As Integer
            If Integer.TryParse(TextBox1.Text, number1) AndAlso Integer.TryParse(TextBox2.Text, number2) Then
                ' Multiply the numbers
                Dim result As Integer = number1 * number2
                ' Display the result in Label5
                Label5.Text = "Amount: " & result.ToString()
            End If
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub user_ordering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox()
    End Sub

    Private Sub PopulateComboBox()
        Try
            ' Define SQL query to fetch distinct categories from the menu table
            Dim query As String = "SELECT DISTINCT category FROM menu"

            ' Create a list to store the distinct categories
            Dim categories As New List(Of String)()

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()

                    ' Execute the query and read the results
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Add each distinct category to the list
                            categories.Add(reader.GetString(0))
                        End While
                    End Using
                End Using
            End Using

            ' Bind the list of categories to ComboBox1
            ComboBox1.DataSource = categories

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        FetchItemsByCategory(ComboBox1.SelectedItem.ToString())
    End Sub

    Private Sub FetchItemsByCategory(category As String)
        Try
            ' Define SQL query to fetch items from the menu table based on category
            Dim query As String = "SELECT item FROM menu WHERE category = @category"

            ' Create a list to store the items
            Dim items As New List(Of String)()

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameter for category
                    cmd.Parameters.AddWithValue("@category", category)
                    conn.Open()

                    ' Execute the query and read the results
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Add each item to the list
                            items.Add(reader.GetString(0))
                        End While
                    End Using
                End Using
            End Using

            ComboBox2.DataSource = items

            ' Display the items (you can customize how to display the items)
            For Each item As String In items
                Console.WriteLine(item)
            Next

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        FetchPriceByItemAndCategory(ComboBox2.SelectedItem.ToString(), ComboBox1.SelectedItem.ToString())
    End Sub

    Private Sub FetchPriceByItemAndCategory(item As String, category As String)
        Try
            ' Define SQL query to fetch price from the menu table based on item and category
            Dim query As String = "SELECT price FROM menu WHERE item = @item AND category = @category"

            ' Create SqlConnection and SqlCommand
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters for item and category
                    cmd.Parameters.AddWithValue("@item", item)
                    cmd.Parameters.AddWithValue("@category", category)
                    conn.Open()

                    ' Execute the query and get the price
                    Dim price As Object = cmd.ExecuteScalar()

                    ' Check if price is not null
                    If price IsNot Nothing AndAlso Not DBNull.Value.Equals(price) Then
                        ' Display the price
                        TextBox1.Text = $"{Convert.ToDecimal(price)}"
                    Else
                        ' Handle case where price is not found
                        MessageBox.Show($"Price of {item} in {category} not found.")
                    End If
                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Parse price and quantity
            Dim price As Decimal
            Dim quantity As Integer
            If Not Decimal.TryParse(TextBox1.Text, price) Then
                MessageBox.Show("Please enter a valid price.")
                Return
            End If
            If Not Integer.TryParse(TextBox2.Text, quantity) Then
                MessageBox.Show("Please enter a valid quantity.")
                Return
            End If

            ' Add row to DataGridView
            Dim serialNo As Integer = DataGridView1.Rows.Count + 1 ' Increment serial number
            Dim item As String = ComboBox2.SelectedItem.ToString()

            ' Add the row with data
            DataGridView1.Rows.Add(serialNo, item, price, quantity)
            CalculateTotal()

        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Check if any row is selected
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Display confirmation message
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' If user confirms deletion, remove the selected row
                If result = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
                    CalculateTotal()
                End If
            Else
                MessageBox.Show("Please select a row to delete.")
            End If
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            ' Display confirmation message
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete all rows?", "Confirm Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If user confirms deletion, clear all rows
            If result = DialogResult.Yes Then
                DataGridView1.Rows.Clear()
            End If
            Label6.Text = "Amount: "
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Function CalculateTotal() As Decimal
        Dim total As Decimal = 0D

        Try
            ' Iterate through each row in DataGridView1
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then ' Ignore the new row placeholder
                    ' Retrieve the Price and Quantity values
                    Dim price As Decimal
                    Dim quantity As Integer

                    ' Check for valid Price and Quantity values
                    If Decimal.TryParse(row.Cells("Price").Value?.ToString(), price) AndAlso Integer.TryParse(row.Cells("Qty").Value?.ToString(), quantity) Then
                        ' Multiply Price and Quantity and add to total
                        total += price * quantity
                    End If
                End If
            Next
            Label6.Text = "Amount: " & total.ToString("C")
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Return total
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total_amount = CalculateTotal()
        total_items = SumQuantity()
        Try
            DataGridView1.Rows.Clear()
            Label6.Text = "Amount: "
            Me.Hide()
            user_dashboard.switchpanel(admin_userview)
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
        user_dashboard.switchpanel(checkout)
    End Sub

    Private Function SumQuantity() As Integer
        Dim totalQty As Integer = 0

        Try
            ' Iterate through each row in DataGridView1
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then ' Ignore the new row placeholder
                    ' Retrieve the Quantity value
                    Dim quantity As Integer

                    ' Check for valid Quantity value
                    If Integer.TryParse(row.Cells("Qty").Value?.ToString(), quantity) Then
                        ' Add Quantity to total
                        totalQty += quantity
                    End If
                End If
            Next
        Catch ex As Exception
            ' Handle any errors that may have occurred
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Return totalQty
    End Function
End Class