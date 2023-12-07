Public Class Home
    Public db As New Connection
    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Do you want to exit the application?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                For Each process In System.Diagnostics.Process.GetProcessesByName("MSACCESS")
                    process.Kill()
                Next
            Catch ex As Exception

            Finally
                Me.Dispose()
                End
            End Try
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub student_btn_Click(sender As Object, e As EventArgs) Handles student_btn.Click
        student_btn.Enabled = False
        Me.Hide()
        Form1.Show()
        student_btn.Enabled = True
    End Sub

    Private Sub prof_btn_Click(sender As Object, e As EventArgs) Handles prof_btn.Click
        prof_btn.Enabled = False
        If Login.isAdmin Then
            Me.Hide()
            Prof_Form.Show()
        Else
            MsgBox("You must logged in as admin")
        End If
        prof_btn.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MsgBox("Do you want to log out your account?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Account_Settings.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Change_Questions.Show()
        Me.Hide()
    End Sub
End Class