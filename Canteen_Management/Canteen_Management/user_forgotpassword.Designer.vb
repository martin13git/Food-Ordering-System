<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_forgotpassword
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 428)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 46)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Reset Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Re-Enter Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enter Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Date of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "User ID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(94, 183)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(314, 26)
        Me.DateTimePicker1.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(94, 351)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(314, 26)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 278)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(314, 26)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 26)
        Me.TextBox1.TabIndex = 9
        '
        'user_forgotpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 551)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "user_forgotpassword"
        Me.Text = "user_forgotpassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
