Imports FontAwesome.Sharp

Public Class MenuPrincipalAdmin
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public nombre As String
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

    End Sub

    Public Sub OpenChildForm(childForm As Form)
        Try
            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
            End If
            currentChildForm = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            PanelDesktop.Controls.Add(childForm)
            PanelDesktop.Tag = childForm
            childForm.BringToFront()
            childForm.Show()

            lblFormTitle.Text = childForm.Text
        Catch ex As Exception
            Me.Show()
        End Try


    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub btn_Sale_Click(sender As Object, e As EventArgs) Handles btn_Sale.Click
        ActivateButton(sender, RGBColors.color1)
        'OpenChildForm(New nombreForm)
    End Sub

    Private Sub btn_Inventory_Click(sender As Object, e As EventArgs) Handles btn_Provider.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New ConsultaProveedor)
    End Sub

    Private Sub btn_category_Click(sender As Object, e As EventArgs) Handles btn_category.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New ConsultaCategoria)
    End Sub


    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New ConsultaUsuarios)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub MenuPrincipalAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nombre.Text = nombre
    End Sub
End Class
