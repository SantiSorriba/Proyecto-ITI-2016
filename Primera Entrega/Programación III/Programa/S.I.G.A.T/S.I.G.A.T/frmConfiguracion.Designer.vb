<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.tabConfiguracion = New System.Windows.Forms.TabControl()
        Me.tabIdioma = New System.Windows.Forms.TabPage()
        Me.cmdIngles = New System.Windows.Forms.Button()
        Me.cmdEspaniol = New System.Windows.Forms.Button()
        Me.tabPreferencias = New System.Windows.Forms.TabPage()
        Me.tabConfiguracion.SuspendLayout()
        Me.tabIdioma.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabConfiguracion
        '
        Me.tabConfiguracion.Controls.Add(Me.tabIdioma)
        Me.tabConfiguracion.Controls.Add(Me.tabPreferencias)
        Me.tabConfiguracion.Location = New System.Drawing.Point(2, 4)
        Me.tabConfiguracion.Name = "tabConfiguracion"
        Me.tabConfiguracion.SelectedIndex = 0
        Me.tabConfiguracion.Size = New System.Drawing.Size(379, 155)
        Me.tabConfiguracion.TabIndex = 0
        '
        'tabIdioma
        '
        Me.tabIdioma.BackColor = System.Drawing.Color.DarkKhaki
        Me.tabIdioma.Controls.Add(Me.cmdIngles)
        Me.tabIdioma.Controls.Add(Me.cmdEspaniol)
        Me.tabIdioma.Location = New System.Drawing.Point(4, 22)
        Me.tabIdioma.Name = "tabIdioma"
        Me.tabIdioma.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIdioma.Size = New System.Drawing.Size(371, 129)
        Me.tabIdioma.TabIndex = 0
        Me.tabIdioma.Text = "Idioma"
        '
        'cmdIngles
        '
        Me.cmdIngles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngles.Location = New System.Drawing.Point(6, 67)
        Me.cmdIngles.Name = "cmdIngles"
        Me.cmdIngles.Size = New System.Drawing.Size(359, 57)
        Me.cmdIngles.TabIndex = 1
        Me.cmdIngles.Text = "Cambiar idioma a Ingles"
        Me.cmdIngles.UseVisualStyleBackColor = True
        '
        'cmdEspaniol
        '
        Me.cmdEspaniol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEspaniol.Location = New System.Drawing.Point(6, 6)
        Me.cmdEspaniol.Name = "cmdEspaniol"
        Me.cmdEspaniol.Size = New System.Drawing.Size(359, 57)
        Me.cmdEspaniol.TabIndex = 0
        Me.cmdEspaniol.Text = "Cambiar idioma a Español"
        Me.cmdEspaniol.UseVisualStyleBackColor = True
        '
        'tabPreferencias
        '
        Me.tabPreferencias.BackColor = System.Drawing.Color.DarkKhaki
        Me.tabPreferencias.Location = New System.Drawing.Point(4, 22)
        Me.tabPreferencias.Name = "tabPreferencias"
        Me.tabPreferencias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPreferencias.Size = New System.Drawing.Size(371, 129)
        Me.tabPreferencias.TabIndex = 1
        Me.tabPreferencias.Text = "Preferencias"
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(384, 162)
        Me.Controls.Add(Me.tabConfiguracion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Configuración"
        Me.tabConfiguracion.ResumeLayout(False)
        Me.tabIdioma.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabConfiguracion As System.Windows.Forms.TabControl
    Friend WithEvents tabIdioma As System.Windows.Forms.TabPage
    Friend WithEvents tabPreferencias As System.Windows.Forms.TabPage
    Friend WithEvents cmdIngles As System.Windows.Forms.Button
    Friend WithEvents cmdEspaniol As System.Windows.Forms.Button
End Class
