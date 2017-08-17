<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimePicker
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
        Me.timep = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btsave = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'timep
        '
        Me.timep.Location = New System.Drawing.Point(52, 47)
        Me.timep.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.timep.Name = "timep"
        Me.timep.Size = New System.Drawing.Size(298, 34)
        Me.timep.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(415, 48)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(132, 32)
        Me.btsave.TabIndex = 2
        Me.btsave.Text = "ບັນທຶກ"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(97, 156)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(116, 31)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 299)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.timep)
        Me.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "TimePicker"
        Me.Text = "TimePicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timep As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btsave As Button
    Friend WithEvents RadioButton1 As RadioButton
End Class
