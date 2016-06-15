Imports System.Threading
Imports DevExpress.Utils
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
'Imports VINNS.nsFuncionesVINNS
Public Class frmInicio
    Private vDTBodegas As DataTable = Nothing
    'Private vCerrarb As Boolean = False
    'Private vAceptar As Boolean = False
    'Dim waitDialgo As WaitDialogForm '("Cargando Formulario", "Espere un momento..")
    Dim mCancel As Boolean = True
    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        'vCerrarb = True
        'Me.Close()
        'Application.Exit()
        Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'lblAviso.Text = "Validando el usuario..."
        dvpValidar.Validate(txtUsuario)

        dvpValidar.Validate(txtClave)

        If dvpValidar.GetInvalidControls.Count > 0 Then Exit Sub
        '--picCargando.Visible = True

        Try
            DTUsuario = Nothing
            'DTUsuario = EjecutarSelect("SELECT     dbo.tUsuarios.idUsuario, dbo.tUsuarios.idBodega, dbo.tUsuarios.usuario, dbo.tUsuarios.clave, dbo.tUsuarios.idGrupo, dbo.tUsuarios.nombre, dbo.tUsuarios.foto,   dbo.tUsuarios.habilitado, dbo.tGrupos.habilitado AS habilitadog FROM dbo.tUsuarios INNER JOIN  dbo.tGrupos ON dbo.tUsuarios.idGrupo = dbo.tGrupos.idGrupo where dbo.tGrupos.idbodega=" & lueBodegas.EditValue & " and dbo.tUsuarios.usuario='" & txtUsuario.Text.Trim & "'")
            DTUsuario = EjecutarProcedimientoP(2, 0, txtUsuario.Text.Trim, "paBGruposUsuariosPermisos")

            ''Dim vClave As String = "" ''ObtenerDato("tusuarios", "clave", "idbodega=" & lueBodegas.EditValue & " and usuario='" & txtUsuario.Text.Trim & "'")
            'Thread.Sleep(3000)
            If DTUsuario.Rows.Count = 0 Then
                XtraMessageBox.Show("El usuario es incorrecto", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'picCargando.Visible = False
                txtUsuario.Focus()
                txtUsuario.SelectAll()
                '--picCargando.Visible = False

                Exit Sub
            End If
            'Dim p As String = EncryptString(txtClave.Text, "EJCGVINNS", ENCRYPT)
            Dim vClave As String = DTUsuario.Rows(0).Item("clave")
            If EncryptString(vClave, "EJCGVINNS", DECRYPT) = txtClave.Text.Trim Then
                llenarDTPermisos(DTUsuario.Rows(0).Item("idGrupo"))
                If Not IsDBNull(DTUsuario.Rows(0).Item("foto")) Then
                    picInicio.Image = convImagenBDD(DTUsuario.Rows(0).Item("foto"))
                End If
                XtraMessageBox.Show("Bienvenido(a) " & DTUsuario.Rows(0).Item("nombre"), "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vConexion.vidBodega = 0
                vConexion.vDescripcion = "" 'lueBodegas.Text
                

                mCancel = False
                Close()

            Else
                XtraMessageBox.Show("Clave incorrecta", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtClave.Focus()
                txtClave.SelectAll()
                '--picCargando.Visible = False

            End If
            ' ''If MantenimientoBDDToolStripMenuItem.Checked Then
            ' ''    Dim frmTmpo As frmConfiguracionBDD = New frmConfiguracionBDD
            ' ''    frmTmpo.ShowDialog()
            ' ''End If

        Catch ex As Exception
            '--picCargando.Visible = False

            XtraMessageBox.Show("Error: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmInicio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If Not vCerrarb And Not vAceptar Then
        '    Application.Exit()
        'End If
    End Sub




   
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServidor.Text = vConexion.vServidor
    End Sub
End Class