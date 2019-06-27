Public Class Operations
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It c'an be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    Friend WithEvents btnOperations As System.Windows.Forms.Button
    Friend WithEvents lbloprn As System.Windows.Forms.Label
    Friend WithEvents cmbOprn As System.Windows.Forms.ComboBox
    Friend WithEvents txtuserId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operations))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.btnOperations = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtuserId = New System.Windows.Forms.TextBox()
        Me.cmbOprn = New System.Windows.Forms.ComboBox()
        Me.lbloprn = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(47, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "User ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLogOff
        '
        Me.btnLogOff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogOff.Location = New System.Drawing.Point(208, 147)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(99, 25)
        Me.btnLogOff.TabIndex = 6
        Me.btnLogOff.Text = "&Log Off"
        '
        'btnOperations
        '
        Me.btnOperations.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOperations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnOperations.Location = New System.Drawing.Point(95, 147)
        Me.btnOperations.Name = "btnOperations"
        Me.btnOperations.Size = New System.Drawing.Size(100, 25)
        Me.btnOperations.TabIndex = 5
        Me.btnOperations.Text = "&Operations"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtuserId)
        Me.GroupBox1.Controls.Add(Me.cmbOprn)
        Me.GroupBox1.Controls.Add(Me.lbloprn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 101)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'txtuserId
        '
        Me.txtuserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtuserId.Location = New System.Drawing.Point(125, 20)
        Me.txtuserId.MaxLength = 20
        Me.txtuserId.Name = "txtuserId"
        Me.txtuserId.Size = New System.Drawing.Size(173, 22)
        Me.txtuserId.TabIndex = 2
        '
        'cmbOprn
        '
        Me.cmbOprn.AllowDrop = True
        Me.cmbOprn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOprn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbOprn.Location = New System.Drawing.Point(125, 56)
        Me.cmbOprn.MaxDropDownItems = 20
        Me.cmbOprn.Name = "cmbOprn"
        Me.cmbOprn.Size = New System.Drawing.Size(173, 24)
        Me.cmbOprn.TabIndex = 3
        '
        'lbloprn
        '
        Me.lbloprn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbloprn.Location = New System.Drawing.Point(42, 56)
        Me.lbloprn.Name = "lbloprn"
        Me.lbloprn.Size = New System.Drawing.Size(77, 23)
        Me.lbloprn.TabIndex = 14
        Me.lbloprn.Text = "Operation"
        Me.lbloprn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Operations
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(404, 203)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLogOff)
        Me.Controls.Add(Me.btnOperations)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Operations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scanning"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public db As New Class1
    Declare Function WNetGetUser Lib "mpr.dll" Alias "WNetGetUserA" (ByVal lpName As String, ByVal lpUsersName As String, ByVal lpnLength As Long) As Long

    Const NoError As Integer = 0       'The Function call was successful

    'Public Sub main()
    '    Dim frm As New Operations
    '    Dim str() As String
    '    str = GetCommandLineArgs()
    '    If (UBound(str) >= 0) Then
    '        a = str(0).ToString
    '        'b = str(1).ToString
    '    End If
    '    Application.Run(frm)
    'End Sub

    'Function GetCommandLineArgs() As String()
    '    ' Declare variables.
    '    Dim separators As String = " "
    '    Dim commands As String = Microsoft.VisualBasic.Command()
    '    Dim args() As String = commands.Split(separators.ToCharArray)
    '    Return args
    'End Function

    Private Sub Operations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtuserId.Text = GetCommandLineArgs(a)

        If txtuserId.Text = "" Then
            Username = System.Security.Principal.WindowsIdentity.GetCurrent().Name
            nUserPos = InStr(Username, "\")
            If nUserPos > 0 Then
                Username = Mid(Username, nUserPos + 1, Len(Username))
            Else
                Username = Trim(Username)
            End If
            sLogonUser = Username
            txtuserId.Text = sLogonUser
        End If

        txtuserId.Enabled = False
        'btnShipment.Visible = False

        If sConnectionServer = "" Then
            sConnectionServer = getConnectionString(Nothing, sVersion)
        End If

        'sConnectionServer = getConnectionString("DEVELOPMENT Server", sVersion)

        cmbload()
    End Sub

    Private Function cmbload() As Boolean
        Dim ds As DataSet
        Dim sql As String

        Try
            'sql = "select userid, uname  from Users where stat=1"
            'ds = db.selectQuery(sql)

            'cmbuid.DataSource = ds.Tables(0)
            'cmbuid.DisplayMember = "uname"
            'cmbuid.ValueMember = "userid"

            sql = " select *, str(opseq)+' - '+ ltrim(rtrim((dsca))) as OprnName from Operations where stat = 1 order by opseq "
            ds = db.selectQuery(sql)
            cmbOprn.DataSource = ds.Tables(0)
            cmbOprn.DisplayMember = "OprnName"      '"dsca"
            cmbOprn.ValueMember = "oprnid"

        Catch ex As System.Exception

            MessageBox.Show(ex.Message)
        End Try
    End Function

#Region "Commented"

    'Private Function ValidateLogin() As Boolean

    '    ' Dim l As New Login
    '    'Dim ds As DataSet
    '    'Dim sql As String
    '    'Dim stat As Integer
    '    ' Dim inc As Integer
    '    'Dim ustatus As String
    '    'inc = 0
    '    'Dim db As New Class1
    '    Try
    '        'sql = "select passwd,stat,uname from Users where userid='" & Trim(txtuserId.Text) & "'"
    '        'ds = db.selectQuery(sql)
    '        ''Dim dr As DataRow
    '        ''For Each dr In ds.Tables(0).Rows
    '        'If ds.Tables(0).Rows.Count > 0 Then
    '        '    stat = ds.Tables(0).Rows(0).Item("stat")
    '        'Else
    '        '    stat = 0
    '        'End If
    '        ''passwd = ds.Tables(0).Rows(0).Item("passwd").ToString
    '        ''stat = ds.Tables(0).Rows(0).Item("stat")

    '        ''If passwd = txtpassword.Text Then
    '        Me.Hide()
    '        workorder.uid = Me.txtuserId.Text              'cmbuid.SelectedValue.ToString
    '        workorder.wstatus = 1             'stat
    '        workorder.nme = ""               'ds.Tables(0).Rows(0).Item("uname")
    '        workorder.sOprn = Me.cmbOprn.SelectedValue.ToString
    '        workorder.sOprnDsca = Me.cmbOprn.Text
    '        workorder.nCurOprn = Val(Mid(cmbOprn.Text, 1, InStr(Me.cmbOprn.Text, "-") - 1))

    '        workorder.txterror.Text = "Press F1 to Scan"
    '        workorder.txterror.Show()
    '        'If stat = 1 Then
    '        '    workorder.btnuser.Show()
    '        '    workorder.btnrej.Show()
    '        '    workorder.btnundo.Show()
    '        'Else
    '        'workorder.btnuser.Hide()
    '        'workorder.btnrej.Hide()
    '        'workorder.btnundo.Hide()
    '        'End If
    '        workorder.Show()
    '    Catch ex As System.Exception
    '        MsgBox(Err.Description)
    '    End Try
    '    'Me.Close()
    'End Function
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim u As New User
    '    u.ShowDialog()
    '    cmbload()
    'End Sub

    'Private Sub Login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
    '    If e.KeyChar = Chr(Keys.Escape) Then
    '        Dim l As New Login
    '        Form.ActiveForm.Close()
    '        Application.Exit()
    '        e.Handled = True

    '    End If
    'End Sub

    'Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
    '    If e.KeyChar = Chr(Keys.Enter) Then

    '        login()
    '        e.Handled = True

    '    End If
    '    If e.KeyChar = Chr(Keys.Escape) Then
    '        Dim l As New Login
    '        Form.ActiveForm.Close()
    '        Application.Exit()
    '        e.Handled = True

    '    End If


    'End Sub


    'Private Sub cmbuid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbuid.KeyPress
    '    If e.KeyChar = Chr(Keys.Enter) Then

    '        txtpassword.Focus()
    '        e.Handled = True

    '    End If
    '    If e.KeyChar = Chr(Keys.Escape) Then
    '        Dim l As New Login
    '        Form.ActiveForm.Close()
    '        Application.Exit()
    '        e.Handled = True

    '    End If
    'End Sub

    'Private Sub btnlogon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnlogon.KeyPress
    '    If e.KeyChar = Chr(Keys.Escape) Then
    '        Dim l As New Login

    '        Form.ActiveForm.Close()
    '        Application.Exit()
    '        e.Handled = True

    '    End If
    'End Sub

    'Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyValue = Keys.Escape Then

    '        Dim l As New Login
    '        Form.ActiveForm.Close()
    '        Application.Exit()
    '        e.Handled = True

    '    End If
    'End Sub
#End Region

    Public Function GetUsersName() As String

        Dim NoError As Integer = 0

        ' Buffer size for the return string.
        Const lpnLength As Integer = 255

        ' Get return buffer space.
        Dim Status As Integer

        ' For getting user information.
        Dim lpName, lpUsersName As String

        ' Assign the buffer size constant to lpUsersName.
        lpUsersName = Space$(lpnLength + 1)

        lpName = ""
        ' Get the log-on name of the person using product.
        Status = WNetGetUser(lpName, lpUsersName, lpnLength)

        ' See whether error occurred.
        If Status = NoError Then
            lpUsersName = Microsoft.VisualBasic.Left(lpUsersName, InStr(lpUsersName, Chr(0)) - 1)
        Else
            MsgBox("Unable to get the name.")
            End
        End If

        ' Display the name of the person logged on to the machine.
        '      MsgBox "The person logged on this machine is: " & lpUsersName
        GetUsersName = lpUsersName
    End Function

    Private Sub cmbOprn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOprn.SelectedIndexChanged

    End Sub

    Private Sub btnShipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim l As New Shipment
        Dim db As New Class1
        l.Show()
    End Sub

    Private Sub btnOperations_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperations.Click
        Try

            Me.Hide()
            'workorder.uid = Me.txtuserId.Text              'cmbuid.SelectedValue.ToString
            workorder.txtwrkordno.Text = ""
            workorder.txtitmcode.Text = ""
            workorder.txtdesc.Text = ""
            workorder.txtwoqty.Text = ""
            workorder.txtqnty.Text = ""
            workorder.txtaccept.Text = ""
            workorder.txtreject.Text = ""
            workorder.txtbal.Text = ""
            workorder.wstatus = 1             'stat
            workorder.nme = ""               'ds.Tables(0).Rows(0).Item("uname")
            workorder.sOprn = Me.cmbOprn.SelectedValue.ToString
            workorder.sOprnDsca = Me.cmbOprn.Text
            workorder.nCurOprn = Val(Mid(cmbOprn.Text, 1, InStr(Me.cmbOprn.Text, "-") - 1))

            workorder.txterror.Text = "Press F1 to Scan"
            workorder.txterror.Show()
            workorder.ShowDialog()
            Me.Show()
        Catch ex As System.Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub btnLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        Me.Close()
        Application.Exit()
    End Sub

End Class
