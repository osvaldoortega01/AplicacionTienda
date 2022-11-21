Imports System.Text.RegularExpressions
Public Class AgregarProveedor
    Public idProvider As Integer? = Nothing
    Public esActualizar As Boolean = False
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim name, phone, address, category, email As String
        name = txt_name.Text
        phone = txt_phone.Text
        address = txt_address.Text
        category = cb_category.SelectedValue
        email = txt_email.Text

        validateFields(name, phone, address, category, email)

        Try
            If esActualizar Then
                ProveedorTableAdapter1.UpdateQuery(name, phone, address, category, email, idProvider)
                MessageBox.Show("El producto se actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ProveedorTableAdapter1.Insert(name, phone, address, category, email)
                MessageBox.Show("El producto se agregó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txt_name.Text = ""
            txt_phone.Text = ""
            txt_address.Text = ""
            txt_email.Text = ""
            cb_category.SelectedValue = Nothing
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try
    End Sub

    Private Function validateFields(name As String, phone As String, address As String, category As String, email As String)

        Dim regexEmail As Regex = New Regex("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$")
        Dim isEmailValid As Boolean = regexEmail.IsMatch(email.Trim)

        Dim regexPhone As Regex = New Regex("^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")
        Dim isPhoneValid As Boolean = regexEmail.IsMatch(phone.Trim)

    End Function

    Private Sub AgregarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TiendaDataSet.categoria' table. You can move, or remove it, as needed.
        Me.CategoriaTableAdapter.Fill(Me.BD_TiendaDataSet.categoria)

    End Sub
End Class