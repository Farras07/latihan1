Public Class Form2
    Dim data(,) As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim data(100, 3)
    End Sub
    Dim i As Integer
    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        data(i, 0) = npm.Text
        data(i, 1) = nama.Text
        Dim tempGender As String
        If laki.Checked Then
            tempGender = "Laki-laki"
        ElseIf wanita.Checked Then
            tempGender = "Wanita"
        End If
        data(i, 2) = tempGender
        data(i, 3) = Telp.Text
        i = +1
        LV.Items.Clear()

        For a As Integer = 0 To data.GetUpperBound(0)
            LV.Items.Add(data(a, 0))
            LV.Items(LV.Items.Count - 1).SubItems.Add(data(a, 1))
            LV.Items(LV.Items.Count - 1).SubItems.Add(data(a, 2))
            LV.Items(LV.Items.Count - 1).SubItems.Add(data(a, 3))

        Next

    End Sub
    Dim temp As String
    Dim str As String
    Private Sub tampil_Click(sender As Object, e As EventArgs) Handles tampil.Click
        temp = data.GetUpperBound(1) + 1
        ReDim Preserve data(100, temp)
        data(0, temp) = "UPNVJT"
        str = data(0, 0) & " " & data(0, 1) & " " & data(0, 2) & " " & data(0, 3) & " " & data(0, 4) & " ;" & vbCrLf &
            data(1, 0) & " " & data(1, 1) & " " & data(1, 2) & " " & data(1, 3) & " " & data(1, 4)
        MsgBox(str)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = data(0, 0) & " " & data(0, 1) & " " & data(0, 2) & " " & data(0, 3) & " ;" & vbCrLf &
            data(1, 0) & " " & data(1, 1) & " " & data(1, 2) & " " & data(1, 3)
        MsgBox(str)
    End Sub
End Class