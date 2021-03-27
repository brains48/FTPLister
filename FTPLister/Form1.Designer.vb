<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFTPFiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFTPFiles))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lstFTPFiles = New System.Windows.Forms.ListView()
        Me.FTPFileType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FTPFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tvFiles = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog3 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PushStraightToNAS = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog4 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog5 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog6 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog7 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog8 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog9 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog10 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtUnpackThisFolder = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FTPListerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadViaAPIToPublicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PUBLICToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USBSHARE22ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOGIETVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BROWSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PushToUploadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SynologyDownloadManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuTorrentWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResilioSyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnpackDownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BergToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThDimensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyAnonaMouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NebulanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SceneTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TVChaosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "FTP Lister"
        Me.NotifyIcon1.Visible = True
        '
        'lstFTPFiles
        '
        Me.lstFTPFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FTPFileType, Me.FTPFileName})
        Me.lstFTPFiles.FullRowSelect = True
        Me.lstFTPFiles.HideSelection = False
        Me.lstFTPFiles.Location = New System.Drawing.Point(438, 115)
        Me.lstFTPFiles.Name = "lstFTPFiles"
        Me.lstFTPFiles.Size = New System.Drawing.Size(29, 25)
        Me.lstFTPFiles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstFTPFiles.TabIndex = 4
        Me.lstFTPFiles.UseCompatibleStateImageBehavior = False
        Me.lstFTPFiles.View = System.Windows.Forms.View.Details
        Me.lstFTPFiles.Visible = False
        '
        'FTPFileType
        '
        Me.FTPFileType.Text = "Rutorrent File"
        Me.FTPFileType.Width = 400
        '
        'FTPFileName
        '
        Me.FTPFileName.Text = "FileOrFolder"
        Me.FTPFileName.Width = 200
        '
        'tvFiles
        '
        Me.tvFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvFiles.CheckBoxes = True
        Me.tvFiles.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvFiles.Location = New System.Drawing.Point(12, 39)
        Me.tvFiles.Name = "tvFiles"
        Me.tvFiles.Size = New System.Drawing.Size(419, 639)
        Me.tvFiles.TabIndex = 9
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_open.png")
        Me.ImageList1.Images.SetKeyName(1, "icon-file-9.jpg.png")
        '
        'PushStraightToNAS
        '
        Me.PushStraightToNAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PushStraightToNAS.Location = New System.Drawing.Point(437, 146)
        Me.PushStraightToNAS.Name = "PushStraightToNAS"
        Me.PushStraightToNAS.Size = New System.Drawing.Size(29, 23)
        Me.PushStraightToNAS.TabIndex = 13
        Me.PushStraightToNAS.Text = "Push2NAS"
        Me.PushStraightToNAS.UseVisualStyleBackColor = True
        Me.PushStraightToNAS.Visible = False
        '
        'txtUnpackThisFolder
        '
        Me.txtUnpackThisFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnpackThisFolder.Location = New System.Drawing.Point(12, 684)
        Me.txtUnpackThisFolder.Name = "txtUnpackThisFolder"
        Me.txtUnpackThisFolder.Size = New System.Drawing.Size(419, 22)
        Me.txtUnpackThisFolder.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FTPListerToolStripMenuItem, Me.TrackersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(479, 36)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FTPListerToolStripMenuItem
        '
        Me.FTPListerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadViaAPIToPublicToolStripMenuItem, Me.PushToUploadFileToolStripMenuItem, Me.SynologyDownloadManagerToolStripMenuItem, Me.RuTorrentWebsiteToolStripMenuItem, Me.ResilioSyncToolStripMenuItem, Me.UnpackDownloadsToolStripMenuItem, Me.HideToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FTPListerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FTPListerToolStripMenuItem.Name = "FTPListerToolStripMenuItem"
        Me.FTPListerToolStripMenuItem.Size = New System.Drawing.Size(108, 32)
        Me.FTPListerToolStripMenuItem.Text = "FTP Lister"
        '
        'DownloadViaAPIToPublicToolStripMenuItem
        '
        Me.DownloadViaAPIToPublicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PUBLICToolStripMenuItem, Me.USBSHARE22ToolStripMenuItem, Me.FOGIETVToolStripMenuItem, Me.BROWSEToolStripMenuItem})
        Me.DownloadViaAPIToPublicToolStripMenuItem.Name = "DownloadViaAPIToPublicToolStripMenuItem"
        Me.DownloadViaAPIToPublicToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.DownloadViaAPIToPublicToolStripMenuItem.Text = "Download Via API"
        '
        'PUBLICToolStripMenuItem
        '
        Me.PUBLICToolStripMenuItem.Name = "PUBLICToolStripMenuItem"
        Me.PUBLICToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.PUBLICToolStripMenuItem.Text = "PUBLIC"
        '
        'USBSHARE22ToolStripMenuItem
        '
        Me.USBSHARE22ToolStripMenuItem.Name = "USBSHARE22ToolStripMenuItem"
        Me.USBSHARE22ToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.USBSHARE22ToolStripMenuItem.Text = "USBSHARE2-2"
        '
        'FOGIETVToolStripMenuItem
        '
        Me.FOGIETVToolStripMenuItem.Name = "FOGIETVToolStripMenuItem"
        Me.FOGIETVToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.FOGIETVToolStripMenuItem.Text = "FOGIETV"
        '
        'BROWSEToolStripMenuItem
        '
        Me.BROWSEToolStripMenuItem.Name = "BROWSEToolStripMenuItem"
        Me.BROWSEToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.BROWSEToolStripMenuItem.Text = "BROWSE"
        '
        'PushToUploadFileToolStripMenuItem
        '
        Me.PushToUploadFileToolStripMenuItem.Name = "PushToUploadFileToolStripMenuItem"
        Me.PushToUploadFileToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.PushToUploadFileToolStripMenuItem.Text = "Push To Upload File"
        '
        'SynologyDownloadManagerToolStripMenuItem
        '
        Me.SynologyDownloadManagerToolStripMenuItem.Name = "SynologyDownloadManagerToolStripMenuItem"
        Me.SynologyDownloadManagerToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.SynologyDownloadManagerToolStripMenuItem.Text = "Synology Download Manager"
        '
        'RuTorrentWebsiteToolStripMenuItem
        '
        Me.RuTorrentWebsiteToolStripMenuItem.Name = "RuTorrentWebsiteToolStripMenuItem"
        Me.RuTorrentWebsiteToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.RuTorrentWebsiteToolStripMenuItem.Text = "ruTorrent Website"
        '
        'ResilioSyncToolStripMenuItem
        '
        Me.ResilioSyncToolStripMenuItem.Name = "ResilioSyncToolStripMenuItem"
        Me.ResilioSyncToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.ResilioSyncToolStripMenuItem.Text = "Resilio Sync"
        '
        'UnpackDownloadsToolStripMenuItem
        '
        Me.UnpackDownloadsToolStripMenuItem.Name = "UnpackDownloadsToolStripMenuItem"
        Me.UnpackDownloadsToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.UnpackDownloadsToolStripMenuItem.Text = "Unpack Downloads"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(358, 32)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'TrackersToolStripMenuItem
        '
        Me.TrackersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BergToolStripMenuItem, Me.ThDimensionToolStripMenuItem, Me.MyAnonaMouseToolStripMenuItem, Me.NebulanceToolStripMenuItem, Me.SceneTimeToolStripMenuItem, Me.TVChaosToolStripMenuItem})
        Me.TrackersToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackersToolStripMenuItem.Name = "TrackersToolStripMenuItem"
        Me.TrackersToolStripMenuItem.Size = New System.Drawing.Size(95, 32)
        Me.TrackersToolStripMenuItem.Text = "Trackers"
        '
        'BergToolStripMenuItem
        '
        Me.BergToolStripMenuItem.Name = "BergToolStripMenuItem"
        Me.BergToolStripMenuItem.Size = New System.Drawing.Size(242, 32)
        Me.BergToolStripMenuItem.Text = "Berg"
        '
        'ThDimensionToolStripMenuItem
        '
        Me.ThDimensionToolStripMenuItem.Name = "ThDimensionToolStripMenuItem"
        Me.ThDimensionToolStripMenuItem.Size = New System.Drawing.Size(242, 32)
        Me.ThDimensionToolStripMenuItem.Text = "4th Dimension"
        '
        'MyAnonaMouseToolStripMenuItem
        '
        Me.MyAnonaMouseToolStripMenuItem.Name = "MyAnonaMouseToolStripMenuItem"
        Me.MyAnonaMouseToolStripMenuItem.Size = New System.Drawing.Size(242, 32)
        Me.MyAnonaMouseToolStripMenuItem.Text = "MyAnonaMouse"
        '
        'NebulanceToolStripMenuItem
        '
        Me.NebulanceToolStripMenuItem.Name = "NebulanceToolStripMenuItem"
        Me.NebulanceToolStripMenuItem.Size = New System.Drawing.Size(242, 32)
        Me.NebulanceToolStripMenuItem.Text = "Nebulance"
        '
        'SceneTimeToolStripMenuItem
        '
        Me.SceneTimeToolStripMenuItem.Name = "SceneTimeToolStripMenuItem"
        Me.SceneTimeToolStripMenuItem.Size = New System.Drawing.Size(242, 32)
        Me.SceneTimeToolStripMenuItem.Text = "SceneTime"
        '
        'TVChaosToolStripMenuItem
        '
        Me.TVChaosToolStripMenuItem.Name = "TVChaosToolStripMenuItem"
        Me.TVChaosToolStripMenuItem.Size = New System.Drawing.Size(242, 32)
        Me.TVChaosToolStripMenuItem.Text = "TV Chaos"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'frmFTPFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUnpackThisFolder)
        Me.Controls.Add(Me.PushStraightToNAS)
        Me.Controls.Add(Me.tvFiles)
        Me.Controls.Add(Me.lstFTPFiles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFTPFiles"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FTP Lister"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents lstFTPFiles As ListView
    Friend WithEvents FTPFileType As ColumnHeader
    Friend WithEvents FTPFileName As ColumnHeader
    Friend WithEvents tvFiles As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog3 As FolderBrowserDialog
    Friend WithEvents PushStraightToNAS As Button
    Friend WithEvents FolderBrowserDialog4 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog5 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog6 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog7 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog8 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog9 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog10 As FolderBrowserDialog
    Friend WithEvents txtUnpackThisFolder As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FTPListerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PushToUploadFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadViaAPIToPublicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PUBLICToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USBSHARE22ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SynologyDownloadManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BROWSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RuTorrentWebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FOGIETVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TrackersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BergToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThDimensionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyAnonaMouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NebulanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SceneTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TVChaosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResilioSyncToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnpackDownloadsToolStripMenuItem As ToolStripMenuItem
End Class
