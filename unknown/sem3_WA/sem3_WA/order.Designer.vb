<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
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
        Me.name_out = New System.Windows.Forms.TextBox()
        Me.condiments_out = New System.Windows.Forms.TextBox()
        Me.cheese_out = New System.Windows.Forms.TextBox()
        Me.meat_out = New System.Windows.Forms.TextBox()
        Me.bread_out = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Condiments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cheese"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bread"
        '
        'name_out
        '
        Me.name_out.Location = New System.Drawing.Point(55, 60)
        Me.name_out.Name = "name_out"
        Me.name_out.ReadOnly = True
        Me.name_out.Size = New System.Drawing.Size(117, 20)
        Me.name_out.TabIndex = 5
        '
        'condiments_out
        '
        Me.condiments_out.Location = New System.Drawing.Point(256, 86)
        Me.condiments_out.Name = "condiments_out"
        Me.condiments_out.ReadOnly = True
        Me.condiments_out.Size = New System.Drawing.Size(117, 20)
        Me.condiments_out.TabIndex = 6
        '
        'cheese_out
        '
        Me.cheese_out.Location = New System.Drawing.Point(256, 60)
        Me.cheese_out.Name = "cheese_out"
        Me.cheese_out.ReadOnly = True
        Me.cheese_out.Size = New System.Drawing.Size(117, 20)
        Me.cheese_out.TabIndex = 7
        '
        'meat_out
        '
        Me.meat_out.Location = New System.Drawing.Point(55, 112)
        Me.meat_out.Name = "meat_out"
        Me.meat_out.ReadOnly = True
        Me.meat_out.Size = New System.Drawing.Size(117, 20)
        Me.meat_out.TabIndex = 8
        '
        'bread_out
        '
        Me.bread_out.Location = New System.Drawing.Point(55, 86)
        Me.bread_out.Name = "bread_out"
        Me.bread_out.ReadOnly = True
        Me.bread_out.Size = New System.Drawing.Size(117, 20)
        Me.bread_out.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(123, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Your Sandwich"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(361, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 163)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bread_out)
        Me.Controls.Add(Me.meat_out)
        Me.Controls.Add(Me.cheese_out)
        Me.Controls.Add(Me.condiments_out)
        Me.Controls.Add(Me.name_out)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Your Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents name_out As TextBox
    Friend WithEvents condiments_out As TextBox
    Friend WithEvents cheese_out As TextBox
    Friend WithEvents meat_out As TextBox
    Friend WithEvents bread_out As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
