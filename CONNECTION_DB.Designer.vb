<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CONNECTION_DB
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
        Me.btndbtest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblexit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btndbtest
        '
        Me.btndbtest.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndbtest.Location = New System.Drawing.Point(163, 242)
        Me.btndbtest.Name = "btndbtest"
        Me.btndbtest.Size = New System.Drawing.Size(126, 56)
        Me.btndbtest.TabIndex = 0
        Me.btndbtest.Text = "TEST"
        Me.btndbtest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATABASE CONNECTION"
        '
        'lblexit
        '
        Me.lblexit.AutoSize = True
        Me.lblexit.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexit.ForeColor = System.Drawing.Color.Red
        Me.lblexit.Location = New System.Drawing.Point(394, 27)
        Me.lblexit.Name = "lblexit"
        Me.lblexit.Size = New System.Drawing.Size(36, 32)
        Me.lblexit.TabIndex = 3
        Me.lblexit.Text = "X"
        '
        'CONNECTION_DB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 450)
        Me.Controls.Add(Me.lblexit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndbtest)
        Me.Name = "CONNECTION_DB"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndbtest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblexit As Label
End Class
