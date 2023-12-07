Imports System.Data.OleDb
Public Class Change_Questions
    Dim db As New Connection
    Dim selected As String

    Public Sub clearInput()
        Q1.Clear()
        A1.Clear()
        Q2.Clear()
        A2.Clear()
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Q1.KeyPress, A1.KeyPress, Q2.KeyPress, A2.KeyPress
        If Asc(e.KeyChar) = 39 Or Asc(e.KeyChar) = 91 Or Asc(e.KeyChar) = 93 Or Asc(e.KeyChar) = 63 Then
            e.Handled = True
        End If
    End Sub

    Private Sub change_btn_Click(sender As Object, e As EventArgs) Handles change_btn.Click
        If Q1.Text = Nothing Or
            Q1.Text = "" Or
            Q2.Text = Nothing Or
            Q2.Text = "" Or
            A1.Text = Nothing Or
            A1.Text = "" Or
            A2.Text = Nothing Or
            A2.Text = "" Then
            MsgBox("Please complete all input")
        Else
            If MsgBox("Are you sure of these questions?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                db.login_conn.Open()
                Using cmd As New OleDbCommand("UPDATE security_questions SET questions=@q1,answers=@a1 WHERE qid=1", db.login_conn)
                    With cmd
                        .Parameters.AddWithValue("@q1", $"{UCase(Q1.Text)}?")
                        .Parameters.AddWithValue("@a1", A1.Text)
                        .ExecuteNonQuery()
                    End With
                End Using

                Using cmd As New OleDbCommand("UPDATE security_questions SET questions=@q2,answers=@a2 WHERE qid=2", db.login_conn)
                    With cmd
                        .Parameters.AddWithValue("@q2", $"{UCase(Q2.Text)}?")
                        .Parameters.AddWithValue("@a2", A2.Text)
                        .ExecuteNonQuery()
                    End With
                End Using
                db.login_conn.Close()
                MsgBox("Questions and Answers changed")
                clearInput()
            End If
        End If
    End Sub

    Private Sub Change_Questions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Home.Show()
    End Sub
End Class