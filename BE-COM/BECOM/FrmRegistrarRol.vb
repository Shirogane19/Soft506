Imports EntitiesLayer

Public Class FrmRegistrarRol

    Private Sub FrmRegistrarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each permiso As permiso In gestorPermiso.obtenerPermisos()
            LchkPermisos.Items.Add(permiso.Nombre())
        Next
    End Sub

    Private Sub FrmRegistrarRol_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        PopAgregado.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        PopMenu.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        PopAgregado.Show()

    End Sub

    Private Sub btnPermisos_Click(sender As Object, e As EventArgs)

        If mostrarPermisos() = True Then
            lblPermisos.Visible = True
            LchkPermisos.Visible = True
        Else
            lblPermisos.Visible = False
            LchkPermisos.Visible = False
        End If

    End Sub

    Private Function mostrarPermisos() As Boolean
        If lblPermisos.Visible = True Or LchkPermisos.Visible = True Then
            mostrarPermisos = False
        Else
            mostrarPermisos = True
        End If
    End Function

End Class