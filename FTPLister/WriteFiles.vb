Public Class WriteFiles

    Shared Sub PushCheckedToUploadFile()

        'Kept in place in case API tool fails.

        'Loops through main nodes and then, if it's a folder, one level down
        'gathering checked options and writing them to the UploadMe.txt file
        'This isn't a recursive loop through a treeview control but a good demo nonetheless

        Dim currentNode As TreeNode
        Dim subNode As TreeNode
        Dim subsubNode As TreeNode

        Dim str As String = ""

        For Each currentNode In frmFTPFiles.tvFiles.Nodes   'rutorrent

            For Each subNode In currentNode.Nodes 'the actual files

                If subNode.Checked = True Then

                    If Strings.Right(subNode.Text, 3) = "; d" Then

                        str = str & GetConfig("FTPLister", "TorrentPrefix") & Strings.Left(subNode.Text, Len(subNode.Text) - 3) & "/" & Environment.NewLine

                    Else

                        str = str & GetConfig("FTPLister", "TorrentPrefix") & Strings.Left(subNode.Text, Len(subNode.Text) - 3) & Environment.NewLine

                    End If

                End If

                For Each subsubNode In subNode.Nodes

                    If subsubNode.Checked = True Then

                        If Strings.Right(subsubNode.Text, 3) = "; d" Then

                            str = str & GetConfig("FTPLister", "TorrentPrefix") & Strings.Left(subNode.Text, Len(subNode.Text) - 3) & "/" & Strings.Left(subsubNode.Text, Len(subsubNode.Text) - 3) & "/" & Environment.NewLine

                        Else

                            str = str & GetConfig("FTPLister", "TorrentPrefix") & Strings.Left(subNode.Text, Len(subNode.Text) - 3) & "/" & Strings.Left(subsubNode.Text, Len(subsubNode.Text) - 3) & Environment.NewLine

                        End If

                    End If

                Next subsubNode

            Next subNode

        Next currentNode

        Dim file As System.IO.StreamWriter
        Dim myUploadFile As String : myUploadFile = GetConfig("FTPLister", "UploadMeFile")

        My.Computer.FileSystem.DeleteFile(myUploadFile)

        file = My.Computer.FileSystem.OpenTextFileWriter(myUploadFile, True)
        file.WriteLine(str)
        file.Close()

        Dim webAddress As String = GetConfig("FTPLister", "SynologyDownloadManagerURL")
        Process.Start(webAddress)

    End Sub

    Shared Sub PushCheckedToNAS()

        '    Dim strURL As String
        '    Dim hReq As Object

        '    'In order to make API requests, you should first request SYNO.API.Info to get the SYNO.API.Auth API info for session login
        '    'and SYNO.DownloadStation.Task API info for download task list

        '    strURL = "http://192.168.0.9:5000/webapi/query.cgi?api=SYNO.API.Info&version=1&method=query&query=SYNO.API.Auth,SYNO.DownloadStation.Task"
        '    'Debug.Print SendGeneralRequest(strURL)

        '    strURL = "http://192.168.0.9:5000/webapi/auth.cgi?api=SYNO.API.Auth&version=2&method=login&account=admin&passwd=1dkwywb1cg1a&session=DownloadStation&format=cookie"
        '    'Debug.Print SendGetReturnJSON(strURL)


        '    'Get task list:
        '    strURL = "http://192.168.0.9:5000/webapi/DownloadStation/task.cgi?api=SYNO.DownloadStation.Task&version=1&method=list"
        '    'Debug.Print SendGetReturnJSON(strURL)



        '    'strURL = "http://192.168.0.9:5000/webapi/DownloadStation/task.cgi?api=SYNO.DownloadStation.Task&version=1&method=create&uri=ftp.mint.seedhost.eu/downloads/Sling Blade (1996)/&username=brains48&password=idkwywbicgia"
        '    strURL = "http://192.168.0.9:5000/webapi/DownloadStation/task.cgi?api=SYNO.DownloadStation.Task&version=1&method=create&uri=ftp://brains48:idkwywbicgia@ftp.mint.seedhost.eu/downloads/Sling Blade (1996)/&destination=Public"

        'Set hReq = CreateObject("MSXML2.XMLHTTP")
        'With hReq
        '        .Open "GET", strURL, False
        '    .Send
        '    End With

        '    Debug.Print hReq.ResponseText



    End Sub

    Sub SendGeneralRequest()


    End Sub

End Class
