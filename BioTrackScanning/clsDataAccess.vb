Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class clsDataAccess
    Public Shared Function GetDBConnection() As SqlConnection
        Dim oSqlConnection As SqlConnection
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim oSqlCommand As New SqlCommand
        Dim sConnString As String
        Dim strError As String
        Try
            sConnString = GetConnectionString()
            'sConnString = "Server=NEWMEDIA-DAJDXP;User ID=sa;password=Super#Long#Day;Database=conquas;Persist Security Info=True"
            'sConnString = "Server=office;User ID=sa;password=password;Database=conquas;Persist Security Info=True"
            'sConnString = "Server=RAJU\SQLEXPRESS;User ID=sa;password=admin1;Database=conquas21;Persist Security Info=True"
            'sConnString = "Server=home;User ID=sa;password=password;Database=conquas21;Persist Security Info=True"
            oSqlConnection = New SqlConnection(sConnString)
            oSqlConnection.Open()
            oSqlCommand.Connection = oSqlConnection
            oSqlCommand.CommandText = "set dateformat DMY"
            oSqlCommand.CommandType = CommandType.Text
            oSqlCommand.ExecuteNonQuery()
            GetDBConnection = oSqlConnection
        Catch
            strError = "Function : clsDataAccess.GetDBConnection " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            ''            MsgBox(strError)
        Finally
            ' oSqlConnection.Close()
            oSqlCommand = Nothing
        End Try

    End Function
    Public Shared Function GetConnectionString() As String
        Dim strError As String
        Dim str As String

        Try
            'GetConnectionString = "Server=.\SQLEXPRESS;User ID=ifadmin;password=bca100;Database=InternalFinishesDB;Persist Security Info=True"
            'Need to add system.configuration in Add Reference
            str = System.Configuration.ConfigurationManager.AppSettings("constr")
            'GetConnectionString = "Server=RAJU\SQLEXPRESS;User ID=sa;password=admin1;Database=conquas21;Persist Security Info=True"
            'GetConnectionString = "Server=office;User ID=sa;password=password;Database=conquas;Persist Security Info=True"
            'GetConnectionString = "Server=home;User ID=sa;password=password;Database=conquas21;Persist Security Info=True"
            'GetConnectionString = "Server=NEWMEDIA-DAJDXP;User ID=sa;password=Super#Long#Day;Database=conquas;Persist Security Info=True"
            GetConnectionString = str
            'MsgBox(str)
        Catch
            strError = "Function : clsDataAccess.GetConnectionString " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
        End Try
    End Function
    Public Shared Sub ExecuteQuery(ByVal strSQL As String)
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        'Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim oSqlCommand As New SqlCommand
        Dim strError As String
        'Dim sConnString As String
        Try

            oSqlConnection = GetDBConnection()
            oSqlCommand.Connection = oSqlConnection
            oSqlCommand.CommandText = strSQL
            oSqlCommand.CommandTimeout = 2400
            'oSqlCommand.CommandType = CommandType.Text
            oSqlCommand.ExecuteNonQuery()
            strError = ""
        Catch
            strError = "Function : clsDataAccess.ExecuteQuery " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)

        Finally
            'oSqlConnection = Nothing
            oSqlConnection.Close()
            oSqlCommand = Nothing
        End Try
    End Sub

    Public Shared Function ExecuteQueryRaiseError(ByVal strSQL As String)
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        'Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim oSqlCommand As New SqlCommand
        Dim strError As String
        'Dim sConnString As String
        Try
            oSqlConnection = GetDBConnection()
            oSqlCommand.Connection = oSqlConnection
            oSqlCommand.CommandText = strSQL
            oSqlCommand.CommandTimeout = 2400
            'oSqlCommand.CommandType = CommandType.Text
            oSqlCommand.ExecuteNonQuery()
            strError = ""
        Catch
            strError = "Function : clsDataAccess.ExecuteQueryRaiseError " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)

        Finally
            'oSqlConnection = Nothing
            oSqlConnection.Close()
            oSqlCommand = Nothing
        End Try
    End Function
    Public Shared Function GetDataSet(ByVal strSQL As String, ByVal strDataSetName As String) As DataSet
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection() 
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strSQL, oSqlConnection)
            oSQLCEAdrDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
            oSQLCEAdrDataAdapter.SelectCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.Fill(dstDataSet, strDataSetName)
            GetDataSet = dstDataSet
        Catch
            strError = "Function : clsDataAccess.GetDataSet " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
            Exit Function
        Finally
            oSQLCEAdrDataAdapter = Nothing
            'oSqlConnection = Nothing
            'oSqlConnection.Close()
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function GetDataSet_Report71(ByVal strSQL As String, ByVal strDataSetName As String) As DataSet
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strSQL, oSqlConnection)
            oSQLCEAdrDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
            oSQLCEAdrDataAdapter.SelectCommand.CommandTimeout = 2400
            dstDataSet.EnforceConstraints = False
            oSQLCEAdrDataAdapter.Fill(dstDataSet, strDataSetName)
            GetDataSet_Report71 = dstDataSet
        Catch
            strError = "Function : clsDataAccess.GetDataSet " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
            Exit Function
        Finally
            oSQLCEAdrDataAdapter = Nothing
            'oSqlConnection = Nothing
            oSqlConnection.Close()
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function GetDataSetByCommand(ByVal strSQL As String, ByVal strDataSetName As String) As DataSet
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim cmdForDataSet As SqlCommand
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            If oSqlConnection.State <> ConnectionState.Open Then
                oSqlConnection.Open()
            End If
            cmdForDataSet = New SqlCommand()
            cmdForDataSet.CommandText = strSQL
            cmdForDataSet.CommandTimeout = 400
            cmdForDataSet.CommandType = CommandType.Text
            cmdForDataSet.Connection = oSqlConnection
            oSQLCEAdrDataAdapter.SelectCommand = cmdForDataSet
            dstDataSet = New DataSet
            'oSQLCEAdrDataAdapter = New SqlDataAdapter(strSQL, oSqlConnection)
            'oSQLCEAdrDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey

            oSQLCEAdrDataAdapter.Fill(dstDataSet, strDataSetName)
            GetDataSetByCommand = dstDataSet
        Catch
            strError = "Function : clsDataAccess.GetDataSetByCommand " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
            Exit Function
        Finally
            oSQLCEAdrDataAdapter = Nothing
            'oSqlConnection = Nothing
            oSqlConnection.Close()
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function GetDataSet1(ByVal strSQL As String, ByVal strDataSetName As String) As DataSet
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strSQL, oSqlConnection)
            'oSQLCEAdrDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
            oSQLCEAdrDataAdapter.Fill(dstDataSet, strDataSetName)
            GetDataSet1 = dstDataSet
        Catch
            strError = "Function : clsDataAccess.GetDataSet " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
            Exit Function
        Finally
            oSQLCEAdrDataAdapter = Nothing
            'oSqlConnection = Nothing
            oSqlConnection.Close()
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function ExecuteScalarQuery(ByVal strSQL As String)
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        'Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim oSqlCommand As New SqlCommand
        Dim strError As String
        Dim intValue As String

        'Dim sConnString As String
        Try

            oSqlConnection = GetDBConnection()
            oSqlCommand.Connection = oSqlConnection
            oSqlCommand.CommandText = strSQL
            oSqlCommand.CommandTimeout = 2400
            'oSqlCommand.CommandType = CommandType.Text
            intValue = oSqlCommand.ExecuteScalar()
            Return intValue
            strError = ""
        Catch
            strError = "Function : clsDataAccess.ExecuteQuery " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)

        Finally
            'oSqlConnection = Nothing
            oSqlConnection.Close()
            oSqlCommand = Nothing
        End Try
    End Function
    Public Shared Function ExecuteNonScalar(ByVal strSQL As String)
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        'Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim oSqlCommand As New SqlCommand
        Dim strError As String
        Dim decValue As Decimal

        'Dim sConnString As String
        Try

            oSqlConnection = GetDBConnection()
            oSqlCommand.Connection = oSqlConnection
            oSqlCommand.CommandText = strSQL
            oSqlCommand.CommandTimeout = 2400
            'oSqlCommand.CommandType = CommandType.Text
            decValue = oSqlCommand.ExecuteScalar()
            Return decValue
            strError = ""
        Catch
            strError = "Function : clsDataAccess.ExecuteQuery " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)

        Finally
            '            oSqlConnection = Nothing
            oSqlConnection.Close()
            oSqlCommand = Nothing
        End Try
    End Function
    Public Shared Function StrExecute(ByVal strSQL As String)
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        'Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim oSqlCommand As New SqlCommand
        Dim strError As String
        Dim strValue As String

        Try

            oSqlConnection = GetDBConnection()
            oSqlCommand.Connection = oSqlConnection
            oSqlCommand.CommandText = strSQL
            oSqlCommand.CommandTimeout = 2400
            strValue = oSqlCommand.ExecuteScalar()
            Return strValue
            strError = ""
        Catch
            strError = "Function : clsDataAccess.ExecuteQuery " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)

        Finally
            '            oSqlConnection = Nothing
            oSqlConnection.Close()
            oSqlCommand = Nothing
        End Try
    End Function
    Public Shared Function GetProjectData(ByVal strProjectID As String, ByVal strDataSetName As String) As DataSet

        Dim dstDataSet As New DataSet
        Dim dstDataSetCategory As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Dim strProjecSQL As String
        Dim strCategSQL As String
        Dim intRowCount As Integer
        Dim iLoop As Integer
        'Dim chkTargetScoreFlag As String
        Dim oSQLCEAdrDataAdapter As SqlDataAdapter
        Dim dstFinalDataSet As New DataSet
        Dim dstFinalTable As New DataTable

        dstFinalTable.Columns.Add("ProjectID")
        dstFinalTable.Columns.Add("CATEGORY_CODE")
        dstFinalTable.Columns.Add("CATEGORY_NAME")
        dstFinalTable.Columns.Add("PROJECT_SHORT_NAME")
        dstFinalTable.Columns.Add("PROJECT_NAME")
        dstFinalTable.Columns.Add("PROJECT_CLASS")
        dstFinalTable.Columns.Add("PROJECT_ZONE_LOCATION")
        dstFinalTable.Columns.Add("PROJECT_LOCATION")
        dstFinalTable.Columns.Add("NO_OF_BUILDINGS")
        dstFinalTable.Columns.Add("SITE_OFFICE_PHONE")
        dstFinalTable.Columns.Add("SITE_OFFICE_FAX")
        dstFinalTable.Columns.Add("CONTACT_PERSON_1")
        dstFinalTable.Columns.Add("CONTACT_PERSON_1_HP")
        dstFinalTable.Columns.Add("CONTACT_PERSON_1_PG")
        dstFinalTable.Columns.Add("CONTACT_PERSON_2")
        dstFinalTable.Columns.Add("CONTACT_PERSON_2_HP")
        dstFinalTable.Columns.Add("CONTACT_PERSON_2_PG")
        dstFinalTable.Columns.Add("CONTACT_PERSON_3")
        dstFinalTable.Columns.Add("CONTACT_PERSON_3_HP")
        dstFinalTable.Columns.Add("CONTACT_PERSON_3_PG")
        dstFinalTable.Columns.Add("FIRST_ASSESSMENT_DATE")
        dstFinalTable.Columns.Add("TENDER_DATE")
        dstFinalTable.Columns.Add("STRUCTURE_END_DATE")
        dstFinalTable.Columns.Add("ARCH_START_DATE")
        dstFinalTable.Columns.Add("ARCH_END_DATE")
        dstFinalTable.Columns.Add("PROJECT_START_DATE")
        dstFinalTable.Columns.Add("PROJECT_END_DATE")
        dstFinalTable.Columns.Add("GROSS_FLOOR_AREA")
        dstFinalTable.Columns.Add("COST_STRUCTURAL_STEEL")
        dstFinalTable.Columns.Add("COST_PRESTRESS_CONCRETE")
        dstFinalTable.Columns.Add("COST_STRUCTURAL_RC_WORK")
        dstFinalTable.Columns.Add("COST_STRUCTURAL_WORK")
        dstFinalTable.Columns.Add("APPLICATION_DATE")

        dstFinalTable.Columns.Add("CIVIL_ENGINEER")
        dstFinalTable.Columns.Add("ME_ENGINEER")
        dstFinalTable.Columns.Add("QUANTITY_SURVEYOR")
        dstFinalTable.Columns.Add("PROJECT_BUILT_ON")
        dstFinalTable.Columns.Add("APPLICATION_REASON")
        dstFinalTable.Columns.Add("TARGET_SCORE_FLAG")
        dstFinalTable.Columns.Add("AGENCY_TARGET_SCORE")
        dstFinalTable.Columns.Add("CONTRACT_SUM")
        dstFinalTable.Columns.Add("STRUCTURE_TYPE")
        dstFinalTable.Columns.Add("STRUCTURE_REVIEW_SCORE")
        dstFinalTable.Columns.Add("ME_REVIEW_SCORE")
        dstFinalTable.Columns.Add("LINKWAY_SHELTER")
        dstFinalTable.Columns.Add("APRON_DRAIN")
        dstFinalTable.Columns.Add("ROADWORK_CARPARK")
        dstFinalTable.Columns.Add("FOOTPATH_TURFING")
        dstFinalTable.Columns.Add("PLAYGROUND")
        dstFinalTable.Columns.Add("COURT")
        dstFinalTable.Columns.Add("FENCING_GATE")
        dstFinalTable.Columns.Add("SWIMMING_POOL")
        dstFinalTable.Columns.Add("CLUB_HOUSE")
        dstFinalTable.Columns.Add("GUARD_HOUSE")
        dstFinalTable.Columns.Add("ELECTRICAL_STATION")
        dstFinalTable.Columns.Add("FLAT_ROOF")
        dstFinalTable.Columns.Add("PLASTERING_SAND")
        dstFinalTable.Columns.Add("ARCHITECT_NAME")
        dstFinalTable.Columns.Add("CONTRACTOR_NAME")
        dstFinalTable.Columns.Add("CONTRACTOR_REG_NO")
        dstFinalTable.Columns.Add("CREATE_DATE")
        dstFinalTable.Columns.Add("CREATE_USER_ID")
        dstFinalTable.Columns.Add("MODIFY_DATE")
        dstFinalTable.Columns.Add("ARCH_REVIEW_SCORE")
        dstFinalTable.Columns.Add("DEVELOPER_NAME")
        dstFinalTable.Columns.Add("DEVELOPER_REG_NO")
        dstFinalTable.Columns.Add("ACTUAL_END_DATE")
        dstFinalTable.Columns.Add("REMARKS")
        dstFinalTable.Columns.Add("CERTIFICATE_STATUS")
        dstFinalTable.Columns.Add("CHANGE_REMARK")
        dstFinalTable.Columns.Add("PROJECT_STATUS")
        dstFinalTable.Columns.Add("NDT_COV_CEILING")
        dstFinalTable.Columns.Add("NDT_COV_BEAM_SIDE")
        dstFinalTable.Columns.Add("NDT_COV_BEAM_SOFFIT")
        dstFinalTable.Columns.Add("NDT_COV_WALL")
        dstFinalTable.Columns.Add("NDT_COV_COLUMN")
        dstFinalTable.Columns.Add("NDT_COV_SLAB")
        dstFinalTable.Columns.Add("RI_INSPECTION_DATE")
        dstFinalTable.Columns.Add("PROJECT_TYPE")
        dstFinalTable.Columns.Add("FINAL_CONQUAS_SCORE")
        dstFinalTable.Columns.Add("NO_WET_AREAS")
        dstFinalTable.Columns.Add("NO_WINDOWS")


        dstFinalDataSet.Tables.Add(dstFinalTable)

        Dim gridrow As DataRow = dstFinalTable.NewRow()
        Dim strCategoryCode As String
        Try
            iLoop = 0
            oSqlConnection = GetDBConnection()
            'strProjecSQL = "select * from project where PROJECT_ID = '" & strProjectID & "'"
            strProjecSQL = "select PROJECT_ID,CATEGORY_CODE,PROJECT_SHORT_NAME,PROJECT_NAME,PROJECT_CLASS,PROJECT_LOCATION,PROJECT_ZONE_LOCATION,NO_OF_BUILDINGS,SITE_OFFICE_PHONE,SITE_OFFICE_FAX,CONTACT_PERSON_1,CONTACT_PERSON_1_HP,CONTACT_PERSON_1_PG,CONTACT_PERSON_2,CONTACT_PERSON_2_HP,CONTACT_PERSON_2_PG,CONTACT_PERSON_3,CONTACT_PERSON_3_HP,CONTACT_PERSON_3_PG,convert(varchar(11),FIRST_ASSESSMENT_DATE,103)AS FIRST_ASSESSMENT_DATE , convert(varchar(11),STRUCTURE_START_DATE,103)AS STRUCTURE_START_DATE,convert(varchar(11),STRUCTURE_END_DATE,103) AS STRUCTURE_END_DATE ,convert(varchar(11),ARCH_START_DATE,103) AS ARCH_START_DATE,convert(varchar(11),ARCH_END_DATE,103)AS ARCH_END_DATE ,convert(varchar(11),PROJECT_START_DATE,103) AS PROJECT_START_DATE,convert(varchar(11),PROJECT_END_DATE,103) AS PROJECT_END_DATE,GROSS_FLOOR_AREA,COST_STRUCTURAL_STEEL,COST_PRESTRESS_CONCRETE,COST_STRUCTURAL_WORK,COST_STRUCTURAL_RC_WORK,convert(varchar(11),APPLICATION_DATE,103)AS APPLICATION_DATE ,CIVIL_ENGINEER,ME_ENGINEER,QUANTITY_SURVEYOR,PROJECT_BUILT_ON, APPLICATION_REASON,TARGET_SCORE_FLAG,AGENCY_TARGET_SCORE,CONTRACT_SUM,STRUCTURE_TYPE,STRUCTURE_REVIEW_SCORE,ME_REVIEW_SCORE,LINKWAY_SHELTER, APRON_DRAIN, ROADWORK_CARPARK, FOOTPATH_TURFING, PLAYGROUND, COURT,FENCING_GATE,SWIMMING_POOL,CLUB_HOUSE,GUARD_HOUSE,ELECTRICAL_STATION, FLAT_ROOF, PLASTERING_SAND, ARCHITECT_NAME,CONTRACTOR_NAME,CONTRACTOR_REG_NO,convert(varchar(11),CREATE_DATE,103)AS CREATE_DATE ,CREATE_USER_ID,convert(varchar(11),MODIFY_DATE,103) AS MODIFY_DATE,MODIFY_USER_ID, ARCH_REVIEW_SCORE,DEVELOPER_NAME,DEVELOPER_REG_NO,convert(varchar(11),ACTUAL_END_DATE,103) AS ACTUAL_END_DATE,REMARKS,CERTIFICATE_STATUS,CHANGE_REMARK,PROJECT_STATUS, NDT_COV_CEILING,NDT_COV_BEAM_SIDE,NDT_COV_BEAM_SOFFIT,NDT_COV_WALL,NDT_COV_COLUMN,NDT_COV_SLAB,convert(varchar(11),RI_INSPECTION_DATE,103) AS RI_INSPECTION_DATE,PROJECT_TYPE,FINAL_CONQUAS_SCORE,convert(varchar(11),TENDER_DATE,103) AS TENDER_DATE,NO_WET_AREAS,NO_WINDOWS from project where PROJECT_ID = '" & strProjectID & "'"

            dstDataSet = clsDataAccess.GetDataSet(strProjecSQL, "dstDataSet")
            intRowCount = dstDataSet.Tables(0).Rows.Count

            For iLoop = 0 To intRowCount - 1

                gridrow("ProjectID") = strProjectID

                gridrow("CATEGORY_CODE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CATEGORY_CODE")), "", dstDataSet.Tables(0).Rows(iLoop)("CATEGORY_CODE"))
                strCategoryCode = dstDataSet.Tables(0).Rows(iLoop)("CATEGORY_CODE").ToString

                strCategSQL = "Select * From PROJECT_CATEGORY where CATEGORY_CODE=" & "'" & strCategoryCode & "'"
                dstDataSetCategory = clsDataAccess.GetDataSet(strCategSQL, "dstDataSetCategory")
                gridrow("PROJECT_SHORT_NAME") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_SHORT_NAME")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_SHORT_NAME"))
                gridrow("PROJECT_NAME") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_NAME")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_NAME"))
                gridrow("PROJECT_CLASS") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_CLASS")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_CLASS"))
                gridrow("PROJECT_ZONE_LOCATION") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_ZONE_LOCATION")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_ZONE_LOCATION"))
                gridrow("PROJECT_LOCATION") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_LOCATION")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_LOCATION"))
                gridrow("NO_OF_BUILDINGS") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NO_OF_BUILDINGS")), "", dstDataSet.Tables(0).Rows(iLoop)("NO_OF_BUILDINGS"))
                gridrow("SITE_OFFICE_PHONE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("SITE_OFFICE_PHONE")), "", dstDataSet.Tables(0).Rows(iLoop)("SITE_OFFICE_PHONE"))
                gridrow("SITE_OFFICE_FAX") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("SITE_OFFICE_FAX")), "", dstDataSet.Tables(0).Rows(iLoop)("SITE_OFFICE_FAX"))
                gridrow("CONTACT_PERSON_1") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_1")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_1"))
                gridrow("CONTACT_PERSON_1_HP") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_1_HP")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_1_HP"))
                gridrow("CONTACT_PERSON_1_PG") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_1_PG")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_1_PG"))
                gridrow("CONTACT_PERSON_2") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_2")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_2"))
                gridrow("CONTACT_PERSON_2_HP") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_2_HP")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_2_HP"))
                gridrow("CONTACT_PERSON_2_PG") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_2_PG")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_2_PG"))
                gridrow("CONTACT_PERSON_3") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_3")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_3"))
                gridrow("CONTACT_PERSON_3_HP") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_3_HP")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_3_HP"))
                gridrow("CONTACT_PERSON_3_PG") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_3_PG")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTACT_PERSON_3_PG"))
                If IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("FIRST_ASSESSMENT_DATE")) = False Then
                    'gridrow("FIRST_ASSESSMENT_DATE") = Format((dstDataSet.Tables(0).Rows(iLoop)("FIRST_ASSESSMENT_DATE")), "dd/MM/yyyy")
                    gridrow("FIRST_ASSESSMENT_DATE") = dstDataSet.Tables(0).Rows(iLoop)("FIRST_ASSESSMENT_DATE")
                End If
                If IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("TENDER_DATE")) = False Then
                    'gridrow("TENDER_DATE") = Format((dstDataSet.Tables(0).Rows(iLoop)("TENDER_DATE")), "dd/MM/yyyy")
                    gridrow("TENDER_DATE") = dstDataSet.Tables(0).Rows(iLoop)("TENDER_DATE")
                End If
                If IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("STRUCTURE_END_DATE")) = False Then
                    'gridrow("STRUCTURE_END_DATE") = Format((dstDataSet.Tables(0).Rows(iLoop)("STRUCTURE_END_DATE")), "dd/MM/yyyy")
                    gridrow("STRUCTURE_END_DATE") = dstDataSet.Tables(0).Rows(iLoop)("STRUCTURE_END_DATE")
                End If
                If IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ARCH_START_DATE")) = False Then
                    'gridrow("ARCH_START_DATE") = Format((dstDataSet.Tables(0).Rows(iLoop)("ARCH_START_DATE")), "dd/MM/yyyy")
                    gridrow("ARCH_START_DATE") = dstDataSet.Tables(0).Rows(iLoop)("ARCH_START_DATE")
                End If
                gridrow("ARCH_START_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ARCH_START_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("ARCH_START_DATE"))
                gridrow("ARCH_END_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ARCH_END_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("ARCH_END_DATE"))
                gridrow("PROJECT_START_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_START_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_START_DATE"))
                gridrow("PROJECT_END_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_END_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_END_DATE"))
                gridrow("GROSS_FLOOR_AREA") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("GROSS_FLOOR_AREA")), "", dstDataSet.Tables(0).Rows(iLoop)("GROSS_FLOOR_AREA"))
                gridrow("COST_STRUCTURAL_STEEL") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("COST_STRUCTURAL_STEEL")), "", dstDataSet.Tables(0).Rows(iLoop)("COST_STRUCTURAL_STEEL"))
                gridrow("COST_PRESTRESS_CONCRETE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("COST_PRESTRESS_CONCRETE")), "", dstDataSet.Tables(0).Rows(iLoop)("COST_PRESTRESS_CONCRETE"))
                gridrow("COST_STRUCTURAL_RC_WORK") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("COST_STRUCTURAL_RC_WORK")), "", dstDataSet.Tables(0).Rows(iLoop)("COST_STRUCTURAL_RC_WORK"))
                gridrow("COST_STRUCTURAL_WORK") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("COST_STRUCTURAL_WORK")), "", dstDataSet.Tables(0).Rows(iLoop)("COST_STRUCTURAL_WORK"))
                gridrow("APPLICATION_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("APPLICATION_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("APPLICATION_DATE"))
                gridrow("CIVIL_ENGINEER") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CIVIL_ENGINEER")), "", dstDataSet.Tables(0).Rows(iLoop)("CIVIL_ENGINEER"))
                gridrow("ME_ENGINEER") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ME_ENGINEER")), "", dstDataSet.Tables(0).Rows(iLoop)("ME_ENGINEER"))
                gridrow("QUANTITY_SURVEYOR") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("QUANTITY_SURVEYOR")), "", dstDataSet.Tables(0).Rows(iLoop)("QUANTITY_SURVEYOR"))
                gridrow("PROJECT_BUILT_ON") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_BUILT_ON")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_BUILT_ON"))
                gridrow("APPLICATION_REASON") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("APPLICATION_REASON")), "", dstDataSet.Tables(0).Rows(iLoop)("APPLICATION_REASON"))
                gridrow("TARGET_SCORE_FLAG") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("TARGET_SCORE_FLAG")), "", dstDataSet.Tables(0).Rows(iLoop)("TARGET_SCORE_FLAG"))
                gridrow("AGENCY_TARGET_SCORE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("AGENCY_TARGET_SCORE")), 0, dstDataSet.Tables(0).Rows(iLoop)("AGENCY_TARGET_SCORE"))
                gridrow("CONTRACT_SUM") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTRACT_SUM")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTRACT_SUM"))
                gridrow("STRUCTURE_TYPE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("STRUCTURE_TYPE")), "", dstDataSet.Tables(0).Rows(iLoop)("STRUCTURE_TYPE"))
                gridrow("STRUCTURE_REVIEW_SCORE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("STRUCTURE_REVIEW_SCORE")), "", dstDataSet.Tables(0).Rows(iLoop)("STRUCTURE_REVIEW_SCORE"))
                gridrow("ME_REVIEW_SCORE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ME_REVIEW_SCORE")), 0, dstDataSet.Tables(0).Rows(iLoop)("ME_REVIEW_SCORE"))

                gridrow("LINKWAY_SHELTER") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("LINKWAY_SHELTER")), "", dstDataSet.Tables(0).Rows(iLoop)("LINKWAY_SHELTER"))
                gridrow("APRON_DRAIN") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("APRON_DRAIN")), "", dstDataSet.Tables(0).Rows(iLoop)("APRON_DRAIN"))
                gridrow("ROADWORK_CARPARK") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ROADWORK_CARPARK")), "", dstDataSet.Tables(0).Rows(iLoop)("ROADWORK_CARPARK"))
                gridrow("FOOTPATH_TURFING") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("FOOTPATH_TURFING")), "", dstDataSet.Tables(0).Rows(iLoop)("FOOTPATH_TURFING"))
                gridrow("PLAYGROUND") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PLAYGROUND")), "", dstDataSet.Tables(0).Rows(iLoop)("PLAYGROUND"))
                gridrow("COURT") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("COURT")), "", dstDataSet.Tables(0).Rows(iLoop)("COURT"))
                gridrow("FENCING_GATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("FENCING_GATE")), "", dstDataSet.Tables(0).Rows(iLoop)("FENCING_GATE"))
                gridrow("SWIMMING_POOL") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("SWIMMING_POOL")), "", dstDataSet.Tables(0).Rows(iLoop)("SWIMMING_POOL"))
                gridrow("CLUB_HOUSE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CLUB_HOUSE")), "", dstDataSet.Tables(0).Rows(iLoop)("CLUB_HOUSE"))
                gridrow("GUARD_HOUSE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("GUARD_HOUSE")), "", dstDataSet.Tables(0).Rows(iLoop)("GUARD_HOUSE"))
                gridrow("ELECTRICAL_STATION") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ELECTRICAL_STATION")), "", dstDataSet.Tables(0).Rows(iLoop)("ELECTRICAL_STATION"))

                gridrow("FLAT_ROOF") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("FLAT_ROOF")), "", dstDataSet.Tables(0).Rows(iLoop)("FLAT_ROOF"))
                gridrow("PLASTERING_SAND") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PLASTERING_SAND")), "", dstDataSet.Tables(0).Rows(iLoop)("PLASTERING_SAND"))

                gridrow("ARCHITECT_NAME") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ARCHITECT_NAME")), "", dstDataSet.Tables(0).Rows(iLoop)("ARCHITECT_NAME"))
                gridrow("CONTRACTOR_NAME") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTRACTOR_NAME")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTRACTOR_NAME"))
                gridrow("CONTRACTOR_REG_NO") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CONTRACTOR_REG_NO")), "", dstDataSet.Tables(0).Rows(iLoop)("CONTRACTOR_REG_NO"))
                gridrow("CREATE_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CREATE_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("CREATE_DATE"))
                gridrow("CREATE_USER_ID") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CREATE_USER_ID")), "", dstDataSet.Tables(0).Rows(iLoop)("CREATE_USER_ID"))
                gridrow("MODIFY_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("MODIFY_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("MODIFY_DATE"))
                gridrow("ARCH_REVIEW_SCORE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ARCH_REVIEW_SCORE")), 0, dstDataSet.Tables(0).Rows(iLoop)("ARCH_REVIEW_SCORE"))
                gridrow("DEVELOPER_NAME") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("DEVELOPER_NAME")), "", dstDataSet.Tables(0).Rows(iLoop)("DEVELOPER_NAME"))
                gridrow("DEVELOPER_REG_NO") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("DEVELOPER_REG_NO")), 0, dstDataSet.Tables(0).Rows(iLoop)("DEVELOPER_REG_NO"))
                gridrow("ACTUAL_END_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("ACTUAL_END_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("ACTUAL_END_DATE"))
                gridrow("REMARKS") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("REMARKS")), "", dstDataSet.Tables(0).Rows(iLoop)("REMARKS"))
                gridrow("CERTIFICATE_STATUS") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CERTIFICATE_STATUS")), "", dstDataSet.Tables(0).Rows(iLoop)("CERTIFICATE_STATUS"))
                gridrow("CHANGE_REMARK") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("CHANGE_REMARK")), "", dstDataSet.Tables(0).Rows(iLoop)("CHANGE_REMARK"))
                gridrow("PROJECT_STATUS") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_STATUS")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_STATUS"))
                gridrow("NDT_COV_CEILING") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_CEILING")), "", dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_CEILING"))
                gridrow("NDT_COV_BEAM_SIDE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_BEAM_SIDE")), "", dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_BEAM_SIDE"))
                gridrow("NDT_COV_BEAM_SOFFIT") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_BEAM_SOFFIT")), "", dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_BEAM_SOFFIT"))
                gridrow("NDT_COV_WALL") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_WALL")), "", dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_WALL"))
                gridrow("NDT_COV_COLUMN") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_COLUMN")), "", dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_COLUMN"))
                gridrow("NDT_COV_SLAB") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_SLAB")), "", dstDataSet.Tables(0).Rows(iLoop)("NDT_COV_SLAB"))
                gridrow("RI_INSPECTION_DATE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("RI_INSPECTION_DATE")), "", dstDataSet.Tables(0).Rows(iLoop)("RI_INSPECTION_DATE"))
                gridrow("PROJECT_TYPE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("PROJECT_TYPE")), "", dstDataSet.Tables(0).Rows(iLoop)("PROJECT_TYPE"))
                gridrow("NO_WINDOWS") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NO_WINDOWS")), 0, dstDataSet.Tables(0).Rows(iLoop)("NO_WINDOWS"))
                gridrow("NO_WET_AREAS") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("NO_WET_AREAS")), 0, dstDataSet.Tables(0).Rows(iLoop)("NO_WET_AREAS"))


                gridrow("FINAL_CONQUAS_SCORE") = IIf(IsDBNull(dstDataSet.Tables(0).Rows(iLoop)("FINAL_CONQUAS_SCORE")), "", dstDataSet.Tables(0).Rows(iLoop)("FINAL_CONQUAS_SCORE"))

                dstFinalDataSet.Tables(0).Rows.Add(gridrow)
            Next iLoop
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strProjecSQL, oSqlConnection)
            oSQLCEAdrDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
            oSQLCEAdrDataAdapter.Fill(dstDataSet, strDataSetName)
            GetProjectData = dstDataSet

        Catch
            strError = "Function : clsDataAccess.GetDataSet " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            Exit Function
        Finally
            oSQLCEAdrDataAdapter = Nothing
            oSqlConnection.Close()
            dstDataSet = Nothing
        End Try

    End Function
    Public Shared Function GetDataSetRaiseError(ByVal strSQL As String, ByVal strDataSetName As String) As DataSet
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strSQL, oSqlConnection)
            oSQLCEAdrDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey

            oSQLCEAdrDataAdapter.Fill(dstDataSet, strDataSetName)
            GetDataSetRaiseError = dstDataSet
        Catch
            strError = "Function : clsDataAccess.GetDataSetRaiseError " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)

        Finally
            oSQLCEAdrDataAdapter = Nothing
            oSqlConnection = Nothing
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function UpdateDataSet(ByVal dstUpdate As DataSet, ByVal strQuery As String) As Integer
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strQuery, oSqlConnection)
            Dim oSQLCECommBuild As New SqlCommandBuilder(oSQLCEAdrDataAdapter)
            oSQLCEAdrDataAdapter.InsertCommand = oSQLCECommBuild.GetInsertCommand()
            oSQLCEAdrDataAdapter.UpdateCommand = oSQLCECommBuild.GetUpdateCommand()
            oSQLCEAdrDataAdapter.InsertCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.UpdateCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.Update(dstUpdate.Tables(0))
            UpdateDataSet = 1
        Catch
            strError = "Function : clsDataAccess.UpdateDataSet " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
        Finally
            oSqlConnection = Nothing
            oSQLCEAdrDataAdapter = Nothing
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function UpdateDataSet_Report16(ByVal dstUpdate As DataSet, ByVal strQuery As String) As Integer
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strQuery, oSqlConnection)
            Dim oSQLCECommBuild As New SqlCommandBuilder(oSQLCEAdrDataAdapter)
            oSQLCEAdrDataAdapter.InsertCommand = oSQLCECommBuild.GetInsertCommand()
            'oSQLCEAdrDataAdapter.UpdateCommand = oSQLCECommBuild.GetUpdateCommand()
            oSQLCEAdrDataAdapter.InsertCommand.CommandTimeout = 2400
            'oSQLCEAdrDataAdapter.UpdateCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.Update(dstUpdate.Tables(0))
            UpdateDataSet_Report16 = 1
        Catch
            strError = "Function : clsDataAccess.UpdateDataSet " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
        Finally
            oSqlConnection = Nothing
            oSQLCEAdrDataAdapter = Nothing
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function UpdateDataSetNoKey(ByVal dstUpdate As DataSet, ByVal strQuery As String) As Integer
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strQuery, oSqlConnection)
            Dim oSQLCECommBuild As New SqlCommandBuilder(oSQLCEAdrDataAdapter)
            oSQLCEAdrDataAdapter.InsertCommand = oSQLCECommBuild.GetInsertCommand()
            oSQLCEAdrDataAdapter.UpdateCommand = oSQLCECommBuild.GetUpdateCommand()
            oSQLCEAdrDataAdapter.InsertCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.UpdateCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.Update(dstUpdate.Tables(0))
            UpdateDataSetNoKey = 1
        Catch
            strError = "Function : clsDataAccess.UpdateDataSetNoKey " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
            'MsgBox(strError)
        Finally
            oSqlConnection = Nothing
            oSQLCEAdrDataAdapter = Nothing
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function UpdateDataSetRaiseError(ByVal dstUpdate As DataSet, ByVal strQuery As String) As Integer
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim oSqlConnection As SqlConnection
        Dim strError As String
        Try
            oSqlConnection = GetDBConnection()
            oSQLCEAdrDataAdapter = New SqlDataAdapter(strQuery, oSqlConnection)
            Dim oSQLCECommBuild As New SqlCommandBuilder(oSQLCEAdrDataAdapter)
            oSQLCEAdrDataAdapter.InsertCommand = oSQLCECommBuild.GetInsertCommand()
            oSQLCEAdrDataAdapter.UpdateCommand = oSQLCECommBuild.GetUpdateCommand()
            oSQLCEAdrDataAdapter.InsertCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.UpdateCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.Update(dstUpdate.Tables(0))
            UpdateDataSetRaiseError = 1
        Catch
            strError = "Function : clsDataAccessServer.UpdateDataSetRaiseError " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
        Finally
            'oSqlConnection = Nothing
            oSqlConnection.Close()
            oSQLCEAdrDataAdapter = Nothing
            dstDataSet = Nothing
        End Try
    End Function
    Public Shared Function ExecuteQueryRaiseError1(ByVal strSQL As String, ByVal cnConn As SqlConnection, ByVal cnTran As SqlTransaction)
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        'Dim dstDataSet As New DataSet
        '  Dim oSqlConnection As SqlConnection
        Dim oSqlCommand As SqlCommand
        Dim strError As String
        'Dim sConnString As String
        Try
            'oSqlConnection = GetDBConnection()
            oSqlCommand = New SqlCommand(strSQL, cnConn)
            'oSqlCommand.Connection = cnConn
            oSqlCommand.CommandText = strSQL
            oSqlCommand.CommandTimeout = 2400
            oSqlCommand.Transaction = cnTran
            'oSqlCommand.CommandType = CommandType.Text
            oSqlCommand.ExecuteNonQuery()
            strError = ""
        Catch


            strError = "Function : clsDataAccess.ExecuteQueryRaiseError " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)

        Finally
            'oSqlConnection = Nothing
            'oSqlConnection.Close()
            oSqlCommand = Nothing
        End Try
    End Function
    Public Shared Function UpdateDataSetRaiseError1(ByVal dstUpdate As DataSet, ByVal strQuery As String, ByVal cnConn As SqlConnection, ByVal cnTran As SqlTransaction) As Integer
        Dim oSQLCEAdrDataAdapter As New SqlDataAdapter
        Dim dstDataSet As New DataSet
        Dim strError As String
        Dim oSqlCommand As SqlCommand
        Try
            oSqlCommand = New SqlCommand(strQuery, cnConn)
            oSqlCommand.Transaction = cnTran
            oSQLCEAdrDataAdapter = New SqlDataAdapter(oSqlCommand)
            Dim oSQLCECommBuild As New SqlCommandBuilder(oSQLCEAdrDataAdapter)
            oSQLCEAdrDataAdapter.InsertCommand = oSQLCECommBuild.GetInsertCommand()
            oSQLCEAdrDataAdapter.UpdateCommand = oSQLCECommBuild.GetUpdateCommand()
            oSQLCEAdrDataAdapter.InsertCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.UpdateCommand.CommandTimeout = 2400
            oSQLCEAdrDataAdapter.Update(dstUpdate.Tables(0))
            UpdateDataSetRaiseError1 = 1
        Catch
            strError = "Function : clsDataAccessServer.UpdateDataSetRaiseError1 " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            Throw New ApplicationException(strError)
        Finally
            'oSqlConnection = Nothing

            oSQLCEAdrDataAdapter = Nothing
            dstDataSet = Nothing
        End Try
    End Function
End Class
