Imports System.Data.OleDb
Public Class frmAgregarMaterias
    Private Sub frmAgregarMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'
    End Sub

    Private Sub btnGuardarMateria_Click(sender As Object, e As EventArgs) Handles btnGuardarMateria.Click
        'Gustavo Alonso Gutierrez '

        Dim nombreDocente As String = txtNombreDocente.Text
        Dim nombreMateria As String = txtNombreMateria.Text

        Dim consulta As String

        If nombreDocente = "" Or nombreMateria = "" Then
            MsgBox("Por favor, llena el formulario", MsgBoxStyle.Critical, "Aviso")
        End If

        Try
            conexion1.Open()

            consulta = "INSERT INTO materias (nombre, docente) VALUES 
             ('" & nombreMateria & "', '" & nombreDocente & "')"

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