Public Class Adaccount
    Private Sub Adaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Switchpanel(Profile)
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Sub Switchpanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Switchpanel(Account)
        Account.DGV_load()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Switchpanel(Profile)
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Switchpanel(Changepass)
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
    End Sub


End Class