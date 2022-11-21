Imports System.Web.Util

Public Class AgregarProducto
    Public idProduct As Integer? = Nothing
    Public esActualizar As Boolean = False
    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.BD_TiendaDataSet.producto)
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.BD_TiendaDataSet.categoria)
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.producto' table. You can move, or remove it, as needed.
        If idProduct IsNot Nothing Then
            ' Me.CategoriaTableAdapter.FillBy()
            ' TODO: Autorellenar los textbox con la información ya existente
        End If
    End Sub


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim name, price, idCategory, stock As String
        name = txt_name.Text
        price = nud_price.Value
        idCategory = cb_category.SelectedValue
        stock = nud_stock.Value
        Try
            If esActualizar Then
                ProductoTableAdapter.UpdateQuery(name, price, idCategory, stock, idProduct)
                MessageBox.Show("El producto se actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ProductoTableAdapter.Insert(name, price, idCategory, stock)
                MessageBox.Show("El producto se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txt_name.Text = ""
            nud_price.Text = ""
            cb_category.Text = ""
            nud_stock.Text = ""
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try
    End Sub



End Class