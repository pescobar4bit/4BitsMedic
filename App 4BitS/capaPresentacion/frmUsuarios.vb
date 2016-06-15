Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Public Class frmUsuarios
    Dim waitDialgo As WaitDialogForm

    Dim vDTUsuarios As DataTable = Nothing
    Dim mCancel As Boolean = True
    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim frmTmpo As frmUsuariosNuevo = New frmUsuariosNuevo
        frmTmpo.vNuevoUsuario = True
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then
            cargarUsuarios()
        End If
    End Sub
    Private Sub cargarUsuarios()
        Try
            waitDialgo = New WaitDialogForm("Cargando Usuarios....", "Espere por favor")
            vDTUsuarios = Nothing
            vDTUsuarios = EjecutarSelect("SELECT     dbo.tUsuarios.*, dbo.tGrupos.nombre AS nombreg FROM         dbo.tUsuarios INNER JOIN      dbo.tGrupos ON dbo.tUsuarios.idGrupo = dbo.tGrupos.idGrupo where dbo.tgrupos.idbodega=" & vConexion.vidBodega)
            gridUsuarios.DataSource = vDTUsuarios
            gridUsuariosTarjeta.DataSource = vDTUsuarios
            Thread.Sleep(500)
            waitDialgo.Close()

            'GridViewProductosD_FocusedRowChanged New Object,New )
        Catch ex As Exception
            waitDialgo.Close()
            XtraMessageBox.Show("Hay un error: " & ex.Message, "VINNS", MessageBoxButtons.OK)

        End Try
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If GridViewUsuarios.FocusedRowHandle < 0 Then Exit Sub
        If GridViewUsuarios.RowCount < 1 Then Exit Sub
        Dim frmTmpo As frmUsuariosNuevo = New frmUsuariosNuevo
        frmTmpo.vDRMofificarUsuario = GridViewUsuarios.GetDataRow(GridViewUsuarios.FocusedRowHandle)
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then
            cargarUsuarios()
            mCancel = False
        End If

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        cargarUsuarios()
        
    End Sub
End Class