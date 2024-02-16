Public Class frmObjectDemonstrations
    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox.Image = New Bitmap(openFileDialog.FileName)
        End If
    End Sub


    Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonGaramond.CheckedChanged, radiobuttonMagneto.CheckedChanged, radiobuttonTahoma.CheckedChanged
        Dim radiobutton As RadioButton = DirectCast(sender, RadioButton)

        If radiobutton.Checked Then
            Select Case radiobutton.Name
                Case "radiobuttonGaramond"
                    SampleTextFont.Font = New Font("Garamond", SampleTextFont.Font.Size, SampleTextFont.Font.Style)

                Case "radiobuttonMagneto"
                    SampleTextFont.Font = New Font("Magneto", SampleTextFont.Font.Size, SampleTextFont.Font.Style)

                Case "radiobuttonTahoma"
                    SampleTextFont.Font = New Font("Tahoma", SampleTextFont.Font.Size, SampleTextFont.Font.Style)
            End Select
        End If
    End Sub

    Private Sub radioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonGreen.CheckedChanged, radiobuttonBlue.CheckedChanged, radiobuttonRed.CheckedChanged
        Dim radiobutton As RadioButton = DirectCast(sender, RadioButton)

        If radiobutton.Checked Then
            Select Case radiobutton.Name
                Case "radiobuttonGreen"
                    SampleTextFont.ForeColor = Color.Green

                Case "radiobuttonBlue"
                    SampleTextFont.ForeColor = Color.Blue

                Case "radiobuttonRed"
                    SampleTextFont.ForeColor = Color.Red
            End Select
        End If
    End Sub

    Private Sub checkBox_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxBold.CheckedChanged, checkBoxItalic.CheckedChanged, checkBoxBI.CheckedChanged
        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)

        If checkbox.Checked Then
            Select Case checkbox.Name
                Case "checkBoxBold"
                    SampleTextFont.Font = New Font(SampleTextFont.Font, FontStyle.Bold)

                Case "checkBoxItalic"
                    SampleTextFont.Font = New Font(SampleTextFont.Font, FontStyle.Italic)

                Case "checkBoxBI"
                    SampleTextFont.Font = New Font(SampleTextFont.Font, FontStyle.Bold Or FontStyle.Italic)
            End Select
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class