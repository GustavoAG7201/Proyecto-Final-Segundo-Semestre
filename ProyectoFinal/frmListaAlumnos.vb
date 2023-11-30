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

        Dim seleccionar_fila As Integer = dgvListaAlumnos.CurrentRow.Cells(0).Value
        Dim respuesta As Byte

        respuesta = MsgBox("¿Estas seguro que quieres eliminar este registro?", MsgBoxStyle.YesNo, "Eliminacion de registros")

        If respuesta = 6 Then
            Try
                conexion1.Open()
                Dim consulta As String = "DELETE FROM alumnos WHERE id_alumnos = " & seleccionar_fila & ""

                Dim comando As New OleDbCommand(consulta, conexion1)
                comando.ExecuteNonQuery()
                conexion1.Close()
                MsgBox("El registro se ha eliminado correctamente!", vbInformation, "Eliminacion de registros")

                listaAlumnos()
                Me.dgvListaAlumnos.CurrentRow.Selected = False
            Catch ex As Exception
                conexion1.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class