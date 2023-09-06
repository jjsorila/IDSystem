Imports System.Data.OleDb
Public Class Change_PIN
    Dim DB As New Connection

    Public Sub clearInput()
        newPin.Clear()
        confirmPin.Clear()
    End Sub
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If confirmPin.Text = Nothing Or confirmPin.Text = "" Or newPin.Text = Nothing Or newPin.Text = "" Then
            MsgBox("Complete all inputs")
        Else
            If confirmPin.Text <> newPin.Text Then
                MsgBox("PIN not matched")
            Else
                Dim check_adpt As New OleDbDataAdapter($"SELECT * FROM Credentials WHERE pin='{confirmPin.Text}'", DB.login_conn)
                Dim check_dt As New DataTable
                check_adpt.Fill(check_dt)
                If check_dt.Rows.Count >= 1 Then
                    MsgBox("You have entered your old password")
                Else
                    DB.login_conn.Open()
                    Using cmd As New OleDbCommand($"UPDATE Credentials SET pin='{confirmPin.Text}'", DB.login_conn)
                        cmd.ExecuteNonQuery()
                    End Using
                    DB.login_conn.Close()
                    clearInput()
                    MsgBox("PIN Updated")
                End If
            End If
        End If
    End Sub

    Private Sub Change_PIN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clearInput()
        Me.Dispose()
    End Sub
End Class