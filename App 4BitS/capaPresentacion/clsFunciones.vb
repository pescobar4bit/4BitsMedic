Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars
Imports System.IO
Imports System.Xml
Imports System.Net
Imports System.Management
Imports DevExpress.XtraSplashScreen

Namespace nsFuncionesVINNS
    Module mdFuncionesVINNS
        Public Function reducirIMAGEN(ByVal vIma As DevExpress.XtraEditors.PictureEdit) As Image
            Dim vResult As Integer = 0
            If File.Exists(vDireccionDocumentos & "\tmpFinal.jpg") Then Kill(vDireccionDocumentos & "\tmpFinal.jpg")
            Try


                vIma.Image.Save(vDireccionDocumentos & "\tmpFinal.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim vPath As String = vDireccionDocumentos & "\tmpFinal.jpg"
                Dim fiFoto As FileInfo = New FileInfo(vPath)
                While fiFoto.Length > vTamanioM '100kb
                    vIma.Image = vIma.Image.GetThumbnailImage((vIma.Image.Width / 2), (vIma.Image.Height / 2), AddressOf MycallBack, IntPtr.Zero)
                    vIma.Image.Save(vDireccionDocumentos & "\tmpFinal.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    fiFoto = New FileInfo(vPath)
                End While
            Catch ex As Exception

                XtraMessageBox.Show("Hay un error al intentar comprimir la imagen, vuelva a intentarlo." & vbCrLf & "Si continua el error intente comprimir la imagen en otro programa (paint), para que no ocupe mucho espacio en la" & vbCrLf & "base de datos.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return vIma.Image
            End Try
            Return vIma.Image
        End Function
        Function MycallBack() As Boolean
            Return False
        End Function
        Public Function verificarPermiso(ByVal formu As String, Optional ByVal tipo As Integer = 0) As Boolean
            If IsDBNull(DTPermisos) Then Return False
            If DTPermisos.Rows.Count = 0 Then Return False
            If formu Is Nothing Then Return False
            Try
                Dim vDRDatos As DataRow() = DTPermisos.Select("nombre='" & formu & "'")
                If vDRDatos.GetLength(0) > 0 Then
                    If CBool(vDRDatos(0).Item("habilitado")) Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False

            End Try
        End Function

        Public Function calcularIVA(ByVal vValor As Double, Optional ByVal vRestarValor As Boolean = False) As Double
            Try
                Select Case vRestarValor
                    Case True
                        calcularIVA = Math.Round(vValor - (vValor / 1.12), 4)
                    Case Else
                        calcularIVA = Math.Round(vValor / 1.12, 4)
                End Select

            Catch ex As Exception
                calcularIVA = 0
                Exit Function
            End Try

        End Function
        Public Function sinAproximar(ByVal number As Decimal, ByVal decimals As Integer) As Decimal
            Dim Multiplicador = Math.Pow(10, decimals)
            Return Math.Truncate(number * Multiplicador) / Multiplicador
        End Function
        Public Function aproximarPrecio(ByVal vPrecio1 As Decimal) As Decimal
            'Dim vPrecio1 As Decimal = 0.0
            Dim vEntero As Integer = 0
            Dim vDecimal As Decimal = 0.0
            Dim vDecimalR As Decimal = 0.0
            Dim vResultado As Decimal = 0.0
            'vPrecio1 = vDTProductos.Rows(lueProductos.ItemIndex).Item("precioventa") * vDTProductos.Rows(lueProductos.ItemIndex).Item("unidadxfardo") * vDTProductos.Rows(lueProductos.ItemIndex).Item("unidadxpaquete")
            vDecimal = FormatNumber(vPrecio1 - Int(vPrecio1), 2)
            If vDecimal > 0.0 Then
                vEntero = Int(vPrecio1)
                vResultado = vEntero
                vDecimalR = vDecimal
                If (vDecimal < 0.25) Then vDecimalR = 0.25
                If vDecimal > 0.25 And vDecimal < 0.5 Then vDecimalR = 0.5
                If vDecimal > 0.5 And vDecimal < 0.75 Then vDecimalR = 0.5
                If vDecimal > 0.75 Then
                    vEntero += 1
                    vDecimalR = 0.0
                    vResultado = vEntero
                End If

                Return vResultado + vDecimalR
            Else
                Return vPrecio1
            End If
        End Function
        'Public Sub cargarBotones()

        '    ' Accessing items through the Items collection and setting the properties on them
        '    ' will propagate certain properties to all items with the same name...
        '    If frmPrincipal.ActiveMdiChild Is Nothing Then
        '        frmPrincipal.buttonSave.Enabled = False
        '        frmPrincipal.buttonFileSaveAs.Enabled = False
        '        frmPrincipal.buttonPrint.Enabled = False
        '    Else
        '        frmPrincipal.buttonSave.Enabled = True
        '        frmPrincipal.buttonFileSaveAs.Enabled = True
        '        frmPrincipal.buttonPrint.Enabled = True
        '    End If

        'End Sub
       
       
        Private Function queImagen(Optional ByVal vRutaImagen As String = "", Optional ByVal vDirecActual As String = "") As String
            Dim cmbDirecciones As System.Windows.Forms.ComboBox = New System.Windows.Forms.ComboBox
            Dim vArchivo As String = vDireccionDocumentos & "\iruta.vns"
            If Not File.Exists(vArchivo) Then
                Try


                    Dim fic As String = vArchivo


                    Dim sw As New System.IO.StreamWriter(fic)
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/paddle/grn-blank.png")
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/paddle/ltblu-blank.png")
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/paddle/pink-blank.png")
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/paddle/blu-blank.png")
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/pushpin/blue-pushpin.png")
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/pushpin/grn-pushpin.png")
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/pushpin/red-pushpin.png")
                    sw.WriteLine("http://maps.google.com/mapfiles/kml/paddle/T.png")
                    sw.Close()
                Catch ex As Exception

                End Try
            End If
            If File.Exists(vArchivo) Then
                Dim Random As New Random()
                Dim sr As New System.IO.StreamReader(vArchivo, System.Text.Encoding.Default, True)

                ' Leer el contenido mientras no se llegue al final
                While sr.Peek() <> -1
                    ' Leer una líena del fichero
                    Dim s As String = sr.ReadLine()
                    ' Si no está vacía, añadirla al control
                    ' Si está vacía, continuar el bucle
                    If String.IsNullOrEmpty(s) Then
                        Continue While
                    End If
                    cmbDirecciones.Items.Add(s)

                End While
                sr.Close()
                Dim numero As Integer = Random.Next(0, cmbDirecciones.Items.Count - 1)
                queImagen = cmbDirecciones.Items(numero)
                If queImagen = vDirecActual Then
                    numero = Random.Next(0, cmbDirecciones.Items.Count - 1)
                    queImagen = cmbDirecciones.Items(numero)
                End If
            Else
                Dim fotoImagen As DevExpress.XtraEditors.ImageEdit = New DevExpress.XtraEditors.ImageEdit
                fotoImagen.Image = My.Resources.map_sign_start
                If File.Exists(vRutaImagen & "map_sign_start.png") Then
                    Kill(vRutaImagen & "map_sign_start.png")
                    fotoImagen.Image.Save(vRutaImagen & "map_sign_start.png")
                End If
                queImagen = vRutaImagen & "map_sign_start.png"
            End If
            'If vDirecActual = queImagen Then queImagen(vRutaImagen, queImagen)
        End Function
        Public Function averiguarEdad(ByVal vfecha As Date) As Integer
            ' ''Dim diaHoy
            ' ''Dim mesHoy
            ' ''Dim diaAlumno
            ' ''Dim mesAlumno
            ' ''diaHoy = Format(Date.Now, "dd")
            ' ''diaAlumno = Format(vfecha, "dd")
            ' ''mesHoy = Format(Date.Now, "mm")
            ' ''mesAlumno = Format(vfecha, "mm")
            ' ''averiguarEdad = Format(Date.Now, "yyyy") - Format(vfecha, "yyyy")

            ' ''If mesHoy < mesAlumno Then
            ' ''    averiguarEdad = averiguarEdad - 1
            ' ''ElseIf mesHoy = mesAlumno Then
            ' ''    If diaHoy < diaAlumno Then
            ' ''        averiguarEdad = averiguarEdad - 1
            ' ''    End If
            ' ''End If
            '     
            ' averiguarEdad = Year(Now) - vfecha.Year
            averiguarEdad = 0
            If DateDiff(DateInterval.Day, vfecha, CDate(Now)) = 0 Then

                Return averiguarEdad

            End If

            Try
                ''Dim e As String = ""
                ''If (Convert.ToDateTime(vfecha).Month <= Today.Month) Then
                ''    If (Convert.ToDateTime(vfecha).Day < Today.Day) Then
                ''        e = Fix((DateDiff("m", Convert.ToDateTime(vfecha), Today)) / 12) - 1
                ''    End If
                ''Else
                ''End If
                ''If e = "" Then
                ''    averiguarEdad = Fix((DateDiff("m", Convert.ToDateTime(vfecha), Today)) / 12)
                ''End If
                averiguarEdad = DateDiff(DateInterval.Day, CDate(vfecha), CDate(Now))


                averiguarEdad = Int(averiguarEdad / 365.25)
                Return averiguarEdad

            Catch ex As Exception
                Return 0
            End Try

        End Function
        Public Function calcularPorcentaje(ByVal vPorcentaje As Double, Optional ByVal vCantidad As Double = 0) As Double
            'Dim valorp As Double
            Try


                Select Case vCantidad
                    Case 0
                        calcularPorcentaje = Math.Round((vPorcentaje / 100), 5)
                    Case Else
                        calcularPorcentaje = Math.Round(vCantidad * (vPorcentaje / 100), 5)
                End Select

                'cPorcentaje = valorp + cantidad
            Catch ex As Exception
                calcularPorcentaje = 0
                Exit Function
            End Try
        End Function
        Public Function RegistroEnLetras(ByVal registro As Double) As String
            Dim Registro2 As Long
            Dim stLetras As String
            Dim stCantidad As String
            Dim stComplemento As String
            Dim inPos As Integer
            stCantidad = Format(registro, "0.00")
            '    If stCantidad = "0.00" Then
            '        RegistroEnLetras = "Cero"
            '    Else
            inPos = InStr(1, stCantidad, ".")
            If inPos <> 0 And Right(stCantidad, 2) <> "00" Then
                stComplemento = " con " & Mid(stCantidad, inPos + 1, Len(stCantidad) - inPos) & "/100"
                stCantidad = Left(stCantidad, inPos - 1)
            Else
                stComplemento = " exactos"   '"exactos"
            End If
            registro = CDbl(stCantidad)
            stLetras = ""
            If registro > 999999 Then
                stCantidad = Left(CStr(registro), 1)
                Select Case stCantidad
                    Case "1"
                        stLetras = stLetras & "UN MILLON "
                    Case "2"
                        stLetras = stLetras & "DOS "
                    Case "3"
                        stLetras = stLetras & "TRES "
                    Case "4"
                        stLetras = stLetras & "CUATRO "
                    Case "5"
                        stLetras = stLetras & "CINCO "
                    Case "6"
                        stLetras = stLetras & "SEIS "
                    Case "7"
                        stLetras = stLetras & "SIETE "
                    Case "8"
                        stLetras = stLetras & "OCHO "
                    Case "9"
                        stLetras = stLetras & "NUEVE "
                End Select
                If stCantidad <> "1" Then
                    stLetras = stLetras & "MILLONES "
                End If
                registro = registro - Val(stCantidad) * 1000000
            End If
            Registro2 = registro
            If registro > 99999 Then
                stCantidad = Left(CStr(registro), 1)
                Select Case stCantidad
                    Case "1"
                        stLetras = stLetras & "CIENTO "
                    Case "2"
                        stLetras = stLetras & "DOSCIENTOS "
                    Case "3"
                        stLetras = stLetras & "TRESCIENTOS "
                    Case "4"
                        stLetras = stLetras & "CUATROCIENTOS "
                    Case "5"
                        stLetras = stLetras & "QUINIENTOS "
                    Case "6"
                        stLetras = stLetras & "SEISCIENTOS "
                    Case "7"
                        stLetras = stLetras & "SETECIENTOS "
                    Case "8"
                        stLetras = stLetras & "OCHOCIENTOS "
                    Case "9"
                        stLetras = stLetras & "NOVECIENTOS "
                End Select
                registro = registro - Val(stCantidad) * 100000
            End If
            If registro > 9999 And registro < 20000 Then
                stCantidad = Left(CStr(registro), 2)
                Select Case stCantidad
                    Case "10"
                        stLetras = stLetras & "DIEZ "
                    Case "11"
                        stLetras = stLetras & "ONCE "
                    Case "12"
                        stLetras = stLetras & "DOCE "
                    Case "13"
                        stLetras = stLetras & "TRECE "
                    Case "14"
                        stLetras = stLetras & "CATORCE "
                    Case "15"
                        stLetras = stLetras & "QUINCE "
                    Case "16"
                        stLetras = stLetras & "DIECISEIS "
                    Case "17"
                        stLetras = stLetras & "DIECISIETE "
                    Case "18"
                        stLetras = stLetras & "DIECIOCHO "
                    Case "19"
                        stLetras = stLetras & "DIECINUEVE "
                End Select
                registro = registro - Val(stCantidad) * 1000
            End If
            If registro > 19000 Then
                stCantidad = Left(CStr(registro), 1)
                Select Case stCantidad
                    Case "2"
                        stLetras = stLetras & "VEINTE"
                        If Mid(Str(registro), 3, 1) <> "0" Then
                            stLetras = Left(stLetras, Len(stLetras) - 1) & "I"
                        Else
                            stLetras = stLetras & " "
                        End If
                    Case "3"
                        stLetras = stLetras & "TREINTA "
                    Case "4"
                        stLetras = stLetras & "CUARENTA "
                    Case "5"
                        stLetras = stLetras & "CINCUENTA "
                    Case "6"
                        stLetras = stLetras & "SESENTA "
                    Case "7"
                        stLetras = stLetras & "SETENTA "
                    Case "8"
                        stLetras = stLetras & "OCHENTA "
                    Case "9"
                        stLetras = stLetras & "NOVENTA "
                End Select
                registro = registro - Val(stCantidad) * 10000
            End If
            If registro > 999 Then
                If Right(stLetras, 2) = "A " Then
                    stLetras = stLetras & "Y "
                End If
                stCantidad = Left(CStr(registro), 1)
                Select Case stCantidad
                    Case "1"
                        stLetras = stLetras & "UN "
                    Case "2"
                        stLetras = stLetras & "DOS "
                    Case "3"
                        stLetras = stLetras & "TRES "
                    Case "4"
                        stLetras = stLetras & "CUATRO "
                    Case "5"
                        stLetras = stLetras & "CINCO "
                    Case "6"
                        stLetras = stLetras & "SEIS "
                    Case "7"
                        stLetras = stLetras & "SIETE "
                    Case "8"
                        stLetras = stLetras & "OCHO "
                    Case "9"
                        stLetras = stLetras & "NUEVE "
                End Select
                registro = registro - Val(stCantidad) * 1000
            End If
            If Registro2 > 999 Then
                If stLetras = "CIENTO " Then stLetras = "CIEN "
                stLetras = stLetras & "MIL "
            End If
            If registro > 99 Then
                stCantidad = Left(CStr(registro), 1)
                Select Case stCantidad
                    Case "1"
                        If registro = 100 Then
                            stLetras = stLetras & "CIEN "
                        Else
                            stLetras = stLetras & "CIENTO "
                        End If
                    Case "2"
                        stLetras = stLetras & "DOSCIENTOS "
                    Case "3"
                        stLetras = stLetras & "TRESCIENTOS "
                    Case "4"
                        stLetras = stLetras & "CUATROCIENTOS "
                    Case "5"
                        stLetras = stLetras & "QUINIENTOS "
                    Case "6"
                        stLetras = stLetras & "SEISCIENTOS "
                    Case "7"
                        stLetras = stLetras & "SETECIENTOS "
                    Case "8"
                        stLetras = stLetras & "OCHOCIENTOS "
                    Case "9"
                        stLetras = stLetras & "NOVECIENTOS "
                End Select
                registro = registro - Val(stCantidad) * 100
            End If
            If registro > 9 And registro < 20 Then
                stCantidad = Left(CStr(registro), 2)
                Select Case stCantidad
                    Case "10"
                        stLetras = stLetras & "DIEZ "
                    Case "11"
                        stLetras = stLetras & "ONCE "
                    Case "12"
                        stLetras = stLetras & "DOCE "
                    Case "13"
                        stLetras = stLetras & "TRECE "
                    Case "14"
                        stLetras = stLetras & "CATORCE "
                    Case "15"
                        stLetras = stLetras & "QUINCE "
                    Case "16"
                        stLetras = stLetras & "DIECISEIS "
                    Case "17"
                        stLetras = stLetras & "DIECISIETE "
                    Case "18"
                        stLetras = stLetras & "DIECIOCHO "
                    Case "19"
                        stLetras = stLetras & "DIECINUEVE "
                End Select
                registro = registro - Val(stCantidad)
            End If
            If registro > 19 Then
                stCantidad = Left(CStr(registro), 1)
                Select Case stCantidad
                    Case "2"
                        stLetras = stLetras & "VEINTE"
                        If Mid(CStr(registro), 2, 1) <> "0" Then
                            stLetras = Left(stLetras, Len(stLetras) - 1) & "I"
                        Else
                            stLetras = stLetras & " "
                        End If
                    Case "3"
                        stLetras = stLetras & "TREINTA "
                    Case "4"
                        stLetras = stLetras & "CUARENTA "
                    Case "5"
                        stLetras = stLetras & "CINCUENTA "
                    Case "6"
                        stLetras = stLetras & "SESENTA "
                    Case "7"
                        stLetras = stLetras & "SETENTA "
                    Case "8"
                        stLetras = stLetras & "OCHENTA "
                    Case "9"
                        stLetras = stLetras & "NOVENTA "
                End Select
                registro = registro - Val(stCantidad) * 10
            End If
            If registro > 0 Then
                If Right(stLetras, 2) = "A " Then
                    stLetras = stLetras & "Y "
                End If
                stCantidad = Left(CStr(registro), 1)
                Select Case stCantidad
                    Case "1"
                        stLetras = stLetras & "UNO "
                    Case "2"
                        stLetras = stLetras & "DOS "
                    Case "3"
                        stLetras = stLetras & "TRES "
                    Case "4"
                        stLetras = stLetras & "CUATRO "
                    Case "5"
                        stLetras = stLetras & "CINCO "
                    Case "6"
                        stLetras = stLetras & "SEIS "
                    Case "7"
                        stLetras = stLetras & "SIETE "
                    Case "8"
                        stLetras = stLetras & "OCHO "
                    Case "9"
                        stLetras = stLetras & "NUEVE "
                End Select
                registro = registro - Val(stCantidad)
            End If
            RegistroEnLetras = RTrim(LCase(stLetras)) & stComplemento

        End Function
        Public Function PropiedadesDiscoDuro(ByVal vTipo As Integer) As String
            Dim vResul As String = ""
            Try
                Select Case vTipo
                    Case 1
                        Dim disco1 As New System.Management.ManagementObject("Win32_DiskDrive='\\.\PHYSICALDRIVE0'")
                        vResul = disco1.Properties("Model").Value.ToString
                    Case 2
                        'Dim disco As New System.Management.ManagementObject("Win32_LogicalDisk.DeviceId='C:'")
                        'vResul = disco("VolumeSerialNumber")
                        Dim disco As New System.Management.ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
                        vResul = disco.Properties("SerialNumber").Value.ToString()
                        'Dim query As New ManagementObjectSearcher("Win32_DiskDrive='\\.\PHYSICALDRIVE0'")
                        'For Each wmiDrive As ManagementObject In query.Get()
                        '    If wmiDrive("SerialNumber") Is Nothing Then
                        '        vResul = ""
                        '    Else
                        '        vResul = wmiDrive("SerialNumber").ToString()
                        '    End If
                        '    Exit For
                        'Next


                End Select

                Return vResul


                'MessageBox.Show(disco1.Properties("Model").Value.ToString & " " & disco.Properties("SerialNumber").Value.ToString, _
                '    "Número de Serie", _
                '    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'MessageBox.Show(ex.Message)
                Return ""
            End Try
        End Function
        Public Sub mostarWait(ByVal formu1 As Form, Optional ByVal vDesc As String = "", Optional ByVal vCap As String = "", Optional ByVal cerrar As Integer = 0)
            Try


                'splashPersonal = New splashPersonal.ShowForm(formu1, GetType(WaitForm1), True, True, False)
                'algo = New SplashScreenManager(formu1, GetType(WaitForm1), True, True, False)
                If cerrar = 1 Then
                    'SplashScreenManager.Default.CloseWaitForm()

                    If SplashScreenManager.Default IsNot Nothing Then
                        If SplashScreenManager.Default.IsSplashFormVisible Then SplashScreenManager.CloseForm(False)

                    End If
                    'SplashScreenManager.Default.Dispose()
                    Return
                End If

                If SplashScreenManager.Default Is Nothing Then SplashScreenManager.ShowForm(formu1, GetType(WaitForm1), True, True, False)
                
                If SplashScreenManager.Default.IsSplashFormVisible Then

                    SplashScreenManager.Default.SetWaitFormDescription(vDesc)
                    SplashScreenManager.Default.SetWaitFormCaption(vCap)
                    ' SplashScreenManager.Default.ShowWaitForm()
                    'SplashScreenManager.Default.CloseWaitForm()

                End If
            Catch ex As Exception
               

                    If SplashScreenManager.Default IsNot Nothing Then SplashScreenManager.CloseForm(False)


            End Try
        End Sub
    End Module
   
End Namespace

Public Class valoresBusquedaRProducto
    Private codigoProducto As String
    Public Property codigoBarras() As String
        Get
            Return codigoProducto
        End Get
        Set(ByVal value As String)
            codigoProducto = value
        End Set
    End Property
    Public Class busquedaRapidaproducto
        Inherits valoresBusquedaRProducto
    End Class
End Class
Public Class ColorPopup
    Private tabControl As XtraTabControl
    Private fResultColor As Color
    Private itemFontColor As BarItem
    Private container As PopupControlContainer
    Private rtPad As RichTextBox
    Public Sub New(ByVal container As PopupControlContainer, ByVal item As BarItem, ByVal rtPad As RichTextBox)
        Me.rtPad = rtPad
        Me.container = container
        Me.itemFontColor = item
        Me.fResultColor = Color.Empty
        Me.tabControl = CreateTabControl()
        Me.tabControl.TabStop = False
        Me.tabControl.TabPages.AddRange(New XtraTabPage() {New XtraTabPage(), New XtraTabPage(), New XtraTabPage()})
        Dim i As Integer = 0
        Do While i < tabControl.TabPages.Count
            SetTabPageProperties(i)
            i += 1
        Loop
        tabControl.Dock = DockStyle.Fill
        Me.container.Controls.AddRange(New System.Windows.Forms.Control() {tabControl})
        Me.container.Size = CalcFormSize()
    End Sub
    Private Function CreateTabControl() As XtraTabControl
        Return New XtraTabControl()
    End Function
    Private Function CreateColorListBox() As ColorListBox
        Return New ColorListBox()
    End Function
    Private Sub SetTabPageProperties(ByVal pageIndex As Integer)
        Dim tabPage As XtraTabPage = Me.tabControl.TabPages(pageIndex)
        Dim colorBox As ColorListBox = Nothing
        Dim control As BaseControl = Nothing
        Select Case pageIndex
            Case 0
                tabPage.Text = Localizer.Active.GetLocalizedString(StringId.ColorTabCustom)
                control = New ColorCellsControl(Nothing)
                Dim rItem As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
                rItem.ShowColorDialog = False
                CType(IIf(TypeOf control Is ColorCellsControl, control, Nothing), ColorCellsControl).Properties = rItem
                AddHandler CType(IIf(TypeOf control Is ColorCellsControl, control, Nothing), ColorCellsControl).EnterColor, AddressOf OnEnterColor
                control.Size = ColorCellsControlViewInfo.BestSize
            Case 1
                tabPage.Text = Localizer.Active.GetLocalizedString(StringId.ColorTabWeb)
                colorBox = CreateColorListBox()
                colorBox.Items.AddRange(ColorListBoxViewInfo.WebColors)
                AddHandler colorBox.EnterColor, AddressOf OnEnterColor
                control = colorBox
            Case 2
                tabPage.Text = Localizer.Active.GetLocalizedString(StringId.ColorTabSystem)
                colorBox = CreateColorListBox()
                colorBox.Items.AddRange(ColorListBoxViewInfo.SystemColors)
                AddHandler colorBox.EnterColor, AddressOf OnEnterColor
                control = colorBox
        End Select
        control.Dock = DockStyle.Fill
        control.BorderStyle = BorderStyles.NoBorder
        control.LookAndFeel.ParentLookAndFeel = itemFontColor.Manager.GetController().LookAndFeel
        tabPage.Controls.Add(control)
    End Sub
    Private Sub OnEnterColor(ByVal sender As Object, ByVal e As EnterColorEventArgs)
        fResultColor = e.Color
        OnEnterColor(e.Color)
    End Sub
    Private Sub OnEnterColor(ByVal clr As Color)
        container.HidePopup()
        rtPad.SelectionColor = clr
        Dim imIndex As Integer = itemFontColor.ImageIndex
        Dim iml As ImageList = TryCast(itemFontColor.Images, ImageList)
        Dim im As Bitmap = CType(iml.Images(imIndex), Bitmap)
        Dim g As Graphics = Graphics.FromImage(im)
        Dim r As Rectangle = New Rectangle(7, 7, 8, 8)
        g.FillRectangle(New SolidBrush(clr), r)
        If imIndex = iml.Images.Count - 1 Then
            iml.Images.RemoveAt(imIndex)
        End If
        g.Dispose()
        iml.Images.Add(im)
        itemFontColor.ImageIndex = iml.Images.Count - 1

    End Sub
    Private ReadOnly Property CellsControl() As ColorCellsControl
        Get
            Return (CType(tabControl.TabPages(0).Controls(0), ColorCellsControl))
        End Get
    End Property
    Private ReadOnly Property CustomColorsName() As String
        Get
            Return "CustomColors"
        End Get
    End Property
    Public ReadOnly Property ResultColor() As Color
        Get
            Return fResultColor
        End Get
    End Property

    Public Function CalcFormSize() As Size
        Dim size As Size = ColorCellsControlViewInfo.BestSize
        size.Height = 113
        Return tabControl.CalcSizeByPageClient(size)
    End Function
   
End Class

''//Le daremos un nombre al archivo y tambien le expecificamos en que directorio se creara
'Dim nombrefile As String = vDireccionDocumentos & "\mapasrutas\" & Hour(Date.Now) & Minute(Date.Now) & ".kml"
'            If File.Exists(nombrefile) Then Kill(nombrefile)

''string nombrefile="Temp/jocamusgeo"+DateTime.Now.Ticks.ToString()+".kml";


''//Definimos el archivo XML
'Dim writer As XmlTextWriter = New XmlTextWriter(nombrefile, System.Text.Encoding.UTF8)
''XmlTextWriter writer = new 
''XmlTextWriter(Server.MapPath(nombrefile), Encoding.UTF8);

''// Empezamos a escribir
'            writer.WriteStartDocument() '01-ABRE
'            writer.WriteStartElement("kml") '02-ABRE
'            writer.WriteAttributeString("xmlns", "http://earth.google.com/kml/2.0")
'            writer.WriteStartElement("Folder") '03-ABRE
'            writer.WriteStartElement("description", "ORDEN200") '04-abre
''//Descripcion del Conjunto de Datos,puede ser texto o HTML
''writer.WriteCData("Algunos paises de America delSur>")
'            writer.WriteEndElement() '04-CIERRA
''writer.WriteElementString("name", "Paises")
''writer.WriteElementString("visibility", "0")
''writer.WriteElementString("open", "1")
''writer.WriteStartElement("Folder")

''//Obtenemos los datos donde estan las coordenadas
''DataSet ds= dsDatos();
''//Recorremos el DataSet
''for(int i=0;i<ds.Tables[0].Rows.Count;i++)
''{
''//Obtenemos los valores de Latitud y Longitud
'Dim slong As String = "-91.5270482"
'Dim slat As String = "14.8681701"
''string slong=ds.Tables[0].Rows[i]["Longitud"].ToString();
''string slat=ds.Tables[0].Rows[i]["Latitud"].ToString();
'            writer.WriteStartElement("Placemark") '05-ABRE
'            writer.WriteStartElement("description") '06-ABRE
'            writer.WriteCData("Aqui puede ir cualquier tipo de texto descriptivo de acuerdo al registro correspondiente")
'            writer.WriteEndElement() '06-CIERRA
''//Asignamos el nombre del registro o coordenada obteniendo el valor del campo Nombre
'            writer.WriteElementString("name", "prueba") 'ds.Tables[0].Rows[i]["Nombre"].ToString());
''writer.WriteElementString("visibility", "1")
'            writer.WriteStartElement("Style") '07-ABRE
'            writer.WriteStartElement("IconStyle") '08-ABRE
'            writer.WriteStartElement("Icon") '09-ABRE
''//Ruta del icono para ver las coordenadas
''//Debe ser pequeña de 32x32.
'            writer.WriteElementString("href", "map_sign_start.png")
''writer.WriteElementString("w", "32")
''writer.WriteElementString("h", "32")
''writer.WriteElementString("x", "64")
''writer.WriteElementString("y", "96")
'            writer.WriteEndElement() '09-CIERRA
'            writer.WriteEndElement() '08-CIERRA
'            writer.WriteEndElement() '07-CIERRA
''writer.WriteStartElement("LookAt")
''writer.WriteElementString("longitude", slong)
''writer.WriteElementString("latitude", slat)
''writer.WriteElementString("range", "3000")
''writer.WriteElementString("tilt", "60")
''writer.WriteElementString("heading", "0")
''writer.WriteEndElement()
'            writer.WriteStartElement("Point") '10-ABRE
''writer.WriteElementString("extrude", "1")
''writer.WriteElementString("altitudeMode", "relativeToGround")
'            writer.WriteElementString("coordinates", slong + "," + slat + ",50")
'            writer.WriteEndElement() '10-CIERRA
'            writer.WriteEndElement() '03-CIERRA
''} fin del for
'            writer.WriteEndElement() '02-CIERRA
''writer.WriteEndElement()
''writer.WriteEndElement()
'            writer.WriteEndDocument() '01-CIERRA
'            writer.Close()