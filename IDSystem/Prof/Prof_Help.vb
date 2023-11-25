Public Class Prof_Help
    Dim runonce As Boolean = False

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        If Not runonce Then
            AxWindowsMediaPlayer1.URL = $"{Application.StartupPath}\modify_template.mp4"
            AxWindowsMediaPlayer1.Ctlenabled = True
            runonce = True
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub TabPage3_Leave(sender As Object, e As EventArgs) Handles TabPage3.Leave
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Prof_Help_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class