<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prof_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.studentSearchUSI = New System.Windows.Forms.TextBox()
        Me.dgv_usi = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.position = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tin_no = New System.Windows.Forms.TextBox()
        Me.sss_no = New System.Windows.Forms.TextBox()
        Me.insertBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.employee_number = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.e_person = New System.Windows.Forms.TextBox()
        Me.e_number = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.mi = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.usi_id_signature = New System.Windows.Forms.PictureBox()
        Me.usi_id_picture = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pi_tp_dgv = New System.Windows.Forms.DataGridView()
        Me.removeSelectedBtn = New System.Windows.Forms.Button()
        Me.removeAllBtn = New System.Windows.Forms.Button()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.previewBtn = New System.Windows.Forms.Button()
        Me.modifyBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pi_refreshBtn = New System.Windows.Forms.Button()
        Me.pi_dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pi_student_search = New System.Windows.Forms.TextBox()
        Me.addToPrintQueueBtn = New System.Windows.Forms.Button()
        Me.ProfCleanupWorker = New System.ComponentModel.BackgroundWorker()
        Me.ProfPrinterList = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgv_usi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.usi_id_signature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usi_id_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pi_tp_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pi_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 27)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.LightGreen
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 23)
        Me.ToolStripMenuItem1.Text = "CHANGE ADMIN PIN"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(56, 23)
        Me.ToolStripMenuItem2.Text = "HELP"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(960, 763)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(952, 726)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Information"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.studentSearchUSI)
        Me.GroupBox8.Controls.Add(Me.dgv_usi)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(501, 355)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(440, 359)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "RECORD LIST"
        '
        'studentSearchUSI
        '
        Me.studentSearchUSI.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.studentSearchUSI.Location = New System.Drawing.Point(114, 38)
        Me.studentSearchUSI.Name = "studentSearchUSI"
        Me.studentSearchUSI.Size = New System.Drawing.Size(297, 30)
        Me.studentSearchUSI.TabIndex = 13
        Me.studentSearchUSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgv_usi
        '
        Me.dgv_usi.AllowUserToAddRows = False
        Me.dgv_usi.AllowUserToDeleteRows = False
        Me.dgv_usi.AllowUserToResizeColumns = False
        Me.dgv_usi.AllowUserToResizeRows = False
        Me.dgv_usi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_usi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_usi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_usi.ColumnHeadersHeight = 43
        Me.dgv_usi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_usi.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_usi.Location = New System.Drawing.Point(31, 88)
        Me.dgv_usi.MultiSelect = False
        Me.dgv_usi.Name = "dgv_usi"
        Me.dgv_usi.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_usi.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_usi.RowHeadersVisible = False
        Me.dgv_usi.RowHeadersWidth = 51
        Me.dgv_usi.RowTemplate.ReadOnly = True
        Me.dgv_usi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_usi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_usi.Size = New System.Drawing.Size(380, 248)
        Me.dgv_usi.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(27, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 23)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "SEARCH:"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.position)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.tin_no)
        Me.GroupBox7.Controls.Add(Me.sss_no)
        Me.GroupBox7.Controls.Add(Me.insertBtn)
        Me.GroupBox7.Controls.Add(Me.clearBtn)
        Me.GroupBox7.Controls.Add(Me.updateBtn)
        Me.GroupBox7.Controls.Add(Me.deleteBtn)
        Me.GroupBox7.Controls.Add(Me.employee_number)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(501, 9)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(440, 337)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'position
        '
        Me.position.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.position.Location = New System.Drawing.Point(30, 217)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(380, 30)
        Me.position.TabIndex = 27
        Me.position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(188, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 23)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Position*"
        '
        'tin_no
        '
        Me.tin_no.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tin_no.Location = New System.Drawing.Point(230, 55)
        Me.tin_no.Name = "tin_no"
        Me.tin_no.Size = New System.Drawing.Size(180, 30)
        Me.tin_no.TabIndex = 26
        Me.tin_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sss_no
        '
        Me.sss_no.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.sss_no.Location = New System.Drawing.Point(32, 55)
        Me.sss_no.Name = "sss_no"
        Me.sss_no.Size = New System.Drawing.Size(190, 30)
        Me.sss_no.TabIndex = 25
        Me.sss_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'insertBtn
        '
        Me.insertBtn.BackColor = System.Drawing.Color.Transparent
        Me.insertBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.insertBtn.FlatAppearance.BorderSize = 3
        Me.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insertBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.insertBtn.ForeColor = System.Drawing.Color.White
        Me.insertBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.insertBtn.Location = New System.Drawing.Point(30, 277)
        Me.insertBtn.Name = "insertBtn"
        Me.insertBtn.Size = New System.Drawing.Size(91, 39)
        Me.insertBtn.TabIndex = 24
        Me.insertBtn.Text = "INSERT"
        Me.insertBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.Transparent
        Me.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.clearBtn.FlatAppearance.BorderSize = 3
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.clearBtn.Location = New System.Drawing.Point(230, 277)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(84, 39)
        Me.clearBtn.TabIndex = 23
        Me.clearBtn.Text = "CLEAR"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.updateBtn.FlatAppearance.BorderSize = 3
        Me.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.updateBtn.ForeColor = System.Drawing.Color.White
        Me.updateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.updateBtn.Location = New System.Drawing.Point(128, 277)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(96, 39)
        Me.updateBtn.TabIndex = 18
        Me.updateBtn.Text = "UPDATE"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.deleteBtn.FlatAppearance.BorderSize = 3
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.deleteBtn.Location = New System.Drawing.Point(319, 277)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(95, 39)
        Me.deleteBtn.TabIndex = 17
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'employee_number
        '
        Me.employee_number.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.employee_number.Location = New System.Drawing.Point(34, 139)
        Me.employee_number.Name = "employee_number"
        Me.employee_number.Size = New System.Drawing.Size(380, 30)
        Me.employee_number.TabIndex = 15
        Me.employee_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(150, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 23)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Employee Number*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(281, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "TIN No.*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(89, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 23)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "SSS No.*"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.e_person)
        Me.GroupBox1.Controls.Add(Me.e_number)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.lname)
        Me.GroupBox1.Controls.Add(Me.mi)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(479, 705)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(122, 622)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Emergency Contact Person*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(121, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Emergency Contact Number*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(182, 442)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(176, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(385, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "M.I."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(179, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "First Name*"
        '
        'e_person
        '
        Me.e_person.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.e_person.Location = New System.Drawing.Point(37, 648)
        Me.e_person.Name = "e_person"
        Me.e_person.Size = New System.Drawing.Size(393, 30)
        Me.e_person.TabIndex = 6
        Me.e_person.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'e_number
        '
        Me.e_number.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.e_number.Location = New System.Drawing.Point(37, 555)
        Me.e_number.MaxLength = 11
        Me.e_number.Name = "e_number"
        Me.e_number.Size = New System.Drawing.Size(393, 30)
        Me.e_number.TabIndex = 5
        Me.e_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.address.Location = New System.Drawing.Point(34, 468)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(396, 30)
        Me.address.TabIndex = 4
        Me.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lname
        '
        Me.lname.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lname.Location = New System.Drawing.Point(34, 386)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(396, 30)
        Me.lname.TabIndex = 3
        Me.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mi
        '
        Me.mi.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mi.Location = New System.Drawing.Point(382, 307)
        Me.mi.MaxLength = 1
        Me.mi.Name = "mi"
        Me.mi.Size = New System.Drawing.Size(48, 30)
        Me.mi.TabIndex = 2
        Me.mi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fname
        '
        Me.fname.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fname.Location = New System.Drawing.Point(37, 307)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(327, 30)
        Me.fname.TabIndex = 1
        Me.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.usi_id_signature)
        Me.GroupBox2.Controls.Add(Me.usi_id_picture)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(14, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 241)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PHOTO AND SIGNATURE"
        '
        'usi_id_signature
        '
        Me.usi_id_signature.BackColor = System.Drawing.Color.White
        Me.usi_id_signature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.usi_id_signature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usi_id_signature.Image = Global.IDSystem.My.Resources.Resources.id_signature_placeholder
        Me.usi_id_signature.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.usi_id_signature.Location = New System.Drawing.Point(231, 33)
        Me.usi_id_signature.Name = "usi_id_signature"
        Me.usi_id_signature.Size = New System.Drawing.Size(188, 192)
        Me.usi_id_signature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usi_id_signature.TabIndex = 1
        Me.usi_id_signature.TabStop = False
        '
        'usi_id_picture
        '
        Me.usi_id_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.usi_id_picture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usi_id_picture.Image = Global.IDSystem.My.Resources.Resources.placeholder
        Me.usi_id_picture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.usi_id_picture.Location = New System.Drawing.Point(23, 33)
        Me.usi_id_picture.Name = "usi_id_picture"
        Me.usi_id_picture.Size = New System.Drawing.Size(188, 192)
        Me.usi_id_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usi_id_picture.TabIndex = 0
        Me.usi_id_picture.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(952, 726)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Print ID"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pi_tp_dgv)
        Me.GroupBox4.Controls.Add(Me.removeSelectedBtn)
        Me.GroupBox4.Controls.Add(Me.removeAllBtn)
        Me.GroupBox4.Controls.Add(Me.printBtn)
        Me.GroupBox4.Controls.Add(Me.previewBtn)
        Me.GroupBox4.Controls.Add(Me.modifyBtn)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(479, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(463, 700)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PRINT QUEUE"
        '
        'pi_tp_dgv
        '
        Me.pi_tp_dgv.AllowUserToAddRows = False
        Me.pi_tp_dgv.AllowUserToDeleteRows = False
        Me.pi_tp_dgv.AllowUserToResizeColumns = False
        Me.pi_tp_dgv.AllowUserToResizeRows = False
        Me.pi_tp_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.pi_tp_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pi_tp_dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.pi_tp_dgv.ColumnHeadersHeight = 43
        Me.pi_tp_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pi_tp_dgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.pi_tp_dgv.Location = New System.Drawing.Point(12, 192)
        Me.pi_tp_dgv.Name = "pi_tp_dgv"
        Me.pi_tp_dgv.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pi_tp_dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.pi_tp_dgv.RowHeadersVisible = False
        Me.pi_tp_dgv.RowHeadersWidth = 51
        Me.pi_tp_dgv.RowTemplate.ReadOnly = True
        Me.pi_tp_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pi_tp_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pi_tp_dgv.Size = New System.Drawing.Size(441, 496)
        Me.pi_tp_dgv.TabIndex = 25
        '
        'removeSelectedBtn
        '
        Me.removeSelectedBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.removeSelectedBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.removeSelectedBtn.FlatAppearance.BorderSize = 3
        Me.removeSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeSelectedBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.removeSelectedBtn.ForeColor = System.Drawing.Color.White
        Me.removeSelectedBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.removeSelectedBtn.Location = New System.Drawing.Point(239, 93)
        Me.removeSelectedBtn.Name = "removeSelectedBtn"
        Me.removeSelectedBtn.Size = New System.Drawing.Size(214, 39)
        Me.removeSelectedBtn.TabIndex = 22
        Me.removeSelectedBtn.Text = "REMOVE SELECTED"
        Me.removeSelectedBtn.UseVisualStyleBackColor = False
        '
        'removeAllBtn
        '
        Me.removeAllBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeAllBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.removeAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.removeAllBtn.FlatAppearance.BorderSize = 3
        Me.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeAllBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.removeAllBtn.ForeColor = System.Drawing.Color.White
        Me.removeAllBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.removeAllBtn.Location = New System.Drawing.Point(12, 93)
        Me.removeAllBtn.Name = "removeAllBtn"
        Me.removeAllBtn.Size = New System.Drawing.Size(221, 39)
        Me.removeAllBtn.TabIndex = 21
        Me.removeAllBtn.Text = "CLEAR QUEUE"
        Me.removeAllBtn.UseVisualStyleBackColor = False
        '
        'printBtn
        '
        Me.printBtn.BackColor = System.Drawing.Color.Transparent
        Me.printBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.printBtn.FlatAppearance.BorderSize = 3
        Me.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.printBtn.ForeColor = System.Drawing.Color.White
        Me.printBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.printBtn.Location = New System.Drawing.Point(12, 144)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(441, 39)
        Me.printBtn.TabIndex = 20
        Me.printBtn.Text = "PRINT"
        Me.printBtn.UseVisualStyleBackColor = False
        '
        'previewBtn
        '
        Me.previewBtn.BackColor = System.Drawing.Color.Transparent
        Me.previewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previewBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.previewBtn.FlatAppearance.BorderSize = 3
        Me.previewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previewBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.previewBtn.ForeColor = System.Drawing.Color.White
        Me.previewBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.previewBtn.Location = New System.Drawing.Point(239, 43)
        Me.previewBtn.Name = "previewBtn"
        Me.previewBtn.Size = New System.Drawing.Size(214, 39)
        Me.previewBtn.TabIndex = 19
        Me.previewBtn.Text = "PRINT PREVIEW"
        Me.previewBtn.UseVisualStyleBackColor = False
        '
        'modifyBtn
        '
        Me.modifyBtn.BackColor = System.Drawing.Color.Transparent
        Me.modifyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.modifyBtn.FlatAppearance.BorderSize = 3
        Me.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifyBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.modifyBtn.ForeColor = System.Drawing.Color.White
        Me.modifyBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.modifyBtn.Location = New System.Drawing.Point(12, 43)
        Me.modifyBtn.Name = "modifyBtn"
        Me.modifyBtn.Size = New System.Drawing.Size(221, 39)
        Me.modifyBtn.TabIndex = 18
        Me.modifyBtn.Text = "MODIFY ID TEMPLATE"
        Me.modifyBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pi_refreshBtn)
        Me.GroupBox3.Controls.Add(Me.pi_dgv)
        Me.GroupBox3.Controls.Add(Me.GroupBox9)
        Me.GroupBox3.Controls.Add(Me.addToPrintQueueBtn)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(458, 700)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RECORD LIST"
        '
        'pi_refreshBtn
        '
        Me.pi_refreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.pi_refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pi_refreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.pi_refreshBtn.FlatAppearance.BorderSize = 3
        Me.pi_refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pi_refreshBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pi_refreshBtn.ForeColor = System.Drawing.Color.White
        Me.pi_refreshBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pi_refreshBtn.Location = New System.Drawing.Point(124, 208)
        Me.pi_refreshBtn.Name = "pi_refreshBtn"
        Me.pi_refreshBtn.Size = New System.Drawing.Size(223, 39)
        Me.pi_refreshBtn.TabIndex = 25
        Me.pi_refreshBtn.Text = "REFRESH LIST"
        Me.pi_refreshBtn.UseVisualStyleBackColor = False
        '
        'pi_dgv
        '
        Me.pi_dgv.AllowUserToAddRows = False
        Me.pi_dgv.AllowUserToDeleteRows = False
        Me.pi_dgv.AllowUserToResizeColumns = False
        Me.pi_dgv.AllowUserToResizeRows = False
        Me.pi_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pi_dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.pi_dgv.ColumnHeadersHeight = 43
        Me.pi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pi_dgv.DefaultCellStyle = DataGridViewCellStyle8
        Me.pi_dgv.Location = New System.Drawing.Point(14, 281)
        Me.pi_dgv.MultiSelect = False
        Me.pi_dgv.Name = "pi_dgv"
        Me.pi_dgv.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pi_dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.pi_dgv.RowHeadersVisible = False
        Me.pi_dgv.RowHeadersWidth = 51
        Me.pi_dgv.RowTemplate.ReadOnly = True
        Me.pi_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pi_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pi_dgv.Size = New System.Drawing.Size(429, 407)
        Me.pi_dgv.TabIndex = 24
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.pi_student_search)
        Me.GroupBox9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(14, 30)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(429, 88)
        Me.GroupBox9.TabIndex = 23
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "FILTER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(29, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "NAME:"
        '
        'pi_student_search
        '
        Me.pi_student_search.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pi_student_search.Location = New System.Drawing.Point(100, 36)
        Me.pi_student_search.Name = "pi_student_search"
        Me.pi_student_search.Size = New System.Drawing.Size(315, 30)
        Me.pi_student_search.TabIndex = 14
        Me.pi_student_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'addToPrintQueueBtn
        '
        Me.addToPrintQueueBtn.BackColor = System.Drawing.Color.Transparent
        Me.addToPrintQueueBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addToPrintQueueBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addToPrintQueueBtn.FlatAppearance.BorderSize = 3
        Me.addToPrintQueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addToPrintQueueBtn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.addToPrintQueueBtn.ForeColor = System.Drawing.Color.White
        Me.addToPrintQueueBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.addToPrintQueueBtn.Location = New System.Drawing.Point(124, 144)
        Me.addToPrintQueueBtn.Name = "addToPrintQueueBtn"
        Me.addToPrintQueueBtn.Size = New System.Drawing.Size(223, 39)
        Me.addToPrintQueueBtn.TabIndex = 23
        Me.addToPrintQueueBtn.Text = "ADD TO PRINT QUEUE"
        Me.addToPrintQueueBtn.UseVisualStyleBackColor = False
        '
        'ProfCleanupWorker
        '
        '
        'ProfPrinterList
        '
        Me.ProfPrinterList.AllowSomePages = True
        Me.ProfPrinterList.UseEXDialog = True
        '
        'Prof_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 811)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Prof_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Professor ID Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.dgv_usi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.usi_id_signature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usi_id_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.pi_tp_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pi_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents studentSearchUSI As TextBox
    Friend WithEvents dgv_usi As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents employee_number As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents e_person As TextBox
    Friend WithEvents e_number As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents mi As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents usi_id_signature As PictureBox
    Friend WithEvents usi_id_picture As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pi_tp_dgv As DataGridView
    Friend WithEvents removeSelectedBtn As Button
    Friend WithEvents removeAllBtn As Button
    Friend WithEvents printBtn As Button
    Friend WithEvents previewBtn As Button
    Friend WithEvents modifyBtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents pi_refreshBtn As Button
    Friend WithEvents pi_dgv As DataGridView
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pi_student_search As TextBox
    Friend WithEvents addToPrintQueueBtn As Button
    Friend WithEvents insertBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents position As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tin_no As TextBox
    Friend WithEvents sss_no As TextBox
    Friend WithEvents ProfCleanupWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProfPrinterList As PrintDialog
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
