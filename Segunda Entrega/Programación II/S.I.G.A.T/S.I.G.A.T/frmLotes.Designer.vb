<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotes
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
        Me.lblNroLote = New System.Windows.Forms.Label()
        Me.txtNroLote = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.panelLotes = New System.Windows.Forms.Panel()
        Me.cmdAgregarAnimales = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cboCriterio = New System.Windows.Forms.ComboBox()
        Me.lblCriterio = New System.Windows.Forms.Label()
        Me.txtNombreLote = New System.Windows.Forms.TextBox()
        Me.lblNombreLote = New System.Windows.Forms.Label()
        Me.numCantAnimales = New System.Windows.Forms.NumericUpDown()
        Me.lblCantAnimales = New System.Windows.Forms.Label()
        Me.txtNumLote2 = New System.Windows.Forms.TextBox()
        Me.lblNumLote2 = New System.Windows.Forms.Label()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.panelLotes.SuspendLayout()
        CType(Me.numCantAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNroLote
        '
        Me.lblNroLote.AutoSize = True
        Me.lblNroLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroLote.Location = New System.Drawing.Point(12, 9)
        Me.lblNroLote.Name = "lblNroLote"
        Me.lblNroLote.Size = New System.Drawing.Size(104, 16)
        Me.lblNroLote.TabIndex = 0
        Me.lblNroLote.Text = "Número de Lote:"
        '
        'txtNroLote
        '
        Me.txtNroLote.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroLote.Location = New System.Drawing.Point(122, 6)
        Me.txtNroLote.MaxLength = 3
        Me.txtNroLote.Name = "txtNroLote"
        Me.txtNroLote.Size = New System.Drawing.Size(36, 25)
        Me.txtNroLote.TabIndex = 1
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(168, 4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(81, 29)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'panelLotes
        '
        Me.panelLotes.Controls.Add(Me.cmdAgregarAnimales)
        Me.panelLotes.Controls.Add(Me.cmdModificar)
        Me.panelLotes.Controls.Add(Me.cmdAgregar)
        Me.panelLotes.Controls.Add(Me.cboCriterio)
        Me.panelLotes.Controls.Add(Me.lblCriterio)
        Me.panelLotes.Controls.Add(Me.txtNombreLote)
        Me.panelLotes.Controls.Add(Me.lblNombreLote)
        Me.panelLotes.Controls.Add(Me.numCantAnimales)
        Me.panelLotes.Controls.Add(Me.lblCantAnimales)
        Me.panelLotes.Controls.Add(Me.txtNumLote2)
        Me.panelLotes.Controls.Add(Me.lblNumLote2)
        Me.panelLotes.Location = New System.Drawing.Point(12, 39)
        Me.panelLotes.Name = "panelLotes"
        Me.panelLotes.Size = New System.Drawing.Size(317, 179)
        Me.panelLotes.TabIndex = 3
        Me.panelLotes.Visible = False
        '
        'cmdAgregarAnimales
        '
        Me.cmdAgregarAnimales.Enabled = False
        Me.cmdAgregarAnimales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarAnimales.Location = New System.Drawing.Point(219, 74)
        Me.cmdAgregarAnimales.Name = "cmdAgregarAnimales"
        Me.cmdAgregarAnimales.Size = New System.Drawing.Size(75, 26)
        Me.cmdAgregarAnimales.TabIndex = 11
        Me.cmdAgregarAnimales.Text = "Agregar"
        Me.cmdAgregarAnimales.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(104, 144)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(97, 29)
        Me.cmdModificar.TabIndex = 10
        Me.cmdModificar.Text = "Modificar Lote"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(6, 144)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(92, 29)
        Me.cmdAgregar.TabIndex = 9
        Me.cmdAgregar.Text = "Agregar Lote"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cboCriterio
        '
        Me.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriterio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCriterio.FormattingEnabled = True
        Me.cboCriterio.Items.AddRange(New Object() {"Enfermedad", "Ordeñe", "Preñadas", "Secas", "Animales no productivos"})
        Me.cboCriterio.Location = New System.Drawing.Point(73, 105)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Size = New System.Drawing.Size(211, 24)
        Me.cboCriterio.TabIndex = 8
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriterio.Location = New System.Drawing.Point(3, 108)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(53, 16)
        Me.lblCriterio.TabIndex = 7
        Me.lblCriterio.Text = "Criterio:"
        '
        'txtNombreLote
        '
        Me.txtNombreLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreLote.Location = New System.Drawing.Point(116, 45)
        Me.txtNombreLote.Name = "txtNombreLote"
        Me.txtNombreLote.Size = New System.Drawing.Size(168, 22)
        Me.txtNombreLote.TabIndex = 6
        '
        'lblNombreLote
        '
        Me.lblNombreLote.AutoSize = True
        Me.lblNombreLote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreLote.Location = New System.Drawing.Point(3, 48)
        Me.lblNombreLote.Name = "lblNombreLote"
        Me.lblNombreLote.Size = New System.Drawing.Size(107, 16)
        Me.lblNombreLote.TabIndex = 5
        Me.lblNombreLote.Text = "Nombre del Lote:"
        '
        'numCantAnimales
        '
        Me.numCantAnimales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCantAnimales.Location = New System.Drawing.Point(146, 76)
        Me.numCantAnimales.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numCantAnimales.Name = "numCantAnimales"
        Me.numCantAnimales.Size = New System.Drawing.Size(67, 22)
        Me.numCantAnimales.TabIndex = 4
        '
        'lblCantAnimales
        '
        Me.lblCantAnimales.AutoSize = True
        Me.lblCantAnimales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantAnimales.Location = New System.Drawing.Point(3, 79)
        Me.lblCantAnimales.Name = "lblCantAnimales"
        Me.lblCantAnimales.Size = New System.Drawing.Size(137, 16)
        Me.lblCantAnimales.TabIndex = 3
        Me.lblCantAnimales.Text = "Cantidad de animales:"
        '
        'txtNumLote2
        '
        Me.txtNumLote2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumLote2.Location = New System.Drawing.Point(110, 12)
        Me.txtNumLote2.MaxLength = 3
        Me.txtNumLote2.Name = "txtNumLote2"
        Me.txtNumLote2.Size = New System.Drawing.Size(36, 25)
        Me.txtNumLote2.TabIndex = 2
        '
        'lblNumLote2
        '
        Me.lblNumLote2.AutoSize = True
        Me.lblNumLote2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumLote2.Location = New System.Drawing.Point(3, 16)
        Me.lblNumLote2.Name = "lblNumLote2"
        Me.lblNumLote2.Size = New System.Drawing.Size(104, 16)
        Me.lblNumLote2.TabIndex = 1
        Me.lblNumLote2.Text = "Número de Lote:"
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(226, 224)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(100, 26)
        Me.cmdVolver.TabIndex = 4
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(341, 256)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.panelLotes)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtNroLote)
        Me.Controls.Add(Me.lblNroLote)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes"
        Me.panelLotes.ResumeLayout(False)
        Me.panelLotes.PerformLayout()
        CType(Me.numCantAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNroLote As System.Windows.Forms.Label
    Friend WithEvents txtNroLote As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents panelLotes As System.Windows.Forms.Panel
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cboCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents txtNombreLote As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreLote As System.Windows.Forms.Label
    Friend WithEvents numCantAnimales As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantAnimales As System.Windows.Forms.Label
    Friend WithEvents txtNumLote2 As System.Windows.Forms.TextBox
    Friend WithEvents lblNumLote2 As System.Windows.Forms.Label
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarAnimales As System.Windows.Forms.Button
End Class
