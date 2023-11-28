Imports System.Data.OleDb
Public Class frmAgregarCalificaciones
    Private Sub frmAgregarCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregarCalificacion_Click(sender As Object, e As EventArgs) Handles btnAgregarCalificacion.Click
        'Gustavo Alonso Gutierrez'

        Dim materia As String = cmbMateria.SelectedValue
        Dim parcial As String = cmbParcial.SelectedValue
        Dim promedio As Integer = nudPromedio.Value

        Dim consulta As String

        If materia = "" Or parcial = "" Then
            MsgBox("Por favor, llena el formulario", MsgBoxStyle.Critical, "Aviso")
        End If

        Try
            conexion1.Open()

            consulta = "INSERT INTO calificaciones (id_calificacion ,id_materia, parcial, promedio) VALUES 
            ('" & materia & "', '" & parcial & "', '" & promedio & "')"

            Dim comando As New OleDbCommand(consulta, conexion1)

            comando.ExecuteNonQuery()
            conexion1.Close()

            MsgBox("Tu informacion se guardo correctamente!", MsgBoxStyle.Information, "Aviso")
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub
End Class