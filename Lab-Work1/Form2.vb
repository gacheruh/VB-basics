Public Class Form2

    ''To change the font of the sample text in the textbox
    Private Sub changeFont(sender As Object, e As EventArgs) Handles garamond.CheckedChanged, magneto.CheckedChanged, tahoma.CheckedChanged
        Dim radioButton As RadioButton = CType(sender, RadioButton)

        If radioButton.Checked Then
            Dim selectedFontName As String = ""
            Select Case radioButton.Name
                Case "garamond"
                    selectedFontName = "Garamond"
                Case "magneto"
                    selectedFontName = "Magneto"
                Case "tahoma"
                    selectedFontName = "Tahoma"
            End Select

            ' Change the font of the TextBox
            TextBox1.Font = New Font(selectedFontName, 12)

            ' Force the TextBox to redraw itself
            TextBox1.Refresh()
        End If
    End Sub

    ''To change the font style of the sample text
    Private Sub changeFontStyle(sender As Object, e As EventArgs) Handles italic.CheckedChanged, bold.CheckedChanged, boldItalic.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If italic.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If bold.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If boldItalic.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic Or FontStyle.Bold
        End If

        TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, fontStyle)
    End Sub

    ''To change the font color of the sample text
    Private Sub changeColor(sender As Object, e As EventArgs) Handles green.CheckedChanged, blue.CheckedChanged, red.CheckedChanged
        If green.Checked Then
            TextBox1.ForeColor = Color.Green
        ElseIf blue.Checked Then
            TextBox1.ForeColor = Color.Blue
        ElseIf red.Checked Then
            TextBox1.ForeColor = Color.Red
        End If

        ' Refresh the TextBox to apply the font color change
        TextBox1.Refresh()
    End Sub

    'To unload the load Obj Demo form when the exit button is clicked'
    Private Sub Exit2Button_Click(sender As Object, e As EventArgs) Handles exit2.Click
        Me.Close() ' Close the current form (Form2)
    End Sub

    'Button that loads a picture and displays it in the picture box control when clicked'
    Private Sub LoadPicButton_Click(sender As Object, e As EventArgs) Handles loadPic.Click
        ' Create an instance of OpenFileDialog
        Using openFileDialog1 As New OpenFileDialog()
            ' Set the filter for image files
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 1
            openFileDialog1.RestoreDirectory = True

            ' Show the dialog and check if the user clicked OK
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Get the selected file name and load the image into PictureBox1
                Try
                    PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ''Adding tooltips to display info about the Btn when the mouse hovers over it
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(exit2, "Close the form")
        ToolTip2.SetToolTip(loadPic, "Load a picture from your gallery")
    End Sub
End Class
