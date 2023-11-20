<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.usi_refreshData = New System.Windows.Forms.Button()
        Me.studentSearchUSI = New System.Windows.Forms.TextBox()
        Me.dgv_usi = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.id_count_label = New System.Windows.Forms.Label()
        Me.date_updated_label = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.s_number = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.usi_course = New System.Windows.Forms.ComboBox()
        Me.usi_year = New System.Windows.Forms.ComboBox()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.remove_validity = New System.Windows.Forms.Button()
        Me.add_validity = New System.Windows.Forms.Button()
        Me.uid_add_validity = New System.Windows.Forms.TextBox()
        Me.uid_validity = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.remove_course = New System.Windows.Forms.Button()
        Me.add_course = New System.Windows.Forms.Button()
        Me.uid_add_course = New System.Windows.Forms.TextBox()
        Me.uid_course = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.uid_update_validity = New System.Windows.Forms.ComboBox()
        Me.updateAllBtn = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pi_tp_dgv = New System.Windows.Forms.DataGridView()
        Me.removeSelectedBtn = New System.Windows.Forms.Button()
        Me.removeAllBtn = New System.Windows.Forms.Button()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.previewBtn = New System.Windows.Forms.Button()
        Me.modifyBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.id_validity_indicator = New System.Windows.Forms.Label()
        Me.pi_refreshBtn = New System.Windows.Forms.Button()
        Me.pi_dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.pi_year = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pi_student_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pi_course = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addToPrintQueueBtn = New System.Windows.Forms.Button()
        Me.CleanupWorker = New System.ComponentModel.BackgroundWorker()
        Me.PrinterList = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgv_usi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.usi_id_signature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usi_id_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pi_tp_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pi_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.usi_refreshData)
        Me.GroupBox8.Controls.Add(Me.studentSearchUSI)
        Me.GroupBox8.Controls.Add(Me.dgv_usi)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.GroupBox8, "GroupBox8")
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.TabStop = False
        '
        'usi_refreshData
        '
        Me.usi_refreshData.BackColor = System.Drawing.Color.Transparent
        Me.usi_refreshData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usi_refreshData.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.usi_refreshData.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.usi_refreshData, "usi_refreshData")
        Me.usi_refreshData.ForeColor = System.Drawing.Color.White
        Me.usi_refreshData.Name = "usi_refreshData"
        Me.usi_refreshData.UseVisualStyleBackColor = False
        '
        'studentSearchUSI
        '
        resources.ApplyResources(Me.studentSearchUSI, "studentSearchUSI")
        Me.studentSearchUSI.Name = "studentSearchUSI"
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
        resources.ApplyResources(Me.dgv_usi, "dgv_usi")
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
        Me.dgv_usi.RowTemplate.ReadOnly = True
        Me.dgv_usi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_usi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.id_count_label)
        Me.GroupBox7.Controls.Add(Me.date_updated_label)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.updateBtn)
        Me.GroupBox7.Controls.Add(Me.deleteBtn)
        Me.GroupBox7.Controls.Add(Me.s_number)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.usi_course)
        Me.GroupBox7.Controls.Add(Me.usi_year)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'id_count_label
        '
        resources.ApplyResources(Me.id_count_label, "id_count_label")
        Me.id_count_label.Name = "id_count_label"
        '
        'date_updated_label
        '
        resources.ApplyResources(Me.date_updated_label, "date_updated_label")
        Me.date_updated_label.Name = "date_updated_label"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.updateBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.updateBtn, "updateBtn")
        Me.updateBtn.ForeColor = System.Drawing.Color.White
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.deleteBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.deleteBtn, "deleteBtn")
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        's_number
        '
        resources.ApplyResources(Me.s_number, "s_number")
        Me.s_number.Name = "s_number"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'usi_course
        '
        Me.usi_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.usi_course, "usi_course")
        Me.usi_course.FormattingEnabled = True
        Me.usi_course.Name = "usi_course"
        '
        'usi_year
        '
        Me.usi_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.usi_year, "usi_year")
        Me.usi_year.FormattingEnabled = True
        Me.usi_year.Items.AddRange(New Object() {resources.GetString("usi_year.Items"), resources.GetString("usi_year.Items1"), resources.GetString("usi_year.Items2"), resources.GetString("usi_year.Items3"), resources.GetString("usi_year.Items4")})
        Me.usi_year.Name = "usi_year"
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
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Name = "Label9"
        '
        'e_person
        '
        resources.ApplyResources(Me.e_person, "e_person")
        Me.e_person.Name = "e_person"
        '
        'e_number
        '
        resources.ApplyResources(Me.e_number, "e_number")
        Me.e_number.Name = "e_number"
        '
        'address
        '
        resources.ApplyResources(Me.address, "address")
        Me.address.Name = "address"
        '
        'lname
        '
        resources.ApplyResources(Me.lname, "lname")
        Me.lname.Name = "lname"
        '
        'mi
        '
        resources.ApplyResources(Me.mi, "mi")
        Me.mi.Name = "mi"
        '
        'fname
        '
        resources.ApplyResources(Me.fname, "fname")
        Me.fname.Name = "fname"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.usi_id_signature)
        Me.GroupBox2.Controls.Add(Me.usi_id_picture)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'usi_id_signature
        '
        Me.usi_id_signature.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.usi_id_signature, "usi_id_signature")
        Me.usi_id_signature.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usi_id_signature.Image = Global.IDSystem.My.Resources.Resources.id_signature_placeholder
        Me.usi_id_signature.Name = "usi_id_signature"
        Me.usi_id_signature.TabStop = False
        '
        'usi_id_picture
        '
        resources.ApplyResources(Me.usi_id_picture, "usi_id_picture")
        Me.usi_id_picture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usi_id_picture.Image = Global.IDSystem.My.Resources.Resources.placeholder
        Me.usi_id_picture.Name = "usi_id_picture"
        Me.usi_id_picture.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox10)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.remove_validity)
        Me.GroupBox6.Controls.Add(Me.add_validity)
        Me.GroupBox6.Controls.Add(Me.uid_add_validity)
        Me.GroupBox6.Controls.Add(Me.uid_validity)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'remove_validity
        '
        Me.remove_validity.BackColor = System.Drawing.Color.Transparent
        Me.remove_validity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remove_validity.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.remove_validity.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.remove_validity, "remove_validity")
        Me.remove_validity.ForeColor = System.Drawing.Color.White
        Me.remove_validity.Name = "remove_validity"
        Me.remove_validity.UseVisualStyleBackColor = False
        '
        'add_validity
        '
        Me.add_validity.BackColor = System.Drawing.Color.Transparent
        Me.add_validity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_validity.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.add_validity.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.add_validity, "add_validity")
        Me.add_validity.ForeColor = System.Drawing.Color.White
        Me.add_validity.Name = "add_validity"
        Me.add_validity.UseVisualStyleBackColor = False
        '
        'uid_add_validity
        '
        resources.ApplyResources(Me.uid_add_validity, "uid_add_validity")
        Me.uid_add_validity.Name = "uid_add_validity"
        '
        'uid_validity
        '
        Me.uid_validity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.uid_validity, "uid_validity")
        Me.uid_validity.FormattingEnabled = True
        Me.uid_validity.Name = "uid_validity"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.remove_course)
        Me.GroupBox5.Controls.Add(Me.add_course)
        Me.GroupBox5.Controls.Add(Me.uid_add_course)
        Me.GroupBox5.Controls.Add(Me.uid_course)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'remove_course
        '
        Me.remove_course.BackColor = System.Drawing.Color.Transparent
        Me.remove_course.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remove_course.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.remove_course.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.remove_course, "remove_course")
        Me.remove_course.ForeColor = System.Drawing.Color.White
        Me.remove_course.Name = "remove_course"
        Me.remove_course.UseVisualStyleBackColor = False
        '
        'add_course
        '
        Me.add_course.BackColor = System.Drawing.Color.Transparent
        Me.add_course.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_course.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.add_course.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.add_course, "add_course")
        Me.add_course.ForeColor = System.Drawing.Color.White
        Me.add_course.Name = "add_course"
        Me.add_course.UseVisualStyleBackColor = False
        '
        'uid_add_course
        '
        resources.ApplyResources(Me.uid_add_course, "uid_add_course")
        Me.uid_add_course.Name = "uid_add_course"
        '
        'uid_course
        '
        Me.uid_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.uid_course, "uid_course")
        Me.uid_course.FormattingEnabled = True
        Me.uid_course.Name = "uid_course"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.uid_update_validity)
        Me.GroupBox10.Controls.Add(Me.updateAllBtn)
        Me.GroupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.GroupBox10, "GroupBox10")
        Me.GroupBox10.ForeColor = System.Drawing.Color.White
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.TabStop = False
        '
        'uid_update_validity
        '
        Me.uid_update_validity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.uid_update_validity, "uid_update_validity")
        Me.uid_update_validity.FormattingEnabled = True
        Me.uid_update_validity.Name = "uid_update_validity"
        '
        'updateAllBtn
        '
        Me.updateAllBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateAllBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.updateAllBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.updateAllBtn, "updateAllBtn")
        Me.updateAllBtn.ForeColor = System.Drawing.Color.White
        Me.updateAllBtn.Name = "updateAllBtn"
        Me.updateAllBtn.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
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
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
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
        resources.ApplyResources(Me.pi_tp_dgv, "pi_tp_dgv")
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
        Me.pi_tp_dgv.RowTemplate.ReadOnly = True
        Me.pi_tp_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pi_tp_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'removeSelectedBtn
        '
        Me.removeSelectedBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.removeSelectedBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.removeSelectedBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.removeSelectedBtn, "removeSelectedBtn")
        Me.removeSelectedBtn.ForeColor = System.Drawing.Color.White
        Me.removeSelectedBtn.Name = "removeSelectedBtn"
        Me.removeSelectedBtn.UseVisualStyleBackColor = False
        '
        'removeAllBtn
        '
        Me.removeAllBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeAllBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.removeAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.removeAllBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.removeAllBtn, "removeAllBtn")
        Me.removeAllBtn.ForeColor = System.Drawing.Color.White
        Me.removeAllBtn.Name = "removeAllBtn"
        Me.removeAllBtn.UseVisualStyleBackColor = False
        '
        'printBtn
        '
        Me.printBtn.BackColor = System.Drawing.Color.Transparent
        Me.printBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.printBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.printBtn, "printBtn")
        Me.printBtn.ForeColor = System.Drawing.Color.White
        Me.printBtn.Name = "printBtn"
        Me.printBtn.UseVisualStyleBackColor = False
        '
        'previewBtn
        '
        Me.previewBtn.BackColor = System.Drawing.Color.Transparent
        Me.previewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previewBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.previewBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.previewBtn, "previewBtn")
        Me.previewBtn.ForeColor = System.Drawing.Color.White
        Me.previewBtn.Name = "previewBtn"
        Me.previewBtn.UseVisualStyleBackColor = False
        '
        'modifyBtn
        '
        Me.modifyBtn.BackColor = System.Drawing.Color.Transparent
        Me.modifyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.modifyBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.modifyBtn, "modifyBtn")
        Me.modifyBtn.ForeColor = System.Drawing.Color.White
        Me.modifyBtn.Name = "modifyBtn"
        Me.modifyBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.id_validity_indicator)
        Me.GroupBox3.Controls.Add(Me.pi_refreshBtn)
        Me.GroupBox3.Controls.Add(Me.pi_dgv)
        Me.GroupBox3.Controls.Add(Me.GroupBox9)
        Me.GroupBox3.Controls.Add(Me.addToPrintQueueBtn)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'id_validity_indicator
        '
        resources.ApplyResources(Me.id_validity_indicator, "id_validity_indicator")
        Me.id_validity_indicator.Name = "id_validity_indicator"
        '
        'pi_refreshBtn
        '
        Me.pi_refreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.pi_refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pi_refreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.pi_refreshBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.pi_refreshBtn, "pi_refreshBtn")
        Me.pi_refreshBtn.ForeColor = System.Drawing.Color.White
        Me.pi_refreshBtn.Name = "pi_refreshBtn"
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
        resources.ApplyResources(Me.pi_dgv, "pi_dgv")
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
        Me.pi_dgv.RowTemplate.ReadOnly = True
        Me.pi_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pi_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.pi_year)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.pi_student_search)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.pi_course)
        Me.GroupBox9.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox9, "GroupBox9")
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.TabStop = False
        '
        'pi_year
        '
        Me.pi_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.pi_year, "pi_year")
        Me.pi_year.FormattingEnabled = True
        Me.pi_year.Items.AddRange(New Object() {resources.GetString("pi_year.Items"), resources.GetString("pi_year.Items1"), resources.GetString("pi_year.Items2"), resources.GetString("pi_year.Items3"), resources.GetString("pi_year.Items4")})
        Me.pi_year.Name = "pi_year"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'pi_student_search
        '
        resources.ApplyResources(Me.pi_student_search, "pi_student_search")
        Me.pi_student_search.Name = "pi_student_search"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'pi_course
        '
        Me.pi_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.pi_course, "pi_course")
        Me.pi_course.FormattingEnabled = True
        Me.pi_course.Name = "pi_course"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'addToPrintQueueBtn
        '
        Me.addToPrintQueueBtn.BackColor = System.Drawing.Color.Transparent
        Me.addToPrintQueueBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addToPrintQueueBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.addToPrintQueueBtn.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.addToPrintQueueBtn, "addToPrintQueueBtn")
        Me.addToPrintQueueBtn.ForeColor = System.Drawing.Color.White
        Me.addToPrintQueueBtn.Name = "addToPrintQueueBtn"
        Me.addToPrintQueueBtn.UseVisualStyleBackColor = False
        '
        'CleanupWorker
        '
        '
        'PrinterList
        '
        Me.PrinterList.AllowSomePages = True
        Me.PrinterList.UseEXDialog = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        '
        'Admin_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IDSystem.My.Resources.Resources.mainbg
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Admin_Form"
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
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.pi_tp_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pi_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents printBtn As Button
    Friend WithEvents previewBtn As Button
    Friend WithEvents modifyBtn As Button
    Friend WithEvents pi_student_search As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pi_course As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents uid_course As ComboBox
    Friend WithEvents uid_validity As ComboBox
    Friend WithEvents pi_year As ComboBox
    Friend WithEvents uid_add_course As TextBox
    Friend WithEvents uid_add_validity As TextBox
    Friend WithEvents remove_course As Button
    Friend WithEvents add_course As Button
    Friend WithEvents remove_validity As Button
    Friend WithEvents add_validity As Button
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
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents s_number As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents usi_course As ComboBox
    Friend WithEvents usi_year As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents studentSearchUSI As TextBox
    Friend WithEvents dgv_usi As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents removeSelectedBtn As Button
    Friend WithEvents removeAllBtn As Button
    Friend WithEvents addToPrintQueueBtn As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents usi_refreshData As Button
    Friend WithEvents pi_dgv As DataGridView
    Friend WithEvents pi_tp_dgv As DataGridView
    Friend WithEvents pi_refreshBtn As Button
    Friend WithEvents updateAllBtn As Button
    Friend WithEvents uid_update_validity As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents CleanupWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents id_count_label As Label
    Friend WithEvents date_updated_label As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PrinterList As PrintDialog
    Friend WithEvents id_validity_indicator As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
