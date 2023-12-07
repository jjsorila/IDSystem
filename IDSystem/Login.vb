Imports System.Data.OleDb
Public Class Login
    Dim db As New Connection
    Public isAdmin As Boolean = False

    Public Sub clearInput()
        username.Clear()
        password.Clear()
    End Sub

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

    Private Sub prof_btn_Click(sender As Object, e As EventArgs) Handles prof_btn.Click
        Using adpt As New OleDbDataAdapter($"SELECT * FROM accounts WHERE usr='{username.Text}' AND pwd='{password.Text}'", db.login_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                If dt.Rows.Count >= 1 Then
                    If username.Text = "admin" Then
                        isAdmin = True
                    Else
                        isAdmin = False
                    End If
                    Home.ToolStripMenuItem1.Visible = isAdmin
                    Home.ToolStripMenuItem3.Visible = isAdmin
                    Me.Hide()
                    clearInput()
                    Home.Show()
                Else
                    MsgBox("Invalid credentials")
                End If
            End Using
        End Using
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress, password.KeyPress
        If Asc(e.KeyChar) = 39 Or Asc(e.KeyChar) = 91 Or Asc(e.KeyChar) = 93 Then
            e.Handled = True
        End If
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Security_Questions.Show()
        Me.Hide()
    End Sub
End Class