Public Class Form1
    Dim array(4) As Integer
    Dim str As String
    Dim arrayPoints = array.CreateInstance(GetType(Integer), New Integer() {3}, New Integer() {-1})

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        array(0) = 85
        array(1) = 70
        array(2) = 40
        array(3) = 80
        array(4) = 90

        arrayPoints(-1) = 87
        arrayPoints(0) = 80
        arrayPoints(1) = 90
    End Sub

    Private Sub Switch_Click(sender As Object, e As EventArgs) Handles Switch.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub length_negatif_Click(sender As Object, e As EventArgs) Handles length_negatif.Click
        For i As Integer = -1 To arrayPoints.Length - 2
            str &= "indeks array ke-(" & i & ") nilai = " & arrayPoints(i) & vbCrLf
        Next
        MessageBox.Show(str, "Array Indeks Negatif (Length)", MessageBoxButtons.OK)
        str = ""
    End Sub

    Private Sub GUB_Negatif_Click(sender As Object, e As EventArgs) Handles GUB_Negatif.Click
        For i As Integer = -1 To arrayPoints.getupperbound(0)
            str &= "indeks array ke-(" & i & " ) nilai = " & arrayPoints(i) & vbCrLf
        Next
        MessageBox.Show(str, "Array Indeks Negatif (GUB)", MessageBoxButtons.OK)
        str = ""
    End Sub

    Private Sub sisipkan_Click(sender As Object, e As EventArgs) Handles sisipkan.Click
        Dim a As Integer
        a = array.Length
        ReDim Preserve array(a)
        array(a) = CInt(TB_newAR.Text)
        a = array.Length + 1
    End Sub

    Private Sub isiData_Click(sender As Object, e As EventArgs) Handles isiData.Click
        Dim hari() As String = {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"}
        For i As Integer = 0 To Hari.getupperbound(0)
            CB_hari.Items.Add(Hari(i))
        Next
    End Sub

    Private Sub length_Click(sender As Object, e As EventArgs) Handles length.Click
        For i As Integer = 0 To array.Length - 1
            str &= "indeks array ke-(" & i & ") nilai = " & array(i) & vbCrLf
        Next
        MessageBox.Show(str, "Array Indeks Positif (Length)", MessageBoxButtons.OK)
        str = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To array.GetUpperBound(0)
            str &= "indeks array ke-(" & i & ") nilai = " & array(i) & vbCrLf
        Next
        MessageBox.Show(str, "Array Indeks Positif (GUB)", MessageBoxButtons.OK)
        str = ""
    End Sub

