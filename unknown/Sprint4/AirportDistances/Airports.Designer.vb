<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Airports
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
        Me.ID1ComboBox = New System.Windows.Forms.ComboBox()
        Me.ID2ComboBox = New System.Windows.Forms.ComboBox()
        Me.City1TextBox = New System.Windows.Forms.TextBox()
        Me.City2TextBox = New System.Windows.Forms.TextBox()
        Me.Lat1TextBox = New System.Windows.Forms.TextBox()
        Me.Lon1TextBox = New System.Windows.Forms.TextBox()
        Me.Lat2TextBox = New System.Windows.Forms.TextBox()
        Me.Lon2TextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IDComboBox = New System.Windows.Forms.ComboBox()
        Me.CalcDistanceButton = New System.Windows.Forms.Button()
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plot_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ID1ComboBox
        '
        Me.ID1ComboBox.FormattingEnabled = True
        Me.ID1ComboBox.Location = New System.Drawing.Point(22, 31)
        Me.ID1ComboBox.Name = "ID1ComboBox"
        Me.ID1ComboBox.Size = New System.Drawing.Size(64, 21)
        Me.ID1ComboBox.TabIndex = 0
        '
        'ID2ComboBox
        '
        Me.ID2ComboBox.FormattingEnabled = True
        Me.ID2ComboBox.Location = New System.Drawing.Point(402, 31)
        Me.ID2ComboBox.Name = "ID2ComboBox"
        Me.ID2ComboBox.Size = New System.Drawing.Size(64, 21)
        Me.ID2ComboBox.TabIndex = 1
        '
        'City1TextBox
        '
        Me.City1TextBox.Location = New System.Drawing.Point(23, 69)
        Me.City1TextBox.Name = "City1TextBox"
        Me.City1TextBox.ReadOnly = True
        Me.City1TextBox.Size = New System.Drawing.Size(141, 20)
        Me.City1TextBox.TabIndex = 2
        '
        'City2TextBox
        '
        Me.City2TextBox.Location = New System.Drawing.Point(325, 69)
        Me.City2TextBox.Name = "City2TextBox"
        Me.City2TextBox.ReadOnly = True
        Me.City2TextBox.Size = New System.Drawing.Size(141, 20)
        Me.City2TextBox.TabIndex = 3
        Me.City2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lat1TextBox
        '
        Me.Lat1TextBox.Location = New System.Drawing.Point(22, 108)
        Me.Lat1TextBox.Name = "Lat1TextBox"
        Me.Lat1TextBox.ReadOnly = True
        Me.Lat1TextBox.Size = New System.Drawing.Size(107, 20)
        Me.Lat1TextBox.TabIndex = 4
        '
        'Lon1TextBox
        '
        Me.Lon1TextBox.Location = New System.Drawing.Point(22, 149)
        Me.Lon1TextBox.Name = "Lon1TextBox"
        Me.Lon1TextBox.ReadOnly = True
        Me.Lon1TextBox.Size = New System.Drawing.Size(107, 20)
        Me.Lon1TextBox.TabIndex = 5
        '
        'Lat2TextBox
        '
        Me.Lat2TextBox.Location = New System.Drawing.Point(359, 108)
        Me.Lat2TextBox.Name = "Lat2TextBox"
        Me.Lat2TextBox.ReadOnly = True
        Me.Lat2TextBox.Size = New System.Drawing.Size(107, 20)
        Me.Lat2TextBox.TabIndex = 8
        Me.Lat2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lon2TextBox
        '
        Me.Lon2TextBox.Location = New System.Drawing.Point(358, 149)
        Me.Lon2TextBox.Name = "Lon2TextBox"
        Me.Lon2TextBox.ReadOnly = True
        Me.Lon2TextBox.Size = New System.Drawing.Size(107, 20)
        Me.Lon2TextBox.TabIndex = 10
        Me.Lon2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(22, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'IDComboBox
        '
        Me.IDComboBox.FormattingEnabled = True
        Me.IDComboBox.Location = New System.Drawing.Point(22, 31)
        Me.IDComboBox.Name = "IDComboBox"
        Me.IDComboBox.Size = New System.Drawing.Size(64, 21)
        Me.IDComboBox.TabIndex = 0
        '
        'CalcDistanceButton
        '
        Me.CalcDistanceButton.Location = New System.Drawing.Point(194, 147)
        Me.CalcDistanceButton.Name = "CalcDistanceButton"
        Me.CalcDistanceButton.Size = New System.Drawing.Size(117, 51)
        Me.CalcDistanceButton.TabIndex = 13
        Me.CalcDistanceButton.Text = "Calculate Distance (miles)"
        Me.CalcDistanceButton.UseVisualStyleBackColor = True
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(194, 108)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.ReadOnly = True
        Me.DistanceTextBox.Size = New System.Drawing.Size(117, 20)
        Me.DistanceTextBox.TabIndex = 14
        Me.DistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Travel Distance Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'plot_btn
        '
        Me.plot_btn.BackColor = System.Drawing.SystemColors.Control
        Me.plot_btn.Enabled = False
        Me.plot_btn.Location = New System.Drawing.Point(312, 202)
        Me.plot_btn.Name = "plot_btn"
        Me.plot_btn.Size = New System.Drawing.Size(75, 23)
        Me.plot_btn.TabIndex = 16
        Me.plot_btn.Text = "View Map"
        Me.plot_btn.UseVisualStyleBackColor = False
        '
        'Airports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 266)
        Me.Controls.Add(Me.plot_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(Me.CalcDistanceButton)
        Me.Controls.Add(Me.Lon2TextBox)
        Me.Controls.Add(Me.Lat2TextBox)
        Me.Controls.Add(Me.Lon1TextBox)
        Me.Controls.Add(Me.Lat1TextBox)
        Me.Controls.Add(Me.City2TextBox)
        Me.Controls.Add(Me.City1TextBox)
        Me.Controls.Add(Me.ID2ComboBox)
        Me.Controls.Add(Me.ID1ComboBox)
        Me.Name = "Airports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents City1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents City2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lat1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lon1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lat2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lon2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CalcDistanceButton As System.Windows.Forms.Button
    Friend WithEvents DistanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents plot_btn As Button
End Class
