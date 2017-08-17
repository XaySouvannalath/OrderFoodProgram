Public Class TimePicker
    Private Sub TimePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timep.CustomFormat = "dd/MM/yyyy"
        timep.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub timep_ValueChanged(sender As Object, e As EventArgs) Handles timep.ValueChanged
        Label1.Text = timep.Text
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        MessageBox.Show("ເຈົ້າເກີດວັນທີ: " & timep.Text)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'If RadioButton1.Checked = True Then
        '    timep.
        'End If
    End Sub
End Class