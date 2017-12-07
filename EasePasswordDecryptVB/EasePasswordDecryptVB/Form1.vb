Public Class Form1
    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Dim password As String
        Dim decrypt As String

        password = txtEasePassword.Text

        decrypt = Getdecrypt(password)

        txtDecrypted.Text = decrypt

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim ServerName
        Dim UserName
        Dim Password

        ServerName = txtServerName.Text
        UserName = txtUserName.Text
        Password = txtPassword.Text

        PopulateGrid(ServerName, UserName, Password)

    End Sub

    Public Function Getdecrypt(ByVal password) As String

        Dim decrypted As String = "", intI As Int16 = 0

        Try
            For intI = 1 To Len(password)
                decrypted &= Chr(Asc(Mid(password, intI, 1)) - intI)
            Next
        Catch ex As Exception
            MessageBox.Show("Failed to Decrypt")
        End Try

        Return decrypted

    End Function

    Public Function PopulateGrid(ByVal ServerName, ByVal UserName, ByVal Password)



    End Function


End Class
