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

    Private Sub ex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ex.KeyPress

        'permite solo numeros y puntos en textbox'

        Dim keyascii As Short = Asc(e.KeyChar)
        If InStr("0123456789.", Chr(keyascii)) = 0 Then
            If keyascii <> 8 Then
                keyascii = 0
            End If
            e.KeyChar = Chr(keyascii)
            If keyascii = 0 Then
                e.Handled = True
                MsgBox("ingresa un numero valido")
            End If
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ex.Focus()

    End Sub

    Private Sub pmax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pmax.KeyPress

        'permite solo numeros y puntos en textbox'

        Dim keyascii As Short = Asc(e.KeyChar)
        If InStr("0123456789.", Chr(keyascii)) = 0 Then
            If keyascii <> 8 Then
                keyascii = 0
            End If
            e.KeyChar = Chr(keyascii)
            If keyascii = 0 Then
                e.Handled = True
                MsgBox("ingresa un numero valido")
            End If
        End If




    End Sub

    Private Sub p_KeyPress(sender As Object, e As KeyPressEventArgs) Handles p.KeyPress

        'permite solo numeros y puntos en textbox'

        Dim keyascii As Short = Asc(e.KeyChar)
        If InStr("0123456789.", Chr(keyascii)) = 0 Then
            If keyascii <> 8 Then
                keyascii = 0
            End If
            e.KeyChar = Chr(keyascii)
            If keyascii = 0 Then
                e.Handled = True
                MsgBox("ingresa un numero valido")
            End If
        End If
    End Sub

    Private Sub nota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nota.KeyPress

        'permite solo numeros y puntos en textbox'

        Dim keyascii As Short = Asc(e.KeyChar)
        If InStr("0123456789.", Chr(keyascii)) = 0 Then
            If keyascii <> 8 Then
                keyascii = 0
            End If
            e.KeyChar = Chr(keyascii)
            If keyascii = 0 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class