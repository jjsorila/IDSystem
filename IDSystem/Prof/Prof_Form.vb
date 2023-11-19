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
                    'loadPIStudents()
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
                'loadPIStudents()
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
            End If
        End If
    End Sub

    'PRINT ID TAB==========================================================================================================================================================================
    Public isPIHasRun As Boolean = False
    Public piSelect As String = Nothing
    Dim globalAccessApp As New Microsoft.Office.Interop.Access.Application()

    Private Sub ProfCleanupWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ProfCleanupWorker.DoWork
        Try
            'globalAccessApp.CloseCurrentDatabase()
            'globalAccessApp.Quit(AcQuitOption.acQuitSaveAll)
        Catch ex As Exception

        Finally
            'If globalAccessApp IsNot Nothing Then
            '    System.Runtime.InteropServices.Marshal.ReleaseComObject(globalAccessApp)
            '    globalAccessApp = Nothing
            'End If
            For Each process In System.Diagnostics.Process.GetProcessesByName("MSACCESS")
                process.Kill()
            Next
            Me.Dispose()
            Me.Close()
        End Try
    End Sub
End Class