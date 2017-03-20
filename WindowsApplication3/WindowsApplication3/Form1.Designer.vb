<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Radio_Controls = New System.Windows.Forms.GroupBox()
        Me.Withdraw_Button = New System.Windows.Forms.RadioButton()
        Me.Deposit_Button = New System.Windows.Forms.RadioButton()
        Me.ServiceCharge_Button = New System.Windows.Forms.RadioButton()
        Me.Check_Button = New System.Windows.Forms.RadioButton()
        Me.Name_Box = New System.Windows.Forms.MaskedTextBox()
        Me.AccountID_Box = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Deposit_Box = New System.Windows.Forms.TextBox()
        Me.Deposit_Label = New System.Windows.Forms.Label()
        Me.Withdraw_Label = New System.Windows.Forms.Label()
        Me.Withdraw_Box = New System.Windows.Forms.TextBox()
        Me.Balance_Label = New System.Windows.Forms.Label()
        Me.Balance_box = New System.Windows.Forms.TextBox()
        Me.ServiceCharge_Box = New System.Windows.Forms.TextBox()
        Me.ServiceCharge_Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Calculate_Button = New System.Windows.Forms.Button()
        Me.Print_Button = New System.Windows.Forms.Button()
        Me.Button_Controls = New System.Windows.Forms.GroupBox()
        Me.Log_IN = New System.Windows.Forms.Label()
        Me.Log_IN2 = New System.Windows.Forms.Label()
        Me.Fail2 = New System.Windows.Forms.Label()
        Me.FAILED = New System.Windows.Forms.Label()
        Me.Welcome_Box = New System.Windows.Forms.TextBox()
        Me.Logout = New System.Windows.Forms.Label()
        Me.Logout2 = New System.Windows.Forms.Label()
        Me.INTRO = New System.Windows.Forms.Label()
        Me.Test = New System.Windows.Forms.Label()
        Me.Done = New System.Windows.Forms.Label()
        Me.OverDraft = New System.Windows.Forms.Label()
        Me.OverDraft2 = New System.Windows.Forms.Label()
        Me.Radio_Controls.SuspendLayout()
        Me.Button_Controls.SuspendLayout()
        Me.SuspendLayout()
        '
        'Radio_Controls
        '
        Me.Radio_Controls.Controls.Add(Me.Withdraw_Button)
        Me.Radio_Controls.Controls.Add(Me.Deposit_Button)
        Me.Radio_Controls.Controls.Add(Me.ServiceCharge_Button)
        Me.Radio_Controls.Controls.Add(Me.Check_Button)
        Me.Radio_Controls.Enabled = False
        Me.Radio_Controls.Location = New System.Drawing.Point(21, 152)
        Me.Radio_Controls.Name = "Radio_Controls"
        Me.Radio_Controls.Size = New System.Drawing.Size(148, 132)
        Me.Radio_Controls.TabIndex = 3
        Me.Radio_Controls.TabStop = False
        Me.Radio_Controls.Text = "Transaction Options"
        '
        'Withdraw_Button
        '
        Me.Withdraw_Button.AutoSize = True
        Me.Withdraw_Button.Location = New System.Drawing.Point(6, 77)
        Me.Withdraw_Button.Name = "Withdraw_Button"
        Me.Withdraw_Button.Size = New System.Drawing.Size(70, 17)
        Me.Withdraw_Button.TabIndex = 2
        Me.Withdraw_Button.TabStop = True
        Me.Withdraw_Button.Text = "Withdraw"
        Me.Withdraw_Button.UseVisualStyleBackColor = True
        '
        'Deposit_Button
        '
        Me.Deposit_Button.AutoSize = True
        Me.Deposit_Button.Location = New System.Drawing.Point(6, 53)
        Me.Deposit_Button.Name = "Deposit_Button"
        Me.Deposit_Button.Size = New System.Drawing.Size(61, 17)
        Me.Deposit_Button.TabIndex = 1
        Me.Deposit_Button.Text = "Deposit"
        Me.Deposit_Button.UseVisualStyleBackColor = True
        '
        'ServiceCharge_Button
        '
        Me.ServiceCharge_Button.AutoSize = True
        Me.ServiceCharge_Button.Location = New System.Drawing.Point(6, 99)
        Me.ServiceCharge_Button.Name = "ServiceCharge_Button"
        Me.ServiceCharge_Button.Size = New System.Drawing.Size(98, 17)
        Me.ServiceCharge_Button.TabIndex = 3
        Me.ServiceCharge_Button.Text = "Service Charge"
        Me.ServiceCharge_Button.UseVisualStyleBackColor = True
        '
        'Check_Button
        '
        Me.Check_Button.AutoSize = True
        Me.Check_Button.Checked = True
        Me.Check_Button.Location = New System.Drawing.Point(6, 30)
        Me.Check_Button.Name = "Check_Button"
        Me.Check_Button.Size = New System.Drawing.Size(98, 17)
        Me.Check_Button.TabIndex = 0
        Me.Check_Button.TabStop = True
        Me.Check_Button.Text = "Check Balance"
        Me.Check_Button.UseVisualStyleBackColor = True
        '
        'Name_Box
        '
        Me.Name_Box.Location = New System.Drawing.Point(78, 12)
        Me.Name_Box.Name = "Name_Box"
        Me.Name_Box.Size = New System.Drawing.Size(126, 20)
        Me.Name_Box.TabIndex = 0
        '
        'AccountID_Box
        '
        Me.AccountID_Box.Location = New System.Drawing.Point(78, 38)
        Me.AccountID_Box.Mask = "0000000"
        Me.AccountID_Box.Name = "AccountID_Box"
        Me.AccountID_Box.Size = New System.Drawing.Size(126, 20)
        Me.AccountID_Box.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Account ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "(7-digits)"
        '
        'Deposit_Box
        '
        Me.Deposit_Box.Location = New System.Drawing.Point(305, 131)
        Me.Deposit_Box.Name = "Deposit_Box"
        Me.Deposit_Box.Size = New System.Drawing.Size(100, 20)
        Me.Deposit_Box.TabIndex = 10
        Me.Deposit_Box.Visible = False
        '
        'Deposit_Label
        '
        Me.Deposit_Label.AutoSize = True
        Me.Deposit_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deposit_Label.Location = New System.Drawing.Point(219, 131)
        Me.Deposit_Label.Name = "Deposit_Label"
        Me.Deposit_Label.Size = New System.Drawing.Size(85, 25)
        Me.Deposit_Label.TabIndex = 11
        Me.Deposit_Label.Text = "Deposit"
        Me.Deposit_Label.Visible = False
        '
        'Withdraw_Label
        '
        Me.Withdraw_Label.AutoSize = True
        Me.Withdraw_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Withdraw_Label.Location = New System.Drawing.Point(201, 131)
        Me.Withdraw_Label.Name = "Withdraw_Label"
        Me.Withdraw_Label.Size = New System.Drawing.Size(101, 25)
        Me.Withdraw_Label.TabIndex = 12
        Me.Withdraw_Label.Text = "Withdraw"
        Me.Withdraw_Label.Visible = False
        '
        'Withdraw_Box
        '
        Me.Withdraw_Box.AcceptsReturn = True
        Me.Withdraw_Box.Location = New System.Drawing.Point(305, 132)
        Me.Withdraw_Box.Name = "Withdraw_Box"
        Me.Withdraw_Box.Size = New System.Drawing.Size(100, 20)
        Me.Withdraw_Box.TabIndex = 13
        Me.Withdraw_Box.Visible = False
        '
        'Balance_Label
        '
        Me.Balance_Label.AutoSize = True
        Me.Balance_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance_Label.Location = New System.Drawing.Point(214, 131)
        Me.Balance_Label.Name = "Balance_Label"
        Me.Balance_Label.Size = New System.Drawing.Size(90, 25)
        Me.Balance_Label.TabIndex = 14
        Me.Balance_Label.Text = "Balance"
        '
        'Balance_box
        '
        Me.Balance_box.AcceptsReturn = True
        Me.Balance_box.Location = New System.Drawing.Point(305, 132)
        Me.Balance_box.Name = "Balance_box"
        Me.Balance_box.ReadOnly = True
        Me.Balance_box.Size = New System.Drawing.Size(100, 20)
        Me.Balance_box.TabIndex = 3
        '
        'ServiceCharge_Box
        '
        Me.ServiceCharge_Box.AcceptsReturn = True
        Me.ServiceCharge_Box.BackColor = System.Drawing.SystemColors.Control
        Me.ServiceCharge_Box.Location = New System.Drawing.Point(297, 132)
        Me.ServiceCharge_Box.Name = "ServiceCharge_Box"
        Me.ServiceCharge_Box.ReadOnly = True
        Me.ServiceCharge_Box.Size = New System.Drawing.Size(108, 20)
        Me.ServiceCharge_Box.TabIndex = 16
        Me.ServiceCharge_Box.Text = "FREE"
        Me.ServiceCharge_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ServiceCharge_Box.Visible = False
        '
        'ServiceCharge_Label
        '
        Me.ServiceCharge_Label.AutoSize = True
        Me.ServiceCharge_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceCharge_Label.Location = New System.Drawing.Point(213, 131)
        Me.ServiceCharge_Label.Name = "ServiceCharge_Label"
        Me.ServiceCharge_Label.Size = New System.Drawing.Size(82, 25)
        Me.ServiceCharge_Label.TabIndex = 17
        Me.ServiceCharge_Label.Text = "Charge"
        Me.ServiceCharge_Label.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(297, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Programmed by: Deon Lundy"
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(89, 64)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 2
        Me.Submit_Button.Text = "Login"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(113, 58)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(101, 33)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(6, 58)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(101, 33)
        Me.Clear_Button.TabIndex = 2
        Me.Clear_Button.Text = "Log Out"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Calculate_Button
        '
        Me.Calculate_Button.Location = New System.Drawing.Point(6, 19)
        Me.Calculate_Button.Name = "Calculate_Button"
        Me.Calculate_Button.Size = New System.Drawing.Size(101, 33)
        Me.Calculate_Button.TabIndex = 0
        Me.Calculate_Button.Text = "Submit"
        Me.Calculate_Button.UseVisualStyleBackColor = True
        '
        'Print_Button
        '
        Me.Print_Button.Location = New System.Drawing.Point(113, 19)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(101, 33)
        Me.Print_Button.TabIndex = 1
        Me.Print_Button.Text = "Print"
        Me.Print_Button.UseVisualStyleBackColor = True
        '
        'Button_Controls
        '
        Me.Button_Controls.Controls.Add(Me.Print_Button)
        Me.Button_Controls.Controls.Add(Me.Calculate_Button)
        Me.Button_Controls.Controls.Add(Me.Clear_Button)
        Me.Button_Controls.Controls.Add(Me.Exit_Button)
        Me.Button_Controls.Enabled = False
        Me.Button_Controls.Location = New System.Drawing.Point(199, 182)
        Me.Button_Controls.Name = "Button_Controls"
        Me.Button_Controls.Size = New System.Drawing.Size(220, 105)
        Me.Button_Controls.TabIndex = 4
        Me.Button_Controls.TabStop = False
        '
        'Log_IN
        '
        Me.Log_IN.AutoSize = True
        Me.Log_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Log_IN.ForeColor = System.Drawing.Color.Green
        Me.Log_IN.Location = New System.Drawing.Point(314, 12)
        Me.Log_IN.Name = "Log_IN"
        Me.Log_IN.Size = New System.Drawing.Size(120, 25)
        Me.Log_IN.TabIndex = 21
        Me.Log_IN.Text = "SUCCESS"
        Me.Log_IN.Visible = False
        '
        'Log_IN2
        '
        Me.Log_IN2.AutoSize = True
        Me.Log_IN2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Log_IN2.Location = New System.Drawing.Point(320, 40)
        Me.Log_IN2.Name = "Log_IN2"
        Me.Log_IN2.Size = New System.Drawing.Size(121, 13)
        Me.Log_IN2.TabIndex = 22
        Me.Log_IN2.Text = "You are now Logged In."
        Me.Log_IN2.Visible = False
        '
        'Fail2
        '
        Me.Fail2.AutoSize = True
        Me.Fail2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Fail2.Location = New System.Drawing.Point(344, 41)
        Me.Fail2.Name = "Fail2"
        Me.Fail2.Size = New System.Drawing.Size(90, 13)
        Me.Fail2.TabIndex = 23
        Me.Fail2.Text = "Please Try Again."
        Me.Fail2.Visible = False
        '
        'FAILED
        '
        Me.FAILED.AutoSize = True
        Me.FAILED.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAILED.ForeColor = System.Drawing.Color.Red
        Me.FAILED.Location = New System.Drawing.Point(331, 15)
        Me.FAILED.Name = "FAILED"
        Me.FAILED.Size = New System.Drawing.Size(91, 25)
        Me.FAILED.TabIndex = 24
        Me.FAILED.Text = "FAILED"
        Me.FAILED.Visible = False
        '
        'Welcome_Box
        '
        Me.Welcome_Box.BackColor = System.Drawing.SystemColors.Control
        Me.Welcome_Box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Welcome_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_Box.Location = New System.Drawing.Point(27, 109)
        Me.Welcome_Box.Name = "Welcome_Box"
        Me.Welcome_Box.ReadOnly = True
        Me.Welcome_Box.Size = New System.Drawing.Size(230, 19)
        Me.Welcome_Box.TabIndex = 25
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.Red
        Me.Logout.Location = New System.Drawing.Point(307, 12)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(134, 25)
        Me.Logout.TabIndex = 26
        Me.Logout.Text = "Logged Out"
        Me.Logout.Visible = False
        '
        'Logout2
        '
        Me.Logout2.AutoSize = True
        Me.Logout2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Logout2.Location = New System.Drawing.Point(315, 41)
        Me.Logout2.Name = "Logout2"
        Me.Logout2.Size = New System.Drawing.Size(126, 13)
        Me.Logout2.TabIndex = 27
        Me.Logout2.Text = "You are now Logged Out"
        Me.Logout2.Visible = False
        '
        'INTRO
        '
        Me.INTRO.AutoSize = True
        Me.INTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INTRO.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.INTRO.Location = New System.Drawing.Point(65, 99)
        Me.INTRO.Name = "INTRO"
        Me.INTRO.Size = New System.Drawing.Size(125, 20)
        Me.INTRO.TabIndex = 28
        Me.INTRO.Text = "Please Sign In"
        Me.INTRO.Visible = False
        '
        'Test
        '
        Me.Test.AutoSize = True
        Me.Test.Location = New System.Drawing.Point(312, 114)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(0, 13)
        Me.Test.TabIndex = 29
        '
        'Done
        '
        Me.Done.AutoSize = True
        Me.Done.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Done.ForeColor = System.Drawing.Color.Green
        Me.Done.Location = New System.Drawing.Point(319, 90)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(57, 20)
        Me.Done.TabIndex = 30
        Me.Done.Text = "DONE!"
        Me.Done.Visible = False
        '
        'OverDraft
        '
        Me.OverDraft.AutoSize = True
        Me.OverDraft.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverDraft.ForeColor = System.Drawing.Color.Red
        Me.OverDraft.Location = New System.Drawing.Point(308, 90)
        Me.OverDraft.Name = "OverDraft"
        Me.OverDraft.Size = New System.Drawing.Size(84, 20)
        Me.OverDraft.TabIndex = 31
        Me.OverDraft.Text = "WHOOPS"
        Me.OverDraft.Visible = False
        '
        'OverDraft2
        '
        Me.OverDraft2.AutoSize = True
        Me.OverDraft2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.OverDraft2.Location = New System.Drawing.Point(309, 110)
        Me.OverDraft2.Name = "OverDraft2"
        Me.OverDraft2.Size = New System.Drawing.Size(95, 13)
        Me.OverDraft2.TabIndex = 32
        Me.OverDraft2.Text = "Funds Unavailable"
        Me.OverDraft2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 341)
        Me.Controls.Add(Me.OverDraft2)
        Me.Controls.Add(Me.OverDraft)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.INTRO)
        Me.Controls.Add(Me.Logout2)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Welcome_Box)
        Me.Controls.Add(Me.FAILED)
        Me.Controls.Add(Me.Fail2)
        Me.Controls.Add(Me.Log_IN2)
        Me.Controls.Add(Me.Log_IN)
        Me.Controls.Add(Me.Button_Controls)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Balance_Label)
        Me.Controls.Add(Me.Withdraw_Label)
        Me.Controls.Add(Me.Deposit_Label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AccountID_Box)
        Me.Controls.Add(Me.Name_Box)
        Me.Controls.Add(Me.Radio_Controls)
        Me.Controls.Add(Me.ServiceCharge_Label)
        Me.Controls.Add(Me.Balance_box)
        Me.Controls.Add(Me.Withdraw_Box)
        Me.Controls.Add(Me.Deposit_Box)
        Me.Controls.Add(Me.ServiceCharge_Box)
        Me.Name = "Form1"
        Me.Text = "Checking Account"
        Me.Radio_Controls.ResumeLayout(False)
        Me.Radio_Controls.PerformLayout()
        Me.Button_Controls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Radio_Controls As System.Windows.Forms.GroupBox
    Friend WithEvents ServiceCharge_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Check_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Name_Box As System.Windows.Forms.MaskedTextBox
    Friend WithEvents AccountID_Box As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Deposit_Box As System.Windows.Forms.TextBox
    Friend WithEvents Deposit_Label As System.Windows.Forms.Label
    Friend WithEvents Withdraw_Label As System.Windows.Forms.Label
    Friend WithEvents Withdraw_Box As System.Windows.Forms.TextBox
    Friend WithEvents Balance_Label As System.Windows.Forms.Label
    Friend WithEvents Balance_box As System.Windows.Forms.TextBox
    Friend WithEvents ServiceCharge_Box As System.Windows.Forms.TextBox
    Friend WithEvents ServiceCharge_Label As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Deposit_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_Button As System.Windows.Forms.Button
    Friend WithEvents Calculate_Button As System.Windows.Forms.Button
    Friend WithEvents Print_Button As System.Windows.Forms.Button
    Friend WithEvents Button_Controls As System.Windows.Forms.GroupBox
    Friend WithEvents Log_IN As System.Windows.Forms.Label
    Friend WithEvents Log_IN2 As System.Windows.Forms.Label
    Friend WithEvents Fail2 As System.Windows.Forms.Label
    Friend WithEvents FAILED As System.Windows.Forms.Label
    Friend WithEvents Welcome_Box As System.Windows.Forms.TextBox
    Friend WithEvents Logout As System.Windows.Forms.Label
    Friend WithEvents Logout2 As System.Windows.Forms.Label
    Friend WithEvents INTRO As System.Windows.Forms.Label
    Friend WithEvents Test As System.Windows.Forms.Label
    Friend WithEvents Withdraw_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Done As System.Windows.Forms.Label
    Friend WithEvents OverDraft As System.Windows.Forms.Label
    Friend WithEvents OverDraft2 As System.Windows.Forms.Label

End Class
