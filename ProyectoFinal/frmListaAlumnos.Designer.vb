<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaAlumnos))
        Me.dgvListaAlumnos = New System.Windows.Forms.DataGridView()
        Me.btnEliminarAlumnos = New System.Windows.Forms.Button()
        CType(Me.dgvListaAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaAlumnos
        '
        Me.dgvListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaAlumnos.Location = New System.Drawing.Point(12, 12)
        Me.dgvListaAlumnos.Name = "dgvListaAlumnos"
        Me.dgvListaAlumnos.Size = New System.Drawing.Size(1077, 307)
        Me.dgvListaAlumnos.TabIndex = 0
        '
        'btnEliminarAlumnos
        '
        Me.btnEliminarAlumnos.Location = New System.Drawing.Point(523, 340)
        Me.btnEliminarAlumnos.Name = "btnEliminarAlumnos"
        Me.btnEliminarAlumnos.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarAlumnos.TabIndex = 1
        Me.btnEliminarAlumnos.Text = "Eliminar"
        Me.btnEliminarAlumnos.UseVisualStyleBackColor = True
        '
        'frmListaAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 385)
        Me.Controls.Add(Me.btnEliminarAlumnos)
        Me.Controls.Add(Me.dgvListaAlumnos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Alumnos"
        CType(Me.dgvListaAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListaAlumnos As DataGridView
    Friend WithEvents btnEliminarAlumnos As Button
End Class
