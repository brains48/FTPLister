Imports System.IO
Imports System.Net
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Module SynologyResponseHandling
    Function fnURL(strName As String) As String

        'This bolts my Synology IP address to the front of the API identified in AntBase as strName
        fnURL = GetConfig("Synology", "SynologyURL") & GetConfig("SynologyAPI", strName)

    End Function

    Function GetFullTextResponse(myRequest As HttpWebRequest) As String

        Dim strResponseText As String
        Dim response As HttpWebResponse = CType(myRequest.GetResponse(), HttpWebResponse)

        ' Get the stream associated with the response.
        Dim receiveStream As Stream = response.GetResponseStream()

        ' Pipes the stream to a higher level stream reader with the required encoding format. 
        Dim readStream As New StreamReader(receiveStream, Encoding.UTF8)
        Dim line As String

        line = readStream.ReadLine
        strResponseText = line
        response.Close()
        readStream.Close()
        GetFullTextResponse = strResponseText

    End Function
    Function GetResponseFromText(rawresp As String, strKeyName As String) As String

        'Drills into supplied JSON text string and returns value from strKeyname supplied. Examples keys: success, data.total, data.tasks[0].title

        Dim json As JObject = JObject.Parse(rawresp)
        GetResponseFromText = json.SelectToken(strKeyName)

    End Function

    'Public Function GetConfig(strToolName As String, strDescriptor As String) As String

    '    'Project - Reference - Add to C:\Program Files (x86)\MySQL\MySQL Installer for Windows\MySql.Data.dll to enable the imports
    '    Dim StrVar As String = ""
    '    Dim rd As MySqlDataReader
    '    Dim cmd As New MySqlCommand

    '    Dim connStr As String = "SERVER=192.168.0.17;DATABASE=AntBase;PORT=3307;UID=SynologyDB;PASSWORD=1dkwywb1cG1@"
    '    Dim connection As New MySqlConnection(connStr)
    '    connection.Open()

    '    cmd.CommandText = "Select DescriptorValue from AntConfig where ToolName = '" & strToolName & "' And Descriptor = '" & strDescriptor & "'"
    '    cmd.Connection = connection
    '    rd = cmd.ExecuteReader

    '    If rd.Read Then

    '        StrVar = rd.GetString(0)

    '    End If

    '    rd.Close()

    '    connection.Close()

    '    GetConfig = StrVar

    'End Function
End Module
