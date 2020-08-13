Public Class Form1

    Private Sub tombolLempar_Click(sender As Object, e As EventArgs) Handles tombolLempar.Click
        Dim intSisiAtas As Integer  'untuk mengindikasikan sisi mana yang di atas
        Dim rand As New Random      'pembangkit nilai Random

        'menghasilkan nilai acak dalam rentang 0 sampai 1
        '0 berarti ekor di atas, dan 1 berarti kepala di atas
        intSisiAtas = rand.Next(2)

        'menampilkan sisi yang di atas
        If intSisiAtas = 0 Then
            '1 berarti ekor di atas, jadi menampilkan citra
            'ekor dan menyembunyikan citra kepala
            gbrEkor.Visible = True
            gbrKepala.Visible = False
        Else
            '1 berarti kepala di atas, jadi menampilkan citra
            'kepala dan menyembunyikan citra ekor
            gbrKepala.Visible = True
            gbrEkor.Visible = False
        End If
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
