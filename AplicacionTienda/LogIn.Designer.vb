<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_Contrasena = New System.Windows.Forms.Label()
        Me.lbl_ForgotPW = New System.Windows.Forms.LinkLabel()
        Me.cb_isAdmin = New System.Windows.Forms.CheckBox()
        Me.btn_Login = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(400, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 450)
        Me.Panel1.TabIndex = 0
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(57, 155)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(271, 26)
        Me.txt_user.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(57, 243)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(271, 26)
        Me.txt_password.TabIndex = 2
        Me.txt_password.UseSystemPasswordChar = True
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Usuario.Location = New System.Drawing.Point(53, 122)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(64, 20)
        Me.lbl_Usuario.TabIndex = 3
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_Contrasena
        '
        Me.lbl_Contrasena.AutoSize = True
        Me.lbl_Contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contrasena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Contrasena.Location = New System.Drawing.Point(53, 211)
        Me.lbl_Contrasena.Name = "lbl_Contrasena"
        Me.lbl_Contrasena.Size = New System.Drawing.Size(92, 20)
        Me.lbl_Contrasena.TabIndex = 4
        Me.lbl_Contrasena.Text = "Contraseña"
        '
        'lbl_ForgotPW
        '
        Me.lbl_ForgotPW.AutoSize = True
        Me.lbl_ForgotPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ForgotPW.Location = New System.Drawing.Point(88, 272)
        Me.lbl_ForgotPW.Name = "lbl_ForgotPW"
        Me.lbl_ForgotPW.Size = New System.Drawing.Size(196, 20)
        Me.lbl_ForgotPW.TabIndex = 5
        Me.lbl_ForgotPW.TabStop = True
        Me.lbl_ForgotPW.Text = "¿OIvidaste tu contraseña?"
        '
        'cb_isAdmin
        '
        Me.cb_isAdmin.AutoSize = True
        Me.cb_isAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_isAdmin.Location = New System.Drawing.Point(101, 304)
        Me.cb_isAdmin.Name = "cb_isAdmin"
        Me.cb_isAdmin.Size = New System.Drawing.Size(183, 24)
        Me.cb_isAdmin.TabIndex = 7
        Me.cb_isAdmin.Text = "¿Es administrador?"
        Me.cb_isAdmin.UseVisualStyleBackColor = True
        '
        'btn_Login
        '
        Me.btn_Login.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btn_Login.IconColor = System.Drawing.Color.Black
        Me.btn_Login.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Login.IconSize = 24
        Me.btn_Login.Location = New System.Drawing.Point(131, 334)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(109, 46)
        Me.btn_Login.TabIndex = 6
        Me.btn_Login.Text = "Iniciar Sesión"
        Me.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.AplicacionTienda.My.Resources.Resources.store_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cb_isAdmin)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.lbl_ForgotPW)
        Me.Controls.Add(Me.lbl_Contrasena)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn"
        Me.Text = "Iniciar Sesión"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_Contrasena As Label
    Friend WithEvents lbl_ForgotPW As LinkLabel
    Friend WithEvents btn_Login As FontAwesome.Sharp.IconButton
    Friend WithEvents cb_isAdmin As CheckBox
    Private WithEvents txt_password As TextBox
End Class
