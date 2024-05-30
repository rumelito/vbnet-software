Public Class ADMIN

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Usertype.Show()
        Usertype.txtusernamein.Clear()
        Usertype.txtpasswordin.Clear()
        Usertype.pcat.Text = ""
    End Sub

    Private Sub Lblexit_Click(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Switchpanel(Adproducts)
        Adproducts.DGV_load()
        Button6.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Switchpanel(Adcostumers)
        Adcostumers.DGV_load()
        Button6.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Btnsignout_Click(sender As Object, e As EventArgs) Handles Btnsignout.Click
        Me.Close()

        Usertype.Show()
        Usertype.txtusernamein.Clear()
        Usertype.txtpasswordin.Clear()
        Usertype.pcat.Text = ""
    End Sub

    Sub Switchpanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Switchpanel(Transaction)

        Button6.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Switchpanel(Addashboard)
        Addashboard.Total_users()
        Addashboard.Total_products()
        Addashboard.Total_order()
        Addashboard.Total_sales()
        Addashboard.Today_sales()
        Button6.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switchpanel(Addashboard)
        Addashboard.Total_users()
        Addashboard.Total_products()
        Addashboard.Total_order()
        Addashboard.Total_sales()
        Addashboard.Today_sales()
        Button6.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Switchpanel(Adanalytics)
        Button6.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub
    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Switchpanel(Adanalytics)
        Button6.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

End Class