<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Changepass
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
        Me.txtconpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsignup = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtconpass
        '
        Me.txtconpass.BackColor = System.Drawing.SystemColors.Control
        Me.txtconpass.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconpass.Location = New System.Drawing.Point(305, 245)
        Me.txtconpass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtconpass.Name = "txtconpass"
        Me.txtconpass.Size = New System.Drawing.Size(319, 24)
        Me.txtconpass.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Confirm Password"
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.SystemColors.Control
        Me.txtlname.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(305, 194)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(320, 24)
        Me.txtlname.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "New Password"
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.SystemColors.Control
        Me.txtfname.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(305, 140)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(319, 24)
        Me.txtfname.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Old Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 40)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Change Password"
        '
        'btnsignup
        '
        Me.btnsignup.BackColor = System.Drawing.Color.LimeGreen
        Me.btnsignup.Font = New System.Drawing.Font("Bookman Old Style", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsignup.Location = New System.Drawing.Point(500, 308)
        Me.btnsignup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(124, 41)
        Me.btnsignup.TabIndex = 34
        Me.btnsignup.Text = "Save"
        Me.btnsignup.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtconpass)
        Me.Panel2.Controls.Add(Me.btnsignup)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtlname)
        Me.Panel2.Controls.Add(Me.txtfname)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(81, 73)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 424)
        Me.Panel2.TabIndex = 43
        '
        'Changepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1514, 884)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Changepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changepass"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtconpass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsignup As Button
    Friend WithEvents Panel2 As Panel
End Class
