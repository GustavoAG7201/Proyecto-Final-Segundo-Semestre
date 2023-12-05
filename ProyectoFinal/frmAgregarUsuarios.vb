Imports System.Data.OleDb
Public Class frmAgregarUsuarios
    Private Sub frmAgregarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Gustavo Alonso Gutierrez'


        Dim correo As String = txtCorreoUsuario.Text
        Dim contrasena As String = txtContrasenaUsuario.Text
        Dim nombreUsuario As String = txtNombreUsuario.Text
        Dim apellidoPaterno As String = txtApellidoPaterno.Text
        Dim apellidoMaterno As String = txtApellidoMaterno.Text

        Dim consulta As String

        If nombreUsuario = "" Or correo = "" Or contrasena = "" Then
            MsgBox("Por favor, llena el formulario", MsgBoxStyle.Critical, "Aviso")
        End If

        Try
            conexion1.Open()

            consulta = "INSERT INTO usuarios (correo, contrasena, nombre_usuario, paterno, materno) VALUES 
            ('" & correo & "', '" & contrasena & "', '" & nombreUsuario & "', '" & apellidoPaterno & "', '" & apellidoMaterno & "' )"

            Dim comando As New OleDbCommand(consulta, conexion1)

            comando.ExecuteNonQuery() 'indica que se inserta, actualiza o elimina datos'
            conexion1.Close()

            MsgBox("Tu informacion se guardo correctamente!", MsgBoxStyle.Information, "Aviso")
            Me.Close()

            conexion1.Close()

        Catch ex As Exception
            MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")
            Me.Close()
            conexion1.Close()
        End Try
    End Sub


End Class