Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.Net

Module WatchFolder

    Public watchfolder As System.IO.FileSystemWatcher
    Public Sub WatchMyFolder()

        watchfolder = New System.IO.FileSystemWatcher()
        watchfolder.Path = GetConfig("WatchFolder", "FolderToWatch")
        watchfolder.NotifyFilter = IO.NotifyFilters.DirectoryName
        watchfolder.NotifyFilter = watchfolder.NotifyFilter Or
                               IO.NotifyFilters.FileName
        watchfolder.NotifyFilter = watchfolder.NotifyFilter Or
                               IO.NotifyFilters.Attributes
        'AddHandler watchfolder.Changed, AddressOf logchange
        AddHandler watchfolder.Created, AddressOf logchange
        ' AddHandler watchfolder.Deleted, AddressOf logchange
        ' AddHandler watchfolder.Renamed, AddressOf logrename
        watchfolder.EnableRaisingEvents = True
    End Sub

    Private Sub logchange(ByVal source As Object, ByVal e As System.IO.FileSystemEventArgs)

        Dim myCleanedName As String
        Dim myFilePath As String

        If e.ChangeType = IO.WatcherChangeTypes.Created Then

            Threading.Thread.Sleep(500)

            If UCase(Right(e.FullPath, 7)) = "TORRENT" Then

                'myFilePath = e.FullPath

                'myCleanedName = e.Name

                'myCleanedName.Replace("(", "")
                'Debug.Print(myCleanedName.ToString)
                'myCleanedName.Replace(")", "")
                'myCleanedName.Replace("[", "")
                'myCleanedName.Replace("]", "")

                'My.Computer.FileSystem.RenameFile(myFilePath, myCleanedName)

                Dim client As WebClient = New WebClient
                client.Credentials = New NetworkCredential(GetConfig("FTPLister", "ruTorrentUsername"), GetConfig("FTPLister", "ruTorrentPassword"))
                client.UploadFile(GetConfig("FTPLister", "FTPTorrentFolder") & e.Name, e.FullPath)

                Kill(e.FullPath)

            End If

        End If

    End Sub

End Module
