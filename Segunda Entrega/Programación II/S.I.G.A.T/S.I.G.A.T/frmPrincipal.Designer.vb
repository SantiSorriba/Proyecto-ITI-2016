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
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.menuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuIngresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuIdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEstablecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdministrarEstablecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsultarProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCampoRecria = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAnimales = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuABMC = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOrdenies = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsultarEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCargarEvento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivo, Me.menuEstablecimientos, Me.menuAnimales, Me.menuEventos, Me.menuUsuarios})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(1284, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'menuArchivo
        '
        Me.menuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuIngresar, Me.menuCerrarSesion, Me.menuIdioma, Me.menuSalir})
        Me.menuArchivo.Name = "menuArchivo"
        Me.menuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuArchivo.Text = "Archivo"
        '
        'menuIngresar
        '
        Me.menuIngresar.Name = "menuIngresar"
        Me.menuIngresar.Size = New System.Drawing.Size(143, 22)
        Me.menuIngresar.Text = "Ingresar"
        '
        'menuCerrarSesion
        '
        Me.menuCerrarSesion.Name = "menuCerrarSesion"
        Me.menuCerrarSesion.Size = New System.Drawing.Size(143, 22)
        Me.menuCerrarSesion.Text = "Cerrar Sesion"
        '
        'menuIdioma
        '
        Me.menuIdioma.Name = "menuIdioma"
        Me.menuIdioma.Size = New System.Drawing.Size(143, 22)
        Me.menuIdioma.Text = "Idioma"
        '
        'menuSalir
        '
        Me.menuSalir.Name = "menuSalir"
        Me.menuSalir.Size = New System.Drawing.Size(143, 22)
        Me.menuSalir.Text = "Salir"
        '
        'menuEstablecimientos
        '
        Me.menuEstablecimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAdministrarEstablecimientos, Me.menuConsultarProduccion, Me.menuCampoRecria})
        Me.menuEstablecimientos.Name = "menuEstablecimientos"
        Me.menuEstablecimientos.Size = New System.Drawing.Size(108, 20)
        Me.menuEstablecimientos.Text = "Establecimientos"
        '
        'menuAdministrarEstablecimientos
        '
        Me.menuAdministrarEstablecimientos.Name = "menuAdministrarEstablecimientos"
        Me.menuAdministrarEstablecimientos.Size = New System.Drawing.Size(228, 22)
        Me.menuAdministrarEstablecimientos.Text = "Administrar establecimientos"
        '
        'menuConsultarProduccion
        '
        Me.menuConsultarProduccion.Name = "menuConsultarProduccion"
        Me.menuConsultarProduccion.Size = New System.Drawing.Size(228, 22)
        Me.menuConsultarProduccion.Text = "Consultar producción"
        '
        'menuCampoRecria
        '
        Me.menuCampoRecria.Name = "menuCampoRecria"
        Me.menuCampoRecria.Size = New System.Drawing.Size(228, 22)
        Me.menuCampoRecria.Text = "Campo de Recria"
        '
        'menuAnimales
        '
        Me.menuAnimales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuABMC, Me.menuInventario, Me.menuLotes, Me.menuOrdenies, Me.menuConsultarEventos})
        Me.menuAnimales.Name = "menuAnimales"
        Me.menuAnimales.Size = New System.Drawing.Size(68, 20)
        Me.menuAnimales.Text = "Animales"
        '
        'menuABMC
        '
        Me.menuABMC.Name = "menuABMC"
        Me.menuABMC.Size = New System.Drawing.Size(169, 22)
        Me.menuABMC.Text = "ABMC"
        '
        'menuInventario
        '
        Me.menuInventario.Name = "menuInventario"
        Me.menuInventario.Size = New System.Drawing.Size(169, 22)
        Me.menuInventario.Text = "Inventario"
        '
        'menuLotes
        '
        Me.menuLotes.Name = "menuLotes"
        Me.menuLotes.Size = New System.Drawing.Size(169, 22)
        Me.menuLotes.Text = "Lotes"
        '
        'menuOrdenies
        '
        Me.menuOrdenies.Name = "menuOrdenies"
        Me.menuOrdenies.Size = New System.Drawing.Size(169, 22)
        Me.menuOrdenies.Text = "Ordeñes"
        '
        'menuConsultarEventos
        '
        Me.menuConsultarEventos.Name = "menuConsultarEventos"
        Me.menuConsultarEventos.Size = New System.Drawing.Size(169, 22)
        Me.menuConsultarEventos.Text = "Consultar Eventos"
        '
        'menuEventos
        '
        Me.menuEventos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCargarEvento})
        Me.menuEventos.Name = "menuEventos"
        Me.menuEventos.Size = New System.Drawing.Size(60, 20)
        Me.menuEventos.Text = "Eventos"
        '
        'menuCargarEvento
        '
        Me.menuCargarEvento.Name = "menuCargarEvento"
        Me.menuCargarEvento.Size = New System.Drawing.Size(152, 22)
        Me.menuCargarEvento.Text = "Cargar evento"
        '
        'menuUsuarios
        '
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.menuUsuarios.Text = "Usuarios"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(1284, 662)
        Me.Controls.Add(Me.menuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuPrincipal
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Ventana Principal"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents menuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuIngresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuIdioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEstablecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAdministrarEstablecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsultarProduccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAnimales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuABMC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInventario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLotes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOrdenies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCampoRecria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCargarEvento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsultarEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUsuarios As System.Windows.Forms.ToolStripMenuItem

End Class
