<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandingPage))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(56, 258)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 26)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(56, 342)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 26)
        Me.TextBox2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(694, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 644)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(92, 544)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 38)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Create Account"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(154, 374)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(148, 24)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(52, 486)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(129, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(125, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Welcome !"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 516)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(19, 605)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Admin Login"
        '
        'LandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1065, 634)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LandingPage"
        Me.Text = "LandingPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
