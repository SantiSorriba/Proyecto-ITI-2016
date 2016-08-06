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
        Me.rdoID = New System.Windows.Forms.RadioButton()
        Me.rdoNombre = New System.Windows.Forms.RadioButton()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblSeleccioneEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimientos = New System.Windows.Forms.ComboBox()
        Me.gridAnimales = New System.Windows.Forms.DataGridView()
        CType(Me.gridAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoID
        '
        Me.rdoID.AutoSize = True
        Me.rdoID.Location = New System.Drawing.Point(181, 37)
        Me.rdoID.Name = "rdoID"
        Me.rdoID.Size = New System.Drawing.Size(36, 17)
        Me.rdoID.TabIndex = 24
        Me.rdoID.TabStop = True
        Me.rdoID.Text = "ID"
        Me.rdoID.UseVisualStyleBackColor = True
        '
        'rdoNombre
        '
        Me.rdoNombre.AutoSize = True
        Me.rdoNombre.Location = New System.Drawing.Point(113, 37)
        Me.rdoNombre.Name = "rdoNombre"
        Me.rdoNombre.Size = New System.Drawing.Size(62, 17)
        Me.rdoNombre.TabIndex = 23
        Me.rdoNombre.TabStop = True
        Me.rdoNombre.Text = "Nombre"
        Me.rdoNombre.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(329, 32)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(72, 23)
        Me.cmdBuscar.TabIndex = 22
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Enabled = False
        Me.txtBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(223, 34)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 21
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(12, 36)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(95, 17)
        Me.lblBuscar.TabIndex = 20
        Me.lblBuscar.Text = "Buscar por:"
        '
        'lblSeleccioneEstablecimiento
        '
        Me.lblSeleccioneEstablecimiento.AutoSize = True
        Me.lblSeleccioneEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccioneEstablecimiento.Location = New System.Drawing.Point(12, 9)
        Me.lblSeleccioneEstablecimiento.Name = "lblSeleccioneEstablecimiento"
        Me.lblSeleccioneEstablecimiento.Size = New System.Drawing.Size(129, 17)
        Me.lblSeleccioneEstablecimiento.TabIndex = 25
        Me.lblSeleccioneEstablecimiento.Text = "Establecimiento:"
        '
        'cboEstablecimientos
        '
        Me.cboEstablecimientos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimientos.FormattingEnabled = True
        Me.cboEstablecimientos.Location = New System.Drawing.Point(147, 5)
        Me.cboEstablecimientos.MaxLength = 20
        Me.cboEstablecimientos.Name = "cboEstablecimientos"
        Me.cboEstablecimientos.Size = New System.Drawing.Size(255, 23)
        Me.cboEstablecimientos.TabIndex = 26
        '
        'gridAnimales
        '
        Me.gridAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAnimales.Location = New System.Drawing.Point(12, 60)
        Me.gridAnimales.Name = "gridAnimales"
        Me.gridAnimales.Size = New System.Drawing.Size(389, 271)
        Me.gridAnimales.TabIndex = 27
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(414, 344)
        Me.Controls.Add(Me.gridAnimales)
        Me.Controls.Add(Me.cboEstablecimientos)
        Me.Controls.Add(Me.lblSeleccioneEstablecimiento)
        Me.Controls.Add(Me.rdoID)
        Me.Controls.Add(Me.rdoNombre)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Inventario de Animales"
        CType(Me.gridAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoID As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNombre As System.Windows.Forms.RadioButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblSeleccioneEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents gridAnimales As System.Windows.Forms.DataGridView
End Class
