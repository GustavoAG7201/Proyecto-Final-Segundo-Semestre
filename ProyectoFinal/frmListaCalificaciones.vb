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
            MsgBox(ex.Message)

            conexion1.Close()
        End Try
    End Sub
End Class