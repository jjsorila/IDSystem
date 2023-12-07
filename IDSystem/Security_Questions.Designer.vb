<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Security_Questions
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
        Me.Q1 = New System.Windows.Forms.Label()
        Me.Q2 = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.TextBox()
        Me.A2 = New System.Windows.Forms.TextBox()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Q1
        '
        Me.Q1.BackColor = System.Drawing.Color.Transparent
        Me.Q1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q1.ForeColor = System.Drawing.Color.Black
        Me.Q1.Location = New System.Drawing.Point(164, 32)
        Me.Q1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(500, 87)
        Me.Q1.TabIndex = 28
        Me.Q1.Text = "Q1"
        Me.Q1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Q2
        '
        Me.Q2.BackColor = System.Drawing.Color.Transparent
        Me.Q2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q2.ForeColor = System.Drawing.Color.Black
        Me.Q2.Location = New System.Drawing.Point(164, 199)
        Me.Q2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(500, 87)
        Me.Q2.TabIndex = 29
        Me.Q2.Text = "Q2"
        Me.Q2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A1
        '
        Me.A1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A1.Location = New System.Drawing.Point(166, 139)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(496, 30)
        Me.A1.TabIndex = 30
        Me.A1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'A2
        '
        Me.A2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A2.Location = New System.Drawing.Point(166, 307)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(496, 30)
        Me.A2.TabIndex = 31
        Me.A2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.add_btn.Location = New System.Drawing.Point(168, 373)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(496, 43)
        Me.add_btn.TabIndex = 32
        Me.add_btn.Text = "SUBMIT"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'Security_Questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.A1)
        Me.Controls.Add(Me.Q2)
        Me.Controls.Add(Me.Q1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Security_Questions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Q1 As Label
    Friend WithEvents Q2 As Label
    Friend WithEvents A1 As TextBox
    Friend WithEvents A2 As TextBox
    Friend WithEvents add_btn As Button
End Class
