<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.gridUsuarios = New DevExpress.XtraGrid.GridControl
        Me.cmsUsuarios = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridViewUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumnNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnFoto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.picFoto = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.LayoutViewColumnHabilitado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gridpicFoto1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.gridUsuariosTarjeta = New DevExpress.XtraGrid.GridControl
        Me.LayoutViewUsuariosTarjetas = New DevExpress.XtraGrid.Views.Layout.LayoutView
        Me.LayoutViewColumnImagen = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.gridpicImagen = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewColumnNombre = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_LayoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewColumnUsuario = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewColumnGrupo = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_LayoutViewColumn1_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsUsuarios.SuspendLayout()
        CType(Me.GridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridpicFoto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gridUsuariosTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewUsuariosTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridpicImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridUsuarios
        '
        Me.gridUsuarios.ContextMenuStrip = Me.cmsUsuarios
        Me.gridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.gridUsuarios.MainView = Me.GridViewUsuarios
        Me.gridUsuarios.Name = "gridUsuarios"
        Me.gridUsuarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gridpicFoto1, Me.picFoto})
        Me.gridUsuarios.Size = New System.Drawing.Size(614, 379)
        Me.gridUsuarios.TabIndex = 0
        Me.gridUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewUsuarios})
        '
        'cmsUsuarios
        '
        Me.cmsUsuarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.cmsUsuarios.Name = "cmsUsuarios"
        Me.cmsUsuarios.Size = New System.Drawing.Size(126, 48)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.namespace4BITS.My.Resources.Resources.note_add
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = Global.namespace4BITS.My.Resources.Resources.note_edit
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'GridViewUsuarios
        '
        Me.GridViewUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNombre, Me.GridColumnUsuario, Me.GridColumnFoto, Me.LayoutViewColumnHabilitado, Me.GridColumnGrupo})
        Me.GridViewUsuarios.GridControl = Me.gridUsuarios
        Me.GridViewUsuarios.Name = "GridViewUsuarios"
        Me.GridViewUsuarios.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridViewUsuarios.OptionsFilter.AllowMRUFilterList = False
        Me.GridViewUsuarios.OptionsView.ShowAutoFilterRow = True
        '
        'GridColumnNombre
        '
        Me.GridColumnNombre.Caption = "Nombre"
        Me.GridColumnNombre.FieldName = "nombre"
        Me.GridColumnNombre.Name = "GridColumnNombre"
        Me.GridColumnNombre.OptionsColumn.AllowEdit = False
        Me.GridColumnNombre.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nombre", "{0:n0}")})
        Me.GridColumnNombre.Visible = True
        Me.GridColumnNombre.VisibleIndex = 0
        '
        'GridColumnUsuario
        '
        Me.GridColumnUsuario.Caption = "Usuario"
        Me.GridColumnUsuario.FieldName = "usuario"
        Me.GridColumnUsuario.Name = "GridColumnUsuario"
        Me.GridColumnUsuario.OptionsColumn.AllowEdit = False
        Me.GridColumnUsuario.Visible = True
        Me.GridColumnUsuario.VisibleIndex = 1
        '
        'GridColumnFoto
        '
        Me.GridColumnFoto.Caption = "Fotografía"
        Me.GridColumnFoto.ColumnEdit = Me.picFoto
        Me.GridColumnFoto.FieldName = "foto"
        Me.GridColumnFoto.Name = "GridColumnFoto"
        '
        'picFoto
        '
        Me.picFoto.AutoHeight = False
        Me.picFoto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.picFoto.Name = "picFoto"
        Me.picFoto.ShowMenu = False
        Me.picFoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'LayoutViewColumnHabilitado
        '
        Me.LayoutViewColumnHabilitado.Caption = "Habilitado"
        Me.LayoutViewColumnHabilitado.FieldName = "habilitado"
        Me.LayoutViewColumnHabilitado.Name = "LayoutViewColumnHabilitado"
        Me.LayoutViewColumnHabilitado.OptionsColumn.AllowEdit = False
        Me.LayoutViewColumnHabilitado.Visible = True
        Me.LayoutViewColumnHabilitado.VisibleIndex = 2
        '
        'GridColumnGrupo
        '
        Me.GridColumnGrupo.Caption = "Grupo"
        Me.GridColumnGrupo.FieldName = "nombreg"
        Me.GridColumnGrupo.Name = "GridColumnGrupo"
        Me.GridColumnGrupo.OptionsColumn.AllowEdit = False
        Me.GridColumnGrupo.Visible = True
        Me.GridColumnGrupo.VisibleIndex = 3
        '
        'gridpicFoto1
        '
        Me.gridpicFoto1.Name = "gridpicFoto1"
        Me.gridpicFoto1.ShowMenu = False
        Me.gridpicFoto1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gridUsuariosTarjeta)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(614, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(259, 379)
        Me.PanelControl1.TabIndex = 1
        '
        'gridUsuariosTarjeta
        '
        Me.gridUsuariosTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUsuariosTarjeta.Location = New System.Drawing.Point(3, 3)
        Me.gridUsuariosTarjeta.MainView = Me.LayoutViewUsuariosTarjetas
        Me.gridUsuariosTarjeta.Name = "gridUsuariosTarjeta"
        Me.gridUsuariosTarjeta.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gridpicImagen})
        Me.gridUsuariosTarjeta.Size = New System.Drawing.Size(253, 373)
        Me.gridUsuariosTarjeta.TabIndex = 0
        Me.gridUsuariosTarjeta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutViewUsuariosTarjetas})
        '
        'LayoutViewUsuariosTarjetas
        '
        Me.LayoutViewUsuariosTarjetas.CardMinSize = New System.Drawing.Size(219, 297)
        Me.LayoutViewUsuariosTarjetas.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.LayoutViewColumnImagen, Me.LayoutViewColumnNombre, Me.LayoutViewColumnUsuario, Me.LayoutViewColumnGrupo})
        Me.LayoutViewUsuariosTarjetas.GridControl = Me.gridUsuariosTarjeta
        Me.LayoutViewUsuariosTarjetas.Name = "LayoutViewUsuariosTarjetas"
        Me.LayoutViewUsuariosTarjetas.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.LayoutViewUsuariosTarjetas.OptionsCustomization.AllowFilter = False
        Me.LayoutViewUsuariosTarjetas.OptionsCustomization.AllowSort = False
        Me.LayoutViewUsuariosTarjetas.OptionsView.ShowCardCaption = False
        Me.LayoutViewUsuariosTarjetas.OptionsView.ShowCardExpandButton = False
        Me.LayoutViewUsuariosTarjetas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.LayoutViewUsuariosTarjetas.OptionsView.ShowHeaderPanel = False
        Me.LayoutViewUsuariosTarjetas.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel
        Me.LayoutViewUsuariosTarjetas.TemplateCard = Me.LayoutViewCard1
        '
        'LayoutViewColumnImagen
        '
        Me.LayoutViewColumnImagen.Caption = "Foto"
        Me.LayoutViewColumnImagen.ColumnEdit = Me.gridpicImagen
        Me.LayoutViewColumnImagen.FieldName = "foto"
        Me.LayoutViewColumnImagen.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.LayoutViewColumnImagen.Name = "LayoutViewColumnImagen"
        Me.LayoutViewColumnImagen.OptionsColumn.AllowEdit = False
        '
        'gridpicImagen
        '
        Me.gridpicImagen.Name = "gridpicImagen"
        Me.gridpicImagen.ShowMenu = False
        Me.gridpicImagen.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 195
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(199, 26)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn1.TextVisible = False
        '
        'LayoutViewColumnNombre
        '
        Me.LayoutViewColumnNombre.Caption = "Nombre"
        Me.LayoutViewColumnNombre.FieldName = "nombre"
        Me.LayoutViewColumnNombre.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_1
        Me.LayoutViewColumnNombre.Name = "LayoutViewColumnNombre"
        Me.LayoutViewColumnNombre.OptionsColumn.AllowEdit = False
        '
        'layoutViewField_LayoutViewColumn1_1
        '
        Me.layoutViewField_LayoutViewColumn1_1.EditorPreferredWidth = 145
        Me.layoutViewField_LayoutViewColumn1_1.Location = New System.Drawing.Point(0, 26)
        Me.layoutViewField_LayoutViewColumn1_1.Name = "layoutViewField_LayoutViewColumn1_1"
        Me.layoutViewField_LayoutViewColumn1_1.Size = New System.Drawing.Size(199, 20)
        Me.layoutViewField_LayoutViewColumn1_1.TextSize = New System.Drawing.Size(41, 13)
        Me.layoutViewField_LayoutViewColumn1_1.TextToControlDistance = 5
        '
        'LayoutViewColumnUsuario
        '
        Me.LayoutViewColumnUsuario.Caption = "Usuario"
        Me.LayoutViewColumnUsuario.FieldName = "usuario"
        Me.LayoutViewColumnUsuario.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.LayoutViewColumnUsuario.Name = "LayoutViewColumnUsuario"
        Me.LayoutViewColumnUsuario.OptionsColumn.AllowEdit = False
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 145
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 46)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(199, 20)
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(41, 13)
        Me.layoutViewField_LayoutViewColumn2.TextToControlDistance = 5
        '
        'LayoutViewColumnGrupo
        '
        Me.LayoutViewColumnGrupo.Caption = "Grupo"
        Me.LayoutViewColumnGrupo.FieldName = "nombreg"
        Me.LayoutViewColumnGrupo.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_2
        Me.LayoutViewColumnGrupo.Name = "LayoutViewColumnGrupo"
        '
        'layoutViewField_LayoutViewColumn1_2
        '
        Me.layoutViewField_LayoutViewColumn1_2.EditorPreferredWidth = 145
        Me.layoutViewField_LayoutViewColumn1_2.Location = New System.Drawing.Point(0, 66)
        Me.layoutViewField_LayoutViewColumn1_2.Name = "layoutViewField_LayoutViewColumn1_2"
        Me.layoutViewField_LayoutViewColumn1_2.Size = New System.Drawing.Size(199, 20)
        Me.layoutViewField_LayoutViewColumn1_2.TextSize = New System.Drawing.Size(41, 13)
        Me.layoutViewField_LayoutViewColumn1_2.TextToControlDistance = 5
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1, Me.layoutViewField_LayoutViewColumn1_1, Me.layoutViewField_LayoutViewColumn2, Me.layoutViewField_LayoutViewColumn1_2})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 379)
        Me.Controls.Add(Me.gridUsuarios)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUsuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsUsuarios.ResumeLayout(False)
        CType(Me.GridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridpicFoto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gridUsuariosTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewUsuariosTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridpicImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridpicFoto1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmsUsuarios As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutViewColumnHabilitado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents picFoto As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridUsuariosTarjeta As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutViewUsuariosTarjetas As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewColumnImagen As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents gridpicImagen As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents LayoutViewColumnNombre As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumnUsuario As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents LayoutViewColumnGrupo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
End Class
