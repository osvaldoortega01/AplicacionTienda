Imports AplicacionTienda
Imports NUnit.Framework

Namespace Usuario.nUnitTesting

    Public Class Tests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub AgregarUsuario()
            Dim usuario As New AplicacionTienda.Usuario()
            Assert.AreEqual("admin", usuario.Login("admin", "admin"), "Admin admin debe de dejar ingresar")
        End Sub

    End Class

End Namespace