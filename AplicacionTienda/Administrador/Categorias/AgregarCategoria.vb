Public Class AgregarCategoria
    Public idCategory As Integer? = Nothing
    Public esActualizar As Boolean = False

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim name, description As String
        name = txt_name.Text
        description = txt_description.Text
        Try
            If esActualizar Then
                CategoriaTableAdapter.UpdateQuery(name, description, idCategory)
                MessageBox.Show("La categoría se actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CategoriaTableAdapter.Insert(name, description)
                MessageBox.Show("La categoría se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txt_name.Text = ""
            txt_description.Text = ""
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try
    End Sub

    Private Sub CategoriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_TiendaDataSet)

    End Sub

    Private Sub AgregarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.BD_TiendaDataSet.categoria)

    End Sub
End Class