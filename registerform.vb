Imports System.Runtime.Versioning
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Security

Public Class Registerform
    Private Sub Lblexit_Click(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub

    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked Then
            txtpasswordup.UseSystemPasswordChar = False
        Else
            txtpasswordup.UseSystemPasswordChar = True
        End If
        If showpass.Checked Then
            txtconpass.UseSystemPasswordChar = False
        Else
            txtconpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Dim fname As String = txtfname.Text.Trim()
        Dim lname As String = txtlname.Text.Trim()
        Dim uname As String = txtusernameup.Text.Trim()
        Dim upass As String = txtpasswordup.Text.Trim()
        Dim conpass As String = txtconpass.Text.Trim()
        TextBox1.Text = "Costumer"

        If (fname = "") Then

            MessageBox.Show("First Name is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If (lname = "") Then

            MessageBox.Show("Last Name is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If (uname = "") Then

            MessageBox.Show("Username is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If (upass = "") Then

            MessageBox.Show("Password is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If (conpass = "") Then

            MessageBox.Show("Confirm Password is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        If (upass <> conpass) Then

            MessageBox.Show("Your Password is not Match!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If



        If (DBConnect()) Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO users(fname,lname,uname,upass,usertype) VALUES (@fname,@lname,@uname,@upass,@usertype)", conn)
                'Dim hashedPassword As String = HashPasswordMD5("upass")
                'txtpasswordup.Text = hashedPassword
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@fname", txtfname.Text.Trim())
                cmd.Parameters.AddWithValue("@lname", txtlname.Text.Trim())
                cmd.Parameters.AddWithValue("@uname", txtusernameup.Text.Trim())
                cmd.Parameters.AddWithValue("@upass", txtpasswordup.Text)
                cmd.Parameters.AddWithValue("@usertype", TextBox1.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then

                    MessageBox.Show("Registered Succesfully!", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Usertype.Show()

                    Adcostumers.DGV_load()
                    Addashboard.Total_users()

                    Me.Close()
                Else

                    MessageBox.Show("Could not register!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Usertype.Show()
    End Sub


End Class