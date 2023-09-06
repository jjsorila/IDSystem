Public Class Admin_Signpad_Form
    Dim draw As Boolean
    Dim drawcolor As Color = Color.Black
    Dim drawize As Integer = 4
    Dim bmp As Bitmap

    Private Sub Paintbrush(X As Integer, Y As Integer)
        Using g As Graphics = Graphics.FromImage(signpad.Image)
            g.FillRectangle(New SolidBrush(drawcolor), New Rectangle(X, Y, drawize, drawize))
        End Using
        signpad.Refresh()
    End Sub
    Private Sub Admin_Signpad_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub doneBtn_Click(sender As Object, e As EventArgs) Handles doneBtn.Click
        Me.Close()
    End Sub

    Private Sub signpad_Click(sender As Object, e As EventArgs) Handles signpad.Click
        Admin_Form.usi_id_signature.Image = signpad.Image
        Admin_Form.isSignatureUploaded = 1
        If Admin_Form.usi_id_signature.Image Is My.Resources.id_signature_placeholder Then
            Admin_Form.usi_id_signature.Refresh()
        Else
            Admin_Form.usi_id_signature.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        bmp = New Bitmap(signpad.Width, signpad.Height)
        Admin_Form.isSignatureUploaded = 0
        signpad.Image = bmp
        Admin_Form.usi_id_signature.Image = signpad.Image
        Admin_Form.usi_id_signature.Invalidate()
        Admin_Form.usi_id_signature.Image = My.Resources.id_signature_placeholder
        Admin_Form.usi_id_signature.Refresh()
        Admin_Form.usi_id_signature.BackgroundImage = Nothing
        Admin_Form.usi_id_signature.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub signpad_MouseDown(sender As Object, e As MouseEventArgs) Handles signpad.MouseDown
        draw = True
        Paintbrush(e.X, e.Y)
    End Sub

    Private Sub signpad_MouseUp(sender As Object, e As MouseEventArgs) Handles signpad.MouseUp
        draw = False
    End Sub

    Private Sub signpad_MouseMove(sender As Object, e As MouseEventArgs) Handles signpad.MouseMove
        If draw = True Then
            Paintbrush(e.X, e.Y)
        End If
    End Sub

    Private Sub Admin_Signpad_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bmp = New Bitmap(signpad.Width, signpad.Height)
        signpad.Image = bmp
    End Sub
End Class