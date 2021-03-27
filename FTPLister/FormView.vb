Public Class FormView

    Shared Sub Manage()

        If frmFTPFiles.Location.X > 1080 Then

            Do Until frmFTPFiles.Location.X = 1080

                frmFTPFiles.Location = New Point(frmFTPFiles.Location.X - 1, 0)
                System.Threading.Thread.Sleep(0.5)

            Loop

            Call MainFTPListerClass.FTPLister()

            frmFTPFiles.Refresh()

        Else

            Do Until frmFTPFiles.Location.X = 1536

                frmFTPFiles.Location = New Point(frmFTPFiles.Location.X + 1, 0)
                System.Threading.Thread.Sleep(0.5)

            Loop

            frmFTPFiles.Refresh()

        End If

    End Sub

End Class
