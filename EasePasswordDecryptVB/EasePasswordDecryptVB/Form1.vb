Imports System.Data.SqlClient
Public Class Form1

    Dim ServerName
    Dim UserName
    Dim Password

    Public Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Dim password As String
        Dim decrypt As String

        password = txtEasePassword.Text

        decrypt = Getdecrypt(password)

        txtDecrypted.Text = decrypt

    End Sub

    Public Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click


        ServerName = txtServerName.Text
        UserName = txtUserName.Text
        Password = txtPassword.Text



        Dim con As New SqlConnection()
        con.ConnectionString = "Data Source=" & ServerName & ";uid=" & UserName & ";pwd=" & Password & ";database=aml_prod"
        con.Open()
        Dim da As New SqlDataAdapter("Select * From sys.databases order by name", con)
        Dim table As New DataTable()
        da.Fill(table)
        cmb_Databases.DataSource = New BindingSource(table, Nothing)
        cmb_Databases.DisplayMember = "Name"
        cmb_Databases.ValueMember = "database_id"

    End Sub

    Public Sub cmb_Databases_SelectionChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Databases.SelectionChangeCommitted
        Dim selectedItem As Object
        selectedItem = cmb_Databases.GetItemText(cmb_Databases.SelectedItem)

        'MessageBox.Show("Selected Item Text: " & selectedItem.ToString())

        Dim str As String = "Data Source=" & ServerName & ";uid=" & UserName & ";pwd=" & Password & ";database=aml_prod"
        Dim con As New SqlConnection(str)
        Dim com1 As String = "Select userid, username, passwordx From " & selectedItem.ToString() & ".dbo.euser"

        Dim Adpt As New SqlDataAdapter(com1, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)

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
