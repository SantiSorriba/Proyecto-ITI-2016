<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdioma
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
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.rdoEspaniol = New System.Windows.Forms.RadioButton()
        Me.rdoIngles = New System.Windows.Forms.RadioButton()
        Me.cmdCambiar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdioma.Location = New System.Drawing.Point(12, 9)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(59, 18)
        Me.lblIdioma.TabIndex = 0
        Me.lblIdioma.Text = "Idioma:"
        '
        'rdoEspaniol
        '
        Me.rdoEspaniol.AutoSize = True
        Me.rdoEspaniol.Checked = True
        Me.rdoEspaniol.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoEspaniol.Location = New System.Drawing.Point(23, 40)
        Me.rdoEspaniol.Name = "rdoEspaniol"
        Me.rdoEspaniol.Size = New System.Drawing.Size(83, 22)
        Me.rdoEspaniol.TabIndex = 1
        Me.rdoEspaniol.TabStop = True
        Me.rdoEspaniol.Text = "Español"
        Me.rdoEspaniol.UseVisualStyleBackColor = True
        '
        'rdoIngles
        '
        Me.rdoIngles.AutoSize = True
        Me.rdoIngles.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIngles.Location = New System.Drawing.Point(23, 78)
        Me.rdoIngles.Name = "rdoIngles"
        Me.rdoIngles.Size = New System.Drawing.Size(66, 22)
        Me.rdoIngles.TabIndex = 2
        Me.rdoIngles.Text = "Ingles"
        Me.rdoIngles.UseVisualStyleBackColor = True
        '
        'cmdCambiar
        '
        Me.cmdCambiar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCambiar.Location = New System.Drawing.Point(173, 12)
        Me.cmdCambiar.Name = "cmdCambiar"
        Me.cmdCambiar.Size = New System.Drawing.Size(86, 32)
        Me.cmdCambiar.TabIndex = 3
        Me.cmdCambiar.Text = "Cambiar"
        Me.cmdCambiar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(173, 73)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(86, 32)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(271, 122)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdCambiar)
        Me.Controls.Add(Me.rdoIngles)
        Me.Controls.Add(Me.rdoEspaniol)
        Me.Controls.Add(Me.lblIdioma)
        Me.MaximizeBox = False
        Me.Name = "frmIdioma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Idioma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdioma As System.Windows.Forms.Label
    Friend WithEvents rdoEspaniol As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIngles As System.Windows.Forms.RadioButton
    Friend WithEvents cmdCambiar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
