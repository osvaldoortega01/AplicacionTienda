Imports System.Windows.Media.Animation
Imports AplicacionTienda.BD_TiendaDataSetTableAdapters

Public Class AgregarUsuario
    Public idUser As Integer? = Nothing
    Public esActualizar As Boolean = False

    Private nameEx = "El campo de nombre es obligatorio"
    Private phoneEx = "El campo de teléfono es obligatorio"
    Private addEx = "El campo de dirección es obligatorio"
    Private emailEx = "El campo de correo electrónico es obligatorio"
    Private typeEx = "El campo de tipo es obligatorio"
    Private usernameEx = "El campo de usuario es obligatorio"
    Private passwordEx = "El campo de contraseña es obligatorio"
    Private usernameDuplEx = "El nombre de usuario ya existe"
    Private idnotexistEx = "No se actualizó correctamente. El id del usuario no existe"
    Private Sub AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If esActualizar Then
            btn_add.Text = "Actualizar Usuario"
        End If
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        txt_password.UseSystemPasswordChar = Not txt_password.UseSystemPasswordChar
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim name, phone, address, email, type, username, password As String
        name = txt_name.Text
        phone = txt_phone.Text
        address = txt_address.Text
        email = txt_email.Text
        type = cb_Type.Text
        username = txt_user.Text
        password = txt_password.Text


        Try
            validateFields(name, phone, address, email, type, username, password)
            If esActualizar Then
                idExist(idUser, idnotexistEx)
                UsuarioTableAdapter1.UpdateQuery(name, type, address, phone, email, username, password, idUser)
                If idUser Is Nothing Then
                    Throw New Exception("El usuario no se actualizó correctamente")
                End If
                MessageBox.Show("El usuario se actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                UsuarioTableAdapter1.InsertQuery(name, type, address, phone, email, username, password)
                MessageBox.Show("El usuario se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txt_name.Text = ""
            txt_phone.Text = ""
            txt_address.Text = ""
            txt_email.Text = ""
            cb_Type.SelectedValue = 0
            txt_user.Text = ""
            txt_password.Text = ""
            MenuPrincipalAdmin.OpenChildForm(New ConsultaUsuarios)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Function validateFields(name As String, phone As String, address As String, email As String, type As String, username As String, password As String)
        validateRequired(name, nameEx)
        validateRequired(phone, phoneEx)
        validateRequired(address, addEx)
        validateRequired(email, emailEx)
        validateRequired(type, typeEx)
        validateRequired(username, usernameEx)
        validateRequired(password, passwordEx)
        validateDuplicated(username, usernameDuplEx)
    End Function

    Private Function validateRequired(field As Object, mensajeExcepcion As String)
        If (field.ToString() Is "") Then
            Throw New Exception(mensajeExcepcion)
        End If
    End Function

    Private Function idExist(field As Object, mensajeExcepcion As String)
        Dim numeroUsuarios = UsuarioTableAdapter1.CountByName(field)
        If numeroUsuarios = 0 Then
            Throw New Exception(mensajeExcepcion)
        End If
    End Function

    Private Function validateDuplicated(field As Object, mensajeExcepcion As String)
        Dim numeroUsuarios = UsuarioTableAdapter1.CountByName(field)
        If numeroUsuarios > 1 Then
            Throw New Exception(mensajeExcepcion)
        End If
    End Function


End Class