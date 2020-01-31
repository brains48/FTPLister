Imports System.IO
Imports System.Net

Public Class frmFTPFiles

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim scr As Screen = Screen.FromPoint(Cursor.Position)
        Me.Visible = True
        Dim x As Integer
        Dim y As Integer

        'Me.Location = New Point(scr.WorkingArea.Right - 697, scr.WorkingArea.Bottom - Me.Height)
        'MessageBox.Show(Me.Width.ToString) '199
        'MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Width.ToString) '1536
        x = 1020 'Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - 705
        'left 1020
        Me.Location = New Point(x, y)

        Me.Visible = False

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        If Me.Visible = True Then

            Me.Visible = False

        Else

            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.BringToFront()
            Call MainFTPListerClass.FTPLister()

        End If
        'Me.WindowState = FormWindowState.Maximized
    End Sub



    Private Sub btnPushToUploadFile_Click(sender As Object, e As EventArgs) Handles btnPushToUploadFile.Click
        Call WriteFiles.PushSelectedToUploadFile()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim result As DialogResult = MessageBox.Show("Sure?", "Title", MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Application.Exit()
            End
        Else
            MessageBox.Show("Doing nothing")
        End If

    End Sub


    Private Sub lstFTPFiles_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
        Dim itm As ListItem
Set itm = lstFTPFiles.HitTest(x, y)
If Not (itm Is Nothing) Then
            If (itm.Selected = False) Then
                itm.Selected = True
                itm.Tag = "s"
            Else
                itm.Selected = False
                itm.Tag = ""
            End If
        End If
Set itm = Nothing

End Sub

    Private Sub lstFTPFiles_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)
        With lstFTPFiles
            .Visible = False
            For x = 1 To lstFTPFiles.ListItems.Count

                If .ListItems(x).Tag = "" Then
                    .ListItems(x).Selected = False
                Else
                    .ListItems(x).Selected = True
                End If
            Next x
            .Visible = True
        End With
End Class
