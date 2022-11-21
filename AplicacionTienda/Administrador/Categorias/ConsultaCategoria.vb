Public Class ConsultaCategoria
    Private Sub ConsultaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.BD_TiendaDataSet.categoria)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        MenuPrincipal.OpenChildForm(New AgregarProducto)
    End Sub
End Class