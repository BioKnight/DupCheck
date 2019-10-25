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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_Delete = New System.Windows.Forms.Button()
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
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(3, 1)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(267, 359)
        Me.TreeView1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(290, 1)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(267, 355)
        Me.ListBox1.TabIndex = 2
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 392)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.btn_Scan)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Scan As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_Delete As Button
End Class
