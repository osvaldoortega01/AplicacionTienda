<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCategoria
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
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.dgv_products = New System.Windows.Forms.DataGridView()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TiendaDataSet = New AplicacionTienda.BD_TiendaDataSet()
        Me.CategoriaTableAdapter = New AplicacionTienda.BD_TiendaDataSetTableAdapters.categoriaTableAdapter()
        Me.btn_addCategory = New FontAwesome.Sharp.IconButton()
        Me.btn_updateCategory = New FontAwesome.Sharp.IconButton()
        Me.btn_deleteCategory = New FontAwesome.Sharp.IconButton()
        Me.lbl_idCategory = New System.Windows.Forms.Label()
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(626, 71)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(166, 26)
        Me.txt_search.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(642, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar Categoría"
        '
        'btn_search
        '
        Me.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.btn_search.IconColor = System.Drawing.Color.White
        Me.btn_search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search.Location = New System.Drawing.Point(668, 128)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 68)
        Me.btn_search.TabIndex = 8
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
        Me.dgv_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoriaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dgv_products.DataSource = Me.CategoriaBindingSource
        Me.dgv_products.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_products.Location = New System.Drawing.Point(0, 0)
        Me.dgv_products.Name = "dgv_products"
        Me.dgv_products.ReadOnly = True
        Me.dgv_products.Size = New System.Drawing.Size(543, 450)
        Me.dgv_products.TabIndex = 9
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 200
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.BD_TiendaDataSet
        '
        'BD_TiendaDataSet
        '
        Me.BD_TiendaDataSet.DataSetName = "BD_TiendaDataSet"
        Me.BD_TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'btn_addCategory
        '
        Me.btn_addCategory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_addCategory.IconColor = System.Drawing.Color.Black
        Me.btn_addCategory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addCategory.Location = New System.Drawing.Point(646, 235)
        Me.btn_addCategory.Name = "btn_addCategory"
        Me.btn_addCategory.Size = New System.Drawing.Size(128, 54)
        Me.btn_addCategory.TabIndex = 11
        Me.btn_addCategory.Text = "Agregar una nueva categoría"
        Me.btn_addCategory.UseVisualStyleBackColor = True
        '
        'btn_updateCategory
        '
        Me.btn_updateCategory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_updateCategory.IconColor = System.Drawing.Color.Black
        Me.btn_updateCategory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_updateCategory.Location = New System.Drawing.Point(646, 295)
        Me.btn_updateCategory.Name = "btn_updateCategory"
        Me.btn_updateCategory.Size = New System.Drawing.Size(128, 52)
        Me.btn_updateCategory.TabIndex = 12
        Me.btn_updateCategory.Text = "Actualizar categoría seleccionada"
        Me.btn_updateCategory.UseVisualStyleBackColor = True
        '
        'btn_deleteCategory
        '
        Me.btn_deleteCategory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_deleteCategory.IconColor = System.Drawing.Color.Black
        Me.btn_deleteCategory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deleteCategory.Location = New System.Drawing.Point(646, 353)
        Me.btn_deleteCategory.Name = "btn_deleteCategory"
        Me.btn_deleteCategory.Size = New System.Drawing.Size(128, 54)
        Me.btn_deleteCategory.TabIndex = 13
        Me.btn_deleteCategory.Text = "Eliminar categoria seleccionada"
        Me.btn_deleteCategory.UseVisualStyleBackColor = True
        '
        'lbl_idCategory
        '
        Me.lbl_idCategory.AutoSize = True
        Me.lbl_idCategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "idCategoria", True))
        Me.lbl_idCategory.Location = New System.Drawing.Point(665, 428)
        Me.lbl_idCategory.Name = "lbl_idCategory"
        Me.lbl_idCategory.Size = New System.Drawing.Size(60, 13)
        Me.lbl_idCategory.TabIndex = 14
        Me.lbl_idCategory.Text = "idCategoria"
        '
        'ConsultaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_idCategory)
        Me.Controls.Add(Me.btn_deleteCategory)
        Me.Controls.Add(Me.btn_updateCategory)
        Me.Controls.Add(Me.btn_addCategory)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dgv_products)
        Me.Name = "ConsultaCategoria"
        Me.Text = "ConsultaCategoria"
        CType(Me.dgv_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_products As DataGridView
    Friend WithEvents BD_TiendaDataSet As BD_TiendaDataSet
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As BD_TiendaDataSetTableAdapters.categoriaTableAdapter
    Friend WithEvents btn_addCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_updateCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_deleteCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lbl_idCategory As Label
End Class
