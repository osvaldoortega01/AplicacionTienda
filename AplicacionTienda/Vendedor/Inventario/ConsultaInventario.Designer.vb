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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.dgv_products = New System.Windows.Forms.DataGridView()
        Me.nombreCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TiendaDataSet = New AplicacionTienda.BD_TiendaDataSet()
        Me.ProductoTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.productoTableAdapter()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(520, 19)
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
        Me.btn_search.Location = New System.Drawing.Point(713, 19)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 68)
        Me.btn_search.TabIndex = 1
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(524, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar nuevo producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(524, 240)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(264, 56)
        Me.IconButton2.TabIndex = 3
        Me.IconButton2.Text = "Eliminar producto seleccionado"
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(524, 334)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(264, 66)
        Me.IconButton3.TabIndex = 4
        Me.IconButton3.Text = "Modificar producto seleccionado"
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'dgv_products
        '
        Me.dgv_products.AllowUserToAddRows = False
        Me.dgv_products.AllowUserToDeleteRows = False
        Me.dgv_products.AllowUserToOrderColumns = True
        Me.dgv_products.AutoGenerateColumns = False
        Me.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.nombreCategoria, Me.ExistenciaDataGridViewTextBoxColumn})
        Me.dgv_products.DataSource = Me.ProductoBindingSource
        Me.dgv_products.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_products.Location = New System.Drawing.Point(0, 0)
        Me.dgv_products.Name = "dgv_products"
        Me.dgv_products.ReadOnly = True
        Me.dgv_products.Size = New System.Drawing.Size(479, 450)
        Me.dgv_products.TabIndex = 5
        '
        'nombreCategoria
        '
        Me.nombreCategoria.DataPropertyName = "nombreCategoria"
        Me.nombreCategoria.HeaderText = "Categoría"
        Me.nombreCategoria.Name = "nombreCategoria"
        Me.nombreCategoria.ReadOnly = True
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(524, 51)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(166, 26)
        Me.txt_search.TabIndex = 6
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
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio ($mxn)"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
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
        'ConsultaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.dgv_products)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaInventario"
        Me.Text = "ConsultaInventario"
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_products As DataGridView
    Friend WithEvents BD_TiendaDataSet As BD_TiendaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As BD_TiendaDataSetTableAdapters.productoTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txt_search As TextBox
End Class
