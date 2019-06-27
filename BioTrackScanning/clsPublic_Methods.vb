Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports System.Reflection

Public Class clsPublic_Methods
    Public dsL As New DataSet
    Dim datRow As DataRow
    Public db As New Class1
    Public sMainWorkOrderNO As String
    Public sMainOperation As Integer
    Public sLogonUser As String
    Public sUpdateMode As String

    Public adPath As String = ConfigurationManager.AppSettings("loginURL")
    Public strQuery As String

    Public Function ValidateActiveDirectoryLogin(ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean = False
        Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & adPath, Username, Password)

        Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
        Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
        Try
            Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
            Success = Not (Results Is Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Success = False
        End Try
        Return (Success)
    End Function

    Public Function GetMenuData(ByVal LgnUser As String) As DataSet
        Dim strSQL As String
        Try
            '//Populate DataTable
            strSQL = ""
            strSQL = strSQL & "SELECT distinct bm.*,  br.menuid AS Expr1 FROM Biomenus bm "
            'strSQL = strSQL & " inner join "
            strSQL = strSQL & " left outer join "
            strSQL = strSQL & " biorights br on br.menuid = bm.menuid "
            If LgnUser = "*" Then
                strSQL = strSQL & " and br.roleid = 'NONE' "
            Else
                strSQL = strSQL & " and br.roleid in ( select roleid from BioUserRights where userid = '" & LgnUser & "') "
            End If
            strSQL = strSQL & " where type not in (2) and isactive = 1 order by MainMenuId, seqNo"
            dsL = db.selectQuery(strSQL)
            Return dsL

        Catch ex As System.Exception
        End Try

    End Function

    Public Function CreateMenuItem(ByVal strText As String, ByVal MnuID As Double) As MenuItem
        Try
            '//Create new menu item
            Dim menuItem As New MenuItem()

            '//Set properties of the menu item
            With menuItem
                .Text = strText
                .Tag = MnuID
            End With
            Return menuItem

        Catch ex As System.Exception
        End Try

    End Function

    Public Function DynamicallyLoadedObject(ByVal objectName As String, Optional ByVal args() As Object = Nothing) As Form

        Dim returnObj As Object = Nothing
        Dim Type As Type = Assembly.GetExecutingAssembly().GetType("MDIApplication." & objectName)

        If Type IsNot Nothing Then
            returnObj = Activator.CreateInstance(Type, args)
            'returnObj.mdiparent = MDIForm
        End If

        Return returnObj

    End Function

    Public Property GetQueryString()
        Get
            Return strQuery
        End Get
        Set(ByVal value)
            strQuery = value
        End Set
    End Property

    Public Function GetSecurityRightsMenus(ByVal sRoleID As String) As DataSet
        Dim strSQL As String
        Try
            '//Populate DataTable
            If sRoleID <> "" Then
                strSQL = ""
                strSQL = strSQL & "SELECT bm.*, CASE WHEN br.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess  FROM Biomenus bm "
                strSQL = strSQL & " Left Outer join biorights br on br.menuid = bm.menuid and bm.menuid >= 0  "
                strSQL = strSQL & " and br.roleid = '" & sRoleID & "' "
                strSQL = strSQL & " order by MainMenuId, seqNo"
            Else
                strSQL = ""
                strSQL = strSQL & "SELECT bm.*   FROM Biomenus bm order by MainMenuId, seqNo "
            End If
            dsL = db.selectQuery(strSQL)
            Return dsL

        Catch ex As System.Exception
        End Try
    End Function

    Public Function GetUserRoles(ByVal sUserID As String) As DataSet
        Dim strSQL As String
        Try

            strSQL = ""
            strSQL = strSQL & "SELECT DISTINCT br.roleid, br.rolename, bur.userid, CASE WHEN bur.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess"
            strSQL = strSQL & " FROM BioRoles AS br LEFT OUTER JOIN"
            strSQL = strSQL & " Biouserrights AS bur ON bur.userid = '" & sUserID & "' AND br.roleid = bur.roleid"
            '//Populate DataTable
            'strSQL = ""
            'strSQL = strSQL & "Select distinct bm.*, CASE WHEN br.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess FROM BioMenus AS bm "
            'strSQL = strSQL & " LEFT OUTER JOIN  BioRights AS br ON br.menuid = bm.MenuID LEFT OUTER JOIN"
            'strSQL = strSQL & " Biouserrights AS bur ON bur.roleid = br.roleid AND bur.userid = '" & sUserID & "'"
            '' strSQL = strSQL & " where bur.roleid is not null"
            'strSQL = strSQL & " order by MainMenuId, seqNo"
            'strSQL = ""
            'strSQL = strSQL & "SELECT br.roleid, CASE WHEN br.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess"
            'strSQL = strSQL & " from BioRoles AS br LEFT OUTER JOIN Biouserrights AS bur ON bur.userid = '" & sUserID & "'"
            'Dim datMenu As OleDbDataAdapter = New OleDbDataAdapter(strSQL, conn)
            dsL = db.selectQuery(strSQL)
            Return dsL

        Catch ex As System.Exception
        End Try

    End Function

    'Public Function GetWorkOrderDetails(ByVal strWorkOrderNo As String) As Boolean

    '    Sql = "SELECT project as WorkOrderNo, ItemCode as ItemCode, ItemDesc as ItemDescription, QtyActual as Quantity, facode as BatchNo, ItemStntLength as ItemStntLength, FormlnBatch as FormulationBatch FROM ZWOList WHERE project = '" & strWorkOrderNo & "' or facode = '" & strWorkOrderNo & "'"
    '    ds = db.selectQuery(Sql)
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        GetWorkOrderDetails = True
    '        stWODetails.sWorkOrderNo = Trim(ds.Tables(0).Rows(0).Item("WorkOrderNo"))
    '        stWODetails.sItemCode = Trim(ds.Tables(0).Rows(0).Item("ItemCode"))
    '        stWODetails.sItemDescription = Trim(ds.Tables(0).Rows(0).Item("ItemDescription"))
    '        stWODetails.sBatchNo = Trim(ds.Tables(0).Rows(0).Item("BatchNo"))
    '        stWODetails.nActualQty = Trim(ds.Tables(0).Rows(0).Item("Quantity"))
    '        stWODetails.nStentLength = Trim(ds.Tables(0).Rows(0).Item("ItemStntLength"))
    '        stWODetails.sFormulationBatch = Trim(ds.Tables(0).Rows(0).Item("FormulationBatch"))
    '    Else
    '        GetWorkOrderDetails = False
    '        stWODetails.sWorkOrderNo = ""
    '        stWODetails.sItemCode = ""
    '        stWODetails.sItemDescription = ""
    '        stWODetails.sBatchNo = ""
    '        stWODetails.nActualQty = 0
    '        stWODetails.nStentLength = 0
    '        stWODetails.sFormulationBatch = ""
    '    End If
    'End Function

    'Public Function GetAvaialbleSerialNos(ByVal WoNo As String)

    '    Sql = "select count(stntserial) as TotalCount from stentserials where stwono = '" & WoNo & "' and stbatch = ''"
    '    ds = db.selectQuery(Sql)

    '    Return ds.Tables(0).Rows(0).Item("TotalCount")

    'End Function

End Class
