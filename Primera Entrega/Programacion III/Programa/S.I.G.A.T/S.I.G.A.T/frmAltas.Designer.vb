<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltas))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimientos = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.rdoJersey = New System.Windows.Forms.RadioButton()
        Me.rdoHolando = New System.Windows.Forms.RadioButton()
        Me.rdoPrimerShow = New System.Windows.Forms.RadioButton()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.lblAnios = New System.Windows.Forms.Label()
        Me.txtEdadMeses = New System.Windows.Forms.TextBox()
        Me.lblMeses = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(2, 43)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(149, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre del animal:"
        '
        'lblEstablecimiento
        '
        Me.lblEstablecimiento.AutoSize = True
        Me.lblEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstablecimiento.Location = New System.Drawing.Point(2, 12)
        Me.lblEstablecimiento.Name = "lblEstablecimiento"
        Me.lblEstablecimiento.Size = New System.Drawing.Size(129, 17)
        Me.lblEstablecimiento.TabIndex = 1
        Me.lblEstablecimiento.Text = "Establecimiento:"
        '
        'cboEstablecimientos
        '
        Me.cboEstablecimientos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimientos.FormattingEnabled = True
        Me.cboEstablecimientos.Location = New System.Drawing.Point(147, 6)
        Me.cboEstablecimientos.Name = "cboEstablecimientos"
        Me.cboEstablecimientos.Size = New System.Drawing.Size(261, 23)
        Me.cboEstablecimientos.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(157, 40)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(251, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(2, 75)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(50, 17)
        Me.lblRaza.TabIndex = 4
        Me.lblRaza.Text = "Raza:"
        '
        'rdoJersey
        '
        Me.rdoJersey.AutoSize = True
        Me.rdoJersey.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoJersey.Location = New System.Drawing.Point(73, 75)
        Me.rdoJersey.Name = "rdoJersey"
        Me.rdoJersey.Size = New System.Drawing.Size(68, 19)
        Me.rdoJersey.TabIndex = 5
        Me.rdoJersey.TabStop = True
        Me.rdoJersey.Text = "Jersey"
        Me.rdoJersey.UseVisualStyleBackColor = True
        '
        'rdoHolando
        '
        Me.rdoHolando.AutoSize = True
        Me.rdoHolando.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHolando.Location = New System.Drawing.Point(157, 75)
        Me.rdoHolando.Name = "rdoHolando"
        Me.rdoHolando.Size = New System.Drawing.Size(79, 19)
        Me.rdoHolando.TabIndex = 6
        Me.rdoHolando.TabStop = True
        Me.rdoHolando.Text = "Holando"
        Me.rdoHolando.UseVisualStyleBackColor = True
        '
        'rdoPrimerShow
        '
        Me.rdoPrimerShow.AutoSize = True
        Me.rdoPrimerShow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPrimerShow.Location = New System.Drawing.Point(251, 75)
        Me.rdoPrimerShow.Name = "rdoPrimerShow"
        Me.rdoPrimerShow.Size = New System.Drawing.Size(109, 19)
        Me.rdoPrimerShow.TabIndex = 7
        Me.rdoPrimerShow.TabStop = True
        Me.rdoPrimerShow.Text = "Primer Show"
        Me.rdoPrimerShow.UseVisualStyleBackColor = True
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(2, 106)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(99, 17)
        Me.lblEdad.TabIndex = 8
        Me.lblEdad.Text = "Edad actual:"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(107, 103)
        Me.txtEdad.Multiline = True
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(44, 20)
        Me.txtEdad.TabIndex = 9
        '
        'lblAnios
        '
        Me.lblAnios.AutoSize = True
        Me.lblAnios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnios.Location = New System.Drawing.Point(157, 106)
        Me.lblAnios.Name = "lblAnios"
        Me.lblAnios.Size = New System.Drawing.Size(45, 17)
        Me.lblAnios.TabIndex = 10
        Me.lblAnios.Text = "Años"
        '
        'txtEdadMeses
        '
        Me.txtEdadMeses.Location = New System.Drawing.Point(213, 103)
        Me.txtEdadMeses.Multiline = True
        Me.txtEdadMeses.Name = "txtEdadMeses"
        Me.txtEdadMeses.Size = New System.Drawing.Size(44, 20)
        Me.txtEdadMeses.TabIndex = 11
        '
        'lblMeses
        '
        Me.lblMeses.AutoSize = True
        Me.lblMeses.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeses.Location = New System.Drawing.Point(263, 106)
        Me.lblMeses.Name = "lblMeses"
        Me.lblMeses.Size = New System.Drawing.Size(54, 17)
        Me.lblMeses.TabIndex = 12
        Me.lblMeses.Text = "Meses"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(3, 135)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(49, 17)
        Me.lblPeso.TabIndex = 13
        Me.lblPeso.Text = "Peso:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(58, 132)
        Me.txtPeso.Multiline = True
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(57, 20)
        Me.txtPeso.TabIndex = 14
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg.Location = New System.Drawing.Point(123, 135)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(28, 17)
        Me.lblKg.TabIndex = 15
        Me.lblKg.Text = "Kg"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(5, 168)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(197, 29)
        Me.cmdAgregar.TabIndex = 16
        Me.cmdAgregar.Text = "Agregar animal"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(213, 168)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(195, 29)
        Me.cmdVolver.TabIndex = 17
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(420, 205)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.lblKg)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblMeses)
        Me.Controls.Add(Me.txtEdadMeses)
        Me.Controls.Add(Me.lblAnios)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.rdoPrimerShow)
        Me.Controls.Add(Me.rdoHolando)
        Me.Controls.Add(Me.rdoJersey)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cboEstablecimientos)
        Me.Controls.Add(Me.lblEstablecimiento)
        Me.Controls.Add(Me.lblNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAltas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Alta de animal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents rdoJersey As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHolando As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPrimerShow As System.Windows.Forms.RadioButton
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents lblAnios As System.Windows.Forms.Label
    Friend WithEvents txtEdadMeses As System.Windows.Forms.TextBox
    Friend WithEvents lblMeses As System.Windows.Forms.Label
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
