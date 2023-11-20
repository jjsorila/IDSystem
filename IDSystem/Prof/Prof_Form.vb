Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop.Access
Public Class Prof_Form
    Dim DB As New Connection
    Public isSignatureUploaded As Integer = 0
    Public isIdUploaded As Integer = 0
    Public hidden_employee_number As String = Nothing
    Public isUSIHasRun As Boolean = False

    'USI TAB=======================================================================================================================================================
    Public Sub loadUSIData(Optional query As String = "SELECT Full_Name FROM employee_search ORDER BY Full_Name ASC")
        dgv_usi.DefaultCellStyle.ForeColor = Color.Black

        Using adpt As New OleDbDataAdapter(query, DB.prof_conn)
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
        employee_number.Clear()
        studentSearchUSI.Clear()
        address.Clear()
        hidden_employee_number = Nothing
        sss_no.Clear()
        tin_no.Clear()
        position.Clear()
        insertBtn.Enabled = True
        updateBtn.Enabled = False
        employee_number.Enabled = True
    End Sub

    Public Sub ResizeSaveSignature(img As Drawing.Image, filename As String)
        'bitmap for result
        Using imgResult As New Bitmap(308, 107)
            'Graphics object for result
            Using grResult As Graphics = Graphics.FromImage(imgResult)
                ''source to result bitmap
                grResult.DrawImage(img, 0, 0, imgResult.Width, imgResult.Height)
                ''save result
                imgResult.Save($"{Windows.Forms.Application.StartupPath}\prof_signatures\{filename}")
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
                imgResult.Save($"{Windows.Forms.Application.StartupPath}\prof_pictures\{filename}")
            End Using
        End Using
    End Sub
    Private Sub Prof_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Prof_Help.Close()
        Prof_Select_Photo_Source.Close()
        Prof_Signpad_Form.Close()
        ProfCleanupWorker.RunWorkerAsync()
        Home.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Change_PIN.Show()
    End Sub

    Private Sub mi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mi.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub e_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e_number.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub employee_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles employee_number.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub sss_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sss_no.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tin_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tin_no.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub usi_id_signature_Click(sender As Object, e As EventArgs) Handles usi_id_signature.Click
        Prof_Signpad_Form.Show()
    End Sub

    Private Sub usi_id_picture_Click(sender As Object, e As EventArgs) Handles usi_id_picture.Click
        Prof_Select_Photo_Source.Show()
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        If Not isUSIHasRun Then
            loadUSIData()
            isUSIHasRun = True
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        If MsgBox("Do you want to clear all inputs?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clearUSIInput()
        End If
    End Sub

    Private Sub Prof_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If hidden_employee_number = Nothing Then
            updateBtn.Enabled = False
        End If
    End Sub

    Private Sub dgv_usi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usi.CellClick
        Dim row As DataGridViewRow = dgv_usi.CurrentRow

        Using adpt As New OleDbDataAdapter($"SELECT employee_number FROM employee_search WHERE Full_Name='{row.Cells("Full_Name").Value.ToString}'", DB.prof_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                hidden_employee_number = dt.Rows(0)("employee_number").ToString
                updateBtn.Enabled = True
                insertBtn.Enabled = False
                employee_number.Enabled = False
            End Using
        End Using

        Using adpt As New OleDbDataAdapter($"SELECT * FROM prof_data WHERE employee_number='{hidden_employee_number}'", DB.prof_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                Dim currentRow As DataRow = dt.Rows(0)
                employee_number.Text = currentRow("employee_number").ToString
                fname.Text = currentRow("fname").ToString
                mi.Text = currentRow("mi").ToString
                lname.Text = currentRow("lname").ToString
                address.Text = currentRow("address").ToString
                e_number.Text = currentRow("e_number").ToString
                e_person.Text = currentRow("e_person").ToString
                position.Text = currentRow("work_position").ToString
                sss_no.Text = currentRow("sss").ToString
                tin_no.Text = currentRow("tin").ToString
                Using fsID As New IO.FileStream($"{Windows.Forms.Application.StartupPath}\prof_pictures\{currentRow("picture").ToString}", IO.FileMode.Open, IO.FileAccess.Read)
                    usi_id_picture.Image = System.Drawing.Image.FromStream(fsID)
                    isIdUploaded = 1
                End Using
                Using fsSign As New IO.FileStream($"{Windows.Forms.Application.StartupPath}\prof_signatures\{currentRow("signature").ToString}", IO.FileMode.Open, IO.FileAccess.Read)
                    usi_id_signature.Image = System.Drawing.Image.FromStream(fsSign)
                    isSignatureUploaded = 1
                End Using
            End Using
        End Using
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If hidden_employee_number = Nothing Then
            MsgBox("Please select an employee")
        Else
            If fname.Text = Nothing Or
               lname.Text = Nothing Or
               address.Text = Nothing Or
               e_number.Text = Nothing Or
               e_person.Text = Nothing Or
               sss_no.Text = Nothing Or
               tin_no.Text = Nothing Or
               isIdUploaded = 0 Or
               isSignatureUploaded = 0 Or
               position.Text = Nothing Then
                MsgBox("Please complete all inputs", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Are these inputs correct?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim modifiedMi As String = ""
                    If Not mi.Text = Nothing Or Not mi.Text = "" Then
                        If InStr(mi.Text, ".") = 0 Then
                            modifiedMi = $"{mi.Text}."
                        Else
                            modifiedMi = mi.Text
                        End If
                    End If
                    Dim pic_name As String = $"{employee_number.Text}.jpg"
                    Dim sign_name As String = $"{employee_number.Text}.png"
                    DB.prof_conn.Open()
                    Using cmd As New OleDbCommand("UPDATE prof_data SET picture=@pic,signature=@sign,fname=@fn,mi=@mi,lname=@ln,address=@addr,e_person=@ep,e_number=@enum,sss=@sssnumber,tin=@tinnumber,work_position=@pos WHERE employee_number=@en", DB.prof_conn)
                        With cmd
                            .Parameters.AddWithValue("@pic", pic_name)
                            .Parameters.AddWithValue("@sign", sign_name)
                            .Parameters.AddWithValue("@fn", StrConv(fname.Text, 3))
                            .Parameters.AddWithValue("@mi", modifiedMi)
                            .Parameters.AddWithValue("@ln", StrConv(lname.Text, 3))
                            .Parameters.AddWithValue("@addr", address.Text)
                            .Parameters.AddWithValue("@ep", e_person.Text)
                            .Parameters.AddWithValue("@enum", e_number.Text)
                            .Parameters.AddWithValue("@sssnumber", sss_no.Text)
                            .Parameters.AddWithValue("@tinnumber", tin_no.Text)
                            .Parameters.AddWithValue("@pos", position.Text)
                            .Parameters.AddWithValue("@en", hidden_employee_number)
                            .ExecuteNonQuery()
                        End With
                    End Using
                    DB.prof_conn.Close()
                    ResizeSaveIDPicture(usi_id_picture.Image, pic_name)
                    ResizeSaveSignature(usi_id_signature.Image, sign_name)
                    clearUSIInput()
                    loadUSIData()
                    loadPIStudents()
                    MsgBox("Record updated", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        If fname.Text = Nothing Or
                lname.Text = Nothing Or
                address.Text = Nothing Or
                e_number.Text = Nothing Or
                employee_number.Text = Nothing Or
                e_person.Text = Nothing Or
                sss_no.Text = Nothing Or
                tin_no.Text = Nothing Or
                isIdUploaded = 0 Or
                isSignatureUploaded = 0 Or
                position.Text = Nothing Then
            MsgBox("Please complete all inputs", MsgBoxStyle.OkOnly)
        Else
            Using adpt As New OleDbDataAdapter($"SELECT employee_number FROM prof_data WHERE employee_number='{employee_number.Text}'", DB.prof_conn)
                Using dt As New DataTable
                    adpt.Fill(dt)
                    If dt.Rows.Count >= 1 Then
                        MsgBox("Employee number already exists")
                        Exit Sub
                    End If
                End Using
            End Using

            If MsgBox("Are these inputs correct?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim modifiedMi As String = ""
                If Not mi.Text = Nothing Or Not mi.Text = "" Then
                    If InStr(mi.Text, ".") = 0 Then
                        modifiedMi = $"{mi.Text}."
                    Else
                        modifiedMi = mi.Text
                    End If
                End If
                Dim pic_name As String = $"{employee_number.Text}.jpg"
                Dim sign_name As String = $"{employee_number.Text}.png"
                DB.prof_conn.Open()
                Using cmd As New OleDbCommand("INSERT INTO prof_data([employee_number],[picture],[signature],[fname],[mi],[lname],[address],[e_person],[e_number],[sss],[tin],[work_position]) VALUES(@en,@pic,@sign,@fn,@mi,@ln,@addr,@ep,@enum,@sss,@tin,@position)", DB.prof_conn)
                    With cmd
                        .Parameters.AddWithValue("@en", employee_number.Text)
                        .Parameters.AddWithValue("@pic", pic_name)
                        .Parameters.AddWithValue("@sign", sign_name)
                        .Parameters.AddWithValue("@fn", StrConv(fname.Text, 3))
                        .Parameters.AddWithValue("@mi", modifiedMi)
                        .Parameters.AddWithValue("@ln", StrConv(lname.Text, 3))
                        .Parameters.AddWithValue("@addr", address.Text)
                        .Parameters.AddWithValue("@ep", e_person.Text)
                        .Parameters.AddWithValue("@enum", e_number.Text)
                        .Parameters.AddWithValue("@sss", sss_no.Text)
                        .Parameters.AddWithValue("@tin", tin_no.Text)
                        .Parameters.AddWithValue("@position", position.Text)
                        .ExecuteNonQuery()
                    End With
                End Using
                DB.prof_conn.Close()
                ResizeSaveIDPicture(usi_id_picture.Image, pic_name)
                ResizeSaveSignature(usi_id_signature.Image, sign_name)
                clearUSIInput()
                loadUSIData()
                loadPIStudents()
                MsgBox("Record added", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If hidden_employee_number = Nothing Then
            MsgBox("Please select an employee")
        Else
            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DB.prof_conn.Open()
                Using cmd As New OleDbCommand("DELETE FROM prof_data WHERE employee_number=@em", DB.prof_conn)
                    With cmd
                        .Parameters.AddWithValue("@em", hidden_employee_number)
                        .ExecuteNonQuery()
                    End With
                End Using
                DB.prof_conn.Close()
                My.Computer.FileSystem.DeleteFile($"{Windows.Forms.Application.StartupPath}\prof_pictures\{hidden_employee_number}.jpg")
                My.Computer.FileSystem.DeleteFile($"{Windows.Forms.Application.StartupPath}\prof_signatures\{hidden_employee_number}.png")
                clearUSIInput()
                loadUSIData()
                loadPIStudents()
            End If
        End If
    End Sub

    'PRINT ID TAB==========================================================================================================================================================================
    Public isPIHasRun As Boolean = False
    Public piSelect As String = Nothing
    Dim globalAccessApp As New Microsoft.Office.Interop.Access.Application()

    Public Sub loadPIPrintQueue()
        pi_tp_dgv.DefaultCellStyle.ForeColor = Color.Black
        Using adpt As New OleDbDataAdapter("SELECT employee_number AS Employee_No,lname & ', ' & fname & ' ' & mi AS Full_Name FROM to_print", DB.prof_to_print_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                pi_tp_dgv.DataSource = dt
            End Using
        End Using
    End Sub

    Public Sub loadPIStudents(Optional query As String = "SELECT TOP 20 Full_Name FROM employee_search ORDER BY Full_Name ASC")
        pi_dgv.DefaultCellStyle.ForeColor = Color.Black

        Using adpt As New OleDbDataAdapter(query, DB.prof_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                pi_dgv.DataSource = dt
                pi_dgv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                'pi_dgv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End Using
        End Using

    End Sub

    Public Sub clearPIInput()
        pi_student_search.Clear()
    End Sub

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

    Private Sub ProfCleanupWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ProfCleanupWorker.DoWork
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
            Me.Close()
        End Try
    End Sub

    Private Sub modifyBtn_Click(sender As Object, e As EventArgs) Handles modifyBtn.Click
        Try
            globalAccessApp.OpenCurrentDatabase($"{Windows.Forms.Application.StartupPath}\Prof_To_Print.accdb", False, "")
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
            globalAccessApp.OpenCurrentDatabase($"{Windows.Forms.Application.StartupPath}\Prof_To_Print.accdb", False, "")
        Catch ex As Exception

        End Try
        Dim strAccReport As String = "to_print"
        globalAccessApp.DoCmd.OpenReport(strAccReport, AcView.acViewPreview, Type.Missing, Type.Missing, AcWindowMode.acWindowNormal, Type.Missing)
        globalAccessApp.Visible = True
    End Sub

    Private Sub removeAllBtn_Click(sender As Object, e As EventArgs) Handles removeAllBtn.Click
        If IsAccessRunning() Then
            MsgBox("Please close all opened MS ACCESS app")
            Exit Sub
        End If

        Dim rows As DataGridViewRowCollection = pi_tp_dgv.Rows
        If rows.Count >= 1 Then
            If MsgBox("Do you want to clear out print queue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DB.prof_to_print_conn.Open()
                Using cmd As New OleDbCommand("DELETE FROM to_print", DB.prof_to_print_conn)
                    cmd.ExecuteNonQuery()
                End Using
                DB.prof_to_print_conn.Close()
                loadPIPrintQueue()
            End If
        Else
            MsgBox("No queue to clear")
        End If
    End Sub

    Private Sub removeSelectedBtn_Click(sender As Object, e As EventArgs) Handles removeSelectedBtn.Click
        If IsAccessRunning() Then
            MsgBox("Please close all opened MS ACCESS app")
            Exit Sub
        End If

        Dim rows As DataGridViewSelectedRowCollection = pi_tp_dgv.SelectedRows

        If rows.Count >= 1 Then
            If MsgBox("Do you want to remove this/these from print queue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                DB.prof_to_print_conn.Open()
                Dim cmd As New OleDbCommand
                For Each row As DataGridViewRow In rows
                    cmd.CommandText = $"DELETE FROM to_print WHERE employee_number='{row.Cells("Employee_No").Value.ToString}'"
                    cmd.Connection = DB.prof_to_print_conn
                    cmd.ExecuteNonQuery()
                Next
                cmd.Dispose()
                DB.prof_to_print_conn.Close()
                loadPIPrintQueue()
            End If
        Else
            MsgBox("Select a queue")
        End If
    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        If Not isPIHasRun Then
            loadPIPrintQueue()
            loadPIStudents()
            isPIHasRun = True
        End If
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
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
                        globalAccessApp.OpenCurrentDatabase($"{Windows.Forms.Application.StartupPath}\Prof_To_Print.accdb", False, "")
                    Catch ex As Exception

                    End Try

                    If ProfPrinterList.ShowDialog() = DialogResult.OK Then
                        Dim selectedPrinter As String = ProfPrinterList.PrinterSettings.PrinterName

                        Dim strAccReport As String = "to_print"

                        globalAccessApp.Visible = False

                        globalAccessApp.DoCmd.OpenReport(strAccReport, AcView.acViewPreview, Type.Missing, Type.Missing, AcWindowMode.acWindowNormal, Type.Missing)

                        globalAccessApp.Printer = globalAccessApp.Printers.Item(selectedPrinter)

                        globalAccessApp.DoCmd.PrintOut(AcPrintRange.acPrintAll, Type.Missing, Type.Missing, AcPrintQuality.acHigh, Type.Missing, Type.Missing)

                        'DB.student_data_conn.Open()
                        'For Each row As DataGridViewRow In rows
                        '    Using cmdUpdate As New OleDbCommand($"UPDATE students SET id_release_count=[id_release_count]+1 WHERE s_number='{row.Cells("Student_Number").Value}'", DB.student_data_conn)
                        '        cmdUpdate.ExecuteNonQuery()
                        '    End Using
                        'Next
                        'DB.student_data_conn.Close()

                        afterPrint()
                    End If
                End If
            End If
        End If

        printBtn.Enabled = True
    End Sub

    Public Async Sub afterPrint()
        Try
            Await DB.prof_to_print_conn.OpenAsync()
            Using cmdDelete As New OleDbCommand("DELETE FROM to_print", DB.prof_to_print_conn)
                Await cmdDelete.ExecuteNonQueryAsync()
            End Using

            loadPIPrintQueue()
            loadPIStudents()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DB.prof_to_print_conn.Close()
            MsgBox("Print started")
        End Try
    End Sub

    Private Sub pi_student_search_TextChanged(sender As Object, e As EventArgs) Handles pi_student_search.TextChanged
        If Not pi_student_search.Text = Nothing Or Not pi_student_search.Text = "" Then
            loadPIStudents($"SELECT TOP 20 Full_Name FROM employee_search WHERE Full_Name LIKE '%{pi_student_search.Text}%' ORDER BY Full_Name ASC")
        End If
    End Sub

    Private Sub pi_refreshBtn_Click(sender As Object, e As EventArgs) Handles pi_refreshBtn.Click
        loadPIStudents()
        clearPIInput()
        MsgBox("Data Refreshed", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub pi_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pi_dgv.CellClick
        piSelect = pi_dgv.CurrentRow.Cells("Full_Name").Value.ToString
    End Sub

    Private Sub addToPrintQueueBtn_Click(sender As Object, e As EventArgs) Handles addToPrintQueueBtn.Click
        If IsAccessRunning() Then
            MsgBox("Please close all opened MS ACCESS app")
            Exit Sub
        End If

        If pi_tp_dgv.Rows.Count >= 8 Then
            MsgBox("Print queue is full", MsgBoxStyle.OkOnly)
        Else
            If piSelect = Nothing Then
                MsgBox("Please select a student")
            Else
                'CHECK IF IT WAS ALREADY IN THE PRINT QUEUE
                Dim rows As DataGridViewRowCollection = pi_tp_dgv.Rows
                Dim isFound As Boolean = False
                For Each row As DataGridViewRow In rows
                    If UCase(row.Cells("Full_Name").Value.ToString) = UCase(piSelect) Then
                        isFound = True
                    End If
                Next

                If isFound Then
                    MsgBox("Record already on print queue")
                Else
                    Dim pi_record_numer As String

                    'GET RECORD NUMBER
                    Using adpt As New OleDbDataAdapter($"SELECT employee_number FROM employee_search WHERE Full_Name='{piSelect}'", DB.prof_conn)
                        Using dt As New DataTable
                            adpt.Fill(dt)
                            pi_record_numer = dt.Rows(0)(0).ToString()
                        End Using
                    End Using

                    'GET ID DETAILS
                    Dim employee_number_holder, fname, lname, mi, address, e_number, e_person, sss, tin, position, idPicture, idSignature As String
                    Using adpt As New OleDbDataAdapter($"SELECT * FROM prof_data WHERE employee_number='{pi_record_numer}'", DB.prof_conn)
                        Using dt As New DataTable
                            adpt.Fill(dt)
                            Dim currentRow As DataRow = dt.Rows(0)
                            employee_number_holder = currentRow("employee_number")
                            fname = currentRow("fname")
                            mi = currentRow("mi")
                            lname = currentRow("lname")
                            address = currentRow("address")
                            e_number = currentRow("e_number")
                            e_person = currentRow("e_person")
                            sss = currentRow("sss")
                            tin = currentRow("tin")
                            position = currentRow("work_position")
                            idPicture = $"{Windows.Forms.Application.StartupPath}\prof_pictures\{currentRow("picture")}"
                            idSignature = $"{Windows.Forms.Application.StartupPath}\prof_signatures\{currentRow("signature")}"
                        End Using
                    End Using

                    'INSERT TO PRINT QUEUE DB
                    DB.prof_to_print_conn.Open()
                    Using cmd As New OleDbCommand("INSERT INTO to_print VALUES(@emplo,@picture,@signature,@fname,@mi,@lname,@address,@e_number,@e_person,@wp,@sss,@tin)", DB.prof_to_print_conn)
                        With cmd
                            .Parameters.AddWithValue("@emplo", employee_number_holder)
                            .Parameters.AddWithValue("@picture", idPicture)
                            .Parameters.AddWithValue("@signature", idSignature)
                            .Parameters.AddWithValue("@fname", fname)
                            .Parameters.AddWithValue("@mi", mi)
                            .Parameters.AddWithValue("@lname", lname)
                            .Parameters.AddWithValue("@address", address)
                            .Parameters.AddWithValue("@e_number", e_number)
                            .Parameters.AddWithValue("@e_person", e_person)
                            .Parameters.AddWithValue("@wp", position)
                            .Parameters.AddWithValue("@sss", sss)
                            .Parameters.AddWithValue("@tin", tin)
                            .ExecuteNonQuery()
                        End With
                    End Using
                    DB.prof_to_print_conn.Close()
                    loadPIPrintQueue()
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Prof_Help.Show()
    End Sub
End Class