<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Countdown
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
        Me.btstart = New System.Windows.Forms.Button()
        Me.btcount = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btstart
        '
        Me.btstart.Location = New System.Drawing.Point(421, 75)
        Me.btstart.Name = "btstart"
        Me.btstart.Size = New System.Drawing.Size(136, 105)
        Me.btstart.TabIndex = 0
        Me.btstart.Text = "Start"
        Me.btstart.UseVisualStyleBackColor = True
        '
        'btcount
        '
        Me.btcount.Location = New System.Drawing.Point(113, 75)
        Me.btcount.Name = "btcount"
        Me.btcount.Size = New System.Drawing.Size(162, 67)
        Me.btcount.TabIndex = 1
        Me.btcount.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 171)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 34)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 232)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 34)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label1"
        '
        'Countdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 280)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btcount)
        Me.Controls.Add(Me.btstart)
        Me.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Countdown"
        Me.Text = "Countdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btstart As Button
    Friend WithEvents btcount As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
