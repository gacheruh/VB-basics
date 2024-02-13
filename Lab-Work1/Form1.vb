Public Class Form1
    'event handler that exits the application when the exit button is clicked'
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Application.Exit()
    End Sub
    'To maximise the window and change the color when anywhere in the form is clicked'
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub
    'Event handler that oppens the Obj Demo Form when the load button is clicked'
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub
    'Adding tooltips that display info about the button when the mouse hovers it'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(exit1, "Exit Application")
        ToolTip2.SetToolTip(loadButton, "Load Object Demonstration Form")
    End Sub

End Class

