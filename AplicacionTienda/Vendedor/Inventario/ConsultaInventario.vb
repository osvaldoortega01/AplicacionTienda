Imports FontAwesome.Sharp

Public Class ConsultaInventario
    Private Sub ConsultaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.producto' table. You can move, or remove it, as needed.

        Me.ProductoTableAdapter.FillAll(Me.BD_TiendaDataSet.producto)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Me.ProductoTableAdapter.FillByName(Me.BD_TiendaDataSet.producto, txt_search.Text)
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

    Private Sub btn_deleteInventory_Click(sender As Object, e As EventArgs) Handles btn_deleteInventory.Click
        Me.ProductoTableAdapter.DeleteQuery(Convert.ToInt32(lbl_idProduct.Text))
        MessageBox.Show("El producto se eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class