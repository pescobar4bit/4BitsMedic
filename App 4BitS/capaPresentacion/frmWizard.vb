Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports namespace4BITS.nsFuncionesVINNS
Public Class frmWizard
    Dim vDTEmpresas As DataTable = Nothing

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        vValidarControles()
        If dvpValidar.GetInvalidControls.Count > 0 Then
            Exit Sub
        End If
        wpConfigurar.AllowCancel = False
        wpConfigurar.AllowCancel = False
        btnConectar.Enabled = False
        pbConectar.Visible = True
        wbProceso01.RunWorkerAsync()
    End Sub

    Private Sub wcConfigInicial_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangedEventArgs) Handles wcConfigInicial.SelectedPageChanged
        If e.Page Is wpConfigurar Then
            txtSource.Focus()
        ElseIf e.Page Is wpSeleccionEmpresa Then
            lueEmpresas.Focus()
        End If
    End Sub


    Private Sub wcConfigInicial_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles wcConfigInicial.SelectedPageChanging
        If e.Page Is wpConfigurar Then
            wpConfigurar.AllowNext = False

        ElseIf e.Page Is wpFinal Then
            wpFinal.AllowBack = False
        ElseIf e.Page Is wpActivacion Then
            If txtActivacion.Enabled Then
                wpActivacion.AllowNext = False
            End If
        ElseIf e.Page Is wpSeleccionEmpresa Then
            wpSeleccionEmpresa.AllowNext = False
        End If
    End Sub

    Private Sub wbProceso01_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles wbProceso01.DoWork

        '  On Error GoTo MensajeC

        Dim tmpNbdd As String = txtBdd.Text
        Dim tmpSvbdd As String = txtSource.Text
        Dim tmpPsbdd = txtClave.Text
        Dim tmpUsbdd = txtUsuario.Text
        Dim Cn2 As SqlConnection
        Cn2 = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA

        Try
            Cn2.Open()
            e.Result = "1"
            Cn2.Close()
            Cn2.Dispose()
            Cn2 = Nothing
        Catch ex As SqlException
            XtraMessageBox.Show("Número de error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Result = "0"
        End Try

        


    End Sub
    Private Sub vValidarControles()
        dvpValidar.Validate(txtBdd)
        dvpValidar.Validate(txtClave)
        dvpValidar.Validate(txtSource)
        dvpValidar.Validate(txtUsuario)
    End Sub

    Private Sub wbProceso01_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles wbProceso01.RunWorkerCompleted
        pbConectar.Visible = False
        wpConfigurar.AllowCancel = True
        wpConfigurar.AllowCancel = True
        If e.Result = 1 Then
            wpConfigurar.AllowNext = True
            btnConectar.Enabled = False
            txtBdd.Enabled = False
            txtClave.Enabled = False
            txtSource.Enabled = False
            txtUsuario.Enabled = False
            lblConexion.Visible = True
            cargarEmpresas()
            If vDTEmpresas.Rows.Count > 0 Then
                lueEmpresas.ItemIndex = 0
            End If
        Else
            wpConfigurar.AllowNext = False
            btnConectar.Enabled = True
        End If
    End Sub
    Private Sub cargarEmpresas()
        Dim tmpNbdd As String = txtBdd.Text
        Dim tmpSvbdd As String = txtSource.Text
        Dim tmpPsbdd = txtClave.Text
        Dim tmpUsbdd = txtUsuario.Text
        Dim Cn2 As SqlConnection
        Dim cmComand2 As SqlCommand

        Dim daVista As New SqlDataAdapter


        Cn2 = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA

        Try
            Cn2.Open()
            vDTEmpresas = New DataTable
            Dim vSql As String = "select * from tempresas"
            cmComand2 = New SqlCommand(vSql, Cn2)
            cmComand2.CommandType = CommandType.Text
            daVista.SelectCommand = cmComand2
            daVista.Fill(vDTEmpresas)

            lueEmpresas.Properties.DataSource = vDTEmpresas
            lueEmpresas.Properties.ForceInitialize()
            If vDTEmpresas.Rows.Count > 0 Then

                '' lueEmpresas.ItemIndex = 0
            Else
                lueEmpresas.Properties.DataSource = Nothing
            End If

            Cn2.Close()
            Cn2.Dispose()
            Cn2 = Nothing
        Catch ex As SqlException
            XtraMessageBox.Show("Número de error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)



        End Try


    End Sub
    Private Sub frmWizard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

 

    Private Sub wpFinal_PageCommit(ByVal sender As Object, ByVal e As System.EventArgs) Handles wpFinal.PageCommit
        configuracionINICIAL(txtSource.Text, txtBdd.Text, txtUsuario.Text, EncryptString(txtClave.Text, "EJCGVINNS", ENCRYPT), lueEmpresas.EditValue, EncryptString(PropiedadesDiscoDuro(1) & "|" & PropiedadesDiscoDuro(2) & "|" & txtActivacion.Text, "EJCGVINNS", ENCRYPT))
        XtraMessageBox.Show("Configuración realizada, vuelva a iniciar el programa", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lueEmpresas_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueEmpresas.EditValueChanged
        If Not vDTEmpresas Is Nothing Then
            If vDTEmpresas.Rows.Count > 0 Then lblClave.Text = lueEmpresas.GetColumnValue(lueEmpresas.Properties.Columns(2))
        End If

    End Sub

    Private Sub btnConectarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectarEmpresa.Click
        If txtClaveEmpresa.Text = lblClave.Text Then
            depError.SetError(txtClaveEmpresa, "")
            XtraMessageBox.Show("Conexión establecida.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            wpSeleccionEmpresa.AllowNext = True
        Else
            XtraMessageBox.Show("Clave incorrecta.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            depError.SetError(txtClaveEmpresa, "Clave incorrecta")
            wpSeleccionEmpresa.AllowNext = False
        End If
    End Sub

    Private Sub btnActivacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivacion.Click
        Dim tmpNbdd As String = txtBdd.Text
        Dim tmpSvbdd As String = txtSource.Text
        Dim tmpPsbdd = txtClave.Text
        Dim tmpUsbdd = txtUsuario.Text
        Dim Cn2 As SqlConnection
        Dim cmComand2 As SqlCommand
        Dim cmComand3 As SqlCommand

        Dim daVista As New SqlDataAdapter
        Dim vDTActivacion As DataTable = Nothing

        Cn2 = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA
        wpActivacion.AllowNext = False
        Try
            Cn2.Open()
            vDTActivacion = New DataTable
            Dim vSql As String = "select * from tseries where numero='" & txtActivacion.Text & "'"

            cmComand2 = New SqlCommand(vSql, Cn2)
            cmComand2.CommandType = CommandType.Text
            daVista.SelectCommand = cmComand2
            daVista.Fill(vDTActivacion)
            If vDTActivacion.Rows.Count > 0 Then
                If vDTActivacion.Rows(0).Item("nactivaciones") > 0 Then
                    If XtraMessageBox.Show("¿Desea activar el programa?", "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        vSql = "update tseries set nactivaciones=" & vDTActivacion.Rows(0).Item("nactivaciones") - 1 & " WHERE idSerie=" & vDTActivacion.Rows(0).Item("idSerie")
                        cmComand3 = New SqlCommand(vSql, Cn2)
                        cmComand3.CommandType = CommandType.Text
                        cmComand3.ExecuteNonQuery()
                        XtraMessageBox.Show("Activación realizada", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtActivacion.Enabled = False
                        btnActivacion.Enabled = False
                        wpActivacion.AllowNext = True
                    End If
                Else
                    XtraMessageBox.Show("Este número de activación ya no se puede utilizar, debe ingresar otro número de activación", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                XtraMessageBox.Show("Número de activación incorrecto", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                wpActivacion.AllowNext = False
            End If

            Cn2.Close()
            Cn2.Dispose()
            Cn2 = Nothing
        Catch ex As SqlException
            XtraMessageBox.Show("Número de error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)



        End Try
    End Sub
   
End Class