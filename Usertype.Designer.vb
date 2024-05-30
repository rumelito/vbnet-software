<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usertype
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblexit = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pcat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpasswordin = New System.Windows.Forms.TextBox()
        Me.btnsignin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.showpass = New System.Windows.Forms.CheckBox()
        Me.txtusernamein = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 40)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Login"
        '
        'lblexit
        '
        Me.lblexit.AutoSize = True
        Me.lblexit.BackColor = System.Drawing.Color.Transparent
        Me.lblexit.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexit.ForeColor = System.Drawing.Color.Red
        Me.lblexit.Location = New System.Drawing.Point(746, 25)
        Me.lblexit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblexit.Name = "lblexit"
        Me.lblexit.Size = New System.Drawing.Size(29, 25)
        Me.lblexit.TabIndex = 26
        Me.lblexit.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(19, 399)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Need an account? Register here!"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.pcat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtpasswordin)
        Me.GroupBox1.Controls.Add(Me.btnsignin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.showpass)
        Me.GroupBox1.Controls.Add(Me.txtusernamein)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(406, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(358, 436)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'pcat
        '
        Me.pcat.BackColor = System.Drawing.SystemColors.Control
        Me.pcat.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcat.FormattingEnabled = True
        Me.pcat.Items.AddRange(New Object() {"Admin", "Costumer"})
        Me.pcat.Location = New System.Drawing.Point(22, 288)
        Me.pcat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pcat.Name = "pcat"
        Me.pcat.Size = New System.Drawing.Size(312, 27)
        Me.pcat.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 258)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "User type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(19, 366)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Forgot Password?"
        '
        'txtpasswordin
        '
        Me.txtpasswordin.BackColor = System.Drawing.SystemColors.Control
        Me.txtpasswordin.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswordin.Location = New System.Drawing.Point(22, 188)
        Me.txtpasswordin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpasswordin.Name = "txtpasswordin"
        Me.txtpasswordin.Size = New System.Drawing.Size(312, 24)
        Me.txtpasswordin.TabIndex = 28
        Me.txtpasswordin.UseSystemPasswordChar = True
        '
        'btnsignin
        '
        Me.btnsignin.BackColor = System.Drawing.Color.LimeGreen
        Me.btnsignin.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignin.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsignin.Location = New System.Drawing.Point(209, 341)
        Me.btnsignin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.Size = New System.Drawing.Size(124, 41)
        Me.btnsignin.TabIndex = 29
        Me.btnsignin.Text = "Sign In"
        Me.btnsignin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Password"
        '
        'showpass
        '
        Me.showpass.AutoSize = True
        Me.showpass.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpass.Location = New System.Drawing.Point(22, 223)
        Me.showpass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(119, 20)
        Me.showpass.TabIndex = 30
        Me.showpass.Text = "Show Password"
        Me.showpass.UseVisualStyleBackColor = True
        '
        'txtusernamein
        '
        Me.txtusernamein.BackColor = System.Drawing.SystemColors.Control
        Me.txtusernamein.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusernamein.Location = New System.Drawing.Point(22, 110)
        Me.txtusernamein.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtusernamein.Name = "txtusernamein"
        Me.txtusernamein.Size = New System.Drawing.Size(312, 24)
        Me.txtusernamein.TabIndex = 27
        Me.txtusernamein.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Test.My.Resources.Resources._438293690_756807072962619_7121699218052410435_n1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(23, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 430)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Usertype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.Test.My.Resources.Resources._360_F_283776631_OllPsanwnqswKzOtsvL86pEBGQlUFIsT3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 526)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Usertype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usertype"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblexit As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpasswordin As TextBox
    Friend WithEvents btnsignin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents showpass As CheckBox
    Friend WithEvents txtusernamein As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pcat As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
