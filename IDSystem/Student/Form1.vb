Imports System.Data.OleDb
Imports System.Drawing.Imaging

Public Class Form1
    Public DB As New Connection
    Public isIdUploaded As Integer = 0
    Public isSignatureUploaded As Integer = 0
    Public isAdminFormOpen As Boolean = False

    Public Sub loadData(Optional query As String = "SELECT TOP 10 full_name AS Full_Name FROM student_search ORDER BY full_name ASC")
        Using adpt As New OleDbDataAdapter(query, DB.student_data_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub

    Public Sub loadComboBox()
        Dim adpt_course As New OleDbDataAdapter("SELECT * FROM courses", DB.student_id_details_conn)
        Dim dt_course As New DataTable
        adpt_course.Fill(dt_course)
        course.DataSource = dt_course
        course.DisplayMember = "course_list"
    End Sub

    Public Sub ResizeSaveSignature(img As Image, filename As String)
        'bitmap for result
        Using imgResult As New Bitmap(308, 107)
            'Graphics object for result
            Using grResult As Graphics = Graphics.FromImage(imgResult)
                ''source to result bitmap
                grResult.DrawImage(img, 0, 0, imgResult.Width, imgResult.Height)
                ''save result
                imgResult.Save($"{Application.StartupPath}\student_signatures\{filename}")
            End Using
        End Using
    End Sub

    Public Sub ResizeSaveIDPicture(img As Image, filename As String)
        'bitmap for result
        Using imgResult As New Bitmap(225, 225)
            'Graphics object for result
            Using grResult As Graphics = Graphics.FromImage(imgResult)
                ''source to result bitmap
                grResult.DrawImage(img, 0, 0, imgResult.Width, imgResult.Height)
                ''save result
                imgResult.Save($"{Application.StartupPath}\student_pictures\{filename}")
            End Using
        End Using
    End Sub

    Public Sub clearInput()
        fname.Clear()
        mi.Clear()
        lname.Clear()
        address.Clear()
        e_number.Clear()
        e_person.Clear()
        student_search.Clear()
        year.Text = Nothing
        course.Text = Nothing
        s_number.Clear()
        id_picture.Image = My.Resources.placeholder
        id_signature.Image = My.Resources.id_signature_placeholder
        isIdUploaded = 0
        isSignatureUploaded = 0
    End Sub

    Private Sub e_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e_number.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadComboBox()
    End Sub

    Private Sub student_search_TextChanged(sender As Object, e As EventArgs) Handles student_search.TextChanged
        loadData($"SELECT TOP 10 full_name AS Full_Name FROM student_search WHERE full_name LIKE '%{student_search.Text}%' ORDER BY full_name ASC")
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        If MsgBox("Are you sure you want to clear all input?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            clearInput()
        End If
    End Sub

    Private Sub mi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mi.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub id_signature_Click(sender As Object, e As EventArgs) Handles id_signature.Click
        Signpad_Form.Show()
    End Sub

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        If (fname.Text = "" Or
            fname.Text = Nothing Or
            lname.Text = "" Or
            lname.Text = Nothing Or
            address.Text = "" Or
            address.Text = Nothing Or
            e_number.Text = "" Or
            e_person.Text = Nothing Or
            year.SelectedIndex = 0 Or
            year.Text = "" Or
            year.Text = Nothing Or
            course.SelectedIndex = 0 Or
            course.Text = "" Or
            course.Text = Nothing Or
            isIdUploaded = 0 Or
            isSignatureUploaded = 0) Then
            MsgBox("Please complete all input", MsgBoxStyle.OkOnly)
        Else
            Dim check_adpt As New OleDbDataAdapter($"SELECT record_number FROM student_search WHERE full_name LIKE '%{lname.Text}, {fname.Text}%'", DB.student_data_conn)
            Dim dt_check As New DataTable
            check_adpt.Fill(dt_check)
            If dt_check.Rows.Count >= 1 Then
                MsgBox("Record found. If you want to update your record please ask the administrator.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Are you sure these input are all correct?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim modifiedMi As String = ""
                    If Not mi.Text = Nothing Or Not mi.Text = "" Then
                        modifiedMi = $"{mi.Text}."
                    End If

                    Dim new_sy As New Date(Date.Now.Year, 7, 1)
                    Dim curr_year As Integer = Date.Now.Year
                    Dim setValidity As String
                    If Date.Now < new_sy Then
                        setValidity = $"{curr_year - 1}-{(curr_year).ToString.Substring(curr_year.ToString.Length - 2)}"
                    Else
                        setValidity = $"{curr_year}-{(curr_year + 1).ToString.Substring((curr_year + 1).ToString.Length - 2)}"
                    End If

                    DB.student_data_conn.Open()

                    'Insert record
                    Using cmd_insert As New OleDbCommand("INSERT INTO students([s_number],[fname],[mi],[lname],[address],[e_number],[e_person],[s_year],[s_course],[s_validity]) VALUES(@snumber,@fname,@mi,@lname,@addr,@enumber,@eperson,@syear,@scourse,@svalidity)", DB.student_data_conn)
                        With cmd_insert
                            .Parameters.AddWithValue("@snumber", s_number.Text)
                            .Parameters.AddWithValue("@fname", StrConv(fname.Text, 3))
                            .Parameters.AddWithValue("@mi", modifiedMi)
                            .Parameters.AddWithValue("@lname", StrConv(lname.Text, 3))
                            .Parameters.AddWithValue("@addr", address.Text)
                            .Parameters.AddWithValue("@enumber", e_number.Text)
                            .Parameters.AddWithValue("@eperson", e_person.Text)
                            .Parameters.AddWithValue("@syear", year.Text)
                            .Parameters.AddWithValue("@scourse", course.Text)
                            .Parameters.AddWithValue("@svalidity", setValidity)
                            .ExecuteNonQuery()
                        End With
                    End Using

                    ' Retrieve the autonumber value of the inserted row
                    Dim recentIdHolder As Integer
                    Using autonumberCmd As New OleDbCommand("SELECT @@IDENTITY;", DB.student_data_conn)
                        recentIdHolder = Convert.ToInt32(autonumberCmd.ExecuteScalar())
                    End Using

                    'Set filename for id_picture & id_signature
                    Dim newPictureName As String = $"{recentIdHolder}.jpg"
                    Dim newSignatureName As String = $"{recentIdHolder}.png"
                    Using populatePic As New OleDbCommand($"UPDATE students SET picture=@picture,signature=@signature WHERE record_number={recentIdHolder}", DB.student_data_conn)
                        populatePic.Parameters.AddWithValue("@picture", newPictureName)
                        populatePic.Parameters.AddWithValue("@signature", newSignatureName)
                        populatePic.ExecuteNonQuery()
                    End Using

                    DB.student_data_conn.Close()
                    ResizeSaveIDPicture(id_picture.Image, newPictureName)
                    ResizeSaveSignature(id_signature.Image, newSignatureName)
                    clearInput()
                    loadData()
                    MsgBox("Student successfully registered", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub s_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles s_number.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub id_picture_Click(sender As Object, e As EventArgs) Handles id_picture.Click
        Select_Photo_Source.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If isAdminFormOpen Then
            MsgBox("Admin Form is already open")
        Else
            Admin_Creds.toProfIdForm = False
            Admin_Creds.Show()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            For Each process In System.Diagnostics.Process.GetProcessesByName("MSACCESS")
                process.Kill()
            Next
        Catch ex As Exception

        Finally
            Home.Show()
            Me.Dispose()
            Me.Close()
            Admin_Form.Close()
        End Try
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        loadData()
        MsgBox("Data Refreshed")
    End Sub
End Class