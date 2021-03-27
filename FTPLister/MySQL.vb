Imports System.Data.Odbc
Imports System.Data.Sql
Imports System.Data.SqlClient

Imports MySql.Data
Imports MySql.Data.MySqlClient
'add reference to C:\Program Files (x86)\MySQL\MySQL Installer for Windows\MySql.Data.dll to enable the imports

Module MySQL

    Public Function GetConfig(strToolName As String, strDescriptor As String) As String

        Dim StrVar As String = ""
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand

        Dim connStr As String = "SERVER=192.168.0.17;DATABASE=AntBase;PORT=3307;UID=SynologyDB;PASSWORD=1dkwywb1cG1@"
        Dim connection As New MySqlConnection(connStr)
        connection.Open()

        cmd.CommandText = "Select DescriptorValue from AntConfig where ToolName = '" & strToolName & "' And Descriptor = '" & strDescriptor & "'"
        cmd.Connection = connection
        rd = cmd.ExecuteReader

        If rd.Read Then

            StrVar = rd.GetString(0)

        End If

        rd.Close()

        connection.Close()

        GetConfig = StrVar


    End Function

End Module
