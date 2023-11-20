Public Class Prof_Help
    Dim runonce As Boolean = False

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        If Not runonce Then
            AxWindowsMediaPlayer1.URL = $"{Application.StartupPath}\modify_template_prof.mp4"
            runonce = True
        End If
    End Sub
End Class