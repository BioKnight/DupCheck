Imports System.IO


Public Class Form1
    Private rootDir As DirectoryInfo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Scan.Click
        Dim rootpicker As New FolderBrowserDialog
        rootpicker.ShowNewFolderButton = False
        Dim result = rootpicker.ShowDialog()

        If result = DialogResult.OK Then
            MsgBox("Test")
        End If
    End Sub
End Class
