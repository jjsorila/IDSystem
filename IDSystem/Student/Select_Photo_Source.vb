Public Class Select_Photo_Source

    Private Sub cameraBtn_Click(sender As Object, e As EventArgs) Handles cameraBtn.Click
        Camera_Form.Show()
    End Sub

    Private Sub fileBtn_Click(sender As Object, e As EventArgs) Handles fileBtn.Click
        Using chosenFile As New OpenFileDialog
            chosenFile.Filter = "Image Files |*.jpg;*.jpeg;*.png"
            chosenFile.InitialDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Pictures"
            If chosenFile.ShowDialog = DialogResult.OK Then
                Form1.isIdUploaded = 1
                Using fs As New IO.FileStream(chosenFile.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    Form1.id_picture.Image = Image.FromStream(fs)
                End Using
                Me.Close()
            End If
        End Using
    End Sub

    Private Sub Select_Photo_Source_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class