Public Class Lightbulb

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Red_Button.CheckedChanged
        ' Change font color to 'Red'

        label_text.ForeColor = Color.Red
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Name_Box_TextChanged(sender As Object, e As EventArgs) Handles Name_Box.TextChanged

    End Sub

    Private Sub Lightbulb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Light_on_Click(sender As Object, e As EventArgs) Handles Light_on.Click
        ' Turn Light Off

        Light_on.Visible = False
        Light_off.Visible = True
        label_text.Text = "Turn ON the Light," & Name_Box.Text
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        ' Close Program

        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles Black_Button.CheckedChanged
        ' Change font color to Black

        label_text.ForeColor = Color.Black

    End Sub

    Private Sub Green_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Green_Button.CheckedChanged
        'Change font color to Green

        label_text.ForeColor = Color.Green
    End Sub

    Private Sub Blue_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Blue_Button.CheckedChanged
        'Change font color to Blue

        label_text.ForeColor = Color.Blue

    End Sub

    Private Sub Light_off_Click(sender As Object, e As EventArgs) Handles Light_off.Click
        ' Turns on Light

        Light_off.Visible = False
        Light_on.Visible = True
        label_text.Text = "Turn OFF the Light," & Name_Box.Text

    End Sub
End Class
