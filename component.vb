Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Component
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader


    Sub Switchpanel(ByVal panel As Form)
        panel.TopLevel = False
        panel.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = True
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
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = True
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
        Dashboard.DataGridView16.Visible = False
        Panel1.Text = "Processor"
        Dashboard.DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel1.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView1.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
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
        Searchfrm.Panel2.Visible = True
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
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = True
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
        Dashboard.DataGridView16.Visible = False
        Panel4.Text = "CPU Cooler"

        Dashboard.DataGridView2.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel4.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView2.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = True
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
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = True
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
        Dashboard.DataGridView16.Visible = False
        Panel5.Text = "Motherboard"

        Dashboard.DataGridView3.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel5.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView3.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = True
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
        Searchfrm.Panel16.Visible = False


        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = True
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
        Dashboard.DataGridView16.Visible = False
        Panel6.Text = "Memory"
        Dashboard.DataGridView4.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel6.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView4.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
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
        Searchfrm.Panel5.Visible = True
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
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = True
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
        Dashboard.DataGridView16.Visible = False
        Panel12.Text = "Graphics Card"
        Dashboard.DataGridView5.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel12.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView5.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
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
        Searchfrm.Panel6.Visible = True
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = True
        Dashboard.DataGridView7.Visible = False
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel13.Text = "Solid State Drive(M.2)"
        Dashboard.DataGridView6.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel13.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView6.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = True
        Searchfrm.Panel8.Visible = False
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = False

        Dashboard.Panel2.Visible = False
        Dashboard.DataGridView1.Visible = False
        Dashboard.DataGridView2.Visible = False
        Dashboard.DataGridView3.Visible = False
        Dashboard.DataGridView4.Visible = False
        Dashboard.DataGridView5.Visible = False
        Dashboard.DataGridView6.Visible = False
        Dashboard.DataGridView7.Visible = True
        Dashboard.DataGridView8.Visible = False
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel14.Text = "Solid State Drive(SATA)"
        Dashboard.DataGridView7.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel14.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView7.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Dashboard.Panel4.Visible = False
        Dashboard.Switchpanel2(Searchfrm)
        Searchfrm.Panel1.Visible = False
        Searchfrm.Panel2.Visible = False
        Searchfrm.Panel3.Visible = False
        Searchfrm.Panel4.Visible = False
        Searchfrm.Panel5.Visible = False
        Searchfrm.Panel6.Visible = False
        Searchfrm.Panel7.Visible = False
        Searchfrm.Panel8.Visible = True
        Searchfrm.Panel9.Visible = False
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
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
        Dashboard.DataGridView8.Visible = True
        Dashboard.DataGridView9.Visible = False
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel15.Text = "Hard Disk Drive"
        Dashboard.DataGridView8.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel15.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView8.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
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
        Searchfrm.Panel9.Visible = True
        Searchfrm.Panel10.Visible = False
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
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
        Dashboard.DataGridView9.Visible = True
        Dashboard.DataGridView10.Visible = False
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel16.Text = "Power Supply"
        Dashboard.DataGridView9.Rows.Clear()
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel16.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView9.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
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
        Searchfrm.Panel10.Visible = True
        Searchfrm.Panel11.Visible = False
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
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
        Dashboard.DataGridView10.Visible = True
        Dashboard.DataGridView11.Visible = False
        Dashboard.DataGridView12.Visible = False
        Dashboard.DataGridView13.Visible = False
        Dashboard.DataGridView14.Visible = False
        Dashboard.DataGridView15.Visible = False
        Dashboard.DataGridView16.Visible = False
        Panel17.Text = "Case"
        Dashboard.DataGridView10.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & Panel17.Text & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dashboard.DataGridView10.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class