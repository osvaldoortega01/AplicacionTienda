Public Class ConsultaProveedor
    Private Sub ConsultaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.FillAll(Me.BD_TiendaDataSet.proveedor)

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Me.ProveedorTableAdapter.FillByName(Me.BD_TiendaDataSet.proveedor, txt_search.Text)
    End Sub
    Private Sub btn_addProvider_Click(sender As Object, e As EventArgs) Handles btn_addProvider.Click
        Dim agregarProveedor As New AgregarProveedor
        agregarProveedor.idProvider = Nothing
        agregarProveedor.esActualizar = False
        MenuPrincipalAdmin.OpenChildForm(agregarProveedor)
    End Sub

    Private Sub btn_updateProvider_Click(sender As Object, e As EventArgs) Handles btn_updateProvider.Click
        Dim agregarProveedor As New AgregarProveedor
        agregarProveedor.idProvider = Convert.ToInt32(lbl_idProvider.Text)
        agregarProveedor.esActualizar = True
        MenuPrincipalAdmin.OpenChildForm(agregarProveedor)
    End Sub

    Private Sub btn_deleteProvider_Click(sender As Object, e As EventArgs) Handles btn_deleteProvider.Click
        Me.ProveedorTableAdapter.DeleteQuery(Convert.ToInt32(lbl_idProvider.Text))
        MessageBox.Show("El proveedor se eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.ProveedorTableAdapter.FillAll(Me.BD_TiendaDataSet.proveedor)
        ' TODO: Checar dependencias de tablas hijas con FK y PK
    End Sub

End Class