Public Class Form1
    Dim A As String = ""
    Dim B As String = ""
    Dim op As String = ""

    Private Sub affiche_TextChanged(sender As Object, e As EventArgs) Handles txt_affiche.TextChanged

    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If op = "" Then
            A = A + "0"
        Else B = B + "0"

        End If
        txt_affiche.Text = A + "" + op + "" + B
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"

        End If
        txt_affiche.text = A + " " + op + " " + B
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        txt_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        txt_affiche.Text = ""
    End Sub

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click
        If Not A = "" Then
            op = "+"
        End If
        txt_affiche.text = A + " " + op + " " + B
    End Sub

    Private Sub Btn__Click(sender As Object, e As EventArgs) Handles Btn_.Click
        If Not A = "" Then
            op = "-"
        End If
        txt_affiche.text = A + " " + op + " " + B
    End Sub

    Private Sub Btn_fois_Click(sender As Object, e As EventArgs) Handles Btn_fois.Click
        If Not A = "" Then
            op = "*"
        End If
        txt_affiche.text = A + " " + op + " " + B
    End Sub

    Private Sub Btn_sur_Click(sender As Object, e As EventArgs) Handles Btn_sur.Click
        If Not A = "" Then
            op = "/"
        End If
        txt_affiche.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = va / vb
            Else
                MessageBox.Show("Division par 0")
                test = False

            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers")
            test = False
        End If
        If test Then
            txt_affiche.text = txt_affiche.Text + "=" + res.ToString
        End If
    End Sub
End Class
