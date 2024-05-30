<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registerform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtusernameup = New System.Windows.Forms.TextBox()
        Me.txtpasswordup = New System.Windows.Forms.TextBox()
        Me.btnsignup = New System.Windows.Forms.Button()
        Me.showpass = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblexit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtconpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusernameup
        '
        Me.txtusernameup.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusernameup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtusernameup.Location = New System.Drawing.Point(18, 271)
        Me.txtusernameup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtusernameup.Name = "txtusernameup"
        Me.txtusernameup.Size = New System.Drawing.Size(319, 24)
        Me.txtusernameup.TabIndex = 3
        '
        'txtpasswordup
        '
        Me.txtpasswordup.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswordup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpasswordup.Location = New System.Drawing.Point(18, 352)
        Me.txtpasswordup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpasswordup.Name = "txtpasswordup"
        Me.txtpasswordup.Size = New System.Drawing.Size(319, 24)
        Me.txtpasswordup.TabIndex = 4
        Me.txtpasswordup.UseSystemPasswordChar = True
        '
        'btnsignup
        '
        Me.btnsignup.BackColor = System.Drawing.Color.LimeGreen
        Me.btnsignup.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsignup.Location = New System.Drawing.Point(242, 523)
        Me.btnsignup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(94, 41)
        Me.btnsignup.TabIndex = 7
        Me.btnsignup.Text = "SIGN UP"
        Me.btnsignup.UseVisualStyleBackColor = False
        '
        'showpass
        '
        Me.showpass.AutoSize = True
        Me.showpass.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpass.Location = New System.Drawing.Point(18, 399)
        Me.showpass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(141, 22)
        Me.showpass.TabIndex = 8
        Me.showpass.Text = "Show Password"
        Me.showpass.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 239)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 316)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Password"
        '
        'lblexit
        '
        Me.lblexit.AutoSize = True
        Me.lblexit.BackColor = System.Drawing.Color.Transparent
        Me.lblexit.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexit.ForeColor = System.Drawing.Color.Red
        Me.lblexit.Location = New System.Drawing.Point(747, 7)
        Me.lblexit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblexit.Name = "lblexit"
        Me.lblexit.Size = New System.Drawing.Size(29, 25)
        Me.lblexit.TabIndex = 17
        Me.lblexit.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(43, 535)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Already have accounts"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtconpass)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnsignup)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.showpass)
        Me.GroupBox1.Controls.Add(Me.txtpasswordup)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtusernameup)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(410, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(358, 610)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'txtconpass
        '
        Me.txtconpass.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconpass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtconpass.Location = New System.Drawing.Point(18, 470)
        Me.txtconpass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtconpass.Name = "txtconpass"
        Me.txtconpass.Size = New System.Drawing.Size(319, 24)
        Me.txtconpass.TabIndex = 29
        Me.txtconpass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 435)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Confirm Password"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtlname.Location = New System.Drawing.Point(18, 195)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(320, 24)
        Me.txtlname.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Last Name"
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfname.Location = New System.Drawing.Point(18, 115)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(319, 24)
        Me.txtfname.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 40)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Register"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(2, 24)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.UseSystemPasswordChar = True
        Me.TextBox1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Test.My.Resources.Resources._438293690_756807072962619_7121699218052410435_n
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(26, 130)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 436)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Registerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.Test.My.Resources.Resources._360_F_283776631_OllPsanwnqswKzOtsvL86pEBGQlUFIsT2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 718)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Registerform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusernameup As TextBox
    Friend WithEvents txtpasswordup As TextBox
    Friend WithEvents btnsignup As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblexit As Label
    Friend WithEvents showpass As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtconpass As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
