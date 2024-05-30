Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography


Module Database
    Public conn As New MySqlConnection()
    Public cmd As MySqlCommand()
    Dim status As Boolean = False
    Public i As Integer


    Dim ConnString = "server=localhost;database=possystemdb;userid=root;password="
    Public Function DBConnect() As Boolean
        If (conn.State = ConnectionState.Closed) Then
            conn.ConnectionString = ConnString
            status = True
        End If

        Return status

    End Function

    Public Function Data_enc(enc_data As String) As String
        Try
            Dim data As Byte() = New Byte(enc_data.Length - 1) {}
            data = System.Text.Encoding.UTF8.GetBytes(enc_data)
            Dim encoded_data As String = Convert.ToBase64String(data)
            Return encoded_data
        Catch ex As Exception
            Throw New Exception("ERROR!" + ex.Message)
        End Try
    End Function

    Public Function Data_dec(dec_data As String) As String
        Dim decrypt As New System.Text.UTF8Encoding
        Dim utf_decrypt As System.Text.Decoder = decrypt.GetDecoder
        Dim udata = Convert.FromBase64String(dec_data)
        Dim charnum As Integer = utf_decrypt.GetCharCount(udata, 0, udata.Length)
        Dim decrypt_char As Char() = New Char(charnum - 1) {}
        utf_decrypt.GetChars(udata, 0, udata.Length, decrypt_char, 0)
        Dim result As String = New [String](decrypt_char)
        Return result
    End Function

End Module