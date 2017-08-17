Public Class Some_part_of_Homework
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btorder.Click
        listorder.Items.Clear()
        If combotype.SelectedIndex = 0 Then
            listorder.Items.Add("ປະເພດ: " & combotype.Text)
        ElseIf combotype.SelectedIndex = 1 Then
            listorder.Items.Add("ປະເພດ: " & combotype.Text)
        ElseIf combotype.SelectedIndex = 2 Then
            listorder.Items.Add("ປະເພດ: " & combotype.Text)
        ElseIf combotype.SelectedIndex = 3 Then
            listorder.Items.Add("ປະເພດ: " & combotype.Text)
        End If
        'Radio Button
        '----------------------------------------------------
        If rbbig.Checked = True Then
            listorder.Items.Add("ຂະໜາດ: " & rbbig.Text)
        ElseIf rbmiddle.Checked = True Then
            listorder.Items.Add("ຂະໜາດ: " & rbmiddle.Text)
        ElseIf rbsmall.Checked = True Then
            listorder.Items.Add("ຂະໜາດ: " & rbsmall.Text)
        End If
        '----------------------------------------------------
        'Checkbox
        '-------------------------------------------------------
        listorder.Items.Add("ຜັກຫອມ ແລະ ເຄື່ອງເທດ:")
        If cbhormbua.Checked = True Then
            listorder.Items.Add("     -" & cbhormbua.Text)
        End If
        If cbhormporm.Checked = True Then
            listorder.Items.Add("     -" & cbhormporm.Text)
        End If
        If cbkathiam.Checked = True Then
            listorder.Items.Add("     -" & cbkathiam.Text)
        End If
        If cbmarkphik.Checked = True Then
            listorder.Items.Add("     -" & cbmarkphik.Text)
        End If
        If cbthuangork.Checked = True Then
            listorder.Items.Add("     -" & cbthuangork.Text)
        End If
    End Sub

    Private Sub Some_part_of_Homework_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub btselect_Click(sender As Object, e As EventArgs) Handles btselect.Click
        If btselect.Text = "ເລືອກທັງໝົດ" Then
            cbhormbua.Checked = True
            cbhormporm.Checked = True
            cbkathiam.Checked = True
            cbmarkphik.Checked = True
            cbthuangork.Checked = True
            btselect.Text = "ຍົກເລີກທັງໝົດ"
        ElseIf btselect.Text = "ຍົກເລີກທັງໝົດ" Then
            cbhormbua.Checked = False
            cbhormporm.Checked = False
            cbkathiam.Checked = False
            cbmarkphik.Checked = False
            cbthuangork.Checked = False
            btselect.Text = "ເລືອກທັງໝົດ"
        End If
    End Sub

    Private Sub btcancel_Click(sender As Object, e As EventArgs) Handles btcancel.Click
        listorder.Items.Clear()

    End Sub
End Class