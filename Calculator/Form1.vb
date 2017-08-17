Public Class Form1

    Dim Num1, num2 As Integer
    Dim status As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        txtdisplay.Text = txtdisplay.Text + bt1.Text


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bt2.Click
        txtdisplay.Text = txtdisplay.Text + bt2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bt3.Click
        txtdisplay.Text = txtdisplay.Text + bt3.Text
    End Sub

    Private Sub btplus_Click(sender As Object, e As EventArgs) Handles btplus.Click
        Num1 = txtdisplay.Text
        status = "plus"
        txtdisplay.Text = ""


    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        txtdisplay.Text = txtdisplay.Text + bt4.Text

    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        txtdisplay.Text = txtdisplay.Text + bt5.Text
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        txtdisplay.Text = txtdisplay.Text + bt6.Text
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        txtdisplay.Text = txtdisplay.Text + bt7.Text
    End Sub

    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        txtdisplay.Text = txtdisplay.Text + bt8.Text
    End Sub

    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        txtdisplay.Text = txtdisplay.Text + bt9.Text
    End Sub

    Private Sub btsub_Click(sender As Object, e As EventArgs) Handles btsub.Click
        Num1 = txtdisplay.Text
        status = "sub"
        txtdisplay.Text = ""
    End Sub

    Private Sub btmulti_Click(sender As Object, e As EventArgs) Handles btmulti.Click
        Num1 = txtdisplay.Text
        status = "multiply"
        txtdisplay.Text = ""
    End Sub

    Private Sub btdivide_Click(sender As Object, e As EventArgs) Handles btdivide.Click
        Num1 = txtdisplay.Text
        status = "divide"
        txtdisplay.Text = ""


    End Sub

    Private Sub btclear_Click(sender As Object, e As EventArgs) Handles btclear.Click
        txtdisplay.Text = ""
        txtdisplay.Focus()

    End Sub

    Private Sub btbackspace_Click(sender As Object, e As EventArgs) Handles btbackspace.Click
        'If txtdisplay.Text < "" Then
        '    txtdisplay.Text = Mid(txtdisplay.Text, 1, Len(txtdisplay.Text) - 1 + 1)
        ' Else
        If txtdisplay.Text = "" Then

            txtdisplay.Text = ""
            Exit Sub

        End If
        txtdisplay.Text = Mid(txtdisplay.Text, 1, Len(txtdisplay.Text) - 1)
       ' End If

    End Sub

    Private Sub btequal_Click(sender As Object, e As EventArgs) Handles btequal.Click
        num2 = txtdisplay.Text
        Select Case status
            Case "plus"
                txtdisplay.Text = Num1 + num2
            Case "sub"
                txtdisplay.Text = Num1 - num2
            Case "multiply"
                txtdisplay.Text = Num1 * num2
            Case "divide"
                txtdisplay.Text = Num1 / num2

        End Select
    End Sub


End Class
