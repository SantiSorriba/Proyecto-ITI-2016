<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoteos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoteos))
        Me.lblNombreLoteo = New System.Windows.Forms.Label()
        Me.txtNombreLoteo = New System.Windows.Forms.TextBox()
        Me.lblCantAnimales = New System.Windows.Forms.Label()
        Me.txtCantAnimales = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.lblRealizara = New System.Windows.Forms.Label()
        Me.cboOrdenies = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNombreLoteo
        '
        Me.lblNombreLoteo.AutoSize = True
        Me.lblNombreLoteo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreLoteo.Location = New System.Drawing.Point(3, 9)
        Me.lblNombreLoteo.Name = "lblNombreLoteo"
        Me.lblNombreLoteo.Size = New System.Drawing.Size(122, 15)
        Me.lblNombreLoteo.TabIndex = 0
        Me.lblNombreLoteo.Text = "Nombre del loteo:"
        '
        'txtNombreLoteo
        '
        Me.txtNombreLoteo.Location = New System.Drawing.Point(131, 7)
        Me.txtNombreLoteo.Name = "txtNombreLoteo"
        Me.txtNombreLoteo.Size = New System.Drawing.Size(266, 20)
        Me.txtNombreLoteo.TabIndex = 1
        '
        'lblCantAnimales
        '
        Me.lblCantAnimales.AutoSize = True
        Me.lblCantAnimales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantAnimales.Location = New System.Drawing.Point(3, 40)
        Me.lblCantAnimales.Name = "lblCantAnimales"
        Me.lblCantAnimales.Size = New System.Drawing.Size(151, 15)
        Me.lblCantAnimales.TabIndex = 2
        Me.lblCantAnimales.Text = "Cantidad de animales:"
        '
        'txtCantAnimales
        '
        Me.txtCantAnimales.Location = New System.Drawing.Point(160, 35)
        Me.txtCantAnimales.Name = "txtCantAnimales"
        Me.txtCantAnimales.Size = New System.Drawing.Size(55, 20)
        Me.txtCantAnimales.TabIndex = 3
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(6, 102)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(178, 23)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar loteo"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(219, 102)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(178, 23)
        Me.cmdVolver.TabIndex = 9
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'lblRealizara
        '
        Me.lblRealizara.AutoSize = True
        Me.lblRealizara.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRealizara.Location = New System.Drawing.Point(3, 71)
        Me.lblRealizara.Name = "lblRealizara"
        Me.lblRealizara.Size = New System.Drawing.Size(124, 15)
        Me.lblRealizara.TabIndex = 10
        Me.lblRealizara.Text = "Se realizara en el:"
        '
        'cboOrdenies
        '
        Me.cboOrdenies.FormattingEnabled = True
        Me.cboOrdenies.Items.AddRange(New Object() {"Primer ordeñe", "Segundo ordeñe", "Tercer ordeñe"})
        Me.cboOrdenies.Location = New System.Drawing.Point(133, 69)
        Me.cboOrdenies.Name = "cboOrdenies"
        Me.cboOrdenies.Size = New System.Drawing.Size(156, 21)
        Me.cboOrdenies.TabIndex = 11
        '
        'frmLoteos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(409, 137)
        Me.Controls.Add(Me.cboOrdenies)
        Me.Controls.Add(Me.lblRealizara)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.txtCantAnimales)
        Me.Controls.Add(Me.lblCantAnimales)
        Me.Controls.Add(Me.txtNombreLoteo)
        Me.Controls.Add(Me.lblNombreLoteo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLoteos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Loteos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreLoteo As System.Windows.Forms.Label
    Friend WithEvents txtNombreLoteo As System.Windows.Forms.TextBox
    Friend WithEvents lblCantAnimales As System.Windows.Forms.Label
    Friend WithEvents txtCantAnimales As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents lblRealizara As System.Windows.Forms.Label
    Friend WithEvents cboOrdenies As System.Windows.Forms.ComboBox
End Class
