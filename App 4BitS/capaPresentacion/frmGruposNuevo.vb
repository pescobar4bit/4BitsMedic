Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Utils
Imports namespace4BITS.nsFuncionesVINNS
Public Class frmGruposNuevo
    Public vNuevoGrupo As Boolean = False
    Public vDRModificarGrupo As DataRow = Nothing
    Dim mCancel As Boolean = True
    Dim vDTCasas As DataTable = Nothing
    'Dim waitDialgo As WaitDialogForm
    
    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub frmGruposNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCasas()
        If Not vNuevoGrupo Then
            txtGrupo.Text = vDRModificarGrupo("nombre")
            ckHabilitado.Checked = CBool(vDRModificarGrupo("habilitado"))

            lueCategorias.EditValue = vDRModificarGrupo("idCasa")
            'Dim algo As String = lueCategorias.Text
            'lueCategorias.Properties.ForceInitialize()
            'lueCategorias.Text = algo
        Else
            lueCategorias.Text = "Todas"
        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        dvpValidar.Validate(txtGrupo)
        If dvpValidar.GetInvalidControls.Count > 0 Then Exit Sub

        If vNuevoGrupo Then
            INSERTAR("insert into tgrupos (nombre,habilitado,fecha,idbodega,idcasa) values('" & txtGrupo.Text.Trim & "'," & ckHabilitado.Checked.GetHashCode & ",'" & Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss") & "'," & vConexion.vidBodega & "," & lueCategorias.EditValue & ")")
            XtraMessageBox.Show("Grupo ingresado.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            INSERTAR("update tgrupos set nombre='" & txtGrupo.Text.Trim & "', habilitado=" & ckHabilitado.Checked.GetHashCode & ", idcasa=" & lueCategorias.EditValue & " where idgrupo=" & vDRModificarGrupo("idGrupo"))
            XtraMessageBox.Show("Grupo modificado.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        mCancel = False
        Close()
    End Sub
    Private Sub cargarCasas()
        Try
            'waitDialgo = New WaitDialogForm("Cargando casas....", "Espere por favor")
            mostarWait(Me, "Cargando casas...", "Espere por favor")
            vDTCasas = Nothing
            vDTCasas = EjecutarSelect("select * from tcasas where idbodega=" & vConexion.vidBodega)
            If vDTCasas.Rows.Count > 0 Then
                vDTCasas.Rows.Add()
                vDTCasas.Rows(vDTCasas.Rows.Count - 1).Item("idCasa") = 0
                vDTCasas.Rows(vDTCasas.Rows.Count - 1).Item("casa") = "Todas"
                vDTCasas.Rows(vDTCasas.Rows.Count - 1).Item("direccion") = "Todas"
                vDTCasas.Rows(vDTCasas.Rows.Count - 1).Item("telefono") = ""
                lueCategorias.Properties.DataSource = vDTCasas
                'lueCategorias.Properties.ForceInitialize()
                'lueCategorias.Text = "Todas"
                btnAceptar.Enabled = True
            Else
                lueCategorias.Properties.DataSource = Nothing
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

    Private Sub lueCategorias_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lueCategorias.ButtonClick
        Select Case e.Button.Index
            Case 1
                cargarCasas()
        End Select
    End Sub
End Class