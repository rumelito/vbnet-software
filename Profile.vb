Imports MySql.Data.MySqlClient

Public Class Profile
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader
    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub
    Public Sub DGV_load()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users where uname = '" & Home.lblUSER.Text & "'", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                Label8.Text = dr.GetValue(0)
                Label7.Text = dr.GetValue(1)
                Label6.Text = dr.GetValue(2)
                Label5.Text = dr.GetValue(3)
                TextBox1.Text = dr.GetValue(4)
                Label9.Text = dr.GetValue(5)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try






    End Sub


End Class