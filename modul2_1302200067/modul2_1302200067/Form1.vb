Public Class Form1
    Friend Hasil As Single = 0
    Dim operasi As String = ""
    Dim operasiHitung As Boolean = False
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles output.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "4"
            operasiHitung = False
        Else
            output.Text = output.Text + "4"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operasiHitung = False
        operasi = ""
        Hasil = 0
        output.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "1"
            operasiHitung = False
        Else
            output.Text = output.Text + "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "2"
            operasiHitung = False
        Else
            output.Text = output.Text + "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "3"
            operasiHitung = False
        Else
            output.Text = output.Text + "3"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "5"
            operasiHitung = False
        Else
            output.Text = output.Text + "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "6"
            operasiHitung = False
        Else
            output.Text = output.Text + "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "7"
            operasiHitung = False
        Else
            output.Text = output.Text + "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "8"
            operasiHitung = False
        Else
            output.Text = output.Text + "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "9"
            operasiHitung = False
        Else
            output.Text = output.Text + "9"
        End If
    End Sub

    Private Sub nol_Click(sender As Object, e As EventArgs) Handles nol.Click
        If operasiHitung = True Or output.Text = "0" Then
            output.Text = "0"
            operasiHitung = False
        Else
            output.Text = output.Text + "0"
        End If
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        operasi = "tambah"
        Hasil = Val(output.Text)
        operasiHitung = True
    End Sub

    Private Sub samadengan_Click(sender As Object, e As EventArgs) Handles samadengan.Click
        Select Case operasi
            Case "tambah"
                Hasil = Hasil + Val(output.Text)
        End Select
        output.Text = Hasil
        operasiHitung = True
    End Sub
End Class
