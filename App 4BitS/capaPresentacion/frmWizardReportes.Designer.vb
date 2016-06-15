<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWizardReportes
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.wcConfigReportes = New DevExpress.XtraWizard.WizardControl
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage
        Me.wpFecha = New DevExpress.XtraWizard.WizardPage
        Me.rgTipo = New DevExpress.XtraEditors.RadioGroup
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.deFechaF = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaI = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.wpFinal = New DevExpress.XtraWizard.CompletionWizardPage
        Me.wpObjetivos = New DevExpress.XtraWizard.WizardPage
        Me.txtAnio = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtMes2 = New DevExpress.XtraScheduler.UI.MonthEdit
        Me.txtMes1 = New DevExpress.XtraScheduler.UI.MonthEdit
        Me.lblMes = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.wpObjetivosFecha = New DevExpress.XtraWizard.WizardPage
        Me.lblCualMes = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.mcCalendario = New System.Windows.Forms.MonthCalendar
        CType(Me.wcConfigReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wcConfigReportes.SuspendLayout()
        Me.wpFecha.SuspendLayout()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaF.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wpObjetivos.SuspendLayout()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wpObjetivosFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'wcConfigReportes
        '
        Me.wcConfigReportes.Controls.Add(Me.WelcomeWizardPage1)
        Me.wcConfigReportes.Controls.Add(Me.wpFecha)
        Me.wcConfigReportes.Controls.Add(Me.wpFinal)
        Me.wcConfigReportes.Controls.Add(Me.wpObjetivos)
        Me.wcConfigReportes.Controls.Add(Me.wpObjetivosFecha)
        Me.wcConfigReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wcConfigReportes.Image = Global.namespace4BITS.My.Resources.Resources.farmalider
        Me.wcConfigReportes.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.wcConfigReportes.Location = New System.Drawing.Point(0, 0)
        Me.wcConfigReportes.Name = "wcConfigReportes"
        Me.wcConfigReportes.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.wpFecha, Me.wpObjetivos, Me.wpObjetivosFecha, Me.wpFinal})
        Me.wcConfigReportes.Size = New System.Drawing.Size(583, 400)
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(366, 267)
        '
        'wpFecha
        '
        Me.wpFecha.Controls.Add(Me.rgTipo)
        Me.wpFecha.Controls.Add(Me.PictureEdit1)
        Me.wpFecha.Controls.Add(Me.deFechaF)
        Me.wpFecha.Controls.Add(Me.LabelControl2)
        Me.wpFecha.Controls.Add(Me.deFechaI)
        Me.wpFecha.Controls.Add(Me.LabelControl1)
        Me.wpFecha.DescriptionText = "Seleccione el tipo de fecha y un rango para el reporte"
        Me.wpFecha.Name = "wpFecha"
        Me.wpFecha.Size = New System.Drawing.Size(551, 255)
        Me.wpFecha.Text = "Selección de fechas"
        '
        'rgTipo
        '
        Me.rgTipo.Location = New System.Drawing.Point(13, 58)
        Me.rgTipo.Name = "rgTipo"
        Me.rgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Por el día que hizo el pedido el vendedor"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Por el día que está emitida la factura")})
        Me.rgTipo.Size = New System.Drawing.Size(245, 114)
        Me.rgTipo.TabIndex = 5
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.namespace4BITS.My.Resources.Resources.farmalider
        Me.PictureEdit1.Location = New System.Drawing.Point(13, 58)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(245, 114)
        Me.PictureEdit1.TabIndex = 10
        '
        'deFechaF
        '
        Me.deFechaF.EditValue = Nothing
        Me.deFechaF.Location = New System.Drawing.Point(279, 152)
        Me.deFechaF.Name = "deFechaF"
        Me.deFechaF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaF.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaF.Size = New System.Drawing.Size(191, 20)
        Me.deFechaF.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(279, 124)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Fecha final"
        '
        'deFechaI
        '
        Me.deFechaI.EditValue = Nothing
        Me.deFechaI.Location = New System.Drawing.Point(279, 77)
        Me.deFechaI.Name = "deFechaI"
        Me.deFechaI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaI.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaI.Size = New System.Drawing.Size(191, 20)
        Me.deFechaI.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(279, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Fecha Inicial"
        '
        'wpFinal
        '
        Me.wpFinal.Name = "wpFinal"
        Me.wpFinal.Size = New System.Drawing.Size(366, 267)
        '
        'wpObjetivos
        '
        Me.wpObjetivos.Controls.Add(Me.txtAnio)
        Me.wpObjetivos.Controls.Add(Me.LabelControl5)
        Me.wpObjetivos.Controls.Add(Me.txtMes2)
        Me.wpObjetivos.Controls.Add(Me.txtMes1)
        Me.wpObjetivos.Controls.Add(Me.lblMes)
        Me.wpObjetivos.Controls.Add(Me.LabelControl4)
        Me.wpObjetivos.Name = "wpObjetivos"
        Me.wpObjetivos.Size = New System.Drawing.Size(551, 255)
        '
        'txtAnio
        '
        Me.txtAnio.EditValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.txtAnio.EnterMoveNextControl = True
        Me.txtAnio.Location = New System.Drawing.Point(164, 157)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtAnio.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAnio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAnio.Properties.EditFormat.FormatString = "n0"
        Me.txtAnio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAnio.Properties.MaxValue = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.txtAnio.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.txtAnio.Properties.NullText = "2000"
        Me.txtAnio.Size = New System.Drawing.Size(161, 20)
        Me.txtAnio.TabIndex = 14
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(115, 160)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Año"
        '
        'txtMes2
        '
        Me.txtMes2.EnterMoveNextControl = True
        Me.txtMes2.Location = New System.Drawing.Point(164, 101)
        Me.txtMes2.Name = "txtMes2"
        Me.txtMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMes2.Size = New System.Drawing.Size(161, 20)
        Me.txtMes2.TabIndex = 12
        '
        'txtMes1
        '
        Me.txtMes1.EnterMoveNextControl = True
        Me.txtMes1.Location = New System.Drawing.Point(164, 39)
        Me.txtMes1.Name = "txtMes1"
        Me.txtMes1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMes1.Size = New System.Drawing.Size(161, 20)
        Me.txtMes1.TabIndex = 11
        '
        'lblMes
        '
        Me.lblMes.Location = New System.Drawing.Point(92, 108)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(42, 13)
        Me.lblMes.TabIndex = 10
        Me.lblMes.Text = "Mes final"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(85, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Mes Inicial"
        '
        'wpObjetivosFecha
        '
        Me.wpObjetivosFecha.Controls.Add(Me.lblCualMes)
        Me.wpObjetivosFecha.Controls.Add(Me.LabelControl3)
        Me.wpObjetivosFecha.Controls.Add(Me.mcCalendario)
        Me.wpObjetivosFecha.Name = "wpObjetivosFecha"
        Me.wpObjetivosFecha.Size = New System.Drawing.Size(551, 255)
        '
        'lblCualMes
        '
        Me.lblCualMes.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.lblCualMes.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCualMes.Location = New System.Drawing.Point(146, 220)
        Me.lblCualMes.Name = "lblCualMes"
        Me.lblCualMes.Size = New System.Drawing.Size(6, 23)
        Me.lblCualMes.TabIndex = 2
        Me.lblCualMes.Text = "."
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(35, 220)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Objetivos del mes de:"
        '
        'mcCalendario
        '
        Me.mcCalendario.Location = New System.Drawing.Point(146, 32)
        Me.mcCalendario.Name = "mcCalendario"
        Me.mcCalendario.TabIndex = 0
        '
        'frmWizardReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 400)
        Me.Controls.Add(Me.wcConfigReportes)
        Me.Name = "frmWizardReportes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.wcConfigReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wcConfigReportes.ResumeLayout(False)
        Me.wpFecha.ResumeLayout(False)
        Me.wpFecha.PerformLayout()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaF.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaI.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wpObjetivos.ResumeLayout(False)
        Me.wpObjetivos.PerformLayout()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wpObjetivosFecha.ResumeLayout(False)
        Me.wpObjetivosFecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wcConfigReportes As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents wpFecha As DevExpress.XtraWizard.WizardPage
    Friend WithEvents wpFinal As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents deFechaF As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents wpObjetivos As DevExpress.XtraWizard.WizardPage
    Friend WithEvents txtMes2 As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents txtMes1 As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents lblMes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents wpObjetivosFecha As DevExpress.XtraWizard.WizardPage
    Friend WithEvents lblCualMes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mcCalendario As System.Windows.Forms.MonthCalendar
End Class
