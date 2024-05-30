Imports MySql.Data.MySqlClient

Public Class Addashboard

    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader


    Private Sub Addashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Timer1 As New Timer()
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Start()
        Total_users()
        Total_products()
        Total_order()
        Total_sales()
        Today_sales()
    End Sub

    Sub Total_order()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(DISTINCT order_id) FROM orderst where order_id>0", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            Label17.Text = String.Format("{0}", count)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Total_users()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            Label2.Text = String.Format("{0}", count - 1)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Total_products()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM posproducts", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            Label5.Text = String.Format("{0}", count)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Total_sales()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SUM(total_cost) FROM tranasactionst", conn)
            'Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            'Label8.Text = String.Format("{0}", count)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                Label8.Text = Convert.ToDecimal(result).ToString("N2")
            Else
                Label8.Text = "0.00"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Today_sales()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SUM(total_cost) AS TotalSales FROM tranasactionst WHERE date =CAST(NOW() AS DATE)", conn)
            'Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                Label13.Text = Convert.ToDecimal(result).ToString("N2")
            Else
                Label13.Text = "0.00"
            End If
            ' Label13.Text = String.Format("{0}", count)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label15.Text = DateTime.Now.ToString("HH:mm:ss" + vbNewLine + "yyyy-MM-dd")

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.TextChanged
        Adanalytics.Label6.Text = Label5.Text
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.TextChanged
        Adanalytics.Label7.Text = Label17.Text

        If Label17.Text = 0 Then
            Transaction.DataGridView1.Enabled = False
            Transaction.Button1.Enabled = False
        Else
            Transaction.DataGridView1.Enabled = True
            Transaction.Button1.Enabled = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.TextChanged
        Adanalytics.Label8.Text = Label2.Text

        If Label2.Text = 0 Then
            Adcostumers.DataGridView1.Enabled = False
        Else
            Adcostumers.DataGridView1.Enabled = True
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.TextChanged
        Adanalytics.Label9.Text = Label8.Text
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.TextChanged
        Adanalytics.Label10.Text = Label13.Text
    End Sub


End Class