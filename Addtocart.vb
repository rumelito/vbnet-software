Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC
Imports System.Drawing.Printing
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Addtocart
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader
    Dim i As Integer
    Private Sub Addtocart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If Label1.Text = "0" Then
            DataGridView2.Enabled = False
        ElseIf Label1.Text = 0 Then
            DataGridView2.Enabled = False

        Else
            DataGridView2.Enabled = True
        End If
    End Sub
    Public Sub DGV_load()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM cart where costumer_id = '" & Customers.Label3.Text & "'", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            Label1.Text = String.Format("{0}", count)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        If Label1.Text = "0" Then
            DataGridView2.Enabled = False
        ElseIf Label1.Text = 0 Then
            DataGridView2.Enabled = False
        Else

            DataGridView2.Enabled = True
        End If

        DataGridView2.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM cart WHERE costumer_id = '" & Customers.Label3.Text & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("productname"), dr.Item("price"), dr.Item("quantity"), dr.Item("totalprice"), dr.Item("costumer_id"), dr.Item("ID"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub


    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        If DataGridView2.Columns(e.ColumnIndex).Name = "delete" Then
            If Label1.Text = "0" Then
                DataGridView2.Enabled = False
            ElseIf Label1.Text = 0 Then
                DataGridView2.Enabled = False
            Else
                DataGridView2.Enabled = True
            End If
            Try
                Customers.DataGridView2.Rows.Add(DataGridView2.CurrentRow.Cells(0).Value, DataGridView2.CurrentRow.Cells(1).Value, DataGridView2.CurrentRow.Cells(2).Value, DataGridView2.CurrentRow.Cells(3).Value)
                Dim totalSum As Integer = 0

                For Each row As DataGridViewRow In Customers.DataGridView2.Rows

                    totalSum += CInt(row.Cells(3).Value)

                Next
                Customers.Label14.Text = totalSum.ToString("N2")

                Try
                    Dim id As String = DataGridView2.SelectedRows(0).Cells(5).Value.ToString()
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM `cart` WHERE ID = @id", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@id", id)

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MessageBox.Show("Item had been moved to Order!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)


                    Else
                        MessageBox.Show("Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Catch ex As Exception

                    MessageBox.Show("Your Cart is Empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                Finally
                    conn.Close()
                End Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DGV_load()
        End If

        If DataGridView2.Columns(e.ColumnIndex).Name = "Column1" Then
            Try
                Dim id As String = DataGridView2.SelectedRows(0).Cells(5).Value.ToString()
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `cart` WHERE ID = @id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id", id)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Removed Successfully!", "Point of Sale!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)


                Else
                    MessageBox.Show("Remove Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MessageBox.Show("Your Cart is Empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Finally
                conn.Close()
            End Try
            DGV_load()
        End If
    End Sub


End Class