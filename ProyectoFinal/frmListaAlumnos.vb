Imports System.Data.OleDb
Public Class frmListaAlumnos
    Private Sub frmListaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'
        listaAlumnos()
    End Sub

    Private Sub listaAlumnos()
        'Gustavo Alonso Gutierrez'

        Try
            conexion1.Open()
            Dim consulta As String = "SELECT id_alumnos, nombre, materno, paterno, fecha_nacimiento, generacion, semestre, matricula, especialidad FROM alumnos"

            Dim comando As New OleDbCommand(consulta, conexion1)
            Dim lectura As OleDbDataReader = comando.ExecuteReader()
            Dim tabla As New DataTable
            tabla.Load(lectura)
            dgvListaAlumnos.DataSource = tabla

            conexion1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            conexion1.Close()
        End Try

    End Sub

    Private Sub btnEliminarAlumnos_Click(sender As Object, e As EventArgs) Handles btnEliminarAlumnos.Click
        'Gustavo Alonso Gutierrez'
    End Sub
End Class