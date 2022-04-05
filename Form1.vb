Public Class Form1
    Dim harfler() As String = {"a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z"}
    Dim rakamlar() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim yazi = TextBox1.Text.Substring(0, TextBox1.Text.Length - 4)
        Dim rakam = TextBox1.Text.Substring(TextBox1.Text.Length - 4, 4)
        Dim sifre(yazi.Length + 3) As String
        Dim i As Integer
        Do While (i < yazi.Length)
            Dim j As Integer = 0
            Do While (j < harfler.Length)
                If j < 26 Then
                    If yazi.Substring(i, 1) = harfler(j) Then
                        TextBox2.Text += harfler(j + 3)
                        GoTo git
                    Else
                        j += 1
                    End If
                Else
                    Select Case j
                        Case 26
                            If yazi.Substring(i, 1) = harfler(j) Then
                                TextBox2.Text += harfler(0)
                                GoTo git
                            Else
                                j += 1
                            End If
                        Case 27
                            If yazi.Substring(i, 1) = harfler(j) Then
                                TextBox2.Text += harfler(1)
                                GoTo git
                            Else
                                j += 1
                            End If
                        Case 28
                            If yazi.Substring(i, 1) = harfler(j) Then
                                TextBox2.Text += harfler(2)
                                GoTo git
                            Else
                                j += 1
                            End If
                    End Select
                End If
            Loop
git:
            i += 1
        Loop
        i = 0
        Do While (i < rakam.Length)
            Dim j As Integer = 0
            Do While (j < rakamlar.Length)
                If j < 7 Then
                    If rakam.Substring(i, 1) = rakamlar(j) Then
                        TextBox2.Text += rakamlar(j + 3)
                        GoTo git2
                    Else
                        j += 1
                    End If
                Else
                    Select Case j
                        Case 7
                            If rakam.Substring(i, 1) = rakamlar(j) Then
                                TextBox2.Text += rakamlar(0)
                                GoTo git2
                            Else
                                j += 1
                            End If
                        Case 8
                            If rakam.Substring(i, 1) = rakamlar(j) Then
                                TextBox2.Text += rakamlar(1)
                                GoTo git2
                            Else
                                j += 1
                            End If
                        Case 9
                            If rakam.Substring(i, 1) = rakamlar(j) Then
                                TextBox2.Text += rakamlar(2)
                                GoTo git2
                            Else
                                j += 1
                            End If
                    End Select
                End If
            Loop
git2:
            i += 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim yazi = TextBox2.Text.Substring(0, TextBox2.Text.Length - 4)
        Dim rakam = TextBox2.Text.Substring(TextBox2.Text.Length - 4, 4)
        Dim sifre(yazi.Length + 3) As String
        Dim i As Integer
        Do While (i < yazi.Length)
            Dim j As Integer = 0
            Do While (j < harfler.Length)
                If j < 2 Then
                    Select Case j
                        Case 0
                            If yazi.Substring(i, 1) = harfler(j) Then
                                TextBox1.Text += harfler(26)
                                GoTo git3
                            Else
                                j += 1
                            End If
                        Case 1
                            If yazi.Substring(i, 1) = harfler(j) Then
                                TextBox1.Text += harfler(27)
                                GoTo git3
                            Else
                                j += 1
                            End If
                        Case 2
                            If yazi.Substring(i, 1) = harfler(j) Then
                                TextBox1.Text += harfler(28)
                                GoTo git3
                            Else
                                j += 1
                            End If
                    End Select
                Else
                    If yazi.Substring(i, 1) = harfler(j) Then
                        TextBox1.Text += harfler(j - 3)
                        GoTo git3
                    Else
                        j += 1
                    End If
                End If
            Loop
git3:
            i += 1
        Loop
        i = 0
        Do While (i < rakam.Length)
            Dim j As Integer = 0
            Do While (j < rakamlar.Length)
                If j > 2 Then
                    Select Case j
                        Case 0
                            If rakam.Substring(i, 1) = rakamlar(j) Then
                                TextBox1.Text += rakamlar(7)
                                GoTo git4
                            Else
                                j += 1
                            End If
                        Case 1
                            If rakam.Substring(i, 1) = rakamlar(j) Then
                                TextBox1.Text += rakamlar(8)
                                GoTo git4
                            Else
                                j += 1
                            End If
                        Case 2
                            If rakam.Substring(i, 1) = rakamlar(j) Then
                                TextBox1.Text += rakamlar(9)
                                GoTo git4
                            Else
                                j += 1
                            End If
                    End Select
                Else
                    If rakam.Substring(i, 1) = rakamlar(j) Then
                        TextBox1.Text += rakamlar(j - 3)
                        GoTo git4
                    Else
                        j += 1
                    End If
                End If
            Loop
git4:
            i += 1
        Loop
    End Sub
End Class
