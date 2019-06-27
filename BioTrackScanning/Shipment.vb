Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports BTFinalLine.BioTrackScanningMain
Imports BTFinalLine.ClsUtil
Public Class Shipment
    Public Gstatus As String
    Public sql As String
    Public sOprn As String = "BOX"
    Public tabSelected As String
    Public db As New Class1
    'Public clspm As New clsPublic_Methods
    Public ds As New DataSet
    Public tabName As String
    Public nCurOprn As Integer
    Public ds1 As New DataSet
    Public shipTo As New Integer
    Public srcheck1 As String
    Public srcheck As String
    Public srwono As String
    Private Sub Shipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsrno1.Visible = True
        txtWono.Text = Trim(sShipmentWorkOrderNO)
        showBITGrid()
    End Sub

    Private Sub txtsrno1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsrno1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            txtsrno1.Focus()
            ' if serial number is valid

            If (ValidateSerialNo() And tabSelected = "BIT") Then
                Gstatus = "A"  ' BIT = 1
                updateShipTo()
                showBITGrid()
                txtsrno1.Text = ""

            Else 'If (ValidateSerialNo() And tabSelected = "BESA") Then
                ' Gstatus = "R"

                showBESAGrid()
                txtsrno1.Text = ""
            End If
        End If


    End Sub

    Private Function ShipToReturn(ByVal ds As DataSet) As Boolean
        If ds.Tables(0).Rows.Count > 0 Then
            If (Not IsDBNull(ds.Tables(0).Rows(0).Item("srlno1"))) Then
                ShipToReturn = True
            Else
                ShipToReturn = False
            End If
        Else
            ShipToReturn = False
        End If
        Return ShipToReturn
    End Function
    Private Function ValidateSerialNo() As Boolean

        ValidateSerialNo = False
        If Not txtsrno1.Text = "" Then
            sql = "select srlno1,wono,shipto from OperationLogs where oprn='" & sOprn & "' and srlno1='" & txtsrno1.Text & "' and status = 1"
            ' sql = "select srlno1,wono from OperationLogs where oprn='" & sOprn & "' and srlno1='" & txtsrno1.Text & "'"
            ds = db.selectQuery(sql)
            ' srwono = ds.Tables(0).Rows(0).Item("wono")
            Try

                If (ds.Tables(0).Rows.Count > 0) Then
                    If (ds.Tables(0).Rows(0).Item("wono").ToString() = sShipmentWorkOrderNO) Then
                        ' if(ds.Tables(0).Rows(0).Item("
                        'srcheck = ds.Tables(0).Rows(0).Item("srlno1")
                        'srwono = ds.Tables(0).Rows(0).Item("wono")

                        'Due to the IsDbNull/0 we have to do two check, first for NULL and tje second one for 0
                        If (IsDBNull(ds.Tables(0).Rows(0)("shipto"))) Then
                            ValidateSerialNo = ShipToReturn(ds)
                        ElseIf (Convert.ToInt32(ds.Tables(0).Rows(0)("shipto")) = 0) Then
                            ValidateSerialNo = ShipToReturn(ds)
                        Else
                            MsgBox(txtsrno1.Text & " Is Already Scanned", MsgBoxStyle.Critical)
                            txtsrno1.Text = ""
                        End If
                        '  txtWono.Text = srwono
                    Else
                        MsgBox("Serial No - " & txtsrno1.Text & " does not belong to Work Order - " & sShipmentWorkOrderNO, MsgBoxStyle.Critical)


                    End If
                Else
                    MsgBox(txtsrno1.Text & " Is Invalid Serial Number")
                    txtsrno1.Text = ""
                End If


            Catch ex As System.Exception
                If InStr(ex.Message, "There is no row at position 0.", CompareMethod.Binary) > 0 Then
                    ValidateSerialNo = False
                End If


                Return ValidateSerialNo
            End Try
            'sShipmentWorkOrderNO = ""

        End If
    End Function

    Private Sub updateShipTo()
        Try
            ' If (ValidateSerialNo()) Then
            If (Gstatus = "A") Then ' For BIT 
                sql = " update OperationLogs set  shipto = 1, mdby = '" & sLogonUser & "', mddt = getdate() where srlno1 = '" & Trim(txtsrno1.Text) & "' and oprn ='" & sOprn & "'"
                db.updateQuery(sql)
                'Dim cmd As New SqlCommand(sql, conn)
                ' conn.Open()
                ' cmd.ExecuteNonQuery()
                ' conn.Close()

            End If
        Catch ex As System.Exception

        End Try
    End Sub

    

    Private Sub showBITGrid()
        Dim ds As New DataSet
        'If shipto = 1 and Gstatus = "A"  ie., BIT = 1
        'show serial number only in datagrid 
        Try

            '  sql = " select srlno1 as [Serial No.], wono as [Work Order No.] from OperationLogs where shipto = 1 and oprn='" & Trim(sOprn) & "'"
            sql = " select a.srlno1 as [Serial No.], mdby as [Scanned By], CONVERT(varchar, a.mddt) AS [Scanned Date]"
            sql = sql & " from OperationLogs a"
            sql = sql & " where a.shipto = 1 and a.status = 1 and a.wono = '" & Trim(sShipmentWorkOrderNO) & "' and a.oprn = '" & Trim(sOprn) & "'"
            sql = sql & " order by mddt desc"

            ds = db.selectQuery(sql)
            dgBIT.DataSource = ds.Tables(0).DefaultView
            countBITandBESA()

        Catch ex As System.Exception

        End Try
    End Sub
    Private Sub showBESAGrid()
        Dim ds As New DataSet
        'If shipto = 1 and Gstatus = "A"  ie., BESA = 1
        'show serial number only in datagrid 
        Try

            ' sql = " select srlno1 as [Serial No.], wono as [Work Order No.] from OperationLogs where (shipto = 0 or shipto is null) and oprn='" & Trim(sOprn) & "'"
            sql = " select srlno1 as [Serial No.], isnull(crby,mdby) as ScannedBy, CONVERT(varchar, crdt) AS [Scanned Date] from OperationLogs "
            sql = sql & " where shipto = 0 and wono = '" & Trim(sShipmentWorkOrderNO) & "' and oprn = '" & Trim(sOprn) & "'"
            sql = sql & " order by srlno1"

            ds1 = db.selectQuery(sql)
            dgBESA.DataSource = ds1.Tables(0).DefaultView
            countBITandBESA()
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub tbShimpment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbShipment.SelectedIndexChanged
        If (tbShipment.SelectedIndex = 0) Then
            ' tabSelected = "BESA"
            ' showBESAGrid()
            tabSelected = "BIT"
            txtsrno1.Visible = True
            showBITGrid()
        Else
            ' tabSelected = "BIT"
            'showBITGrid()
            tabSelected = "BESA"
            txtsrno1.Visible = False
            showBESAGrid()
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Private Sub dgBIT_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgBIT.MouseClick
    '    Dim inc As Integer
    '    inc = dgBIT.CurrentRowIndex
    '    If UCase(e.Button.ToString) = "LEFT" Then
    '        sShipmentWorkOrderNO = dgBIT.Item(inc, 1)
    '    Else
    '        sShipmentWorkOrderNO = ""
    '    End If
    '    FrmShipment.ShowDialog()
    'End Sub

   


    'Private Sub dgBESA_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgBESA.MouseClick
    '    Dim inc As Integer

    '    If UCase(e.Button.ToString) = "LEFT" Then
    '        sShipmentWorkOrderNO = dgBIT.Item(inc, 1)
    '    Else
    '        sShipmentWorkOrderNO = ""
    '    End If
    '    FrmShipment.ShowDialog()
    'End Sub

    Private Sub countBITandBESA()
        sql = ""
        sql = sql & "SELECT COUNT(CASE WHEN s.oprn ='" & sOprn & "' AND s.shipTo = 1 THEN s.srlno1 END) AS BIT, "
        sql = sql & " COUNT(CASE WHEN s.oprn = '" & sOprn & "' AND s.shipTo = 0 THEN s.srlno1 END) AS BESA"
        sql = sql & " From OperationLogs AS s "
        sql = sql & " where s.oprn ='" & sOprn & "' and s.wono = '" & Trim(sShipmentWorkOrderNO) & "'"
        ' sql = sql & " GROUP BY wono"
        'sql = sql & " Order By wono"
        ds = db.selectQuery(sql)
        txtBIT.Text = ds.Tables(0).Rows(0).Item("BIT").ToString()
        txtBESA.Text = ds.Tables(0).Rows(0).Item("BESA").ToString()
        txtWono.Text = sShipmentWorkOrderNO.ToString()
    End Sub
End Class



