Public Class frmMenu

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        frmAlumnos.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        frmAlumnos.Show()
        frmAlumnos.cmdSalir.Visible = False
        frmAlumnos.cmdGuardar.Visible = False
        frmAlumnos.cmdEliminar.Visible = False
        frmAlumnos.cmdNuevo.Visible = False
        frmAlumnos.cmdCancelar.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseHover

    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        frmProfesores.Show()
        Me.Hide()
    End Sub
End Class
