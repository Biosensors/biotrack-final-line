Imports System.Exception
Public Class RejectionCode
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrej As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbReasonTypes As System.Windows.Forms.ComboBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbReasonTypes = New System.Windows.Forms.ComboBox
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.txtrej = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbReasonTypes)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.txtrej)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 132)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Reason Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbReasonTypes
        '
        Me.cmbReasonTypes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbReasonTypes.FormattingEnabled = True
        Me.cmbReasonTypes.Location = New System.Drawing.Point(150, 21)
        Me.cmbReasonTypes.Name = "cmbReasonTypes"
        Me.cmbReasonTypes.Size = New System.Drawing.Size(209, 24)
        Me.cmbReasonTypes.TabIndex = 1
        '
        'txtdesc
        '
        Me.txtdesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtdesc.Location = New System.Drawing.Point(150, 92)
        Me.txtdesc.MaxLength = 50
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(209, 22)
        Me.txtdesc.TabIndex = 3
        '
        'txtrej
        '
        Me.txtrej.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtrej.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtrej.Location = New System.Drawing.Point(150, 58)
        Me.txtrej.MaxLength = 6
        Me.txtrej.Name = "txtrej"
        Me.txtrej.Size = New System.Drawing.Size(209, 22)
        Me.txtrej.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(38, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(38, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Rejection Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Location = New System.Drawing.Point(158, 164)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 25)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "Save"
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Location = New System.Drawing.Point(248, 164)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        '
        'RejectionCode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(451, 207)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RejectionCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rejection Code"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public sReasonType As String

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "U" Then
            Me.cmbReasonTypes.Enabled = False
            Me.txtrej.ReadOnly = True
            Me.Text = "Edit Rejection Code"
        ElseIf Me.Tag = "I" Then
            LoadReasonTypes()
            Me.cmbReasonTypes.Enabled = True
            Me.txtrej.ReadOnly = False
            Me.txtrej.Text = ""
            Me.txtdesc.Text = ""
            Me.Text = "Add Rejection Code"
        ElseIf Me.Tag = "S" Then
            Me.cmbReasonTypes.Enabled = False
            Me.Text = "Add Rejection Code"
            Me.txtrej.ReadOnly = False
            Me.txtrej.Text = ""
            Me.txtdesc.Text = ""
        End If
    End Sub

    Public Sub LoadReasonTypes()
        Try
            Dim ds As New DataSet
            sql = "select rtype,description from reasontypes"
            ds = db.selectQuery(sql)

            With cmbReasonTypes
                .DisplayMember = "description"
                .ValueMember = "rtype"
                .DataSource = ds.Tables(0)
            End With
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtrej_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrej.TextChanged

    End Sub

    Private Sub txtrej_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrej.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            txtdesc.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            btnsave.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql As String
        Dim db As New Class1
        sReasonType = cmbReasonTypes.SelectedValue()

        If Me.Tag = "I" Then

            sql = "insert into Reasons(rtype,rejcd,dsca) values ('" & sReasonType & "','" & txtrej.Text & "','" & txtdesc.Text & "')"

            If db.insertQuery(sql) Then
                Me.Tag = "U"
                MsgBox("Rejection Code Added", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("Failure in adding Rejection Code", MsgBoxStyle.Information)
            End If

        ElseIf Me.Tag = "U" Then
            sql = "update Reasons set dsca ='" & txtdesc.Text & "' where rejcd='" & txtrej.Text & "'"

            If db.updateQuery(sql) Then
                Me.Tag = "U"
                MsgBox("Rejection Code Updated", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("Failure in updating Rejection Code", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
