Imports System.Diagnostics.Metrics
Imports System.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Adanalytics
    Dim conn As New MySqlConnection("server=localhost;database=possystemdb;user=root;password=")
    Dim dr As MySqlDataReader

    Private Sub Adanalytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Total_order()
        Total_products()
        Total_sales()
        Today_sales()
        Total_user()
    End Sub


    Sub Total_user()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)

            Me.Chart2.Series("No. of Costumers").Points.AddXY("", String.Format("{0}", count - 1))

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Sub Total_sales()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SUM(total_cost), date FROM tranasactionst", conn)
            Dim result As Object = cmd.ExecuteScalar()
            dr = cmd.ExecuteReader
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                While dr.Read
                    Me.Chart3.Series("Total Sales").Points.AddXY("", Convert.ToDecimal(result).ToString("N2"))
                End While
            Else
                While dr.Read
                    Me.Chart3.Series("Total Sales").Points.AddXY("", "0.00")
                End While
            End If
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub Total_order()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(DISTINCT order_id) FROM orderst where order_id>0", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)

            dr = cmd.ExecuteReader
            While dr.Read
                Me.Chart5.Series("No. of Orders").Points.AddXY("", String.Format("{0}", count))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Total_products()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*), date FROM posproducts", conn)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)

            dr = cmd.ExecuteReader
            While dr.Read
                Me.Chart4.Series("No. of Products").Points.AddXY("", String.Format("{0}", count))
            End While

            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub Today_sales()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT SUM(total_cost) AS TotalSales, date FROM tranasactionst WHERE date =CAST(NOW() AS DATE)", conn)
            Dim result As Object = cmd.ExecuteScalar()
            dr = cmd.ExecuteReader
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                While dr.Read
                    Me.Chart1.Series("Today Sales").Points.AddXY(dr.Item("DATE"), Convert.ToDecimal(result).ToString("N2"))
                End While
            Else
                While dr.Read
                    Me.Chart1.Series("Today Sales").Points.AddXY(dr.Item("DATE"), "0.00")
                End While
            End If
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class