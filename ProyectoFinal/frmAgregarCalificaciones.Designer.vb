﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCalificaciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.cmbParcial = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudPromedio = New System.Windows.Forms.NumericUpDown()
        Me.btnCancelarCalificacion = New System.Windows.Forms.Button()
        Me.btnAgregarCalificacion = New System.Windows.Forms.Button()
        Me.cmbAlumno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.nudPromedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de calificaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(277, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Materia"
        '
        'cmbMateria
        '
        Me.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(281, 75)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(178, 21)
        Me.cmbMateria.TabIndex = 2
        '
        'cmbParcial
        '
        Me.cmbParcial.FormattingEnabled = True
        Me.cmbParcial.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero"})
        Me.cmbParcial.Location = New System.Drawing.Point(17, 128)
        Me.cmbParcial.Name = "cmbParcial"
        Me.cmbParcial.Size = New System.Drawing.Size(178, 21)
        Me.cmbParcial.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Parcial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(277, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Promedio"
        '
        'nudPromedio
        '
        Me.nudPromedio.Location = New System.Drawing.Point(281, 128)
        Me.nudPromedio.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudPromedio.Name = "nudPromedio"
        Me.nudPromedio.Size = New System.Drawing.Size(178, 20)
        Me.nudPromedio.TabIndex = 6
        Me.nudPromedio.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'btnCancelarCalificacion
        '
        Me.btnCancelarCalificacion.Location = New System.Drawing.Point(16, 181)
        Me.btnCancelarCalificacion.Name = "btnCancelarCalificacion"
        Me.btnCancelarCalificacion.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarCalificacion.TabIndex = 7
        Me.btnCancelarCalificacion.Text = "Cancelar"
        Me.btnCancelarCalificacion.UseVisualStyleBackColor = True
        '
        'btnAgregarCalificacion
        '
        Me.btnAgregarCalificacion.Location = New System.Drawing.Point(397, 181)
        Me.btnAgregarCalificacion.Name = "btnAgregarCalificacion"
        Me.btnAgregarCalificacion.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCalificacion.TabIndex = 8
        Me.btnAgregarCalificacion.Text = "Guardar"
        Me.btnAgregarCalificacion.UseVisualStyleBackColor = True
        '
        'cmbAlumno
        '
        Me.cmbAlumno.FormattingEnabled = True
        Me.cmbAlumno.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero"})
        Me.cmbAlumno.Location = New System.Drawing.Point(17, 75)
        Me.cmbAlumno.Name = "cmbAlumno"
        Me.cmbAlumno.Size = New System.Drawing.Size(178, 21)
        Me.cmbAlumno.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Alumno"
        '
        'frmAgregarCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 225)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbAlumno)
        Me.Controls.Add(Me.btnAgregarCalificacion)
        Me.Controls.Add(Me.btnCancelarCalificacion)
        Me.Controls.Add(Me.nudPromedio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbParcial)
        Me.Controls.Add(Me.cmbMateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Calificaciones"
        CType(Me.nudPromedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMateria As ComboBox
    Friend WithEvents cmbParcial As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nudPromedio As NumericUpDown
    Friend WithEvents btnCancelarCalificacion As Button
    Friend WithEvents btnAgregarCalificacion As Button
    Friend WithEvents cmbAlumno As ComboBox
    Friend WithEvents Label5 As Label
End Class
