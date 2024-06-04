<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_profile
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
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(199, 250)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(363, 26)
        Me.TextBox4.TabIndex = 32
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(333, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 42)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Phone No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Date Of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(199, 179)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(363, 26)
        Me.TextBox3.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(199, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(363, 26)
        Me.TextBox2.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(199, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(363, 26)
        Me.DateTimePicker1.TabIndex = 24
        '
        'user_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 356)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "user_profile"
        Me.Text = "user_profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
