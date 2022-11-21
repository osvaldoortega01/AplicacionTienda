<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BD_TiendaDataSet = New AplicacionTienda.BD_TiendaDataSet()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.categoriaTableAdapter()
        Me.cb_category = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nud_stock = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nud_price = New System.Windows.Forms.NumericUpDown()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New AplicacionTienda.BD_TiendaDataSetTableAdapters.TableAdapterManager()
        Me.btn_add = New FontAwesome.Sharp.IconButton()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(137, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(139, 104)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(311, 26)
        Me.txt_name.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(137, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
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
        'cb_category
        '
        Me.cb_category.DataSource = Me.CategoriaBindingSource
        Me.cb_category.DisplayMember = "nombre"
        Me.cb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_category.FormattingEnabled = True
        Me.cb_category.Location = New System.Drawing.Point(139, 256)
        Me.cb_category.Name = "cb_category"
        Me.cb_category.Size = New System.Drawing.Size(311, 28)
        Me.cb_category.TabIndex = 6
        Me.cb_category.ValueMember = "idCategoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(137, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Categoría"
        '
        'nud_stock
        '
        Me.nud_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_stock.Location = New System.Drawing.Point(289, 173)
        Me.nud_stock.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_stock.Name = "nud_stock"
        Me.nud_stock.Size = New System.Drawing.Size(120, 26)
        Me.nud_stock.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(285, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Existencias"
        '
        'nud_price
        '
        Me.nud_price.DecimalPlaces = 2
        Me.nud_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_price.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nud_price.Location = New System.Drawing.Point(139, 173)
        Me.nud_price.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_price.Name = "nud_price"
        Me.nud_price.Size = New System.Drawing.Size(120, 26)
        Me.nud_price.TabIndex = 10
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AplicacionTienda.BD_TiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaDetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'btn_add
        '
        Me.btn_add.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_add.IconColor = System.Drawing.Color.Black
        Me.btn_add.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_add.Location = New System.Drawing.Point(523, 70)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(178, 232)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "Agregar Producto"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.nud_price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nud_stock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_category)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarProducto"
        Me.Text = "Agregar Producto"
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BD_TiendaDataSet As BD_TiendaDataSet
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As BD_TiendaDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents cb_category As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nud_stock As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nud_price As NumericUpDown
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As BD_TiendaDataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As BD_TiendaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btn_add As FontAwesome.Sharp.IconButton
End Class
