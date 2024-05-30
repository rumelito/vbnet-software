Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Summary
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")

    Sub Switchpanel1(ByVal panel1 As Form)
        panel1.TopLevel = False
        panel1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox3.Text, pstocks.Text, Label15.Text, Val(pstocks.Text * Label15.Text))
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox3.Text)
            cmd.Parameters.AddWithValue("@price", pstocks.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(pstocks.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then

                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try
            Addtocart.DataGridView2.Rows.Add(TextBox6.Text, TextBox1.Text, Label15.Text, Val(TextBox1.Text * Label15.Text))

            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox6.Text)
            cmd.Parameters.AddWithValue("@price", TextBox1.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox1.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox7.Text, TextBox4.Text, Label15.Text, Val(TextBox4.Text * Label15.Text))

            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox7.Text)
            cmd.Parameters.AddWithValue("@price", TextBox4.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox4.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox8.Text, TextBox9.Text, Label15.Text, Val(TextBox9.Text * Label15.Text))

            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox8.Text)
            cmd.Parameters.AddWithValue("@price", TextBox9.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox9.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox11.Text, TextBox12.Text, Label15.Text, Val(TextBox12.Text * Label15.Text))


            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox11.Text)
            cmd.Parameters.AddWithValue("@price", TextBox12.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox12.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox14.Text, TextBox15.Text, Label15.Text, Val(TextBox15.Text * Label15.Text))



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox14.Text)
            cmd.Parameters.AddWithValue("@price", TextBox15.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox15.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox17.Text, TextBox18.Text, Label15.Text, Val(TextBox18.Text * Label15.Text))



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox17.Text)
            cmd.Parameters.AddWithValue("@price", TextBox18.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox18.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox20.Text, TextBox21.Text, Label15.Text, Val(TextBox21.Text * Label15.Text))


            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox20.Text)
            cmd.Parameters.AddWithValue("@price", TextBox21.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox21.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox23.Text, TextBox24.Text, Label15.Text, Val(TextBox24.Text * Label15.Text))



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox23.Text)
            cmd.Parameters.AddWithValue("@price", TextBox24.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox24.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox26.Text, TextBox27.Text, Label15.Text, Val(TextBox27.Text * Label15.Text))



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox26.Text)
            cmd.Parameters.AddWithValue("@price", TextBox27.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox27.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox31.Text, TextBox32.Text, Label15.Text, Val(TextBox32.Text * Label15.Text))


            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox31.Text)
            cmd.Parameters.AddWithValue("@price", TextBox32.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox32.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox44.Text, TextBox45.Text, Label15.Text, Val(TextBox45.Text * Label15.Text))



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox44.Text)
            cmd.Parameters.AddWithValue("@price", TextBox45.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox45.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox38.Text, TextBox2.Text, Label15.Text, Val(TextBox2.Text * Label15.Text))


            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox38.Text)
            cmd.Parameters.AddWithValue("@price", TextBox2.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox2.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox41.Text, TextBox47.Text, Label15.Text, Val(TextBox47.Text * Label15.Text))



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox41.Text)
            cmd.Parameters.AddWithValue("@price", TextBox47.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox47.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox29.Text, TextBox48.Text, Label15.Text, Val(TextBox48.Text * Label15.Text))



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox29.Text)
            cmd.Parameters.AddWithValue("@price", TextBox48.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox48.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity

        Try
            Addtocart.DataGridView2.Rows.Add(TextBox35.Text, TextBox49.Text, Label15.Text, Val(TextBox49.Text * Label15.Text))


            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO cart(productname, price, quantity, totalprice, costumer_id) VALUES (@productname, @price, @quantity, @totalprice, @costumer_id)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@productname", TextBox35.Text)
            cmd.Parameters.AddWithValue("@price", TextBox49.Text)
            cmd.Parameters.AddWithValue("@quantity", Label15.Text)
            cmd.Parameters.AddWithValue("@totalprice", Val(TextBox49.Text * Label15.Text))
            cmd.Parameters.AddWithValue("@costumer_id", Customers.Label3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Item added to cart Succesfully!", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Addtocart.DGV_load()
            Else
                MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try
            Customers.DataGridView2.Rows.Add(TextBox3.Text, pstocks.Text, Label15.Text, Val(pstocks.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox6.Text, TextBox1.Text, Label15.Text, Val(TextBox1.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox7.Text, TextBox4.Text, Label15.Text, Val(TextBox4.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox8.Text, TextBox9.Text, Label15.Text, Val(TextBox9.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox11.Text, TextBox12.Text, Label15.Text, Val(TextBox12.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox14.Text, TextBox15.Text, Label15.Text, Val(TextBox15.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox17.Text, TextBox18.Text, Label15.Text, Val(TextBox18.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox20.Text, TextBox21.Text, Label15.Text, Val(TextBox21.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox23.Text, TextBox24.Text, Label15.Text, Val(TextBox24.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox26.Text, TextBox27.Text, Label15.Text, Val(TextBox27.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox31.Text, TextBox32.Text, Label15.Text, Val(TextBox32.Text * Label15.Text))

            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox44.Text, TextBox45.Text, Label15.Text, Val(TextBox45.Text * Label15.Text))

            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox38.Text, TextBox2.Text, Label15.Text, Val(TextBox2.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox41.Text, TextBox47.Text, Label15.Text, Val(TextBox47.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox29.Text, TextBox48.Text, Label15.Text, Val(TextBox48.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Dim quantity As Integer = 1
        Label15.Text = quantity
        Try

            Customers.DataGridView2.Rows.Add(TextBox35.Text, TextBox49.Text, Label15.Text, Val(TextBox49.Text * Label15.Text))
            Dim totalSum As Integer = 0

            For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                totalSum += CInt(row.Cells(3).Value)
            Next
            Customers.Label14.Text = totalSum.ToString("N2")

            MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class