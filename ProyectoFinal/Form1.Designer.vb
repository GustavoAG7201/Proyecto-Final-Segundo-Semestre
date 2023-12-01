<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.AlumnosToolStripMenuItem, Me.MateriasToolStripMenuItem, Me.CalificacionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ListaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListaToolStripMenuItem.Text = "Lista"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem1, Me.ListaToolStripMenuItem1})
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'AgregarToolStripMenuItem1
        '
        Me.AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        Me.AgregarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem1.Text = "Agregar"
        '
        'ListaToolStripMenuItem1
        '
        Me.ListaToolStripMenuItem1.Name = "ListaToolStripMenuItem1"
        Me.ListaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ListaToolStripMenuItem1.Text = "Lista"
        '
        'MateriasToolStripMenuItem
        '
        Me.MateriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem2, Me.ListaToolStripMenuItem2})
        Me.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        Me.MateriasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MateriasToolStripMenuItem.Text = "Materias"
        '
        'AgregarToolStripMenuItem2
        '
        Me.AgregarToolStripMenuItem2.Name = "AgregarToolStripMenuItem2"
        Me.AgregarToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.AgregarToolStripMenuItem2.Text = "Agregar"
        '
        'ListaToolStripMenuItem2
        '
        Me.ListaToolStripMenuItem2.Name = "ListaToolStripMenuItem2"
        Me.ListaToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.ListaToolStripMenuItem2.Text = "Lista"
        '
        'CalificacionesToolStripMenuItem
        '
        Me.CalificacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem3, Me.ListaToolStripMenuItem3})
        Me.CalificacionesToolStripMenuItem.Name = "CalificacionesToolStripMenuItem"
        Me.CalificacionesToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.CalificacionesToolStripMenuItem.Text = "Calificaciones"
        '
        'AgregarToolStripMenuItem3
        '
        Me.AgregarToolStripMenuItem3.Name = "AgregarToolStripMenuItem3"
        Me.AgregarToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem3.Text = "Agregar"
        '
        'ListaToolStripMenuItem3
        '
        Me.ListaToolStripMenuItem3.Name = "ListaToolStripMenuItem3"
        Me.ListaToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ListaToolStripMenuItem3.Text = "Lista"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 405)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CalificacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem3 As ToolStripMenuItem
End Class
