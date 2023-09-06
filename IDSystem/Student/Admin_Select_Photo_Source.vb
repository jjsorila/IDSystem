Public Class Admin_Select_Photo_Source
    Private Sub Admin_Select_Photo_Source_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub fileBtn_Click(sender As Object, e As EventArgs) Handles fileBtn.Click
        Using chosenFile As New OpenFileDialog
            chosenFile.Filter = "Image Files |*.jpg;*.jpeg;*.png"
            chosenFile.InitialDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Pictures"
            If chosenFile.ShowDialog = DialogResult.OK Then
                Admin_Form.isIdUploaded = 1
                Using fs As New IO.FileStream(chosenFile.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    Admin_Form.usi_id_picture.Image = Image.FromStream(fs)
                End Using
                Me.Close()
            End If
        End Using
    End Sub

    Private Sub cameraBtn_Click(sender As Object, e As EventArgs) Handles cameraBtn.Click
        Admin_Camera_Form.Show()
    End Sub
End Class