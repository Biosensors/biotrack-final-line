Imports System.IO
Imports System.IO.StreamWriter
Imports System.Text

Public Class clsScanning

    Public Function GetConnectionStringValue() As String
        Dim dbConnectionName As String = "DBConnection"
        Dim sTmpConnString As String = ""
        GetConnectionStringValue = ""

        sTmpConnString = "SERVER="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Server")
        sTmpConnString = sTmpConnString & ";Database="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Database")
        sTmpConnString = sTmpConnString & ";UID="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Uid")
        sTmpConnString = sTmpConnString & ";PWD="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Pwd")
        sTmpConnString = sTmpConnString & ";Trusted_Connection="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Trusted_Connection")
        GetConnectionStringValue = sTmpConnString
    End Function

    Public Function CheckUserRights(ByVal sUserID As String, ByVal sApplicationName As String) As Boolean
        Sql = "SELECT distinct bm.* FROM Biomenus bm  join  biorights br on br.menuid = bm.menuid and br.roleid in ( select roleid from BioUserRights where userid = '" & sUserID & "') where type = 3 and isactive = 1 and formname = '" & sApplicationName & "'"
        ds = db.selectQuery(Sql)

        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
