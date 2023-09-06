<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Photo_Source
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
        Me.cameraBtn = New System.Windows.Forms.Button()
        Me.fileBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cameraBtn
        '
        Me.cameraBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cameraBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.cameraBtn.FlatAppearance.BorderSize = 5
        Me.cameraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cameraBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cameraBtn.Location = New System.Drawing.Point(34, 42)
        Me.cameraBtn.Name = "cameraBtn"
        Me.cameraBtn.Size = New System.Drawing.Size(135, 35)
        Me.cameraBtn.TabIndex = 0
        Me.cameraBtn.Text = "From Camera"
        Me.cameraBtn.UseVisualStyleBackColor = True
        '
        'fileBtn
        '
        Me.fileBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.fileBtn.FlatAppearance.BorderSize = 5
        Me.fileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.fileBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileBtn.Location = New System.Drawing.Point(203, 42)
        Me.fileBtn.Name = "fileBtn"
        Me.fileBtn.Size = New System.Drawing.Size(96, 35)
        Me.fileBtn.TabIndex = 1
        Me.fileBtn.Text = "From File"
        Me.fileBtn.UseVisualStyleBackColor = True
        '
        'Select_Photo_Source
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 120)
        Me.Controls.Add(Me.fileBtn)
        Me.Controls.Add(Me.cameraBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Select_Photo_Source"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Source"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cameraBtn As Button
    Friend WithEvents fileBtn As Button
End Class
