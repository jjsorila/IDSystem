Imports System.Data.OleDb
Public Class Change_Password
    Dim db As New Connection

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If Asc(e.KeyChar) = 39 Or Asc(e.KeyChar) = 91 Or Asc(e.KeyChar) = 93 Then
            e.Handled = True
        End If
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Using adpt As New OleDbDataAdapter($"SELECT pwd FROM accounts WHERE pwd='{password.Text}'", db.login_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                If dt.Rows.Count >= 1 Then
                    MsgBox("You have entered your old password")
                Else
                    If MsgBox("Are you sure to this password?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        db.login_conn.Open()
                        Using cmd As New OleDbCommand("UPDATE accounts SET pwd=@pwd WHERE usr='admin'", db.login_conn)
                            With cmd
                                .Parameters.AddWithValue("@pwd", password.Text)
                                .ExecuteNonQuery()
                            End With
                        End Using
                        db.login_conn.Close()
                        MsgBox("Admin password changed")
                        Me.Close()
                    End If
                End If
            End Using
        End Using
    End Sub

    Private Sub Change_Password_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Security_Questions.Close()
    End Sub
End Class