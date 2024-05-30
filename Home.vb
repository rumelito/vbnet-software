Imports MySql.Data.MySqlClient

Public Class Home
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader
    Sub Switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Switchpanel(Dashboard)
        Button9.Enabled = False
        Button8.Enabled = True
        Button7.Enabled = True
        PictureBox1.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Switchpanel(Customers)
        Button9.Enabled = True
        Button8.Enabled = False
        Button7.Enabled = True
        PictureBox1.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Switchpanel(Addtocart)
        Addtocart.DGV_load()
        Button9.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = False
        PictureBox1.Enabled = True
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switchpanel(Dashboard)
        Button9.Enabled = False
        Button8.Enabled = True
        Button7.Enabled = True
        PictureBox1.Enabled = True

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users where uname = '" & Usertype.txtusernamein.Text & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                lblUSER.Text = dr.GetValue(3)
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Lblexit_Click(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub

    Private Sub Btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        Addtocart.DataGridView2.Rows.Clear()
        Dashboard.Clearrrr()
        Me.Close()
        Usertype.Show()
        Usertype.txtusernamein.Clear()
        Usertype.txtpasswordin.Clear()
        Usertype.pcat.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Switchpanel(Adaccount)
        Button9.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True
        PictureBox1.Enabled = False
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Switchpanel(Addtocart)
        Button9.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = False
        PictureBox1.Enabled = True
    End Sub
End Class