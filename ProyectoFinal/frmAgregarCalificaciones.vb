Imports System.Data.OleDb
Public Class frmAgregarCalificaciones

    Private Sub frmAgregarCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'
        'Relacion entre calificaciones y alumnos'

        Try
            conexion1.Open()

            Dim consulta1 As String = "Select id_alumnos, nombre From alumnos"
            Dim tabla1 As New DataTable
            Dim adapter1 As New OleDbDataAdapter(consulta1, conexion1)
            adapter1.Fill(tabla1)

            cmbAlumno.DataSource = tabla1
            cmbAlumno.DisplayMember = "nombre"
            cmbAlumno.ValueMember = "id_alumnos"

            conexion1.Close()

        Catch ex As Exception
            MsgBox("Error inesperado!", MsgBoxStyle.Critical, "Aviso")
            conexion1.Close()
        End Try


        'Relacion entre calificaciones y materias'
        Try
            conexion1.Open()

            Dim consulta2 As String = "Select id_materia, nombre From materias"
            Dim tabla2 As New DataTable
            Dim adapter2 As New OleDbDataAdapter(consulta2, conexion1)
            adapter2.Fill(tabla2)

            cmbMateria.DataSource = tabla2
            cmbMateria.DisplayMember = "nombre"
            cmbMateria.ValueMember = "id_materia"

            conexion1.Close()

        Catch ex As Exception
            MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")
            conexion1.Close()


        End Try
    End Sub

    Private Sub btnAgregarCalificacion_Click(sender As Object, e As EventArgs) Handles btnAgregarCalificacion.Click
        'Gustavo Alonso Gutierrez'
        Dim materia As String = CInt(cmbMateria.SelectedValue)
        Dim alumno As String = CInt(cmbAlumno.SelectedValue)

        'aqui
        Dim parcial As String = cmbParcial.SelectedItem
        Dim promedio As Integer = nudPromedio.Value


        Dim consulta As String

        If promedio = "0" Or parcial = "" Then
            MsgBox("Por favor, llena el promedio del alumno", MsgBoxStyle.Critical, "Aviso")
            Return
        End If

        Try
            conexion1.Open()

            consulta = "INSERT INTO calificaciones (id_materia, id_alumnos, parcial, promedio) VALUES (" & materia & ", " & alumno & ", '" & parcial & "', " & promedio & ")"

            Dim comando As New OleDbCommand(consulta, conexion1)

            comando.ExecuteNonQuery()
            conexion1.Close()

            MsgBox("Tu información se guardó correctamente!", MsgBoxStyle.Information, "Aviso")
            Me.Close()

            conexion1.Close()

        Catch ex As Exception
            MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")
            Me.Close()
            conexion1.Close()
        End Try
    End Sub

    Private Sub btnCancelarCalificacion_Click(sender As Object, e As EventArgs) Handles btnCancelarCalificacion.Click
        'Gustavo Alonso Gutierrez'

        Me.Close()
    End Sub
End Class