Imports System.Data.OleDb
Public Class frmListaUsuarios
    Private Sub frmListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Alonso Gutierrez Gustavo'
        listaUsuario()
    End Sub

    Private Sub listaUsuario()
        'Alonso Gutierrez Gustavo'

        Try
            conexion1.Open()
            Dim consulta As String = "SELECT id_usuarios, correo, nombre_usuario, paterno, materno FROM usuarios"

            Dim comando As New OleDbCommand(consulta, conexion1)
            Dim lectura As OleDbDataReader = comando.ExecuteReader()
            Dim tabla As New DataTable
            tabla.Load(lectura)
            dgvListaUsuarios.DataSource = tabla

            conexion1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            conexion1.Close()
        End Try

    End Sub

End Class