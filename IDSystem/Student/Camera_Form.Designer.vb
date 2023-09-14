<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Camera_Form
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
        Me.cameraFeed = New System.Windows.Forms.PictureBox()
        Me.captureBtn = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.CaptureCamera = New System.ComponentModel.BackgroundWorker()
        CType(Me.cameraFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.captureBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cameraFeed
        '
        Me.cameraFeed.BackColor = System.Drawing.Color.White
        Me.cameraFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cameraFeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cameraFeed.Location = New System.Drawing.Point(0, 0)
        Me.cameraFeed.Name = "cameraFeed"
        Me.cameraFeed.Size = New System.Drawing.Size(800, 450)
        Me.cameraFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.cameraFeed.TabIndex = 0
        Me.cameraFeed.TabStop = False
        '
        'captureBtn
        '
        Me.captureBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.captureBtn.BackColor = System.Drawing.Color.Transparent
        Me.captureBtn.BackgroundImage = Global.IDSystem.My.Resources.Resources.capture_btn
        Me.captureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.captureBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.captureBtn.Location = New System.Drawing.Point(344, 303)
        Me.captureBtn.Name = "captureBtn"
        Me.captureBtn.Size = New System.Drawing.Size(110, 109)
        Me.captureBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.captureBtn.TabIndex = 2
        Me.captureBtn.TabStop = False
        '
        'okBtn
        '
        Me.okBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.okBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.okBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.okBtn.Image = Global.IDSystem.My.Resources.Resources.ok_btn
        Me.okBtn.Location = New System.Drawing.Point(303, 333)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(50, 49)
        Me.okBtn.TabIndex = 3
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelBtn.Image = Global.IDSystem.My.Resources.Resources.cancel_btn
        Me.cancelBtn.Location = New System.Drawing.Point(444, 333)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(50, 49)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'CaptureCamera
        '
        '
        'Camera_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.captureBtn)
        Me.Controls.Add(Me.cameraFeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Camera_Form"
        Me.Text = "Camera"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cameraFeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.captureBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cameraFeed As PictureBox
    Friend WithEvents captureBtn As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents okBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents CaptureCamera As System.ComponentModel.BackgroundWorker
End Class
