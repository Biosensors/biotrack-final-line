
Public Class FrmLogin

    Dim objClsScanning As New clsScanning
    Dim p As New System.Diagnostics.Process
    Dim ds As New DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sConnectionServer = objClsScanning.GetConnectionStringValue
        sApplicationName = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name()
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtUserName.Select()
    End Sub

    Private Sub ValidateLogin()
        Try
            sLogonUser = LCase(txtUserName.Text.Trim())
            Sql = "select userid from Users where userid = '" & txtUserName.Text.Trim() & "' and passwd = '" & txtPassword.Text.Trim() & "' COLLATE Latin1_General_CS_AS"
            ds = db.selectQuery(Sql)


            If (ds.Tables(0).Rows.Count > 0) And (getUserAuthentication() = True) Then
                If objClsScanning.CheckUserRights(sLogonUser, sApplicationName) Then
                    SuccessLogin()
                Else
                    MsgBox("Authorization not succeed.", MsgBoxStyle.Critical)

                End If
            Else
                MsgBox(db.conn.ConnectionString.ToString, MsgBoxStyle.Critical)

                MsgBox("Password is incorrect.", MsgBoxStyle.Critical)
                txtPassword.Text = ""
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SuccessLogin()

        Me.txtPassword.Text = ""
        Me.Hide()
        sLoginCancel = True

        sLogonUser = txtUserName.Text.Trim()
        Operations.txtuserId.Text = sLogonUser
        Operations.ShowDialog()

    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "" Then
            MsgBox("Enter Username")
            txtUserName.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Enter Password")
            txtPassword.Focus()
        Else
            ValidateLogin()
        End If
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            ValidateLogin()
        End If
    End Sub

End Class
