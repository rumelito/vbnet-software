Imports MySql.Data.MySqlClient
Imports Mysqlx.Notice
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Forgot

    Private Sub Btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click

        Dim unamein As String = txtusernamein.Text.Trim()
        Dim upassin As String = txtpasswordin.Text.Trim()

        If (unamein = "") Then

            MessageBox.Show("Firstname is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        If (upassin = "") Then

            MessageBox.Show("Lastname is Required!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")

        conn.Open()

        Dim cmd = New MySqlCommand("SELECT * FROM users where fname=@fname AND lname=@lname", conn)
        'Dim hashedPassword As String = HashPasswordMD5("upass")
        'TextBox1.Text = hashedPassword

        With cmd.Parameters
            .AddWithValue("fname", txtusernamein.Text.Trim())
            .AddWithValue("lname", txtpasswordin.Text.Trim())
        End With

        Dim reader As MySqlDataReader = cmd.ExecuteReader

        If reader.Read Then

            MessageBox.Show("Your Password is: " & reader.Item("upass"), "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
        Else

            MessageBox.Show("No data Found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Usertype.Show()
    End Sub

    Private Sub Lblexit_Click(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub

    Public Sub Clear()
        txtusernamein.Clear()
        txtpasswordin.Clear()
    End Sub
End Class