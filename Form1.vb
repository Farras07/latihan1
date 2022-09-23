Public Class Form1
    Dim array(4) As Integer
    Dim str As String
    Dim arrayPoints = array.CreateInstance(GetType(Integer), New Integer() {3}, New Integer() {-1})
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        array(0) = 85
        array(1) = 70
        array(2) = 40
        array(3) = 80
        array(4) = 90
    End Sub

    Private Sub CB_hari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_hari.SelectedIndexChanged
    End Sub

    Private Sub Switch_Click(sender As Object, e As EventArgs) Handles Switch.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub length_negatif_Click(sender As Object, e As EventArgs) Handles length_negatif.Click

    End Sub
End Class
