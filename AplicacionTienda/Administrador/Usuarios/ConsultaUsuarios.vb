Imports OpenQA.Selenium.DevTools.V105.Page

Public Class ConsultaUsuarios
    Private Sub ConsultaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsuarioTableAdapter.Fill(Me.BD_TiendaDataSet.usuario)
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txt_search.Text Is Nothing Or txt_search.Text.ToString() = "" Then
            Me.UsuarioTableAdapter.Fill(Me.BD_TiendaDataSet.usuario)
        End If
        Try
            Me.UsuarioTableAdapter.FillByName(Me.BD_TiendaDataSet.usuario, txt_search.Text)
            If Me.BD_TiendaDataSet.usuario.Rows.Count = 0 Then
                Throw New Exception("No se encontró ningún registro")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_addUser_Click(sender As Object, e As EventArgs) Handles btn_addUser.Click
        Dim agregarUsuario As New AgregarUsuario
        agregarUsuario.idUser = Nothing
        agregarUsuario.esActualizar = False
        MenuPrincipalAdmin.OpenChildForm(agregarUsuario)
    End Sub

    Private Sub btn_updateUser_Click(sender As Object, e As EventArgs) Handles btn_updateUser.Click
        Try
            If lbl_idUser.Text.ToString() = "" Then
                Throw New Exception("Se debe de seleccionar algún registro para actualizar")
            End If
            Dim agregarUsuario As New AgregarUsuario
            agregarUsuario.idUser = lbl_idUser.Text
            agregarUsuario.esActualizar = True
            agregarUsuario.Text = "Actualizar usuario"
            MenuPrincipalAdmin.OpenChildForm(agregarUsuario)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_deleteUser_Click(sender As Object, e As EventArgs) Handles btn_deleteUser.Click
        Try
            If lbl_idUser.Text.ToString() = "" Then
                Throw New Exception("Se debe de seleccionar algún registro para eliminar")
            End If
            Dim noVentas = Me.VentaTableAdapter.SearchByIDUser(lbl_idUser.Text)
            If noVentas > 0 Then
                Throw New Exception("El usuario tiene una venta asignada y no se puede eliminar")
            End If
            Me.UsuarioTableAdapter.DeleteQuery(lbl_idUser.Text)
            MessageBox.Show("El usuario se eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.UsuarioTableAdapter.Fill(Me.BD_TiendaDataSet.usuario)
            ' TODO: Checar dependencias de tablas hijas con FK y PK
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class