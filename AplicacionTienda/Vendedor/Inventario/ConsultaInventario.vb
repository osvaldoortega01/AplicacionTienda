Imports FontAwesome.Sharp

Public Class ConsultaInventario
    Private Sub ConsultaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.producto' table. You can move, or remove it, as needed.

        Me.ProductoTableAdapter.FillAll(Me.BD_TiendaDataSet.producto)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Me.ProductoTableAdapter.FillByName(Me.BD_TiendaDataSet.producto, txt_search.Text)
        MenuPrincipal.OpenChildForm(New AgregarProducto)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgv_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_products.CellContentClick

    End Sub

    Private Sub btn_addInventory_Click(sender As Object, e As EventArgs) Handles btn_addInventory.Click
        Dim agregarProducto As New AgregarProducto
        agregarProducto.idProduct = Nothing
        agregarProducto.esActualizar = False
        MenuPrincipal.OpenChildForm(agregarProducto)
    End Sub

    Private Sub btn_updateInventory_Click(sender As Object, e As EventArgs) Handles btn_updateInventory.Click
        Dim agregarProducto As New AgregarProducto
        agregarProducto.idProduct = Convert.ToInt32(lbl_idProduct.Text)
        agregarProducto.esActualizar = True
        MenuPrincipal.OpenChildForm(agregarProducto)
    End Sub
End Class