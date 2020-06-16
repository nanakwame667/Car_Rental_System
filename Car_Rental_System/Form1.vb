Public Class Form1
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuLabel3_Click(sender As Object, e As EventArgs) Handles BunifuLabel3.Click

    End Sub

    Private Sub BunifuSeparator1_Load(sender As Object, e As EventArgs) Handles BunifuSeparator1.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        BunifuPages1.SetPage(0)


    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        BunifuPages1.SetPage(1)


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim oForm As New Form2()

        Me.Hide()
        oForm.ShowDialog()

        Me.Close()

    End Sub
End Class
