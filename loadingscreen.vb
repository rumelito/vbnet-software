Public Class loadingscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        lblpercent.Text = ProgressBar1.Value & "%"
        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            Timer1.Enabled = False
            Me.Hide()
            registerform.Show()
        End If
    End Sub

    Private Sub Loadingscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class