Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC
Imports System.Drawing.Printing
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Customers
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Public Sub DGV_load()

        conn.Open()
        Dim cmd1 As New MySqlCommand("SELECT MAX(order_id) FROM orderst", conn)
        Dim highestID As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
        Label18.Text = highestID.ToString() + 1
        Try

            Dim cmd As New MySqlCommand("SELECT * FROM users where uname = '" & Home.lblUSER.Text & "'", conn)
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
            Dim cmd As New MySqlCommand("SELECT * FROM posproducts where stocks > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))

            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try




    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM posproducts WHERE productID like '%" & TextBox3.Text & "%' OR productname like '%" & TextBox3.Text & "%' OR category like '%" & TextBox3.Text & "%'OR price like '%" & TextBox3.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("productID"), dr.Item("productname"), dr.Item("category"), dr.Item("price"), dr.Item("stocks"), dr.Item("date"), Format(CBool(dr.Item("STATUS"))), dr.Item("image"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then

            MessageBox.Show("Choice Item First!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return

        ElseIf (TextBox8.Text = "") Then

            MessageBox.Show("Quantity is needed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return

        End If

        If Val(TextBox8.Text) > DataGridView1.SelectedRows(0).Cells(4).Value Then

            MessageBox.Show("Insuficient Stocks !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Try
                DataGridView2.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox8.Text, Val(TextBox2.Text * TextBox8.Text))

                Dim totalSum As Integer = 0

                For Each row As DataGridViewRow In DataGridView2.Rows

                    totalSum += CInt(row.Cells(3).Value)
                Next
                Label14.Text = totalSum.ToString("N2")
            Catch ex As Exception
                MessageBox.Show("Quantity is Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End Try
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox8.Clear()
        End If



        ' Dim total As String = TextBox6.Text
        ' Dim price, quantity, subT As Decimal

        ' price = Val(TextBox2.Text)
        ' quantity = Val(TextBox8.Text)

        'TextBox4.Text &= TextBox1.Text & vbNewLine
        'TextBox5.Text &= price & vbNewLine
        'TextBox7.Text &= quantity & vbNewLine
        'TextBox6.Text &= price * quantity & vbNewLine

    End Sub

    Private Function SumNumbersSeparatedByNewline(inputText As String) As Double

        'for computing the number inside a text separated by vbNewline
        Dim totalSum As Double = 0.00

        ' Split the input text by newline characters
        Dim lines As String() = inputText.Split(CChar(Environment.NewLine))

        ' Iterate through each line and sum the numeric values
        For Each line As String In lines
            Dim number As Double
            If Double.TryParse(line, number) Then
                totalSum += number
            End If
        Next

        Return totalSum.ToString("N2")
    End Function

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        If DataGridView2.Columns(e.ColumnIndex).Name = "delete" Then
            DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)

            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Label14.Text = totalSum.ToString("N2")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label14.Text = 0.00 Then
            MessageBox.Show("Orders is Empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        Try
            conn.Open()
            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                Dim cmd1 As New MySqlCommand("UPDATE posproducts SET stocks = stocks - @quantity WHERE productname = @productname", conn)
                cmd1.Parameters.AddWithValue("@quantity", DataGridView2.Rows(i).Cells(2).Value)
                cmd1.Parameters.AddWithValue("@productname", DataGridView2.Rows(i).Cells(0).Value)
                cmd1.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Try
            conn.Open()
            Dim oid As Integer = Label18.Text

            For Each row As DataGridViewRow In DataGridView2.Rows
                Dim cmd As New MySqlCommand("INSERT INTO orderst(order_id,costumer_id,items, unit_price, quantity, price, date) VALUES (@order_id,@costumer_id, @items, @unit_price, @quantity, @price, @date)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@order_id", oid)
                cmd.Parameters.AddWithValue("@costumer_id", Label3.Text)
                cmd.Parameters.AddWithValue("@items", row.Cells(0).Value)
                cmd.Parameters.AddWithValue("@unit_price", row.Cells(1).Value)
                cmd.Parameters.AddWithValue("@quantity", row.Cells(2).Value)
                cmd.Parameters.AddWithValue("@price", row.Cells(3).Value)
                cmd.Parameters.AddWithValue("@date", CDate(DateTimePicker1.Value))

                i = cmd.ExecuteNonQuery

            Next
            If i > 0 Then

                oid = Val(Label18.Text) + 1
                Label18.Text = oid
                DataGridView2.Rows.Clear()
                Label14.Text = 0.00
                MessageBox.Show("Your Order has been Saved", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Transaction.DGV_load()
            Else
                MessageBox.Show("Record Save Orders!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show("Your Order has been Saved", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            conn.Close()
        End Try
        ' clear()
        DGV_load()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.TextChanged
        If Label14.Text = 0.00 Then
            DataGridView2.Enabled = False
        Else
            DataGridView2.Enabled = True
        End If
    End Sub


End Class