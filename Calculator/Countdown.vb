Public Class Countdown
    Dim x As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static count As Integer = 10 'staticສະແດງຄົງທີ່
        If count > 0 Then
            count -= 1
            btcount.Text = count.ToString
        Else
            btcount.Text = "ນັບຖອຍຫຼັງ"
            count = 10
            Timer1.Enabled = False 'ບໍ່ໃຫ້ເຮັດວຽກຕໍ່ເນື້ອງ
        End If
    End Sub

    Private Sub btstart_Click(sender As Object, e As EventArgs) Handles btstart.Click
        'Dim x As Integer = 0
        'Static y As Integer = 0
        'TextBox1.Text = x
        'TextBox2.Text = y

        btcount.Text = 10 'ໃຫ້10ສະແດງໃນບັດຕອນ
        Timer1.Enabled = True 'Trueໃຫ້ມັນໃຊ້ໄດ້
    End Sub
End Class