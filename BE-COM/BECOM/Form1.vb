Public Class FrmMenu

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Location = New Point(190, 13)'
        Dim fechaActual As DateTime = DateTime.Now()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub



    Private Sub btnCerrar_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmMenuUsuario.Show()
        Me.Hide()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub pnUsers_Click(sender As Object, e As EventArgs)
        FrmMenuUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub lblMinimizar_MouseHover(sender As Object, e As EventArgs)
        BackColor = Color.Gainsboro
    End Sub

    Private Sub lblMinimizar_MouseLeave(sender As Object, e As EventArgs)
        BackColor = Color.White
    End Sub


 
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        FrmAlumnos.Show()
        Me.Hide()

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        PopMenu.Show()

    End Sub




    Private Sub lblMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub






    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click

    End Sub

    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click

    End Sub

    Private Sub btnBecas_Click(sender As Object, e As EventArgs) Handles btnBecas.Click

    End Sub

    Private Sub btnAcademico_Click(sender As Object, e As EventArgs) Handles btnAcademico.Click

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAca_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnReportesM_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBecasM_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnusuariosM_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnOut_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs)

    End Sub

End Class
