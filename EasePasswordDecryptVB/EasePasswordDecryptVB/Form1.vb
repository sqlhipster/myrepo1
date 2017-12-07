Imports System.Data.SqlClient
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

        Dim str As String = "Data Source=" & ServerName & ";uid=" & UserName & ";pwd=" & Password & ";database=aml_prod"
        Dim con As New SqlConnection(str)
        Dim com1 As String = "Select userid, username, passwordx From euser"

        'Dim Adpt As New SqlDataAdapter(com1, con)
        'Dim ds As New DataSet()
        'Adpt.Fill(ds, "Emp")
        'DataGridView1.DataSource = ds.Tables(0)

        Dim ds2 As New DataSet()
        Dim com2 As String = "Select name From sys.databases"
        Dim Adpt2 As New SqlDataAdapter(com2, con)
        Adpt2.Fill(ds2, "sys.databases")
        cmb_Databases.DataSource = ds2
        cmb_Databases.DisplayMember = "name"

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



End Class
