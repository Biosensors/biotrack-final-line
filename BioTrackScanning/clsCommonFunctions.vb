Imports System.Data
Imports System.Data.SqlClient
Public Class clsCommonFunctions

    Public Shared Function ReadErrorMessage(ByVal strMessageCode As String, Optional ByVal strParam1 As String = "", Optional ByVal strParam2 As String = "", Optional ByVal strParam3 As String = "") As String
        Dim dstMessage As New DataSet
        Dim strMessage As String
        Dim strSQL As String
        Dim strError As String
        Try
            strSQL = "Select * from ERROR_MESSAGES Where Upper(RTrim(ERROR_CODE))='" & Trim(strMessageCode) & "'"
            dstMessage = clsDataAccess.GetDataSet(strSQL, "Message")
            If dstMessage.Tables.Count > 0 Then
                If dstMessage.Tables(0).Rows.Count > 0 Then
                    strMessage = dstMessage.Tables(0).Rows(0)("ERROR_MESSAGE")
                    strMessage = strMessage.Replace("%1", strParam1)
                    strMessage = strMessage.Replace("%2", strParam2)
                    strMessage = strMessage.Replace("%3", strParam3)
                    ReadErrorMessage = strMessage
                    Exit Function
                End If
            End If
        Catch
            strError = "Function : clsCommonFunctions.ErrorMessage " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            MsgBox(strError)
            Exit Function
        Finally

            dstMessage = Nothing
        End Try
        ReadErrorMessage = ""
    End Function

    Public Shared Function GetSequenceNumberForDocPage(ByVal strProjectNumber As String, ByVal strSequenceName As String) As Long

        Dim dstDaSeqNo As New DataSet
        Dim strSQL As String
        'Dim strDesc As String
        Dim strError As String
        Dim lngSequenceNumber As Long
        Try
            strSQL = "Select * from Sequence Where Upper(RTrim(SequenceName))='" & UCase(Trim(strSequenceName)) & "' and PROJECT_ID='" & Trim(strProjectNumber) & "'"
            dstDaSeqNo = clsDataAccess.GetDataSet(strSQL, "Sequence")
            If dstDaSeqNo.Tables.Count > 0 Then
                If dstDaSeqNo.Tables(0).Rows.Count > 0 Then
                    lngSequenceNumber = dstDaSeqNo.Tables(0).Rows(0)("CurrNumber")
                    GetSequenceNumberForDocPage = lngSequenceNumber
                    lngSequenceNumber = lngSequenceNumber + 1
                    dstDaSeqNo.Tables(0).Rows(0)("CurrNumber") = lngSequenceNumber
                    clsDataAccess.UpdateDataSet(dstDaSeqNo, "Select * from Sequence")
                    Exit Function
                End If
            End If
        Catch
            strError = "Function : clsCommonFunctions.GetSequenceNumber " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            MsgBox(strError)
            Exit Function
        Finally

        End Try
        GetSequenceNumberForDocPage = 0
    End Function
    Public Shared Function GetSequenceNumberOthers(ByVal strSequenceName As String) As Long

        Dim dstDaSeqNo As New DataSet
        Dim strSQL As String
        'Dim strDesc As String
        Dim strError As String
        Dim lngSequenceNumber As Long
        Try
            strSQL = "Select * from SequenceOthers Where Upper(RTrim(SequenceName))='" & UCase(Trim(strSequenceName)) & "'"
            dstDaSeqNo = clsDataAccess.GetDataSet(strSQL, "Sequence")
            If dstDaSeqNo.Tables.Count > 0 Then
                If dstDaSeqNo.Tables(0).Rows.Count > 0 Then
                    lngSequenceNumber = dstDaSeqNo.Tables(0).Rows(0)("CurrNumber")
                    GetSequenceNumberOthers = lngSequenceNumber
                    lngSequenceNumber = lngSequenceNumber + 1
                    dstDaSeqNo.Tables(0).Rows(0)("CurrNumber") = lngSequenceNumber
                    clsDataAccess.UpdateDataSet(dstDaSeqNo, "Select * from SequenceOthers")
                    Exit Function
                End If
            End If
        Catch
            strError = "Function : clsCommonFunctions.GetSequenceNumberOthers " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            MsgBox(strError)
            Exit Function
        Finally

        End Try
        GetSequenceNumberOthers = 0
    End Function
    Public Shared Function GetSequenceNumber(ByVal strSequenceName As String) As Long

        Dim dstDaSeqNo As New DataSet
        Dim strSQL As String
        'Dim strDesc As String
        Dim strError As String
        Dim lngSequenceNumber As Long
        Try
            strSQL = "Select * from Sequence Where Upper(RTrim(SequenceName))='" & UCase(Trim(strSequenceName)) & "'"
            dstDaSeqNo = clsDataAccess.GetDataSet(strSQL, "Sequence")
            If dstDaSeqNo.Tables.Count > 0 Then
                If dstDaSeqNo.Tables(0).Rows.Count > 0 Then
                    lngSequenceNumber = dstDaSeqNo.Tables(0).Rows(0)("CurrNumber")
                    GetSequenceNumber = lngSequenceNumber
                    lngSequenceNumber = lngSequenceNumber + 1
                    dstDaSeqNo.Tables(0).Rows(0)("CurrNumber") = lngSequenceNumber
                    clsDataAccess.UpdateDataSet(dstDaSeqNo, "Select * from Sequence")
                    Exit Function
                End If
            End If
        Catch
            strError = "Function : clsCommonFunctions.GetSequenceNumber " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            MsgBox(strError)
            Exit Function
        Finally

            dstDaSeqNo = Nothing
        End Try
        GetSequenceNumber = 0
    End Function
    Public Shared Function FindValueString(ByVal strQuery As String, ByVal strReturnFieldName As String, ByVal strDataSetName As String) As String

        Dim dstFind As DataSet = New DataSet
        Dim strValue As String
        'Dim strSQL As String
        Dim strError As String
        Try
            strValue = ""
            dstFind = clsDataAccess.GetDataSet(strQuery, strDataSetName)
            If dstFind.Tables.Count > 0 Then
                If dstFind.Tables(0).Rows.Count > 0 Then
                    strValue = dstFind.Tables(0).Rows(0)(strReturnFieldName)
                End If
            End If
        Catch
            strError = "Function : clsCommonFunctions.FindValue " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
        Finally
            dstFind = Nothing

        End Try
        FindValueString = strValue
    End Function
    Public Shared Function FindValueNumeric(ByVal strQuery As String, ByVal strReturnFieldName As String, ByVal strDataSetName As String) As Double

        Dim dstFind As DataSet = New DataSet
        Dim dblValue As Double
        'Dim strSQL As String
        Dim strError As String
        Try
            dstFind = clsDataAccess.GetDataSet(strQuery, strDataSetName)
            If dstFind.Tables.Count > 0 Then
                If dstFind.Tables(0).Rows.Count > 0 Then
                    dblValue = dstFind.Tables(0).Rows(0)(strReturnFieldName)
                End If
            End If
        Catch
            strError = "Function : clsCommonFunctions.DispMessage " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
        Finally
            dstFind = Nothing

        End Try
        FindValueNumeric = dblValue
    End Function
    Public Shared Function DispMessage(ByVal strMessageCode As String, Optional ByVal strParam1 As String = "", Optional ByVal strParam2 As String = "", Optional ByVal strParam3 As String = "") As String

        Dim dstMessage As New DataSet
        Dim strMessage As String
        Dim strSQL As String
        Dim strError As String
        Try
            strSQL = "Select * from Message Where Upper(RTrim(MessageCode))='" & Trim(strMessageCode) & "'"
            dstMessage = clsDataAccess.GetDataSet(strSQL, "Message")
            If dstMessage.Tables.Count > 0 Then
                If dstMessage.Tables(0).Rows.Count > 0 Then
                    strMessage = dstMessage.Tables(0).Rows(0)("MessageDescription")
                    strMessage = strMessage.Replace("{0}", strParam1)
                    strMessage = strMessage.Replace("{1}", strParam2)
                    strMessage = strMessage.Replace("{2}", strParam3)
                    DispMessage = strMessage
                    Exit Function
                End If
            End If
        Catch
            strError = "Function : clsCommonFunctions.DispMessage " & Chr(13)
            strError = strError & "Error No.: " & Err.Number & Chr(13)
            strError = strError & "Error Description.: " & Err.Description
            'MsgBox(strError)
            'Exit Function
        Finally

            dstMessage = Nothing
        End Try
        DispMessage = ""
    End Function
    Public Shared Function AlphanumericValidation(ByVal strValue As String) As Integer

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim strChar As String

        intLen = Len(strValue)
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)
            If (Asc(strChar) > 96 And Asc(strChar) < 123) Or ((Asc(strChar) > 64 And Asc(strChar) < 91)) Then
                AlphanumericValidation = 1
            ElseIf (Asc(strChar) > 47 And Asc(strChar) < 58) Then
                AlphanumericValidation = 1
            Else
                AlphanumericValidation = 0
                Exit Function
            End If
        Next Loopint
        Return AlphanumericValidation
    End Function
    Public Shared Function AlphaValidation(ByVal strValue As String) As Integer

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim strChar As String

        intLen = Len(strValue)
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)
            If (Asc(strChar) > 96 And Asc(strChar) < 123) Or ((Asc(strChar) > 64 And Asc(strChar) < 91)) Then
                AlphaValidation = 1
            ElseIf (Asc(strChar) > 47 And Asc(strChar) < 58) Then
                AlphaValidation = 1
            Else
                AlphaValidation = 0
                Exit Function
            End If
        Next Loopint
        Return AlphaValidation
    End Function
    Public Shared Function AlphanumericCommaValidation(ByVal strValue As String) As Integer

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim strChar As String

        intLen = Len(strValue)
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)
            If (Asc(strChar) > 96 And Asc(strChar) < 123) Or ((Asc(strChar) > 64 And Asc(strChar) < 91)) Then
                AlphanumericCommaValidation = 1
            ElseIf (Asc(strChar) > 47 And Asc(strChar) < 58) Then
                AlphanumericCommaValidation = 1
            ElseIf (Asc(strChar) = 44) Then
                AlphanumericCommaValidation = 1
            Else
                AlphanumericCommaValidation = 0
                Exit Function
            End If
        Next Loopint
        Return AlphanumericCommaValidation
    End Function
    Public Shared Function NumericValidation(ByVal strValue As String) As Integer

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim strChar As String

        intLen = Len(strValue)
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)
            If (Asc(strChar) > 47 And Asc(strChar) < 58) Then
                NumericValidation = 1
            Else
                NumericValidation = 0
                Exit Function
            End If
        Next Loopint
        ' Please enter only numeric values

    End Function
    Public Shared Function NumericCommaValidation(ByVal strValue As String) As Integer

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim strChar As String

        intLen = Len(strValue)
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)
            If (Asc(strChar) > 47 And Asc(strChar) < 58) Then
                NumericCommaValidation = 1
            ElseIf (Asc(strChar) = 44) Then
                NumericCommaValidation = 1
            Else
                NumericCommaValidation = 0
                Exit Function
            End If
        Next Loopint
        
    End Function
    Public Shared Function DecimalValidation(ByVal strValue As String) As Integer

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim intDecimal As Integer
        Dim strChar As String

        intLen = Len(strValue)
        intDecimal = 0
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)

            If intDecimal = 1 Then
                If intLen - Loopint > 1 Then
                    DecimalValidation = 0
                    Exit Function
                End If
            End If

            If Asc(strChar) = 46 Then
                intDecimal = intDecimal + 1
            End If

            If (Asc(strChar) > 47 And Asc(strChar) < 58) Or (Asc(strChar) = 46) Then
                DecimalValidation = 1
            Else
                DecimalValidation = 0
                Exit Function
            End If
        Next Loopint

        If intDecimal > 1 Then
            DecimalValidation = 0
            Exit Function
        End If
        ' Please enter the numbers as per the format (nn.nn)
    End Function
    Public Shared Function sysDecimalValidate(ByVal strValue As String) As Integer

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim intDecimal As Integer
        Dim strChar As String

        intLen = Len(strValue)
        intDecimal = 0
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)

            If intDecimal = 1 Then
                If intLen - Loopint > 1 Then
                    sysDecimalValidate = 0
                    Exit Function
                End If
            End If

            If Asc(strChar) = 46 Then
                intDecimal = intDecimal + 1
            End If

            If (Asc(strChar) > 47 And Asc(strChar) < 58) Or (Asc(strChar) = 46) Then
                sysDecimalValidate = 1
            Else
                sysDecimalValidate = 0
                Exit Function
            End If
        Next Loopint

        If intDecimal > 1 Then
            sysDecimalValidate = 0
            Exit Function
        End If
        ' Please enter the numbers as per the format (nn.nn)
    End Function
    Public Shared Function DateValidate(ByVal pres_date As String) As Boolean
        Dim s As String
        Dim splited_date(3) As String
        Dim date_pre As String
        Dim month As String
        Dim year As String

        If (Len(Trim(pres_date))) = 0 Or pres_date.Length > 10 Then
            Return False 'Display_Error(db.Fetch_Error_Description(7))
            Exit Function
        Else
            Dim pos As Integer
            pos = InStr(1, Trim(pres_date), "/")
            If InStr(pos + 1, Trim(pres_date), "/") <> 0 Then
                Try
                    s = Trim(pres_date)
                    splited_date = s.Split("/")
                    date_pre = splited_date(0)
                    month = splited_date(1)
                    year = splited_date(2)

                    If NumCheck(date_pre) = False Then
                        Return False
                    End If

                    If NumCheck(month) = False Then
                        Return False
                    End If

                    If NumCheck(year) = False Then
                        Return False
                    End If

                    Dim d As New Date(Right(s, 4), Mid(s, 4, 2), Left(s, 2))
                    'If d > Today() Then
                    '    pres_date = ""
                    '    Return False
                    '    'Display_Error(db.Fetch_Error_Description(7))
                    '    Exit Function
                    'End If
                Catch ex As System.Exception
                    pres_date = ""
                    Return False
                    Exit Function
                    'Display_Error(db.Fetch_Error_Description(7))
                End Try
            Else
                pres_date = ""
                Return False
                Exit Function
                'Display_Error(db.Fetch_Error_Description(7))
            End If
        End If
        Return True
    End Function
    Public Shared Function NumCheck(ByVal strValue As String) As Boolean

        Dim intLen As Integer
        Dim Loopint As Integer
        Dim strChar As String

        intLen = Len(strValue)
        For Loopint = 1 To intLen
            strChar = Mid(strValue, Loopint, 1)
            If (Asc(strChar) > 47 And Asc(strChar) < 58) Then
                NumCheck = True
            Else
                NumCheck = False
                Exit Function
            End If
        Next Loopint
        ' Please enter only numeric values

    End Function
    Public Shared Function gfstrPasswordDecrypt(ByVal strOldPassword As String) As String
        '*******************************************************************************
        'Purpose                : To decrypt the password which is stored in encrypted
        '                       : form in the database. The function will return
        '                       : decrypted password as a string.
        'Input Paramter         : strOldPassword - String
        'Output Paramter        : strDecryptPassword - String
        'Author & Creation Date : Vibhuti Ohri - 21/07/1999
        'Last Modified By & Date: Vibhuti Ohri - 23/07/1999
        '*******************************************************************************
        Dim intCount As Integer          'Used in For Next loop
        Dim strDecryptPassword As String           'used to store the result of the_
        'function
        Dim strTempPass As String           'Used to read each character of _
        'the password string
        For intCount = 1 To Len(strOldPassword)
            'Read each character of the string
            strTempPass = Mid(strOldPassword, intCount, 1)
            'Add a value to the ascii value of each character
            strTempPass = (Asc(strTempPass) + intCount)
            strDecryptPassword = strDecryptPassword & Chr(strTempPass)
        Next intCount
        gfstrPasswordDecrypt = strDecryptPassword
    End Function

    Public Shared Function PasswordEncrypt(ByVal strNewPassword As String) As String

        Dim intCount As Integer          'Used in For Next loop
        Dim strEncryptPassword As String           'used to store the result of the_
        'Function
        Dim strTempPass As String           'Used to read each character of _
        'The password string
        For intCount = 1 To Len(strNewPassword)
            'Read each character of the string
            strTempPass = Mid(strNewPassword, intCount, 1)
            'Subtract a value from the ascii value of each character
            strTempPass = (Asc(strTempPass) - intCount)
            strEncryptPassword = strEncryptPassword & IIf(Chr(strTempPass) = "'", Chr(strTempPass) & _
            Chr(strTempPass), Chr(strTempPass))
        Next intCount
        PasswordEncrypt = strEncryptPassword

    End Function
    Public Shared Function gfblnGenerateAuditTrail(ByVal strProjectId As String, ByVal strUserId As String, _
   ByVal strDescription As String) As Boolean
        '*******************************************************************************
        'Purpose                : To generate audit trail
        'Input Paramter         : ProjectId - String
        '                       : UserId - String
        '                       : Description - String
        'Output Paramter        : True/False
        'Author & Creation Date : R.Ramya-03/01/2008

        '*******************************************************************************
        Dim strQuery As String
        Dim dtmDate As Date

        dtmDate = System.DateTime.Today.Date
        'Give the SQL string
        strQuery = "Insert into AUDIT_TRAIL values ('" & strProjectId _
                      & "', '" & strUserId & "',getDate()," & _
                     "' " & Replace(strDescription, "'", "''") & "')"


        clsDataAccess.ExecuteQueryRaiseError(strQuery)

    End Function
    Public Shared Function DateFormatChange(ByVal strValue As String) As Date
        Dim myDateTime As DateTime
        myDateTime = DateTime.ParseExact(strValue, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)

        DateFormatChange = myDateTime

        'Dim strMonth As String
        'Dim strDate As String
        'Dim strYear As String
        'Dim strFinalDate As String

        'strDate = Mid$(strValue, 1, 2)
        'strMonth = Mid$(strValue, 4, 2)
        'strYear = Mid$(strValue, 7, 4)

        'strFinalDate = strMonth + "/" + strDate + "/" + strYear
        'DateFormatChange = CDate(strFinalDate)
    End Function
   
    Public Shared Function FromToDateValidation(ByVal dtFromDATE As Date, ByVal dtToDATE As Date) As Integer
        ' This common Function validate the From and Todate and return a integer value to calling function
        ' the retun value is 1 means the validation is true and or if it is 0 the validation is False
        Dim intValue As Integer
        If DateTime.Compare(dtFromDATE, dtToDATE) < 0 Then
            intValue = 1
        ElseIf DateTime.Compare(dtFromDATE, dtToDATE) = 0 Then
            intValue = 1
        ElseIf DateTime.Compare(dtFromDATE, dtToDATE) > 0 Then
            intValue = 0
        End If
        FromToDateValidation = intValue
    End Function
    'Public Shared Function ProjectDateValidation(ByVal dtFromDATE As Date, ByVal dtToDATE As Date) As Integer
    '    ' This common Function validate the From and Todate and return a integer value to calling function
    '    ' the retun value is 1 means the validation is true and or if it is 0 the validation is False
    '    If DateTime.Compare(dtFromDATE, dtToDATE) < 0 Then
    '        Return 1
    '    ElseIf DateTime.Compare(dtFromDATE, dtToDATE) = 0 Then
    '        'From and Todate are same
    '        Return 1
    '        Exit Function
    '    End If
    'End Function
    'Public Shared Function EndDateValidation(ByVal dtFromDATE As Date, ByVal dateEnd_Date As Date) As Integer
    '    If DateTime.Compare(dtFromDATE, dateEnd_Date) > 0 Then
    '        Return 1
    '        Exit Function
    '    ElseIf DateTime.Compare(dtFromDATE, dateEnd_Date) = 0 Then
    '        'From and Todate are same
    '        Return 1
    '        Exit Function
    '    End If
    'End Function
   

    'Public Shared Function SetRadioButtons(ByRef grpToSet As GroupBox, ByVal strQuery As String, ByVal strFieldvalue As String, ByVal intTopGap As Integer, ByVal intLeft As Integer)
    '    Dim objDARadioButton As New clsDataAccess
    '    Dim dstRadioButton As New DataSet
    '    Dim dstComboDefaultRow As New DataSet
    '    Dim strError As String
    '    Dim radCurrent As RadioButton
    '    Dim intCurrNo As Integer
    '    intCurrNo = 1
    '    Try
    '        dstRadioButton = objDARadioButton.GetDataSet(strQuery, "dstListRadioButton")
    '        For Each grpRow As DataRow In dstRadioButton.Tables(0).Rows
    '            radCurrent = New RadioButton
    '            radCurrent.Text = grpRow(strFieldvalue)
    '            radCurrent.Name = "Rad" & intCurrNo
    '            radCurrent.AutoSize = True
    '            radCurrent.Top = intCurrNo * intTopGap
    '            radCurrent.Left = intLeft
    '            radCurrent.Tag = grpRow(strFieldvalue)

    '            If intCurrNo = 1 Then
    '                radCurrent.Checked = True
    '            End If
    '            grpToSet.Controls.Add(radCurrent)
    '            intCurrNo = intCurrNo + 1
    '        Next
    '    Catch
    '        strError = "Function : clsCommonFunctions.SetRadioButtons" & Chr(13)
    '        strError = strError & "Error No.: " & Err.Number & Chr(13)
    '        strError = strError & "Error Description.: " & Err.Description
    '        MsgBox(strError)
    '        Exit Function
    '    Finally
    '        dstRadioButton = Nothing
    '    End Try
    'End Function
    'Public Shared Function GetRadioButtonPressed(ByRef grpToGet As GroupBox)
    '    Dim strPressedTag As String
    '    strPressedTag = ""
    '    For Each radButton As RadioButton In grpToGet.Controls
    '        If radButton.Checked = True Then
    '            strPressedTag = radButton.Tag
    '            Exit For
    '        End If
    '    Next
    '    GetRadioButtonPressed = strPressedTag
    'End Function
    'Public Shared Function ClearRadioButtonsGroup(ByRef grpToClear As GroupBox)
    '    For Each ctrlGroupControls As Control In grpToClear.Controls
    '        If (TypeOf ctrlGroupControls Is RadioButton) Then
    '            Dim radCurrent As RadioButton = CType(ctrlGroupControls, RadioButton)
    '            radCurrent.Checked = False
    '        End If
    '    Next
    'End Function
    'Public Shared Function ClearRadioButtonsPanel(ByRef pnlToClear As Panel)
    '    For Each ctrlPanelControls As Control In pnlToClear.Controls
    '        If (TypeOf ctrlPanelControls Is RadioButton) Then
    '            Dim radCurrent As RadioButton = CType(ctrlPanelControls, RadioButton)
    '            radCurrent.Checked = False
    '        End If
    '    Next
    'End Function

    'Public Shared Function SetRadioButtonValue(ByRef grpToSet As GroupBox, ByVal strTag As String)
    '    For Each radButton As RadioButton In grpToSet.Controls
    '        If Trim(strTag) = Trim(radButton.Tag) Then
    '            radButton.Checked = True
    '            Exit For
    '        End If
    '    Next
    'End Function
    'Public Shared Function SetPictureCheckBoxValue(ByRef picToSetCheckBox As PictureBox, ByVal intElementCheckBoxValue As Integer, ByRef imgList As ImageList)
    '    If intElementCheckBoxValue = 1 Then 'TICK
    '        picToSetCheckBox.Tag = "TICK"
    '        picToSetCheckBox.Image = imgList.Images("tick")
    '    End If
    '    If intElementCheckBoxValue = 2 Then 'CROSS
    '        picToSetCheckBox.Tag = "CROSS"
    '        picToSetCheckBox.Image = imgList.Images("cross")
    '    End If
    '    If intElementCheckBoxValue = 3 Then 'BLANK
    '        picToSetCheckBox.Tag = "BLANK"
    '        picToSetCheckBox.Image = imgList.Images("blank")
    '    End If
    'End Function
    'Public Shared Function GetRadioButtonPressedOfPanelMixedControls(ByRef pnlToGet As Panel)
    '    Dim strPressedTag As String
    '    strPressedTag = ""
    '    For Each ctrlPanelControls As Control In pnlToGet.Controls
    '        If (TypeOf ctrlPanelControls Is RadioButton) Then
    '            Dim radCurrent As RadioButton = CType(ctrlPanelControls, RadioButton)
    '            If radCurrent.Checked = True Then
    '                strPressedTag = ctrlPanelControls.Tag
    '                Exit For
    '            End If
    '        End If
    '    Next
    '    GetRadioButtonPressedOfPanelMixedControls = strPressedTag
    'End Function
    'Public Shared Function GetRadioButtonPressedOfPanel(ByRef pnlToGet As Panel)
    '    Dim strPressedTag As String
    '    strPressedTag = ""
    '    For Each radButton As RadioButton In pnlToGet.Controls
    '        If radButton.Checked = True Then
    '            strPressedTag = radButton.Tag
    '            Exit For
    '        End If
    '    Next
    '    GetRadioButtonPressedOfPanel = strPressedTag
    'End Function
    'Public Shared Function SetRadioButtonValueOfPanel(ByRef pnlToSet As Panel, ByVal strTag As String)
    '    For Each radButton As RadioButton In pnlToSet.Controls
    '        If Trim(strTag) = Trim(radButton.Tag) Then
    '            radButton.Checked = True
    '            Exit For
    '        End If
    '    Next
    'End Function
    'Public Shared Function SetRadioButtonValueOfPanelMixedCotrols(ByRef pnlToSet As Panel, ByVal strTag As String)
    '    For Each ctrlPanelControls As Control In pnlToSet.Controls
    '        If (TypeOf ctrlPanelControls Is RadioButton) Then
    '            Dim radCurrent As RadioButton = CType(ctrlPanelControls, RadioButton)
    '            If Trim(strTag) = Trim(radCurrent.Tag) Then
    '                radCurrent.Checked = True
    '                Exit For
    '            End If
    '        End If
    '    Next
    'End Function
    'Private Function ConvertImageToByteArray(ByVal imageToConvert As System.Drawing.Image, ByVal formatOfImage As ImageFormat) As Byte()
    '    Dim Ret As Byte()
    '    Try

    '        ' Using 
    '        Dim ms As MemoryStream = New MemoryStream
    '        Try
    '            imageToConvert.Save(ms, formatOfImage)
    '            Ret = ms.ToArray
    '        Finally
    '            CType(ms, IDisposable).Dispose()
    '        End Try
    '    Catch generatedExceptionVariable0 As Exception
    '        Throw
    '    End Try
    '    Return Ret
    'End Function
    'Public Shared Function PopulateComboGeneral(ByRef cmbComboFill As ComboBox, ByVal strQuery As String, ByVal strDisplayMember As String, ByVal strValueMember As String, ByVal strDataSetName As String, ByVal lngCurrentValue As Long)
    '    Dim objComboFill As New clsDataAccess
    '    Dim dstComboFill As New DataSet
    '    Dim dstComboDefaultRow As New DataSet
    '    'Dim strSQL As String
    '    Dim strError As String
    '    'Dim lngDefaultValue As Long
    '    Try

    '        dstComboFill = objComboFill.GetDataSet(strQuery, strDataSetName)
    '        cmbComboFill.DisplayMember = strDisplayMember
    '        cmbComboFill.ValueMember = strValueMember
    '        cmbComboFill.DataSource = dstComboFill.Tables(0).DefaultView

    '        If lngCurrentValue < 0 Then 'And lngDefaultValue < 0 Then
    '            cmbComboFill.SelectedValue = 0
    '        End If
    '        If lngCurrentValue > 0 Then
    '            cmbComboFill.SelectedValue = lngCurrentValue
    '        End If
    '        If lngCurrentValue <= 0 Then 'And lngDefaultValue > 0 Then
    '            cmbComboFill.SelectedValue = 0
    '        End If
    '    Catch
    '        strError = "Function : clsCommonFunctions.PopulateComboGeneral " & Chr(13)
    '        strError = strError & "Error No.: " & Err.Number & Chr(13)
    '        strError = strError & "Error Description.: " & Err.Description
    '        MsgBox(strError)
    '        Exit Function
    '    Finally
    '        dstComboFill = Nothing
    '    End Try
    '    'cmbComboFill.DataBindings()
    'End Function
    'Public Shared Function PopulateGridComboColumn(ByRef cmbComboFill As DataGridViewComboBoxColumn, ByVal strQuery As String, ByVal strDisplayMember As String, ByVal strValueMember As String, ByVal strDataSetName As String, ByVal lngCurrentValue As Long)
    '    Dim objComboFill As New clsDataAccess
    '    Dim dstComboFill As New DataSet
    '    Dim dstComboDefaultRow As New DataSet
    '    'Dim strSQL As String
    '    Dim strError As String
    '    'Dim lngDefaultValue As Long
    '    Try
    '        dstComboFill = objComboFill.GetDataSet(strQuery, strDataSetName)
    '        cmbComboFill.DisplayMember = strDisplayMember
    '        cmbComboFill.ValueMember = strValueMember
    '        cmbComboFill.DataSource = dstComboFill.Tables(0).DefaultView

    '        'If lngCurrentValue < 0 Then 'And lngDefaultValue < 0 Then
    '        '    cmbComboFill.Selected = 0
    '        'End If
    '        'If lngCurrentValue > 0 Then
    '        '    cmbComboFill.Selected = lngCurrentValue
    '        'End If
    '        'If lngCurrentValue <= 0 Then 'And lngDefaultValue > 0 Then
    '        '    cmbComboFill.Selected = 0
    '        'End If
    '    Catch
    '        strError = "Function : clsCommonFunctions.PopulateComboGeneral " & Chr(13)
    '        strError = strError & "Error No.: " & Err.Number & Chr(13)
    '        strError = strError & "Error Description.: " & Err.Description
    '        MsgBox(strError)
    '        Exit Function
    '    Finally
    '        dstComboFill = Nothing
    '    End Try
    '    'cmbComboFill.DataBindings()
    'End Function

End Class