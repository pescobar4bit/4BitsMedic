<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferencias
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
        Me.components = New System.ComponentModel.Container
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.txtFotoDespues = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtTamanioI = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtTiempoO = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescuentoM = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.depError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtFotoDespues.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanioI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtTiempoO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.depError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(477, 292)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtFotoDespues)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.txtTamanioI)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(473, 267)
        Me.XtraTabPage1.Text = "Configuración para ingreso"
        '
        'txtFotoDespues
        '
        Me.txtFotoDespues.Location = New System.Drawing.Point(113, 180)
        Me.txtFotoDespues.Name = "txtFotoDespues"
        Me.txtFotoDespues.Properties.DisplayFormat.FormatString = "n"
        Me.txtFotoDespues.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFotoDespues.Properties.EditFormat.FormatString = "n"
        Me.txtFotoDespues.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFotoDespues.Properties.Mask.EditMask = "n"
        Me.txtFotoDespues.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFotoDespues.Properties.NullText = "0"
        Me.txtFotoDespues.Size = New System.Drawing.Size(120, 20)
        Me.txtFotoDespues.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(38, 149)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(216, 13)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "¿Despues de que cantidad, debe tomar foto?"
        '
        'txtTamanioI
        '
        Me.txtTamanioI.Location = New System.Drawing.Point(113, 69)
        Me.txtTamanioI.Name = "txtTamanioI"
        Me.txtTamanioI.Properties.Mask.EditMask = "P"
        Me.txtTamanioI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTamanioI.Properties.NullText = "500"
        Me.txtTamanioI.Size = New System.Drawing.Size(120, 20)
        Me.txtTamanioI.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(189, 95)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "1 Megabyte = 1,024 kbytes"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(38, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(203, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tamaño maximo para imagenes (kilobytes)"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.txtTiempoO)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.txtDescuentoM)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(400, 261)
        Me.XtraTabPage2.Text = "Configuración para venta"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(295, 172)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl7.TabIndex = 5
        Me.LabelControl7.Text = "minutos."
        '
        'LabelControl5
        '
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(47, 139)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(315, 26)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Tiempo maximo de ordenes, luego de transcurrir este tiempo mandara un aviso en el" & _
            " monitor de ordenes pendientes"
        '
        'txtTiempoO
        '
        Me.txtTiempoO.Location = New System.Drawing.Point(145, 171)
        Me.txtTiempoO.Name = "txtTiempoO"
        Me.txtTiempoO.Properties.NullText = "30"
        Me.txtTiempoO.Size = New System.Drawing.Size(143, 20)
        Me.txtTiempoO.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(47, 75)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(184, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Nota. Aplica para todos los productos."
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(47, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(164, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Descuento maximo para la venta. "
        '
        'txtDescuentoM
        '
        Me.txtDescuentoM.Location = New System.Drawing.Point(145, 49)
        Me.txtDescuentoM.Name = "txtDescuentoM"
        Me.txtDescuentoM.Properties.Mask.EditMask = "p"
        Me.txtDescuentoM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuentoM.Properties.NullText = "0"
        Me.txtDescuentoM.Size = New System.Drawing.Size(143, 20)
        Me.txtDescuentoM.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnSalir)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 244)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(477, 48)
        Me.PanelControl1.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(234, 13)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(101, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        '
        'depError
        '
        Me.depError.ContainerControl = Me
        '
        'frmPreferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 292)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPreferencias"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferencias"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtFotoDespues.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanioI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtTiempoO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.depError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtTamanioI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTiempoO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuentoM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFotoDespues As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents depError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
