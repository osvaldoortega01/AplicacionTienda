Public Class LogIn

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        Dim usuario As String
        Dim contrasena As String
        usuario = txt_user.Text
        contrasena = txt_password.Text
        If usuario = Nothing Or contrasena = Nothing Then
            MsgBox("Introduzca el usuario y contrasena", MsgBoxStyle.Exclamation)
            Return
        End If
        Dim type As String = "VENDEDOR"

        If cb_isAdmin.Checked Then
            type = "ADMIN"
        End If

        Dim count = LogIn(type)

    End Sub

    Private Function LogIn(type As String) As Integer
        Dim count = Me.UsuarioTableAdapter.CountByUserPWType(txt_user.Text, txt_password.Text, type)

        If count > 0 Then
            MsgBox("Inicio Sesion exitosamente", MsgBoxStyle.Information)
            If type = "ADMIN" Then
                MenuPrincipalAdmin.Show()
            Else
                MenuPrincipal.Show()
            End If
            Me.Hide()
            txt_user.Text = ""
            txt_password.Text = ""
        Else
            MsgBox("Credenciales incorrectas, intente nuevamente", MsgBoxStyle.Critical)
        End If

        Return count
    End Function

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_TiendaDataSet)

    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_TiendaDataSet)

    End Sub
End Class