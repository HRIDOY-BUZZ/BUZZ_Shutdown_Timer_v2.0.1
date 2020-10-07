Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("shutdown -s -t " & (Val(NumBox1.Text) * 60))
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Shell("shutdown -a")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.hridoy-buzz.blogspot.com")
    End Sub

    Private Sub NumBox1_ValueChanged(sender As Object, e As EventArgs) Handles NumBox1.ValueChanged

    End Sub
End Class
