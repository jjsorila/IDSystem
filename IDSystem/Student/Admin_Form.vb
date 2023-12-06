Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop.Access

Public Class Admin_Form
    Dim DB As New Connection
    Public isSignatureUploaded As Integer = 0
    Public isIdUploaded As Integer = 0
    Public record_number As String = Nothing
    Public isUSIHasRun As Boolean = False

    'USI TAB=======================================================================================================================================================
    Public Sub loadUSIData(Optional query As String = "SELECT TOP 20 full_name AS 'Full Name' FROM student_search ORDER BY full_name ASC")
        Using adpt As New OleDbDataAdapter(query, DB.student_data_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                dgv_usi.DataSource = dt
            End Using
        End Using
    End Sub

    Public Sub clearUSIInput()
        usi_id_picture.Image = My.Resources.placeholder
        isIdUploaded = 0
        usi_id_signature.Image = My.Resources.id_signature_placeholder
        isSignatureUploaded = 0
        fname.Clear()
        mi.Clear()
        lname.Clear()
        e_number.Clear()
        e_person.Clear()
        usi_year.Text = Nothing
        usi_course.Text = Nothing
        s_number.Clear()
        studentSearchUSI.Clear()
        address.Clear()
        record_number = Nothing
        id_count_label.Text = Nothing
        date_updated_label.Text = Nothing
    End Sub

    Public Sub loadUSIComboBox()
        Dim adpt_course As New OleDbDataAdapter("SELECT * FROM courses", DB.student_id_details_conn)
        Dim dt_course As New DataTable
        adpt_course.Fill(dt_course)
        usi_course.DataSource = dt_course
        usi_course.DisplayMember = "course_list"
    End Sub

    Public Sub ResizeSaveSignature(img As Drawing.Image, filename As String)
        'bitmap for result
        Using imgResult As New Bitmap(308, 107)
            'Graphics object for result
            Using grResult As Graphics = Graphics.FromImage(imgResult)
                ''source to result bitmap
                grResult.DrawImage(img, 0, 0, imgResult.Width, imgResult.Height)
                ''save result
                imgResult.Save($"{Windows.Forms.Application.StartupPath}\student_signatures\{filename}")
            End Using
        End Using
    End Sub

    Public Sub ResizeSaveIDPicture(img As Drawing.Image, filename As String)
        'bitmap for result
        Using imgResult As New Bitmap(500, 500)
            'Graphics object for result
            Using grResult As Graphics = Graphics.FromImage(imgResult)
                ''source to result bitmap
                grResult.DrawImage(img, 0, 0, imgResult.Width, imgResult.Height)
                ''save result
                imgResult.Save($"{Windows.Forms.Application.StartupPath}\student_pictures\{filename}")
            End Using
        End Using
    End Sub

    Private Sub studentSearchUSI_TextChanged(sender As Object, e As EventArgs) Handles studentSearchUSI.TextChanged
        If studentSearchUSI.Text = Nothing Or studentSearchUSI.Text = "" Then
            loadUSIData()
        Else
            loadUSIData($"SELECT TOP 20 full_name AS 'Full Name' FROM student_search WHERE full_name LIKE '%{studentSearchUSI.Text}%' ORDER BY full_name ASC")
        End If
    End Sub

    Private Sub usi_id_signature_Click(sender As Object, e As EventArgs) Handles usi_id_signature.Click
        If record_number = Nothing Then
            MsgBox("Please select a student", MsgBoxStyle.OkOnly)
        Else
            Admin_Select_Signature_Source.Show()
        End If
    End Sub

    Private Sub usi_id_picture_Click(sender As Object, e As EventArgs) Handles usi_id_picture.Click
        If record_number = Nothing Then
            MsgBox("Please select a student", MsgBoxStyle.OkOnly)
        Else
            Admin_Select_Photo_Source.Show()
        End If
    End Sub

    Private Sub dgv_usi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usi.CellClick
        Dim row As DataGridViewRow = dgv_usi.CurrentRow
        Using find_record_num_adpt As New OleDbDataAdapter($"SELECT record_number FROM student_search WHERE full_name='{row.Cells(0).Value}'", DB.student_data_conn)
            Using fing_record_num_dt As New DataTable
                find_record_num_adpt.Fill(fing_record_num_dt)
                record_number = fing_record_num_dt.Rows(0)(0).ToString()
            End Using
        End Using

        Using display_record As New OleDbDataAdapter($"SELECT * FROM students WHERE record_number={record_number}", DB.student_data_conn)
            Using dt As New DataTable
                display_record.Fill(dt)
                Dim currentRow As DataRow = dt.Rows(0)
                fname.Text = currentRow("fname")
                mi.Text = currentRow("mi")
                lname.Text = currentRow("lname")
                address.Text = currentRow("address")
                e_number.Text = currentRow("e_number")
                e_person.Text = currentRow("e_person")
                usi_year.Text = currentRow("s_year")
                usi_course.Text = currentRow("s_course")
                s_number.Text = currentRow("s_number")
                date_updated_label.Text = currentRow("date_updated")
                id_count_label.Text = currentRow("id_release_count")
                Using fsID As New IO.FileStream($"{Windows.Forms.Application.StartupPath}\student_pictures\{record_number}.jpg", IO.FileMode.Open, IO.FileAccess.Read)
                    usi_id_picture.Image = System.Drawing.Image.FromStream(fsID)
                    isIdUploaded = 1
                End Using
                Using fsSign As New IO.FileStream($"{Windows.Forms.Application.StartupPath}\student_signatures\{record_number}.png", IO.FileMode.Open, IO.FileAccess.Read)
                    usi_id_signature.Image = System.Drawing.Image.FromStream(fsSign)
                    isSignatureUploaded = 1
                End Using
            End Using
        End Using
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If record_number = Nothing Then
            MsgBox("Please select a student", MsgBoxStyle.OkOnly)
        Else
            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DB.student_data_conn.Open()
                Using cmd As New OleDbCommand($"DELETE FROM students WHERE record_number={record_number}", DB.student_data_conn)
                    cmd.ExecuteNonQuery()
                End Using
                DB.student_data_conn.Close()
                My.Computer.FileSystem.DeleteFile($"{Windows.Forms.Application.StartupPath}\student_pictures\{record_number}.jpg")
                My.Computer.FileSystem.DeleteFile($"{Windows.Forms.Application.StartupPath}\student_signatures\{record_number}.png")
                clearUSIInput()
                loadUSIData()
                loadPIStudents()
                MsgBox("Student Record Deleted", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If record_number = Nothing Then
            MsgBox("Please select a student", MsgBoxStyle.OkOnly)
        Else
            If fname.Text = Nothing Or
                lname.Text = Nothing Or
                address.Text = Nothing Or
                e_number.Text = Nothing Or
                s_number.Text = Nothing Or
                e_person.Text = Nothing Or
                usi_year.SelectedIndex = 0 Or
                usi_course.SelectedIndex = 0 Or
                isIdUploaded = 0 Or
                isSignatureUploaded = 0 Then

                MsgBox("Please complete all inputs", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim modifiedMi As String = ""
                    If Not mi.Text = Nothing Or Not mi.Text = "" Then
                        If InStr(mi.Text, ".") = 0 Then
                            modifiedMi = $"{mi.Text}."
                        Else
                            modifiedMi = mi.Text
                        End If
                    End If
                    DB.student_data_conn.Open()
                    Using cmd As New OleDbCommand("UPDATE students SET s_number=@s_number,fname=@fname,mi=@mi,lname=@lanme,address=@address,e_number=@e_number,e_person=@e_person,s_year=@s_year,s_course=@s_course,date_updated=@updated WHERE record_number=@record_number", DB.student_data_conn)
                        With cmd
                            .Parameters.AddWithValue("@s_number", s_number.Text)
                            .Parameters.AddWithValue("@fname", StrConv(fname.Text, 3))
                            .Parameters.AddWithValue("@mi", modifiedMi)
                            .Parameters.AddWithValue("@lname", StrConv(lname.Text, 3))
                            .Parameters.AddWithValue("@address", address.Text)
                            .Parameters.AddWithValue("@e_number", e_number.Text)
                            .Parameters.AddWithValue("@e_person", e_person.Text)
                            .Parameters.AddWithValue("@s_year", usi_year.Text)
                            .Parameters.AddWithValue("@s_course", usi_course.Text)
                            .Parameters.AddWithValue("@updated", DateTime.Now().ToString("M/dd/yyyy h:mm:ss tt"))
                            .Parameters.AddWithValue("@record_number", record_number)
                            .ExecuteNonQuery()
                        End With
                    End Using
                    DB.student_data_conn.Close()
                    ResizeSaveIDPicture(usi_id_picture.Image, $"{record_number}.jpg")
                    ResizeSaveSignature(usi_id_signature.Image, $"{record_number}.png")
                    clearUSIInput()
                    loadUSIData()
                    loadPIStudents()
                    MsgBox("Record Updated", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub e_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e_number.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub mi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mi.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub s_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles s_number.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub usi_refreshData_Click(sender As Object, e As EventArgs) Handles usi_refreshData.Click
        loadUSIData()
        clearUSIInput()
        MsgBox("Data Refreshed", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        If Not isUSIHasRun Then
            loadUSIData()
            loadUSIComboBox()
            isUSIHasRun = True
        End If
    End Sub

    'PRINT ID TAB==================================================================================================================================================

    Public isPIHasRun As Boolean = False
    Public piSelect As String = Nothing
    Dim globalAccessApp As New Microsoft.Office.Interop.Access.Application()

    Public Function IsAccessRunning() As Boolean
        Dim accessProcessName As String = "MSACCESS" ' Process name for Microsoft Access

        ' Get the list of all running processes
        Dim processes As Process() = Process.GetProcesses()

        ' Check if any of the processes match Microsoft Access and have a visible window
        For Each process As Process In processes
            If String.Equals(process.ProcessName, accessProcessName, StringComparison.OrdinalIgnoreCase) AndAlso Not process.MainWindowHandle.Equals(IntPtr.Zero) Then
                ' Microsoft Access is running and has a visible window
                Return True
            End If
        Next

        ' Microsoft Access is not running or is running in the background
        Return False
    End Function

    Public Sub loadPIPrintQueue()
        Using adpt As New OleDbDataAdapter("SELECT s_number AS 'Student Number',lname & ', ' & fname & ' ' & mi AS 'Full Name' FROM to_print", DB.student_to_print_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                pi_tp_dgv.DataSource = dt
            End Using
        End Using
    End Sub
    Public Sub loadPIStudents()
        pi_dgv.DefaultCellStyle.ForeColor = Color.Black
        Dim ssQuery As String = $"full_name LIKE '%{pi_student_search.Text}%'"
        Dim courseQuery As String = $"s_course='{pi_course.Text}'"
        Dim yearQuery As String = $"s_year='{pi_year.Text}'"

        If pi_student_search.Text = Nothing Or pi_student_search.Text = "" Then
            ssQuery = "NOT full_name IS NULL"
        End If

        If pi_course.Text = Nothing Or pi_course.SelectedIndex = 0 Then
            courseQuery = "NOT s_course IS NULL"
        End If

        If pi_year.Text = Nothing Or pi_year.SelectedIndex = 0 Then
            yearQuery = "NOT s_year IS NULL"
        End If

        Using adpt As New OleDbDataAdapter($"SELECT TOP 20 id_release_count AS 'ID Count',full_name AS 'Full Name' FROM student_search WHERE {ssQuery} AND {courseQuery} AND {yearQuery} ORDER BY full_name ASC", DB.student_data_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                pi_dgv.DataSource = dt
                pi_dgv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                pi_dgv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using
        End Using

    End Sub

    Public Sub loadPIComboBox()
        Dim adpt As New OleDbDataAdapter("SELECT * FROM courses", DB.student_id_details_conn)
        Dim dt As New DataTable
        adpt.Fill(dt)
        pi_course.DataSource = dt
        pi_course.DisplayMember = "course_list"
    End Sub

    Public Sub clearPIInput()
        pi_student_search.Clear()
        pi_course.SelectedIndex = 0
        pi_year.SelectedIndex = 0
    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        If Not isPIHasRun Then
            Using adpt As New OleDbDataAdapter("SELECT current_validity FROM validity", DB.student_id_details_conn)
                Using dt As New DataTable
                    adpt.Fill(dt)
                    id_validity_indicator.Text = $"Current ID Validity: {dt.Rows(0)("current_validity").ToString}"
                End Using
            End Using
            loadPIStudents()
            loadPIComboBox()
            loadPIPrintQueue()
            isPIHasRun = True
        End If
    End Sub

    Private Sub pi_student_search_TextChanged(sender As Object, e As EventArgs) Handles pi_student_search.TextChanged
        loadPIStudents()
    End Sub

    Private Sub pi_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pi_year.SelectedIndexChanged
        loadPIStudents()
    End Sub

    Private Sub pi_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pi_course.SelectedIndexChanged
        loadPIStudents()
    End Sub

    Private Sub addToPrintQueueBtn_Click(sender As Object, e As EventArgs) Handles addToPrintQueueBtn.Click
        If IsAccessRunning() Then
            MsgBox("Please close all opened MS ACCESS app")
            Exit Sub
        End If

        If pi_tp_dgv.Rows.Count >= 5 Then
            MsgBox("Print queue is full", MsgBoxStyle.OkOnly)
        Else
            If piSelect = Nothing Then
                MsgBox("Please select a student")
            Else
                Dim setValidity As String
                Using adpt As New OleDbDataAdapter("SELECT current_validity FROM validity", DB.student_id_details_conn)
                    Using dt As New DataTable
                        adpt.Fill(dt)
                        setValidity = dt.Rows(0)("current_validity")
                    End Using
                End Using

                'CHECK IF IT WAS ALREADY IN THE PRINT QUEUE
                Dim rows As DataGridViewRowCollection = pi_tp_dgv.Rows
                Dim isFound As Boolean = False
                For Each row As DataGridViewRow In rows
                    If UCase(row.Cells(1).Value.ToString) = UCase(piSelect) Then
                        isFound = True
                    End If
                Next

                If isFound Then
                    MsgBox("Record already on print queue")
                Else
                    Dim pi_record_numer As String

                    'GET RECORD NUMBER
                    Using adpt As New OleDbDataAdapter($"SELECT record_number FROM student_search WHERE full_name='{piSelect}'", DB.student_data_conn)
                        Using dt As New DataTable
                            adpt.Fill(dt)
                            pi_record_numer = dt.Rows(0)(0).ToString()
                        End Using
                    End Using

                    'CHECK IF STUDENT HAS STUDENT NUMBER
                    Using checkS_Number As New OleDbDataAdapter($"SELECT s_number FROM students WHERE record_number={pi_record_numer}", DB.student_data_conn)
                        Using dt As New DataTable
                            checkS_Number.Fill(dt)
                            Dim temp_s_number As String = dt.Rows(0)(0).ToString()
                            If temp_s_number = Nothing Then
                                MsgBox("Record has no Student Number")
                                Exit Sub
                            End If
                        End Using
                    End Using

                    'GET ID DETAILS
                    Dim s_number, fname, lname, mi, address, e_number, e_person, s_course, s_year, idPicture, idSignature As String
                    Using adpt As New OleDbDataAdapter($"SELECT * FROM students WHERE record_number={pi_record_numer}", DB.student_data_conn)
                        Using dt As New DataTable
                            adpt.Fill(dt)
                            Dim currentRow As DataRow = dt.Rows(0)
                            s_number = currentRow("s_number")
                            fname = currentRow("fname")
                            mi = currentRow("mi")
                            lname = currentRow("lname")
                            address = currentRow("address")
                            e_number = currentRow("e_number")
                            e_person = currentRow("e_person")
                            s_course = currentRow("s_course")
                            s_year = currentRow("s_year")
                            idPicture = $"{Windows.Forms.Application.StartupPath}\student_pictures\{currentRow("picture")}"
                            idSignature = $"{Windows.Forms.Application.StartupPath}\student_signatures\{currentRow("signature")}"
                        End Using
                    End Using

                    'INSERT TO PRINT QUEUE DB
                    DB.student_to_print_conn.Open()
                    Using cmd As New OleDbCommand("INSERT INTO to_print VALUES(@s_number,@fname,@mi,@lname,@address,@e_number,@e_person,@picture,@signature,@s_year,@s_course,@s_validity)", DB.student_to_print_conn)
                        With cmd
                            .Parameters.AddWithValue("@s_number", s_number)
                            .Parameters.AddWithValue("@fname", fname)
                            .Parameters.AddWithValue("@mi", mi)
                            .Parameters.AddWithValue("@lname", UCase(lname))
                            .Parameters.AddWithValue("@address", StrReverse(address))
                            .Parameters.AddWithValue("@e_number", StrReverse(e_number))
                            .Parameters.AddWithValue("@e_person", StrReverse(e_person))
                            .Parameters.AddWithValue("@picture", idPicture)
                            .Parameters.AddWithValue("@signature", idSignature)
                            .Parameters.AddWithValue("@s_year", StrReverse(s_year))
                            .Parameters.AddWithValue("@s_course", s_course)
                            .Parameters.AddWithValue("@s_validity", StrReverse(setValidity))
                            .ExecuteNonQuery()
                        End With
                    End Using
                    DB.student_to_print_conn.Close()
                    loadPIPrintQueue()
                End If
            End If
        End If
    End Sub

    Private Sub pi_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pi_dgv.CellClick
        piSelect = pi_dgv.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub removeSelectedBtn_Click(sender As Object, e As EventArgs) Handles removeSelectedBtn.Click
        If IsAccessRunning() Then
            MsgBox("Please close all opened MS ACCESS app")
            Exit Sub
        End If

        Dim rows As DataGridViewSelectedRowCollection = pi_tp_dgv.SelectedRows

        If rows.Count >= 1 Then
            If MsgBox("Do you want to remove this/these from print queue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                DB.student_to_print_conn.Open()
                Dim cmd As New OleDbCommand
                For Each row As DataGridViewRow In rows
                    cmd.CommandText = $"DELETE FROM to_print WHERE s_number='{row.Cells(0).Value.ToString}'"
                    cmd.Connection = DB.student_to_print_conn
                    cmd.ExecuteNonQuery()
                Next
                cmd.Dispose()
                DB.student_to_print_conn.Close()
                loadPIPrintQueue()
            End If
        Else
            MsgBox("Select a queue")
        End If
    End Sub

    Private Sub removeAllBtn_Click(sender As Object, e As EventArgs) Handles removeAllBtn.Click
        If IsAccessRunning() Then
            MsgBox("Please close all opened MS ACCESS app")
            Exit Sub
        End If

        Dim rows As DataGridViewRowCollection = pi_tp_dgv.Rows
        If rows.Count >= 1 Then
            If MsgBox("Do you want to clear out print queue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DB.student_to_print_conn.Open()
                Using cmd As New OleDbCommand("DELETE FROM to_print", DB.student_to_print_conn)
                    cmd.ExecuteNonQuery()
                End Using
                DB.student_to_print_conn.Close()
                loadPIPrintQueue()
            End If
        Else
            MsgBox("No queue to clear")
        End If
    End Sub

    Private Sub modifyBtn_Click(sender As Object, e As EventArgs) Handles modifyBtn.Click
        Try
            globalAccessApp.OpenCurrentDatabase($"{Windows.Forms.Application.StartupPath}\Student_To_Print.accdb", False, "")
        Catch ex As Exception

        End Try
        Dim strAccReport As String = "to_print"
        globalAccessApp.DoCmd.OpenReport(strAccReport, AcView.acViewDesign, Type.Missing, Type.Missing, AcWindowMode.acWindowNormal, Type.Missing)
        globalAccessApp.Visible = True
    End Sub

    Private Sub previewBtn_Click(sender As Object, e As EventArgs) Handles previewBtn.Click
        Dim rows As DataGridViewRowCollection = pi_tp_dgv.Rows

        If rows.Count <= 0 Then
            MsgBox("No data to print")
            Exit Sub
        End If

        Try
            globalAccessApp.OpenCurrentDatabase($"{Windows.Forms.Application.StartupPath}\Student_To_Print.accdb", False, "")
        Catch ex As Exception

        End Try
        Dim strAccReport As String = "to_print"
        globalAccessApp.DoCmd.OpenReport(strAccReport, AcView.acViewPreview, Type.Missing, Type.Missing, AcWindowMode.acWindowNormal, Type.Missing)
        globalAccessApp.Visible = True
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        DB.student_data_conn.Close()
        DB.student_to_print_conn.Close()
        printBtn.Enabled = False
        Dim rows As DataGridViewRowCollection = pi_tp_dgv.Rows

        If IsAccessRunning() Then
            MsgBox("Please close all opened MS ACCESS app")
        Else
            If rows.Count <= 0 Then
                MsgBox("No data to print")
            Else
                If MsgBox("Is the printer ready and physically connected?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
                    Try
                        globalAccessApp.OpenCurrentDatabase($"{Windows.Forms.Application.StartupPath}\Student_To_Print.accdb", False, "")
                    Catch ex As Exception

                    End Try

                    If PrinterList.ShowDialog() = DialogResult.OK Then
                        Dim selectedPrinter As String = PrinterList.PrinterSettings.PrinterName

                        Dim strAccReport As String = "to_print"

                        Try
                            globalAccessApp.Visible = False

                            globalAccessApp.DoCmd.OpenReport(strAccReport, AcView.acViewPreview, Type.Missing, Type.Missing, AcWindowMode.acWindowNormal, Type.Missing)

                            globalAccessApp.Printer = globalAccessApp.Printers.Item(selectedPrinter)

                            globalAccessApp.DoCmd.PrintOut(AcPrintRange.acPrintAll, Type.Missing, Type.Missing, AcPrintQuality.acHigh, Type.Missing, Type.Missing)
                        Catch ex As Exception
                            printBtn.Enabled = True
                            Exit Sub
                        Finally
                            globalAccessApp.DoCmd.Close()
                        End Try

                        Try
                            DB.student_data_conn.Open()
                            For Each row As DataGridViewRow In rows
                                Using cmdUpdate As New OleDbCommand($"UPDATE students SET id_release_count=[id_release_count]+1 WHERE s_number='{row.Cells(0).Value}'", DB.student_data_conn)
                                    cmdUpdate.ExecuteNonQuery()
                                End Using
                            Next
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            DB.student_data_conn.Close()
                        End Try

                        Try
                            DB.student_to_print_conn.Open()
                            Using cmdDelete As New OleDbCommand("DELETE FROM to_print", DB.student_to_print_conn)
                                cmdDelete.ExecuteNonQuery()
                            End Using
                            loadPIPrintQueue()
                            loadPIStudents()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            DB.student_to_print_conn.Close()
                        End Try

                    End If
                End If
            End If
        End If

        printBtn.Enabled = True
    End Sub

    Public Async Sub afterPrint()
        Try
            Await DB.student_to_print_conn.OpenAsync()
            Using cmdDelete As New OleDbCommand("DELETE FROM to_print", DB.student_to_print_conn)
                Await cmdDelete.ExecuteNonQueryAsync()
            End Using

            loadPIPrintQueue()
            loadPIStudents()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DB.student_to_print_conn.Close()
        End Try
    End Sub

    Private Sub pi_refreshBtn_Click(sender As Object, e As EventArgs) Handles pi_refreshBtn.Click
        loadPIStudents()
        MsgBox("Data Refreshed", MsgBoxStyle.OkOnly)
    End Sub

    'UID TAB==================================================================================================================================================
    Public IsUIDHasRun As Boolean = False

    Public Sub UIDClearInput()
        uid_add_course.Clear()
        uid_course.SelectedIndex = 0
    End Sub

    Public Sub loadUIDComboBox()
        Dim adpt_course As New OleDbDataAdapter("SELECT * FROM courses", DB.student_id_details_conn)
        Dim dt_course As New DataTable
        adpt_course.Fill(dt_course)
        uid_course.DataSource = dt_course
        uid_course.DisplayMember = "course_list"
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        If Not IsUIDHasRun Then
            Using adpt As New OleDbDataAdapter("SELECT current_validity FROM validity", DB.student_id_details_conn)
                Using dt As New DataTable
                    adpt.Fill(dt)
                    uid_validity_indicator.Text = $"Current ID Validity: {dt.Rows(0)("current_validity").ToString}"
                End Using
            End Using
            loadUIDComboBox()
            IsUIDHasRun = True
        End If
    End Sub

    Private Sub add_course_Click(sender As Object, e As EventArgs) Handles add_course.Click
        If uid_add_course.Text = Nothing Or uid_add_course.Text = "" Then
            MsgBox("No input detected")
        Else
            Dim isFound As Boolean = False
            For Each courseItem As DataRowView In uid_course.Items
                If courseItem.Item(0).ToString.ToLower = uid_add_course.Text.ToLower Then
                    isFound = True
                End If
            Next
            If isFound Then
                MsgBox("Course already added")
                Exit Sub
            End If

            DB.student_id_details_conn.Open()
            Using cmd As New OleDbCommand($"INSERT INTO courses VALUES('{uid_add_course.Text}')", DB.student_id_details_conn)
                cmd.ExecuteNonQuery()
            End Using
            DB.student_id_details_conn.Close()
            Form1.loadComboBox()
            loadUIDComboBox()
            loadPIComboBox()
            loadUSIComboBox()
            UIDClearInput()
            MsgBox("Added successfully")
        End If
    End Sub

    Private Sub remove_course_Click(sender As Object, e As EventArgs) Handles remove_course.Click
        If uid_course.SelectedIndex = 0 Then
            MsgBox("Select course")
        Else
            DB.student_id_details_conn.Open()
            Using cmd As New OleDbCommand($"DELETE FROM courses WHERE course_list='{uid_course.Text}'", DB.student_id_details_conn)
                cmd.ExecuteNonQuery()
            End Using
            DB.student_id_details_conn.Close()
            Form1.loadComboBox()
            loadUIDComboBox()
            loadPIComboBox()
            loadUSIComboBox()
            UIDClearInput()
            MsgBox("Deleted successfully")
        End If
    End Sub

    Private Sub updateAllBtn_Click(sender As Object, e As EventArgs) Handles updateAllBtn.Click
        If MsgBox("Do you want to update ID validity? This will reset the ID RELEASE COUNT.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim new_sy As New Date(Date.Now.Year, 7, 1)
            Dim curr_year As Integer = Date.Now.Year
            Dim setValidity As String
            If Date.Now < new_sy Then
                setValidity = $"{curr_year - 1}-{(curr_year).ToString.Substring(curr_year.ToString.Length - 2)}"
            Else
                setValidity = $"{curr_year}-{(curr_year + 1).ToString.Substring((curr_year + 1).ToString.Length - 2)}"
            End If

            Try
                DB.student_id_details_conn.Open()
                Using cmd As New OleDbCommand($"UPDATE validity SET current_validity=@s_validity", DB.student_id_details_conn)
                    With cmd
                        .Parameters.AddWithValue("@s_validity", setValidity)
                        .ExecuteNonQuery()
                    End With
                End Using
                DB.student_id_details_conn.Close()

                DB.student_data_conn.Open()
                Using cmd As New OleDbCommand($"UPDATE students SET id_release_count=0", DB.student_data_conn)
                    cmd.ExecuteNonQuery()
                End Using
                DB.student_data_conn.Close()
                id_validity_indicator.Text = $"Current ID Validity: {setValidity}"
                uid_validity_indicator.Text = $"Current ID Validity: {setValidity}"
                UIDClearInput()
                loadPIStudents()
                loadUSIData()
                MsgBox("Updated successfully")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'CLEANUP WORK==================================================================================================================================================
    Private Sub Admin_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.isAdminFormOpen = False
        Admin_Select_Signature_Source.Close()
        Admin_Select_Photo_Source.Close()
        Admin_Signpad_Form.Close()
        Admin_Help.Close()
        CleanupWorker.RunWorkerAsync()
    End Sub

    Private Sub CleanupWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CleanupWorker.DoWork
        Try
            globalAccessApp.CloseCurrentDatabase()
            globalAccessApp.Quit(AcQuitOption.acQuitSaveAll)
        Catch ex As Exception

        Finally
            If globalAccessApp IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(globalAccessApp)
                globalAccessApp = Nothing
            End If
            For Each process In System.Diagnostics.Process.GetProcessesByName("MSACCESS")
                process.Kill()
            Next
            Me.Dispose()
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Admin_Help.Show()
    End Sub
End Class