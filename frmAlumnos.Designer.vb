<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_alumnoLabel As System.Windows.Forms.Label
        Dim Al_nombreLabel As System.Windows.Forms.Label
        Dim Al_apellidoLabel As System.Windows.Forms.Label
        Dim Al_fecha_nacLabel As System.Windows.Forms.Label
        Dim Al_lugar_nacLabel As System.Windows.Forms.Label
        Dim Al_dniLabel As System.Windows.Forms.Label
        Dim Al_domicilioLabel As System.Windows.Forms.Label
        Dim Al_localidadLabel As System.Windows.Forms.Label
        Dim Al_carreraLabel As System.Windows.Forms.Label
        Dim Al_fecha_ingresoLabel As System.Windows.Forms.Label
        Dim Al_emailLabel As System.Windows.Forms.Label
        Dim Al_telefonoLabel As System.Windows.Forms.Label
        Dim Al_telefono2Label As System.Windows.Forms.Label
        Dim Al_cursoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AlumnosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sistema_EscolarDataSet = New aCopiar.Sistema_EscolarDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlumnosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Id_alumnoTextBox = New System.Windows.Forms.TextBox()
        Me.Al_nombreTextBox = New System.Windows.Forms.TextBox()
        Me.Al_apellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Al_fecha_nacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Al_lugar_nacTextBox = New System.Windows.Forms.TextBox()
        Me.Al_dniTextBox = New System.Windows.Forms.TextBox()
        Me.Al_domicilioTextBox = New System.Windows.Forms.TextBox()
        Me.Al_localidadTextBox = New System.Windows.Forms.TextBox()
        Me.Al_carreraTextBox = New System.Windows.Forms.TextBox()
        Me.Al_fecha_ingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Al_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Al_telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Al_telefono2TextBox = New System.Windows.Forms.TextBox()
        Me.Al_cursoTextBox = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlumnosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AlumnosTableAdapter = New aCopiar.Sistema_EscolarDataSetTableAdapters.alumnosTableAdapter()
        Me.TableAdapterManager = New aCopiar.Sistema_EscolarDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Id_alumnoLabel = New System.Windows.Forms.Label()
        Al_nombreLabel = New System.Windows.Forms.Label()
        Al_apellidoLabel = New System.Windows.Forms.Label()
        Al_fecha_nacLabel = New System.Windows.Forms.Label()
        Al_lugar_nacLabel = New System.Windows.Forms.Label()
        Al_dniLabel = New System.Windows.Forms.Label()
        Al_domicilioLabel = New System.Windows.Forms.Label()
        Al_localidadLabel = New System.Windows.Forms.Label()
        Al_carreraLabel = New System.Windows.Forms.Label()
        Al_fecha_ingresoLabel = New System.Windows.Forms.Label()
        Al_emailLabel = New System.Windows.Forms.Label()
        Al_telefonoLabel = New System.Windows.Forms.Label()
        Al_telefono2Label = New System.Windows.Forms.Label()
        Al_cursoLabel = New System.Windows.Forms.Label()
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlumnosBindingNavigator.SuspendLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistema_EscolarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_alumnoLabel
        '
        Id_alumnoLabel.AutoSize = True
        Id_alumnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_alumnoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Id_alumnoLabel.Location = New System.Drawing.Point(63, 7)
        Id_alumnoLabel.Name = "Id_alumnoLabel"
        Id_alumnoLabel.Size = New System.Drawing.Size(49, 13)
        Id_alumnoLabel.TabIndex = 1
        Id_alumnoLabel.Text = "Legajo:"
        '
        'Al_nombreLabel
        '
        Al_nombreLabel.AutoSize = True
        Al_nombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_nombreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_nombreLabel.Location = New System.Drawing.Point(415, 6)
        Al_nombreLabel.Name = "Al_nombreLabel"
        Al_nombreLabel.Size = New System.Drawing.Size(60, 13)
        Al_nombreLabel.TabIndex = 3
        Al_nombreLabel.Text = "Nombres:"
        '
        'Al_apellidoLabel
        '
        Al_apellidoLabel.AutoSize = True
        Al_apellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_apellidoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_apellidoLabel.Location = New System.Drawing.Point(699, 7)
        Al_apellidoLabel.Name = "Al_apellidoLabel"
        Al_apellidoLabel.Size = New System.Drawing.Size(56, 13)
        Al_apellidoLabel.TabIndex = 5
        Al_apellidoLabel.Text = "Apellido:"
        '
        'Al_fecha_nacLabel
        '
        Al_fecha_nacLabel.AutoSize = True
        Al_fecha_nacLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_fecha_nacLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_fecha_nacLabel.Location = New System.Drawing.Point(1, 44)
        Al_fecha_nacLabel.Name = "Al_fecha_nacLabel"
        Al_fecha_nacLabel.Size = New System.Drawing.Size(111, 13)
        Al_fecha_nacLabel.TabIndex = 7
        Al_fecha_nacLabel.Text = "Fecha nacimiento:"
        '
        'Al_lugar_nacLabel
        '
        Al_lugar_nacLabel.AutoSize = True
        Al_lugar_nacLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_lugar_nacLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_lugar_nacLabel.Location = New System.Drawing.Point(367, 40)
        Al_lugar_nacLabel.Name = "Al_lugar_nacLabel"
        Al_lugar_nacLabel.Size = New System.Drawing.Size(108, 13)
        Al_lugar_nacLabel.TabIndex = 9
        Al_lugar_nacLabel.Text = "Lugar nacimiento:"
        '
        'Al_dniLabel
        '
        Al_dniLabel.AutoSize = True
        Al_dniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_dniLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_dniLabel.Location = New System.Drawing.Point(722, 43)
        Al_dniLabel.Name = "Al_dniLabel"
        Al_dniLabel.Size = New System.Drawing.Size(33, 13)
        Al_dniLabel.TabIndex = 11
        Al_dniLabel.Text = "DNI:"
        '
        'Al_domicilioLabel
        '
        Al_domicilioLabel.AutoSize = True
        Al_domicilioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_domicilioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_domicilioLabel.Location = New System.Drawing.Point(54, 79)
        Al_domicilioLabel.Name = "Al_domicilioLabel"
        Al_domicilioLabel.Size = New System.Drawing.Size(58, 13)
        Al_domicilioLabel.TabIndex = 13
        Al_domicilioLabel.Text = "Domicilio"
        '
        'Al_localidadLabel
        '
        Al_localidadLabel.AutoSize = True
        Al_localidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_localidadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_localidadLabel.Location = New System.Drawing.Point(413, 76)
        Al_localidadLabel.Name = "Al_localidadLabel"
        Al_localidadLabel.Size = New System.Drawing.Size(62, 13)
        Al_localidadLabel.TabIndex = 15
        Al_localidadLabel.Text = "Localidad"
        '
        'Al_carreraLabel
        '
        Al_carreraLabel.AutoSize = True
        Al_carreraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_carreraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_carreraLabel.Location = New System.Drawing.Point(703, 76)
        Al_carreraLabel.Name = "Al_carreraLabel"
        Al_carreraLabel.Size = New System.Drawing.Size(52, 13)
        Al_carreraLabel.TabIndex = 17
        Al_carreraLabel.Text = "Carrera:"
        '
        'Al_fecha_ingresoLabel
        '
        Al_fecha_ingresoLabel.AutoSize = True
        Al_fecha_ingresoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_fecha_ingresoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_fecha_ingresoLabel.Location = New System.Drawing.Point(21, 116)
        Al_fecha_ingresoLabel.Name = "Al_fecha_ingresoLabel"
        Al_fecha_ingresoLabel.Size = New System.Drawing.Size(91, 13)
        Al_fecha_ingresoLabel.TabIndex = 19
        Al_fecha_ingresoLabel.Text = "Fecha ingreso:"
        '
        'Al_emailLabel
        '
        Al_emailLabel.AutoSize = True
        Al_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_emailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_emailLabel.Location = New System.Drawing.Point(431, 116)
        Al_emailLabel.Name = "Al_emailLabel"
        Al_emailLabel.Size = New System.Drawing.Size(44, 13)
        Al_emailLabel.TabIndex = 21
        Al_emailLabel.Text = "e-mail:"
        '
        'Al_telefonoLabel
        '
        Al_telefonoLabel.AutoSize = True
        Al_telefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_telefonoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_telefonoLabel.Location = New System.Drawing.Point(403, 161)
        Al_telefonoLabel.Name = "Al_telefonoLabel"
        Al_telefonoLabel.Size = New System.Drawing.Size(72, 13)
        Al_telefonoLabel.TabIndex = 23
        Al_telefonoLabel.Text = "Telefono 2:"
        '
        'Al_telefono2Label
        '
        Al_telefono2Label.AutoSize = True
        Al_telefono2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_telefono2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_telefono2Label.Location = New System.Drawing.Point(51, 158)
        Al_telefono2Label.Name = "Al_telefono2Label"
        Al_telefono2Label.Size = New System.Drawing.Size(61, 13)
        Al_telefono2Label.TabIndex = 25
        Al_telefono2Label.Text = "Telefono:"
        '
        'Al_cursoLabel
        '
        Al_cursoLabel.AutoSize = True
        Al_cursoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Al_cursoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Al_cursoLabel.Location = New System.Drawing.Point(712, 112)
        Al_cursoLabel.Name = "Al_cursoLabel"
        Al_cursoLabel.Size = New System.Drawing.Size(43, 13)
        Al_cursoLabel.TabIndex = 27
        Al_cursoLabel.Text = "Curso:"
        '
        'AlumnosBindingNavigator
        '
        Me.AlumnosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AlumnosBindingNavigator.BindingSource = Me.AlumnosBindingSource
        Me.AlumnosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AlumnosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AlumnosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AlumnosBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.AlumnosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AlumnosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AlumnosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AlumnosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AlumnosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AlumnosBindingNavigator.Name = "AlumnosBindingNavigator"
        Me.AlumnosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AlumnosBindingNavigator.Size = New System.Drawing.Size(1190, 25)
        Me.AlumnosBindingNavigator.TabIndex = 0
        Me.AlumnosBindingNavigator.Text = "BindingNavigator1"
        Me.AlumnosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.Sistema_EscolarDataSet
        '
        'Sistema_EscolarDataSet
        '
        Me.Sistema_EscolarDataSet.DataSetName = "Sistema_EscolarDataSet"
        Me.Sistema_EscolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AlumnosBindingNavigatorSaveItem
        '
        Me.AlumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlumnosBindingNavigatorSaveItem.Image = CType(resources.GetObject("AlumnosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AlumnosBindingNavigatorSaveItem.Name = "AlumnosBindingNavigatorSaveItem"
        Me.AlumnosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AlumnosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Id_alumnoTextBox
        '
        Me.Id_alumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Id_alumno", True))
        Me.Id_alumnoTextBox.Enabled = False
        Me.Id_alumnoTextBox.Location = New System.Drawing.Point(133, 4)
        Me.Id_alumnoTextBox.Name = "Id_alumnoTextBox"
        Me.Id_alumnoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_alumnoTextBox.TabIndex = 1
        '
        'Al_nombreTextBox
        '
        Me.Al_nombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_nombre", True))
        Me.Al_nombreTextBox.Enabled = False
        Me.Al_nombreTextBox.Location = New System.Drawing.Point(474, 3)
        Me.Al_nombreTextBox.Name = "Al_nombreTextBox"
        Me.Al_nombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_nombreTextBox.TabIndex = 2
        '
        'Al_apellidoTextBox
        '
        Me.Al_apellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_apellido", True))
        Me.Al_apellidoTextBox.Enabled = False
        Me.Al_apellidoTextBox.Location = New System.Drawing.Point(774, 4)
        Me.Al_apellidoTextBox.Name = "Al_apellidoTextBox"
        Me.Al_apellidoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_apellidoTextBox.TabIndex = 3
        '
        'Al_fecha_nacDateTimePicker
        '
        Me.Al_fecha_nacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnosBindingSource, "al_fecha_nac", True))
        Me.Al_fecha_nacDateTimePicker.Enabled = False
        Me.Al_fecha_nacDateTimePicker.Location = New System.Drawing.Point(133, 40)
        Me.Al_fecha_nacDateTimePicker.Name = "Al_fecha_nacDateTimePicker"
        Me.Al_fecha_nacDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Al_fecha_nacDateTimePicker.TabIndex = 4
        '
        'Al_lugar_nacTextBox
        '
        Me.Al_lugar_nacTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_lugar_nac", True))
        Me.Al_lugar_nacTextBox.Enabled = False
        Me.Al_lugar_nacTextBox.Location = New System.Drawing.Point(474, 37)
        Me.Al_lugar_nacTextBox.Name = "Al_lugar_nacTextBox"
        Me.Al_lugar_nacTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_lugar_nacTextBox.TabIndex = 5
        '
        'Al_dniTextBox
        '
        Me.Al_dniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_dni", True))
        Me.Al_dniTextBox.Enabled = False
        Me.Al_dniTextBox.Location = New System.Drawing.Point(774, 40)
        Me.Al_dniTextBox.Name = "Al_dniTextBox"
        Me.Al_dniTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_dniTextBox.TabIndex = 6
        '
        'Al_domicilioTextBox
        '
        Me.Al_domicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_domicilio", True))
        Me.Al_domicilioTextBox.Enabled = False
        Me.Al_domicilioTextBox.Location = New System.Drawing.Point(133, 76)
        Me.Al_domicilioTextBox.Name = "Al_domicilioTextBox"
        Me.Al_domicilioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_domicilioTextBox.TabIndex = 7
        '
        'Al_localidadTextBox
        '
        Me.Al_localidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_localidad", True))
        Me.Al_localidadTextBox.Enabled = False
        Me.Al_localidadTextBox.Location = New System.Drawing.Point(474, 73)
        Me.Al_localidadTextBox.Name = "Al_localidadTextBox"
        Me.Al_localidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_localidadTextBox.TabIndex = 8
        '
        'Al_carreraTextBox
        '
        Me.Al_carreraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_carrera", True))
        Me.Al_carreraTextBox.Enabled = False
        Me.Al_carreraTextBox.Location = New System.Drawing.Point(774, 73)
        Me.Al_carreraTextBox.Name = "Al_carreraTextBox"
        Me.Al_carreraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_carreraTextBox.TabIndex = 9
        '
        'Al_fecha_ingresoDateTimePicker
        '
        Me.Al_fecha_ingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnosBindingSource, "al_fecha_ingreso", True))
        Me.Al_fecha_ingresoDateTimePicker.Enabled = False
        Me.Al_fecha_ingresoDateTimePicker.Location = New System.Drawing.Point(133, 113)
        Me.Al_fecha_ingresoDateTimePicker.Name = "Al_fecha_ingresoDateTimePicker"
        Me.Al_fecha_ingresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Al_fecha_ingresoDateTimePicker.TabIndex = 10
        '
        'Al_emailTextBox
        '
        Me.Al_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_email", True))
        Me.Al_emailTextBox.Enabled = False
        Me.Al_emailTextBox.Location = New System.Drawing.Point(474, 113)
        Me.Al_emailTextBox.Name = "Al_emailTextBox"
        Me.Al_emailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_emailTextBox.TabIndex = 11
        '
        'Al_telefonoTextBox
        '
        Me.Al_telefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_telefono", True))
        Me.Al_telefonoTextBox.Enabled = False
        Me.Al_telefonoTextBox.Location = New System.Drawing.Point(474, 158)
        Me.Al_telefonoTextBox.Name = "Al_telefonoTextBox"
        Me.Al_telefonoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_telefonoTextBox.TabIndex = 14
        '
        'Al_telefono2TextBox
        '
        Me.Al_telefono2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_telefono2", True))
        Me.Al_telefono2TextBox.Enabled = False
        Me.Al_telefono2TextBox.Location = New System.Drawing.Point(133, 155)
        Me.Al_telefono2TextBox.Name = "Al_telefono2TextBox"
        Me.Al_telefono2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_telefono2TextBox.TabIndex = 13
        '
        'Al_cursoTextBox
        '
        Me.Al_cursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "al_curso", True))
        Me.Al_cursoTextBox.Enabled = False
        Me.Al_cursoTextBox.Location = New System.Drawing.Point(774, 109)
        Me.Al_cursoTextBox.Name = "Al_cursoTextBox"
        Me.Al_cursoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Al_cursoTextBox.TabIndex = 12
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1190, 516)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = -6
        Me.LineShape3.X2 = 1241
        Me.LineShape3.Y1 = 280
        Me.LineShape3.Y2 = 280
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 5
        Me.LineShape2.X2 = 95
        Me.LineShape2.Y1 = 77
        Me.LineShape2.Y2 = 77
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 220
        Me.LineShape1.X2 = 1197
        Me.LineShape1.Y1 = 77
        Me.LineShape1.Y2 = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(96, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'AlumnosDataGridView
        '
        Me.AlumnosDataGridView.AllowUserToAddRows = False
        Me.AlumnosDataGridView.AllowUserToDeleteRows = False
        Me.AlumnosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlumnosDataGridView.AutoGenerateColumns = False
        Me.AlumnosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlumnosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.AlumnosDataGridView.DataSource = Me.AlumnosBindingSource
        Me.AlumnosDataGridView.Location = New System.Drawing.Point(13, 288)
        Me.AlumnosDataGridView.Name = "AlumnosDataGridView"
        Me.AlumnosDataGridView.ReadOnly = True
        Me.AlumnosDataGridView.RowTemplate.Height = 18
        Me.AlumnosDataGridView.Size = New System.Drawing.Size(1090, 220)
        Me.AlumnosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_alumno"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "al_nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRES"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "al_apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "al_fecha_nac"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FECHA NAC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "al_lugar_nac"
        Me.DataGridViewTextBoxColumn5.HeaderText = "LUGAR NAC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "al_dni"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "al_domicilio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DOMICILIO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "al_localidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LOCALIDAD"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "al_carrera"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CARRERA"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "al_fecha_ingreso"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FECHA INGRESO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "al_email"
        Me.DataGridViewTextBoxColumn11.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "al_telefono"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TELEFONO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "al_telefono2"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TELEFONO 2"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "al_curso"
        Me.DataGridViewTextBoxColumn14.HeaderText = "CURSO"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdNuevo)
        Me.Panel1.Controls.Add(Me.cmdEliminar)
        Me.Panel1.Controls.Add(Me.cmdGuardar)
        Me.Panel1.Controls.Add(Al_cursoLabel)
        Me.Panel1.Controls.Add(Me.Al_cursoTextBox)
        Me.Panel1.Controls.Add(Al_telefono2Label)
        Me.Panel1.Controls.Add(Me.Al_telefono2TextBox)
        Me.Panel1.Controls.Add(Al_fecha_ingresoLabel)
        Me.Panel1.Controls.Add(Al_telefonoLabel)
        Me.Panel1.Controls.Add(Me.Al_telefonoTextBox)
        Me.Panel1.Controls.Add(Al_emailLabel)
        Me.Panel1.Controls.Add(Me.Al_emailTextBox)
        Me.Panel1.Controls.Add(Me.Al_fecha_ingresoDateTimePicker)
        Me.Panel1.Controls.Add(Al_carreraLabel)
        Me.Panel1.Controls.Add(Me.Al_carreraTextBox)
        Me.Panel1.Controls.Add(Al_localidadLabel)
        Me.Panel1.Controls.Add(Me.Al_localidadTextBox)
        Me.Panel1.Controls.Add(Al_domicilioLabel)
        Me.Panel1.Controls.Add(Me.Al_domicilioTextBox)
        Me.Panel1.Controls.Add(Al_dniLabel)
        Me.Panel1.Controls.Add(Me.Al_dniTextBox)
        Me.Panel1.Controls.Add(Al_lugar_nacLabel)
        Me.Panel1.Controls.Add(Me.Al_lugar_nacTextBox)
        Me.Panel1.Controls.Add(Al_fecha_nacLabel)
        Me.Panel1.Controls.Add(Me.Al_fecha_nacDateTimePicker)
        Me.Panel1.Controls.Add(Al_apellidoLabel)
        Me.Panel1.Controls.Add(Me.Al_apellidoTextBox)
        Me.Panel1.Controls.Add(Al_nombreLabel)
        Me.Panel1.Controls.Add(Me.Al_nombreTextBox)
        Me.Panel1.Controls.Add(Id_alumnoLabel)
        Me.Panel1.Controls.Add(Me.Id_alumnoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(3, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 188)
        Me.Panel1.TabIndex = 31
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(1026, 121)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 34)
        Me.cmdCancelar.TabIndex = 18
        Me.cmdCancelar.Text = "          CANCELAR"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(1026, 83)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(104, 34)
        Me.cmdNuevo.TabIndex = 17
        Me.cmdNuevo.Text = "     NUEVO"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.Location = New System.Drawing.Point(1026, 45)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(104, 34)
        Me.cmdEliminar.TabIndex = 16
        Me.cmdEliminar.Text = "          ELIMINAR"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(1026, 7)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(104, 34)
        Me.cmdGuardar.TabIndex = 15
        Me.cmdGuardar.Text = "           GUARDAR "
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(1128, 481)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(59, 32)
        Me.cmdSalir.TabIndex = 19
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.carrerasTableAdapter = Nothing
        Me.TableAdapterManager.profesoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = aCopiar.Sistema_EscolarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1109, 301)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'frmAlumnos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1190, 516)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AlumnosDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlumnosBindingNavigator)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm1"
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlumnosBindingNavigator.ResumeLayout(False)
        Me.AlumnosBindingNavigator.PerformLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistema_EscolarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sistema_EscolarDataSet As aCopiar.Sistema_EscolarDataSet
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As aCopiar.Sistema_EscolarDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents TableAdapterManager As aCopiar.Sistema_EscolarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlumnosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlumnosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_alumnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_nombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_apellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_fecha_nacDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Al_lugar_nacTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_dniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_domicilioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_localidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_carreraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_fecha_ingresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Al_emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_telefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_telefono2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Al_cursoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents AlumnosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
