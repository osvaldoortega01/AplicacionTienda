Public Class ConsultaInventario
    Private Sub ConsultaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.producto' table. You can move, or remove it, as needed.

        Me.ProductoTableAdapter.FillAll(Me.BD_TiendaDataSet.producto)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Me.ProductoTableAdapter.FillBy(Me.BD_TiendaDataSet.producto, txt_search.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class