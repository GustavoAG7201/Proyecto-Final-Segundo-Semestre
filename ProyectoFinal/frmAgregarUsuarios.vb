Imports System.Data.OleDb
Public Class frmAgregarUsuarios
    Private Sub frmAgregarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Gustavo Alonso Gutierrez'

        Dim usuario As String = txtUsuario.Text
        Dim correo As String = txtCorreoUsuario.Text
        Dim contrasena As String = txtContrasenaUsuario.Text
        Dim nombreUsuario As String = txtNombreUsuario.Text
        Dim apellidoPaterno As String = txtApellidoPaterno.Text
        Dim apellidoMaterno As String = txtApellidoMaterno.Text

        Dim consulta As String

        If usuario = "" Or correo = "" Or contrasena = "" Then
            MsgBox("Por favor, llena el formulario", MsgBoxStyle.Critical, "Aviso")
        End If
    End Sub
End Class