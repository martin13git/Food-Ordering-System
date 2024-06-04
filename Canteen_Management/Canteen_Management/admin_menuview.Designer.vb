<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_menuview
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(364, 38)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "View/Manage Menu Items"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(622, 414)
        Me.DataGridView1.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(640, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Item ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(640, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(640, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Item"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(644, 306)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(363, 26)
        Me.TextBox3.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(644, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(363, 26)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(644, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(363, 26)
        Me.TextBox1.TabIndex = 28
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Fast Food", "Cold Drinks", "Pizza", "Taco", "Rice", "Noodles", "Main Course", "Desserts", "Side Dishes"})
        Me.ComboBox1.Location = New System.Drawing.Point(644, 237)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(363, 28)
        Me.ComboBox1.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(772, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 39)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Add/Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'admin_menuview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 493)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "admin_menuview"
        Me.Text = "admin_menuview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
