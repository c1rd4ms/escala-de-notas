Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ex.KeyPress

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles p.KeyPress



    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nota.KeyPress

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pmax.KeyPress

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ex.Clear()
        pmax.Clear()
        p.Clear()
        nota.Clear()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        p.Clear()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub operacion()

        nota.Text = 3 * Val(p.Text) / (Val(ex.Text) * Val(pmax.Text)) + 1



    End Sub
    Private Sub operacion2()

        nota.Text = 3 * (Val(p.Text) - Val(ex.Text) * Val(pmax.Text)) / (Val(pmax.Text) * (1 - Val(ex.Text))) + 4

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sexo As Double
        sexo = Val(ex.Text) * Val(pmax.Text)

        If Val(p.Text) < sexo Then
            operacion()
        Else
            operacion2()
        End If


    End Sub

    Private Sub nota_TextChanged(sender As Object, e As EventArgs) Handles nota.TextChanged

    End Sub
End Class