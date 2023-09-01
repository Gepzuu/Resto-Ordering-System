Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim f2home As New f2home

        f2home.MdiParent = Me
        f2home.Show()
    End Sub

    Private Sub HowToOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToOrderToolStripMenuItem.Click
        Dim f3about As New f3about

        f3about.MdiParent = Me
        f3about.Show()
    End Sub

    Private Sub DrinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrinksToolStripMenuItem.Click
        Dim f8drinks As New f8drinks

        f8drinks.MdiParent = Me
        f8drinks.Show()
    End Sub

    Private Sub SushiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SushiToolStripMenuItem.Click
        Dim f4sushi As New f4sushi

        f4sushi.MdiParent = Me
        f4sushi.Show()
    End Sub

    Private Sub RamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RamenToolStripMenuItem.Click
        Dim f5ramen As New f5ramen

        f5ramen.MdiParent = Me
        f5ramen.Show()
    End Sub

    Private Sub SaladToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaladToolStripMenuItem.Click
        Dim f6salad As New f6salad

        f6salad.MdiParent = Me
        f6salad.Show()
    End Sub
End Class
