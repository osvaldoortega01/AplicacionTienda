Imports AplicacionTienda.BD_TiendaDataSetTableAdapters

Public Class AgregarUsuario
    Public idUser As Integer? = Nothing
    Public esActualizar As Boolean = False

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

        'validateFields(name, phone, address, category, email)
        Try
            If esActualizar Then
                UsuarioTableAdapter1.UpdateQuery(name, type, address, phone, email, username, password, idUser)
                MessageBox.Show("El producto se actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                UsuarioTableAdapter1.InsertQuery(name, type, address, phone, email, username, password)
                MessageBox.Show("El producto se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txt_name.Text = ""
            txt_phone.Text = ""
            txt_address.Text = ""
            txt_email.Text = ""
            cb_Type.SelectedValue = 0
            txt_user.Text = ""
            txt_password.Text = ""
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try
    End Sub
End Class