Imports MySql.Data.MySqlClient

Public Class CONNECTION_DB
    Private Sub Lblexit_Click(sender As Object, e As EventArgs) Handles lblexit.Click
        Application.Exit()
    End Sub

    Private Sub Btndbtest_Click(sender As Object, e As EventArgs) Handles btndbtest.Click
        If (DBConnect()) Then
            conn.Open()

            MsgBox("Database Connected!", vbInformation)
        Else
            MsgBox("Not Connected", vbCritical)

        End If

    End Sub


End Class
