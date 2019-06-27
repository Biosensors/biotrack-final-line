Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports BTFinalLine.ClsUtil
Imports BTFinalLine.BioTrackScanningMain


Public Class ClsConfig
    Private ds As DataSet
    Private filename As String
    Public connectionString As String
    Public INIFilePath As String
    Public updateUrl As String
    Public mainRefresh As Integer
    Public frame4Refresh As Integer
    Public reportPath As String
    Public company As String
    Public authUrl As String
    Public domain As String
    Public domainPath As String

    Sub New()

 
        'sDBServer = INIRead(INIFilePath, sConnectionServer, "ServerName")
        'sDBName = INIRead(INIFilePath, sConnectionServer, "DBName")
        'sConnectionServer = "SERVER=" & sDBServer & ";Database=" & sDBName & ";UId=exact;Trusted_Connection=Yes"

        'endregion

        'updateUrl = MNS(ds.Tables(0).Rows(0)("updateUrl"))
        'reportPath = MNS(ds.Tables(0).Rows(0)("reportPath"))
        ' mainRefresh = MNI(ds.Tables(0).Rows(0)("mainRefresh"))
        'frame4Refresh = MNI(ds.Tables(0).Rows(0)("frame4Refresh"))
        'If mainRefresh = 0 Or frame4Refresh = 0 Then
        '    mainRefresh = 30
        '    frame4Refresh = 60
        'End If
        'If reportPath = "" Then
        '    reportPath = Directory.GetCurrentDirectory
        'End If
        'company = MNS(ds.Tables(0).Rows(0)("company"))
        ''not being used anywhere but we'll leave it for compatibility with v1.0.0.0...
        'authUrl = MNS(ds.Tables(0).Rows(0)("authUrl"))

        'Try
        '    domain = MNS(ds.Tables(0).Rows(0)("domain"))
        '    domainPath = MNS(ds.Tables(0).Rows(0)("domainPath"))
        'Catch
        '    domain = Nothing
        '    domainPath = Nothing
        'End Try

        ''write if domain is null
        'Try
        '    If domain Is Nothing Then
        '        ds.Tables(0).Columns.Add("domain", GetType(String))
        '        ds.Tables(0).Columns.Add("domainPath", GetType(String))
        '        ds.Tables(0).Rows(0)("domain") = "baan"
        '        ds.Tables(0).Rows(0)("domainPath") = "WinNT://baan/"

        '        ds.WriteXml(filename)

        '        domain = "baan"
        '        domainPath = "WinNT://baan/"
        '        'domainPath = "WinNT://192.168.72.20/"
        '    End If
        'Catch
        'End Try



    End Sub

End Class

