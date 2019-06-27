Public Class ChangeShip2Target
    Public wono As String
    Public Oprn As String
    Public status As String
    Public rstatus As String
    Public Astatus As String
    Public sLoginUser As String
    Public txtStentSerial As String

    Private Sub ChangeShip2Target_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.txtOprn.Text = "SEAL" Then
            Me.cmbShipTo.Items.Add("None - ZZZ")
            Me.cmbShipTo.Items.Add("Bio Burden(QA) - QBB")
            Me.cmbShipTo.Visible = True
            Me.cmbShipTo.Visible = True
            Me.cmbShipTo.SelectedIndex = 0
        ElseIf Me.txtOprn.Text = "BOX" Then
            Me.cmbShipTo.Items.Add("Singapore - SGW")
            Me.cmbShipTo.Items.Add("QA - SGQ")
            Me.cmbShipTo.Items.Add("BESA - CHW")
            Me.lblnewShipTo.Visible = True
            Me.cmbShipTo.Visible = True
            Me.cmbShipTo.SelectedIndex = 0
        End If
        Me.txtOprn.ReadOnly = True
        Me.txtSerialNo.ReadOnly = True
        Me.txtCurrShipToTarget.ReadOnly = True
        Me.txtCurrWorkOrder.ReadOnly = True

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Sql = " EXEC [SP_UpdateShip2TargetBySerialNo] '"
            Sql = Sql & Me.txtCurrWorkOrder.Text & "','"
            Sql = Sql & Me.txtSerialNo.Text & "','"
            Sql = Sql & Me.cmbShipTo.Text & "','"
            Sql = Sql & Me.txtOprn.Text & "','"
            Sql = Sql & Me.lblLogonUser.Text & "' "
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows(0).Item(0) <> 0 Then
                MsgBox("Save Ship2Target :" & ds.Tables(0).Rows(0).Item(1).ToString)
            Else
                MsgBox("Ship2Target Value Updated ")
            End If
        Catch
            MsgBox("Save Shitp2Target : " & Err.Description)
        End Try
        Me.Close()
    End Sub
End Class