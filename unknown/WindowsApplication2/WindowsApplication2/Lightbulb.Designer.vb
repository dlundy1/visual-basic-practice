<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lightbulb
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lightbulb))
        Me.Name_Box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Black_Button = New System.Windows.Forms.RadioButton()
        Me.Blue_Button = New System.Windows.Forms.RadioButton()
        Me.Green_Button = New System.Windows.Forms.RadioButton()
        Me.Red_Button = New System.Windows.Forms.RadioButton()
        Me.Print_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.label_text = New System.Windows.Forms.Label()
        Me.Light_on = New System.Windows.Forms.PictureBox()
        Me.Light_off = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Light_on, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Light_off, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Name_Box
        '
        Me.Name_Box.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Name_Box.Location = New System.Drawing.Point(225, 21)
        Me.Name_Box.Name = "Name_Box"
        Me.Name_Box.Size = New System.Drawing.Size(168, 20)
        Me.Name_Box.TabIndex = 0
        Me.Name_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Black_Button)
        Me.GroupBox1.Controls.Add(Me.Blue_Button)
        Me.GroupBox1.Controls.Add(Me.Green_Button)
        Me.GroupBox1.Controls.Add(Me.Red_Button)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 119)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Color"
        '
        'Black_Button
        '
        Me.Black_Button.AutoSize = True
        Me.Black_Button.Checked = True
        Me.Black_Button.Location = New System.Drawing.Point(6, 27)
        Me.Black_Button.Name = "Black_Button"
        Me.Black_Button.Size = New System.Drawing.Size(52, 17)
        Me.Black_Button.TabIndex = 0
        Me.Black_Button.TabStop = True
        Me.Black_Button.Text = "Black"
        Me.Black_Button.UseVisualStyleBackColor = True
        '
        'Blue_Button
        '
        Me.Blue_Button.AutoSize = True
        Me.Blue_Button.Location = New System.Drawing.Point(6, 96)
        Me.Blue_Button.Name = "Blue_Button"
        Me.Blue_Button.Size = New System.Drawing.Size(46, 17)
        Me.Blue_Button.TabIndex = 3
        Me.Blue_Button.Text = "Blue"
        Me.Blue_Button.UseVisualStyleBackColor = True
        '
        'Green_Button
        '
        Me.Green_Button.AutoSize = True
        Me.Green_Button.Location = New System.Drawing.Point(6, 73)
        Me.Green_Button.Name = "Green_Button"
        Me.Green_Button.Size = New System.Drawing.Size(54, 17)
        Me.Green_Button.TabIndex = 2
        Me.Green_Button.Text = "Green"
        Me.Green_Button.UseVisualStyleBackColor = True
        '
        'Red_Button
        '
        Me.Red_Button.AutoSize = True
        Me.Red_Button.Location = New System.Drawing.Point(6, 50)
        Me.Red_Button.Name = "Red_Button"
        Me.Red_Button.Size = New System.Drawing.Size(45, 17)
        Me.Red_Button.TabIndex = 1
        Me.Red_Button.Text = "Red"
        Me.Red_Button.UseVisualStyleBackColor = True
        '
        'Print_Button
        '
        Me.Print_Button.Location = New System.Drawing.Point(195, 270)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(115, 35)
        Me.Print_Button.TabIndex = 2
        Me.Print_Button.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.Print_Button, "Prints Form")
        Me.Print_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(316, 270)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(115, 35)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.Exit_Button, "Exit Program")
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'label_text
        '
        Me.label_text.AutoSize = True
        Me.label_text.BackColor = System.Drawing.SystemColors.Control
        Me.label_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_text.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label_text.Location = New System.Drawing.Point(246, 227)
        Me.label_text.Name = "label_text"
        Me.label_text.Size = New System.Drawing.Size(129, 20)
        Me.label_text.TabIndex = 0
        Me.label_text.Text = "Turn on the Light"
        '
        'Light_on
        '
        Me.Light_on.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.light_on
        Me.Light_on.Image = Global.WindowsApplication2.My.Resources.Resources.light_on
        Me.Light_on.Location = New System.Drawing.Point(210, 64)
        Me.Light_on.Name = "Light_on"
        Me.Light_on.Size = New System.Drawing.Size(192, 151)
        Me.Light_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Light_on.TabIndex = 6
        Me.Light_on.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Light_on, "Click to turn Light OFF")
        Me.Light_on.Visible = False
        '
        'Light_off
        '
        Me.Light_off.BackgroundImage = CType(resources.GetObject("Light_off.BackgroundImage"), System.Drawing.Image)
        Me.Light_off.Image = Global.WindowsApplication2.My.Resources.Resources.light_off
        Me.Light_off.Location = New System.Drawing.Point(210, 64)
        Me.Light_off.Name = "Light_off"
        Me.Light_off.Size = New System.Drawing.Size(192, 151)
        Me.Light_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Light_off.TabIndex = 5
        Me.Light_off.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Light_off, "Click to turn Light ON")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Programmed by: Deon L."
        '
        'Lightbulb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_text)
        Me.Controls.Add(Me.Light_off)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Print_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Name_Box)
        Me.Controls.Add(Me.Light_on)
        Me.Name = "Lightbulb"
        Me.Text = "'LightBulb' by Deon Lundy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Light_on, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Light_off, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Name_Box As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Red_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Blue_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Green_Button As System.Windows.Forms.RadioButton
    Friend WithEvents Print_Button As System.Windows.Forms.Button
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents Light_off As System.Windows.Forms.PictureBox
    Friend WithEvents Light_on As System.Windows.Forms.PictureBox
    Friend WithEvents label_text As System.Windows.Forms.Label
    Friend WithEvents Black_Button As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
