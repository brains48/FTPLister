Imports System.IO
Imports System.Net
'publish/deploy to D:\Dropbox\Application Support\_AntTools\FTP
Public Class frmFTPFiles

    Public FTPFolder As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim IntPSBH As Integer
        Dim IntTaskBarHeight As Integer

        Call WatchMyFolder()

        FTPFolder = GetConfig("FTPLister", "FTPFolder")

        IntPSBH = My.Computer.Screen.Bounds.Height 'System.Windows.Forms.Screen.PrimaryScreen.Bounds
        IntTaskBarHeight = IntPSBH - System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height

        Me.Width = 479
        Me.Height = My.Computer.Screen.Bounds.Height - IntTaskBarHeight
        Me.Location = New Point(My.Computer.Screen.Bounds.Right, 0)
        'Me.lvItems.View = View.Details
        'Me.lvItems.Columns.Add("Modified")
        'Me.lvItems.Columns.Add("Filename")
        Call MainFTPListerClass.FTPLister()
        'Call MainFTPListerClass.FluentFTPLIster()
        Me.Refresh()



    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        FormView.Manage()

    End Sub

    Private Sub frmFTPFiles_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        FormView.Manage()
    End Sub

    Private Sub PushStraightToNAS_Click(sender As Object, e As EventArgs) Handles PushStraightToNAS.Click
        MessageBox.Show(GetConfig("FTPLister", "TorrentPrefix"))
    End Sub

    Private Sub tvFiles_DoubleClick(sender As Object, e As EventArgs) Handles tvFiles.DoubleClick

        MainFTPListerClass.GetSubFiles()

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Call QuitApp()
    End Sub

    Private Sub UploadTorrentsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call UploadTorrents()
    End Sub

    Private Sub PushToUploadFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PushToUploadFileToolStripMenuItem.Click
        Call WriteFiles.PushCheckedToUploadFile()
        Call FormView.Manage()
    End Sub

    Private Sub UnpackDownloadsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call UnpackDownloadsFolder()
    End Sub

    Private Sub DownloadViaAPIToPublicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadViaAPIToPublicToolStripMenuItem.Click

    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Call FormView.Manage()
    End Sub

    Private Sub PUBLICToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PUBLICToolStripMenuItem.Click
        Call DownloadViaAPIToPublic("PUBLIC")
    End Sub

    Private Sub USBSHARE22ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USBSHARE22ToolStripMenuItem.Click
        Call DownloadViaAPIToPublic("USBSHARE2-2")
    End Sub

    Private Sub SynologyDownloadManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SynologyDownloadManagerToolStripMenuItem.Click
        Call OpenSynologyDownloadManager()
    End Sub

    Private Sub BROWSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BROWSEToolStripMenuItem.Click
        'e.g. USBSHARE2-2/0 - 2020
        Dim strFolder As String, strFolderWashed As String

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            strFolder = FolderBrowserDialog1.SelectedPath
        End If

        strFolderWashed = WashMe(strFolder)
        strFolderWashed = Replace(strFolderWashed, "\", "/")

        strFolderWashed = Replace(strFolderWashed, " ", "%20")
        '%20
        Call DownloadViaAPIToPublic(strFolderWashed)

    End Sub

    Private Sub RuTorrentWebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuTorrentWebsiteToolStripMenuItem.Click
        Call OpenRuTorrent()
    End Sub

    Private Sub FOGIETVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOGIETVToolStripMenuItem.Click

        Dim strFolder As String

        strFolder = "PUBLIC\Other\FogieTV"
        strFolder = Replace(strFolder, "\", "/")
        strFolder = Replace(strFolder, " ", "%20")

        Call DownloadViaAPIToPublic(strFolder)

    End Sub

    Private Sub BergToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BergToolStripMenuItem.Click
        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Trackers", "Berg")
        Process.Start(webAddress)
    End Sub

    Private Sub ThDimensionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThDimensionToolStripMenuItem.Click
        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Trackers", "4thDimension")
        Process.Start(webAddress)
    End Sub

    Private Sub MyAnonaMouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyAnonaMouseToolStripMenuItem.Click
        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Trackers", "MyAnonaMouse")
        Process.Start(webAddress)
    End Sub

    Private Sub NebulanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NebulanceToolStripMenuItem.Click
        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Trackers", "Nebulance")
        Process.Start(webAddress)
    End Sub

    Private Sub SceneTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SceneTimeToolStripMenuItem.Click
        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Trackers", "SceneTime")
        Process.Start(webAddress)
    End Sub

    Private Sub TVChaosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TVChaosToolStripMenuItem.Click
        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Trackers", "TVChaos")
        Process.Start(webAddress)
    End Sub

    Private Sub ResilioSyncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResilioSyncToolStripMenuItem.Click
        Call FormView.Manage()
        Dim webAddress As String = GetConfig("Synology", "ResilioSync")
        Process.Start(webAddress)
    End Sub

    Private Sub UnpackDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnpackDownloadsToolStripMenuItem.Click
        Call UnpackDownloadsFolder()
    End Sub
End Class
