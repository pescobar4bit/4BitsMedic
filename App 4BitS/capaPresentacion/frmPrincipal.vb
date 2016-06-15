Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.Tutorials.Controls
Imports DevExpress.XtraBars
Imports System.Threading
Imports System.IO
Imports System.Data.SqlClient
Imports namespace4BITS.nsFuncionesVINNS
Imports System.Globalization
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI


Public Class frmPrincipal
    Dim waitDialgo As WaitDialogForm
    Private vNumeroTab As Integer = 0
    Private mrfFileName As String = "mostRecentFiles.ini"
    Private vDTQueBusca As DataTable = Nothing ' para hacer busquedas 
    Private Sub frmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        escribirRegistro("skin", defaultLookAndFeel1.LookAndFeel.SkinName)
        Application.Exit()
        Me.Dispose()
    End Sub
    Private Function versionArchivo() As String
        Try

        
            Dim fvi As System.Diagnostics.FileVersionInfo = _
                    System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
            'Return fvi.FileVersion
            'Return fvi.ProductVersion

            Dim sb As New System.Text.StringBuilder
            'sb.AppendLine("ProductName:     " & fvi.ProductName)
            'sb.AppendLine("FileDescription: " & fvi.FileDescription)
            sb.AppendLine(fvi.FileVersion)
            'sb.AppendLine("ProductVersion:  " & fvi.ProductVersion)
            'sb.AppendLine("LegalCopyright:  " & fvi.LegalCopyright)

            Return sb.ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Sub inicioloMasReciente()
        Dim fileName As String = vDireccionDocumentos & "\" & mrfFileName
        If (Not System.IO.File.Exists(fileName)) Then
            Return
        End If
        Dim sr As System.IO.StreamReader = System.IO.File.OpenText(fileName)
        Dim s As String = sr.ReadLine()
        Do While Not s Is Nothing
            ilbRecientes.Items.Add(s, 2)
            'ilbRecientes.Items(ilbRecientes.Items.Count-1).ta
            'AddToMostRecentFiles(s, List)
            s = sr.ReadLine()
        Loop
        sr.Close()
    End Sub
    Private Sub grabarloMasReciente(ByVal list As BarListItem)
        Try
            Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(vDireccionDocumentos & "\" & mrfFileName)
            'For i As Integer = list.Strings.Count - 1 To 0 Step -1
            '    sw.WriteLine(list.Strings(i))
            'Next i
            For i As Integer = ilbRecientes.Items.Count - 1 To 0 Step -1
                sw.WriteLine(ilbRecientes.Items(i).Value)
            Next
            sw.Close()
        Catch
        End Try
    End Sub
   
    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'arMRUList = New MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images(0), imageCollection3.Images(1))
        'AddHandler arMRUList.LabelClicked, AddressOf OnLabelClicked
        'InitMostRecentFiles(arMRUList)

        rcPrincipal.ForceInitialize()
        DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, True)
        For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
            Dim item As BarCheckItem = rcPrincipal.Items.CreateCheckItem(skin.SkinName, False)
            item.Tag = skin.SkinName
            AddHandler item.ItemClick, AddressOf OnPaintStyleClick
            iPaintStyle.ItemLinks.Add(item)
        Next skin
        'btnUsuarios.Visibility = BarItemVisibility.Never
        Dim vSkin As String = leerRegistro("skin")
        If vSkin = "" Then vSkin = "Caramel"
        defaultLookAndFeel1.LookAndFeel.SkinName = vSkin
        rcPrincipal.ApplicationButtonDropDownControl = Nothing
        rcPrincipal.ApplicationButtonDropDownControl = BackstageViewControl1
        cargarConfiguracionRegional()
        beiVersion.EditValue = versionArchivo()
        ''Me.Text = Me.Text & " V" & versionArchivo()
        'If File.Exists(vDireccionDocumentos & "\config_server.xml") Then
        '    leerXML(vDireccionDocumentos)
        '    If verificarActivacion() Then



        '        configuracionInicial()

        '    Else
        '        XtraMessageBox.Show("El programa no esta activado", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        'Else

        '    Dim frmTmpo As frmWizard = New frmWizard

        '    frmTmpo.ShowDialog()
        '    frmTmpo.Dispose()
        'End If



    End Sub
    Private Function verificarActivacion() As Boolean
        Dim vCumple As Boolean = False
        If vConexion.vActivacion.Length > 0 Then
            Dim vCuan As Integer = 1
            Dim vUltimaPos As Integer = 0
            vCumple = True
            Dim vCod As String = EncryptString(vConexion.vActivacion, "EJCGVINNS", DECRYPT)
            For x As Integer = 1 To Len(vCod)
                If Mid(vCod, x, 1) = "|" Then
                    Select Case vCuan
                        Case 1
                            If Not PropiedadesDiscoDuro(1) = Mid(vCod, 1, x - 1) Then
                                vCumple = False
                            Else
                                vUltimaPos = x
                                vCuan += 1
                            End If

                        Case 2
                            If Not PropiedadesDiscoDuro(2) = Mid(vCod, vUltimaPos + 1, x - 1 - vUltimaPos) Then
                                vCumple = False
                            Else
                                vUltimaPos = x
                                vCuan += 1
                                vConexion.vActivacion = Mid(vCod, x + 1, Len(vCod) - x)
                                Exit For
                            End If
                    End Select
                End If
                If Not vCumple Then Exit For
            Next
        End If
        verificarActivacion = vcumple
        Return verificarActivacion
    End Function
    Private Sub cargarConfiguracionRegional()

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-GT")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("es-GT")
        'ilbRecientes.Items.Add("TIENDAS.KML", 2)
    End Sub
    Private Sub configuracionInicial(Optional ByVal vSegundaVez As Boolean = False)
        bsiDescripcion.Caption = "CuentasI "
        'bsiBdd.Caption = "BDD: "
        picFondo.Image = Nothing
        picFotoU.Image = Nothing
        picFotoU.Visible = False
        rcPrincipal.SelectedPage = ribbonPage1
        If Not vSegundaVez Then
            Dim frmTmpo As frmInicioEmpresas = New frmInicioEmpresas
            frmTmpo.ShowDialog(Me)
            If frmTmpo.oCancelar Then
                Application.Exit()
                Exit Sub
            End If

            frmTmpo.Dispose()
        End If
        Dim frmIni As frmInicio = New frmInicio
        frmIni.ShowDialog()
        If frmIni.oCancelar Then
            Application.Exit()
            Exit Sub
        Else
            bsiBdd.Caption = "BDD: " & vConexion.vBdd
            beiSucursal.EditValue = vConexion.vServidor
        End If
        frmIni.Dispose()
        'configuracionInicial()
        bsiUsuario.Caption = DTUsuario.Rows(0).Item("nombre")

        'cargarNotas(3)
        If Not IsDBNull(DTUsuario.Rows(0).Item("foto")) Then
            'picFondo.BringToFront()
            'picFotoU.BringToFront()
            'picFotoU.SendToBack()
            'picFondo.SendToBack()
            picFotoU.Visible = True
            picFotoU.Image = convImagenBDD(DTUsuario.Rows(0).Item("foto"))


        Else
            picFotoU.Visible = False
        End If
        'inicioloMasReciente()
        bsiDescripcion.Caption = "CuentasI " & vConexion.vDescripcion
        'If vConexion.vidSerie = "" Then
        bsiSerie.Caption = "Serie NO DEFINIDA"
        Try


            Dim vQFecha As Date = EjecutarSelect("select getdate() as fecha").Rows(0).Item("fecha")
            If Math.Abs(DateDiff(DateInterval.Day, Date.Now.Date, vQFecha.Date)) > 0 Then
                XtraMessageBox.Show("Verifique la fecha del sistema, podria trabajar con datos incorrectos", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            vConexion.vFechaServidor = vQFecha
        Catch ex As Exception

        End Try
        ''llenarDTFactuasCredito()
        picFondo.Image = My.Resources.farmalider01
    End Sub
   
    Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
    End Sub
   


    Private Sub iPaintStyle_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles iPaintStyle.Popup
        For Each link As BarItemLink In iPaintStyle.ItemLinks
            CType(link.Item, BarCheckItem).Checked = link.Item.Caption = defaultLookAndFeel1.LookAndFeel.ActiveSkinName
        Next link
    End Sub

   

    Private Sub iAbout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
    
    End Sub

    Private Sub iExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
        Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    

    Private Sub iAutoHide_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAutoHide.ItemClick
        rcPrincipal.Minimized = Not rcPrincipal.Minimized
    End Sub


    Private Sub tabmdiPrincipal_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles tabmdiPrincipal.PageAdded
        'barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = True
        picFotoU.SendToBack()
        picFondo.SendToBack()
        vNumeroTab = e.Page.TabControl.PageCount - 1
        picFondo.Visible = False
        picFotoU.Visible = False
        e.Page.Image = imageCollection2_2.Images(4)
    End Sub

    Private Sub tabmdiPrincipal_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles tabmdiPrincipal.PageRemoved
        If tabmdiPrincipal.Pages.Count = 0 Then
            picFondo.BringToFront() 'barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
            'If vVERSIONACT.descripcion <> "" Then
            '    picFondo.Image = vVERSIONACT.foto
            'End If

            picFondo.Visible = True
            If picFotoU.Image IsNot Nothing And (DockPanel1.Visibility.ToString = Docking.DockVisibility.AutoHide.ToString) Then
                picFotoU.BringToFront()
                picFotoU.Visible = True
            End If
            
            'configurarVistas()
        End If

    End Sub

   

    Private Sub btnSesion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSesion.ItemClick
        CerrarSesion()

    End Sub
    Private Sub btnConexion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConexion.ItemClick
        Dim vResul As Integer = XtraMessageBox.Show("¿Desea tratar de conectarse a la base de datos con la configuración guardada?" & vbCrLf & "Si elige que ""No"", se abrira el asistente para configurar una nueva conexión", "VINNS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        Select Case vResul
            Case 7 'no
                Dim frmTmpo As frmWizard = New frmWizard
                frmTmpo.txtBdd.Text = vConexion.vBdd
                frmTmpo.txtClave.Text = vConexion.vPasswordbdd
                frmTmpo.txtSource.Text = vConexion.vServidor
                frmTmpo.txtUsuario.Text = vConexion.vUsuariobdd
                frmTmpo.ShowDialog()
                frmTmpo.Dispose()
            Case 6 ' yes

                wbProceso01.RunWorkerAsync()
            Case 2 ' cancel

        End Select

    End Sub
    Private Sub wbProceso01_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles wbProceso01.DoWork
        Dim espera As New WaitDialogForm("Intentando conectar....", "Espere por favor")
        Thread.Sleep(500)
        '  On Error GoTo MensajeC
        Dim Cn2 As SqlConnection
        Dim tmpNbdd As String = vConexion.vBdd
        Dim tmpSvbdd As String = vConexion.vServidor
        Dim tmpPsbdd = vConexion.vPasswordbdd
        Dim tmpUsbdd = vConexion.vUsuariobdd

        Cn2 = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA

        Try
            Cn2.Open()
            e.Result = "1"
            Cn2.Close()
            Cn2.Dispose()
            Cn2 = Nothing
            espera.Close()
        Catch ex As SqlException
            XtraMessageBox.Show("Número de error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Result = "0"
            espera.Close()
        End Try




    End Sub

    Private Sub wbProceso01_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles wbProceso01.RunWorkerCompleted
        If e.Result = 1 Then
            ' btnConexion.Visibility = BarItemVisibility.Never
          
            XtraMessageBox.Show("Si hay conexión con el servidor", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If XtraMessageBox.Show("No hay conexión,¿desea volver a configurar la conexión para accesar a la base de datos?", "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim frmTmpo As frmWizard = New frmWizard
                frmTmpo.txtBdd.Text = vConexion.vBdd
                frmTmpo.txtClave.Text = vConexion.vPasswordbdd
                frmTmpo.txtSource.Text = vConexion.vServidor
                frmTmpo.txtUsuario.Text = vConexion.vUsuariobdd
                frmTmpo.ShowDialog()
                frmTmpo.Dispose()
            End If


        End If
    End Sub

    Private Sub btnNuevaBodega_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevaBodega.ItemClick
        'If Not verificarPermiso(btnNuevaBodega.Name) Then
        '    XtraMessageBox.Show("No tiene permisos para acceso", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        Dim vNombreAccion As String = btnNuevaBodega.Name
        If Not verificarPermiso(vNombreAccion) Then
            XtraMessageBox.Show("No tiene permisos para acceso", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim frmTmpoPermiso As frmInputPass = New frmInputPass(vNombreAccion)
            frmTmpoPermiso.ShowDialog(Me)
            If frmTmpoPermiso.oCancelar Then
                Exit Sub
            End If
            frmTmpoPermiso.Dispose()
        End If
        vNombreAccion = "nuevabodega"
        If Not verificarPermiso(vNombreAccion) Then
            XtraMessageBox.Show("No tiene permisos para acceso", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim frmTmpoPermiso As frmInputPass = New frmInputPass(vNombreAccion)
            frmTmpoPermiso.ShowDialog(Me)
            If frmTmpoPermiso.oCancelar Then
                Exit Sub
            End If
            frmTmpoPermiso.Dispose()
        End If
       
    End Sub

    Private Sub btnUsuarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsuarios.ItemClick
       
        Dim vNombreAccion As String = btnUsuarios.Name
        If Not verificarPermiso(vNombreAccion) Then
            XtraMessageBox.Show("No tiene permisos para acceso", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim frmTmpoPermiso As frmInputPass = New frmInputPass(vNombreAccion)
            frmTmpoPermiso.ShowDialog(Me)
            If frmTmpoPermiso.oCancelar Then
                Exit Sub
            End If
            frmTmpoPermiso.Dispose()
        End If
        Dim frmTmpo As frmGrupos = New frmGrupos(Me)
        frmTmpo.ShowDialog()
        frmTmpo.Dispose()

    End Sub

   

    Private Sub acAlerta_AlertClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles acAlerta.AlertClick
        ' MsgBox(e.Info.Text)
        If e.Info.Text = "Salir Para Actualizar Sistema" Then
            'facAlCredito()
            Close()
        End If
    End Sub

    Private Sub acAlerta_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs) Handles acAlerta.ButtonClick

        If e.Button.Name = "alertButton1" Then
            ' facAlCredito()
            Close()
        End If
    End Sub

    Private Sub tmTiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmTiempo.Tick
        If Not bwProcesoInicialFacturasCredito.IsBusy Then
            If DTFacturasCredito.Rows.Count > 0 Then
                acAlerta.Show(Me, "Hay facturas al crédito pendientes...", "Ver facturas", "Ver facturas", My.Resources.note_edit)
                tmTiempo.Interval = 10800000 '3 horas


                llenarDTFactuasCredito()
            End If
        End If
    End Sub

   

    Private Sub CerrarSesion()
        'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Courier New", 12)


        If tabmdiPrincipal.Pages.Count > 0 Then
            XtraMessageBox.Show("Debe cerrar todas la ventanas abiertas para poder cerrar sesión", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If XtraMessageBox.Show("¿Desea cerrar sesión?", "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                configuracionInicial(True)
            End If

        End If

    End Sub
    Private Sub BackstageViewCerrarS_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles BackstageViewCerrarS.ItemClick
        CerrarSesion()
    End Sub

    Private Sub DockPanel1_VisibilityChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles DockPanel1.VisibilityChanged
        '        MsgBox(e.Visibility.ToString)
        If e.Visibility.ToString = Docking.DockVisibility.Visible.ToString Then
            'picFotoU.SendToBack()
            'picFondo.SendToBack()
            picFotoU.Visible = False
        Else
            If tabmdiPrincipal.Pages.Count = 0 Then
                picFotoU.Visible = True
            End If

        End If
    End Sub

   

    Private Sub btnModificarUsuarioPropio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificarUsuarioPropio.ItemClick
        Dim frmTmpo As frmUsuariosNuevo = New frmUsuariosNuevo
        frmTmpo.vDRMofificarUsuario = DTUsuario.Rows(0)
        frmTmpo.vNuevoUsuario = False
        frmTmpo.ckHabilitado.Visible = False
        frmTmpo.lueUsuario.Visible = False
        frmTmpo.LabelControl5.Visible = False
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then
            DTUsuario.Rows(0).Item("nombre") = frmTmpo.oNombre
            DTUsuario.Rows(0).Item("usuario") = frmTmpo.oUsuario
            DTUsuario.Rows(0).Item("clave") = EncryptString(frmTmpo.oClave, "EJCGVINNS", ENCRYPT)
            If frmTmpo.oFoto.Image Is Nothing Then
                picFotoU.Image = Nothing
                picFotoU.Visible = False
            Else
                Dim fsFoto As FileStream
                Dim vPath As String = vDireccionDocumentos & "\fototmpocamb.jpg" '"C:\VINNS\Farmalider\bin\Debug"
                frmTmpo.oFoto.Image.Save(vPath, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim fiFoto As FileInfo = New FileInfo(vPath)

                Dim Temp As Long = fiFoto.Length
                Dim lung As Long = Convert.ToInt32(Temp)
                Dim picture(lung) As Byte
                fsFoto = New FileStream(vPath, FileMode.Open)
                fsFoto.Read(picture, 0, lung)
                fsFoto.Close()
                If File.Exists(vPath) Then Kill(vPath)


                DTUsuario.Rows(0).Item("foto") = picture
                picFotoU.Image = frmTmpo.oFoto.Image
            End If

            bsiUsuario.Caption = DTUsuario.Rows(0).Item("nombre")
        End If
    End Sub

 


    Private Sub dpNotas_CustomButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles dpNotas.CustomButtonClick
        cargarNotas(e.Button.Properties.Tag)
        

    End Sub
    Private Sub cargarNotas(ByVal vTipo As String)
        Select Case vTipo
            Case "0" ' Eliminar pestaña
                Dim vIndex As Integer = xtcNotas.TabPages.TabControl.SelectedTabPageIndex
                If XtraMessageBox.Show("¿Desea eliminar la nota " & xtcNotas.TabPages(vIndex).Text & ", se perderán los datos?", "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
                xtcNotas.TabPages.RemoveAt(vIndex)
                'MsgBox(xtcNotas.TabPages.TabControl.SelectedTabPageIndex)

            Case "1" 'Agregar pestaña
                xtcNotas.TabPages.Add("Nota " & xtcNotas.TabPages.Count + 1)

                xtcNotas.TabPages(xtcNotas.TabPages.Count - 1).Controls.Add(New DevExpress.XtraEditors.MemoEdit)
                For Each tabP As DevExpress.XtraTab.XtraTabPage In xtcNotas.TabPages
                    For Each controlTab In tabP.Controls
                        If TypeOf controlTab Is DevExpress.XtraEditors.MemoEdit Then
                            ''LIMPIA EL CONTROL
                            Dim memo1 As DevExpress.XtraEditors.MemoEdit = CType(controlTab, DevExpress.XtraEditors.MemoEdit)
                            'For x As Integer = 0 To listado.Items.Count - 1
                            '    listado.Items(x).CheckState = vValor.GetHashCode
                            'Next
                            memo1.Dock = DockStyle.Fill
                        End If
                    Next
                Next
            Case "2"  'Guardar
                Dim vDatosParaInsertar As datosInsertarInstruccion = Nothing
                vDatosParaInsertar = INICIARTRANSACCION(vDatosParaInsertar)
                vDatosParaInsertar = AGREGARTRAN(vDatosParaInsertar, "delete tnotas where idusuario=" & DTUsuario.Rows(0).Item("idUsuario"))
                If xtcNotas.TabPages.Count > 0 Then
                    xtcNotas.TabPages(xtcNotas.TabPages.Count - 1).Controls.Add(New DevExpress.XtraEditors.MemoEdit)
                    For Each tabP As DevExpress.XtraTab.XtraTabPage In xtcNotas.TabPages
                        For Each controlTab In tabP.Controls
                            If TypeOf controlTab Is DevExpress.XtraEditors.MemoEdit Then
                                ''LIMPIA EL CONTROL
                                Dim memo1 As DevExpress.XtraEditors.MemoEdit = CType(controlTab, DevExpress.XtraEditors.MemoEdit)
                                'For x As Integer = 0 To listado.Items.Count - 1
                                '    listado.Items(x).CheckState = vValor.GetHashCode
                                'Next
                                If memo1.Text.Length <> 0 Then vDatosParaInsertar = AGREGARTRAN(vDatosParaInsertar, "insert into tnotas (idusuario,nota,fecha) values(" & DTUsuario.Rows(0).Item("idUsuario") & ",'" & memo1.Text & "','" & Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss") & "')")
                            End If
                        Next
                    Next
                End If
                Try


                    Dim vError As String = TERMINARBIENTRAN(vDatosParaInsertar, "paInsertarInstrucciones")
                    If vError <> 0 Then
                        XtraMessageBox.Show("Error. ", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    XtraMessageBox.Show("Error. " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Case "3" 'refrescar
                xtcNotas.TabPages.Clear()
                Dim vDTNotas As DataTable = EjecutarSelect("select * from tnotas where idusuario=" & DTUsuario.Rows(0).Item("idUsuario") & " order by idnota desc")
                If vDTNotas.Rows.Count > 0 Then
                    For x As Integer = 0 To vDTNotas.Rows.Count - 1


                        xtcNotas.TabPages.Add("Nota " & xtcNotas.TabPages.Count + 1)


                        Dim memoagrega As New DevExpress.XtraEditors.MemoEdit  'CType(xtcNotas.TabPages(xtcNotas.TabPages.Count - 1).Controls, DevExpress.XtraEditors.MemoEdit)
                        memoagrega.Text = vDTNotas.Rows(x).Item("nota")
                        'memoagrega = vDTNotas.Rows(x).Item("nota")
                        xtcNotas.TabPages(xtcNotas.TabPages.Count - 1).Controls.Add(memoagrega)
                    Next


                Else ' si no hay notas...
                    xtcNotas.TabPages.Add("Nota " & xtcNotas.TabPages.Count + 1)


                    Dim memoagrega As New DevExpress.XtraEditors.MemoEdit  'CType(xtcNotas.TabPages(xtcNotas.TabPages.Count - 1).Controls, DevExpress.XtraEditors.MemoEdit)
                    memoagrega.Text = ""
                    'memoagrega = vDTNotas.Rows(x).Item("nota")
                    xtcNotas.TabPages(xtcNotas.TabPages.Count - 1).Controls.Add(memoagrega)
                End If
            Case "cerrar"
                xtcNotas.TabPages.Clear()
                'For x1 As Integer = 0 To xtcNotas.TabPages.Count - 1
                '    xtcNotas.TabPages.RemoveAt(x1)
                'Next

        End Select
        For Each tabP As DevExpress.XtraTab.XtraTabPage In xtcNotas.TabPages ' para poner en fill todos los memos
            For Each controlTab In tabP.Controls
                If TypeOf controlTab Is DevExpress.XtraEditors.MemoEdit Then
                    ''LIMPIA EL CONTROL
                    Dim memo1 As DevExpress.XtraEditors.MemoEdit = CType(controlTab, DevExpress.XtraEditors.MemoEdit)
                    'For x As Integer = 0 To listado.Items.Count - 1
                    '    listado.Items(x).CheckState = vValor.GetHashCode
                    'Next
                    memo1.Dock = DockStyle.Fill
                End If
            Next
        Next
    End Sub
    Private Sub btnAnalisisDisenador_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnalisisDisenador.ItemClick
        'Dim vNombreAccion As String = btnAnalisisDisenador.Name
        'If Not verificarPermiso(vNombreAccion) Then
        '    XtraMessageBox.Show("No tiene permisos para acceso", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Dim frmTmpoPermiso As frmInputPass = New frmInputPass(vNombreAccion)
        '    frmTmpoPermiso.ShowDialog(Me)
        '    If frmTmpoPermiso.oCancelar Then
        '        Exit Sub
        '    End If
        '    frmTmpoPermiso.Dispose()
        'End If
        Dim frmTmpo As frmAnalisisDisenadorActu = New frmAnalisisDisenadorActu
        frmTmpo.Show()
    End Sub

   
    Private Sub BarButtonItem69_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem69.ItemClick
        Dim frmTempEsp As New frmEspecialidades
        frmTempEsp.MdiParent = Me
        frmTempEsp.Show()
    End Sub
End Class