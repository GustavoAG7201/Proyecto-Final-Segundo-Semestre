<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarAlumnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarAlumnos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.dtpNacimientoAlumno = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbGeneracionAlumno = New System.Windows.Forms.ComboBox()
        Me.nudSemestreAlumno = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMatriculaAlumno = New System.Windows.Forms.TextBox()
        Me.cmbEspecialidadAlumno = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelarAlumno = New System.Windows.Forms.Button()
        Me.btnGuardarAlumno = New System.Windows.Forms.Button()
        CType(Me.nudSemestreAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos del alumno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nombre"
        '
        'txtNombreAlumno
        '
        Me.txtNombreAlumno.Location = New System.Drawing.Point(16, 70)
        Me.txtNombreAlumno.Name = "txtNombreAlumno"
        Me.txtNombreAlumno.Size = New System.Drawing.Size(181, 20)
        Me.txtNombreAlumno.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(254, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Apellido Paterno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(258, 70)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(181, 20)
        Me.txtApellidoPaterno.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellido Materno"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(16, 141)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(181, 20)
        Me.txtApellidoMaterno.TabIndex = 14
        '
        'dtpNacimientoAlumno
        '
        Me.dtpNacimientoAlumno.Location = New System.Drawing.Point(16, 188)
        Me.dtpNacimientoAlumno.Name = "dtpNacimientoAlumno"
        Me.dtpNacimientoAlumno.Size = New System.Drawing.Size(200, 20)
        Me.dtpNacimientoAlumno.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Fecha de nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Generacion"
        '
        'cmbGeneracionAlumno
        '
        Me.cmbGeneracionAlumno.FormattingEnabled = True
        Me.cmbGeneracionAlumno.Items.AddRange(New Object() {"2019-2022"})
        Me.cmbGeneracionAlumno.Location = New System.Drawing.Point(258, 131)
        Me.cmbGeneracionAlumno.Name = "cmbGeneracionAlumno"
        Me.cmbGeneracionAlumno.Size = New System.Drawing.Size(121, 21)
        Me.cmbGeneracionAlumno.TabIndex = 18
        '
        'nudSemestreAlumno
        '
        Me.nudSemestreAlumno.Location = New System.Drawing.Point(12, 244)
        Me.nudSemestreAlumno.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudSemestreAlumno.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSemestreAlumno.Name = "nudSemestreAlumno"
        Me.nudSemestreAlumno.Size = New System.Drawing.Size(120, 20)
        Me.nudSemestreAlumno.TabIndex = 19
        Me.nudSemestreAlumno.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Tag = ""
        Me.Label7.Text = "Semestre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(254, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Tag = ""
        Me.Label8.Text = "Matricula"
        '
        'txtMatriculaAlumno
        '
        Me.txtMatriculaAlumno.Location = New System.Drawing.Point(258, 187)
        Me.txtMatriculaAlumno.Name = "txtMatriculaAlumno"
        Me.txtMatriculaAlumno.Size = New System.Drawing.Size(141, 20)
        Me.txtMatriculaAlumno.TabIndex = 22
        '
        'cmbEspecialidadAlumno
        '
        Me.cmbEspecialidadAlumno.FormattingEnabled = True
        Me.cmbEspecialidadAlumno.Items.AddRange(New Object() {"Programacion", "Laboratorio Clinico", "Contabilidad", "Administracion de Recursos Humanos", "Electricidad", "Mecatronica"})
        Me.cmbEspecialidadAlumno.Location = New System.Drawing.Point(258, 243)
        Me.cmbEspecialidadAlumno.Name = "cmbEspecialidadAlumno"
        Me.cmbEspecialidadAlumno.Size = New System.Drawing.Size(121, 21)
        Me.cmbEspecialidadAlumno.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(254, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Tag = ""
        Me.Label9.Text = "Especialidad"
        '
        'btnCancelarAlumno
        '
        Me.btnCancelarAlumno.Location = New System.Drawing.Point(16, 311)
        Me.btnCancelarAlumno.Name = "btnCancelarAlumno"
        Me.btnCancelarAlumno.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarAlumno.TabIndex = 25
        Me.btnCancelarAlumno.Text = "Cancelar"
        Me.btnCancelarAlumno.UseVisualStyleBackColor = True
        '
        'btnGuardarAlumno
        '
        Me.btnGuardarAlumno.Location = New System.Drawing.Point(364, 311)
        Me.btnGuardarAlumno.Name = "btnGuardarAlumno"
        Me.btnGuardarAlumno.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarAlumno.TabIndex = 26
        Me.btnGuardarAlumno.Text = "Guardar"
        Me.btnGuardarAlumno.UseVisualStyleBackColor = True
        '
        'frmAgregarAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 346)
        Me.Controls.Add(Me.btnGuardarAlumno)
        Me.Controls.Add(Me.btnCancelarAlumno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbEspecialidadAlumno)
        Me.Controls.Add(Me.txtMatriculaAlumno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudSemestreAlumno)
        Me.Controls.Add(Me.cmbGeneracionAlumno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpNacimientoAlumno)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreAlumno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarAlumnos"
        Me.Text = "Agregar Alumnos"
        CType(Me.nudSemestreAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreAlumno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents dtpNacimientoAlumno As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbGeneracionAlumno As ComboBox
    Friend WithEvents nudSemestreAlumno As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMatriculaAlumno As TextBox
    Friend WithEvents cmbEspecialidadAlumno As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCancelarAlumno As Button
    Friend WithEvents btnGuardarAlumno As Button
End Class
