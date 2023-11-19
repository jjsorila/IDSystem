Public Class Home
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
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub prof_btn_Click(sender As Object, e As EventArgs) Handles prof_btn.Click
        Admin_Creds.toProfIdForm = True
        Admin_Creds.Show()
    End Sub
End Class