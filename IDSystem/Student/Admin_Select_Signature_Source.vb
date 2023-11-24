Public Class Admin_Select_Signature_Source

    Private Sub cameraBtn_Click(sender As Object, e As EventArgs) Handles cameraBtn.Click
        Me.Close()
        Admin_Signpad_Form.Show()
    End Sub

    Private Sub fileBtn_Click(sender As Object, e As EventArgs) Handles fileBtn.Click
        Using chosenFile As New OpenFileDialog
            chosenFile.Filter = "Signature Files |*.jpg;*.jpeg;*.png"
            chosenFile.InitialDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Pictures"
            If chosenFile.ShowDialog = DialogResult.OK Then
                Admin_Form.isSignatureUploaded = 1
                Using fs As New IO.FileStream(chosenFile.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    Admin_Form.usi_id_signature.Image = Image.FromStream(fs)
                End Using
                Me.Close()
            End If
        End Using
    End Sub

    Private Sub Select_Photo_Source_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class