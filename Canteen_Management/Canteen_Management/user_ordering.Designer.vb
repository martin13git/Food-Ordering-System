<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_ordering
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 155)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(226, 28)
        Me.ComboBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 224)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 26)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Item, Me.Price, Me.Qty})
        Me.DataGridView1.Location = New System.Drawing.Point(244, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(565, 356)
        Me.DataGridView1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(54, 298)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 26)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = "1"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 26)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Amount:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(54, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 45)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Add to Cart"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.HeaderText = "Sr. No."
        Me.ID.MinimumWidth = 8
        Me.ID.Name = "ID"
        Me.ID.Width = 45
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 8
        Me.Item.Name = "Item"
        Me.Item.Width = 140
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 8
        Me.Price.Name = "Price"
        Me.Price.Width = 90
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MinimumWidth = 8
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 70
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCoral
        Me.Button4.Location = New System.Drawing.Point(819, 339)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 40)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Remove"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PowderBlue
        Me.Button5.Location = New System.Drawing.Point(819, 413)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(191, 68)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Proceed to CheckOut"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Location = New System.Drawing.Point(819, 293)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(191, 40)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Clear All"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(815, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Amount:"
        '
        'user_ordering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 493)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "user_ordering"
        Me.Text = "user_ordering"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
End Class
