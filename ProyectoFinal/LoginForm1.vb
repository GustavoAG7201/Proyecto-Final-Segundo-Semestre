Imports System.Data.OleDb

Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Alonso Gutierrez Gustavo'

        Dim usuario As String = txtNombreUsuario.Text
        Dim contrasena As String = txtContrasenaUsuario.Text

        Try
            conexion1.Open()

            Dim consulta As String = "SELECT COUNT(*) FROM usuarios WHERE correo = @usuario AND contrasena = @contrasena"
            Dim comando As New OleDbCommand(consulta, conexion1)
            comando.Parameters.AddWithValue("@usuario", usuario)
            comando.Parameters.AddWithValue("@contrasena", contrasena)

            Dim validacionDeCredenciales As Integer = CInt(comando.ExecuteScalar())

            If validacionDeCredenciales > 0 Then

                MsgBox("Credenciales válidas. Acceso permitido.", MsgBoxStyle.Information, "Bienvenido!")
                frmMenu.Show()
                Me.Close()
            Else
                MsgBox("Las credenciales que ingresaste son incorrectas, por favor ingrésalas nuevamente.", MsgBoxStyle.Critical, "Error de credenciales")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion1.Close()
        End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Gustavo Alonso Gutierrez'
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'


    End Sub
End Class
