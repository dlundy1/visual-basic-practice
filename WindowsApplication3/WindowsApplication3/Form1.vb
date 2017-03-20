Public Class Form1
    ' Module Variables
    Private userName, ID As String
    Private balance As Double

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Name_Box.Text = ""
        AccountID_Box.Text = ""
        Check_Button.Checked = True
        Log_IN.Visible = False
        Log_IN2.Visible = False
        Logout.Visible = True
        Logout2.Visible = True
        Radio_Controls.Enabled = False
        Button_Controls.Enabled = False
        Welcome_Box.Visible = False
        INTRO.Visible = True
        OverDraft.Visible = False
        OverDraft2.Visible = False
        Balance_box.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculate_Button.Click
        ' Calculate Code
        Dim deposit, withdraw As Double

        Try
            If Check_Button.Checked = True Then
                Done.Visible = False
                deposit = 0
                withdraw = 0
                Debug.WriteLine("Balance=" & balance)
            ElseIf Deposit_Button.Checked = True Then
                Done.Visible = False
                deposit = Double.Parse(Deposit_Box.Text)
                balance = balance + deposit
                Debug.WriteLine("Balance=" & balance)
                Debug.WriteLine("Deposit =" & Double.Parse(Deposit_Box.Text))
                Debug.WriteLine("Balance=" & balance)
                Deposit_Box.Text = ""
                deposit = 0
                Done.Visible = True
            ElseIf Withdraw_Button.Checked = True Then
                Done.Visible = False
                withdraw = Double.Parse(Withdraw_Box.Text)
                If balance < withdraw Then
                    'MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    OverDraft.Visible = True
                    OverDraft2.Visible = True
                    Withdraw_Box.Text = ""
                Else
                    balance = balance - withdraw
                    Debug.WriteLine("Withdraw = " & Double.Parse(Withdraw_Box.Text))
                    Debug.WriteLine("Balance=" & balance)
                    withdraw = 0
                    Withdraw_Box.Text = ""
                    Done.Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        Debug.WriteLine("-- Immediate Window Should Work Here --")
        Debug.Print("-- Print Code, Immediate Window-- ")
        userName = Name_Box.Text
        ID = AccountID_Box.Text

        If userName = "" Or ID = "" Then
            FAILED.Visible = True
            Fail2.Visible = True
        Else
            'Code to Execute Once information has been Submitted
            Balance_box.Enabled = True
            Balance_box.Text = balance.ToString("C")
            Welcome_Box.Text = "Welcome, " & Name_Box.Text
            FAILED.Visible = False
            Fail2.Visible = False
            Logout.Visible = False
            Logout2.Visible = False
            Log_IN.Visible = True
            Log_IN2.Visible = True
            Radio_Controls.Enabled = True
            Button_Controls.Enabled = True
            INTRO.Visible = False

        End If
    End Sub

    Private Sub Check_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Button.CheckedChanged
        ' Radio_Button Control Structure
        If Check_Button.Checked = True Then
            'Code to remove other Labels
            Done.Visible = False
            Deposit_Box.Visible = False
            Deposit_Label.Visible = False
            Withdraw_Box.Visible = False
            Withdraw_Label.Visible = False
            ServiceCharge_Box.Visible = False
            ServiceCharge_Label.Visible = False
            Balance_box.Visible = True
            Balance_Label.Visible = True
            balance = balance
            Balance_box.Text = balance.ToString("C")
        End If
    End Sub

    Private Sub Deposit_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Deposit_Button.CheckedChanged
        ' Radio_Button Control Structure
        If Deposit_Button.Checked = True Then
            'Code to remove other Labels
            Done.Visible = False
            Withdraw_Box.Visible = False
            Withdraw_Label.Visible = False
            ServiceCharge_Box.Visible = False
            ServiceCharge_Label.Visible = False
            Balance_box.Visible = False
            Balance_Label.Visible = False
            Deposit_Box.Visible = True
            Deposit_Label.Visible = True
        End If
    End Sub

    Private Sub Withdraw_Button_CheckedChanged(sender As Object, e As EventArgs) Handles Withdraw_Button.CheckedChanged
        ' Radio_Button Control Structure
       If Withdraw_Button.Checked = True Then
            'Code to remove other Labels
            Done.Visible = False
            Balance_box.Visible = False
            Balance_Label.Visible = False
            Deposit_Box.Visible = False
            Deposit_Label.Visible = False
            ServiceCharge_Box.Visible = False
            ServiceCharge_Label.Visible = False
            Withdraw_Box.Visible = True
            Withdraw_Label.Visible = True
            OverDraft.Visible = False
            OverDraft.Visible = False
        End If
    End Sub

    Private Sub ServiceCharge_Button_CheckedChanged(sender As Object, e As EventArgs) Handles ServiceCharge_Button.CheckedChanged
        ' Radio_Button Control Structure
        If ServiceCharge_Button.Checked = True Then
            'Code to remove other Labels
            Done.Visible = False
            Withdraw_Label.Visible = False
            Withdraw_Box.Visible = False
            Deposit_Box.Visible = False
            Deposit_Label.Visible = False
            Balance_box.Visible = False
            Balance_Label.Visible = False
            ServiceCharge_Box.Visible = True
            ServiceCharge_Label.Visible = True
        End If
    End Sub

    Private Sub Balance_Label_Click(sender As Object, e As EventArgs) Handles Balance_Label.Click

    End Sub
End Class
