Imports Microsoft.Office.Interop

Public Class frmAlumnos

    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistema_EscolarDataSet)

    End Sub

    Private Sub frm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistema_EscolarDataSet.alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter.Fill(Me.Sistema_EscolarDataSet.alumnos)
        AlumnosDataGridView.BackColor = Color.Bisque
        AlumnosDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige


    End Sub

    Private Sub frm1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize


        ' MsgBox("Se cambio el tamaño de la ventana")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()


    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Me.AlumnosTableAdapter.GUARDAR(Al_nombreTextBox.Text, Al_apellidoTextBox.Text, Al_fecha_nacDateTimePicker.Text, Al_lugar_nacTextBox.Text, Al_dniTextBox.Text, Al_domicilioTextBox.Text, Al_localidadTextBox.Text, Al_carreraTextBox.Text, Al_fecha_ingresoDateTimePicker.Text, Al_emailTextBox.Text, Al_telefonoTextBox.Text, Al_telefono2TextBox.Text, Al_cursoTextBox.Text)
            Me.AlumnosTableAdapter.Fill(Me.Sistema_EscolarDataSet.alumnos)
            frmMsg.Show()
            With frmMsg
                .BackColor = Color.Green
                .titulo.Text = "Guardado con exito!"
                .titulo.ForeColor = Color.Aqua
                .detalle.Text = "Los datos fueron guardaos exitosamente."
                .boton.Text = "OK"
            End With


        Catch ex As Exception
            MsgBox("Por favor, verifique los datos ingresados!", vbOKOnly + MsgBoxStyle.Information, "Error!")
        End Try



    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminar.Click
        Me.AlumnosTableAdapter.ELIMINAR(Id_alumnoTextBox.Text)
        Me.AlumnosTableAdapter.Fill(Me.Sistema_EscolarDataSet.alumnos)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles cmdNuevo.Click
        With Me
            .Id_alumnoTextBox.Enabled = True
            .Al_apellidoTextBox.Enabled = True
            .Al_carreraTextBox.Enabled = True
            .Al_cursoTextBox.Enabled = True
            .Al_dniTextBox.Enabled = True
            .Al_domicilioTextBox.Enabled = True
            .Al_emailTextBox.Enabled = True
            .Al_fecha_ingresoDateTimePicker.Enabled = True
            .Al_fecha_nacDateTimePicker.Enabled = True
            .Al_localidadTextBox.Enabled = True
            .Al_lugar_nacTextBox.Enabled = True
            .Al_nombreTextBox.Enabled = True
            .Al_telefono2TextBox.Enabled = True
            .Al_telefonoTextBox.Enabled = True
            .cmdGuardar.Enabled = True
            .cmdCancelar.Enabled = True
            .cmdEliminar.Enabled = True
            .cmdNuevo.Enabled = False


        End With
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        With Me
            .Id_alumnoTextBox.Enabled = False
            .Al_apellidoTextBox.Enabled = False
            .Al_carreraTextBox.Enabled = False
            .Al_cursoTextBox.Enabled = False
            .Al_dniTextBox.Enabled = False
            .Al_domicilioTextBox.Enabled = False
            .Al_emailTextBox.Enabled = False
            .Al_fecha_ingresoDateTimePicker.Enabled = False
            .Al_fecha_nacDateTimePicker.Enabled = False
            .Al_localidadTextBox.Enabled = False
            .Al_lugar_nacTextBox.Enabled = False
            .Al_nombreTextBox.Enabled = False
            .Al_telefono2TextBox.Enabled = False
            .Al_telefonoTextBox.Enabled = False
            .cmdGuardar.Enabled = False
            .cmdCancelar.Enabled = False
            .cmdEliminar.Enabled = False
            .cmdNuevo.Enabled = True
        End With
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        ' Cambiamos el cursor por el de carga
        Me.Cursor = Cursors.WaitCursor

        Try
            ' Creamos todo lo necesario para un excel
            Dim appXL As Excel.Application
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            Dim indice As Integer = 2
            appXL = CreateObject("Excel.Application")
            appXL.Visible = False 'Para que no se muestre mientras se crea
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            ' Añadimos las cabeceras de las columnas con formato en negrita
            ' Dim formatRange As Excel.Range
            'formatRange = shXL.Range("A1:C1", formatRange.EntireRow.Font.Bold = True)
            shXL.Range("A1").EntireRow.Font.Bold = True
            shXL.Cells(1, 1).Value = "LEGAJO"
            shXL.Cells(1, 2).Value = "NOMBRE"
            shXL.Cells(1, 3).Value = "APELLIDO"
            shXL.Cells(1, 4).Value = "FECHA NACIMIENTO"
            shXL.Cells(1, 5).Value = "LUGAR NACIMIENTO"
            shXL.Cells(1, 6).Value = "DNI"
            shXL.Cells(1, 7).Value = "DOMICILIO"
            shXL.Cells(1, 8).Value = "LOCALIDAD"
            shXL.Cells(1, 9).Value = "CARRERA"
            shXL.Cells(1, 10).Value = "FECHA DE INGRESO"
            shXL.Cells(1, 11).Value = "EMAIL"
            shXL.Cells(1, 12).Value = "TELEFONO"
            shXL.Cells(1, 13).Value = "TELEFONO 2"
            shXL.Cells(1, 14).Value = "CURSO"



            ' Conexión con la base de datos
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sistema Escolar.accdb"
            Dim conexion As New OleDb.OleDbConnection(connection)


            Dim s As String = ("SELECT * FROM alumnos")
            Dim myCommand As New OleDb.OleDbCommand(s)
            myCommand.Connection = conexion
            conexion.Open()
            Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

            While myReader.Read()
                ' Cargamos la información en el excel
                shXL.Cells(indice, 1).Value = myReader("id_alumno")
                shXL.Cells(indice, 2).Value = myReader("al_nombre")
                shXL.Cells(indice, 3).Value = myReader("al_apellido")
                shXL.Cells(indice, 4).Value = myReader("al_fecha_nac")
                shXL.Cells(indice, 5).Value = myReader("al_lugar_nac")
                shXL.Cells(indice, 6).Value = myReader("al_dni")
                shXL.Cells(indice, 7).Value = myReader("al_domicilio")
                shXL.Cells(indice, 8).Value = myReader("al_localidad")
                shXL.Cells(indice, 9).Value = myReader("al_carrera")
                shXL.Cells(indice, 10).Value = myReader("al_fecha_ingreso")
                shXL.Cells(indice, 11).Value = myReader("al_email")
                shXL.Cells(indice, 12).Value = myReader("al_telefono")
                shXL.Cells(indice, 13).Value = myReader("al_telefono2")
                shXL.Cells(indice, 14).Value = myReader("al_curso")
                indice += 1
            End While

            ' Mostramos un dialog para que el usuario indique donde quiere guardar el excel
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Title = "Guardar documento Excel"
            saveFileDialog1.Filter = "Excel File|*.xls"
            saveFileDialog1.FileName = "Usuarios_web"
            saveFileDialog1.ShowDialog()


            ' Guardamos el excel en la ruta que ha especificado el usuario
            wbXl.SaveAs(saveFileDialog1.FileName)
            MsgBox("Datos exportados con exito", MessageBoxIcon.Asterisk, MessageBoxButtons.OK)
            appXL.Workbooks.Close()
            'Eliminamos el objeto excel
            appXL.Quit()
        Catch ex As Exception
            MessageBox.Show("Error al exportar los datos a excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show(ex.Message)

        End Try
        ' Cerramos el workbook
        Me.Cursor = Cursors.Arrow
        
    End Sub
End Class