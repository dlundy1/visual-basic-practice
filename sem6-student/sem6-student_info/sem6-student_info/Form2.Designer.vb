<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddSchool_Box = New System.Windows.Forms.TextBox()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Quit_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter School Name"
        '
        'AddSchool_Box
        '
        Me.AddSchool_Box.Location = New System.Drawing.Point(62, 58)
        Me.AddSchool_Box.Name = "AddSchool_Box"
        Me.AddSchool_Box.Size = New System.Drawing.Size(145, 20)
        Me.AddSchool_Box.TabIndex = 1
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(61, 114)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Submit_Button.TabIndex = 2
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Quit_Button
        '
        Me.Quit_Button.Location = New System.Drawing.Point(142, 114)
        Me.Quit_Button.Name = "Quit_Button"
        Me.Quit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Quit_Button.TabIndex = 3
        Me.Quit_Button.Text = "Quit"
        Me.Quit_Button.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 173)
        Me.Controls.Add(Me.Quit_Button)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.AddSchool_Box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddSchool_Box As System.Windows.Forms.TextBox
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Quit_Button As System.Windows.Forms.Button
End Class
