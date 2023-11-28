Imports System.Data.OleDb
Public Class frmAgregarCalificaciones

    Private Sub frmAgregarCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'

        Try
            conexion1.Open()

            Dim consulta1 As String = "Select id_alumnos, nombre From alumnos"
            Dim tabla1 As New DataTable
            Dim adapter1 As New OleDbDataAdapter(consulta1, conexion1)
            adapter1.Fill(tabla1)




        Catch ex As Exception

        End Try
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
            MsgBox(ex.Message)

            conexion1.Close()


        End Try
    End Sub

    Private Sub btnAgregarCalificacion_Click(sender As Object, e As EventArgs) Handles btnAgregarCalificacion.Click
        'Gustavo Alonso Gutierrez'
        Dim materia As Integer = CInt(cmbMateria.SelectedValue)
        Dim parcial As String = cmbParcial.SelectedItem.ToString
        Dim promedio As Integer = nudPromedio.Value


        Dim consulta As String

        If promedio = "0" Then
            MsgBox("Por favor, llena el formulario", MsgBoxStyle.Critical, "Aviso")
        End If

        Try
            conexion1.Open()

            consulta = "INSERT INTO calificaciones (parcial, promedio, id_materia) VALUES 
            ('" & parcial & "', " & promedio & ", " & materia & ")"

            Dim comando As New OleDbCommand(consulta, conexion1)

            comando.ExecuteNonQuery()
            conexion1.Close()

            MsgBox("Tu informacion se guardo correctamente!", MsgBoxStyle.Information, "Aviso")
            Me.Close()

            conexion1.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            conexion1.Close()
        End Try
    End Sub




End Class