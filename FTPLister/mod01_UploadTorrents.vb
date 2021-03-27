Imports System.IO
Imports System.Net
Module mod01_UploadTorrents

    Dim LocalFolder As String
    Dim FTPFolder As String

    Public Sub UploadTorrents()

        'This has been replaced by the Powershell script D:\Dropbox\Application Support\_AntTools\Powershell Scripts\15 - Upload Torrents In This Folder (working)\UploadTorrentsInThisFolder.ps1
        'but kept here as demo of VB.Net FTP-ing of files 

        Dim intTorrentCount As Integer = 0
        LocalFolder = GetConfig("FTPLister", "LocalTorrentFolder")
        FTPFolder = GetConfig("FTPLister", "FTPTorrentFolder")

        Dim strTorrentList As String = ""
        Dim files() As String = IO.Directory.GetFiles(LocalFolder, "*.torrent")

        For Each file As String In files
            intTorrentCount = intTorrentCount + 1
            strTorrentList = strTorrentList & Path.GetFileName(file) & vbNewLine & vbNewLine
        Next

        If intTorrentCount = 0 Then

            MessageBox.Show("No .torrent files found in " & LocalFolder)

        Else

            Dim result As DialogResult = MessageBox.Show("Upload these torrents to seedbox? " & vbNewLine & vbNewLine & strTorrentList, "Torrent Uploader", MessageBoxButtons.YesNo)

            If result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then

                For Each file As String In files
                    strTorrentList = strTorrentList & file
                    UploadFTP(file, FTPFolder & Path.GetFileName(file))
                    Kill(file)
                Next

                Call FormView.Manage()

                If GetConfig("FTPLister", "GoToruTorrent") = "Yes" Then
                    Dim webAddress As String = GetConfig("FTPLister", "ruTorrent")
                    Process.Start(webAddress)
                End If

            End If

        End If

    End Sub

    Function UploadFTP(strLocalFile As String, strFTPFile As String) As Boolean

        UploadFTP = False

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))

        client.UploadFile(strFTPFile, strLocalFile)
        UploadFTP = True

    End Function

End Module
