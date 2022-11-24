<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BD_TiendaDataSet = New AplicacionTienda.BD_TiendaDataSet()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.categoriaTableAdapter()
        Me.dgv_products = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.productoTableAdapter()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_addShop = New FontAwesome.Sharp.IconButton()
        Me.btn_clearShop = New FontAwesome.Sharp.IconButton()
        Me.nud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_Cart = New System.Windows.Forms.DataGridView()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_idProduct = New System.Windows.Forms.Label()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_TiendaDataSet
        '
        Me.BD_TiendaDataSet.DataSetName = "BD_TiendaDataSet"
        Me.BD_TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.BD_TiendaDataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
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
        Me.dgv_products.Location = New System.Drawing.Point(39, 118)
        Me.dgv_products.Name = "dgv_products"
        Me.dgv_products.ReadOnly = True
        Me.dgv_products.Size = New System.Drawing.Size(403, 309)
        Me.dgv_products.TabIndex = 6
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
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 60
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
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.Transparent
        Me.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.btn_search.IconColor = System.Drawing.Color.White
        Me.btn_search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search.IconSize = 36
        Me.btn_search.Location = New System.Drawing.Point(399, 54)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(40, 40)
        Me.btn_search.TabIndex = 7
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(35, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(98, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 26)
        Me.TextBox1.TabIndex = 9
        '
        'btn_addShop
        '
        Me.btn_addShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addShop.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_addShop.IconColor = System.Drawing.Color.Black
        Me.btn_addShop.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addShop.Location = New System.Drawing.Point(464, 253)
        Me.btn_addShop.Name = "btn_addShop"
        Me.btn_addShop.Size = New System.Drawing.Size(120, 54)
        Me.btn_addShop.TabIndex = 10
        Me.btn_addShop.Text = "Agregar al carrito"
        Me.btn_addShop.UseVisualStyleBackColor = True
        '
        'btn_clearShop
        '
        Me.btn_clearShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearShop.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_clearShop.IconColor = System.Drawing.Color.Black
        Me.btn_clearShop.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_clearShop.Location = New System.Drawing.Point(467, 348)
        Me.btn_clearShop.Name = "btn_clearShop"
        Me.btn_clearShop.Size = New System.Drawing.Size(120, 41)
        Me.btn_clearShop.TabIndex = 11
        Me.btn_clearShop.Text = "Limpiar Carrito"
        Me.btn_clearShop.UseVisualStyleBackColor = True
        '
        'nud_quantity
        '
        Me.nud_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_quantity.Location = New System.Drawing.Point(464, 175)
        Me.nud_quantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_quantity.Name = "nud_quantity"
        Me.nud_quantity.Size = New System.Drawing.Size(120, 26)
        Me.nud_quantity.TabIndex = 12
        '
        'txt_IVA
        '
        Me.txt_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.Location = New System.Drawing.Point(769, 417)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.Size = New System.Drawing.Size(100, 26)
        Me.txt_IVA.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(678, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "IVA"
        '
        'txt_Total
        '
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(769, 466)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(100, 26)
        Me.txt_Total.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(678, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Total"
        '
        'dgv_Cart
        '
        Me.dgv_Cart.AllowUserToAddRows = False
        Me.dgv_Cart.AllowUserToDeleteRows = False
        Me.dgv_Cart.AllowUserToOrderColumns = True
        Me.dgv_Cart.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Cart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.producto, Me.cantidad, Me.precio})
        Me.dgv_Cart.Location = New System.Drawing.Point(593, 118)
        Me.dgv_Cart.Name = "dgv_Cart"
        Me.dgv_Cart.ReadOnly = True
        Me.dgv_Cart.Size = New System.Drawing.Size(400, 246)
        Me.dgv_Cart.TabIndex = 17
        '
        'idProducto
        '
        Me.idProducto.HeaderText = "idProducto"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Visible = False
        '
        'producto
        '
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'IconButton4
        '
        Me.IconButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.Location = New System.Drawing.Point(464, 443)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(120, 43)
        Me.IconButton4.TabIndex = 19
        Me.IconButton4.Text = "Vender"
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(479, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cantidad"
        '
        'txt_subTotal
        '
        Me.txt_subTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subTotal.Location = New System.Drawing.Point(769, 369)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.Size = New System.Drawing.Size(100, 26)
        Me.txt_subTotal.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(678, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Subtotal"
        '
        'lbl_idProduct
        '
        Me.lbl_idProduct.AutoSize = True
        Me.lbl_idProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.lbl_idProduct.Location = New System.Drawing.Point(42, 443)
        Me.lbl_idProduct.Name = "lbl_idProduct"
        Me.lbl_idProduct.Size = New System.Drawing.Size(52, 13)
        Me.lbl_idProduct.TabIndex = 23
        Me.lbl_idProduct.Text = "idProduct"
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio", True))
        Me.lbl_Price.Location = New System.Drawing.Point(246, 443)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Price.TabIndex = 24
        Me.lbl_Price.Text = "price"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.lbl_name.Location = New System.Drawing.Point(144, 443)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(33, 13)
        Me.lbl_name.TabIndex = 25
        Me.lbl_name.Text = "name"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "existencia", True))
        Me.lbl_stock.Location = New System.Drawing.Point(381, 443)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(33, 13)
        Me.lbl_stock.TabIndex = 26
        Me.lbl_stock.Text = "stock"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 507)
        Me.Controls.Add(Me.lbl_stock)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_Price)
        Me.Controls.Add(Me.lbl_idProduct)
        Me.Controls.Add(Me.txt_subTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.dgv_Cart)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_IVA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nud_quantity)
        Me.Controls.Add(Me.btn_clearShop)
        Me.Controls.Add(Me.btn_addShop)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dgv_products)
        Me.Name = "Venta"
        Me.Text = "Venta"
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_TiendaDataSet As BD_TiendaDataSet
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As BD_TiendaDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents dgv_products As DataGridView
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As BD_TiendaDataSetTableAdapters.productoTableAdapter
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_addShop As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_clearShop As FontAwesome.Sharp.IconButton
    Friend WithEvents nud_quantity As NumericUpDown
    Friend WithEvents txt_IVA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_Cart As DataGridView
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_idProduct As Label
    Friend WithEvents lbl_Price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_stock As Label
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
End Class
