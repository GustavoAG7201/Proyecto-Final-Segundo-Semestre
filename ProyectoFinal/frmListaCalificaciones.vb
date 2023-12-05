Imports System.Data.OleDb

Public Class frmListaCalificaciones

    Private Sub frmListaCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'
        listaCalificaciones()

    End Sub

    Private Sub listaCalificaciones()
        'Gustavo Alonso Gutierrez'

        Try
            conexion1.Open()
            Dim consulta As String = "SELECT id_calificaciones, id_materia, id_alumnos, parcial, promedio FROM calificaciones"

            Dim comando As New OleDbCommand(consulta, conexion1)
            Dim lectura As OleDbDataReader = comando.ExecuteReader()
            Dim tabla As New DataTable
            tabla.Load(lectura)
            dgvListaCalificaciones.DataSource = tabla

            conexion1.Close()
        Catch ex As Exception
            MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")

            conexion1.Close()
        End Try
    End Sub

    Private Sub btnEliminarCalificaciones_Click(sender As Object, e As EventArgs) Handles btnEliminarCalificaciones.Click
        'Gustavo Alonso Gutierrez'

        Dim seleccionar_fila As Integer = dgvListaCalificaciones.CurrentRow.Cells(0).Value
        Dim respuesta As Byte

        respuesta = MsgBox("¿Estas seguro que quieres eliminar este registro?", MsgBoxStyle.YesNo, "Eliminacion de registros")

        If respuesta = 6 Then
            Try
                conexion1.Open()
                Dim consulta As String = "DELETE FROM calificaciones WHERE id_calificaciones = " & seleccionar_fila & ""

                Dim comando As New OleDbCommand(consulta, conexion1)
                comando.ExecuteNonQuery()
                conexion1.Close()
                MsgBox("El registro se ha eliminado correctamente!", vbInformation, "Eliminacion de registros")

                listaCalificaciones()
                Me.dgvListaCalificaciones.CurrentRow.Selected = False
            Catch ex As Exception
                conexion1.Close()
                MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")
            End Try
        End If
    End Sub
End Class