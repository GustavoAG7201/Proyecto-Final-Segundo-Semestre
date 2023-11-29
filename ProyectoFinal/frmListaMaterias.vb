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
            MsgBox(ex.Message)

            conexion1.Close()
        End Try

    End Sub
End Class