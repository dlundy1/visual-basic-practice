Public Class sandwich_form
    Private TheSandwich As sandwich
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submit_btn.Click
        Try
            TheSandwich = New sandwich(name_box.Text, bread_box.Text, meat_box.Text,
                                       cheese_box.Text, condiments_box.Text)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim order_form As New order()
        order_form.ShowDialog()
        Debug.WriteLine(TheSandwich.getBread())

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        name_box.Clear()
        bread_box.Clear()
        meat_box.Clear()
        cheese_box.Clear()
        condiments_box.Clear()
    End Sub

    ReadOnly Property getObj() As sandwich
        Get
            Return TheSandwich
        End Get
    End Property
End Class
