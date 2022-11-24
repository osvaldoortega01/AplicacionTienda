Public Class Venta
    Public subtotal = 0
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.FillAll(Me.BD_TiendaDataSet.producto)
    End Sub

    Private Sub btn_addShop_Click(sender As Object, e As EventArgs) Handles btn_addShop.Click
        Dim idProduct = lbl_idProduct.Text
        Dim nombre = lbl_name.Text
        Dim stock = CInt(lbl_stock.Text)
        Dim cantidad = nud_quantity.Value
        Dim precio = lbl_Price.Text
        Dim iva
        Dim total

        Dim precioTot = cantidad * precio

        If cantidad < stock Then
            dgv_Cart.Rows.Add(idProduct, nombre, cantidad, "$ " & precio)
            ' TODO: dgv_products.CurrentRow.Cells(3).Value = stock - cantidad (Quitar la existencia que se compró)
            subtotal += precioTot
            iva = subtotal * 0.16
            total = subtotal + iva
            txt_subTotal.Text = subtotal
            txt_IVA.Text = iva
            txt_Total.Text = total
        Else
            MsgBox("No existe suficiente cantidad en inventario para realizar esa operacion")
        End If

    End Sub

    Private Sub btn_clearShop_Click(sender As Object, e As EventArgs) Handles btn_clearShop.Click
        dgv_Cart.Rows.Clear()
        subtotal = 0
        txt_subTotal.Text = 0
        txt_IVA.Text = 0
        txt_Total.Text = 0
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

    End Sub
End Class