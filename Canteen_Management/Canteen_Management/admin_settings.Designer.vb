<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_settings
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Re-Enter New Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Enter New Password"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(56, 341)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(363, 26)
        Me.TextBox5.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(56, 242)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(363, 26)
        Me.TextBox4.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Enter Old Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(56, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(363, 26)
        Me.TextBox1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 48)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'admin_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 493)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Name = "admin_settings"
        Me.Text = "admin_settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
