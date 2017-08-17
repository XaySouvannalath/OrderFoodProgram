Public Class PictureBoxLearn
    Private Sub PictureBoxLearn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb.Items.Add("First Picture")
        lb.Items.Add("Second Picture")
        lb.Items.Add("Third Picture")

    End Sub

    Private Sub lb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb.SelectedIndexChanged
        If lb.SelectedIndex = 0 Then
            PictureBox1.Image = My.Resources._12884503_808704242607208_251536593_n
        ElseIf lb.SelectedIndex = 1 Then
            PictureBox1.Image = My.Resources._12900242_808704249273874_1064583677_n
        ElseIf lb.SelectedIndex = 2 Then
            PictureBox1.Image = My.Resources._12921113_808704272607205_591365588_n


        End If
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton1.ValueChanged
        If SwitchButton1.SwitchClickTogglesValue = True Then
            MsgBox("You OPen")
            SwitchButton1.SwitchClickTogglesValue = False
        ElseIf SwitchButton1.SwitchClickTogglesValue = False Then
            MsgBox("you have turn off!")
            SwitchButton1.SwitchClickTogglesValue = True
        End If
    End Sub

    Private Sub BubbleButton1_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton1.Click

    End Sub
End Class