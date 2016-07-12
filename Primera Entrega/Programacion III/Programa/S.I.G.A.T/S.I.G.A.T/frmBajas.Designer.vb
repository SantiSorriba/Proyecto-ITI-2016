<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBajas))
        Me.rdoID = New System.Windows.Forms.RadioButton()
        Me.rdoNombre = New System.Windows.Forms.RadioButton()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.groupDatosAnimal = New System.Windows.Forms.GroupBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblPrimerShow = New System.Windows.Forms.Label()
        Me.lblHolando = New System.Windows.Forms.Label()
        Me.lblJersey = New System.Windows.Forms.Label()
        Me.lblMacho = New System.Windows.Forms.Label()
        Me.lblHembra = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblEstadoActual = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmdDarBaja = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.groupDatosAnimal.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoID
        '
        Me.rdoID.AutoSize = True
        Me.rdoID.Location = New System.Drawing.Point(181, 9)
        Me.rdoID.Name = "rdoID"
        Me.rdoID.Size = New System.Drawing.Size(36, 17)
        Me.rdoID.TabIndex = 14
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
        Me.rdoNombre.TabIndex = 13
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
        Me.cmdBuscar.TabIndex = 12
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
        Me.txtBuscar.TabIndex = 11
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(12, 9)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(95, 17)
        Me.lblBuscar.TabIndex = 10
        Me.lblBuscar.Text = "Buscar por:"
        '
        'groupDatosAnimal
        '
        Me.groupDatosAnimal.Controls.Add(Me.txtEdad)
        Me.groupDatosAnimal.Controls.Add(Me.lblEdad)
        Me.groupDatosAnimal.Controls.Add(Me.txtFechaIngreso)
        Me.groupDatosAnimal.Controls.Add(Me.txtEstado)
        Me.groupDatosAnimal.Controls.Add(Me.lblPrimerShow)
        Me.groupDatosAnimal.Controls.Add(Me.lblHolando)
        Me.groupDatosAnimal.Controls.Add(Me.lblJersey)
        Me.groupDatosAnimal.Controls.Add(Me.lblMacho)
        Me.groupDatosAnimal.Controls.Add(Me.lblHembra)
        Me.groupDatosAnimal.Controls.Add(Me.txtNombre)
        Me.groupDatosAnimal.Controls.Add(Me.txtID)
        Me.groupDatosAnimal.Controls.Add(Me.lblTipo)
        Me.groupDatosAnimal.Controls.Add(Me.lblRaza)
        Me.groupDatosAnimal.Controls.Add(Me.lblEstadoActual)
        Me.groupDatosAnimal.Controls.Add(Me.lblFechaIngreso)
        Me.groupDatosAnimal.Controls.Add(Me.lblId)
        Me.groupDatosAnimal.Controls.Add(Me.lblNombre)
        Me.groupDatosAnimal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupDatosAnimal.Location = New System.Drawing.Point(15, 32)
        Me.groupDatosAnimal.Name = "groupDatosAnimal"
        Me.groupDatosAnimal.Size = New System.Drawing.Size(386, 164)
        Me.groupDatosAnimal.TabIndex = 15
        Me.groupDatosAnimal.TabStop = False
        Me.groupDatosAnimal.Text = "Datos de animal"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(316, 75)
        Me.txtEdad.Multiline = True
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(41, 18)
        Me.txtEdad.TabIndex = 16
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(256, 78)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(44, 15)
        Me.lblEdad.TabIndex = 15
        Me.lblEdad.Text = "Edad:"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Location = New System.Drawing.Point(269, 28)
        Me.txtFechaIngreso.Multiline = True
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(100, 18)
        Me.txtFechaIngreso.TabIndex = 14
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(112, 129)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 18)
        Me.txtEstado.TabIndex = 13
        '
        'lblPrimerShow
        '
        Me.lblPrimerShow.AutoSize = True
        Me.lblPrimerShow.Enabled = False
        Me.lblPrimerShow.Location = New System.Drawing.Point(228, 105)
        Me.lblPrimerShow.Name = "lblPrimerShow"
        Me.lblPrimerShow.Size = New System.Drawing.Size(102, 15)
        Me.lblPrimerShow.TabIndex = 12
        Me.lblPrimerShow.Text = "PRIMER SHOW"
        '
        'lblHolando
        '
        Me.lblHolando.AutoSize = True
        Me.lblHolando.Enabled = False
        Me.lblHolando.Location = New System.Drawing.Point(137, 105)
        Me.lblHolando.Name = "lblHolando"
        Me.lblHolando.Size = New System.Drawing.Size(74, 15)
        Me.lblHolando.TabIndex = 11
        Me.lblHolando.Text = "HOLANDO"
        '
        'lblJersey
        '
        Me.lblJersey.AutoSize = True
        Me.lblJersey.Enabled = False
        Me.lblJersey.Location = New System.Drawing.Point(59, 105)
        Me.lblJersey.Name = "lblJersey"
        Me.lblJersey.Size = New System.Drawing.Size(58, 15)
        Me.lblJersey.TabIndex = 10
        Me.lblJersey.Text = "JERSEY"
        '
        'lblMacho
        '
        Me.lblMacho.AutoSize = True
        Me.lblMacho.Enabled = False
        Me.lblMacho.Location = New System.Drawing.Point(53, 78)
        Me.lblMacho.Name = "lblMacho"
        Me.lblMacho.Size = New System.Drawing.Size(57, 15)
        Me.lblMacho.TabIndex = 9
        Me.lblMacho.Text = "MACHO"
        '
        'lblHembra
        '
        Me.lblHembra.AutoSize = True
        Me.lblHembra.Enabled = False
        Me.lblHembra.Location = New System.Drawing.Point(119, 78)
        Me.lblHembra.Name = "lblHembra"
        Me.lblHembra.Size = New System.Drawing.Size(64, 15)
        Me.lblHembra.TabIndex = 8
        Me.lblHembra.Text = "HEMBRA"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 51)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(166, 18)
        Me.txtNombre.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(47, 25)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(45, 18)
        Me.txtID.TabIndex = 6
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(6, 78)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 15)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "Tipo:"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(6, 105)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(43, 15)
        Me.lblRaza.TabIndex = 4
        Me.lblRaza.Text = "Raza:"
        '
        'lblEstadoActual
        '
        Me.lblEstadoActual.AutoSize = True
        Me.lblEstadoActual.Location = New System.Drawing.Point(6, 132)
        Me.lblEstadoActual.Name = "lblEstadoActual"
        Me.lblEstadoActual.Size = New System.Drawing.Size(100, 15)
        Me.lblEstadoActual.TabIndex = 3
        Me.lblEstadoActual.Text = "Estado actual:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(137, 28)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(122, 15)
        Me.lblFechaIngreso.TabIndex = 2
        Me.lblFechaIngreso.Text = "Fecha de ingreso:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(6, 28)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(25, 15)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 54)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 15)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'cmdDarBaja
        '
        Me.cmdDarBaja.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDarBaja.Location = New System.Drawing.Point(15, 202)
        Me.cmdDarBaja.Name = "cmdDarBaja"
        Me.cmdDarBaja.Size = New System.Drawing.Size(135, 29)
        Me.cmdDarBaja.TabIndex = 16
        Me.cmdDarBaja.Text = "Dar de baja"
        Me.cmdDarBaja.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(266, 202)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(135, 29)
        Me.cmdVolver.TabIndex = 17
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(413, 237)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdDarBaja)
        Me.Controls.Add(Me.groupDatosAnimal)
        Me.Controls.Add(Me.rdoID)
        Me.Controls.Add(Me.rdoNombre)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Baja de animales"
        Me.groupDatosAnimal.ResumeLayout(False)
        Me.groupDatosAnimal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoID As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNombre As System.Windows.Forms.RadioButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents groupDatosAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents lblPrimerShow As System.Windows.Forms.Label
    Friend WithEvents lblHolando As System.Windows.Forms.Label
    Friend WithEvents lblJersey As System.Windows.Forms.Label
    Friend WithEvents lblMacho As System.Windows.Forms.Label
    Friend WithEvents lblHembra As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblEstadoActual As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents cmdDarBaja As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
