<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.p = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pmax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ex = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nota = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'p
        '
        Me.p.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p.Location = New System.Drawing.Point(443, 124)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(151, 30)
        Me.p.TabIndex = 5
        Me.p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Puntaje Alumno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Puntaje Maximo"
        '
        'pmax
        '
        Me.pmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pmax.Location = New System.Drawing.Point(443, 88)
        Me.pmax.Name = "pmax"
        Me.pmax.Size = New System.Drawing.Size(151, 30)
        Me.pmax.TabIndex = 4
        Me.pmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(285, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Exigencia"
        '
        'ex
        '
        Me.ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ex.Location = New System.Drawing.Point(443, 52)
        Me.ex.Name = "ex"
        Me.ex.Size = New System.Drawing.Size(151, 30)
        Me.ex.TabIndex = 3
        Me.ex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nota"
        '
        'nota
        '
        Me.nota.Enabled = False
        Me.nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nota.Location = New System.Drawing.Point(443, 160)
        Me.nota.MaxLength = 3
        Me.nota.Name = "nota"
        Me.nota.ReadOnly = True
        Me.nota.Size = New System.Drawing.Size(151, 30)
        Me.nota.TabIndex = 10
        Me.nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(481, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 40)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Calcular"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(39, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 169)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(343, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Borrar "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 397)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pmax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escala de Notas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents p As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pmax As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ex As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nota As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
