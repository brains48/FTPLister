Public Class WriteFiles

    Shared Sub PushSelectedToUploadFile()

        Dim i As Integer

        Dim str As String = ""

        For i = 0 To frmFTPFiles.lstFTPFiles.SelectedItems.Count - 1

            If frmFTPFiles.lstFTPFiles.SelectedItems(i).SubItems(1).Text = "d" Then

                str = str & "ftp://brains48:idkwywbicgia@ftp.mint.seedhost.eu/downloads/" & frmFTPFiles.lstFTPFiles.SelectedItems(i).SubItems(0).Text & "/" & Environment.NewLine

            Else

                str = str & "ftp://brains48:idkwywbicgia@ftp.mint.seedhost.eu/downloads/" & frmFTPFiles.lstFTPFiles.SelectedItems(i).SubItems(0).Text & Environment.NewLine

            End If

        Next i

        Dim file As System.IO.StreamWriter
        Dim myUploadFile As String : myUploadFile = "D:\Dropbox\Application Support\_AntTools\0 - TorrentUploads\UploadMe.txt"

        My.Computer.FileSystem.DeleteFile(myUploadFile)

        file = My.Computer.FileSystem.OpenTextFileWriter(myUploadFile, True)
        file.WriteLine(str)
        file.Close()

        Dim webAddress As String = "http://192.168.0.9:5000/index.cgi"
        Process.Start(webAddress)

    End Sub

End Class
