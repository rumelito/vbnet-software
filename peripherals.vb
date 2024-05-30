Imports MySql.Data.MySqlClient

Public Class Peripherals
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader

    Sub Switchpanel(ByVal panel As Form)
        panel.TopLevel = False
        panel.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = True
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = False
        Dashboard.DataGridView7.Visible = False
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = True
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel1.Text = "Display"
        Dashboard.DataGridView11.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel1.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView11.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel12.Visible = True
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = False


        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = False
        Dashboard.DataGridView7.Visible = False
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = True
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel4.Text = "Keyboard"
        Dashboard.DataGridView12.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel4.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView12.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dashboard.Switchpanel2(Searchfrm)
        Dashboard.Panel4.Visible = False
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel13.Visible = True
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = False


        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = False
        Dashboard.DataGridView7.Visible = False
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = True
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel5.Text = "Mouse"
        Dashboard.DataGridView13.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel5.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView13.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dashboard.Switchpanel2(Searchfrm)
        Dashboard.Panel4.Visible = False
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = True
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = False
        Dashboard.DataGridView7.Visible = False
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = True
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel6.Text = "Headset"
        Dashboard.DataGridView14.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel6.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView14.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel15.Visible = True
        Searchfrm.Panel16.Visible = False


        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = False
        Dashboard.DataGridView7.Visible = False
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = True
        Dashboard.DataGridView16.Visible = False
        Panel12.Text = "Speaker"
        Dashboard.DataGridView15.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel12.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView15.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = True


        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = False
        Dashboard.DataGridView7.Visible = False
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = True
        Panel13.Text = "Web Digital Camera"
        Dashboard.DataGridView16.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel13.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView16.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class