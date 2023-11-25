<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Creds
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.pinTxt = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(91, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(108, 23)
        Me.label1.TabIndex = 15
        Me.label1.Text = "ADMIN PIN"
        '
        'pinTxt
        '
        Me.pinTxt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinTxt.Location = New System.Drawing.Point(37, 64)
        Me.pinTxt.Name = "pinTxt"
        Me.pinTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pinTxt.Size = New System.Drawing.Size(215, 30)
        Me.pinTxt.TabIndex = 17
        Me.pinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.loginBtn.FlatAppearance.BorderSize = 3
        Me.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.Black
        Me.loginBtn.Location = New System.Drawing.Point(51, 124)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(187, 39)
        Me.loginBtn.TabIndex = 19
        Me.loginBtn.Text = "PROCEED"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Admin_Creds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(281, 204)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.pinTxt)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_Creds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As Label
    Friend WithEvents pinTxt As TextBox
    Friend WithEvents loginBtn As Button
End Class
