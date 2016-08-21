<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.menu_Principal = New System.Windows.Forms.MenuStrip()
        Me.menu_Archivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Ingresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_CerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Idioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Establecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_AdministrarEstablecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_ConsultarProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Animales = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_AdministrarAnimales = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Inventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Lotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Ordenies = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Eventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menu_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_Principal
        '
        Me.menu_Principal.BackColor = System.Drawing.SystemColors.Info
        Me.menu_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Archivo, Me.menu_Establecimientos, Me.menu_Animales, Me.menu_Eventos, Me.menu_Usuarios})
        Me.menu_Principal.Location = New System.Drawing.Point(0, 0)
        Me.menu_Principal.Name = "menu_Principal"
        Me.menu_Principal.Size = New System.Drawing.Size(1284, 24)
        Me.menu_Principal.TabIndex = 1
        Me.menu_Principal.Text = "MenuStrip1"
        '
        'menu_Archivo
        '
        Me.menu_Archivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Ingresar, Me.menu_CerrarSesion, Me.menu_Idioma, Me.menu_Salir})
        Me.menu_Archivo.Name = "menu_Archivo"
        Me.menu_Archivo.Size = New System.Drawing.Size(60, 20)
        Me.menu_Archivo.Text = "Archivo"
        '
        'menu_Ingresar
        '
        Me.menu_Ingresar.Name = "menu_Ingresar"
        Me.menu_Ingresar.Size = New System.Drawing.Size(143, 22)
        Me.menu_Ingresar.Text = "Ingresar"
        '
        'menu_CerrarSesion
        '
        Me.menu_CerrarSesion.Name = "menu_CerrarSesion"
        Me.menu_CerrarSesion.Size = New System.Drawing.Size(143, 22)
        Me.menu_CerrarSesion.Text = "Cerrar Sesión"
        '
        'menu_Idioma
        '
        Me.menu_Idioma.Name = "menu_Idioma"
        Me.menu_Idioma.Size = New System.Drawing.Size(143, 22)
        Me.menu_Idioma.Text = "Idioma"
        '
        'menu_Salir
        '
        Me.menu_Salir.Name = "menu_Salir"
        Me.menu_Salir.Size = New System.Drawing.Size(143, 22)
        Me.menu_Salir.Text = "Salir"
        '
        'menu_Establecimientos
        '
        Me.menu_Establecimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_AdministrarEstablecimientos, Me.menu_ConsultarProduccion})
        Me.menu_Establecimientos.Name = "menu_Establecimientos"
        Me.menu_Establecimientos.Size = New System.Drawing.Size(108, 20)
        Me.menu_Establecimientos.Text = "Establecimientos"
        '
        'menu_AdministrarEstablecimientos
        '
        Me.menu_AdministrarEstablecimientos.Name = "menu_AdministrarEstablecimientos"
        Me.menu_AdministrarEstablecimientos.Size = New System.Drawing.Size(228, 22)
        Me.menu_AdministrarEstablecimientos.Text = "Administrar establecimientos"
        '
        'menu_ConsultarProduccion
        '
        Me.menu_ConsultarProduccion.Name = "menu_ConsultarProduccion"
        Me.menu_ConsultarProduccion.Size = New System.Drawing.Size(228, 22)
        Me.menu_ConsultarProduccion.Text = "Consultar produccion"
        '
        'menu_Animales
        '
        Me.menu_Animales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_AdministrarAnimales, Me.menu_Inventario, Me.menu_Lotes, Me.menu_Ordenies})
        Me.menu_Animales.Name = "menu_Animales"
        Me.menu_Animales.Size = New System.Drawing.Size(68, 20)
        Me.menu_Animales.Text = "Animales"
        '
        'menu_AdministrarAnimales
        '
        Me.menu_AdministrarAnimales.Name = "menu_AdministrarAnimales"
        Me.menu_AdministrarAnimales.Size = New System.Drawing.Size(193, 22)
        Me.menu_AdministrarAnimales.Text = "Administrar animales"
        '
        'menu_Inventario
        '
        Me.menu_Inventario.Name = "menu_Inventario"
        Me.menu_Inventario.Size = New System.Drawing.Size(193, 22)
        Me.menu_Inventario.Text = "Inventario de animales"
        '
        'menu_Lotes
        '
        Me.menu_Lotes.Name = "menu_Lotes"
        Me.menu_Lotes.Size = New System.Drawing.Size(193, 22)
        Me.menu_Lotes.Text = "Lotes"
        '
        'menu_Ordenies
        '
        Me.menu_Ordenies.Name = "menu_Ordenies"
        Me.menu_Ordenies.Size = New System.Drawing.Size(193, 22)
        Me.menu_Ordenies.Text = "Ordeñes"
        '
        'menu_Eventos
        '
        Me.menu_Eventos.Name = "menu_Eventos"
        Me.menu_Eventos.Size = New System.Drawing.Size(60, 20)
        Me.menu_Eventos.Text = "Eventos"
        '
        'menu_Usuarios
        '
        Me.menu_Usuarios.Name = "menu_Usuarios"
        Me.menu_Usuarios.Size = New System.Drawing.Size(64, 20)
        Me.menu_Usuarios.Text = "Usuarios"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Fecha.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(1138, 629)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(134, 24)
        Me.lbl_Fecha.TabIndex = 3
        Me.lbl_Fecha.Text = "XX/XX/XXXX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(978, 629)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha de hoy:"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1284, 662)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.menu_Principal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menu_Principal
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Ventana Principal"
        Me.menu_Principal.ResumeLayout(False)
        Me.menu_Principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu_Principal As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_Archivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Ingresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_CerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Idioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Establecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_AdministrarEstablecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_ConsultarProduccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Animales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_AdministrarAnimales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Eventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Inventario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Lotes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Ordenies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
