Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports namespace4BITS.nsFuncionesVINNS

Public Class frmUsuariosNuevo
    Dim waitDialgo As WaitDialogForm
    Dim mCancel As Boolean = True
    Public vNuevoUsuario As Boolean = False
    Public vDRMofificarUsuario As DataRow = Nothing
    Dim vDTGrupos As DataTable = Nothing



    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property
    ReadOnly Property oUsuario() As String
        Get
            Return txtUsuario.Text
        End Get
    End Property
    ReadOnly Property oClave() As String
        Get
            Return txtClave.Text.Trim
        End Get
    End Property
    ReadOnly Property oFoto() As DevExpress.XtraEditors.PictureEdit
        Get
            Return picFoto
        End Get
    End Property
    ReadOnly Property oNombre() As String
        Get
            Return txtNombre.Text
        End Get
    End Property
    Private Sub TomarFotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TomarFotoToolStripMenuItem.Click
        '    Dim frmTmpo As frmTomarFoto = New frmTomarFoto(picFoto)
        '   frmTmpo.ShowDialog()
        '   frmTmpo.Dispose()
    End Sub

    Private Sub SinFotoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SinFotoToolStripMenuItem.Click
        picFoto.Image = Nothing
    End Sub

    Private Sub CargarFotoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CargarFotoToolStripMenuItem.Click
        picFoto.LoadImage()
        If Not picFoto.Image Is Nothing Then
            If XtraMessageBox.Show("Dejar del tamaño real? Nota. Si se comprime puede bajar la calidad de la imagen.", "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                picFoto.Image = reducirIMAGEN(picFoto)
            End If

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        dvpValidar.Validate(txtNombre)
        dvpValidar.Validate(txtUsuario)
        dvpValidar.Validate(txtClave)
        'dvpValidar.Validate(txtClave2)
        If txtClave.Text.Trim <> txtClave2.Text.Trim Then
            depError.SetError(txtClave, "La claves no son iguales")
            depError.SetError(txtClave2, "La claves no son iguales")
            Exit Sub
        End If
        If dvpValidar.GetInvalidControls.Count > 0 Then Exit Sub
        Dim vDatos As datosUsuario = Nothing
        vDatos.nombre = txtNombre.Text.Trim
        vDatos.usuario = txtUsuario.Text.Trim
        vDatos.clave = EncryptString(txtClave.Text.Trim, "EJCGVINNS", ENCRYPT)
        vDatos.foto = picFoto
        vDatos.idGrupo = lueUsuario.EditValue
        vDatos.habilitado = ckHabilitado.Checked
        If vNuevoUsuario Then
            vDatos.tipo = 1
            INSERTARPAUSUARIOS(vDatos, "paMUsuarios")
            XtraMessageBox.Show("Usuario Ingresado", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            vDatos.tipo = 2
            vDatos.idUsuario = vDRMofificarUsuario("idUsuario")
            INSERTARPAUSUARIOS(vDatos, "paMUsuarios")
            XtraMessageBox.Show("Usuario Modificado", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        mCancel = False
        Close()
    End Sub

    Private Sub frmUsuariosNuevo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        cargarGrupos()

        If Not vNuevoUsuario Then
            Try
                txtNombre.Text = vDRMofificarUsuario("nombre")
                txtUsuario.Text = vDRMofificarUsuario("usuario")
                txtClave.Text = EncryptString(vDRMofificarUsuario("clave"), "EJCGVINNS", DECRYPT)
                txtClave2.Text = txtClave.Text
                ckHabilitado.Checked = CBool(vDRMofificarUsuario("habilitado"))
                lueUsuario.EditValue = vDRMofificarUsuario("idGrupo")



                If Not IsDBNull(vDRMofificarUsuario("foto")) Then
                    picFoto.Image = convImagenBDD(vDRMofificarUsuario("foto"))
                End If
            Catch ex As Exception
                'Dim vDRTmpo As DataRow = EjecutarSelect("select foto from tproductos where idproducto=" & vDRModificarProducto("idProducto")).Rows(0)
                'If Not IsDBNull(vDRTmpo("foto")) Then
                ' picFoto.Image = convImagenBDD(vDRTmpo("foto"))
                ' End If
                picFoto.Image = Nothing
            End Try
        End If
    End Sub
    Private Sub cargarGrupos()
        Try

        
            'waitDialgo = New WaitDialogForm("Cargando Grupos....", "Espere por favor")
            mostarWait(Me, "Cargando grupos", "Espere por favor")
            vDTGrupos = Nothing
            vDTGrupos = EjecutarSelect("select * from tgrupos where idbodega=" & vConexion.vidBodega)
            lueUsuario.Properties.DataSource = vDTGrupos
            If vDTGrupos.Rows.Count > 0 Then
                lueUsuario.ItemIndex = 0
            Else
                btnAceptar.Enabled = False
            End If
            Thread.Sleep(500)
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            XtraMessageBox.Show("Hay un error: " & ex.Message, "VINNS", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class