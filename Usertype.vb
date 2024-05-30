Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Usertype
    Private Sub Btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        Dim unamein As String = txtusernamein.Text.Trim()
        Dim upassin As String = txtpasswordin.Text.Trim()
        Dim usertype As String = pcat.Text

        If (unamein = "") Then

            MessageBox.Show("Username is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If (upassin = "") Then

            MessageBox.Show("Password is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If (usertype = "") Then

            MessageBox.Show("Usertype is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        If (pcat.Text = "Costumer") Then
            Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM users where uname=@uname AND upass=@upass And usertype=@usertype", conn)
            'Dim hashedPassword As String = HashPasswordMD5("upass")
            'txtpasswordin.Text = hashedPassword
            With cmd.Parameters
                .AddWithValue("uname", txtusernamein.Text.Trim())
                .AddWithValue("upass", txtpasswordin.Text)
                .AddWithValue("usertype", pcat.Text.Trim())
            End With

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then

                MessageBox.Show("Logined Succesfully!", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Home.Show()
                Account.DGV_load()
                Addtocart.DGV_load()
                Customers.DGV_load()


                Me.Close()
            Else
                MessageBox.Show("Wrong Username or Password or Usertype!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        ElseIf (pcat.Text = "Admin") Then
            Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM users where uname=@uname AND upass=@upass AND usertype=@usertype", conn)
            'Dim hashedPassword As String = HashPasswordMD5("upass")
            'txtpasswordin.Text = hashedPassword
            With cmd.Parameters
                .AddWithValue("uname", txtusernamein.Text.Trim())
                .AddWithValue("upass", txtpasswordin.Text)
                .AddWithValue("usertype", pcat.Text.Trim())
            End With

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then

                MessageBox.Show("Logined Succesfully!", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ADMIN.Show()
                Transaction.DGV_load()
                Me.Close()

            Else
                MessageBox.Show("Wrong Username or Password or Usertype!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        End If

    End Sub

    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked Then
            txtpasswordin.UseSystemPasswordChar = False
        Else
            txtpasswordin.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Lblexit_Click(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        registerform.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
        forgot.Show()
    End Sub

End Class