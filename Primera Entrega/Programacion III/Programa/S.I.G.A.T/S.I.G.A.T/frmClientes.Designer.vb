<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.listClientes = New System.Windows.Forms.ListBox()
        Me.cmdDatosCliente = New System.Windows.Forms.Button()
        Me.cmdHistorialCliente = New System.Windows.Forms.Button()
        Me.cmdNuevoCliente = New System.Windows.Forms.Button()
        Me.cmdBorrarCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listClientes
        '
        Me.listClientes.BackColor = System.Drawing.Color.Beige
        Me.listClientes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClientes.FormattingEnabled = True
        Me.listClientes.ItemHeight = 17
        Me.listClientes.Items.AddRange(New Object() {"Cliente 1", "Cliente 2", "Cliente 3"})
        Me.listClientes.Location = New System.Drawing.Point(12, 6)
        Me.listClientes.Name = "listClientes"
        Me.listClientes.Size = New System.Drawing.Size(310, 174)
        Me.listClientes.TabIndex = 0
        '
        'cmdDatosCliente
        '
        Me.cmdDatosCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatosCliente.Location = New System.Drawing.Point(12, 225)
        Me.cmdDatosCliente.Name = "cmdDatosCliente"
        Me.cmdDatosCliente.Size = New System.Drawing.Size(149, 26)
        Me.cmdDatosCliente.TabIndex = 1
        Me.cmdDatosCliente.Text = "Ver datos del cliente"
        Me.cmdDatosCliente.UseVisualStyleBackColor = True
        '
        'cmdHistorialCliente
        '
        Me.cmdHistorialCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistorialCliente.Location = New System.Drawing.Point(173, 225)
        Me.cmdHistorialCliente.Name = "cmdHistorialCliente"
        Me.cmdHistorialCliente.Size = New System.Drawing.Size(149, 26)
        Me.cmdHistorialCliente.TabIndex = 2
        Me.cmdHistorialCliente.Text = "Ver historial "
        Me.cmdHistorialCliente.UseVisualStyleBackColor = True
        '
        'cmdNuevoCliente
        '
        Me.cmdNuevoCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevoCliente.Location = New System.Drawing.Point(12, 193)
        Me.cmdNuevoCliente.Name = "cmdNuevoCliente"
        Me.cmdNuevoCliente.Size = New System.Drawing.Size(149, 26)
        Me.cmdNuevoCliente.TabIndex = 3
        Me.cmdNuevoCliente.Text = "Nuevo cliente"
        Me.cmdNuevoCliente.UseVisualStyleBackColor = True
        '
        'cmdBorrarCliente
        '
        Me.cmdBorrarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrarCliente.Location = New System.Drawing.Point(173, 193)
        Me.cmdBorrarCliente.Name = "cmdBorrarCliente"
        Me.cmdBorrarCliente.Size = New System.Drawing.Size(149, 26)
        Me.cmdBorrarCliente.TabIndex = 4
        Me.cmdBorrarCliente.Text = "Borrar cliente"
        Me.cmdBorrarCliente.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(334, 262)
        Me.Controls.Add(Me.cmdBorrarCliente)
        Me.Controls.Add(Me.cmdNuevoCliente)
        Me.Controls.Add(Me.cmdHistorialCliente)
        Me.Controls.Add(Me.cmdDatosCliente)
        Me.Controls.Add(Me.listClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Clientes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listClientes As System.Windows.Forms.ListBox
    Friend WithEvents cmdDatosCliente As System.Windows.Forms.Button
    Friend WithEvents cmdHistorialCliente As System.Windows.Forms.Button
    Friend WithEvents cmdNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents cmdBorrarCliente As System.Windows.Forms.Button
End Class
