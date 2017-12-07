<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEasePassword = New System.Windows.Forms.TextBox()
        Me.txtDecrypted = New System.Windows.Forms.TextBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmb_Databases = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEasePassword
        '
        Me.txtEasePassword.Location = New System.Drawing.Point(90, 58)
        Me.txtEasePassword.Name = "txtEasePassword"
        Me.txtEasePassword.Size = New System.Drawing.Size(150, 20)
        Me.txtEasePassword.TabIndex = 0
        '
        'txtDecrypted
        '
        Me.txtDecrypted.Location = New System.Drawing.Point(322, 58)
        Me.txtDecrypted.Name = "txtDecrypted"
        Me.txtDecrypted.ReadOnly = True
        Me.txtDecrypted.Size = New System.Drawing.Size(150, 20)
        Me.txtDecrypted.TabIndex = 1
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(90, 160)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(150, 20)
        Me.txtServerName.TabIndex = 2
        Me.txtServerName.Text = "easeworks-eng.easeinc.com"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(90, 186)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(150, 20)
        Me.txtUserName.TabIndex = 3
        Me.txtUserName.Text = "easeuser"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(90, 213)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "u2BvfjByGVaXqF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(164, 85)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 9
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(306, 213)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 10
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(460, 197)
        Me.DataGridView1.TabIndex = 11
        '
        'cmb_Databases
        '
        Me.cmb_Databases.FormattingEnabled = True
        Me.cmb_Databases.Location = New System.Drawing.Point(306, 160)
        Me.cmb_Databases.Name = "cmb_Databases"
        Me.cmb_Databases.Size = New System.Drawing.Size(166, 21)
        Me.cmb_Databases.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Database"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_Databases)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.txtDecrypted)
        Me.Controls.Add(Me.txtEasePassword)
        Me.Name = "Form1"
        Me.Text = "Ease Password Decrypt"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEasePassword As TextBox
    Friend WithEvents txtDecrypted As TextBox
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmb_Databases As ComboBox
    Friend WithEvents Label5 As Label
End Class
