<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_Scan = New System.Windows.Forms.Button()
        Me.trv_Folders = New System.Windows.Forms.TreeView()
        Me.lst_Files = New System.Windows.Forms.ListBox()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Folder_Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Scan
        '
        Me.btn_Scan.Location = New System.Drawing.Point(3, 366)
        Me.btn_Scan.Name = "btn_Scan"
        Me.btn_Scan.Size = New System.Drawing.Size(75, 23)
        Me.btn_Scan.TabIndex = 0
        Me.btn_Scan.Text = "Scan Folder"
        Me.btn_Scan.UseVisualStyleBackColor = True
        '
        'trv_Folders
        '
        Me.trv_Folders.Location = New System.Drawing.Point(3, 1)
        Me.trv_Folders.Name = "trv_Folders"
        Me.trv_Folders.Size = New System.Drawing.Size(267, 359)
        Me.trv_Folders.TabIndex = 1
        '
        'lst_Files
        '
        Me.lst_Files.FormattingEnabled = True
        Me.lst_Files.Location = New System.Drawing.Point(290, 1)
        Me.lst_Files.Name = "lst_Files"
        Me.lst_Files.Size = New System.Drawing.Size(267, 355)
        Me.lst_Files.TabIndex = 2
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(482, 362)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_Delete.TabIndex = 3
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Folder_Delete
        '
        Me.btn_Folder_Delete.Location = New System.Drawing.Point(195, 366)
        Me.btn_Folder_Delete.Name = "btn_Folder_Delete"
        Me.btn_Folder_Delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_Folder_Delete.TabIndex = 4
        Me.btn_Folder_Delete.Text = "Delete"
        Me.btn_Folder_Delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 392)
        Me.Controls.Add(Me.btn_Folder_Delete)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.lst_Files)
        Me.Controls.Add(Me.trv_Folders)
        Me.Controls.Add(Me.btn_Scan)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Scan As Button
    Friend WithEvents trv_Folders As TreeView
    Friend WithEvents lst_Files As ListBox
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Folder_Delete As Button
End Class
