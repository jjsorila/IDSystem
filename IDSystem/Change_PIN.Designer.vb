<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_PIN
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
        Me.newPin = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.confirmPin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'newPin
        '
        Me.newPin.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPin.Location = New System.Drawing.Point(86, 64)
        Me.newPin.Name = "newPin"
        Me.newPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPin.Size = New System.Drawing.Size(215, 30)
        Me.newPin.TabIndex = 19
        Me.newPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(149, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 23)
        Me.label1.TabIndex = 18
        Me.label1.Text = "NEW PIN"
        '
        'confirmPin
        '
        Me.confirmPin.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPin.Location = New System.Drawing.Point(86, 153)
        Me.confirmPin.Name = "confirmPin"
        Me.confirmPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPin.Size = New System.Drawing.Size(215, 30)
        Me.confirmPin.TabIndex = 21
        Me.confirmPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "CONFIRM NEW PIN"
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.updateBtn.FlatAppearance.BorderSize = 3
        Me.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.ForeColor = System.Drawing.Color.Black
        Me.updateBtn.Location = New System.Drawing.Point(100, 221)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(187, 39)
        Me.updateBtn.TabIndex = 22
        Me.updateBtn.Text = "CHANGE"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'Change_PIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 305)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.confirmPin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.newPin)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Change_PIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Admin PIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newPin As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents confirmPin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents updateBtn As Button
End Class
