<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaProveedor
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BD_TiendaDataSet = New AplicacionTienda.BD_TiendaDataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.proveedorTableAdapter()
        Me.dgv_products = New System.Windows.Forms.DataGridView()
        Me.lbl_idProvider = New System.Windows.Forms.Label()
        Me.btn_deleteProvider = New FontAwesome.Sharp.IconButton()
        Me.btn_updateProvider = New FontAwesome.Sharp.IconButton()
        Me.btn_addProvider = New FontAwesome.Sharp.IconButton()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_TiendaDataSet
        '
        Me.BD_TiendaDataSet.DataSetName = "BD_TiendaDataSet"
        Me.BD_TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.BD_TiendaDataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'dgv_products
        '
        Me.dgv_products.AllowUserToAddRows = False
        Me.dgv_products.AllowUserToDeleteRows = False
        Me.dgv_products.AllowUserToOrderColumns = True
        Me.dgv_products.AutoGenerateColumns = False
        Me.dgv_products.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.nombreCategoria, Me.CorreoDataGridViewTextBoxColumn})
        Me.dgv_products.DataSource = Me.ProveedorBindingSource
        Me.dgv_products.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_products.Location = New System.Drawing.Point(0, 0)
        Me.dgv_products.Name = "dgv_products"
        Me.dgv_products.ReadOnly = True
        Me.dgv_products.Size = New System.Drawing.Size(604, 450)
        Me.dgv_products.TabIndex = 6
        '
        'lbl_idProvider
        '
        Me.lbl_idProvider.AutoSize = True
        Me.lbl_idProvider.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "idProveedor", True))
        Me.lbl_idProvider.Location = New System.Drawing.Point(682, 429)
        Me.lbl_idProvider.Name = "lbl_idProvider"
        Me.lbl_idProvider.Size = New System.Drawing.Size(54, 13)
        Me.lbl_idProvider.TabIndex = 17
        Me.lbl_idProvider.Text = "idProvider"
        '
        'btn_deleteProvider
        '
        Me.btn_deleteProvider.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_deleteProvider.IconColor = System.Drawing.Color.Black
        Me.btn_deleteProvider.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deleteProvider.Location = New System.Drawing.Point(652, 366)
        Me.btn_deleteProvider.Name = "btn_deleteProvider"
        Me.btn_deleteProvider.Size = New System.Drawing.Size(112, 50)
        Me.btn_deleteProvider.TabIndex = 16
        Me.btn_deleteProvider.Text = "Eliminar proveedor seleccionado"
        Me.btn_deleteProvider.UseVisualStyleBackColor = True
        '
        'btn_updateProvider
        '
        Me.btn_updateProvider.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_updateProvider.IconColor = System.Drawing.Color.Black
        Me.btn_updateProvider.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_updateProvider.Location = New System.Drawing.Point(652, 294)
        Me.btn_updateProvider.Name = "btn_updateProvider"
        Me.btn_updateProvider.Size = New System.Drawing.Size(112, 51)
        Me.btn_updateProvider.TabIndex = 15
        Me.btn_updateProvider.Text = "Actualizar proveedor seleccionado"
        Me.btn_updateProvider.UseVisualStyleBackColor = True
        '
        'btn_addProvider
        '
        Me.btn_addProvider.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_addProvider.IconColor = System.Drawing.Color.Black
        Me.btn_addProvider.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addProvider.Location = New System.Drawing.Point(652, 231)
        Me.btn_addProvider.Name = "btn_addProvider"
        Me.btn_addProvider.Size = New System.Drawing.Size(112, 48)
        Me.btn_addProvider.TabIndex = 14
        Me.btn_addProvider.Text = "Agregar Proveedor"
        Me.btn_addProvider.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(622, 73)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(166, 26)
        Me.txt_search.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(638, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar Proveedor"
        '
        'btn_search
        '
        Me.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.btn_search.IconColor = System.Drawing.Color.White
        Me.btn_search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search.Location = New System.Drawing.Point(664, 130)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 68)
        Me.btn_search.TabIndex = 12
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'nombreCategoria
        '
        Me.nombreCategoria.DataPropertyName = "nombreCategoria"
        Me.nombreCategoria.FillWeight = 150.0!
        Me.nombreCategoria.HeaderText = "Categoría"
        Me.nombreCategoria.Name = "nombreCategoria"
        Me.nombreCategoria.ReadOnly = True
        Me.nombreCategoria.Width = 150
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsultaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_idProvider)
        Me.Controls.Add(Me.btn_deleteProvider)
        Me.Controls.Add(Me.btn_updateProvider)
        Me.Controls.Add(Me.btn_addProvider)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dgv_products)
        Me.Name = "ConsultaProveedor"
        Me.Text = "Consultar Proveedor"
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_TiendaDataSet As BD_TiendaDataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As BD_TiendaDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents dgv_products As DataGridView
    Friend WithEvents lbl_idProvider As Label
    Friend WithEvents btn_deleteProvider As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_updateProvider As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_addProvider As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCategoria As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
