
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle

Public Class Dashboard
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader

    Dim myb, comi, pere, summ As String
    Dim subtotal, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, p11, p12, p13, p14, p15, p16 As Double

    Sub Switchpanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub Switchpanel1(ByVal panel1 As Form)
        Panel2.Controls.Clear()
        panel1.TopLevel = False
        Panel2.Controls.Add(panel1)
        panel1.Show()
    End Sub

    Sub Switchpanel2(ByVal panel2 As Form)
        Panel3.Controls.Clear()
        panel2.TopLevel = False
        Panel3.Controls.Add(panel2)
        panel2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Switchpanel2(Searchfrm)
        Label13.Visible = True
        Label12.Visible = False
        Panel4.Visible = False

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

        Panel2.Visible = False
        Switchpanel(Component)
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False
        DataGridView5.Visible = False
        DataGridView6.Visible = False
        DataGridView7.Visible = False
        DataGridView8.Visible = False
        DataGridView9.Visible = False
        DataGridView10.Visible = False
        DataGridView11.Visible = False
        DataGridView12.Visible = False
        DataGridView13.Visible = False
        DataGridView14.Visible = False
        DataGridView15.Visible = False
        DataGridView16.Visible = False
        comi = "Processor"
        DataGridView1.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & comi & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switchpanel2(Searchfrm)
        Label13.Visible = True
        Label12.Visible = False

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

        Switchpanel(Component)
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False
        DataGridView5.Visible = False
        DataGridView6.Visible = False
        DataGridView7.Visible = False
        DataGridView8.Visible = False
        DataGridView9.Visible = False
        DataGridView10.Visible = False
        DataGridView11.Visible = False
        DataGridView12.Visible = False
        DataGridView13.Visible = False
        DataGridView14.Visible = False
        DataGridView15.Visible = False
        DataGridView16.Visible = False
        myb = "Processor"

        DataGridView1.Rows.Clear()
        Try


            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & myb & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clearrrr()


    End Sub

    Sub Clearrrr()
        Panel4.Visible = False
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar3.Value = 0
        ProgressBar4.Value = 0
        ProgressBar5.Value = 0
        ProgressBar6.Value = 0

        Component.PictureBox1.Image = My.Resources.processor_green3
        Component.PictureBox4.Image = My.Resources.DSADAS
        Component.PictureBox5.Image = My.Resources.motherboard_green
        Component.PictureBox6.Image = My.Resources.memory_green
        Component.PictureBox11.Image = My.Resources.graphic_card_green
        Component.PictureBox12.Image = My.Resources.solid_state_drive_green__1_
        Component.PictureBox2.Image = My.Resources.solid_state_drive_green__1_
        Component.PictureBox14.Image = My.Resources.hdd_green
        Component.PictureBox15.Image = My.Resources.power_supply_green
        Component.PictureBox16.Image = My.Resources.computer_tower_green1
        Peripherals.PictureBox1.Image = My.Resources.display
        Peripherals.PictureBox4.Image = My.Resources.computer_keyboard
        Peripherals.PictureBox5.Image = My.Resources.mouse
        Peripherals.PictureBox6.Image = My.Resources.headset
        Peripherals.PictureBox11.Image = My.Resources.speaker
        Peripherals.PictureBox12.Image = My.Resources.web_cam

        Component.TextBox3.Clear()
        Component.pprice.Clear()
        Component.pstocks.Clear()

        Component.TextBox6.Clear()
        Component.TextBox2.Clear()
        Component.TextBox1.Clear()

        Component.TextBox7.Clear()
        Component.TextBox5.Clear()
        Component.TextBox4.Clear()

        Component.TextBox8.Clear()
        Component.TextBox10.Clear()
        Component.TextBox9.Clear()

        Component.TextBox11.Clear()
        Component.TextBox13.Clear()
        Component.TextBox12.Clear()

        Component.TextBox14.Clear()
        Component.TextBox16.Clear()
        Component.TextBox15.Clear()

        Component.TextBox17.Clear()
        Component.TextBox19.Clear()
        Component.TextBox18.Clear()

        Component.TextBox20.Clear()
        Component.TextBox22.Clear()
        Component.TextBox21.Clear()

        Component.TextBox23.Clear()
        Component.TextBox25.Clear()
        Component.TextBox24.Clear()

        Component.TextBox26.Clear()
        Component.TextBox28.Clear()
        Component.TextBox27.Clear()

        Peripherals.TextBox3.Clear()
        Peripherals.pprice.Clear()
        Peripherals.pstocks.Clear()

        Peripherals.TextBox1.Clear()
        Peripherals.TextBox4.Clear()
        Peripherals.TextBox2.Clear()

        Peripherals.TextBox5.Clear()
        Peripherals.TextBox7.Clear()
        Peripherals.TextBox6.Clear()

        Peripherals.TextBox8.Clear()
        Peripherals.TextBox10.Clear()
        Peripherals.TextBox9.Clear()

        Peripherals.TextBox11.Clear()
        Peripherals.TextBox13.Clear()
        Peripherals.TextBox12.Clear()

        Peripherals.TextBox14.Clear()
        Peripherals.TextBox16.Clear()
        Peripherals.TextBox15.Clear()

        Label4.Text = "0.00"

        Button3.Visible = False
        Button5.Visible = False
        Panel2.Visible = False

        Summary.Panel1.Visible = False
        Summary.Panel4.Visible = False
        Summary.Panel5.Visible = False
        Summary.Panel6.Visible = False
        Summary.Panel12.Visible = False
        Summary.Panel13.Visible = False
        Summary.Panel14.Visible = False
        Summary.Panel15.Visible = False
        Summary.Panel16.Visible = False
        Summary.Panel17.Visible = False
        Summary.Panel8.Visible = False
        Summary.Panel10.Visible = False
        Summary.Panel7.Visible = False
        Summary.Panel9.Visible = False
        Summary.Panel2.Visible = False
        Summary.Panel3.Visible = False
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Switchpanel1(Summary)
        Panel2.Visible = True
        Panel4.Visible = True

    End Sub



    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView2.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView3.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView4.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView5.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView6.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView7.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView8.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView9.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView10.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView11.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView12.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView13.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView14.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView15.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
                DataGridView16.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label13.Visible = False
        Label12.Visible = True
        Panel4.Visible = False

        Panel2.Visible = False
        Switchpanel(Peripherals)
        pere = "Display"

        Switchpanel2(Searchfrm)
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
        Searchfrm.Panel13.Visible = False
        Searchfrm.Panel14.Visible = False
        Searchfrm.Panel12.Visible = False
        Searchfrm.Panel15.Visible = False
        Searchfrm.Panel16.Visible = False

        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False
        DataGridView5.Visible = False
        DataGridView6.Visible = False
        DataGridView7.Visible = False
        DataGridView8.Visible = False
        DataGridView9.Visible = False
        DataGridView10.Visible = False
        DataGridView11.Visible = True
        DataGridView12.Visible = False
        DataGridView13.Visible = False
        DataGridView14.Visible = False
        DataGridView15.Visible = False
        DataGridView16.Visible = False
        DataGridView11.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE category like '%" & pere & "%' and stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView11.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("brands"), dr.Item("model"), dr.Item("chipset"), dr.Item("capacity"), dr.Item("watts"), dr.Item("formfactor"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Dim processor, memory, graphics, SSD, powersupply, range As Double
    Dim processorr, memoryy, graphicss, SSDD, powersupplyy As Double

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        processor = Val(DataGridView1.CurrentRow.Cells(9).Value)

        If processor >= 14900 Then
            ProgressBar1.Value = 100
        ElseIf processor >= 5581 And processor <= 14899.99 Then
            ProgressBar1.Value = 50
        ElseIf processor >= 2100 And processor <= 5580.99 Then
            ProgressBar1.Value = 25
        ElseIf processor <= 2099.99 Then
            ProgressBar1.Value = 0
        End If

        processorr = ProgressBar1.Value / 4
        memoryy = ProgressBar2.Value / 4
        graphicss = ProgressBar3.Value / 4
        SSDD = ProgressBar4.Value / 4
        powersupplyy = ProgressBar5.Value / 4
        range = processorr + memoryy + graphicss + SSDD + powersupplyy
        ProgressBar6.Value = range

        Button5.Visible = True
        Button3.Visible = True
        Panel2.Visible = False
        Summary.Panel1.Visible = True


        Component.TextBox3.Text = DataGridView1.CurrentRow.Cells(1).Value
        Component.pprice.Text = DataGridView1.CurrentRow.Cells(9).Value
        Component.pstocks.Text = DataGridView1.CurrentRow.Cells(10).Value

        Summary.TextBox3.Text = DataGridView1.CurrentRow.Cells(1).Value
        Summary.pstocks.Text = DataGridView1.CurrentRow.Cells(9).Value




        Dim arrimage() As Byte
        arrimage = DataGridView1.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox1.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Button5.Visible = True
        Button3.Visible = True
        Panel2.Visible = False
        summary.Panel4.Visible = True
        Component.TextBox6.Text = DataGridView2.CurrentRow.Cells(1).Value
        Component.TextBox2.Text = DataGridView2.CurrentRow.Cells(9).Value
        Component.TextBox1.Text = DataGridView2.CurrentRow.Cells(10).Value

        summary.TextBox6.Text = DataGridView2.CurrentRow.Cells(1).Value
        Summary.TextBox1.Text = DataGridView2.CurrentRow.Cells(9).Value

        Dim arrimage() As Byte
        arrimage = DataGridView2.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox4.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Button5.Visible = True
        Button3.Visible = True
        Panel2.Visible = False
        summary.Panel5.Visible = True
        Component.TextBox7.Text = DataGridView3.CurrentRow.Cells(1).Value
        Component.TextBox5.Text = DataGridView3.CurrentRow.Cells(9).Value
        Component.TextBox4.Text = DataGridView3.CurrentRow.Cells(10).Value

        summary.TextBox7.Text = DataGridView3.CurrentRow.Cells(1).Value
        Summary.TextBox4.Text = DataGridView3.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView3.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox5.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick

        memory = Val(DataGridView4.CurrentRow.Cells(9).Value)

        If memory >= 8000 Then
            ProgressBar2.Value = 100
        ElseIf memory >= 2070 And memory <= 7999.99 Then
            ProgressBar2.Value = 50
        ElseIf memory >= 829 And memory <= 2069.9 Then
            ProgressBar2.Value = 25
        ElseIf memory <= 828 Then
            ProgressBar2.Value = 0
        End If
        processorr = ProgressBar1.Value / 4
        memoryy = ProgressBar2.Value / 4
        graphicss = ProgressBar3.Value / 4
        SSDD = ProgressBar4.Value / 4
        powersupplyy = ProgressBar5.Value / 4
        range = processorr + memoryy + graphicss + SSDD + powersupplyy
        ProgressBar6.Value = range

        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        Summary.Panel6.Visible = True
        Component.TextBox8.Text = DataGridView4.CurrentRow.Cells(1).Value
        Component.TextBox10.Text = DataGridView4.CurrentRow.Cells(9).Value
        Component.TextBox9.Text = DataGridView4.CurrentRow.Cells(10).Value

        Summary.TextBox8.Text = DataGridView4.CurrentRow.Cells(1).Value
        Summary.TextBox9.Text = DataGridView4.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView4.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox6.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick

        graphics = Val(DataGridView5.CurrentRow.Cells(9).Value)

        If graphics >= 27501 Then
            ProgressBar3.Value = 100
        ElseIf graphics >= 13451 And graphics <= 27500.99 Then
            ProgressBar3.Value = 50
        ElseIf graphics >= 8425 And graphics <= 13450.99 Then
            ProgressBar3.Value = 25
        ElseIf graphics <= 8424.99 Then
            ProgressBar3.Value = 0
        End If
        processorr = ProgressBar1.Value / 4
        memoryy = ProgressBar2.Value / 4
        graphicss = ProgressBar3.Value / 4
        SSDD = ProgressBar4.Value / 4
        powersupplyy = ProgressBar5.Value / 4
        range = processorr + memoryy + graphicss + SSDD + powersupplyy
        ProgressBar6.Value = range

        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        Summary.Panel12.Visible = True
        Component.TextBox11.Text = DataGridView5.CurrentRow.Cells(1).Value
        Component.TextBox13.Text = DataGridView5.CurrentRow.Cells(9).Value
        Component.TextBox12.Text = DataGridView5.CurrentRow.Cells(10).Value

        Summary.TextBox11.Text = DataGridView5.CurrentRow.Cells(1).Value
        Summary.TextBox12.Text = DataGridView5.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView5.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox11.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellClick

        SSD = Val(DataGridView6.CurrentRow.Cells(9).Value)

        If SSD >= 4396 Then
            ProgressBar4.Value = 100
        ElseIf SSD >= 2351 And SSD <= 4395.99 Then
            ProgressBar4.Value = 50
        ElseIf SSD >= 795 And SSD <= 2350.99 Then
            ProgressBar4.Value = 25
        ElseIf SSD <= 794.99 Then
            ProgressBar4.Value = 0
        End If
        processorr = ProgressBar1.Value / 4
        memoryy = ProgressBar2.Value / 4
        graphicss = ProgressBar3.Value / 4
        SSDD = ProgressBar4.Value / 4
        powersupplyy = ProgressBar5.Value / 4
        range = processorr + memoryy + graphicss + SSDD + powersupplyy
        ProgressBar6.Value = range

        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        Summary.Panel13.Visible = True
        Component.TextBox14.Text = DataGridView6.CurrentRow.Cells(1).Value
        Component.TextBox16.Text = DataGridView6.CurrentRow.Cells(9).Value
        Component.TextBox15.Text = DataGridView6.CurrentRow.Cells(10).Value

        Summary.TextBox14.Text = DataGridView6.CurrentRow.Cells(1).Value
        Summary.TextBox15.Text = DataGridView6.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView6.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox12.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView7_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellClick
        Button3.Visible = True
        Panel2.Visible = False
        Button5.Visible = True
        summary.Panel14.Visible = True
        Component.TextBox17.Text = DataGridView7.CurrentRow.Cells(1).Value
        Component.TextBox19.Text = DataGridView7.CurrentRow.Cells(9).Value
        Component.TextBox18.Text = DataGridView7.CurrentRow.Cells(10).Value

        summary.TextBox17.Text = DataGridView7.CurrentRow.Cells(1).Value
        Summary.TextBox18.Text = DataGridView7.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView7.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox2.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView8_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView8.CellClick
        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        summary.Panel15.Visible = True
        Component.TextBox20.Text = DataGridView8.CurrentRow.Cells(1).Value
        Component.TextBox22.Text = DataGridView8.CurrentRow.Cells(9).Value
        Component.TextBox21.Text = DataGridView8.CurrentRow.Cells(10).Value

        summary.TextBox20.Text = DataGridView8.CurrentRow.Cells(1).Value
        Summary.TextBox21.Text = DataGridView8.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView8.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox14.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView9_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView9.CellClick


        powersupply = Val(DataGridView9.CurrentRow.Cells(9).Value)

        If powersupply >= 6395 Then
            ProgressBar5.Value = 100
        ElseIf powersupply >= 2350 And powersupply <= 6394.99 Then
            ProgressBar5.Value = 50
        ElseIf powersupply >= 385 And powersupply <= 2349.99 Then
            ProgressBar5.Value = 25
        ElseIf powersupply <= 384.99 Then
            ProgressBar5.Value = 0
        End If

        processorr = ProgressBar1.Value / 4
        memoryy = ProgressBar2.Value / 4
        graphicss = ProgressBar3.Value / 4
        SSDD = ProgressBar4.Value / 4
        powersupplyy = ProgressBar5.Value / 4
        range = processorr + memoryy + graphicss + SSDD + powersupplyy
        ProgressBar6.Value = range

        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        Summary.Panel16.Visible = True
        Component.TextBox23.Text = DataGridView9.CurrentRow.Cells(1).Value
        Component.TextBox25.Text = DataGridView9.CurrentRow.Cells(9).Value
        Component.TextBox24.Text = DataGridView9.CurrentRow.Cells(10).Value

        Summary.TextBox23.Text = DataGridView9.CurrentRow.Cells(1).Value
        Summary.TextBox24.Text = DataGridView9.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView9.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox15.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub

    Private Sub DataGridView10_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView10.CellClick
        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        summary.Panel17.Visible = True
        Component.TextBox26.Text = DataGridView10.CurrentRow.Cells(1).Value

        Component.TextBox28.Text = DataGridView10.CurrentRow.Cells(9).Value
        Component.TextBox27.Text = DataGridView10.CurrentRow.Cells(10).Value

        summary.TextBox26.Text = DataGridView10.CurrentRow.Cells(1).Value
        Summary.TextBox27.Text = DataGridView10.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView10.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Component.PictureBox16.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub
    Private Sub DataGridView11_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView11.CellClick
        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        summary.Panel8.Visible = True
        Peripherals.TextBox3.Text = DataGridView11.CurrentRow.Cells(1).Value

        Peripherals.pprice.Text = DataGridView11.CurrentRow.Cells(9).Value
        Peripherals.pstocks.Text = DataGridView11.CurrentRow.Cells(10).Value

        summary.TextBox31.Text = DataGridView11.CurrentRow.Cells(1).Value
        Summary.TextBox32.Text = DataGridView11.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView11.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Peripherals.PictureBox1.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub
    Private Sub DataGridView12_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView12.CellClick
        Button3.Visible = True
        Panel2.Visible = False
        Button5.Visible = True
        summary.Panel10.Visible = True
        Peripherals.TextBox1.Text = DataGridView12.CurrentRow.Cells(1).Value
        Peripherals.TextBox4.Text = DataGridView12.CurrentRow.Cells(9).Value
        Peripherals.TextBox2.Text = DataGridView12.CurrentRow.Cells(10).Value

        summary.TextBox44.Text = DataGridView12.CurrentRow.Cells(1).Value
        Summary.TextBox45.Text = DataGridView12.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView12.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Peripherals.PictureBox4.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub
    Private Sub DataGridView13_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView13.CellClick
        Button3.Visible = True
        Panel2.Visible = False
        Button5.Visible = True
        summary.Panel7.Visible = True
        Peripherals.TextBox5.Text = DataGridView13.CurrentRow.Cells(1).Value
        Peripherals.TextBox7.Text = DataGridView13.CurrentRow.Cells(9).Value
        Peripherals.TextBox6.Text = DataGridView13.CurrentRow.Cells(10).Value

        summary.TextBox38.Text = DataGridView13.CurrentRow.Cells(1).Value
        Summary.TextBox2.Text = DataGridView13.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView13.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Peripherals.PictureBox5.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub
    Private Sub DataGridView14_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView14.CellClick
        Button3.Visible = True
        Panel2.Visible = False
        Button5.Visible = True
        summary.Panel9.Visible = True
        Peripherals.TextBox8.Text = DataGridView14.CurrentRow.Cells(1).Value
        Peripherals.TextBox10.Text = DataGridView14.CurrentRow.Cells(9).Value
        Peripherals.TextBox9.Text = DataGridView14.CurrentRow.Cells(10).Value

        summary.TextBox41.Text = DataGridView14.CurrentRow.Cells(1).Value
        Summary.TextBox47.Text = DataGridView14.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView14.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Peripherals.PictureBox6.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub
    Private Sub DataGridView15_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView15.CellClick
        Button3.Visible = True
        Button5.Visible = True
        Panel2.Visible = False
        summary.Panel2.Visible = True
        Peripherals.TextBox11.Text = DataGridView15.CurrentRow.Cells(1).Value
        Peripherals.TextBox13.Text = DataGridView15.CurrentRow.Cells(9).Value
        Peripherals.TextBox12.Text = DataGridView15.CurrentRow.Cells(10).Value

        summary.TextBox29.Text = DataGridView15.CurrentRow.Cells(1).Value
        Summary.TextBox48.Text = DataGridView15.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView15.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Peripherals.PictureBox11.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub
    Private Sub DataGridView16_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView16.CellClick
        Button3.Visible = True
        Panel2.Visible = False
        Button5.Visible = True
        summary.Panel3.Visible = True
        Peripherals.TextBox14.Text = DataGridView16.CurrentRow.Cells(1).Value
        Peripherals.TextBox16.Text = DataGridView16.CurrentRow.Cells(9).Value
        Peripherals.TextBox15.Text = DataGridView16.CurrentRow.Cells(10).Value

        summary.TextBox35.Text = DataGridView16.CurrentRow.Cells(1).Value
        Summary.TextBox49.Text = DataGridView16.CurrentRow.Cells(9).Value


        Dim arrimage() As Byte
        arrimage = DataGridView16.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        Peripherals.PictureBox12.Image = Image.FromStream(memsrtr)

        c1 = Val(Component.pprice.Text)
        c2 = Val(Component.TextBox2.Text)
        c3 = Val(Component.TextBox5.Text)
        c4 = Val(Component.TextBox10.Text)
        c5 = Val(Component.TextBox13.Text)
        c6 = Val(Component.TextBox16.Text)
        c7 = Val(Component.TextBox19.Text)
        c8 = Val(Component.TextBox22.Text)
        c9 = Val(Component.TextBox25.Text)
        c10 = Val(Component.TextBox28.Text)
        p11 = Val(Peripherals.pprice.Text)
        p12 = Val(Peripherals.TextBox4.Text)
        p13 = Val(Peripherals.TextBox7.Text)
        p14 = Val(Peripherals.TextBox10.Text)
        p15 = Val(Peripherals.TextBox13.Text)
        p16 = Val(Peripherals.TextBox16.Text)
        subtotal = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10 + p11 + p12 + p13 + p14 + p15 + p16
        Label4.Text = subtotal.ToString("N2")
    End Sub
End Class