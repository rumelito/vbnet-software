Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Transaction
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()

    End Sub

    Public Sub DGV_load()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT sum(quantity) FROM orderst", conn)
            Dim result As Object = cmd.ExecuteScalar()
            Label22.Text = String.Format("{0}", result)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users where uname = '" & Usertype.txtusernamein.Text & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Label3.Text = dr.GetValue(0)
                Label4.Text = dr.GetValue(1)
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT orderst.order_id,users.costumer_id,users.fname,orderst.items,orderst.unit_price,orderst.quantity,orderst.price,orderst.date FROM orderst inner join users on orderst.costumer_id = users.costumer_id where orderst.order_id>0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("order_id"), dr.Item("costumer_id"), dr.Item("fname"), dr.Item("items"), dr.Item("unit_price"), dr.Item("quantity"), dr.Item("price"), dr.Item("date"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(6).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MsgBox("You need to Select First!", vbExclamation)
            Return
        End If

        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    ' Hide the selected row
                    DataGridView1.Rows.Item(row.Index).Visible = False
                Next
                DataGridView2.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox7.Text, TextBox6.Text, TextBox5.Text, TextBox4.Text, DateTimePicker1.Text)
            End If
            TextBox8.Clear()


            Dim totalSum As Integer = 0
            Dim qty As Integer = 0

            For Each row As DataGridViewRow In DataGridView2.Rows
                totalSum += CInt(row.Cells(6).Value)
                qty += CInt(row.Cells(5).Value)
            Next
            Label14.Text = totalSum.ToString("N2")
            Label18.Text = qty.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox7.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox9.Text = "") Then
            MsgBox("Select The Reciept!", vbExclamation)
            Return
        End If

        Try
            conn.Open()


            Dim cmd As New MySqlCommand("INSERT INTO `tranasactionst` (`order_id`,`costumer_id`,`no_of_items`,`total_cost`,`cash`,`change`,`receipt`,`date`) VALUES (@order_id,@costumer_id,@no_of_items,@total_cost,@cash,@change,@receipt,@date)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@order_id", CInt(DataGridView2.Rows(0).Cells(0).Value))
            cmd.Parameters.AddWithValue("@costumer_id", CInt(DataGridView2.Rows(0).Cells(1).Value))
            cmd.Parameters.AddWithValue("@no_of_items", CInt(Label18.Text))
            cmd.Parameters.AddWithValue("@total_cost", CInt(Label14.Text))
            cmd.Parameters.AddWithValue("@cash", CInt(TextBox8.Text))
            cmd.Parameters.AddWithValue("@change", CInt(Label13.Text))
            cmd.Parameters.AddWithValue("@receipt", System.IO.Path.GetFileName(TextBox9.Text))
            cmd.Parameters.AddWithValue("@date", CDate(DateTimePicker1.Value))

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                Dim cmd2 As New MySqlCommand("DELETE  FROM `orderst` WHERE `order_id` = '" & CInt(DataGridView2.Rows(0).Cells(0).Value) & "'", conn)
                cmd2.Parameters.Clear()
                i = cmd2.ExecuteNonQuery()
                DataGridView2.Rows.Clear()

                MessageBox.Show("Processed Done Successfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Addashboard.Total_users()
                Addashboard.Total_products()
                Addashboard.Total_order()
                Addashboard.Total_sales()
                Addashboard.Today_sales()

                Adanalytics.Total_order()
                Adanalytics.Total_sales()
                Adanalytics.Today_sales()
                Account.DGV_load()

            Else
                MessageBox.Show("Processed Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return
            End If
            If TextBox9.Text <> "" Then
                System.IO.File.Copy(TextBox9.Text, Application.StartupPath & "\Receipt_file\" & System.IO.Path.GetFileName(TextBox9.Text))
            End If
            TextBox9.Clear()
            Label18.Text = 0
            Label14.Text = 0.ToString("N2")
            Label13.Text = 0.ToString("N2")
            TextBox8.Clear()
        Catch ex As Exception
            MessageBox.Show("Receipt filename is already Used!, Please Order Again, and Repeat the Transaction", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TextBox9.Clear()
            Label18.Text = 0
            Label14.Text = 0.ToString("N2")
            Label13.Text = 0.ToString("N2")
            TextBox8.Clear()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If Val(Label14.Text < TextBox8.Text) Then
            Try
                Label13.Text = Val(TextBox8.Text - Label14.Text).ToString("N2")
            Catch ex As Exception
                MessageBox.Show("Cash is Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try

        ElseIf TextBox8.Text = "" Then
            TextBox8.Clear()
            Label13.Text = 0.ToString("N2")
        Else
            Try
                Label13.Text = Val(TextBox8.Text - Label14.Text).ToString("N2")
            Catch ex As Exception
                MessageBox.Show("Cash is Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
        End If




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Val(Label14.Text = 0) Then

            MessageBox.Show("You need to Select First!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        ElseIf Val(TextBox8.Text = "") Then

            MessageBox.Show("Input your Cash!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        ElseIf Val(Label14.Text > TextBox8.Text) Then

            MessageBox.Show("Insuficient Cash!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Return
        ElseIf Val(Label13.Text < 0) Then
            MessageBox.Show("Insuficient Cash!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Return
        End If

        Try
            OpenFileDialog1.Filter = "PDF |*.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                TextBox9.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Val(Label14.Text = 0) Then
            MessageBox.Show("You need to Select First!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        ElseIf Val(TextBox8.Text = "") Then

            MessageBox.Show("Input your Cash!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        ElseIf Val(Label14.Text > TextBox8.Text) Then

            MessageBox.Show("Insuficient Cash!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Return
        ElseIf Val(Label13.Text < 0) Then
            MessageBox.Show("Insuficient Cash!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Return
        End If

        'for receipt
        PD.DefaultPageSettings.PaperSize = New PaperSize("MySize", 600, 600)
        PPD.WindowState = FormWindowState.Maximized
        ' PPD.PrintPreviewControl.Zoom = 2.5

        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        'to set font
        Dim f8 As New Font("Arial", 8, FontStyle.Regular)
        Dim f8b As New Font("Verdana", 8, FontStyle.Bold)
        Dim f7 As New Font("Arial", 6, FontStyle.Bold)


        'to set alignment
        Dim left As New StringFormat
        Dim center As New StringFormat
        Dim right As New StringFormat

        left.Alignment = StringAlignment.Near
        center.Alignment = StringAlignment.Center
        right.Alignment = StringAlignment.Far

        'to draw a rectangle
        Dim rect1 As New Rectangle(30, 5, 550, 17)
        Dim rect2 As New Rectangle(30, 22, 550, 17)
        Dim rect3 As New Rectangle(30, 39, 550, 17)



        e.Graphics.DrawRectangle(Pens.Black, rect1)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect3)

        e.Graphics.DrawString("PC BUILD & POS System", f8b, Brushes.Red, rect1, center)
        e.Graphics.DrawString("GROUP 3", f8b, Brushes.Red, rect2, center)
        e.Graphics.DrawString("BSIT - 2F", f8b, Brushes.Red, rect3, center)


        Dim rect4 As New Rectangle(30, 56, 275, 17)
        Dim rect5 As New Rectangle(305, 56, 275, 17)

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users where costumer_id = '" & DataGridView2.CurrentRow.Cells(1).Value & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Customers.Label3.Text = dr.GetValue(0)
                Customers.Label4.Text = dr.GetValue(1)
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


        e.Graphics.DrawRectangle(Pens.Black, rect4)
        e.Graphics.DrawRectangle(Pens.Black, rect5)
        e.Graphics.DrawString("Costumer ID:  " & vbTab& & Customers.Label3.Text & "", f7, Brushes.Red, rect4, center)
        e.Graphics.DrawString("Costumer Name:  " & vbTab& & Customers.Label4.Text & "", f7, Brushes.Red, rect5, center)



        Dim rect6 As New Rectangle(30, 90, 55, 17)
        ' Dim rect7 As New Rectangle(85, 90, 55, 17)
        ' Dim rect8 As New Rectangle(140, 90, 78.57, 17)
        Dim rect9 As New Rectangle(85, 90, 364.97, 17)
        Dim rect10 As New Rectangle(449.99, 90, 50, 17)
        Dim rect11 As New Rectangle(499.99, 90, 30, 17)
        Dim rect12 As New Rectangle(529.99, 90, 50, 17)


        e.Graphics.DrawRectangle(Pens.Black, rect6)
        'e.Graphics.DrawRectangle(Pens.Black, rect7)
        'e.Graphics.DrawRectangle(Pens.Black, rect8)
        e.Graphics.DrawRectangle(Pens.Black, rect9)
        e.Graphics.DrawRectangle(Pens.Black, rect10)
        e.Graphics.DrawRectangle(Pens.Black, rect11)
        e.Graphics.DrawRectangle(Pens.Black, rect12)

        e.Graphics.DrawString("Order ID", f7, Brushes.Black, rect6, center)
        'e.Graphics.DrawString("Costumer ID", f7, Brushes.Black, rect7, center)
        'e.Graphics.DrawString("Costumer Name", f7, Brushes.Black, rect8, center)
        e.Graphics.DrawString("Product Name", f7, Brushes.Black, rect9, center)
        e.Graphics.DrawString("Unit Price", f7, Brushes.Black, rect10, center)
        e.Graphics.DrawString("Qty.", f7, Brushes.Black, rect11, center)
        e.Graphics.DrawString("Price", f7, Brushes.Black, rect12, center)

        Dim y As Integer = 107
        Dim total As Integer = 0.ToString("N2")

        For i = 0 To DataGridView2.Rows.Count - 1

            Dim rect13 As New Rectangle(30, y, 55, 17)
            'Dim rect14 As New Rectangle(85, y, 55, 17)
            ' Dim rect15 As New Rectangle(140, y, 78.57, 17)
            Dim rect16 As New Rectangle(85, y, 364.97, 17)
            Dim rect17 As New Rectangle(449.99, y, 50, 17)
            Dim rect18 As New Rectangle(499.99, y, 30, 17)
            Dim rect19 As New Rectangle(529.99, y, 50, 17)


            e.Graphics.DrawRectangle(Pens.Black, rect13)
            'e.Graphics.DrawRectangle(Pens.Black, rect14)
            'e.Graphics.DrawRectangle(Pens.Black, rect15)
            e.Graphics.DrawRectangle(Pens.Black, rect16)
            e.Graphics.DrawRectangle(Pens.Black, rect17)
            e.Graphics.DrawRectangle(Pens.Black, rect18)
            e.Graphics.DrawRectangle(Pens.Black, rect19)


            e.Graphics.DrawString(DataGridView2.Rows(i).Cells(0).Value, f7, Brushes.Black, rect13, center)
            'e.Graphics.DrawString(DataGridView2.Rows(i).Cells(1).Value, f7, Brushes.Black, rect14, center)
            'e.Graphics.DrawString(DataGridView2.Rows(i).Cells(2).Value, f7, Brushes.Black, rect15, center)
            e.Graphics.DrawString(DataGridView2.Rows(i).Cells(3).Value, f7, Brushes.Black, rect16, center)
            e.Graphics.DrawString(Convert.ToDecimal(DataGridView2.Rows(i).Cells(4).Value).ToString("N2"), f7, Brushes.Black, rect17, center)
            e.Graphics.DrawString(DataGridView2.Rows(i).Cells(5).Value, f7, Brushes.Black, rect18, center)
            e.Graphics.DrawString(Convert.ToDecimal(DataGridView2.Rows(i).Cells(6).Value).ToString("N2"), f7, Brushes.Black, rect19, center)


            y += 17
            total += DataGridView2.Rows(i).Cells(6).Value
        Next


        Dim rect20 As New Rectangle(30, y + 17, 275, 17)
        Dim rect21 As New Rectangle(305, y + 17, 137.5, 17)
        Dim rect22 As New Rectangle(442, y + 17, 137.5, 17)


        e.Graphics.DrawRectangle(Pens.Black, rect20)
        e.Graphics.DrawRectangle(Pens.Black, rect21)
        e.Graphics.DrawRectangle(Pens.Black, rect22)

        e.Graphics.DrawString("No. of Items:  " & Label18.Text & " ", f7, Brushes.Black, rect20, center)
        e.Graphics.DrawString("TOTAL BILL: ", f7, Brushes.Black, rect21, center)
        e.Graphics.DrawString(" ₱ " & total.ToString("N2") & " ", f7, Brushes.Black, rect22, center)

        Dim rect23 As New Rectangle(30, y + 34, 275, 17)
        Dim rect24 As New Rectangle(305, y + 34, 137.5, 17)
        Dim rect25 As New Rectangle(442, y + 34, 137.5, 17)

        e.Graphics.DrawRectangle(Pens.Black, rect23)
        e.Graphics.DrawRectangle(Pens.Black, rect24)
        e.Graphics.DrawRectangle(Pens.Black, rect25)

        e.Graphics.DrawString("DATE : " & DateTimePicker1.Text & " ", f7, Brushes.Black, rect23, center)
        e.Graphics.DrawString("CASH :  ", f7, Brushes.Black, rect24, center)
        e.Graphics.DrawString(" ₱ " & Convert.ToDecimal(TextBox8.Text).ToString("N2") & "", f7, Brushes.Black, rect25, center)

        Dim rect26 As New Rectangle(30, y + 51, 275, 17)
        Dim rect27 As New Rectangle(305, y + 51, 137.5, 17)
        Dim rect28 As New Rectangle(442, y + 51, 137.5, 17)

        e.Graphics.DrawRectangle(Pens.Black, rect26)
        e.Graphics.DrawRectangle(Pens.Black, rect27)
        e.Graphics.DrawRectangle(Pens.Black, rect28)

        e.Graphics.DrawString("Process by  : " & Label4.Text & " ", f7, Brushes.Black, rect26, center)
        e.Graphics.DrawString("CHANGE :  ", f7, Brushes.Black, rect27, center)
        e.Graphics.DrawString(" ₱ " & Convert.ToDecimal(Label13.Text).ToString("N2") & "", f7, Brushes.Black, rect28, center)

    End Sub


    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        If DataGridView2.Columns(e.ColumnIndex).Name = "delete" Then

            DataGridView1.Rows.Add(DataGridView2.CurrentRow.Cells(0).Value, DataGridView2.CurrentRow.Cells(1).Value, DataGridView2.CurrentRow.Cells(2).Value, DataGridView2.CurrentRow.Cells(3).Value, DataGridView2.CurrentRow.Cells(4).Value, DataGridView2.CurrentRow.Cells(5).Value, DataGridView2.CurrentRow.Cells(6).Value, DataGridView2.CurrentRow.Cells(7).Value)
            Cleaar()
            DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)


            Dim totalSum As Integer = 0
            Dim qty As Integer = 0

            For Each row As DataGridViewRow In DataGridView2.Rows
                totalSum += CInt(row.Cells(6).Value)
                qty += CInt(row.Cells(5).Value)
            Next
            Label14.Text = totalSum.ToString("N2")
            Label18.Text = qty.ToString()

        End If
    End Sub

    Sub Cleaar()
        Label13.Text = 0.ToString("N2")
        Label18.Text = 0
        Label14.Text = 0.ToString("N2")
        TextBox8.Clear()
    End Sub

    Private Sub Label18_TextChanged(sender As Object, e As EventArgs) Handles Label18.TextChanged
        If Label18.Text > 0 Then
            TextBox8.Enabled = True
            DataGridView2.Enabled = True
        Else
            TextBox8.Enabled = False
            DataGridView2.Enabled = False
        End If



        If Label18.Text = Label22.Text Then
            Button1.Enabled = False
            DataGridView1.Enabled = False
        Else
            Button1.Enabled = True
            DataGridView1.Enabled = True
        End If
    End Sub


End Class