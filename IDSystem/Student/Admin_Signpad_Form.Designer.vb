<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Signpad_Form
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.doneBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.signpad = New System.Windows.Forms.PictureBox()
        CType(Me.signpad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(-1, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(450, 10)
        Me.Panel4.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 345)
        Me.Panel3.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(440, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 345)
        Me.Panel2.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(376, 23)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "HOLD DOWN LEFT CLICK MOUSE TO DRAW"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(-1, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 10)
        Me.Panel1.TabIndex = 26
        '
        'doneBtn
        '
        Me.doneBtn.BackColor = System.Drawing.Color.Transparent
        Me.doneBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.doneBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.doneBtn.FlatAppearance.BorderSize = 3
        Me.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.doneBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doneBtn.ForeColor = System.Drawing.Color.Black
        Me.doneBtn.Location = New System.Drawing.Point(267, 262)
        Me.doneBtn.Name = "doneBtn"
        Me.doneBtn.Size = New System.Drawing.Size(113, 50)
        Me.doneBtn.TabIndex = 25
        Me.doneBtn.Text = "DONE"
        Me.doneBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.Transparent
        Me.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.clearBtn.FlatAppearance.BorderSize = 3
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.Black
        Me.clearBtn.Location = New System.Drawing.Point(72, 262)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(113, 50)
        Me.clearBtn.TabIndex = 24
        Me.clearBtn.Text = "CLEAR"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'signpad
        '
        Me.signpad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.signpad.Cursor = System.Windows.Forms.Cursors.Cross
        Me.signpad.Location = New System.Drawing.Point(72, 63)
        Me.signpad.Name = "signpad"
        Me.signpad.Size = New System.Drawing.Size(308, 107)
        Me.signpad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.signpad.TabIndex = 23
        Me.signpad.TabStop = False
        '
        'Admin_Signpad_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(449, 344)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.doneBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.signpad)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_Signpad_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Signpad_Form"
        CType(Me.signpad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents doneBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents signpad As PictureBox
End Class
