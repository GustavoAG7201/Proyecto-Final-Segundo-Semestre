<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCorreoUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasenaUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de inicio de sesion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña"
        '
        'txtCorreoUsuario
        '
        Me.txtCorreoUsuario.Location = New System.Drawing.Point(24, 71)
        Me.txtCorreoUsuario.Name = "txtCorreoUsuario"
        Me.txtCorreoUsuario.Size = New System.Drawing.Size(181, 20)
        Me.txtCorreoUsuario.TabIndex = 5
        '
        'txtContrasenaUsuario
        '
        Me.txtContrasenaUsuario.Location = New System.Drawing.Point(234, 71)
        Me.txtContrasenaUsuario.Name = "txtContrasenaUsuario"
        Me.txtContrasenaUsuario.Size = New System.Drawing.Size(181, 20)
        Me.txtContrasenaUsuario.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Datos Generales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(24, 170)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(181, 20)
        Me.txtNombreUsuario.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Apellido Paterno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(16, 235)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(181, 20)
        Me.txtApellidoPaterno.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(230, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Apellido Materno"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(234, 235)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(181, 20)
        Me.txtApellidoMaterno.TabIndex = 13
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(24, 296)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(340, 296)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmAgregarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 327)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtContrasenaUsuario)
        Me.Controls.Add(Me.txtCorreoUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCorreoUsuario As TextBox
    Friend WithEvents txtContrasenaUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
