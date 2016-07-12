<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.listProveedores = New System.Windows.Forms.ListBox()
        Me.cmdBorrarProveedor = New System.Windows.Forms.Button()
        Me.cmdNuevoProveedor = New System.Windows.Forms.Button()
        Me.cmdHistorialProveedor = New System.Windows.Forms.Button()
        Me.cmdDatosProveedor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listProveedores
        '
        Me.listProveedores.BackColor = System.Drawing.Color.Beige
        Me.listProveedores.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listProveedores.FormattingEnabled = True
        Me.listProveedores.ItemHeight = 17
        Me.listProveedores.Items.AddRange(New Object() {"Proveedor 1", "Proveedor 2", "Proveedor 3"})
        Me.listProveedores.Location = New System.Drawing.Point(12, 12)
        Me.listProveedores.Name = "listProveedores"
        Me.listProveedores.Size = New System.Drawing.Size(310, 174)
        Me.listProveedores.TabIndex = 1
        '
        'cmdBorrarProveedor
        '
        Me.cmdBorrarProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrarProveedor.Location = New System.Drawing.Point(173, 196)
        Me.cmdBorrarProveedor.Name = "cmdBorrarProveedor"
        Me.cmdBorrarProveedor.Size = New System.Drawing.Size(149, 26)
        Me.cmdBorrarProveedor.TabIndex = 8
        Me.cmdBorrarProveedor.Text = "Borrar proveedor"
        Me.cmdBorrarProveedor.UseVisualStyleBackColor = True
        '
        'cmdNuevoProveedor
        '
        Me.cmdNuevoProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevoProveedor.Location = New System.Drawing.Point(12, 196)
        Me.cmdNuevoProveedor.Name = "cmdNuevoProveedor"
        Me.cmdNuevoProveedor.Size = New System.Drawing.Size(149, 26)
        Me.cmdNuevoProveedor.TabIndex = 7
        Me.cmdNuevoProveedor.Text = "Nuevo proveedor"
        Me.cmdNuevoProveedor.UseVisualStyleBackColor = True
        '
        'cmdHistorialProveedor
        '
        Me.cmdHistorialProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistorialProveedor.Location = New System.Drawing.Point(173, 228)
        Me.cmdHistorialProveedor.Name = "cmdHistorialProveedor"
        Me.cmdHistorialProveedor.Size = New System.Drawing.Size(149, 26)
        Me.cmdHistorialProveedor.TabIndex = 6
        Me.cmdHistorialProveedor.Text = "Ver historial "
        Me.cmdHistorialProveedor.UseVisualStyleBackColor = True
        '
        'cmdDatosProveedor
        '
        Me.cmdDatosProveedor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatosProveedor.Location = New System.Drawing.Point(12, 228)
        Me.cmdDatosProveedor.Name = "cmdDatosProveedor"
        Me.cmdDatosProveedor.Size = New System.Drawing.Size(149, 26)
        Me.cmdDatosProveedor.TabIndex = 5
        Me.cmdDatosProveedor.Text = "Ver datos"
        Me.cmdDatosProveedor.UseVisualStyleBackColor = True
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(334, 262)
        Me.Controls.Add(Me.cmdBorrarProveedor)
        Me.Controls.Add(Me.cmdNuevoProveedor)
        Me.Controls.Add(Me.cmdHistorialProveedor)
        Me.Controls.Add(Me.cmdDatosProveedor)
        Me.Controls.Add(Me.listProveedores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Proveedores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listProveedores As System.Windows.Forms.ListBox
    Friend WithEvents cmdBorrarProveedor As System.Windows.Forms.Button
    Friend WithEvents cmdNuevoProveedor As System.Windows.Forms.Button
    Friend WithEvents cmdHistorialProveedor As System.Windows.Forms.Button
    Friend WithEvents cmdDatosProveedor As System.Windows.Forms.Button
End Class
