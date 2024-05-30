
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Adproducts
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim imgpath As String
    Dim arrimage() As Byte

    Sub Switchpanel(ByVal panel As Form)
        panel.TopLevel = False
        panel.Show()
    End Sub
    Private Sub Adproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts", conn)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Save()
        DGV_load()

    End Sub
    Public Sub Save()
        If (pid.Text = "") Then
            MsgBox("Product ID is Required!", vbExclamation)
            Return
        End If
        If (pname.Text = "") Then
            MsgBox("Product Name is Required!", vbExclamation)
            Return
        End If
        If (pcat.Text = "") Then
            MsgBox("Category is Required!", vbExclamation)
            Return
        End If
        If (ComboBox1.Text = "") Then
            MsgBox("Brands is Required!", vbExclamation)
            Return
        End If
        If (ComboBox4.Text = "") Then
            MsgBox("Model is Required!", vbExclamation)
            Return
        End If
        If (ComboBox5.Text = "") Then
            MsgBox("Chipset is Required!", vbExclamation)
            Return
        End If
        If (ComboBox3.Text = "") Then
            MsgBox("Capacity is Required!", vbExclamation)
            Return
        End If
        If (ComboBox2.Text = "") Then
            MsgBox("Watts is Required!", vbExclamation)
            Return
        End If
        If (ComboBox6.Text = "") Then
            MsgBox("Form Factor is Required!", vbExclamation)
            Return
        End If
        If (pprice.Text = "") Then
            MsgBox("Price is Required!", vbExclamation)
            Return
        End If
        If (pstocks.Text = "") Then
            MsgBox("Stocks is Required!", vbExclamation)
            Return
        End If

        Try
            Dim ms As New System.IO.MemoryStream
            PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = ms.GetBuffer()
            Dim filesize As UInt32
            filesize = ms.Length
            ms.Close()

            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO posproducts(productID, productname, category, brands, model, chipset, capacity, watts, formfactor, price, stocks, date, status, image) VALUES (@productID, @productname, @category, @brands, @model, @chipset, @capacity, @watts, @formfactor, @price, @stocks, @date, @status, @image)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productID", pid.Text)
            cmd.Parameters.AddWithValue("@productname", pname.Text)
            cmd.Parameters.AddWithValue("@category", pcat.Text)
            cmd.Parameters.AddWithValue("@brands", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@model", ComboBox4.Text)
            cmd.Parameters.AddWithValue("@chipset", ComboBox5.Text)
            cmd.Parameters.AddWithValue("@capacity", ComboBox3.Text)
            cmd.Parameters.AddWithValue("@watts", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@formfactor", ComboBox6.Text)
            cmd.Parameters.AddWithValue("@price", CDec(pprice.Text))
            cmd.Parameters.AddWithValue("@stocks", pstocks.Text)
            cmd.Parameters.AddWithValue("@date", CDate(DateTimePicker1.Value))
            cmd.Parameters.AddWithValue("@status", CBool(CheckBox1.Checked.ToString))
            cmd.Parameters.AddWithValue("@image", arrimage)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                Addashboard.Total_products()
                Adanalytics.Total_products()

                MessageBox.Show("Record Saved Success !", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show("Record Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            conn.Close()
        End Try
        Clear()
    End Sub

    Public Sub Clear()
        pid.Clear()
        pname.Clear()
        pcat.Text = ""
        ComboBox1.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox6.Text = ""
        pprice.Clear()
        pstocks.Clear()
        DateTimePicker1.Value = Now
        CheckBox1.CheckState = False
        PictureBox1.Image = My.Resources.def_prod

        pid.ReadOnly = False
        Button3.Enabled = True

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        pid.Text = DataGridView1.CurrentRow.Cells(0).Value
        pname.Text = DataGridView1.CurrentRow.Cells(1).Value
        pcat.Text = DataGridView1.CurrentRow.Cells(2).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(3).Value
        ComboBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
        ComboBox5.Text = DataGridView1.CurrentRow.Cells(5).Value
        ComboBox3.Text = DataGridView1.CurrentRow.Cells(6).Value
        ComboBox2.Text = DataGridView1.CurrentRow.Cells(7).Value
        ComboBox6.Text = DataGridView1.CurrentRow.Cells(8).Value
        pprice.Text = DataGridView1.CurrentRow.Cells(9).Value
        pstocks.Text = DataGridView1.CurrentRow.Cells(10).Value
        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(11).Value
        CheckBox1.Checked = DataGridView1.CurrentRow.Cells(12).Value

        arrimage = DataGridView1.CurrentRow.Cells(13).Value
        Dim memsrtr As New MemoryStream(arrimage)
        PictureBox1.Image = Image.FromStream(memsrtr)

        pid.ReadOnly = True
        Button3.Enabled = False
    End Sub

    Sub Edit()
        If (pid.Text = "") Then
            MessageBox.Show("Select item First!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        Try
            Dim ms As New System.IO.MemoryStream
            PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = ms.GetBuffer()
            Dim filesize As UInt32
            filesize = ms.Length
            ms.Close()

            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE posproducts SET productname=@productname, category=@category, brands=@brands, model=@model, chipset=@chipset, capacity=@capacity, watts=@watts, formfactor=@formfactor, price=@price, stocks=@stocks, date=@date, status=@status, image=@image WHERE productID = @productID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productID", pid.Text)
            cmd.Parameters.AddWithValue("@productname", pname.Text)
            cmd.Parameters.AddWithValue("@category", pcat.Text)
            cmd.Parameters.AddWithValue("@brands", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@model", ComboBox4.Text)
            cmd.Parameters.AddWithValue("@chipset", ComboBox5.Text)
            cmd.Parameters.AddWithValue("@capacity", ComboBox3.Text)
            cmd.Parameters.AddWithValue("@watts", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@formfactor", ComboBox6.Text)
            cmd.Parameters.AddWithValue("@price", CDec(pprice.Text))
            cmd.Parameters.AddWithValue("@stocks", pstocks.Text)
            cmd.Parameters.AddWithValue("@date", CDate(DateTimePicker1.Value))
            cmd.Parameters.AddWithValue("@status", CBool(CheckBox1.Checked.ToString))
            cmd.Parameters.AddWithValue("@image", arrimage)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Updated Success !", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Clear()
        DGV_load()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Edit()
    End Sub

    Public Sub Delete()
        If (pid.Text = "") Then
            MessageBox.Show("Select item First!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If
        If MsgBox("Are You Sure Delete This Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM posproducts WHERE productID = @productID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@productID", pid.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    Addashboard.Total_products()
                    Adanalytics.Total_products()
                    MessageBox.Show("Record Deleted Success !", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Record Delete Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            Clear()
            DGV_load()

        Else
            Return
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Delete()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE productID like '%" & TextBox1.Text & "%' OR productname like '%" & TextBox1.Text & "%' OR category like '%" & TextBox1.Text & "%' OR brands like '%" & TextBox1.Text & "%' OR model like '%" & TextBox1.Text & "%' OR chipset like '%" & TextBox1.Text & "%' OR capacity like '%" & TextBox1.Text & "%' OR price like '%" & TextBox1.Text & "%' OR stocks like '%" & TextBox1.Text & "%' ", conn)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ofd As FileDialog = New OpenFileDialog
            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg;)|*.jpg;*.bmp;*.gif;*.jpeg;"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                PictureBox1.ImageLocation = imgpath
            End If

            ofd = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.def_prod
    End Sub


End Class