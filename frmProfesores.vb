Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop


Public Class frmProfesores

    Private Sub ProfesoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProfesoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfesoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistema_EscolarDataSet)



    End Sub

    Private Sub frmProfesores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistema_EscolarDataSet.profesores' table. You can move, or remove it, as needed.
        Me.ProfesoresTableAdapter.Fill(Me.Sistema_EscolarDataSet.profesores)
        ProfesoresDataGridView.BackColor = Color.Bisque
        ProfesoresDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ProfesoresDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProfesoresDataGridView.CellContentClick

    End Sub


    Private Sub button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

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
            'Dim formatRange As Excel.Range
            'formatRange = shXL.Range("A1:C1", formatRange.EntireRow.Font.Bold = True)
            shXL.Range("A1").EntireRow.Font.Bold = True
            shXL.Cells(1, 1).Value = "NOMBRE"
            shXL.Cells(1, 2).Value = "APELLIDOS"
            shXL.Cells(1, 3).Value = "EDAD"
            shXL.Cells(1, 4).Value = "POBLACIÓN"
            shXL.Cells(1, 5).Value = "PROVINCIA"
            shXL.Cells(1, 6).Value = "DIRECCIÓN"
            shXL.Cells(1, 7).Value = "ESTADO"
            shXL.Cells(1, 8).Value = "NIF"

            ' Conexión con la base de datos
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sistema Escolar.accdb"
            Dim conexion As New OleDb.OleDbConnection(connection)


            Dim s As String = ("SELECT * FROM profesores")
            Dim myCommand As New OleDb.OleDbCommand(s)
            myCommand.Connection = conexion
            conexion.Open()
            Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

            While myReader.Read()
                ' Cargamos la información en el excel
                shXL.Cells(indice, 1).Value = myReader("LEGAJO")
                shXL.Cells(indice, 2).Value = myReader("APELLIDOS")
                shXL.Cells(indice, 3).Value = myReader("EDAD")
                shXL.Cells(indice, 4).Value = myReader("POBLACION")
                shXL.Cells(indice, 5).Value = myReader("PROVINCIA")
                shXL.Cells(indice, 6).Value = myReader("DIRECCION")
                shXL.Cells(indice, 7).Value = myReader("ESTADO")
                shXL.Cells(indice, 8).Value = myReader("NIF")
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
        Catch ex As Exception
            MessageBox.Show("Error al exportar los datos a excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        ' Cerramos el workbook

        Me.Cursor = Cursors.Arrow



    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

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
            'Dim formatRange As Excel.Range
            'formatRange = shXL.Range("A1:C1", formatRange.EntireRow.Font.Bold = True)
            shXL.Range("A1").EntireRow.Font.Bold = True
            shXL.Cells(1, 1).Value = "NOMBRE"
            shXL.Cells(1, 2).Value = "APELLIDOS"
            shXL.Cells(1, 3).Value = "EDAD"
            shXL.Cells(1, 4).Value = "POBLACIÓN"
            shXL.Cells(1, 5).Value = "PROVINCIA"
            shXL.Cells(1, 6).Value = "DIRECCIÓN"
            shXL.Cells(1, 7).Value = "ESTADO"
            shXL.Cells(1, 8).Value = "NIF"

            ' Conexión con la base de datos
            Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sistema Escolar.accdb"
            Dim conexion As New OleDb.OleDbConnection(connection)


            Dim s As String = ("SELECT * FROM profesores")
            Dim myCommand As New OleDb.OleDbCommand(s)
            myCommand.Connection = conexion
            conexion.Open()
            Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

            While myReader.Read()
                ' Cargamos la información en el excel
                ' cambiamos "legajo", "apellido", etc por el nombre de cada campo en la tabla. 
                shXL.Cells(indice, 1).Value = myReader("LEGAJO")
                shXL.Cells(indice, 2).Value = myReader("APELLIDOS")
                shXL.Cells(indice, 3).Value = myReader("EDAD")
                shXL.Cells(indice, 4).Value = myReader("POBLACION")
                shXL.Cells(indice, 5).Value = myReader("PROVINCIA")
                shXL.Cells(indice, 6).Value = myReader("DIRECCION")
                shXL.Cells(indice, 7).Value = myReader("ESTADO")
                shXL.Cells(indice, 8).Value = myReader("NIF")
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
        Catch ex As Exception
            MessageBox.Show("Error al exportar los datos a excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(Err.Description)

        End Try
        ' Cerramos el workbook

        Me.Cursor = Cursors.Arrow


    End Sub

    Private Sub cmdNuevo_Click(sender As System.Object, e As System.EventArgs) Handles cmdNuevo.Click
        With Me
            .Id_profesorTextBox.Enabled = True
            .Pr_apellidoTextBox.Enabled = True
            .Pr_sexoTextBox.Enabled = True
            .Pr_tituloTextBox.Enabled = True
            .Pr_domicilioTextBox.Enabled = True
            .Pr_mailTextBox.Enabled = True
            .Pr_titulo2TextBox.Enabled = True
            .Pr_fecha_nacDateTimePicker.Enabled = True
            .Pr_localidadTextBox.Enabled = True
            .Pr_lugar_nacTextBox.Enabled = True
            .Pr_nombreTextBox.Enabled = True
            .Pr_perfilTextBox.Enabled = True
            .Pr_horas_cargoTextBox.Enabled = True
            .Pr_dniTextBox.Enabled = True
            .cmdGuardar.Enabled = True
            .cmdCancelar.Enabled = True
            .cmdEliminar.Enabled = True
            .cmdNuevo.Enabled = False


        End With
    End Sub

    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        With Me
            .Id_profesorTextBox.Enabled = False
            .Pr_apellidoTextBox.Enabled = False
            .Pr_sexoTextBox.Enabled = False
            .Pr_tituloTextBox.Enabled = False
            .Pr_domicilioTextBox.Enabled = False
            .Pr_mailTextBox.Enabled = False
            .Pr_titulo2TextBox.Enabled = False
            .Pr_fecha_nacDateTimePicker.Enabled = False
            .Pr_localidadTextBox.Enabled = False
            .Pr_lugar_nacTextBox.Enabled = False
            .Pr_nombreTextBox.Enabled = False
            .Pr_perfilTextBox.Enabled = False
            .Pr_horas_cargoTextBox.Enabled = False
            .Pr_dniTextBox.Enabled = False
            .cmdGuardar.Enabled = False
            .cmdCancelar.Enabled = False
            .cmdEliminar.Enabled = False
            .cmdNuevo.Enabled = True
        End With
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        If Pr_horas_cargoTextBox.Text = "" Then Pr_horas_cargoTextBox.Text = "0"

        Try
            Me.ProfesoresTableAdapter.GUARDAR(Pr_nombreTextBox.Text, Pr_apellidoTextBox.Text, Pr_fecha_nacDateTimePicker.Text, Pr_lugar_nacTextBox.Text, Pr_localidadTextBox.Text, Pr_domicilioTextBox.Text, Pr_dniTextBox.Text, Pr_perfilTextBox.Text, Pr_sexoTextBox.Text, Pr_tituloTextBox.Text, Pr_titulo2TextBox.Text, Pr_mailTextBox.Text, Pr_horas_cargoTextBox.Text)
            Me.ProfesoresTableAdapter.Fill(Me.Sistema_EscolarDataSet.profesores)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class