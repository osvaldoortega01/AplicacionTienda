<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipalAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipalAdmin))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_user = New FontAwesome.Sharp.IconButton()
        Me.btn_category = New FontAwesome.Sharp.IconButton()
        Me.btn_Provider = New FontAwesome.Sharp.IconButton()
        Me.btn_Sale = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btn_user)
        Me.PanelMenu.Controls.Add(Me.btn_category)
        Me.PanelMenu.Controls.Add(Me.btn_Provider)
        Me.PanelMenu.Controls.Add(Me.btn_Sale)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 621)
        Me.PanelMenu.TabIndex = 1
        '
        'btn_user
        '
        Me.btn_user.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_user.FlatAppearance.BorderSize = 0
        Me.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_user.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_user.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.btn_user.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_user.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_user.IconSize = 32
        Me.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_user.Location = New System.Drawing.Point(0, 320)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_user.Size = New System.Drawing.Size(220, 60)
        Me.btn_user.TabIndex = 6
        Me.btn_user.Text = "Usuarios"
        Me.btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'btn_category
        '
        Me.btn_category.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_category.FlatAppearance.BorderSize = 0
        Me.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_category.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_category.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btn_category.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_category.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_category.IconSize = 32
        Me.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_category.Location = New System.Drawing.Point(0, 260)
        Me.btn_category.Name = "btn_category"
        Me.btn_category.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_category.Size = New System.Drawing.Size(220, 60)
        Me.btn_category.TabIndex = 4
        Me.btn_category.Text = "Categorías"
        Me.btn_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_category.UseVisualStyleBackColor = True
        '
        'btn_Provider
        '
        Me.btn_Provider.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Provider.FlatAppearance.BorderSize = 0
        Me.btn_Provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Provider.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Provider.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btn_Provider.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Provider.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Provider.IconSize = 32
        Me.btn_Provider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Provider.Location = New System.Drawing.Point(0, 200)
        Me.btn_Provider.Name = "btn_Provider"
        Me.btn_Provider.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_Provider.Size = New System.Drawing.Size(220, 60)
        Me.btn_Provider.TabIndex = 2
        Me.btn_Provider.Text = "Proveedores"
        Me.btn_Provider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Provider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Provider.UseVisualStyleBackColor = True
        '
        'btn_Sale
        '
        Me.btn_Sale.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Sale.FlatAppearance.BorderSize = 0
        Me.btn_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Sale.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_Sale.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btn_Sale.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_Sale.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Sale.IconSize = 32
        Me.btn_Sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Sale.Location = New System.Drawing.Point(0, 140)
        Me.btn_Sale.Name = "btn_Sale"
        Me.btn_Sale.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_Sale.Size = New System.Drawing.Size(220, 60)
        Me.btn_Sale.TabIndex = 1
        Me.btn_Sale.Text = "Ventas"
        Me.btn_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Sale.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionTienda.My.Resources.Resources.store_logo
        Me.PictureBox1.Location = New System.Drawing.Point(22, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btn_logout)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1021, 75)
        Me.PanelTitleBar.TabIndex = 2
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        Me.btn_logout.IconColor = System.Drawing.Color.Black
        Me.btn_logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_logout.Location = New System.Drawing.Point(905, 0)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(116, 75)
        Me.btn_logout.TabIndex = 2
        Me.btn_logout.Text = "Cerrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sesión"
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(66, 32)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(35, 13)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(28, 22)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1021, 546)
        Me.PanelDesktop.TabIndex = 3
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(77, 51)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(75, 23)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.Text = "IconButton1"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'MenuPrincipalAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 621)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.IconButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipalAdmin"
        Me.Text = "Menú Principal Administrador"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btn_Sale As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btn_category As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Provider As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btn_user As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
End Class
