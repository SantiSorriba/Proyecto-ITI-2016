<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarAnimal))
        Me.rdoID = New System.Windows.Forms.RadioButton()
        Me.rdoNombre = New System.Windows.Forms.RadioButton()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblMedicaciones = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblProgenitores = New System.Windows.Forms.Label()
        Me.lblEnfermedades = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtMedicaciones = New System.Windows.Forms.TextBox()
        Me.txtProgenitores = New System.Windows.Forms.TextBox()
        Me.txtEnfermedades = New System.Windows.Forms.TextBox()
        Me.cmdDatos = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdoID
        '
        Me.rdoID.AutoSize = True
        Me.rdoID.Location = New System.Drawing.Point(181, 9)
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
        Me.cmdBuscar.Location = New System.Drawing.Point(331, 5)
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
        Me.txtBuscar.Location = New System.Drawing.Point(225, 6)
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(411, 263)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 401
        Me.LineShape1.Y1 = 33
        Me.LineShape1.Y2 = 33
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(110, 43)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(133, 15)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre del animal:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(12, 45)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(25, 15)
        Me.lblId.TabIndex = 22
        Me.lblId.Text = "ID:"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(13, 74)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(43, 15)
        Me.lblPeso.TabIndex = 23
        Me.lblPeso.Text = "Peso:"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(174, 72)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(43, 15)
        Me.lblRaza.TabIndex = 24
        Me.lblRaza.Text = "Raza:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(259, 106)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(44, 15)
        Me.lblEdad.TabIndex = 25
        Me.lblEdad.Text = "Edad:"
        '
        'lblMedicaciones
        '
        Me.lblMedicaciones.AutoSize = True
        Me.lblMedicaciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicaciones.Location = New System.Drawing.Point(11, 133)
        Me.lblMedicaciones.Name = "lblMedicaciones"
        Me.lblMedicaciones.Size = New System.Drawing.Size(101, 15)
        Me.lblMedicaciones.TabIndex = 26
        Me.lblMedicaciones.Text = "Medicaciones:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(12, 106)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(146, 15)
        Me.lblFechaNac.TabIndex = 27
        Me.lblFechaNac.Text = "Fecha de nacimiento:"
        '
        'lblProgenitores
        '
        Me.lblProgenitores.AutoSize = True
        Me.lblProgenitores.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgenitores.Location = New System.Drawing.Point(11, 161)
        Me.lblProgenitores.Name = "lblProgenitores"
        Me.lblProgenitores.Size = New System.Drawing.Size(96, 15)
        Me.lblProgenitores.TabIndex = 28
        Me.lblProgenitores.Text = "Progenitores:"
        '
        'lblEnfermedades
        '
        Me.lblEnfermedades.AutoSize = True
        Me.lblEnfermedades.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfermedades.Location = New System.Drawing.Point(13, 190)
        Me.lblEnfermedades.Name = "lblEnfermedades"
        Me.lblEnfermedades.Size = New System.Drawing.Size(105, 15)
        Me.lblEnfermedades.TabIndex = 29
        Me.lblEnfermedades.Text = "Enfermedades:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(45, 41)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(48, 19)
        Me.txtId.TabIndex = 30
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(249, 39)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 19)
        Me.txtNombre.TabIndex = 31
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(60, 72)
        Me.txtPeso.Multiline = True
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(48, 19)
        Me.txtPeso.TabIndex = 32
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(223, 70)
        Me.txtRaza.Multiline = True
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(117, 19)
        Me.txtRaza.TabIndex = 33
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New System.Drawing.Point(164, 104)
        Me.txtFechaNac.Multiline = True
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(79, 19)
        Me.txtFechaNac.TabIndex = 34
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(309, 104)
        Me.txtEdad.Multiline = True
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(48, 19)
        Me.txtEdad.TabIndex = 35
        '
        'txtMedicaciones
        '
        Me.txtMedicaciones.Location = New System.Drawing.Point(135, 129)
        Me.txtMedicaciones.Multiline = True
        Me.txtMedicaciones.Name = "txtMedicaciones"
        Me.txtMedicaciones.Size = New System.Drawing.Size(264, 19)
        Me.txtMedicaciones.TabIndex = 36
        '
        'txtProgenitores
        '
        Me.txtProgenitores.Location = New System.Drawing.Point(135, 157)
        Me.txtProgenitores.Multiline = True
        Me.txtProgenitores.Name = "txtProgenitores"
        Me.txtProgenitores.Size = New System.Drawing.Size(264, 19)
        Me.txtProgenitores.TabIndex = 37
        '
        'txtEnfermedades
        '
        Me.txtEnfermedades.Location = New System.Drawing.Point(135, 186)
        Me.txtEnfermedades.Multiline = True
        Me.txtEnfermedades.Name = "txtEnfermedades"
        Me.txtEnfermedades.Size = New System.Drawing.Size(264, 19)
        Me.txtEnfermedades.TabIndex = 38
        '
        'cmdDatos
        '
        Me.cmdDatos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatos.Location = New System.Drawing.Point(12, 217)
        Me.cmdDatos.Name = "cmdDatos"
        Me.cmdDatos.Size = New System.Drawing.Size(183, 34)
        Me.cmdDatos.TabIndex = 39
        Me.cmdDatos.Text = "Ver datos de produccion"
        Me.cmdDatos.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(219, 217)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(183, 34)
        Me.cmdVolver.TabIndex = 40
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmConsultarAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(411, 263)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdDatos)
        Me.Controls.Add(Me.txtEnfermedades)
        Me.Controls.Add(Me.txtProgenitores)
        Me.Controls.Add(Me.txtMedicaciones)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.txtRaza)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblEnfermedades)
        Me.Controls.Add(Me.lblProgenitores)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblMedicaciones)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.rdoID)
        Me.Controls.Add(Me.rdoNombre)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsultarAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Consultar animal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoID As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNombre As System.Windows.Forms.RadioButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblMedicaciones As System.Windows.Forms.Label
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents lblProgenitores As System.Windows.Forms.Label
    Friend WithEvents lblEnfermedades As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaNac As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtMedicaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtProgenitores As System.Windows.Forms.TextBox
    Friend WithEvents txtEnfermedades As System.Windows.Forms.TextBox
    Friend WithEvents cmdDatos As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
