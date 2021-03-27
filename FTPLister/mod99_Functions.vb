Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Imports System.Data.Odbc
Imports System.Data.Sql

Imports MySql.Data
Imports MySql.Data.MySqlClient

Module mod99_Functions
    'Dim MySQLConn As MySQLConnection

    Sub  TEST_CONSIG()

        MessageBox.Show(Config("FTPFolder"))

    End Sub


    Public Function Config(strDescriptor As String) As String

        Config = "ftp://ftp.lime.seedhost.eu/downloads/"


    End Function

    Sub QuitApp()

        Dim result As DialogResult = MessageBox.Show("Sure?", "Title", MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Application.Exit()
            End
        Else
            MessageBox.Show("Doing nothing")
        End If

    End Sub

    'Function HasDownloaded(strFileName As String) As Boolean

    '    'create dictionary on refresh and check that
    '    'https://stackoverflow.com/questions/22198144/check-if-ftp-folder-exists-if-not-then-create-it/23346989

    '    Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.lime.seedhost.eu/downloads/completed/"), FtpWebRequest)
    '    request.Method = WebRequestMethods.Ftp.ListDirectory
    '    request.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))

    '    request.Method = WebRequestMethods.Ftp.GetFileSize

    '    Try

    '        request.GetResponse()
    '        HasDownloaded = True
    '        Exit Function

    '    Catch

    '        HasDownloaded = False

    '        '    FtpWebResponse response = (FtpWebResponse)e.Response

    '        'If (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable) Then

    '        '        Console.WriteLine("Does not exist")

    '        '    Else

    '        '        Console.WriteLine("Error: " + e.Message)

    '        '    End If

    '    End Try

    'End Function

    Sub OpenSynologyDownloadManager()

        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Synology", "SynologyDownloadManager")
        Process.Start(webAddress)

    End Sub
    Sub OpenRuTorrent()

        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Seedhost", "ruTorrent")
        Process.Start(webAddress)

    End Sub
    Public Function WashMe(myPath As String) As String

        Dim myDrive As String, myUNCfolder As String, strOutput As String
        Dim FullPath As String

        FullPath = myPath ' z:\film\a

        myDrive = Left(myPath, 2)
        myUNCfolder = GetUNCFolder(myDrive)

        If InStr(myUNCfolder, "Public") > 0 Then
            strOutput = "Public\" & Right(FullPath, Len(FullPath) - 3)
        Else
            strOutput = "USBSHARE2-2\" & Right(FullPath, Len(FullPath) - 3)
        End If

        WashMe = strOutput

    End Function

    Public Function RemoveIllegalCharacters(strFileName As String) As String

        Dim StrVar As String = ""
        Dim rd As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim findChar As String, replaceChar As String
        Dim myWashedFileName As String
        myWashedFileName = strFileName

        Dim connStr As String = "SERVER=192.168.0.17;DATABASE=AntBase;PORT=3307;UID=SynologyDB;PASSWORD=1dkwywb1cG1@"
        Dim connection As New MySqlConnection(connStr)
        connection.Open()

        cmd.CommandText = "Select DescriptorValue, Comments From AntConfig Where ToolName = 'ReplaceIllegalCharacters'"
        cmd.Connection = connection
        rd = cmd.ExecuteReader

        While rd.Read()

            findChar = rd.GetString(0)
            replaceChar = rd.GetString(1)

            myWashedFileName = Replace(myWashedFileName, findChar, replaceChar)

        End While

        rd.Close()
        connection.Close()

        RemoveIllegalCharacters = myWashedFileName

    End Function

End Module
