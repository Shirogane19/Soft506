Imports EntitiesLayer

Public Class FrmRegistrarRol
    Dim formAnterior As Form
    Dim listaDatos As List(Of Boolean)

    Public Sub New(pformAnterior As Form)
        formAnterior = pformAnterior
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmRegistrarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each permiso As Permiso In gestorPermiso.obtenerPermisos()
            LchkPermisos.Items.Add(permiso.Nombre())
        Next

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Function mostrarPermisos() As Boolean
        If lblPermisos.Visible = True Or LchkPermisos.Visible = True Then
            mostrarPermisos = False
        Else
            mostrarPermisos = True
        End If
    End Function

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        For Each validacion As Label In Me.pnFormulario.Controls.OfType(Of Label)()
            If IsNumeric(validacion.Tag) = True Then
                If validacion.Image.Equals(campoIncorrecto) Then
                    MsgBox("Existen campos incorrectos")
                End If
            End If
        Next


        Dim permisosSeleccionados As List(Of Integer) = New List(Of Integer)

        For Each permisoSeleccionado As Integer In LchkPermisos.CheckedIndices
            permisosSeleccionados.Add(permisoSeleccionado)
        Next

    End Sub

    Private Sub validarCampoFormulario()
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If validaciones.validarCamposTexto(txtNombre) = True Then
            lblNombreV.Image = campoCorrecto
            lblNombreV.Visible = True
        Else
            lblNombreV.Image = campoIncorrecto
            lblNombreV.Visible = True
        End If
    End Sub

    Private Sub rctDescripcion_Leave(sender As Object, e As EventArgs) Handles rctDescripcion.Leave
        If validaciones.validarCamposTexto(rctDescripcion) = True Then
            lblDescripcionV.Image = campoCorrecto
            lblDescripcionV.Visible = True
        Else
            lblDescripcionV.Image = campoIncorrecto
            lblDescripcionV.Visible = True
        End If
    End Sub
End Class