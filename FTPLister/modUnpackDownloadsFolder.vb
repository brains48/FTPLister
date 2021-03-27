Imports System.IO

Module modUnpackDownloadsFolder

    'Replaced by D:\Dropbox\Application Support\_AntTools\Powershell Scripts\07 - UnpackDownloadsFolders\UnpackDownloadsInTheseFolder.ps1

    Sub UnpackDownloadsFolder()

        Dim strDestinationFolder As String = ""

        If Len(frmFTPFiles.txtUnpackThisFolder.Text) > 0 Then

            strDestinationFolder = frmFTPFiles.txtUnpackThisFolder.Text
            FormView.Manage()

        Else

            FormView.Manage()

            If frmFTPFiles.FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

                strDestinationFolder = frmFTPFiles.FolderBrowserDialog1.SelectedPath

            End If

        End If

        Dim dirs As String() = Directory.GetDirectories(strDestinationFolder, "*", SearchOption.TopDirectoryOnly)
        Dim strDownloadsFolder As String
        Dim dir As String

        For Each dir In dirs

            If dir.Contains("download") Then

                strDownloadsFolder = dir

                ' MoveAllItems(strDownloadsFolder, strDestinationFolder)
                System.IO.Directory.Delete(strDownloadsFolder, True)

            End If

        Next

        Process.Start(strDestinationFolder)

    End Sub



End Module
