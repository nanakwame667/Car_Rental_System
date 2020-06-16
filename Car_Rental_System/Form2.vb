Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuFormDock1.SubscribeControlToDragEvents(Panel1)
        BunifuFormDock1.SubscribeControlToDragEvents(Panel2)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(0)
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(1)
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(2)
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(3)
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        indicator.Top = (CType(sender, Control)).Top
        BunifuPages1.SetPage(4)
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        Application.[Exit]()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        Dim oForm1 As New Form1()

        Me.Hide()
        oForm1.ShowDialog()

        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub BunifuShadowPanel3_Paint(sender As Object, e As PaintEventArgs) Handles BunifuShadowPanel3.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTextBox7_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox7.TextChanged

    End Sub

    Private Sub BunifuButton20_Click(sender As Object, e As EventArgs) Handles BunifuButton20.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            BunifuPictureBox2.ImageLocation = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            BunifuPictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BunifuDropdown1_onItemSelected_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuDatepicker4_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker4.onValueChanged

    End Sub

    Private Sub BunifuTextBox14_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox14.TextChanged

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub BunifuSeparator5_Load(sender As Object, e As EventArgs) Handles BunifuSeparator5.Load

    End Sub
End Class