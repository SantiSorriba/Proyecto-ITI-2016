<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBajaUsuario))
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblApellidoUsu = New System.Windows.Forms.Label()
        Me.lblNombreUsu = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.cmdEliminarUsu = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(226, 9)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(95, 31)
        Me.cmdBuscar.TabIndex = 5
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtCi
        '
        Me.txtCi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCi.Location = New System.Drawing.Point(81, 13)
        Me.txtCi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(137, 22)
        Me.txtCi.TabIndex = 4
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(4, 14)
        Me.lblCi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(69, 18)
        Me.lblCi.TabIndex = 3
        Me.lblCi.Text = "Cédula:"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 9
        Me.LineShape1.X2 = 319
        Me.LineShape1.Y1 = 48
        Me.LineShape1.Y2 = 48
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(334, 217)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'lblApellidoUsu
        '
        Me.lblApellidoUsu.AutoSize = True
        Me.lblApellidoUsu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoUsu.Location = New System.Drawing.Point(125, 86)
        Me.lblApellidoUsu.Name = "lblApellidoUsu"
        Me.lblApellidoUsu.Size = New System.Drawing.Size(166, 18)
        Me.lblApellidoUsu.TabIndex = 25
        Me.lblApellidoUsu.Text = "Apellido del Usuario"
        '
        'lblNombreUsu
        '
        Me.lblNombreUsu.AutoSize = True
        Me.lblNombreUsu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsu.Location = New System.Drawing.Point(125, 60)
        Me.lblNombreUsu.Name = "lblNombreUsu"
        Me.lblNombreUsu.Size = New System.Drawing.Size(165, 18)
        Me.lblNombreUsu.TabIndex = 24
        Me.lblNombreUsu.Text = "Nombre del Usuario"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(13, 86)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(72, 17)
        Me.lblApellido.TabIndex = 23
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(13, 60)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 17)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre:"
        '
        'lblActivo
        '
        Me.lblActivo.AutoSize = True
        Me.lblActivo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(12, 115)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(107, 17)
        Me.lblActivo.TabIndex = 26
        Me.lblActivo.Text = "Activo desde:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.Location = New System.Drawing.Point(170, 115)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(96, 18)
        Me.lblFechaIngreso.TabIndex = 27
        Me.lblFechaIngreso.Text = "01/01/1900"
        '
        'cmdEliminarUsu
        '
        Me.cmdEliminarUsu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarUsu.Location = New System.Drawing.Point(9, 145)
        Me.cmdEliminarUsu.Name = "cmdEliminarUsu"
        Me.cmdEliminarUsu.Size = New System.Drawing.Size(308, 29)
        Me.cmdEliminarUsu.TabIndex = 28
        Me.cmdEliminarUsu.Text = "Eliminar Usuario"
        Me.cmdEliminarUsu.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(9, 179)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(308, 29)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmBajaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(334, 217)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdEliminarUsu)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Controls.Add(Me.lblActivo)
        Me.Controls.Add(Me.lblApellidoUsu)
        Me.Controls.Add(Me.lblNombreUsu)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBajaUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Eliminar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblApellidoUsu As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsu As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblActivo As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents cmdEliminarUsu As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
