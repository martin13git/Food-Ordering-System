<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_userview
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(622, 398)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(865, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add New User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(640, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Phone No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(640, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(640, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Date Of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(644, 323)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(363, 26)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(644, 185)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(363, 26)
        Me.TextBox2.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(644, 254)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(363, 26)
        Me.DateTimePicker1.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(644, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(363, 26)
        Me.TextBox1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(778, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 42)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(644, 394)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(363, 26)
        Me.TextBox4.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(640, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "User ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(393, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(277, 38)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "View/Manage Users"
        '
        'admin_userview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 493)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "admin_userview"
        Me.Text = "admin_userview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
