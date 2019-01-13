Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'boton salir'
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'boton limpia todos los campos'
        ex.Clear()
        pmax.Clear()
        p.Clear()
        nota.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'boton limpia solo campo puntaje alumno'
        p.Clear()
    End Sub

    Private Sub operacion()
        'formula 1'

        nota.Text = 3 * Val(p.Text) / (Val(ex.Text) * Val(pmax.Text)) + 1


    End Sub
    Private Sub operacion2()
        'formula 2'
        nota.Text = 3 * (Val(p.Text) - Val(ex.Text) * Val(pmax.Text)) / (Val(pmax.Text) * (1 - Val(ex.Text))) + 4

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'decide que operacion hacer en relacion si exigencia x puntaje max es menor o mayor de el puntaje del alumno'

        Dim sexo As Double
        sexo = Val(ex.Text) * Val(pmax.Text)

        If Val(p.Text) < sexo Then
            operacion()
        Else
            operacion2()
        End If


    End Sub


End Class