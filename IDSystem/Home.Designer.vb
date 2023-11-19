<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.student_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prof_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'student_btn
        '
        Me.student_btn.BackColor = System.Drawing.Color.Transparent
        Me.student_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.student_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.student_btn.FlatAppearance.BorderSize = 3
        Me.student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.student_btn.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student_btn.ForeColor = System.Drawing.Color.Black
        Me.student_btn.Location = New System.Drawing.Point(138, 212)
        Me.student_btn.Name = "student_btn"
        Me.student_btn.Size = New System.Drawing.Size(241, 124)
        Me.student_btn.TabIndex = 18
        Me.student_btn.Text = "COLLEGE STUDENT ID"
        Me.student_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(230, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 56)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "INTERNATIONAL ELECTRONICS AND" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TECHNICAL INSTITUTE, INC."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.IDSystem.My.Resources.Resources.logo_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(86, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 105)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'prof_btn
        '
        Me.prof_btn.BackColor = System.Drawing.Color.Transparent
        Me.prof_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prof_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.prof_btn.FlatAppearance.BorderSize = 3
        Me.prof_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prof_btn.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_btn.ForeColor = System.Drawing.Color.Black
        Me.prof_btn.Location = New System.Drawing.Point(447, 212)
        Me.prof_btn.Name = "prof_btn"
        Me.prof_btn.Size = New System.Drawing.Size(241, 124)
        Me.prof_btn.TabIndex = 21
        Me.prof_btn.Text = "COLLEGE PROFESSOR ID"
        Me.prof_btn.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.prof_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.student_btn)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents student_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents prof_btn As Button
End Class
