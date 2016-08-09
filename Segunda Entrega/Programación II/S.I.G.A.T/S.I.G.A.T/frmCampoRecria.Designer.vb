<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampoRecria
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
        Me.lblEstablecimiento = New System.Windows.Forms.Label()
        Me.cmdVer = New System.Windows.Forms.Button()
        Me.cboEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.panelAnimales = New System.Windows.Forms.Panel()
        Me.gridAnimales = New System.Windows.Forms.DataGridView()
        Me.lblAnimales = New System.Windows.Forms.Label()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.panelAnimales.SuspendLayout()
        CType(Me.gridAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstablecimiento
        '
        Me.lblEstablecimiento.AutoSize = True
        Me.lblEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstablecimiento.Location = New System.Drawing.Point(12, 16)
        Me.lblEstablecimiento.Name = "lblEstablecimiento"
        Me.lblEstablecimiento.Size = New System.Drawing.Size(105, 16)
        Me.lblEstablecimiento.TabIndex = 0
        Me.lblEstablecimiento.Text = "Establecimiento:"
        '
        'cmdVer
        '
        Me.cmdVer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVer.Location = New System.Drawing.Point(375, 10)
        Me.cmdVer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(56, 28)
        Me.cmdVer.TabIndex = 2
        Me.cmdVer.Text = "Ver"
        Me.cmdVer.UseVisualStyleBackColor = True
        '
        'cboEstablecimiento
        '
        Me.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimiento.FormattingEnabled = True
        Me.cboEstablecimiento.Items.AddRange(New Object() {"Establecimiento Las Perdices", "Establecimiento Tala", "Establecimiento Los Juncales"})
        Me.cboEstablecimiento.Location = New System.Drawing.Point(123, 11)
        Me.cboEstablecimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboEstablecimiento.MaxLength = 30
        Me.cboEstablecimiento.Name = "cboEstablecimiento"
        Me.cboEstablecimiento.Size = New System.Drawing.Size(246, 24)
        Me.cboEstablecimiento.TabIndex = 3
        '
        'panelAnimales
        '
        Me.panelAnimales.Controls.Add(Me.gridAnimales)
        Me.panelAnimales.Controls.Add(Me.lblAnimales)
        Me.panelAnimales.Location = New System.Drawing.Point(12, 47)
        Me.panelAnimales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelAnimales.Name = "panelAnimales"
        Me.panelAnimales.Size = New System.Drawing.Size(419, 366)
        Me.panelAnimales.TabIndex = 4
        Me.panelAnimales.Visible = False
        '
        'gridAnimales
        '
        Me.gridAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAnimales.Location = New System.Drawing.Point(6, 38)
        Me.gridAnimales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridAnimales.Name = "gridAnimales"
        Me.gridAnimales.Size = New System.Drawing.Size(410, 324)
        Me.gridAnimales.TabIndex = 1
        '
        'lblAnimales
        '
        Me.lblAnimales.AutoSize = True
        Me.lblAnimales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimales.Location = New System.Drawing.Point(3, 12)
        Me.lblAnimales.Name = "lblAnimales"
        Me.lblAnimales.Size = New System.Drawing.Size(66, 16)
        Me.lblAnimales.TabIndex = 0
        Me.lblAnimales.Text = "Animales:"
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(336, 420)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(95, 28)
        Me.cmdVolver.TabIndex = 5
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmCampoRecria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(440, 453)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.panelAnimales)
        Me.Controls.Add(Me.cboEstablecimiento)
        Me.Controls.Add(Me.cmdVer)
        Me.Controls.Add(Me.lblEstablecimiento)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCampoRecria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campo de Recria"
        Me.panelAnimales.ResumeLayout(False)
        Me.panelAnimales.PerformLayout()
        CType(Me.gridAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cmdVer As System.Windows.Forms.Button
    Friend WithEvents cboEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents panelAnimales As System.Windows.Forms.Panel
    Friend WithEvents gridAnimales As System.Windows.Forms.DataGridView
    Friend WithEvents lblAnimales As System.Windows.Forms.Label
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
