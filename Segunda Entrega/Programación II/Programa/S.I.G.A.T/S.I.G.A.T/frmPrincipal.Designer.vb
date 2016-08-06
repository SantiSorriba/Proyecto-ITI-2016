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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.menuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuIngreso = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEstablecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAnimales = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.AmbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivo, Me.menuEstablecimientos, Me.menuAnimales, Me.menuUsuarios})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(1284, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'menuArchivo
        '
        Me.menuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuIngreso, Me.menuCerrarSesion, Me.menuConfig, Me.menuSalir})
        Me.menuArchivo.Name = "menuArchivo"
        Me.menuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuArchivo.Text = "Archivo"
        '
        'menuIngreso
        '
        Me.menuIngreso.Name = "menuIngreso"
        Me.menuIngreso.Size = New System.Drawing.Size(150, 22)
        Me.menuIngreso.Text = "Ingreso"
        '
        'menuCerrarSesion
        '
        Me.menuCerrarSesion.Name = "menuCerrarSesion"
        Me.menuCerrarSesion.Size = New System.Drawing.Size(150, 22)
        Me.menuCerrarSesion.Text = "Cerrar Sesión"
        '
        'menuConfig
        '
        Me.menuConfig.Name = "menuConfig"
        Me.menuConfig.Size = New System.Drawing.Size(150, 22)
        Me.menuConfig.Text = "Configuración"
        '
        'menuSalir
        '
        Me.menuSalir.Name = "menuSalir"
        Me.menuSalir.Size = New System.Drawing.Size(150, 22)
        Me.menuSalir.Text = "Salir"
        '
        'menuEstablecimientos
        '
        Me.menuEstablecimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AmbToolStripMenuItem})
        Me.menuEstablecimientos.Name = "menuEstablecimientos"
        Me.menuEstablecimientos.Size = New System.Drawing.Size(108, 20)
        Me.menuEstablecimientos.Text = "Establecimientos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        '
        'menuAnimales
        '
        Me.menuAnimales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem, Me.LoteosToolStripMenuItem, Me.InventarioToolStripMenuItem})
        Me.menuAnimales.Name = "menuAnimales"
        Me.menuAnimales.Size = New System.Drawing.Size(68, 20)
        Me.menuAnimales.Text = "Animales"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'LoteosToolStripMenuItem
        '
        Me.LoteosToolStripMenuItem.Name = "LoteosToolStripMenuItem"
        Me.LoteosToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LoteosToolStripMenuItem.Text = "Loteos"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'menuUsuarios
        '
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.menuUsuarios.Text = "Usuarios"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Peru
        Me.lblFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(1099, 621)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(173, 32)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "dd/mm/yyyy"
        '
        'AmbToolStripMenuItem
        '
        Me.AmbToolStripMenuItem.Name = "AmbToolStripMenuItem"
        Me.AmbToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AmbToolStripMenuItem.Text = "amb"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.S.I.G.A.T.My.Resources.Resources.fondo_verde
        Me.ClientSize = New System.Drawing.Size(1284, 662)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.menuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuPrincipal
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Inicio"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents menuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuIngreso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEstablecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAnimales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents ABMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoteosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmbToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
