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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StudentName_Box = New System.Windows.Forms.TextBox()
        Me.units_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Status_box = New System.Windows.Forms.GroupBox()
        Me.Senior_Button = New System.Windows.Forms.RadioButton()
        Me.Junior_Button = New System.Windows.Forms.RadioButton()
        Me.Sophmore_Button = New System.Windows.Forms.RadioButton()
        Me.Freshman_Button = New System.Windows.Forms.RadioButton()
        Me.DeanList = New System.Windows.Forms.CheckBox()
        Me.School_Box = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSchoolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print_Button = New System.Windows.Forms.Button()
        Me.OK_button = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Status_box.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentName_Box
        '
        Me.StudentName_Box.Location = New System.Drawing.Point(96, 37)
        Me.StudentName_Box.Name = "StudentName_Box"
        Me.StudentName_Box.Size = New System.Drawing.Size(100, 20)
        Me.StudentName_Box.TabIndex = 0
        '
        'units_box
        '
        Me.units_box.Location = New System.Drawing.Point(96, 63)
        Me.units_box.Name = "units_box"
        Me.units_box.Size = New System.Drawing.Size(100, 20)
        Me.units_box.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Units Completed"
        '
        'Status_box
        '
        Me.Status_box.Controls.Add(Me.Senior_Button)
        Me.Status_box.Controls.Add(Me.Junior_Button)
        Me.Status_box.Controls.Add(Me.Sophmore_Button)
        Me.Status_box.Controls.Add(Me.Freshman_Button)
        Me.Status_box.Location = New System.Drawing.Point(12, 120)
        Me.Status_box.Name = "Status_box"
        Me.Status_box.Size = New System.Drawing.Size(139, 169)
        Me.Status_box.TabIndex = 4
        Me.Status_box.TabStop = False
        Me.Status_box.Text = "Class Status"
        '
        'Senior_Button
        '
        Me.Senior_Button.AutoSize = True
        Me.Senior_Button.Location = New System.Drawing.Point(6, 131)
        Me.Senior_Button.Name = "Senior_Button"
        Me.Senior_Button.Size = New System.Drawing.Size(55, 17)
        Me.Senior_Button.TabIndex = 3
        Me.Senior_Button.TabStop = True
        Me.Senior_Button.Text = "Senior"
        Me.Senior_Button.UseVisualStyleBackColor = True
        '
        'Junior_Button
        '
        Me.Junior_Button.AutoSize = True
        Me.Junior_Button.Location = New System.Drawing.Point(6, 96)
        Me.Junior_Button.Name = "Junior_Button"
        Me.Junior_Button.Size = New System.Drawing.Size(53, 17)
        Me.Junior_Button.TabIndex = 2
        Me.Junior_Button.TabStop = True
        Me.Junior_Button.Text = "Junior"
        Me.Junior_Button.UseVisualStyleBackColor = True
        '
        'Sophmore_Button
        '
        Me.Sophmore_Button.AutoSize = True
        Me.Sophmore_Button.Location = New System.Drawing.Point(6, 62)
        Me.Sophmore_Button.Name = "Sophmore_Button"
        Me.Sophmore_Button.Size = New System.Drawing.Size(73, 17)
        Me.Sophmore_Button.TabIndex = 1
        Me.Sophmore_Button.TabStop = True
        Me.Sophmore_Button.Text = "Sophmore"
        Me.Sophmore_Button.UseVisualStyleBackColor = True
        '
        'Freshman_Button
        '
        Me.Freshman_Button.AutoSize = True
        Me.Freshman_Button.Location = New System.Drawing.Point(6, 29)
        Me.Freshman_Button.Name = "Freshman_Button"
        Me.Freshman_Button.Size = New System.Drawing.Size(71, 17)
        Me.Freshman_Button.TabIndex = 0
        Me.Freshman_Button.TabStop = True
        Me.Freshman_Button.Text = "Freshman"
        Me.Freshman_Button.UseVisualStyleBackColor = True
        '
        'DeanList
        '
        Me.DeanList.AutoSize = True
        Me.DeanList.Location = New System.Drawing.Point(18, 308)
        Me.DeanList.Name = "DeanList"
        Me.DeanList.Size = New System.Drawing.Size(78, 17)
        Me.DeanList.TabIndex = 4
        Me.DeanList.Text = "Dean's List"
        Me.DeanList.UseVisualStyleBackColor = True
        '
        'School_Box
        '
        Me.School_Box.FormattingEnabled = True
        Me.School_Box.Items.AddRange(New Object() {"Unknown", "Franklin", "Highland", "West Highland", "Midtown"})
        Me.School_Box.Location = New System.Drawing.Point(157, 150)
        Me.School_Box.Name = "School_Box"
        Me.School_Box.Size = New System.Drawing.Size(121, 21)
        Me.School_Box.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(433, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSchoolsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSchoolsToolStripMenuItem
        '
        Me.PrintSchoolsToolStripMenuItem.Name = "PrintSchoolsToolStripMenuItem"
        Me.PrintSchoolsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintSchoolsToolStripMenuItem.Text = "&Print Schools"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSchoolToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddSchoolToolStripMenuItem
        '
        Me.AddSchoolToolStripMenuItem.Name = "AddSchoolToolStripMenuItem"
        Me.AddSchoolToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AddSchoolToolStripMenuItem.Text = "&Add School"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'Print_Button
        '
        Me.Print_Button.Location = New System.Drawing.Point(189, 281)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(89, 27)
        Me.Print_Button.TabIndex = 8
        Me.Print_Button.Text = "Print"
        Me.Print_Button.UseVisualStyleBackColor = True
        '
        'OK_button
        '
        Me.OK_button.Location = New System.Drawing.Point(284, 281)
        Me.OK_button.Name = "OK_button"
        Me.OK_button.Size = New System.Drawing.Size(89, 27)
        Me.OK_button.TabIndex = 9
        Me.OK_button.Text = "OK"
        Me.OK_button.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Accounting", "Business", "Computer Information Systems", "Marketing"})
        Me.ListBox1.Location = New System.Drawing.Point(301, 149)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(166, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Select Your School"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(180, 176)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(62, 13)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add School"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(337, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(290, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Brought to you by Deon L."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 351)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.OK_button)
        Me.Controls.Add(Me.Print_Button)
        Me.Controls.Add(Me.School_Box)
        Me.Controls.Add(Me.DeanList)
        Me.Controls.Add(Me.Status_box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.units_box)
        Me.Controls.Add(Me.StudentName_Box)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Status_box.ResumeLayout(False)
        Me.Status_box.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentName_Box As System.Windows.Forms.TextBox
    Friend WithEvents units_box As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Status_box As System.Windows.Forms.GroupBox
    Friend WithEvents Senior_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Junior_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Sophmore_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Freshman_Button As System.Windows.Forms.RadioButton
    Friend WithEvents DeanList As System.Windows.Forms.CheckBox
    Friend WithEvents School_Box As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSchoolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print_Button As System.Windows.Forms.Button
    Friend WithEvents OK_button As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles School_Box.SelectedIndexChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Private Sub AddSchoolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSchoolToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub OK_button_Click(sender As Object, e As EventArgs) Handles OK_button.Click
        StudentName_Box.Text = ""
        units_box.Text = ""
        Freshman_Button.Select()
        'School_Box.Items.Contains =
        DeanList.Checked = False

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.ShowDialog()
    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

    Private Sub Print_Button_Click(sender As Object, e As EventArgs) Handles Print_Button.Click
        PrintDocument1.Print()
    End Sub

    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

    Private Sub PrintSchoolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSchoolsToolStripMenuItem.Click
        PrintDocument1.Print()

        ' Dim printString As String

        'For Count As Integer = 0 To School_Box.Items.Count - 1
        'printString = School_Box.Items(Count).ToString()
        'Next
    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
