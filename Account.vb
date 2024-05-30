Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Account
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dr As MySqlDataReader
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Public Sub DGV_load()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tranasactionst where costumer_id = '" & Customers.Label3.Text & "'", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            Label2.Text = String.Format("{0}", count)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tranasactionst where costumer_id = '" & Customers.Label3.Text & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("transacation_id"), dr.Item("order_id"), dr.Item("costumer_id"), dr.Item("total_cost"), dr.Item("cash"), dr.Item("change"), dr.Item("receipt"), dr.Item("date"))

            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If Label2.Text = "0" Then
            DataGridView1.Enabled = False
        ElseIf Label2.Text = 0 Then
            DataGridView1.Enabled = False
        Else
            DataGridView1.Enabled = True
        End If

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.CurrentRow.Cells(2).Value = Customers.Label3.Text Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tranasactionst where transacation_id = '" & DataGridView1.CurrentRow.Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                With TabControl1
                    .Show()
                    .Focus()
                    .SelectedTab = TabPage2
                    AxAcroPDF1.src = Application.StartupPath & "\Receipt_file\" & dr.Item("Receipt")
                End With
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tranasactionst where transacation_id = '" & DataGridView1.CurrentRow.Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read

                With TabControl1
                    .Show()
                    .Focus()
                    .SelectedTab = TabPage2
                    AxAcroPDF1.src = Application.StartupPath & "\Receipt_file\" & dr.Item("Receipt")
                End With

            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class