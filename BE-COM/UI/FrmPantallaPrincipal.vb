﻿Public Class FrmPantallaPrincipal

    Private Sub FrmPantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fechaActual As DateTime = DateTime.Now()
    End Sub

    Private Sub FrmPantallaPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
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

        Dim frmMantenimientoUsuarios As Form = New FrmMantenimientoUsuarios(Me)
        frmMantenimientoUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnBecas_Click(sender As Object, e As EventArgs) Handles btnBecas.Click
        Dim frmMostrarTiposBeca As Form = New FrmMostrarTiposDeBeca(Me)
        frmMostrarTiposBeca.Show()

    End Sub
End Class
