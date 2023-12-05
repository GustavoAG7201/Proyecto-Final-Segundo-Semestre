Imports System.Data.OleDb
Public Class frmListaMaterias
    Private Sub frmListaMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'
        listaMaterias()
    End Sub

    Private Sub listaMaterias()
        'Gustavo Alonso Gutierrez'

        Try
            conexion1.Open()
            Dim consulta As String = "SELECT id_materia, nombre, docente FROM materias"

            Dim comando As New OleDbCommand(consulta, conexion1)
            Dim lectura As OleDbDataReader = comando.ExecuteReader()
            Dim tabla As New DataTable
            tabla.Load(lectura)
            dgvListaMaterias.DataSource = tabla

            conexion1.Close()
        Catch ex As Exception
            MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")

            conexion1.Close()
        End Try

    End Sub

    Private Sub btnEliminarMaterias_Click(sender As Object, e As EventArgs) Handles btnEliminarMaterias.Click
        'Gustavo Alonso Gutierrez'

        Dim seleccionar_fila As Integer = dgvListaMaterias.CurrentRow.Cells(0).Value
        Dim respuesta As Byte

        respuesta = MsgBox("¿Estas seguro que quieres eliminar este registro?", MsgBoxStyle.YesNo, "Eliminacion de registros")

        If respuesta = 6 Then
            Try
                conexion1.Open()
                Dim consulta As String = "DELETE FROM materias WHERE id_materia = " & seleccionar_fila & ""

                Dim comando As New OleDbCommand(consulta, conexion1)
                comando.ExecuteNonQuery()
                conexion1.Close()
                MsgBox("El registro se ha eliminado correctamente!", vbInformation, "Eliminacion de registros")

                listaMaterias()
                Me.dgvListaMaterias.CurrentRow.Selected = False
            Catch ex As Exception
                conexion1.Close()
                MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")
            End Try
        End If
    End Sub
End Class