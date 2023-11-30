<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaMaterias))
        Me.dgvListaMaterias = New System.Windows.Forms.DataGridView()
        Me.btnEliminarMaterias = New System.Windows.Forms.Button()
        CType(Me.dgvListaMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaMaterias
        '
        Me.dgvListaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaMaterias.Location = New System.Drawing.Point(12, 12)
        Me.dgvListaMaterias.Name = "dgvListaMaterias"
        Me.dgvListaMaterias.Size = New System.Drawing.Size(553, 293)
        Me.dgvListaMaterias.TabIndex = 0
        '
        'btnEliminarMaterias
        '
        Me.btnEliminarMaterias.Location = New System.Drawing.Point(256, 321)
        Me.btnEliminarMaterias.Name = "btnEliminarMaterias"
        Me.btnEliminarMaterias.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarMaterias.TabIndex = 1
        Me.btnEliminarMaterias.Text = "Eliminar"
        Me.btnEliminarMaterias.UseVisualStyleBackColor = True
        '
        'frmListaMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 356)
        Me.Controls.Add(Me.btnEliminarMaterias)
        Me.Controls.Add(Me.dgvListaMaterias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaMaterias"
        Me.Text = "Lista Materias"
        CType(Me.dgvListaMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListaMaterias As DataGridView
    Friend WithEvents btnEliminarMaterias As Button
End Class
