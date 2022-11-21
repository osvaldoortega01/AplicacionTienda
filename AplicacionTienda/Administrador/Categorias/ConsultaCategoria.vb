Imports System.Web.Util

Public Class ConsultaCategoria
    Private Sub ConsultaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.BD_TiendaDataSet.categoria)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txt_search.Text Is "" Then
            Me.CategoriaTableAdapter.Fill(Me.BD_TiendaDataSet.categoria)
            Return
        End If
        Me.CategoriaTableAdapter.FillByName(Me.BD_TiendaDataSet.categoria, txt_search.Text)
    End Sub

    Private Sub btn_addCategory_Click(sender As Object, e As EventArgs) Handles btn_addCategory.Click
        Dim agregarCategoria As New AgregarCategoria
        agregarCategoria.idCategory = Nothing
        agregarCategoria.esActualizar = False
        MenuPrincipalAdmin.OpenChildForm(agregarCategoria)
    End Sub

    Private Sub btn_updateCategory_Click(sender As Object, e As EventArgs) Handles btn_updateCategory.Click
        Dim agregarCategoria As New AgregarCategoria
        agregarCategoria.idCategory = Convert.ToInt32(lbl_idCategory.Text)
        agregarCategoria.esActualizar = True
        MenuPrincipalAdmin.OpenChildForm(agregarCategoria)
    End Sub

    Private Sub btn_deleteCategory_Click(sender As Object, e As EventArgs) Handles btn_deleteCategory.Click
        Try
            Me.CategoriaTableAdapter.DeleteQuery(Convert.ToInt32(lbl_idCategory.Text))
            MessageBox.Show("La categoría se eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class