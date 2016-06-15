<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioEmpresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioEmpresas))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.depError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.lueNegocios = New DevExpress.XtraEditors.LookUpEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.picCargando = New DevExpress.XtraEditors.PictureEdit
        Me.bwProceso01 = New System.ComponentModel.BackgroundWorker
        Me.lblAviso = New DevExpress.XtraEditors.LabelControl
        CType(Me.depError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNegocios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.picCargando.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(242, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Seleccione a que base de datos se desea conectar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(20, 79)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(187, 79)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "&Salir"
        '
        'depError
        '
        Me.depError.ContainerControl = Me
        '
        'lueNegocios
        '
        Me.lueNegocios.EnterMoveNextControl = True
        Me.lueNegocios.Location = New System.Drawing.Point(20, 42)
        Me.lueNegocios.Name = "lueNegocios"
        Me.lueNegocios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo)})
        Me.lueNegocios.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idNegocios", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Distribuiodra"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuariobdd", "ubdd", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bdd", "bdd", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("servidor", "servidor", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clavebdd", "clavedd", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lueNegocios.Properties.DisplayMember = "nombre"
        Me.lueNegocios.Properties.NullText = "[No hay distribuidoras definidas"
        Me.lueNegocios.Properties.ValueMember = "idNegocios"
        Me.lueNegocios.Size = New System.Drawing.Size(242, 20)
        Me.lueNegocios.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lueNegocios)
        Me.PanelControl1.Controls.Add(Me.btnSalir)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(17, 45)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(289, 125)
        Me.PanelControl1.TabIndex = 0
        '
        'picCargando
        '
        Me.picCargando.EditValue = Global.namespace4BITS.My.Resources.Resources.loading2
        Me.picCargando.Location = New System.Drawing.Point(263, 3)
        Me.picCargando.Name = "picCargando"
        Me.picCargando.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picCargando.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.picCargando.Properties.Appearance.Options.UseBackColor = True
        Me.picCargando.Properties.Appearance.Options.UseForeColor = True
        Me.picCargando.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picCargando.Properties.ShowMenu = False
        Me.picCargando.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picCargando.Size = New System.Drawing.Size(43, 36)
        Me.picCargando.TabIndex = 3
        Me.picCargando.Visible = False
        '
        'bwProceso01
        '
        '
        'lblAviso
        '
        Me.lblAviso.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.lblAviso.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblAviso.Appearance.Options.UseFont = True
        Me.lblAviso.Appearance.Options.UseForeColor = True
        Me.lblAviso.Location = New System.Drawing.Point(17, 12)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(132, 19)
        Me.lblAviso.TabIndex = 4
        Me.lblAviso.Text = "Espere por favor..."
        Me.lblAviso.Visible = False
        '
        'frmInicioEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 182)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.picCargando)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmInicioEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione la distribuidora"
        CType(Me.depError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNegocios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.picCargando.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents depError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents lueNegocios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bwProceso01 As System.ComponentModel.BackgroundWorker
    Friend WithEvents picCargando As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblAviso As DevExpress.XtraEditors.LabelControl
End Class
