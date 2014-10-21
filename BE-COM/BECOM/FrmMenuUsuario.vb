Public Class FrmMenuUsuario

    Private Sub FrmMenuUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub FrmMenuUsuario_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub ptrAtras_Click(sender As Object, e As EventArgs) Handles ptrAtras.Click
        Me.Hide()
        FrmMenu.Show()
    End Sub



    Private Sub btnMin_Click_1(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnEstudiantes_Click(sender As Object, e As EventArgs) Handles btnEstudiantes.Click
        Me.Hide()
        FrmAlumnos.Show()
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Me.Hide()
        FrmAgregarUsuario.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        PopMenu.Show()
    End Sub
End Class