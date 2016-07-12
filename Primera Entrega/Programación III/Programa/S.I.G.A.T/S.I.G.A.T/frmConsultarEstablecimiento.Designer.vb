<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarEstablecimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarEstablecimiento))
        Me.lblSeleccioneEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimientos = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblPropietario = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.lblSuperficie = New System.Windows.Forms.Label()
        Me.txtHectareas = New System.Windows.Forms.TextBox()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.lblAnimales = New System.Windows.Forms.Label()
        Me.txtAnimales = New System.Windows.Forms.TextBox()
        Me.lblDeLosCuales = New System.Windows.Forms.Label()
        Me.lblJersey = New System.Windows.Forms.Label()
        Me.lblHolando = New System.Windows.Forms.Label()
        Me.lblPrimerShow = New System.Windows.Forms.Label()
        Me.txtPrimerShow = New System.Windows.Forms.TextBox()
        Me.lblPorciento1 = New System.Windows.Forms.Label()
        Me.lblPorciento2 = New System.Windows.Forms.Label()
        Me.lblPorciento3 = New System.Windows.Forms.Label()
        Me.txtHolando = New System.Windows.Forms.TextBox()
        Me.txtJersey = New System.Windows.Forms.TextBox()
        Me.lblCantVacas = New System.Windows.Forms.Label()
        Me.lblCantToros = New System.Windows.Forms.Label()
        Me.txtVacas = New System.Windows.Forms.TextBox()
        Me.txtToros = New System.Windows.Forms.TextBox()
        Me.lblProduccionDiaria = New System.Windows.Forms.Label()
        Me.lblProduccionMensual = New System.Windows.Forms.Label()
        Me.lblProduccionAnual = New System.Windows.Forms.Label()
        Me.lblProduccionTotal = New System.Windows.Forms.Label()
        Me.txtProduccionDiaria = New System.Windows.Forms.TextBox()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.txtProduccionMensual = New System.Windows.Forms.TextBox()
        Me.txtProduccionAnual = New System.Windows.Forms.TextBox()
        Me.txtProduccionTotal = New System.Windows.Forms.TextBox()
        Me.lblLitros1 = New System.Windows.Forms.Label()
        Me.lblLitros2 = New System.Windows.Forms.Label()
        Me.lblLitros3 = New System.Windows.Forms.Label()
        Me.lblTipoOrdenie = New System.Windows.Forms.Label()
        Me.txtOrdenie = New System.Windows.Forms.TextBox()
        Me.lblCantidadOrdenies = New System.Windows.Forms.Label()
        Me.txtCantOrdenies = New System.Windows.Forms.TextBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSeleccioneEstablecimiento
        '
        Me.lblSeleccioneEstablecimiento.AutoSize = True
        Me.lblSeleccioneEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccioneEstablecimiento.Location = New System.Drawing.Point(3, 9)
        Me.lblSeleccioneEstablecimiento.Name = "lblSeleccioneEstablecimiento"
        Me.lblSeleccioneEstablecimiento.Size = New System.Drawing.Size(293, 22)
        Me.lblSeleccioneEstablecimiento.TabIndex = 0
        Me.lblSeleccioneEstablecimiento.Text = "Seleccione un establecimiento:"
        '
        'cboEstablecimientos
        '
        Me.cboEstablecimientos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimientos.FormattingEnabled = True
        Me.cboEstablecimientos.Items.AddRange(New Object() {"Establecimiento1", "Establecimiento2", "Establecimiento3"})
        Me.cboEstablecimientos.Location = New System.Drawing.Point(302, 9)
        Me.cboEstablecimientos.Name = "cboEstablecimientos"
        Me.cboEstablecimientos.Size = New System.Drawing.Size(270, 25)
        Me.cboEstablecimientos.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 362)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 568
        Me.LineShape1.Y1 = 43
        Me.LineShape1.Y2 = 43
        '
        'lblPropietario
        '
        Me.lblPropietario.AutoSize = True
        Me.lblPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropietario.Location = New System.Drawing.Point(5, 56)
        Me.lblPropietario.Name = "lblPropietario"
        Me.lblPropietario.Size = New System.Drawing.Size(102, 18)
        Me.lblPropietario.TabIndex = 3
        Me.lblPropietario.Text = "Propietario:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(129, 56)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(191, 18)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre del propietario"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(336, 56)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(192, 18)
        Me.lblApellido.TabIndex = 5
        Me.lblApellido.Text = "Apellido del propietario"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.Location = New System.Drawing.Point(5, 89)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(252, 18)
        Me.lblUbicacion.TabIndex = 6
        Me.lblUbicacion.Text = "Ubicacion del establecimiento:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(263, 84)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(306, 23)
        Me.txtUbicacion.TabIndex = 7
        '
        'lblSuperficie
        '
        Me.lblSuperficie.AutoSize = True
        Me.lblSuperficie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperficie.Location = New System.Drawing.Point(3, 118)
        Me.lblSuperficie.Name = "lblSuperficie"
        Me.lblSuperficie.Size = New System.Drawing.Size(253, 18)
        Me.lblSuperficie.TabIndex = 8
        Me.lblSuperficie.Text = "Superficie del establecimiento:"
        '
        'txtHectareas
        '
        Me.txtHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHectareas.Location = New System.Drawing.Point(263, 113)
        Me.txtHectareas.Name = "txtHectareas"
        Me.txtHectareas.Size = New System.Drawing.Size(83, 23)
        Me.txtHectareas.TabIndex = 9
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHectareas.Location = New System.Drawing.Point(352, 118)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(90, 18)
        Me.lblHectareas.TabIndex = 10
        Me.lblHectareas.Text = "hectáreas"
        '
        'lblAnimales
        '
        Me.lblAnimales.AutoSize = True
        Me.lblAnimales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimales.Location = New System.Drawing.Point(5, 147)
        Me.lblAnimales.Name = "lblAnimales"
        Me.lblAnimales.Size = New System.Drawing.Size(184, 18)
        Me.lblAnimales.TabIndex = 11
        Me.lblAnimales.Text = "Cantidad de animales:"
        '
        'txtAnimales
        '
        Me.txtAnimales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnimales.Location = New System.Drawing.Point(195, 146)
        Me.txtAnimales.Name = "txtAnimales"
        Me.txtAnimales.Size = New System.Drawing.Size(62, 22)
        Me.txtAnimales.TabIndex = 12
        '
        'lblDeLosCuales
        '
        Me.lblDeLosCuales.AutoSize = True
        Me.lblDeLosCuales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeLosCuales.Location = New System.Drawing.Point(263, 147)
        Me.lblDeLosCuales.Name = "lblDeLosCuales"
        Me.lblDeLosCuales.Size = New System.Drawing.Size(117, 18)
        Me.lblDeLosCuales.TabIndex = 13
        Me.lblDeLosCuales.Text = "de los cuales:"
        '
        'lblJersey
        '
        Me.lblJersey.AutoSize = True
        Me.lblJersey.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJersey.Location = New System.Drawing.Point(386, 151)
        Me.lblJersey.Name = "lblJersey"
        Me.lblJersey.Size = New System.Drawing.Size(54, 15)
        Me.lblJersey.TabIndex = 14
        Me.lblJersey.Text = "Jersey:"
        '
        'lblHolando
        '
        Me.lblHolando.AutoSize = True
        Me.lblHolando.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolando.Location = New System.Drawing.Point(386, 176)
        Me.lblHolando.Name = "lblHolando"
        Me.lblHolando.Size = New System.Drawing.Size(65, 15)
        Me.lblHolando.TabIndex = 15
        Me.lblHolando.Text = "Holando:"
        '
        'lblPrimerShow
        '
        Me.lblPrimerShow.AutoSize = True
        Me.lblPrimerShow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerShow.Location = New System.Drawing.Point(386, 202)
        Me.lblPrimerShow.Name = "lblPrimerShow"
        Me.lblPrimerShow.Size = New System.Drawing.Size(95, 15)
        Me.lblPrimerShow.TabIndex = 16
        Me.lblPrimerShow.Text = "Primer Show:"
        '
        'txtPrimerShow
        '
        Me.txtPrimerShow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerShow.Location = New System.Drawing.Point(494, 200)
        Me.txtPrimerShow.MaxLength = 3
        Me.txtPrimerShow.Name = "txtPrimerShow"
        Me.txtPrimerShow.Size = New System.Drawing.Size(34, 21)
        Me.txtPrimerShow.TabIndex = 19
        Me.txtPrimerShow.Text = "0"
        Me.txtPrimerShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPorciento1
        '
        Me.lblPorciento1.AutoSize = True
        Me.lblPorciento1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorciento1.Location = New System.Drawing.Point(534, 151)
        Me.lblPorciento1.Name = "lblPorciento1"
        Me.lblPorciento1.Size = New System.Drawing.Size(18, 15)
        Me.lblPorciento1.TabIndex = 20
        Me.lblPorciento1.Text = "%"
        '
        'lblPorciento2
        '
        Me.lblPorciento2.AutoSize = True
        Me.lblPorciento2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorciento2.Location = New System.Drawing.Point(534, 176)
        Me.lblPorciento2.Name = "lblPorciento2"
        Me.lblPorciento2.Size = New System.Drawing.Size(18, 15)
        Me.lblPorciento2.TabIndex = 21
        Me.lblPorciento2.Text = "%"
        '
        'lblPorciento3
        '
        Me.lblPorciento3.AutoSize = True
        Me.lblPorciento3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorciento3.Location = New System.Drawing.Point(534, 202)
        Me.lblPorciento3.Name = "lblPorciento3"
        Me.lblPorciento3.Size = New System.Drawing.Size(18, 15)
        Me.lblPorciento3.TabIndex = 22
        Me.lblPorciento3.Text = "%"
        '
        'txtHolando
        '
        Me.txtHolando.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHolando.Location = New System.Drawing.Point(494, 174)
        Me.txtHolando.MaxLength = 3
        Me.txtHolando.Name = "txtHolando"
        Me.txtHolando.Size = New System.Drawing.Size(34, 21)
        Me.txtHolando.TabIndex = 23
        Me.txtHolando.Text = "0"
        Me.txtHolando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJersey
        '
        Me.txtJersey.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJersey.Location = New System.Drawing.Point(494, 149)
        Me.txtJersey.MaxLength = 3
        Me.txtJersey.Name = "txtJersey"
        Me.txtJersey.Size = New System.Drawing.Size(34, 21)
        Me.txtJersey.TabIndex = 24
        Me.txtJersey.Text = "0"
        Me.txtJersey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantVacas
        '
        Me.lblCantVacas.AutoSize = True
        Me.lblCantVacas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantVacas.Location = New System.Drawing.Point(4, 177)
        Me.lblCantVacas.Name = "lblCantVacas"
        Me.lblCantVacas.Size = New System.Drawing.Size(63, 18)
        Me.lblCantVacas.TabIndex = 25
        Me.lblCantVacas.Text = "Vacas:"
        '
        'lblCantToros
        '
        Me.lblCantToros.AutoSize = True
        Me.lblCantToros.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantToros.Location = New System.Drawing.Point(153, 177)
        Me.lblCantToros.Name = "lblCantToros"
        Me.lblCantToros.Size = New System.Drawing.Size(59, 18)
        Me.lblCantToros.TabIndex = 26
        Me.lblCantToros.Text = "Toros:"
        '
        'txtVacas
        '
        Me.txtVacas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVacas.Location = New System.Drawing.Point(73, 174)
        Me.txtVacas.Name = "txtVacas"
        Me.txtVacas.Size = New System.Drawing.Size(61, 21)
        Me.txtVacas.TabIndex = 27
        '
        'txtToros
        '
        Me.txtToros.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToros.Location = New System.Drawing.Point(218, 174)
        Me.txtToros.Name = "txtToros"
        Me.txtToros.Size = New System.Drawing.Size(61, 21)
        Me.txtToros.TabIndex = 28
        '
        'lblProduccionDiaria
        '
        Me.lblProduccionDiaria.AutoSize = True
        Me.lblProduccionDiaria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduccionDiaria.Location = New System.Drawing.Point(5, 212)
        Me.lblProduccionDiaria.Name = "lblProduccionDiaria"
        Me.lblProduccionDiaria.Size = New System.Drawing.Size(154, 18)
        Me.lblProduccionDiaria.TabIndex = 29
        Me.lblProduccionDiaria.Text = "Producción diaria:"
        '
        'lblProduccionMensual
        '
        Me.lblProduccionMensual.AutoSize = True
        Me.lblProduccionMensual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduccionMensual.Location = New System.Drawing.Point(5, 239)
        Me.lblProduccionMensual.Name = "lblProduccionMensual"
        Me.lblProduccionMensual.Size = New System.Drawing.Size(176, 18)
        Me.lblProduccionMensual.TabIndex = 30
        Me.lblProduccionMensual.Text = "Producción mensual:"
        '
        'lblProduccionAnual
        '
        Me.lblProduccionAnual.AutoSize = True
        Me.lblProduccionAnual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduccionAnual.Location = New System.Drawing.Point(5, 267)
        Me.lblProduccionAnual.Name = "lblProduccionAnual"
        Me.lblProduccionAnual.Size = New System.Drawing.Size(153, 18)
        Me.lblProduccionAnual.TabIndex = 31
        Me.lblProduccionAnual.Text = "Producción anual:"
        '
        'lblProduccionTotal
        '
        Me.lblProduccionTotal.AutoSize = True
        Me.lblProduccionTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduccionTotal.Location = New System.Drawing.Point(4, 295)
        Me.lblProduccionTotal.Name = "lblProduccionTotal"
        Me.lblProduccionTotal.Size = New System.Drawing.Size(145, 18)
        Me.lblProduccionTotal.TabIndex = 32
        Me.lblProduccionTotal.Text = "Producción total:"
        '
        'txtProduccionDiaria
        '
        Me.txtProduccionDiaria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduccionDiaria.Location = New System.Drawing.Point(187, 207)
        Me.txtProduccionDiaria.Name = "txtProduccionDiaria"
        Me.txtProduccionDiaria.Size = New System.Drawing.Size(100, 23)
        Me.txtProduccionDiaria.TabIndex = 33
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros.Location = New System.Drawing.Point(299, 212)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(54, 18)
        Me.lblLitros.TabIndex = 34
        Me.lblLitros.Text = "Litros"
        '
        'txtProduccionMensual
        '
        Me.txtProduccionMensual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduccionMensual.Location = New System.Drawing.Point(187, 236)
        Me.txtProduccionMensual.Name = "txtProduccionMensual"
        Me.txtProduccionMensual.Size = New System.Drawing.Size(100, 23)
        Me.txtProduccionMensual.TabIndex = 35
        '
        'txtProduccionAnual
        '
        Me.txtProduccionAnual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduccionAnual.Location = New System.Drawing.Point(187, 266)
        Me.txtProduccionAnual.Name = "txtProduccionAnual"
        Me.txtProduccionAnual.Size = New System.Drawing.Size(100, 23)
        Me.txtProduccionAnual.TabIndex = 36
        '
        'txtProduccionTotal
        '
        Me.txtProduccionTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduccionTotal.Location = New System.Drawing.Point(187, 295)
        Me.txtProduccionTotal.Name = "txtProduccionTotal"
        Me.txtProduccionTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtProduccionTotal.TabIndex = 37
        '
        'lblLitros1
        '
        Me.lblLitros1.AutoSize = True
        Me.lblLitros1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros1.Location = New System.Drawing.Point(299, 241)
        Me.lblLitros1.Name = "lblLitros1"
        Me.lblLitros1.Size = New System.Drawing.Size(54, 18)
        Me.lblLitros1.TabIndex = 38
        Me.lblLitros1.Text = "Litros"
        '
        'lblLitros2
        '
        Me.lblLitros2.AutoSize = True
        Me.lblLitros2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros2.Location = New System.Drawing.Point(299, 271)
        Me.lblLitros2.Name = "lblLitros2"
        Me.lblLitros2.Size = New System.Drawing.Size(54, 18)
        Me.lblLitros2.TabIndex = 39
        Me.lblLitros2.Text = "Litros"
        '
        'lblLitros3
        '
        Me.lblLitros3.AutoSize = True
        Me.lblLitros3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros3.Location = New System.Drawing.Point(299, 300)
        Me.lblLitros3.Name = "lblLitros3"
        Me.lblLitros3.Size = New System.Drawing.Size(54, 18)
        Me.lblLitros3.TabIndex = 40
        Me.lblLitros3.Text = "Litros"
        '
        'lblTipoOrdenie
        '
        Me.lblTipoOrdenie.AutoSize = True
        Me.lblTipoOrdenie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoOrdenie.Location = New System.Drawing.Point(381, 236)
        Me.lblTipoOrdenie.Name = "lblTipoOrdenie"
        Me.lblTipoOrdenie.Size = New System.Drawing.Size(135, 18)
        Me.lblTipoOrdenie.TabIndex = 41
        Me.lblTipoOrdenie.Text = "Tipo de Ordeñe:"
        '
        'txtOrdenie
        '
        Me.txtOrdenie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenie.Location = New System.Drawing.Point(379, 257)
        Me.txtOrdenie.Name = "txtOrdenie"
        Me.txtOrdenie.Size = New System.Drawing.Size(149, 23)
        Me.txtOrdenie.TabIndex = 42
        '
        'lblCantidadOrdenies
        '
        Me.lblCantidadOrdenies.AutoSize = True
        Me.lblCantidadOrdenies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadOrdenies.Location = New System.Drawing.Point(381, 295)
        Me.lblCantidadOrdenies.Name = "lblCantidadOrdenies"
        Me.lblCantidadOrdenies.Size = New System.Drawing.Size(147, 15)
        Me.lblCantidadOrdenies.TabIndex = 43
        Me.lblCantidadOrdenies.Text = "Cantidad de Ordeñes:"
        '
        'txtCantOrdenies
        '
        Me.txtCantOrdenies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantOrdenies.Location = New System.Drawing.Point(537, 290)
        Me.txtCantOrdenies.MaxLength = 1
        Me.txtCantOrdenies.Name = "txtCantOrdenies"
        Me.txtCantOrdenies.Size = New System.Drawing.Size(18, 23)
        Me.txtCantOrdenies.TabIndex = 44
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(478, 319)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(94, 32)
        Me.cmdVolver.TabIndex = 45
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmConsultarEstablecimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.txtCantOrdenies)
        Me.Controls.Add(Me.lblCantidadOrdenies)
        Me.Controls.Add(Me.txtOrdenie)
        Me.Controls.Add(Me.lblTipoOrdenie)
        Me.Controls.Add(Me.lblLitros3)
        Me.Controls.Add(Me.lblLitros2)
        Me.Controls.Add(Me.lblLitros1)
        Me.Controls.Add(Me.txtProduccionTotal)
        Me.Controls.Add(Me.txtProduccionAnual)
        Me.Controls.Add(Me.txtProduccionMensual)
        Me.Controls.Add(Me.lblLitros)
        Me.Controls.Add(Me.txtProduccionDiaria)
        Me.Controls.Add(Me.lblProduccionTotal)
        Me.Controls.Add(Me.lblProduccionAnual)
        Me.Controls.Add(Me.lblProduccionMensual)
        Me.Controls.Add(Me.lblProduccionDiaria)
        Me.Controls.Add(Me.txtToros)
        Me.Controls.Add(Me.txtVacas)
        Me.Controls.Add(Me.lblCantToros)
        Me.Controls.Add(Me.lblCantVacas)
        Me.Controls.Add(Me.txtJersey)
        Me.Controls.Add(Me.txtHolando)
        Me.Controls.Add(Me.lblPorciento3)
        Me.Controls.Add(Me.lblPorciento2)
        Me.Controls.Add(Me.lblPorciento1)
        Me.Controls.Add(Me.txtPrimerShow)
        Me.Controls.Add(Me.lblPrimerShow)
        Me.Controls.Add(Me.lblHolando)
        Me.Controls.Add(Me.lblJersey)
        Me.Controls.Add(Me.lblDeLosCuales)
        Me.Controls.Add(Me.txtAnimales)
        Me.Controls.Add(Me.lblAnimales)
        Me.Controls.Add(Me.lblHectareas)
        Me.Controls.Add(Me.txtHectareas)
        Me.Controls.Add(Me.lblSuperficie)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblPropietario)
        Me.Controls.Add(Me.cboEstablecimientos)
        Me.Controls.Add(Me.lblSeleccioneEstablecimiento)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsultarEstablecimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Consultar Establecimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeleccioneEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblPropietario As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents lblSuperficie As System.Windows.Forms.Label
    Friend WithEvents txtHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents lblAnimales As System.Windows.Forms.Label
    Friend WithEvents txtAnimales As System.Windows.Forms.TextBox
    Friend WithEvents lblDeLosCuales As System.Windows.Forms.Label
    Friend WithEvents lblJersey As System.Windows.Forms.Label
    Friend WithEvents lblHolando As System.Windows.Forms.Label
    Friend WithEvents lblPrimerShow As System.Windows.Forms.Label
    Friend WithEvents txtPrimerShow As System.Windows.Forms.TextBox
    Friend WithEvents lblPorciento1 As System.Windows.Forms.Label
    Friend WithEvents lblPorciento2 As System.Windows.Forms.Label
    Friend WithEvents lblPorciento3 As System.Windows.Forms.Label
    Friend WithEvents txtHolando As System.Windows.Forms.TextBox
    Friend WithEvents txtJersey As System.Windows.Forms.TextBox
    Friend WithEvents lblCantVacas As System.Windows.Forms.Label
    Friend WithEvents lblCantToros As System.Windows.Forms.Label
    Friend WithEvents txtVacas As System.Windows.Forms.TextBox
    Friend WithEvents txtToros As System.Windows.Forms.TextBox
    Friend WithEvents lblProduccionDiaria As System.Windows.Forms.Label
    Friend WithEvents lblProduccionMensual As System.Windows.Forms.Label
    Friend WithEvents lblProduccionAnual As System.Windows.Forms.Label
    Friend WithEvents lblProduccionTotal As System.Windows.Forms.Label
    Friend WithEvents txtProduccionDiaria As System.Windows.Forms.TextBox
    Friend WithEvents lblLitros As System.Windows.Forms.Label
    Friend WithEvents txtProduccionMensual As System.Windows.Forms.TextBox
    Friend WithEvents txtProduccionAnual As System.Windows.Forms.TextBox
    Friend WithEvents txtProduccionTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblLitros1 As System.Windows.Forms.Label
    Friend WithEvents lblLitros2 As System.Windows.Forms.Label
    Friend WithEvents lblLitros3 As System.Windows.Forms.Label
    Friend WithEvents lblTipoOrdenie As System.Windows.Forms.Label
    Friend WithEvents txtOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidadOrdenies As System.Windows.Forms.Label
    Friend WithEvents txtCantOrdenies As System.Windows.Forms.TextBox
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
