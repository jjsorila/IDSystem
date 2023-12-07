Imports System.Data.OleDb
Public Class Security_Questions
    Dim db As New Connection
    Dim isWrong As Boolean = False

    Private Sub Security_Questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using adpt As New OleDbDataAdapter("SELECT questions FROM security_questions", db.login_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                Q1.Text = dt.Rows(0)("questions").ToString
                Q2.Text = dt.Rows(1)("questions").ToString
            End Using
        End Using
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles A1.KeyPress, A2.KeyPress
        If Asc(e.KeyChar) = 39 Or Asc(e.KeyChar) = 91 Or Asc(e.KeyChar) = 93 Then
            e.Handled = True
        End If
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        isWrong = False
        Using adpt As New OleDbDataAdapter("SELECT answers FROM security_questions", db.login_conn)
            Using dt As New DataTable
                adpt.Fill(dt)

                If Not UCase(A1.Text).Replace(" ", "") = UCase(dt.Rows(0)("answers").ToString).Replace(" ", "") Or Not UCase(A2.Text).Replace(" ", "") = UCase(dt.Rows(1)("answers").ToString).Replace(" ", "") Then
                    isWrong = True
                End If
            End Using
        End Using
        If isWrong Then
            MsgBox("One of your answers is not correct")
        Else
            Me.Hide()
            Change_Password.Show()
        End If
    End Sub

    Private Sub Security_Questions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Login.Show()
    End Sub
End Class