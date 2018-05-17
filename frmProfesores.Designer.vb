<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfesores
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
        Dim Id_profesorLabel As System.Windows.Forms.Label
        Dim Pr_nombreLabel As System.Windows.Forms.Label
        Dim Pr_apellidoLabel As System.Windows.Forms.Label
        Dim Pr_fecha_nacLabel As System.Windows.Forms.Label
        Dim Pr_lugar_nacLabel As System.Windows.Forms.Label
        Dim Pr_localidadLabel As System.Windows.Forms.Label
        Dim Pr_domicilioLabel As System.Windows.Forms.Label
        Dim Pr_dniLabel As System.Windows.Forms.Label
        Dim Pr_perfilLabel As System.Windows.Forms.Label
        Dim Pr_sexoLabel As System.Windows.Forms.Label
        Dim Pr_tituloLabel As System.Windows.Forms.Label
        Dim Pr_titulo2Label As System.Windows.Forms.Label
        Dim Pr_mailLabel As System.Windows.Forms.Label
        Dim Pr_horas_cargoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfesores))
        Me.ProfesoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ProfesoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProfesoresDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pr_horas_cargoTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_titulo2TextBox = New System.Windows.Forms.TextBox()
        Me.Pr_tituloTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_sexoTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_perfilTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_dniTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_domicilioTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_localidadTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_lugar_nacTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_fecha_nacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Pr_apellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_nombreTextBox = New System.Windows.Forms.TextBox()
        Me.Id_profesorTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProfesoresTableAdapter = New aCopiar.Sistema_EscolarDataSetTableAdapters.profesoresTableAdapter()
        Me.TableAdapterManager = New aCopiar.Sistema_EscolarDataSetTableAdapters.TableAdapterManager()
        Id_profesorLabel = New System.Windows.Forms.Label()
        Pr_nombreLabel = New System.Windows.Forms.Label()
        Pr_apellidoLabel = New System.Windows.Forms.Label()
        Pr_fecha_nacLabel = New System.Windows.Forms.Label()
        Pr_lugar_nacLabel = New System.Windows.Forms.Label()
        Pr_localidadLabel = New System.Windows.Forms.Label()
        Pr_domicilioLabel = New System.Windows.Forms.Label()
        Pr_dniLabel = New System.Windows.Forms.Label()
        Pr_perfilLabel = New System.Windows.Forms.Label()
        Pr_sexoLabel = New System.Windows.Forms.Label()
        Pr_tituloLabel = New System.Windows.Forms.Label()
        Pr_titulo2Label = New System.Windows.Forms.Label()
        Pr_mailLabel = New System.Windows.Forms.Label()
        Pr_horas_cargoLabel = New System.Windows.Forms.Label()
        CType(Me.ProfesoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfesoresBindingNavigator.SuspendLayout()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistema_EscolarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_profesorLabel
        '
        Id_profesorLabel.AutoSize = True
        Id_profesorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Id_profesorLabel.Location = New System.Drawing.Point(35, 21)
        Id_profesorLabel.Name = "Id_profesorLabel"
        Id_profesorLabel.Size = New System.Drawing.Size(60, 13)
        Id_profesorLabel.TabIndex = 33
        Id_profesorLabel.Text = "Id profesor:"
        '
        'Pr_nombreLabel
        '
        Pr_nombreLabel.AutoSize = True
        Pr_nombreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_nombreLabel.Location = New System.Drawing.Point(230, 21)
        Pr_nombreLabel.Name = "Pr_nombreLabel"
        Pr_nombreLabel.Size = New System.Drawing.Size(57, 13)
        Pr_nombreLabel.TabIndex = 34
        Pr_nombreLabel.Text = "pr nombre:"
        '
        'Pr_apellidoLabel
        '
        Pr_apellidoLabel.AutoSize = True
        Pr_apellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_apellidoLabel.Location = New System.Drawing.Point(433, 21)
        Pr_apellidoLabel.Name = "Pr_apellidoLabel"
        Pr_apellidoLabel.Size = New System.Drawing.Size(58, 13)
        Pr_apellidoLabel.TabIndex = 35
        Pr_apellidoLabel.Text = "pr apellido:"
        '
        'Pr_fecha_nacLabel
        '
        Pr_fecha_nacLabel.AutoSize = True
        Pr_fecha_nacLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_fecha_nacLabel.Location = New System.Drawing.Point(621, 19)
        Pr_fecha_nacLabel.Name = "Pr_fecha_nacLabel"
        Pr_fecha_nacLabel.Size = New System.Drawing.Size(70, 13)
        Pr_fecha_nacLabel.TabIndex = 36
        Pr_fecha_nacLabel.Text = "pr fecha nac:"
        '
        'Pr_lugar_nacLabel
        '
        Pr_lugar_nacLabel.AutoSize = True
        Pr_lugar_nacLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Pr_lugar_nacLabel.Location = New System.Drawing.Point(29, 52)
        Pr_lugar_nacLabel.Name = "Pr_lugar_nacLabel"
        Pr_lugar_nacLabel.Size = New System.Drawing.Size(66, 13)
        Pr_lugar_nacLabel.TabIndex = 37
        Pr_lugar_nacLabel.Text = "pr lugar nac:"
        '
        'Pr_localidadLabel
        '
        Pr_localidadLabel.AutoSize = True
        Pr_localidadLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_localidadLabel.Location = New System.Drawing.Point(223, 48)
        Pr_localidadLabel.Name = "Pr_localidadLabel"
        Pr_localidadLabel.Size = New System.Drawing.Size(64, 13)
        Pr_localidadLabel.TabIndex = 38
        Pr_localidadLabel.Text = "pr localidad:"
        '
        'Pr_domicilioLabel
        '
        Pr_domicilioLabel.AutoSize = True
        Pr_domicilioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_domicilioLabel.Location = New System.Drawing.Point(429, 48)
        Pr_domicilioLabel.Name = "Pr_domicilioLabel"
        Pr_domicilioLabel.Size = New System.Drawing.Size(62, 13)
        Pr_domicilioLabel.TabIndex = 39
        Pr_domicilioLabel.Text = "pr domicilio:"
        '
        'Pr_dniLabel
        '
        Pr_dniLabel.AutoSize = True
        Pr_dniLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_dniLabel.Location = New System.Drawing.Point(655, 48)
        Pr_dniLabel.Name = "Pr_dniLabel"
        Pr_dniLabel.Size = New System.Drawing.Size(36, 13)
        Pr_dniLabel.TabIndex = 40
        Pr_dniLabel.Text = "pr dni:"
        '
        'Pr_perfilLabel
        '
        Pr_perfilLabel.AutoSize = True
        Pr_perfilLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Pr_perfilLabel.Location = New System.Drawing.Point(51, 81)
        Pr_perfilLabel.Name = "Pr_perfilLabel"
        Pr_perfilLabel.Size = New System.Drawing.Size(44, 13)
        Pr_perfilLabel.TabIndex = 41
        Pr_perfilLabel.Text = "pr perfil:"
        '
        'Pr_sexoLabel
        '
        Pr_sexoLabel.AutoSize = True
        Pr_sexoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_sexoLabel.Location = New System.Drawing.Point(243, 81)
        Pr_sexoLabel.Name = "Pr_sexoLabel"
        Pr_sexoLabel.Size = New System.Drawing.Size(44, 13)
        Pr_sexoLabel.TabIndex = 42
        Pr_sexoLabel.Text = "pr sexo:"
        '
        'Pr_tituloLabel
        '
        Pr_tituloLabel.AutoSize = True
        Pr_tituloLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_tituloLabel.Location = New System.Drawing.Point(447, 81)
        Pr_tituloLabel.Name = "Pr_tituloLabel"
        Pr_tituloLabel.Size = New System.Drawing.Size(44, 13)
        Pr_tituloLabel.TabIndex = 43
        Pr_tituloLabel.Text = "pr titulo:"
        '
        'Pr_titulo2Label
        '
        Pr_titulo2Label.AutoSize = True
        Pr_titulo2Label.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_titulo2Label.Location = New System.Drawing.Point(641, 81)
        Pr_titulo2Label.Name = "Pr_titulo2Label"
        Pr_titulo2Label.Size = New System.Drawing.Size(50, 13)
        Pr_titulo2Label.TabIndex = 44
        Pr_titulo2Label.Text = "pr titulo2:"
        '
        'Pr_mailLabel
        '
        Pr_mailLabel.AutoSize = True
        Pr_mailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Pr_mailLabel.Location = New System.Drawing.Point(55, 109)
        Pr_mailLabel.Name = "Pr_mailLabel"
        Pr_mailLabel.Size = New System.Drawing.Size(40, 13)
        Pr_mailLabel.TabIndex = 45
        Pr_mailLabel.Text = "pr mail:"
        '
        'Pr_horas_cargoLabel
        '
        Pr_horas_cargoLabel.AutoSize = True
        Pr_horas_cargoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Pr_horas_cargoLabel.Location = New System.Drawing.Point(209, 109)
        Pr_horas_cargoLabel.Name = "Pr_horas_cargoLabel"
        Pr_horas_cargoLabel.Size = New System.Drawing.Size(78, 13)
        Pr_horas_cargoLabel.TabIndex = 46
        Pr_horas_cargoLabel.Text = "pr horas cargo:"
        '
        'ProfesoresBindingNavigator
        '
        Me.ProfesoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProfesoresBindingNavigator.BindingSource = Me.ProfesoresBindingSource
        Me.ProfesoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfesoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProfesoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProfesoresBindingNavigatorSaveItem})
        Me.ProfesoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfesoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfesoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfesoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfesoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfesoresBindingNavigator.Name = "ProfesoresBindingNavigator"
        Me.ProfesoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfesoresBindingNavigator.Size = New System.Drawing.Size(1180, 25)
        Me.ProfesoresBindingNavigator.TabIndex = 0
        Me.ProfesoresBindingNavigator.Text = "BindingNavigator1"
        Me.ProfesoresBindingNavigator.Visible = False
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
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "profesores"
        Me.ProfesoresBindingSource.DataSource = Me.Sistema_EscolarDataSet
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
        'ProfesoresBindingNavigatorSaveItem
        '
        Me.ProfesoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProfesoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfesoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfesoresBindingNavigatorSaveItem.Name = "ProfesoresBindingNavigatorSaveItem"
        Me.ProfesoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProfesoresBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProfesoresDataGridView
        '
        Me.ProfesoresDataGridView.AutoGenerateColumns = False
        Me.ProfesoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProfesoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.ProfesoresDataGridView.DataSource = Me.ProfesoresBindingSource
        Me.ProfesoresDataGridView.Location = New System.Drawing.Point(2, 246)
        Me.ProfesoresDataGridView.Name = "ProfesoresDataGridView"
        Me.ProfesoresDataGridView.Size = New System.Drawing.Size(1152, 238)
        Me.ProfesoresDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_profesor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_profesor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pr_nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "pr_nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "pr_apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "pr_apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pr_fecha_nac"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pr_fecha_nac"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pr_lugar_nac"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pr_lugar_nac"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pr_localidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pr_localidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "pr_domicilio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "pr_domicilio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pr_dni"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pr_dni"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "pr_perfil"
        Me.DataGridViewTextBoxColumn9.HeaderText = "pr_perfil"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "pr_sexo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "pr_sexo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "pr_titulo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "pr_titulo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "pr_titulo2"
        Me.DataGridViewTextBoxColumn12.HeaderText = "pr_titulo2"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "pr_mail"
        Me.DataGridViewTextBoxColumn13.HeaderText = "pr_mail"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "pr_horas_cargo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "pr_horas_cargo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(1048, 124)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 34)
        Me.cmdCancelar.TabIndex = 33
        Me.cmdCancelar.Text = "          CANCELAR"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(1048, 86)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(104, 34)
        Me.cmdNuevo.TabIndex = 32
        Me.cmdNuevo.Text = "     NUEVO"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.Location = New System.Drawing.Point(1048, 48)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(104, 34)
        Me.cmdEliminar.TabIndex = 31
        Me.cmdEliminar.Text = "          ELIMINAR"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(1048, 10)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(104, 34)
        Me.cmdGuardar.TabIndex = 30
        Me.cmdGuardar.Text = "           GUARDAR "
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Pr_horas_cargoLabel)
        Me.Panel1.Controls.Add(Me.Pr_horas_cargoTextBox)
        Me.Panel1.Controls.Add(Pr_mailLabel)
        Me.Panel1.Controls.Add(Me.Pr_mailTextBox)
        Me.Panel1.Controls.Add(Pr_titulo2Label)
        Me.Panel1.Controls.Add(Me.Pr_titulo2TextBox)
        Me.Panel1.Controls.Add(Pr_tituloLabel)
        Me.Panel1.Controls.Add(Me.Pr_tituloTextBox)
        Me.Panel1.Controls.Add(Pr_sexoLabel)
        Me.Panel1.Controls.Add(Me.Pr_sexoTextBox)
        Me.Panel1.Controls.Add(Pr_perfilLabel)
        Me.Panel1.Controls.Add(Me.Pr_perfilTextBox)
        Me.Panel1.Controls.Add(Pr_dniLabel)
        Me.Panel1.Controls.Add(Me.Pr_dniTextBox)
        Me.Panel1.Controls.Add(Pr_domicilioLabel)
        Me.Panel1.Controls.Add(Me.Pr_domicilioTextBox)
        Me.Panel1.Controls.Add(Pr_localidadLabel)
        Me.Panel1.Controls.Add(Me.Pr_localidadTextBox)
        Me.Panel1.Controls.Add(Pr_lugar_nacLabel)
        Me.Panel1.Controls.Add(Me.Pr_lugar_nacTextBox)
        Me.Panel1.Controls.Add(Pr_fecha_nacLabel)
        Me.Panel1.Controls.Add(Me.Pr_fecha_nacDateTimePicker)
        Me.Panel1.Controls.Add(Pr_apellidoLabel)
        Me.Panel1.Controls.Add(Me.Pr_apellidoTextBox)
        Me.Panel1.Controls.Add(Pr_nombreLabel)
        Me.Panel1.Controls.Add(Me.Pr_nombreTextBox)
        Me.Panel1.Controls.Add(Id_profesorLabel)
        Me.Panel1.Controls.Add(Me.Id_profesorTextBox)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdNuevo)
        Me.Panel1.Controls.Add(Me.cmdEliminar)
        Me.Panel1.Controls.Add(Me.cmdGuardar)
        Me.Panel1.Location = New System.Drawing.Point(2, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 167)
        Me.Panel1.TabIndex = 34
        '
        'Pr_horas_cargoTextBox
        '
        Me.Pr_horas_cargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_horas_cargo", True))
        Me.Pr_horas_cargoTextBox.Enabled = False
        Me.Pr_horas_cargoTextBox.Location = New System.Drawing.Point(293, 106)
        Me.Pr_horas_cargoTextBox.Name = "Pr_horas_cargoTextBox"
        Me.Pr_horas_cargoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_horas_cargoTextBox.TabIndex = 47
        '
        'Pr_mailTextBox
        '
        Me.Pr_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_mail", True))
        Me.Pr_mailTextBox.Enabled = False
        Me.Pr_mailTextBox.Location = New System.Drawing.Point(101, 106)
        Me.Pr_mailTextBox.Name = "Pr_mailTextBox"
        Me.Pr_mailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_mailTextBox.TabIndex = 46
        '
        'Pr_titulo2TextBox
        '
        Me.Pr_titulo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_titulo2", True))
        Me.Pr_titulo2TextBox.Enabled = False
        Me.Pr_titulo2TextBox.Location = New System.Drawing.Point(697, 78)
        Me.Pr_titulo2TextBox.Name = "Pr_titulo2TextBox"
        Me.Pr_titulo2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_titulo2TextBox.TabIndex = 45
        '
        'Pr_tituloTextBox
        '
        Me.Pr_tituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_titulo", True))
        Me.Pr_tituloTextBox.Enabled = False
        Me.Pr_tituloTextBox.Location = New System.Drawing.Point(497, 78)
        Me.Pr_tituloTextBox.Name = "Pr_tituloTextBox"
        Me.Pr_tituloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_tituloTextBox.TabIndex = 44
        '
        'Pr_sexoTextBox
        '
        Me.Pr_sexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_sexo", True))
        Me.Pr_sexoTextBox.Enabled = False
        Me.Pr_sexoTextBox.Location = New System.Drawing.Point(293, 78)
        Me.Pr_sexoTextBox.Name = "Pr_sexoTextBox"
        Me.Pr_sexoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_sexoTextBox.TabIndex = 43
        '
        'Pr_perfilTextBox
        '
        Me.Pr_perfilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_perfil", True))
        Me.Pr_perfilTextBox.Enabled = False
        Me.Pr_perfilTextBox.Location = New System.Drawing.Point(101, 78)
        Me.Pr_perfilTextBox.Name = "Pr_perfilTextBox"
        Me.Pr_perfilTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_perfilTextBox.TabIndex = 42
        '
        'Pr_dniTextBox
        '
        Me.Pr_dniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_dni", True))
        Me.Pr_dniTextBox.Enabled = False
        Me.Pr_dniTextBox.Location = New System.Drawing.Point(697, 45)
        Me.Pr_dniTextBox.Name = "Pr_dniTextBox"
        Me.Pr_dniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_dniTextBox.TabIndex = 41
        '
        'Pr_domicilioTextBox
        '
        Me.Pr_domicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_domicilio", True))
        Me.Pr_domicilioTextBox.Enabled = False
        Me.Pr_domicilioTextBox.Location = New System.Drawing.Point(497, 45)
        Me.Pr_domicilioTextBox.Name = "Pr_domicilioTextBox"
        Me.Pr_domicilioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_domicilioTextBox.TabIndex = 40
        '
        'Pr_localidadTextBox
        '
        Me.Pr_localidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_localidad", True))
        Me.Pr_localidadTextBox.Enabled = False
        Me.Pr_localidadTextBox.Location = New System.Drawing.Point(293, 45)
        Me.Pr_localidadTextBox.Name = "Pr_localidadTextBox"
        Me.Pr_localidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_localidadTextBox.TabIndex = 39
        '
        'Pr_lugar_nacTextBox
        '
        Me.Pr_lugar_nacTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_lugar_nac", True))
        Me.Pr_lugar_nacTextBox.Enabled = False
        Me.Pr_lugar_nacTextBox.Location = New System.Drawing.Point(101, 49)
        Me.Pr_lugar_nacTextBox.Name = "Pr_lugar_nacTextBox"
        Me.Pr_lugar_nacTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_lugar_nacTextBox.TabIndex = 38
        '
        'Pr_fecha_nacDateTimePicker
        '
        Me.Pr_fecha_nacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfesoresBindingSource, "pr_fecha_nac", True))
        Me.Pr_fecha_nacDateTimePicker.Enabled = False
        Me.Pr_fecha_nacDateTimePicker.Location = New System.Drawing.Point(697, 15)
        Me.Pr_fecha_nacDateTimePicker.Name = "Pr_fecha_nacDateTimePicker"
        Me.Pr_fecha_nacDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Pr_fecha_nacDateTimePicker.TabIndex = 37
        '
        'Pr_apellidoTextBox
        '
        Me.Pr_apellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_apellido", True))
        Me.Pr_apellidoTextBox.Enabled = False
        Me.Pr_apellidoTextBox.Location = New System.Drawing.Point(497, 18)
        Me.Pr_apellidoTextBox.Name = "Pr_apellidoTextBox"
        Me.Pr_apellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_apellidoTextBox.TabIndex = 36
        '
        'Pr_nombreTextBox
        '
        Me.Pr_nombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "pr_nombre", True))
        Me.Pr_nombreTextBox.Enabled = False
        Me.Pr_nombreTextBox.Location = New System.Drawing.Point(293, 18)
        Me.Pr_nombreTextBox.Name = "Pr_nombreTextBox"
        Me.Pr_nombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_nombreTextBox.TabIndex = 35
        '
        'Id_profesorTextBox
        '
        Me.Id_profesorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfesoresBindingSource, "Id_profesor", True))
        Me.Id_profesorTextBox.Enabled = False
        Me.Id_profesorTextBox.Location = New System.Drawing.Point(101, 18)
        Me.Id_profesorTextBox.Name = "Id_profesorTextBox"
        Me.Id_profesorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_profesorTextBox.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(926, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 30)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "EXCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1114, 210)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.carrerasTableAdapter = Nothing
        Me.TableAdapterManager.profesoresTableAdapter = Me.ProfesoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = aCopiar.Sistema_EscolarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1180, 506)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProfesoresDataGridView)
        Me.Controls.Add(Me.ProfesoresBindingNavigator)
        Me.Name = "frmProfesores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProfesores"
        CType(Me.ProfesoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfesoresBindingNavigator.ResumeLayout(False)
        Me.ProfesoresBindingNavigator.PerformLayout()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistema_EscolarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sistema_EscolarDataSet As aCopiar.Sistema_EscolarDataSet
    Friend WithEvents ProfesoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresTableAdapter As aCopiar.Sistema_EscolarDataSetTableAdapters.profesoresTableAdapter
    Friend WithEvents TableAdapterManager As aCopiar.Sistema_EscolarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfesoresBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProfesoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProfesoresDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pr_dniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_domicilioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_localidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_lugar_nacTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_fecha_nacDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Pr_apellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_nombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_profesorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_horas_cargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_titulo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_tituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_sexoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_perfilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
