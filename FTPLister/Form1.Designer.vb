<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFTPFiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFTPFiles))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnPushToUploadFile = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstFTPFiles = New System.Windows.Forms.ListView()
        Me.FTPFileType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FTPFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblHide = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'btnPushToUploadFile
        '
        Me.btnPushToUploadFile.Location = New System.Drawing.Point(501, 626)
        Me.btnPushToUploadFile.Name = "btnPushToUploadFile"
        Me.btnPushToUploadFile.Size = New System.Drawing.Size(166, 31)
        Me.btnPushToUploadFile.TabIndex = 1
        Me.btnPushToUploadFile.Text = "Push To Upload File"
        Me.btnPushToUploadFile.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(69, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(598, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 626)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstFTPFiles
        '
        Me.lstFTPFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FTPFileType, Me.FTPFileName})
        Me.lstFTPFiles.FullRowSelect = True
        Me.lstFTPFiles.HideSelection = False
        Me.lstFTPFiles.Location = New System.Drawing.Point(12, 40)
        Me.lstFTPFiles.Name = "lstFTPFiles"
        Me.lstFTPFiles.Size = New System.Drawing.Size(655, 580)
        Me.lstFTPFiles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstFTPFiles.TabIndex = 4
        Me.lstFTPFiles.UseCompatibleStateImageBehavior = False
        Me.lstFTPFiles.View = System.Windows.Forms.View.Details
        '
        'FTPFileType
        '
        Me.FTPFileType.Text = "Rutorrent File"
        Me.FTPFileType.Width = 400
        '
        'FTPFileName
        '
        Me.FTPFileName.Text = "FileOrFolder"
        Me.FTPFileName.Width = 0
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(161, 628)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(51, 17)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "Label1"
        '
        'lblHide
        '
        Me.lblHide.AutoSize = True
        Me.lblHide.Location = New System.Drawing.Point(14, 8)
        Me.lblHide.Name = "lblHide"
        Me.lblHide.Size = New System.Drawing.Size(17, 17)
        Me.lblHide.TabIndex = 6
        Me.lblHide.Text = "X"
        '
        'frmFTPFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 658)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHide)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lstFTPFiles)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnPushToUploadFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFTPFiles"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FTP Lister"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btnPushToUploadFile As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lstFTPFiles As ListView
    Friend WithEvents FTPFileType As ColumnHeader
    Friend WithEvents FTPFileName As ColumnHeader
    Friend WithEvents lblCount As Label
    Friend WithEvents lblHide As Label
End Class
