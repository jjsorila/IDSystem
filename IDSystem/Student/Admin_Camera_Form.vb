Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Admin_Camera_Form
    Dim CAMERA As VideoCaptureDevice

    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        cameraFeed.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Admin_Camera_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        okBtn.Visible = False
        cancelBtn.Visible = False
        Dim CAMERAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()

        If CAMERAS.ShowDialog() = DialogResult.OK Then
            CAMERA = CAMERAS.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
            CAMERA.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Admin_Camera_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            CAMERA.Stop()
        Catch ex As Exception
        Finally
            Me.Dispose()
        End Try
    End Sub

    Private Sub captureBtn_Click(sender As Object, e As EventArgs) Handles captureBtn.Click
        okBtn.Visible = True
        cancelBtn.Visible = True
        captureBtn.Visible = False
        CAMERA.Stop()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        CAMERA.Start()
        cancelBtn.Visible = False
        okBtn.Visible = False
        captureBtn.Visible = True
        Me.Focus()
    End Sub

    Private Sub Admin_Camera_Form_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If CAMERA.IsRunning Then
            If Asc(e.KeyChar) = 32 Then
                okBtn.Visible = True
                cancelBtn.Visible = True
                captureBtn.Visible = False
                CAMERA.Stop()
            End If
        End If
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        'If MsgBox("Is this good?", MsgBoxStyle.YesNo) = DialogResult.Yes Then

        '    If cameraFeed.Image.Height < 1000 Then
        '        Using imgResult As New Bitmap(cameraFeed.Image)
        '            imgResult.Save(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"))
        '        End Using

        '        Using fs As New IO.FileStream(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"), IO.FileMode.Open, IO.FileAccess.Read)
        '            Admin_Form.usi_id_picture.Image = Image.FromStream(fs)
        '        End Using
        '    Else
        '        'Recommended Camera Resolution 1920 x 1080

        '        'CROP CAMERA FEED IMAGE
        '        Dim CropRect As New Rectangle(449, 0, 1000, 1000)

        '        Using imgResult As New Bitmap(CropRect.Width, CropRect.Height)
        '            Using grResult As Graphics = Graphics.FromImage(imgResult)
        '                grResult.DrawImage(cameraFeed.Image, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
        '                imgResult.Save(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"))
        '            End Using
        '        End Using

        '        Using fs As New IO.FileStream(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"), IO.FileMode.Open, IO.FileAccess.Read)
        '            Admin_Form.usi_id_picture.Image = Image.FromStream(fs)
        '        End Using
        '    End If

        '    Admin_Form.isIdUploaded = 1
        '    Admin_Select_Photo_Source.Close()
        '    Me.Close()
        'Else
        '    cancelBtn.PerformClick()
        'End If

        If cameraFeed.Image.Height < 1000 Then
            Using imgResult As New Bitmap(cameraFeed.Image)
                imgResult.Save(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"))
            End Using

            Using fs As New IO.FileStream(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"), IO.FileMode.Open, IO.FileAccess.Read)
                Admin_Form.usi_id_picture.Image = Image.FromStream(fs)
            End Using
        Else
            'Recommended Camera Resolution 1920 x 1080

            'CROP CAMERA FEED IMAGE
            Dim CropRect As New Rectangle(449, 0, 1000, 1000)

            Using imgResult As New Bitmap(CropRect.Width, CropRect.Height)
                Using grResult As Graphics = Graphics.FromImage(imgResult)
                    grResult.DrawImage(cameraFeed.Image, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
                    imgResult.Save(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"))
                End Using
            End Using

            Using fs As New IO.FileStream(Path.Combine(Application.StartupPath, "temp_student_pic.jpg"), IO.FileMode.Open, IO.FileAccess.Read)
                Admin_Form.usi_id_picture.Image = Image.FromStream(fs)
            End Using
        End If

        Admin_Form.isIdUploaded = 1
        Admin_Select_Photo_Source.Close()
        Me.Close()
    End Sub
End Class