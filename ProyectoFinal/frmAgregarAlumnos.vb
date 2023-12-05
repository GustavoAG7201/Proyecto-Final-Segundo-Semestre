Imports System.Data.OleDb
Public Class frmAgregarAlumnos
    Private Sub frmAgregarAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Alonso Gutierrez Gustavo'



    End Sub

    Private Sub btnGuardarAlumno_Click(sender As Object, e As EventArgs) Handles btnGuardarAlumno.Click
        'Gustavo Alonso Gutierrez'

        Dim nombreAlumno As String = txtNombreAlumno.Text
        Dim apellidoPaterno As String = txtApellidoPaterno.Text
        Dim apellidoMarterno As String = txtApellidoMaterno.Text
        Dim generacion As String = cmbGeneracionAlumno.SelectedItem.ToString
        Dim fechaNacimiento As Date = dtpNacimientoAlumno.Value
        Dim matriculaEscolar As String = txtMatriculaAlumno.Text
        Dim semestre As Integer = CInt(nudSemestreAlumno.Value)
        Dim especialidad As String = cmbEspecialidadAlumno.SelectedItem.ToString


        Dim consulta As String

        If String.IsNullOrEmpty(nombreAlumno) And
            String.IsNullOrEmpty(apellidoPaterno) And
            String.IsNullOrEmpty(apellidoMarterno) And
            generacion Is Nothing And
            fechaNacimiento = DateTime.MinValue And
            String.IsNullOrEmpty(matriculaEscolar) And
            semestre = Nothing And
            String.IsNullOrEmpty(especialidad) Then
            MsgBox("Por favor, llena el formulario", MsgBoxStyle.Critical, "Aviso")
        End If



        Try
            conexion1.Open()

            consulta = "INSERT INTO alumnos (nombre, paterno, materno, fecha_nacimiento, generacion, semestre, matricula, especialidad) VALUES 
            ('" & nombreAlumno & "', '" & apellidoPaterno & "', '" & apellidoMarterno & "', '" & fechaNacimiento & "', '" & generacion & "', " & semestre & ", '" & matriculaEscolar & "', '" & especialidad & "' )"

            Dim comando As New OleDbCommand(consulta, conexion1)

            comando.ExecuteNonQuery() 'indica que se inserta, actualiza o elimina datos'
            conexion1.Close()

            MsgBox("Tu informacion se guardo correctamente!", MsgBoxStyle.Information, "Aviso")
            Me.Close()

            conexion1.Close()
        Catch ex As Exception
            MsgBox("Error inesperado", MsgBoxStyle.Critical, "Aviso")
            Me.Close()
            conexion1.Close()
        End Try

    End Sub
End Class