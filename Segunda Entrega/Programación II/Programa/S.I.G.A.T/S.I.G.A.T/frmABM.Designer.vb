<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABM))
        Me.rdoID = New System.Windows.Forms.RadioButton()
        Me.rdoNombre = New System.Windows.Forms.RadioButton()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.panelGeneral = New System.Windows.Forms.Panel()
        Me.lblEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombreAnimal = New System.Windows.Forms.TextBox()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.panelGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoID
        '
        Me.rdoID.AutoSize = True
        Me.rdoID.Location = New System.Drawing.Point(181, 8)
        Me.rdoID.Name = "rdoID"
        Me.rdoID.Size = New System.Drawing.Size(36, 17)
        Me.rdoID.TabIndex = 19
        Me.rdoID.TabStop = True
        Me.rdoID.Text = "ID"
        Me.rdoID.UseVisualStyleBackColor = True
        '
        'rdoNombre
        '
        Me.rdoNombre.AutoSize = True
        Me.rdoNombre.Location = New System.Drawing.Point(113, 8)
        Me.rdoNombre.Name = "rdoNombre"
        Me.rdoNombre.Size = New System.Drawing.Size(62, 17)
        Me.rdoNombre.TabIndex = 18
        Me.rdoNombre.TabStop = True
        Me.rdoNombre.Text = "Nombre"
        Me.rdoNombre.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(329, 3)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(72, 23)
        Me.cmdBuscar.TabIndex = 17
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Enabled = False
        Me.txtBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(223, 5)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 16
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(12, 9)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(95, 17)
        Me.lblBuscar.TabIndex = 15
        Me.lblBuscar.Text = "Buscar por:"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(407, 4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(74, 23)
        Me.cmdAgregar.TabIndex = 20
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'panelGeneral
        '
        Me.panelGeneral.Controls.Add(Me.lblKg)
        Me.panelGeneral.Controls.Add(Me.txtPeso)
        Me.panelGeneral.Controls.Add(Me.lblPeso)
        Me.panelGeneral.Controls.Add(Me.txtNombreAnimal)
        Me.panelGeneral.Controls.Add(Me.lblNombre)
        Me.panelGeneral.Controls.Add(Me.cboEstablecimiento)
        Me.panelGeneral.Controls.Add(Me.lblEstablecimiento)
        Me.panelGeneral.Location = New System.Drawing.Point(12, 32)
        Me.panelGeneral.Name = "panelGeneral"
        Me.panelGeneral.Size = New System.Drawing.Size(463, 330)
        Me.panelGeneral.TabIndex = 21
        '
        'lblEstablecimiento
        '
        Me.lblEstablecimiento.AutoSize = True
        Me.lblEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstablecimiento.Location = New System.Drawing.Point(3, 11)
        Me.lblEstablecimiento.Name = "lblEstablecimiento"
        Me.lblEstablecimiento.Size = New System.Drawing.Size(208, 17)
        Me.lblEstablecimiento.TabIndex = 2
        Me.lblEstablecimiento.Text = "Animal del establecimiento:"
        '
        'cboEstablecimiento
        '
        Me.cboEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimiento.FormattingEnabled = True
        Me.cboEstablecimiento.Location = New System.Drawing.Point(217, 8)
        Me.cboEstablecimiento.MaxLength = 20
        Me.cboEstablecimiento.Name = "cboEstablecimiento"
        Me.cboEstablecimiento.Size = New System.Drawing.Size(243, 25)
        Me.cboEstablecimiento.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(149, 17)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre del animal:"
        '
        'txtNombreAnimal
        '
        Me.txtNombreAnimal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAnimal.Location = New System.Drawing.Point(158, 37)
        Me.txtNombreAnimal.MaxLength = 15
        Me.txtNombreAnimal.Multiline = True
        Me.txtNombreAnimal.Name = "txtNombreAnimal"
        Me.txtNombreAnimal.Size = New System.Drawing.Size(143, 20)
        Me.txtNombreAnimal.TabIndex = 5
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg.Location = New System.Drawing.Point(123, 68)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(28, 17)
        Me.lblKg.TabIndex = 18
        Me.lblKg.Text = "Kg"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(58, 65)
        Me.txtPeso.MaxLength = 5
        Me.txtPeso.Multiline = True
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(57, 20)
        Me.txtPeso.TabIndex = 17
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(3, 68)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(49, 17)
        Me.lblPeso.TabIndex = 16
        Me.lblPeso.Text = "Peso:"
        '
        'frmABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(487, 374)
        Me.Controls.Add(Me.panelGeneral)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.rdoID)
        Me.Controls.Add(Me.rdoNombre)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmABM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - General Animales"
        Me.panelGeneral.ResumeLayout(False)
        Me.panelGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoID As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNombre As System.Windows.Forms.RadioButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents panelGeneral As System.Windows.Forms.Panel
    Friend WithEvents lblEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents txtNombreAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimiento As System.Windows.Forms.ComboBox
End Class
