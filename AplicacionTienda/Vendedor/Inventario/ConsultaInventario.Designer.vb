<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaInventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.dgv_products = New System.Windows.Forms.DataGridView()
        Me.nombreCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.btn_addInventory = New FontAwesome.Sharp.IconButton()
        Me.btn_updateInventory = New FontAwesome.Sharp.IconButton()
        Me.btn_deleteInventory = New FontAwesome.Sharp.IconButton()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TiendaDataSet = New AplicacionTienda.BD_TiendaDataSet()
        Me.ProductoTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.productoTableAdapter()
        Me.lbl_idProduct = New System.Windows.Forms.Label()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(639, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Producto"
        '
        'btn_search
        '
        Me.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.btn_search.IconColor = System.Drawing.Color.White
        Me.btn_search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search.Location = New System.Drawing.Point(665, 129)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 68)
        Me.btn_search.TabIndex = 1
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'dgv_products
        '
        Me.dgv_products.AllowUserToAddRows = False
        Me.dgv_products.AllowUserToDeleteRows = False
        Me.dgv_products.AllowUserToOrderColumns = True
        Me.dgv_products.AutoGenerateColumns = False
        Me.dgv_products.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.nombreCategoria, Me.ExistenciaDataGridViewTextBoxColumn})
        Me.dgv_products.DataSource = Me.ProductoBindingSource
        Me.dgv_products.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_products.Location = New System.Drawing.Point(0, 0)
        Me.dgv_products.Name = "dgv_products"
        Me.dgv_products.ReadOnly = True
        Me.dgv_products.Size = New System.Drawing.Size(604, 450)
        Me.dgv_products.TabIndex = 5
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
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(623, 72)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(166, 26)
        Me.txt_search.TabIndex = 6
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.lbl_idProduct)
        Me.PanelDesktop.Controls.Add(Me.btn_deleteInventory)
        Me.PanelDesktop.Controls.Add(Me.btn_updateInventory)
        Me.PanelDesktop.Controls.Add(Me.btn_addInventory)
        Me.PanelDesktop.Controls.Add(Me.txt_search)
        Me.PanelDesktop.Controls.Add(Me.Label1)
        Me.PanelDesktop.Controls.Add(Me.btn_search)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(800, 450)
        Me.PanelDesktop.TabIndex = 7
        '
        'btn_addInventory
        '
        Me.btn_addInventory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_addInventory.IconColor = System.Drawing.Color.Black
        Me.btn_addInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addInventory.Location = New System.Drawing.Point(653, 230)
        Me.btn_addInventory.Name = "btn_addInventory"
        Me.btn_addInventory.Size = New System.Drawing.Size(112, 48)
        Me.btn_addInventory.TabIndex = 7
        Me.btn_addInventory.Text = "Agregar Producto"
        Me.btn_addInventory.UseVisualStyleBackColor = True
        '
        'btn_updateInventory
        '
        Me.btn_updateInventory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_updateInventory.IconColor = System.Drawing.Color.Black
        Me.btn_updateInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_updateInventory.Location = New System.Drawing.Point(653, 293)
        Me.btn_updateInventory.Name = "btn_updateInventory"
        Me.btn_updateInventory.Size = New System.Drawing.Size(112, 51)
        Me.btn_updateInventory.TabIndex = 8
        Me.btn_updateInventory.Text = "Actualizar producto seleccionado"
        Me.btn_updateInventory.UseVisualStyleBackColor = True
        '
        'btn_deleteInventory
        '
        Me.btn_deleteInventory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_deleteInventory.IconColor = System.Drawing.Color.Black
        Me.btn_deleteInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deleteInventory.Location = New System.Drawing.Point(653, 365)
        Me.btn_deleteInventory.Name = "btn_deleteInventory"
        Me.btn_deleteInventory.Size = New System.Drawing.Size(112, 50)
        Me.btn_deleteInventory.TabIndex = 9
        Me.btn_deleteInventory.Text = "Eliminar producto seleccionado"
        Me.btn_deleteInventory.UseVisualStyleBackColor = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 200
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio (mxn)"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 110
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.BD_TiendaDataSet
        '
        'BD_TiendaDataSet
        '
        Me.BD_TiendaDataSet.DataSetName = "BD_TiendaDataSet"
        Me.BD_TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'lbl_idProduct
        '
        Me.lbl_idProduct.AutoSize = True
        Me.lbl_idProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.lbl_idProduct.Location = New System.Drawing.Point(683, 428)
        Me.lbl_idProduct.Name = "lbl_idProduct"
        Me.lbl_idProduct.Size = New System.Drawing.Size(52, 13)
        Me.lbl_idProduct.TabIndex = 10
        Me.lbl_idProduct.Text = "idProduct"
        '
        'ConsultaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv_products)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Name = "ConsultaInventario"
        Me.Text = "ConsultaInventario"
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_products As DataGridView
    Friend WithEvents BD_TiendaDataSet As BD_TiendaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As BD_TiendaDataSetTableAdapters.productoTableAdapter
    Friend WithEvents txt_search As TextBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_deleteInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_updateInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_addInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_idProduct As Label
End Class
