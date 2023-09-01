Public Class print
    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.Document = PrintDocument1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()

        End If

        preview.Text = ""
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("**************************************************************************************" + vbCrLf)

        preview.AppendText(vbTab + vbTab + vbTab + vbTab & "Receipt" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText(vbTab + "Name : " + vbTab + TextBox1.Text + vbTab + vbTab + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText(vbTab + "Address : " + vbTab & TextBox2.Text + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText(vbTab + "Phone Number : " + vbTab & TextBox3.Text + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText("" + vbCrLf)
        preview.AppendText(vbTab + "Mode of Payment : " + vbTab & ComboBox1.Text + vbCrLf)

        preview.AppendText("**************************************************************************************" + vbCrLf)

        preview.AppendText(vbTab + "Comment : " + vbTab & textcomment.Text + vbCrLf)


        preview.AppendText("``````````````````````````````````````````````````````````````````````````````" + vbCrLf)
        preview.AppendText(vbTab + vbTab + vbTab + "Thank you for ordering..." + vbCrLf)
        preview.AppendText("                                Contact Us: giornogiornogmail.net                         " + vbCrLf)
        preview.AppendText("``````````````````````````````````````````````````````````````````````````````" + vbCrLf)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Trebuchet MS", 12, FontStyle.Bold)

        e.Graphics.DrawString(preview.Text, font, Brushes.Crimson, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox3.Image, 120, 130, PictureBox3.Width - 15, PictureBox3.Height - 25)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If textcomment.Text + TextBox1.Text + TextBox2.Text = "" Then
            MsgBox("Please Write Something...")

        Else
            PrintPreviewDialog1.ShowDialog()
        End If

    End Sub


End Class