Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim firstnum As Integer
        Dim secondnum As Integer

        firstnum = txtFirstnum.Text
        secondnum = txtSecondnum.Text

        lblResult.Text = firstnum * secondnum



    End Sub
End Class
