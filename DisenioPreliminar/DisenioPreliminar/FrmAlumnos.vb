Public Class FrmAlumnos

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmAlumnos_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim List = New List(Of String)
        List.Add("Mauricio")
        gridMostrarAlumnos.DataSource = List

    End Sub

  
    Private Sub gridMostrarAlumnos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridMostrarAlumnos.CellMouseEnter
        gridMostrarAlumnos.RowsDefaultCellStyle.SelectionBackColor = Color.Purple
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmAgregarUsuario.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        FrmMenuUsuario.Show()
    End Sub


  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmAgregarUsuario.Show()
        Me.Hide()
    End Sub
End Class