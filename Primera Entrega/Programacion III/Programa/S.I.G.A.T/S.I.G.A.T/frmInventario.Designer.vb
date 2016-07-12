<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.listAnimales = New System.Windows.Forms.ListBox()
        Me.cmdDatosGenerales = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.rdoNombre = New System.Windows.Forms.RadioButton()
        Me.rdoID = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(2, 9)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(95, 17)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Enabled = False
        Me.txtBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(215, 6)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(321, 5)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(72, 23)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'listAnimales
        '
        Me.listAnimales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listAnimales.FormattingEnabled = True
        Me.listAnimales.ItemHeight = 15
        Me.listAnimales.Items.AddRange(New Object() {"Animal 1", "Animal 2", "Animal 3"})
        Me.listAnimales.Location = New System.Drawing.Point(12, 31)
        Me.listAnimales.Name = "listAnimales"
        Me.listAnimales.Size = New System.Drawing.Size(381, 364)
        Me.listAnimales.TabIndex = 5
        '
        'cmdDatosGenerales
        '
        Me.cmdDatosGenerales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatosGenerales.Location = New System.Drawing.Point(12, 401)
        Me.cmdDatosGenerales.Name = "cmdDatosGenerales"
        Me.cmdDatosGenerales.Size = New System.Drawing.Size(154, 23)
        Me.cmdDatosGenerales.TabIndex = 6
        Me.cmdDatosGenerales.Text = "Ver datos generales"
        Me.cmdDatosGenerales.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(239, 401)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(154, 23)
        Me.cmdVolver.TabIndex = 7
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'rdoNombre
        '
        Me.rdoNombre.AutoSize = True
        Me.rdoNombre.Location = New System.Drawing.Point(103, 8)
        Me.rdoNombre.Name = "rdoNombre"
        Me.rdoNombre.Size = New System.Drawing.Size(62, 17)
        Me.rdoNombre.TabIndex = 8
        Me.rdoNombre.TabStop = True
        Me.rdoNombre.Text = "Nombre"
        Me.rdoNombre.UseVisualStyleBackColor = True
        '
        'rdoID
        '
        Me.rdoID.AutoSize = True
        Me.rdoID.Location = New System.Drawing.Point(171, 9)
        Me.rdoID.Name = "rdoID"
        Me.rdoID.Size = New System.Drawing.Size(36, 17)
        Me.rdoID.TabIndex = 9
        Me.rdoID.TabStop = True
        Me.rdoID.Text = "ID"
        Me.rdoID.UseVisualStyleBackColor = True
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(405, 433)
        Me.Controls.Add(Me.rdoID)
        Me.Controls.Add(Me.rdoNombre)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdDatosGenerales)
        Me.Controls.Add(Me.listAnimales)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents listAnimales As System.Windows.Forms.ListBox
    Friend WithEvents cmdDatosGenerales As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents rdoNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rdoID As System.Windows.Forms.RadioButton
End Class
