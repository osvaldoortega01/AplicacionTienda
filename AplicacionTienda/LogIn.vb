Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Windows.Navigation

Public Class LogIn

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        Dim usuario As String
        Dim contrasena As String
        usuario = txt_user.Text
        contrasena = txt_password.Text
        If usuario = Nothing Or contrasena = Nothing Then
            MsgBox("Introduzca el usuario y contrasena", MsgBoxStyle.Exclamation)
            Return
        End If
        Dim type As String = "VENDEDOR"

        If cb_isAdmin.Checked Then
            type = "ADMIN"
        End If

        Dim count = LogIn(type)

    End Sub

    Private Function LogIn(type As String) As Integer
        Dim connection As New OleDbConnection(My.Settings.BD_TiendaConnectionString)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim cmd As New OleDbCommand("", connection)

        cmd = New OleDbCommand("SELECT COUNT (*) FROM USUARIO WHERE usuario = ? and contrasena = ? and tipo = ?", connection)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txt_user.Text
        cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txt_password.Text
        cmd.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = type
        Dim count = Convert.ToInt32(cmd.ExecuteScalar())

        If count > 0 Then
            MsgBox("Inicio Sesion exitosamente", MsgBoxStyle.Information)
            If type = "ADMIN" Then
                MenuPrincipalAdmin.Show()
            Else
                MenuPrincipal.Show()
            End If
            Me.Hide()
        Else
            MsgBox("Credenciales incorrectas, intente nuevamente", MsgBoxStyle.Critical)
        End If

        Return count
    End Function

End Class