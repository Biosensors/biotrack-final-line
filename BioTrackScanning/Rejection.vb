

Public Class Rejection
    Inherits System.Windows.Forms.Form
    Dim rescd1 As String
    Dim rescd2 As String
    Public wono As String
    Public status As String
    Public rstatus As String
    Public Astatus As String
    Public word As String
    Public Istatus As String
    Public user As String

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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbst As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtst As System.Windows.Forms.TextBox
    Friend WithEvents txtcath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtuid As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnok = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbst = New System.Windows.Forms.ComboBox
        Me.cmbcat = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtst = New System.Windows.Forms.TextBox
        Me.txtcath = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtuid = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Location = New System.Drawing.Point(270, 163)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        '
        'btnok
        '
        Me.btnok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnok.Location = New System.Drawing.Point(180, 163)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 25)
        Me.btnok.TabIndex = 4
        Me.btnok.Text = "OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.cmbst)
        Me.GroupBox1.Controls.Add(Me.cmbcat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtst)
        Me.GroupBox1.Controls.Add(Me.txtcath)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 128)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'cmbst
        '
        Me.cmbst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbst.Location = New System.Drawing.Point(272, 80)
        Me.cmbst.Name = "cmbst"
        Me.cmbst.Size = New System.Drawing.Size(176, 24)
        Me.cmbst.TabIndex = 3
        Me.cmbst.Visible = False
        '
        'cmbcat
        '
        Me.cmbcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbcat.Location = New System.Drawing.Point(102, 42)
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(344, 24)
        Me.cmbcat.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(143, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Rejection Reason"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtst
        '
        Me.txtst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtst.Location = New System.Drawing.Point(104, 80)
        Me.txtst.MaxLength = 20
        Me.txtst.Name = "txtst"
        Me.txtst.ReadOnly = True
        Me.txtst.Size = New System.Drawing.Size(152, 22)
        Me.txtst.TabIndex = 2
        Me.txtst.TabStop = False
        Me.txtst.Visible = False
        '
        'txtcath
        '
        Me.txtcath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtcath.Location = New System.Drawing.Point(104, 42)
        Me.txtcath.Name = "txtcath"
        Me.txtcath.ReadOnly = True
        Me.txtcath.Size = New System.Drawing.Size(152, 22)
        Me.txtcath.TabIndex = 20
        Me.txtcath.TabStop = False
        Me.txtcath.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Stents"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Catheter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'txtuid
        '
        Me.txtuid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtuid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuid.Location = New System.Drawing.Point(360, 164)
        Me.txtuid.Name = "txtuid"
        Me.txtuid.Size = New System.Drawing.Size(84, 22)
        Me.txtuid.TabIndex = 6
        Me.txtuid.Visible = False
        '
        'Rejection
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(512, 205)
        Me.Controls.Add(Me.txtuid)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Rejection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rejection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Rejection1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rcmbload()
    End Sub

    Private Function Rcmbload() As Boolean
        Dim ds As DataSet
        Dim sql As String
        Dim db As New Class1
        Try
            Dim rtype As String
            rtype = workorder.rType.ToString
            'sql = "select rejcd, dsca from Reasons"
            sql = "select rejcd, dsca from Reasons where rtype='" & workorder.rType & "'"
            ds = db.selectQuery(sql)

            cmbcat.DataSource = ds.Tables(0)
            cmbcat.DisplayMember = "dsca"
            cmbcat.ValueMember = "rejcd"


            'sql = "select rejcd, dsca from Reasons"
            'ds1 = db.selectQuery(sql)

            'cmbst.DataSource = ds1.Tables(0)
            'cmbst.DisplayMember = "dsca"

            'cmbcat.SelectedIndex = cmbcat.FindStringExact(rescd1)
            'cmbst.SelectedIndex = cmbst.FindStringExact(rescd2)

        Catch ex As System.Exception

            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Rej()
    End Sub
    Private Function Rej() As Boolean
        Dim sql As String
        Dim db As New Class1
        Dim w As New workorder
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim wono1 As String
        Dim now As Date
        Dim dlgRes As DialogResult
        'Dim v As New MainForm

        dlgRes = MessageBox.Show( _
              "Are you Sure U Want To Reject '" & txtcath.Text & "' ", _
              "Confirm Record Deletion", _
        MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If dlgRes = Windows.Forms.DialogResult.Yes Then
            sql = "select  getdate()"
            ' ds = db.selectQuery(sql)
            'now = ds.Tables(0).Rows(0).Item(0).ToString
            '  Commented by Ali, 18-Jun-2018 ... Updates moved to Stored Procedure
            'If Istatus = "R" Then
            '    sql = "insert into OperationLogs(wono,srlno1,srlno2,oprn,status,mdby,crdt,reascd1,reascd2) values ('" & word & "','" & Trim(txtcath.Text) & "','" & Trim(txtst.Text) & "','" & rstatus & "',0,'" & txtuid.Text & "', getdate() " & " ,'" & cmbcat.SelectedValue.ToString & "','" & cmbcat.SelectedValue.ToString & "' )"
            '    db.insertQuery(sql)
            '    If db.w = 1 Then
            '        sql = "update OperationLogs set reascd1='" & cmbcat.SelectedValue.ToString & "',reascd2='" & cmbcat.SelectedValue.ToString & "',status=0,mddt= getdate() " & " ,mdby= '" & txtuid.Text & "'"
            '        sql = sql & " where rtrim(ltrim(wono))= '" & word & "' and srlno1='" & txtcath.Text & "' and oprn = '" & rstatus & "'"
            '        db.updateQuery(sql)
            '    End If
            'Else
            '    sql = "update OperationLogs set reascd1='" & cmbcat.SelectedValue.ToString & "',reascd2='" & cmbcat.SelectedValue.ToString & "',status=0,mddt= getdate() " & " ,mdby= '" & txtuid.Text & "'"
            '    sql = sql & " where rtrim(ltrim(wono))= '" & word & "' and srlno1='" & txtcath.Text & "' and oprn= '" & rstatus & "'"

            '    db.updateQuery(sql)
            'End If

            sql = " EXEC [SP_ValidateFinalLineScanning] '"
            sql = sql & word & "','"
            sql = sql & txtcath.Text & "','"
            sql = sql & Trim(txtst.Text) & "','"
            sql = sql & "" & "',0,'"
            sql = sql & rstatus & "','"
            sql = sql & txtuid.Text & "','"
            sql = sql & cmbcat.SelectedValue.ToString() & "' "
            ds = db.selectQuery(sql)
            If ds.Tables(0).Rows(0).Item(0) < 0 Then
                MsgBox(ds.Tables(0).Rows(0).Item(1).ToString)
            End If
            Me.Close()
        End If
    End Function

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Dim r As New Rejection
        Form.ActiveForm.Close()
    End Sub

    Private Sub cmbcat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcat.SelectedIndexChanged

    End Sub

    Private Sub cmbst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbst.SelectedIndexChanged

    End Sub

    Private Sub cmbcat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcat.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cmbst.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub cmbst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbst.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnok.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub btnok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnok.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Rej()

            e.Handled = True
        End If
    End Sub
End Class
