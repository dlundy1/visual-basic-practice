Public Class order
    Private TS As sandwich
    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TS = sandwich_form.getObj()

        name_out.Text = TS.getName()
        bread_out.Text = TS.getBread()
        meat_out.Text = TS.getMeat()
        cheese_out.Text = TS.getCheese()
        condiments_out.Text = TS.getCondiments()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class