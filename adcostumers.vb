Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class Adcostumers
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader
    Private Sub Adcostumers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub
    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE usertype = 'Costumer'", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("costumer_id"), dr.Item("fname"), dr.Item("lname"), dr.Item("uname"), dr.Item("upass"), dr.Item("usertype"))
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        pid.Text = DataGridView1.CurrentRow.Cells(0).Value

        If DataGridView1.Columns(e.ColumnIndex).Name = "Column7" Then
            Delete()
            'DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        End If
    End Sub

    Public Sub Delete()
        If MsgBox("Are You Sure Delete This Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM users WHERE costumer_id = @costumer_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@costumer_id", pid.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then

                    MessageBox.Show("Record Deleted Success!", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Addashboard.Total_users()
                    Adanalytics.Total_user()

                    Transaction.DGV_load()

                    Addashboard.Total_sales()
                    Adanalytics.Total_sales()

                    Addashboard.Today_sales()
                    Adanalytics.Today_sales()


                Else
                    MessageBox.Show("Record Delete Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM orderst WHERE costumer_id = @costumer_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@costumer_id", pid.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    Addashboard.Total_order()
                    Adanalytics.Total_order()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM cart WHERE costumer_id = @costumer_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@costumer_id", pid.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    Addtocart.DGV_load()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            DGV_load()

        Else
            Return
        End If

    End Sub




End Class