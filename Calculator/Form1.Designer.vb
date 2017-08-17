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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btbackspace = New System.Windows.Forms.Button()
        Me.btsub = New System.Windows.Forms.Button()
        Me.btplus = New System.Windows.Forms.Button()
        Me.btequal = New System.Windows.Forms.Button()
        Me.btmulti = New System.Windows.Forms.Button()
        Me.btdivide = New System.Windows.Forms.Button()
        Me.btclear = New System.Windows.Forms.Button()
        Me.bt9 = New System.Windows.Forms.Button()
        Me.bt8 = New System.Windows.Forms.Button()
        Me.bt7 = New System.Windows.Forms.Button()
        Me.bt6 = New System.Windows.Forms.Button()
        Me.bt5 = New System.Windows.Forms.Button()
        Me.bt4 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt0 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.txtdisplay)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 101)
        Me.Panel1.TabIndex = 0
        '
        'txtdisplay
        '
        Me.txtdisplay.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtdisplay.Location = New System.Drawing.Point(0, 0)
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(263, 20)
        Me.txtdisplay.TabIndex = 2
        Me.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Violet
        Me.Panel2.Location = New System.Drawing.Point(0, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 249)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Controls.Add(Me.btbackspace)
        Me.Panel3.Controls.Add(Me.btsub)
        Me.Panel3.Controls.Add(Me.btplus)
        Me.Panel3.Controls.Add(Me.btequal)
        Me.Panel3.Controls.Add(Me.btmulti)
        Me.Panel3.Controls.Add(Me.btdivide)
        Me.Panel3.Controls.Add(Me.btclear)
        Me.Panel3.Controls.Add(Me.bt9)
        Me.Panel3.Controls.Add(Me.bt8)
        Me.Panel3.Controls.Add(Me.bt7)
        Me.Panel3.Controls.Add(Me.bt6)
        Me.Panel3.Controls.Add(Me.bt5)
        Me.Panel3.Controls.Add(Me.bt4)
        Me.Panel3.Controls.Add(Me.bt3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.bt2)
        Me.Panel3.Controls.Add(Me.bt1)
        Me.Panel3.Controls.Add(Me.bt0)
        Me.Panel3.Location = New System.Drawing.Point(2, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(263, 246)
        Me.Panel3.TabIndex = 1
        '
        'btbackspace
        '
        Me.btbackspace.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btbackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbackspace.Location = New System.Drawing.Point(193, 43)
        Me.btbackspace.Name = "btbackspace"
        Me.btbackspace.Size = New System.Drawing.Size(64, 41)
        Me.btbackspace.TabIndex = 21
        Me.btbackspace.Text = "Backspace"
        Me.btbackspace.UseVisualStyleBackColor = False
        '
        'btsub
        '
        Me.btsub.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btsub.Location = New System.Drawing.Point(193, 83)
        Me.btsub.Name = "btsub"
        Me.btsub.Size = New System.Drawing.Size(64, 41)
        Me.btsub.TabIndex = 20
        Me.btsub.Text = "-"
        Me.btsub.UseVisualStyleBackColor = False
        '
        'btplus
        '
        Me.btplus.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btplus.Location = New System.Drawing.Point(193, 123)
        Me.btplus.Name = "btplus"
        Me.btplus.Size = New System.Drawing.Size(64, 41)
        Me.btplus.TabIndex = 19
        Me.btplus.Text = "+"
        Me.btplus.UseVisualStyleBackColor = False
        '
        'btequal
        '
        Me.btequal.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btequal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btequal.Location = New System.Drawing.Point(194, 163)
        Me.btequal.Name = "btequal"
        Me.btequal.Size = New System.Drawing.Size(64, 81)
        Me.btequal.TabIndex = 17
        Me.btequal.Text = "="
        Me.btequal.UseVisualStyleBackColor = False
        '
        'btmulti
        '
        Me.btmulti.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btmulti.Location = New System.Drawing.Point(130, 43)
        Me.btmulti.Name = "btmulti"
        Me.btmulti.Size = New System.Drawing.Size(64, 41)
        Me.btmulti.TabIndex = 16
        Me.btmulti.Text = "*"
        Me.btmulti.UseVisualStyleBackColor = False
        '
        'btdivide
        '
        Me.btdivide.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btdivide.Location = New System.Drawing.Point(67, 43)
        Me.btdivide.Name = "btdivide"
        Me.btdivide.Size = New System.Drawing.Size(64, 41)
        Me.btdivide.TabIndex = 15
        Me.btdivide.Text = "/"
        Me.btdivide.UseVisualStyleBackColor = False
        '
        'btclear
        '
        Me.btclear.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btclear.Location = New System.Drawing.Point(4, 43)
        Me.btclear.Name = "btclear"
        Me.btclear.Size = New System.Drawing.Size(64, 41)
        Me.btclear.TabIndex = 14
        Me.btclear.Text = "C"
        Me.btclear.UseVisualStyleBackColor = False
        '
        'bt9
        '
        Me.bt9.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt9.Location = New System.Drawing.Point(130, 83)
        Me.bt9.Name = "bt9"
        Me.bt9.Size = New System.Drawing.Size(64, 41)
        Me.bt9.TabIndex = 13
        Me.bt9.Text = "9"
        Me.bt9.UseVisualStyleBackColor = False
        '
        'bt8
        '
        Me.bt8.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt8.Location = New System.Drawing.Point(67, 83)
        Me.bt8.Name = "bt8"
        Me.bt8.Size = New System.Drawing.Size(64, 41)
        Me.bt8.TabIndex = 12
        Me.bt8.Text = "8"
        Me.bt8.UseVisualStyleBackColor = False
        '
        'bt7
        '
        Me.bt7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt7.Location = New System.Drawing.Point(4, 83)
        Me.bt7.Name = "bt7"
        Me.bt7.Size = New System.Drawing.Size(64, 41)
        Me.bt7.TabIndex = 11
        Me.bt7.Text = "7"
        Me.bt7.UseVisualStyleBackColor = False
        '
        'bt6
        '
        Me.bt6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt6.Location = New System.Drawing.Point(130, 123)
        Me.bt6.Name = "bt6"
        Me.bt6.Size = New System.Drawing.Size(64, 41)
        Me.bt6.TabIndex = 10
        Me.bt6.Text = "6"
        Me.bt6.UseVisualStyleBackColor = False
        '
        'bt5
        '
        Me.bt5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt5.Location = New System.Drawing.Point(67, 123)
        Me.bt5.Name = "bt5"
        Me.bt5.Size = New System.Drawing.Size(64, 41)
        Me.bt5.TabIndex = 9
        Me.bt5.Text = "5"
        Me.bt5.UseVisualStyleBackColor = False
        '
        'bt4
        '
        Me.bt4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt4.Location = New System.Drawing.Point(4, 123)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(64, 41)
        Me.bt4.TabIndex = 8
        Me.bt4.Text = "4"
        Me.bt4.UseVisualStyleBackColor = False
        '
        'bt3
        '
        Me.bt3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt3.Location = New System.Drawing.Point(131, 163)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(64, 41)
        Me.bt3.TabIndex = 7
        Me.bt3.Text = "3"
        Me.bt3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.Location = New System.Drawing.Point(131, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 41)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt2.Location = New System.Drawing.Point(68, 163)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(64, 41)
        Me.bt2.TabIndex = 5
        Me.bt2.Text = "2"
        Me.bt2.UseVisualStyleBackColor = False
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt1.Location = New System.Drawing.Point(5, 163)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(64, 41)
        Me.bt1.TabIndex = 4
        Me.bt1.Text = "1"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'bt0
        '
        Me.bt0.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bt0.Location = New System.Drawing.Point(4, 203)
        Me.bt0.Name = "bt0"
        Me.bt0.Size = New System.Drawing.Size(128, 41)
        Me.bt0.TabIndex = 0
        Me.bt0.Text = "0"
        Me.bt0.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 356)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtdisplay As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bt1 As Button
    Friend WithEvents bt0 As Button
    Friend WithEvents btbackspace As Button
    Friend WithEvents btsub As Button
    Friend WithEvents btplus As Button
    Friend WithEvents btequal As Button
    Friend WithEvents btmulti As Button
    Friend WithEvents btdivide As Button
    Friend WithEvents btclear As Button
    Friend WithEvents bt9 As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents bt7 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bt2 As Button
End Class
