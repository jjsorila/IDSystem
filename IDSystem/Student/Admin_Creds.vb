Imports System.Data.OleDb
Public Class Admin_Creds
    Dim DB As New Connection
    Public toProfIdForm As Boolean = False

    Public Sub clearInput()
        pinTxt.Clear()
    End Sub
    Private Sub Admin_Creds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearInput()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        loginBtn.Enabled = False
        Using adpt As New OleDbDataAdapter($"SELECT * FROM Credentials WHERE pin='{pinTxt.Text}'", DB.login_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                If (dt.Rows.Count >= 1) Then
                    Me.Close()
                    If toProfIdForm Then
                        Prof_Form.Show()
                        Home.Hide()
                    Else
                        Form1.isAdminFormOpen = True
                        Admin_Form.Show()
                    End If
                Else
                    MsgBox("Incorrect PIN")
                End If
            End Using
        End Using
        loginBtn.Enabled = True
    End Sub

    Private Sub Admin_Creds_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        clearInput()
    End Sub
End Class