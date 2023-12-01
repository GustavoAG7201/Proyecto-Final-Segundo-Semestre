<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarMaterias))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreMateria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreDocente = New System.Windows.Forms.TextBox()
        Me.btnCancelarMateria = New System.Windows.Forms.Button()
        Me.btnGuardarMateria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de la materia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'txtNombreMateria
        '
        Me.txtNombreMateria.Location = New System.Drawing.Point(12, 76)
        Me.txtNombreMateria.Name = "txtNombreMateria"
        Me.txtNombreMateria.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreMateria.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Docente que imparte"
        '
        'txtNombreDocente
        '
        Me.txtNombreDocente.Location = New System.Drawing.Point(12, 131)
        Me.txtNombreDocente.Name = "txtNombreDocente"
        Me.txtNombreDocente.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreDocente.TabIndex = 4
        '
        'btnCancelarMateria
        '
        Me.btnCancelarMateria.Location = New System.Drawing.Point(12, 200)
        Me.btnCancelarMateria.Name = "btnCancelarMateria"
        Me.btnCancelarMateria.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarMateria.TabIndex = 5
        Me.btnCancelarMateria.Text = "Cancelar"
        Me.btnCancelarMateria.UseVisualStyleBackColor = True
        '
        'btnGuardarMateria
        '
        Me.btnGuardarMateria.Location = New System.Drawing.Point(155, 200)
        Me.btnGuardarMateria.Name = "btnGuardarMateria"
        Me.btnGuardarMateria.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarMateria.TabIndex = 6
        Me.btnGuardarMateria.Text = "Guardar"
        Me.btnGuardarMateria.UseVisualStyleBackColor = True
        '
        'frmAgregarMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(242, 235)
        Me.Controls.Add(Me.btnGuardarMateria)
        Me.Controls.Add(Me.btnCancelarMateria)
        Me.Controls.Add(Me.txtNombreDocente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreMateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarMaterias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Materias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreMateria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreDocente As TextBox
    Friend WithEvents btnCancelarMateria As Button
    Friend WithEvents btnGuardarMateria As Button
End Class
