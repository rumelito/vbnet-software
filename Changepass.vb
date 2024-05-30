Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Changepass

    Private Sub Btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        If (txtfname.Text = "") Then
            MsgBox("Old Password is Required!", vbExclamation)
            Return
        End If

        If (txtlname.Text = "") Then
            MsgBox("New Password is Required!", vbExclamation)
            Return
        End If

        If (txtconpass.Text = "") Then
            MsgBox("Confirm Password is Required!", vbExclamation)
            Return
        End If

        If (txtlname.Text <> txtconpass.Text) Then
            MsgBox("Your Password is not Match!", vbExclamation)
            Return
        End If

        Try
            Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE users SET upass=@upass WHERE costumer_id = '" & Customers.Label3.Text & "' AND upass = '" & txtfname.Text & "' ", conn)
            'Dim hashedPassword As String = HashPasswordMD5("upass")
            'txtfname.Text = hashedPassword

            'Dim hashedPassword2 As String = HashPasswordMD5("upass")
            'txtconpass.Text = hashedPassword2

            'Dim hashedPassword1 As String = HashPasswordMD5("upass")
            'txtlname.Text = hashedPassword1

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@upass", txtlname.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Updated Success!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Profile.DGV_load()
                clear()
            Else

                MessageBox.Show("Record Update Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub Clear()
        txtfname.Clear()
        txtlname.Clear()
        txtconpass.Clear()
    End Sub


End Class