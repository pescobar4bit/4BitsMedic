Imports System.Threading
Imports DevExpress.Utils
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Public Class frmInicioEmpresas
    Dim vDTServidor As DataTable = Nothing
    Dim mCancel As Boolean = True
    Dim waitDialgo As WaitDialogForm
    Dim vConexionCopia As datosConexion = Nothing
    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub frmInicioEmpresas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub frmInicioEmpresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'waitDialgo = New WaitDialogForm("Cargando....", "Espere por favor")
        picCargando.Visible = True
        vConexionCopia = vConexion
        bwProceso01.RunWorkerAsync()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        mCancel = False
        Close()
    End Sub

    Private Sub lueNegocios_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lueNegocios.ButtonClick
        Select Case e.Button.Index
            Case 1

                ' waitDialgo = New WaitDialogForm("Cargando....", "Espere por favor")
                picCargando.Visible = True
                If Not bwProceso01.IsBusy Then bwProceso01.RunWorkerAsync()

        End Select
    End Sub

    Private Sub lueNegocios_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueNegocios.EditValueChanged
        asignarValores()
    End Sub
    Private Sub asignarValores()
        vConexion.vServidor = lueNegocios.GetColumnValue(lueNegocios.Properties.Columns(4))
        vConexion.vBdd = lueNegocios.GetColumnValue(lueNegocios.Properties.Columns(3))
        vConexion.vUsuariobdd = lueNegocios.GetColumnValue(lueNegocios.Properties.Columns(2))
        vConexion.vPasswordbdd = lueNegocios.GetColumnValue(lueNegocios.Properties.Columns(5))
    End Sub
    Private Sub bwProceso01_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwProceso01.DoWork
        Dim vCn As SqlConnection
        vCn = New SqlConnection("Data Source=" & vConexionCopia.vServidor & ";Initial Catalog=" & vConexionCopia.vBdd & ";Integrated Security=false;user ID=" & vConexionCopia.vUsuariobdd & ";password=" & vConexionCopia.vPasswordbdd)

        Try
            vCn.Open()
            e.Result = 1
            '  lblConexion.Text = "Si hay conexión"
        Catch ex As SqlException
            '            XtraMessageBox.Show("Error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)

            e.Result = 0
            'e.Cancel = True
            '            bProgreso.Visible = False
        End Try
    End Sub

    Private Sub bwProceso01_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwProceso01.RunWorkerCompleted
        Try
            DTEMPRESAS = Nothing
     
            If e.Result = 1 Then
                Dim vConexionTmpo As datosConexion = Nothing
                vConexionPrincipal = vConexion
                vConexionTmpo = vConexion
                vConexion = vConexionCopia
                vDTServidor = EjecutarSelect("select dbo.tNegocios.*, dbo.tEmpresas.empresa FROM dbo.tEmpresas INNER JOIN dbo.tNegocios ON dbo.tEmpresas.idEmpresa = dbo.tNegocios.idEmpresa where dbo.tEmpresas.idEmpresa=" & vConexionCopia.vidBodega)
                vConexion = vConexionTmpo
                'lueNegocios.Properties.ForceInitialize()
                lueNegocios.Properties.DataSource = Nothing

                If vDTServidor.Rows.Count > 0 Then
                    lueNegocios.Properties.DataSource = vDTServidor
                    DTEMPRESAS = vDTServidor.Copy
                    lueNegocios.Properties.ForceInitialize()
                    lueNegocios.ItemIndex = 0
                    asignarValores()
                    depError.SetError(lueNegocios, "")
                    btnAceptar.Enabled = True
                Else
                    depError.SetError(lueNegocios, "No hay distribuidoras definidas")
                    btnAceptar.Enabled = False
                End If

            Else
                Thread.Sleep(500)
                'waitDialgo.Close()
                picCargando.Visible = False
                XtraMessageBox.Show("Hay un error en la conexión", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnAceptar.Enabled = False
            End If
            Thread.Sleep(500)
            'waitDialgo.Close()
            picCargando.Visible = False
        Catch ex As Exception
            'waitDialgo.Close()
            picCargando.Visible = False
            XtraMessageBox.Show("Hay un error: " & ex.Message, "VINNS", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub picCargando_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCargando.EditValueChanged

    End Sub

    Private Sub picCargando_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles picCargando.VisibleChanged
        lblAviso.Visible = picCargando.Visible
    End Sub
End Class