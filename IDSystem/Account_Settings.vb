Imports System.Data.OleDb
Public Class Account_Settings
    Dim db As New Connection
    Dim selected As String

    Public Sub loadAccounts()
        Using adpt As New OleDbDataAdapter($"SELECT usr AS USERNAMES FROM accounts", db.login_conn)
            Using dt As New DataTable
                adpt.Fill(dt)
                accounts_table.DefaultCellStyle.ForeColor = Color.Black
                accounts_table.DataSource = dt
            End Using
        End Using
    End Sub

    Public Sub clearInput()
        newpassword.Clear()
        password.Clear()
        username.Clear()
        selected = Nothing
        usrname_label.Text = ""
    End Sub

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Show()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress, password.KeyPress, newpassword.KeyPress
        If Asc(e.KeyChar) = 39 Or Asc(e.KeyChar) = 91 Or Asc(e.KeyChar) = 93 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Account_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAccounts()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        delete_btn.Enabled = False
        If selected = Nothing Then
            MsgBox("Please select an account")
        ElseIf selected = "admin" Then
            MsgBox("You can't delete the admin account")
        Else
            If MsgBox("Do you want to delete this account?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    db.login_conn.Open()
                    Using cmd As New OleDbCommand("DELETE FROM accounts WHERE usr=@username", db.login_conn)
                        With cmd
                            .Parameters.AddWithValue("@username", selected)
                            .ExecuteNonQuery()
                        End With
                    End Using
                    db.login_conn.Close()
                    loadAccounts()
                    clearInput()
                    MsgBox("Account deleted")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    db.login_conn.Close()
                End Try
            End If
        End If
        delete_btn.Enabled = True
    End Sub

    Private Sub change_btn_Click(sender As Object, e As EventArgs) Handles change_btn.Click
        change_btn.Enabled = False
        If selected = Nothing Then
            MsgBox("Please select an account")
        ElseIf newpassword.Text = Nothing Or newpassword.Text = "" Then
            MsgBox("Please set a new password")
        Else
            If MsgBox("Do you want to update this account's password?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Using adpt As New OleDbDataAdapter($"SELECT * FROM accounts WHERE usr='{selected}' AND pwd='{newpassword.Text}'", db.login_conn)
                    Using dt As New DataTable
                        adpt.Fill(dt)
                        If dt.Rows.Count >= 1 Then
                            MsgBox("You have entered your old password")
                        Else
                            Try
                                db.login_conn.Open()
                                Using cmd As New OleDbCommand("UPDATE accounts SET pwd=@password WHERE usr=@username", db.login_conn)
                                    With cmd
                                        .Parameters.AddWithValue("@password", newpassword.Text)
                                        .Parameters.AddWithValue("@username", selected)
                                        .ExecuteNonQuery()
                                    End With
                                End Using
                                db.login_conn.Close()
                                loadAccounts()
                                clearInput()
                                MsgBox("Password updated")
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            Finally
                                db.login_conn.Close()
                            End Try
                        End If
                    End Using
                End Using
            End If
        End If
        change_btn.Enabled = True
    End Sub

    Private Sub accounts_table_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles accounts_table.CellClick
        Dim row As DataGridViewRow = accounts_table.CurrentRow
        selected = row.Cells("USERNAMES").Value.ToString
        usrname_label.Text = row.Cells("USERNAMES").Value.ToString
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        add_btn.Enabled = False
        If username.Text = "" Or username.Text = Nothing Or
            password.Text = "" Or password.Text = Nothing Then
            MsgBox("Please complete required inputs")
        Else
            Using adpt As New OleDbDataAdapter($"SELECT * FROM accounts WHERE usr='{username.Text}'", db.login_conn)
                Using dt As New DataTable
                    adpt.Fill(dt)
                    If dt.Rows.Count >= 1 Then
                        MsgBox("Username already exist")
                    Else
                        Try
                            db.login_conn.Open()
                            Using cmd As New OleDbCommand("INSERT INTO accounts VALUES(@username,@password)", db.login_conn)
                                With cmd
                                    .Parameters.AddWithValue("@username", username.Text)
                                    .Parameters.AddWithValue("@password", password.Text)
                                    .ExecuteNonQuery()
                                End With
                            End Using
                            db.login_conn.Close()
                            loadAccounts()
                            clearInput()
                            MsgBox("Account registered")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            db.login_conn.Close()
                        End Try
                    End If
                End Using
            End Using
        End If
        add_btn.Enabled = True
    End Sub
End Class