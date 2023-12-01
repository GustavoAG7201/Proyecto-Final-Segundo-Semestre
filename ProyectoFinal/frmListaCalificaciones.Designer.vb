<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaCalificaciones))
        Me.dgvListaCalificaciones = New System.Windows.Forms.DataGridView()
        Me.btnEliminarCalificaciones = New System.Windows.Forms.Button()
        CType(Me.dgvListaCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaCalificaciones
        '
        Me.dgvListaCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCalificaciones.Location = New System.Drawing.Point(12, 12)
        Me.dgvListaCalificaciones.Name = "dgvListaCalificaciones"
        Me.dgvListaCalificaciones.Size = New System.Drawing.Size(828, 301)
        Me.dgvListaCalificaciones.TabIndex = 0
        '
        'btnEliminarCalificaciones
        '
        Me.btnEliminarCalificaciones.Location = New System.Drawing.Point(404, 332)
        Me.btnEliminarCalificaciones.Name = "btnEliminarCalificaciones"
        Me.btnEliminarCalificaciones.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarCalificaciones.TabIndex = 1
        Me.btnEliminarCalificaciones.Text = "Eliminar"
        Me.btnEliminarCalificaciones.UseVisualStyleBackColor = True
        '
        'frmListaCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 367)
        Me.Controls.Add(Me.btnEliminarCalificaciones)
        Me.Controls.Add(Me.dgvListaCalificaciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Calificaciones"
        CType(Me.dgvListaCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListaCalificaciones As DataGridView
    Friend WithEvents btnEliminarCalificaciones As Button
End Class
