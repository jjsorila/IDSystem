<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Account_Settings
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.accounts_table = New System.Windows.Forms.DataGridView()
        Me.newpassword = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.change_btn = New System.Windows.Forms.Button()
        Me.usrname_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        CType(Me.accounts_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'accounts_table
        '
        Me.accounts_table.AllowUserToAddRows = False
        Me.accounts_table.AllowUserToDeleteRows = False
        Me.accounts_table.AllowUserToResizeColumns = False
        Me.accounts_table.AllowUserToResizeRows = False
        Me.accounts_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.accounts_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.accounts_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.accounts_table.ColumnHeadersHeight = 43
        Me.accounts_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.accounts_table.DefaultCellStyle = DataGridViewCellStyle8
        Me.accounts_table.Dock = System.Windows.Forms.DockStyle.Left
        Me.accounts_table.Location = New System.Drawing.Point(0, 0)
        Me.accounts_table.MultiSelect = False
        Me.accounts_table.Name = "accounts_table"
        Me.accounts_table.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.accounts_table.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.accounts_table.RowHeadersVisible = False
        Me.accounts_table.RowHeadersWidth = 51
        Me.accounts_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.accounts_table.RowTemplate.ReadOnly = True
        Me.accounts_table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.accounts_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.accounts_table.Size = New System.Drawing.Size(238, 450)
        Me.accounts_table.TabIndex = 15
        '
        'newpassword
        '
        Me.newpassword.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpassword.Location = New System.Drawing.Point(284, 90)
        Me.newpassword.Name = "newpassword"
        Me.newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpassword.Size = New System.Drawing.Size(215, 30)
        Me.newpassword.TabIndex = 25
        Me.newpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(255, 46)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(215, 30)
        Me.username.TabIndex = 24
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.delete_btn)
        Me.GroupBox5.Controls.Add(Me.change_btn)
        Me.GroupBox5.Controls.Add(Me.usrname_label)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.newpassword)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(244, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(550, 212)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MODIFY ACCOUNT"
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Transparent
        Me.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.delete_btn.FlatAppearance.BorderSize = 3
        Me.delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.Black
        Me.delete_btn.Location = New System.Drawing.Point(64, 144)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(208, 43)
        Me.delete_btn.TabIndex = 30
        Me.delete_btn.Text = "DELETE"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'change_btn
        '
        Me.change_btn.BackColor = System.Drawing.Color.Transparent
        Me.change_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.change_btn.FlatAppearance.BorderSize = 3
        Me.change_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.change_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.change_btn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_btn.ForeColor = System.Drawing.Color.Black
        Me.change_btn.Location = New System.Drawing.Point(282, 144)
        Me.change_btn.Name = "change_btn"
        Me.change_btn.Size = New System.Drawing.Size(221, 43)
        Me.change_btn.TabIndex = 29
        Me.change_btn.Text = "CHANGE"
        Me.change_btn.UseVisualStyleBackColor = False
        '
        'usrname_label
        '
        Me.usrname_label.AutoSize = True
        Me.usrname_label.BackColor = System.Drawing.Color.Transparent
        Me.usrname_label.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrname_label.ForeColor = System.Drawing.Color.Black
        Me.usrname_label.Location = New System.Drawing.Point(290, 52)
        Me.usrname_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.usrname_label.Name = "usrname_label"
        Me.usrname_label.Size = New System.Drawing.Size(0, 22)
        Me.usrname_label.TabIndex = 28
        Me.usrname_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(73, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NEW PASSWORD:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(129, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "USERNAME:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.add_btn)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(244, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 214)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADD ACCOUNT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(102, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 22)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "PASSWORD:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(105, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 22)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "USERNAME:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.add_btn.Location = New System.Drawing.Point(170, 154)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(208, 43)
        Me.add_btn.TabIndex = 31
        Me.add_btn.Text = "ADD"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(255, 94)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(215, 30)
        Me.password.TabIndex = 26
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Account_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.accounts_table)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Account_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Settings"
        CType(Me.accounts_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents accounts_table As DataGridView
    Friend WithEvents newpassword As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents password As TextBox
    Friend WithEvents usrname_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents change_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents add_btn As Button
End Class
