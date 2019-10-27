Imports System.IO
Imports System.Threading


Public Class Form1
    Private rootDir As DirectoryInfo
    Public worker_Thread As Thread

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Scan.Click
        Dim rootpicker As New FolderBrowserDialog
        rootpicker.ShowNewFolderButton = False
        Dim result = rootpicker.ShowDialog()

        If result = DialogResult.OK Then
            rootDir = New DirectoryInfo(rootpicker.SelectedPath)
            worker_Thread = New Thread(AddressOf thread_Process)
            worker_Thread.Start()
        End If
    End Sub

    Delegate Sub setNodeCallback(node As TreeNode, tree As TreeView)

    Private Sub add_Node(node As TreeNode, tree As TreeView)
        If trv_Folders.InvokeRequired Then
            Dim d As New setNodeCallback(AddressOf add_Node)
            Me.Invoke(d, New Object() {node, tree})
        Else
            trv_Folders.Nodes.Add(node)
        End If
    End Sub

    Private Sub thread_Process()
        Try
            add_Node(read_Directory(rootDir), trv_Folders)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function read_Directory(dir As DirectoryInfo) As TreeNode
        Dim new_Node As New TreeNode(dir.Name)
        If dir.GetFiles.Count > 1 Then new_Node.ForeColor = Color.Red
        Try
            For Each nextDir As DirectoryInfo In dir.GetDirectories
                new_Node.Nodes.Add(read_Directory(nextDir))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return new_Node
    End Function

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        btn_Scan.Top = Me.Height - 69
        trv_Folders.Height = btn_Scan.Top - 3
        trv_Folders.Width = (Me.Width / 2) - 20

        btn_Folder_Delete.Top = btn_Scan.Top

        btn_Delete.Top = Me.Height - 69
        btn_Delete.Left = Me.Width - btn_Delete.Width - 19
        lst_Files.Height = trv_Folders.Height
        lst_Files.Left = trv_Folders.Width + 20
        lst_Files.Width = (Me.Width / 2) - 20
    End Sub

    Private Sub trv_Folders_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trv_Folders.AfterSelect
        Dim folder As String = Nothing
        If trv_Folders.SelectedNode IsNot Nothing Then
            Try
                If Strings.Right(rootDir.Parent.FullName, 1) = "\" Then
                    folder = rootDir.Parent.FullName & trv_Folders.SelectedNode.FullPath
                Else
                    folder = rootDir.Parent.FullName & "\" & trv_Folders.SelectedNode.FullPath
                End If

                Dim dir As New DirectoryInfo(folder)
                lst_Files.Items.Clear()
                For Each file As FileInfo In dir.EnumerateFiles
                    lst_Files.Items.Add(file)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim file As FileInfo = TryCast(lst_Files.SelectedItem, FileInfo)
        If file IsNot Nothing Then
            Try
                file.Delete()
                lst_Files.Items.Remove(file)
                If lst_Files.Items.Count < 2 Then
                    '************************************************
                    ' Some code to change the color of the treeview
                    '************************************************
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btn_Folder_Delete_Click(sender As Object, e As EventArgs) Handles btn_Folder_Delete.Click
        Dim folder As New DirectoryInfo(rootDir.Parent.FullName & trv_Folders.SelectedNode.FullPath)
        Dim verify As DialogResult = MsgBox("Are you sure you want to delete: " & folder.FullName, MsgBoxStyle.YesNo, "Don't do it!!!")
        If verify = DialogResult.Yes Then
            Try
                If folder.GetFiles.Count > 0 Then
                    For Each file As FileInfo In folder.GetFiles
                        file.Delete()
                    Next
                End If
                folder.Delete()
                trv_Folders.SelectedNode.Remove()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class
