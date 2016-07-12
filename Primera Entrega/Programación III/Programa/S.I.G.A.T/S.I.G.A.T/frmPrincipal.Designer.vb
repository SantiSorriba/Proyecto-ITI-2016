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
        Me.menuConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEstablecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNuevoEstablecimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsultarEstablecimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuModificarEstablecimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEntidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuServicios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAnimales = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoteos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAltasyBajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAltas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsultarAnimal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAgregarUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuModificarUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBajaUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.OrdeñesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivo, Me.menuEstablecimientos, Me.menuEntidades, Me.menuAnimales, Me.menuUsuarios})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(1284, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'menuArchivo
        '
        Me.menuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuIngreso, Me.menuCerrarSesion, Me.menuConfiguracion, Me.menuSalir})
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
        'menuConfiguracion
        '
        Me.menuConfiguracion.Name = "menuConfiguracion"
        Me.menuConfiguracion.Size = New System.Drawing.Size(150, 22)
        Me.menuConfiguracion.Text = "Configuración"
        '
        'menuSalir
        '
        Me.menuSalir.Name = "menuSalir"
        Me.menuSalir.Size = New System.Drawing.Size(150, 22)
        Me.menuSalir.Text = "Salir"
        '
        'menuEstablecimientos
        '
        Me.menuEstablecimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNuevoEstablecimiento, Me.menuConsultarEstablecimiento, Me.menuModificarEstablecimiento})
        Me.menuEstablecimientos.Name = "menuEstablecimientos"
        Me.menuEstablecimientos.Size = New System.Drawing.Size(108, 20)
        Me.menuEstablecimientos.Text = "Establecimientos"
        '
        'menuNuevoEstablecimiento
        '
        Me.menuNuevoEstablecimiento.Name = "menuNuevoEstablecimiento"
        Me.menuNuevoEstablecimiento.Size = New System.Drawing.Size(212, 22)
        Me.menuNuevoEstablecimiento.Text = "Nuevo Establecimiento"
        '
        'menuConsultarEstablecimiento
        '
        Me.menuConsultarEstablecimiento.Name = "menuConsultarEstablecimiento"
        Me.menuConsultarEstablecimiento.Size = New System.Drawing.Size(212, 22)
        Me.menuConsultarEstablecimiento.Text = "Consultar Establecimiento"
        '
        'menuModificarEstablecimiento
        '
        Me.menuModificarEstablecimiento.Name = "menuModificarEstablecimiento"
        Me.menuModificarEstablecimiento.Size = New System.Drawing.Size(212, 22)
        Me.menuModificarEstablecimiento.Text = "Modificar Establecimiento"
        '
        'menuEntidades
        '
        Me.menuEntidades.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuClientes, Me.menuProveedores, Me.menuServicios})
        Me.menuEntidades.Name = "menuEntidades"
        Me.menuEntidades.Size = New System.Drawing.Size(70, 20)
        Me.menuEntidades.Text = "Entidades"
        '
        'menuClientes
        '
        Me.menuClientes.Name = "menuClientes"
        Me.menuClientes.Size = New System.Drawing.Size(139, 22)
        Me.menuClientes.Text = "Clientes"
        '
        'menuProveedores
        '
        Me.menuProveedores.Name = "menuProveedores"
        Me.menuProveedores.Size = New System.Drawing.Size(139, 22)
        Me.menuProveedores.Text = "Proveedores"
        '
        'menuServicios
        '
        Me.menuServicios.Name = "menuServicios"
        Me.menuServicios.Size = New System.Drawing.Size(139, 22)
        Me.menuServicios.Text = "Servicios"
        '
        'menuAnimales
        '
        Me.menuAnimales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInventario, Me.menuLoteos, Me.menuAltasyBajas, Me.menuConsultarAnimal, Me.OrdeñesToolStripMenuItem})
        Me.menuAnimales.Name = "menuAnimales"
        Me.menuAnimales.Size = New System.Drawing.Size(68, 20)
        Me.menuAnimales.Text = "Animales"
        '
        'menuInventario
        '
        Me.menuInventario.Name = "menuInventario"
        Me.menuInventario.Size = New System.Drawing.Size(164, 22)
        Me.menuInventario.Text = "Inventario"
        '
        'menuLoteos
        '
        Me.menuLoteos.Name = "menuLoteos"
        Me.menuLoteos.Size = New System.Drawing.Size(164, 22)
        Me.menuLoteos.Text = "Loteos"
        '
        'menuAltasyBajas
        '
        Me.menuAltasyBajas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAltas, Me.menuBajas})
        Me.menuAltasyBajas.Name = "menuAltasyBajas"
        Me.menuAltasyBajas.Size = New System.Drawing.Size(164, 22)
        Me.menuAltasyBajas.Text = "Altas y Bajas"
        '
        'menuAltas
        '
        Me.menuAltas.Name = "menuAltas"
        Me.menuAltas.Size = New System.Drawing.Size(96, 22)
        Me.menuAltas.Text = "Alta"
        '
        'menuBajas
        '
        Me.menuBajas.Name = "menuBajas"
        Me.menuBajas.Size = New System.Drawing.Size(96, 22)
        Me.menuBajas.Text = "Baja"
        '
        'menuConsultarAnimal
        '
        Me.menuConsultarAnimal.Name = "menuConsultarAnimal"
        Me.menuConsultarAnimal.Size = New System.Drawing.Size(164, 22)
        Me.menuConsultarAnimal.Text = "Consultar animal"
        '
        'menuUsuarios
        '
        Me.menuUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAgregarUsuario, Me.menuModificarUsuario, Me.menuBajaUsuario})
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.menuUsuarios.Text = "Usuarios"
        '
        'menuAgregarUsuario
        '
        Me.menuAgregarUsuario.Name = "menuAgregarUsuario"
        Me.menuAgregarUsuario.Size = New System.Drawing.Size(168, 22)
        Me.menuAgregarUsuario.Text = "Agregar Usuario"
        '
        'menuModificarUsuario
        '
        Me.menuModificarUsuario.Name = "menuModificarUsuario"
        Me.menuModificarUsuario.Size = New System.Drawing.Size(168, 22)
        Me.menuModificarUsuario.Text = "Modificar Usuario"
        '
        'menuBajaUsuario
        '
        Me.menuBajaUsuario.Name = "menuBajaUsuario"
        Me.menuBajaUsuario.Size = New System.Drawing.Size(168, 22)
        Me.menuBajaUsuario.Text = "Dar de baja"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Peru
        Me.lblFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(1099, 621)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(173, 32)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "dd/mm/yyyy"
        '
        'OrdeñesToolStripMenuItem
        '
        Me.OrdeñesToolStripMenuItem.Name = "OrdeñesToolStripMenuItem"
        Me.OrdeñesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OrdeñesToolStripMenuItem.Text = "Ordeñes"
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
    Friend WithEvents menuConfiguracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEstablecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuNuevoEstablecimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsultarEstablecimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuModificarEstablecimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEntidades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuServicios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAnimales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInventario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLoteos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAltasyBajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents menuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAgregarUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuModificarUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBajaUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsultarAnimal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAltas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdeñesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
