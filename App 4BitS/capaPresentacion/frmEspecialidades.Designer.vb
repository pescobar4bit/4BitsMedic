<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspecialidades
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
        Me.gcEspecialidades = New DevExpress.XtraGrid.GridControl()
        Me.GridViewUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolIdEspecialidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gColEspecialidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridpicFoto1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.picFoto = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        CType(Me.gcEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridpicFoto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcEspecialidades
        '
        Me.gcEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcEspecialidades.Location = New System.Drawing.Point(0, 0)
        Me.gcEspecialidades.MainView = Me.GridViewUsuarios
        Me.gcEspecialidades.Name = "gcEspecialidades"
        Me.gcEspecialidades.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gridpicFoto1, Me.picFoto})
        Me.gcEspecialidades.Size = New System.Drawing.Size(902, 494)
        Me.gcEspecialidades.TabIndex = 1
        Me.gcEspecialidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewUsuarios})
        '
        'GridViewUsuarios
        '
        Me.GridViewUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolIdEspecialidad, Me.gColEspecialidad})
        Me.GridViewUsuarios.GridControl = Me.gcEspecialidades
        Me.GridViewUsuarios.Name = "GridViewUsuarios"
        Me.GridViewUsuarios.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridViewUsuarios.OptionsFilter.AllowMRUFilterList = False
        Me.GridViewUsuarios.OptionsView.ShowAutoFilterRow = True
        '
        'gcolIdEspecialidad
        '
        Me.gcolIdEspecialidad.Caption = "IdEspecialidad"
        Me.gcolIdEspecialidad.FieldName = "IdEspecialidad"
        Me.gcolIdEspecialidad.Name = "gcolIdEspecialidad"
        Me.gcolIdEspecialidad.OptionsColumn.AllowEdit = False
        Me.gcolIdEspecialidad.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nombre", "{0:n0}")})
        '
        'gColEspecialidad
        '
        Me.gColEspecialidad.Caption = "Especialidad"
        Me.gColEspecialidad.FieldName = "Especialidad"
        Me.gColEspecialidad.Name = "gColEspecialidad"
        Me.gColEspecialidad.OptionsColumn.AllowEdit = False
        Me.gColEspecialidad.Visible = True
        Me.gColEspecialidad.VisibleIndex = 0
        '
        'gridpicFoto1
        '
        Me.gridpicFoto1.Name = "gridpicFoto1"
        Me.gridpicFoto1.ShowMenu = False
        Me.gridpicFoto1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'picFoto
        '
        Me.picFoto.AutoHeight = False
        Me.picFoto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.picFoto.Name = "picFoto"
        Me.picFoto.ShowMenu = False
        Me.picFoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'frmEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 494)
        Me.Controls.Add(Me.gcEspecialidades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEspecialidades"
        Me.Text = "frmEspecialidades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gcEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridpicFoto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcEspecialidades As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolIdEspecialidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gColEspecialidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridpicFoto1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents picFoto As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
End Class
