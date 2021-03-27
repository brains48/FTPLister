Imports System.IO
Imports System.Net
Imports FluentFTP

Public Class MainFTPListerClass

    Shared dctFileNames As New Dictionary(Of String, Integer)
    Shared CompletedList As New List(Of String)
    Shared dctSubNodeFileNames As New Dictionary(Of String, Integer)
    Shared SubDirlist As New List(Of String)

    Shared Sub FTPLister()

        Dim Rows As New List(Of ListViewItem)

SetupTreeview:

        frmFTPFiles.tvFiles.Nodes.Clear()
        Dim root = New TreeNode("ruTorrent")
        frmFTPFiles.tvFiles.Nodes.Add(root)

        Call MainFTPListerClass.CreateDictionary()
        Call MainFTPListerClass.CreateCompletedList()

        frmFTPFiles.tvFiles.ImageList = frmFTPFiles.ImageList1
        Dim arr() As String
        Dim Dirlist As New List(Of String) 'I prefer List() instead of an array

        'FTPFolder
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(Config("FTPFolder")), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.ListDirectory
        request.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))

        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream
        Dim line As String
        Using reader As New StreamReader(responseStream)

            line = reader.ReadLine
            arr = Split(line, vbNewLine)
            Do While (Not line Is Nothing)

                'MessageBox.Show(arr(0))

                Dirlist.Add(line)
                line = reader.ReadLine

            Loop

        End Using

        response.Close()

        Dim intSubFolderCount As Integer : intSubFolderCount = 1
        Dim intcount As Integer : intcount = 1
        Dim strFound As String

        For Each item In Dirlist

            strFound = "-"

            For Each pair As KeyValuePair(Of String, Integer) In dctFileNames

                If InStr(pair.Key, item) > 0 Then

                    strFound = Left(pair.Key, 1)
                    Exit For

                End If

            Next

            Select Case item

                Case Is = "vpn"
                    'do nothing
                Case Is = "torrents"
                    'do nothing
                Case Is = "watch"
                    'do nothing      
                Case Is = "completed"
                    'do nothing      
                Case Is = "filezilla"
                    'do nothing      

                Case Else

                    If strFound = "d" Then

                        If CompletedList.Contains(item.ToString) Then

                            With frmFTPFiles.tvFiles.Nodes(0).Nodes.Add(item & "; " & strFound, item & "; " & strFound, 0)
                                .ForeColor = Color.Green
                                .NodeFont = New Font(frmFTPFiles.tvFiles.Font, FontStyle.Bold)
                            End With

                        Else

                            With frmFTPFiles.tvFiles.Nodes(0).Nodes.Add(item & "; " & strFound, item & "; " & strFound, 0)
                                .ForeColor = Color.Gray
                                .NodeFont = New Font(frmFTPFiles.tvFiles.Font, FontStyle.Regular)
                            End With

                        End If

                    Else

                        If CompletedList.Contains(item.ToString) = True Then

                            With frmFTPFiles.tvFiles.Nodes(0).Nodes.Add(item & "; " & strFound, item & "; " & strFound, 1)
                                .ForeColor = Color.Green
                                .NodeFont = New Font(frmFTPFiles.tvFiles.Font, FontStyle.Bold)
                            End With

                        Else

                            With frmFTPFiles.tvFiles.Nodes(0).Nodes.Add(item & "; " & strFound, item & "; " & strFound, 1)
                                .ForeColor = Color.Gray
                                .NodeFont = New Font(frmFTPFiles.tvFiles.Font, FontStyle.Regular)
                            End With

                        End If

                    End If

                    intcount = intcount + 1

            End Select

        Next

        frmFTPFiles.tvFiles.Sort()
        frmFTPFiles.tvFiles.ExpandAll()

    End Sub
    Shared Sub CreateDictionary()

        Dim Dirlist As New List(Of String) 'I prefer List() instead of an array

        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(GetConfig("FTPLister", "FTPFolder")), FtpWebRequest)

        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails
        request.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))

        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream

        Dim intcount As Integer : intcount = 1
        Dim line As String

        Using reader As New StreamReader(responseStream)

            line = reader.ReadLine

            dctFileNames = New Dictionary(Of String, Integer)

            Do While (Not line Is Nothing)

                dctFileNames.Add(line, intcount)
                intcount = intcount + 1
                line = reader.ReadLine

            Loop

        End Using

        response.Close()

    End Sub
    Shared Sub CreateSubDirectoryList(myDirectory As String)

        Dim Dirlist As New List(Of String) 'I prefer List() instead of an array

        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(GetConfig("FTPLister", "FTPFolder") & myDirectory & "/"), FtpWebRequest)

        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails
        request.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))

        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream

        Dim intcount As Integer : intcount = 1
        Dim line As String
        Using reader As New StreamReader(responseStream)

            dctSubNodeFileNames = New Dictionary(Of String, Integer)

            line = reader.ReadLine

            Do While (Not line Is Nothing)
                dctSubNodeFileNames.Add(line, intcount)
                intcount = intcount + 1
                line = reader.ReadLine

            Loop

        End Using

        response.Close()

    End Sub

    Shared Sub CreateCompletedList()

        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(GetConfig("FTPLister", "FTPCompletedFolder")), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.ListDirectory
        request.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))

        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream
        Dim line As String
        Using reader As New StreamReader(responseStream)

            line = reader.ReadLine

            Do While (Not line Is Nothing)
                'Debug.Print(line)
                CompletedList.Add(line)
                line = reader.ReadLine

            Loop

        End Using

        response.Close()

    End Sub
    Shared Sub GetSubFiles()

        Dim n As Windows.Forms.TreeNode
        n = frmFTPFiles.tvFiles.SelectedNode
        If Right(n.Text, 1) <> "d" Then
            MessageBox.Show("Not a directory")
            Exit Sub
        End If

        CreateSubDirectoryList(Left(n.Text, Len(n.Text) - 3)) 'going to need the directory/file flags for the ftp string

        Dim Dirlist As New List(Of String) 'I prefer List() instead of an array
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(GetConfig("FTPLister", "FTPFolder") & Left(n.Text, Len(n.Text) - 3) & "/"), FtpWebRequest)

        request.Method = WebRequestMethods.Ftp.ListDirectory
        request.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))

        Dim myresponse As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = myresponse.GetResponseStream

        Dim line As String

        Using reader As New StreamReader(responseStream)

            line = reader.ReadLine

            Do While (Not line Is Nothing)

                Dirlist.Add(line)

                line = reader.ReadLine
            Loop

        End Using

        myresponse.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim intSubFolderCount As Integer : intSubFolderCount = 1
        Dim intcount As Integer : intcount = 1
        Dim strFound As String

        For Each item In Dirlist

            strFound = "-"

            For Each pair As KeyValuePair(Of String, Integer) In dctSubNodeFileNames

                If InStr(pair.Key, item) > 0 Then

                    strFound = Left(pair.Key, 1)
                    Exit For

                End If

            Next

            If strFound = "d" Then

                n.Nodes.Add(item & "; " & strFound, item & "; " & strFound, 0)

            Else

                n.Nodes.Add(item & "; " & strFound, item & "; " & strFound, 1)

            End If

            intcount = intcount + 1

        Next

        n.Expand()

    End Sub

    Shared Sub FluentFTPLIster()

        Dim client As New FtpClient()
        client.Host = GetConfig("Seedhost", "SSHHostname") 'Config("FTPFolder")
        client.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))
        client.Connect()

        client.SetWorkingDirectory("downloads")

        '  MessageBox.Show(client.GetWorkingDirectory)

        Dim arr(2) As String

        For Each FtpListItem In client.GetListing(client.GetWorkingDirectory)


            arr(1) = FtpListItem.Name
            arr(0) = Convert.ToDateTime(FtpListItem.Modified) 'FtpListItem.Modified.ToLongTimeString '.ToLongDateString
            Dim itm As New ListViewItem(arr)
            'frmFTPFiles.lvItems.Items.Add(itm) '.Add(FtpListItem.Name, FtpListItem.Size)

        Next

    End Sub

End Class
