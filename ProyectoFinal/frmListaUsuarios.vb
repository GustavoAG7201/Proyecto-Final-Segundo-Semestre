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

    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        'Gusatavo Alonso Gutierrez'

        Dim seleccionar_fila As Integer = dgvListaUsuarios.CurrentRow.Cells(0).Value
        Dim respuesta As Byte

        respuesta = MsgBox("¿Estas seguro que quieres eliminar este registro?", MsgBoxStyle.YesNo, "Eliminacion de registros")

        If respuesta = 6 Then
            Try
                conexion1.Open()
                Dim consulta As String = "DELETE FROM usuarios WHERE id_usuarios = " & seleccionar_fila & ""

                Dim comando As New OleDbCommand(consulta, conexion1)
                comando.ExecuteNonQuery()
                conexion1.Close()
                MsgBox("El registro se ha eliminado correctamente!", vbInformation, "Eliminacion de registros")

                listaUsuario()
                Me.dgvListaUsuarios.CurrentRow.Selected = False
            Catch ex As Exception
                conexion1.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class