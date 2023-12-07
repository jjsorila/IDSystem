<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Change_Password
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
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(170, 165)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(215, 30)
        Me.password.TabIndex = 26
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(149, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NEW ADMIN PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.Color.Transparent
        Me.add_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.add_btn.FlatAppearance.BorderSize = 3
        Me.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.ForeColor = System.Drawing.Color.Black
        Me.add_btn.Location = New System.Drawing.Point(108, 246)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(338, 43)
        Me.add_btn.TabIndex = 33
        Me.add_btn.Text = "CHANGE"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 367)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Change_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents add_btn As Button
End Class
