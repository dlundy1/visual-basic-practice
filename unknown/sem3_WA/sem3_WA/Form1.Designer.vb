<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sandwich_form
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.name_box = New System.Windows.Forms.TextBox()
        Me.bread_box = New System.Windows.Forms.TextBox()
        Me.meat_box = New System.Windows.Forms.TextBox()
        Me.cheese_box = New System.Windows.Forms.TextBox()
        Me.condiments_box = New System.Windows.Forms.TextBox()
        Me.Submit_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bread"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Meat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cheese"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Condiments"
        '
        'name_box
        '
        Me.name_box.Location = New System.Drawing.Point(64, 87)
        Me.name_box.Name = "name_box"
        Me.name_box.Size = New System.Drawing.Size(100, 20)
        Me.name_box.TabIndex = 5
        '
        'bread_box
        '
        Me.bread_box.Location = New System.Drawing.Point(64, 115)
        Me.bread_box.Name = "bread_box"
        Me.bread_box.Size = New System.Drawing.Size(100, 20)
        Me.bread_box.TabIndex = 6
        '
        'meat_box
        '
        Me.meat_box.Location = New System.Drawing.Point(64, 141)
        Me.meat_box.Name = "meat_box"
        Me.meat_box.Size = New System.Drawing.Size(100, 20)
        Me.meat_box.TabIndex = 7
        '
        'cheese_box
        '
        Me.cheese_box.Location = New System.Drawing.Point(236, 21)
        Me.cheese_box.Name = "cheese_box"
        Me.cheese_box.Size = New System.Drawing.Size(100, 20)
        Me.cheese_box.TabIndex = 8
        '
        'condiments_box
        '
        Me.condiments_box.Location = New System.Drawing.Point(236, 49)
        Me.condiments_box.Name = "condiments_box"
        Me.condiments_box.Size = New System.Drawing.Size(100, 20)
        Me.condiments_box.TabIndex = 9
        '
        'Submit_btn
        '
        Me.Submit_btn.Location = New System.Drawing.Point(135, 176)
        Me.Submit_btn.Name = "Submit_btn"
        Me.Submit_btn.Size = New System.Drawing.Size(107, 33)
        Me.Submit_btn.TabIndex = 10
        Me.Submit_btn.Text = "SUBMIT"
        Me.Submit_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Place Your Order"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.condiments_box)
        Me.GroupBox1.Controls.Add(Me.cheese_box)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 154)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(313, 130)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Reset"
        '
        'sandwich_form
        '
        Me.AcceptButton = Me.Submit_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 244)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Submit_btn)
        Me.Controls.Add(Me.meat_box)
        Me.Controls.Add(Me.bread_box)
        Me.Controls.Add(Me.name_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "sandwich_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Your Sandwich"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents name_box As TextBox
    Friend WithEvents bread_box As TextBox
    Friend WithEvents meat_box As TextBox
    Friend WithEvents cheese_box As TextBox
    Friend WithEvents condiments_box As TextBox
    Friend WithEvents Submit_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
