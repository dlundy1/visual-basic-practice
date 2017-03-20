Public Class Form2

    Private Sub Quit_Button_Click(sender As Object, e As EventArgs) Handles Quit_Button.Click
        Me.Close()
    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        Form1.School_Box.Items.Add(AddSchool_Box.Text)
        AddSchool_Box.Text = ""
        Me.Close()
    End Sub
End Class