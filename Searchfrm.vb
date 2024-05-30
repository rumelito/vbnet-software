Imports MySql.Data.MySqlClient

Public Class Searchfrm
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader
    Sub Switchpanel(ByVal panel2 As Form)
        panel2.TopLevel = False
        panel2.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dashboard.DataGridView1.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Processor' and productname like '%" & TextBox1.Text & "%' and stocks > 0", conn)
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
        ComboBox4.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dashboard.DataGridView1.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Processor' and chipset like '%" & ComboBox4.Text & "%' and stocks > 0", conn)
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
        TextBox1.Clear()

        ComboBox3.Text = ""
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dashboard.DataGridView1.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Processor' and model like '%" & ComboBox3.Text & "%' and stocks > 0", conn)
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
        TextBox1.Clear()

        ComboBox4.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dashboard.DataGridView2.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='CPU Cooler' and productname like '%" & TextBox2.Text & "%' and stocks > 0", conn)
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


        ComboBox5.Text = ""
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dashboard.DataGridView2.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='CPU Cooler' and brands like '%" & ComboBox5.Text & "%' and stocks > 0", conn)
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
        TextBox2.Clear()
    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs) Handles TextBox29.TextChanged
        Dashboard.DataGridView3.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Motherboard' and productname like '%" & TextBox29.Text & "%' and stocks > 0", conn)
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

        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dashboard.DataGridView3.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Motherboard' and brands like '%" & ComboBox1.Text & "%' and stocks > 0", conn)
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
        TextBox29.Clear()
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dashboard.DataGridView3.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Motherboard' and model like '%" & ComboBox2.Text & "%' and stocks > 0", conn)
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
        TextBox29.Clear()
        ComboBox1.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dashboard.DataGridView4.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Memory' and productname like '%" & TextBox3.Text & "%' and stocks > 0", conn)
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
        ComboBox8.Text = ""
        ComboBox7.Text = ""
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        Dashboard.DataGridView4.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Memory' and brands like '%" & ComboBox8.Text & "%' and stocks > 0", conn)
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
        TextBox3.Clear()
        ComboBox7.Text = ""
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Dashboard.DataGridView4.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Memory' and capacity like '%" & ComboBox7.Text & "%' and stocks > 0", conn)
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
        TextBox3.Clear()
        ComboBox8.Text = ""
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dashboard.DataGridView5.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Graphics Card' and productname like '%" & TextBox4.Text & "%' and stocks > 0", conn)
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
        ComboBox10.Text = ""
        ComboBox9.Text = ""
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged
        Dashboard.DataGridView5.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Graphics Card' and brands like '%" & ComboBox10.Text & "%' and stocks > 0", conn)
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
        TextBox4.Clear()
        ComboBox9.Text = ""
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        Dashboard.DataGridView5.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Graphics Card' and model like '%" & ComboBox9.Text & "%' and stocks > 0", conn)
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
        TextBox4.Clear()
        ComboBox10.Text = ""
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dashboard.DataGridView6.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Solid State Drive(M.2)' and productname like '%" & TextBox5.Text & "%' and stocks > 0", conn)
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
        ComboBox12.Text = ""
        ComboBox11.Text = ""
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged
        Dashboard.DataGridView6.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Solid State Drive(M.2)' and brands like '%" & ComboBox12.Text & "%' and stocks > 0", conn)
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
        TextBox5.Clear()
        ComboBox11.Text = ""
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged
        Dashboard.DataGridView6.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Solid State Drive(M.2)' and capacity like '%" & ComboBox11.Text & "%' and stocks > 0", conn)
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
        TextBox5.Clear()
        ComboBox12.Text = ""
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

        Dashboard.DataGridView7.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Solid State Drive(SATA)' and productname like '%" & TextBox6.Text & "%' and stocks > 0", conn)
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
        ComboBox14.Text = ""
        ComboBox13.Text = ""
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox14.SelectedIndexChanged
        Dashboard.DataGridView7.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Solid State Drive(SATA)' and brands like '%" & ComboBox14.Text & "%' and stocks > 0", conn)
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
        TextBox6.Clear()
        ComboBox13.Text = ""
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox13.SelectedIndexChanged
        Dashboard.DataGridView7.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Solid State Drive(SATA)' and capacity like '%" & ComboBox13.Text & "%' and stocks > 0", conn)
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
        TextBox6.Clear()
        ComboBox14.Text = ""
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dashboard.DataGridView8.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Hard Disk Drive' and productname like '%" & TextBox7.Text & "%' and stocks > 0", conn)
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
        ComboBox15.Text = ""
        ComboBox16.Text = ""
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox16.SelectedIndexChanged
        Dashboard.DataGridView8.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Hard Disk Drive' and brands like '%" & ComboBox16.Text & "%' and stocks > 0", conn)
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
        TextBox7.Clear()
        ComboBox15.Text = ""
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox15.SelectedIndexChanged
        Dashboard.DataGridView8.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Hard Disk Drive' and capacity like '%" & ComboBox15.Text & "%' and stocks > 0", conn)
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
        TextBox7.Clear()
        ComboBox16.Text = ""
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dashboard.DataGridView9.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Power Supply' and productname like '%" & TextBox8.Text & "%' and stocks > 0", conn)
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
        ComboBox18.Text = ""
        ComboBox17.Text = ""
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox18.SelectedIndexChanged
        Dashboard.DataGridView9.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Power Supply' and brands like '%" & ComboBox18.Text & "%' and stocks > 0", conn)
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
        TextBox8.Clear()
        ComboBox17.Text = ""
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox17.SelectedIndexChanged
        Dashboard.DataGridView9.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Power Supply' and watts like '%" & ComboBox17.Text & "%' and stocks > 0", conn)
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
        TextBox8.Clear()
        ComboBox18.Text = ""
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Dashboard.DataGridView10.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Case' and productname like '%" & TextBox9.Text & "%' and stocks > 0", conn)
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
        ComboBox20.Text = ""
        ComboBox19.Text = ""
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox20.SelectedIndexChanged
        Dashboard.DataGridView10.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Case' and brands like '%" & ComboBox20.Text & "%' and stocks > 0", conn)
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
        TextBox9.Clear()
        ComboBox19.Text = ""
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox19.SelectedIndexChanged
        Dashboard.DataGridView10.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Case' and formfactor like '%" & ComboBox19.Text & "%' and stocks > 0", conn)
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
        TextBox9.Clear()
        ComboBox20.Text = ""
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Dashboard.DataGridView11.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Display' and productname like '%" & TextBox10.Text & "%' and stocks > 0", conn)
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
        ComboBox21.Text = ""

    End Sub

    Private Sub ComboBox21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox21.SelectedIndexChanged
        Dashboard.DataGridView11.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Display' and brands like '%" & ComboBox21.Text & "%' and stocks > 0", conn)
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
        TextBox10.Clear()
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        Dashboard.DataGridView12.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Keyboard' and productname like '%" & TextBox13.Text & "%' and stocks > 0", conn)
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
        ComboBox27.Text = ""
    End Sub

    Private Sub ComboBox27_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox27.SelectedIndexChanged
        Dashboard.DataGridView12.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Keyboard' and brands like '%" & ComboBox27.Text & "%' and stocks > 0", conn)
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
        TextBox13.Clear()
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Dashboard.DataGridView13.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Mouse' and productname like '%" & TextBox11.Text & "%' and stocks > 0", conn)
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
        ComboBox23.Text = ""
    End Sub

    Private Sub ComboBox23_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox23.SelectedIndexChanged
        Dashboard.DataGridView13.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Mouse' and brands like '%" & ComboBox23.Text & "%' and stocks > 0", conn)
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
        TextBox11.Clear()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Dashboard.DataGridView14.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Headset' and productname like '%" & TextBox12.Text & "%' and stocks > 0", conn)
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
        ComboBox25.Text = ""
    End Sub

    Private Sub ComboBox25_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox25.SelectedIndexChanged
        Dashboard.DataGridView14.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Headset' and brands like '%" & ComboBox25.Text & "%' and stocks > 0", conn)
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
        TextBox12.Clear()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Dashboard.DataGridView15.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Speaker' and productname like '%" & TextBox14.Text & "%' and stocks > 0", conn)
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
        ComboBox29.Text = ""
    End Sub

    Private Sub ComboBox29_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox29.SelectedIndexChanged
        Dashboard.DataGridView15.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Speaker' and brands like '%" & ComboBox29.Text & "%' and stocks > 0", conn)
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
        TextBox14.Clear()
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        Dashboard.DataGridView16.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Web Digital Camera' and productname like '%" & TextBox15.Text & "%' and stocks > 0", conn)
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
        ComboBox31.Text = ""
    End Sub

    Private Sub ComboBox31_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox31.SelectedIndexChanged
        Dashboard.DataGridView16.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category='Web Digital Camera' and brands like '%" & ComboBox31.Text & "%' and stocks > 0", conn)
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
        TextBox15.Clear()
    End Sub

End Class