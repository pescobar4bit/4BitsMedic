Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System
Imports System.Reflection
Imports System.Security
Imports System.Security.AccessControl
Imports System.IO
Imports DevExpress.XtraEditors
Imports System.Xml
Imports System.Text
Imports System.ComponentModel
Imports namespace4BITS.nsFuncionesVINNS


#Region "Structuras del sistema"
Structure datosConfiguracionMes
    Public descripcion As String
    Public fecha As Date
    Public mes As String
    Public diasefectivos As Decimal
    Public tipo As Integer
    Public idConfiguracionMes As Integer
    Public idCasa As Integer
    'Public fardos As Boolean
End Structure
Structure datosRotacion
    Public fecha1 As Date
    Public fecha2 As Date
End Structure
Structure datosSellOut
    Public anulada As Boolean
    Public credito As Boolean
    Public pagadas As Boolean
    Public transito As Boolean
    Public fechapedido As Boolean
    'Public fechasistema As Boolean
    Public fechai As Date
    Public fechaf As Date
End Structure
Structure datosReportes
    Public fechaInicio As Date
    Public fechaFin As Date
    Public vOpcion1 As Integer
    Public vOpcion2 As Integer
    Public vDato1 As String
    Public vDato2 As String
End Structure
Structure datosUsuario
    Public idUsuario As Integer
    Public tipo As Integer
    Public foto As DevExpress.XtraEditors.PictureEdit
    Public nombre As String
    Public usuario As String
    Public clave As String
    Public habilitado As Boolean
    Public idGrupo As Integer
End Structure
Structure datosChequesClientes
    Public nombrecuenta As String
    Public numero As String
    Public idBanco As String
    Public foto As DevExpress.XtraEditors.PictureEdit
    Public idDetalleFacturaCorteOrdenEntrega As Integer
    Public fechacobrocheque As Date
    Public total As Decimal
End Structure
Structure datosActualizarInventario
    Public fecha As Date
    Public motivo As String
    Public existenciareal As Boolean
End Structure
Structure datosCorteOrdenesEntrega
    Public fecha As Date
    Public idOrdenEntrega As Integer
    Public efectivo As Decimal
    Public cheques As Decimal
    Public credito As Decimal
    Public anuladas As Decimal
    Public faltante As Decimal
    Public gastos As Decimal
    Public idEmpleado As Integer
    Public vales As Decimal
    Public usuario As String
    Public depositos As Decimal
    Public descuentos As Decimal
End Structure
Structure datosDetalleFacturasCorteOrdenesEntrega
    Public idVenta As Integer
    Public anulada As Boolean
    Public pagadaefectivo As Boolean
    Public cheque As Boolean
    Public credito As Boolean
    Public nopagada As Boolean
    Public idCorteOrdenesEntrega As Integer
    Public abono As Decimal
    Public numfacturacambiaria As String
End Structure
Structure datosPedido
    Public fechaentrega As Date
    Public observaciones As String
    Public idEmpleado As Integer
    Public idtienda As Integer
    Public tipo As Integer
    Public idpedido As Integer
    Public total As Decimal
    Public nuevopedido As Boolean
    Public fechainicial As Date
    Public idPedidoDev As Integer
    Public autorizacion As Boolean
End Structure
Structure datoDetallePedido
    Public cantidad
    Public existenciatienda As Integer
    Public idproducto As Integer
    Public idpedido As Integer
    'Public preciocosto As Decimal
    'Public precioventa As Decimal
    Public presentacion As String
    Public precio As Decimal
    Public promocion As Boolean
    'Public existencia2 As Integer
    Public facturar As Boolean
    Public montodescuento As Decimal
    Public idProveedor As Integer
    Public motivo As String
End Structure
Structure datosPromocion
    Public codigo As String
    Public fechainicio As Date
    Public fechafinal As Date
    Public descripcion As String
    Public descripcionfac As String
    Public cantidad As Integer
    Public idProducto As Integer
    Public operador As String
    Public cantidad2 As Integer
    Public operador2 As String
    Public precioventa As String
    Public presentacion As String
    Public habilitada As Boolean
    Public idPromocion As Integer
    Public tipo As Integer
End Structure
Structure datosTienda
    Public tienda As String
    Public codigo As String
    Public direccion As String
    Public telefono As String
    Public cliente As String
    Public nit As String
    Public idruta As Integer
    Public latitud As String
    Public longitud As String
    Public distancia As String
    Public direccionf As String
    Public idtienda As Integer
    Public tipo As Integer
    Public idPropietario As Integer
    Public telefononoti As String
    Public correo As String
    Public notitele As Boolean
    Public noticorreo As Boolean
    Public idDepartamento As Integer
    Public idMunicipio As Integer
    Public codigointerno As Integer
    Public limitecredito As Decimal
End Structure
Structure datosInsertarInstruccion
    Public instruccion As String
End Structure
Structure datosBodega
    Public idbodega As Integer
    Public bodega As String
    Public direccion As String
    Public departamento As String
    Public telefono As String
    Public latitud As String
    Public longitud As String
    Public tipo As Integer
    Public habilitada As Boolean
End Structure
Structure datosProductos
    'Public idbodega As Integer
    Public descripcion As String
    Public descripcion2 As String
    Public codigo As String
    Public codigo2 As String
    Public codigo3 As String
    Public idsubcategoria As Integer
    Public foto As DevExpress.XtraEditors.PictureEdit
    Public preciocosto As Decimal
    Public precioventa As Decimal
    Public unidadxfardo As Integer
    Public unidadxpaquete As Integer

    'Public existencia As Integer
    'Public existencia2 As Integer
    Public idproducto As Integer
    Public fechavencimiento As Date
    Public fechavencimientosi As Boolean
    Public tipo As Integer
    Public venta As Boolean
    Public fardo As Boolean
    Public paquete As Boolean
    Public unidad As Boolean
    Public pesoneto As Decimal
    Public pesobruto As Decimal
    Public decimetroc As Decimal
    Public idCasa As Integer
    Public idSegmento As Integer
End Structure
Structure datosPreferencia
    Public apiMapa As String
End Structure
Structure datosConexion
    Public vidBodega As String
    Public vUsuariobdd As String
    Public vPasswordbdd As String
    Public vServidor As String
    Public vDescripcion As String
    Public vBdd As String
    Public vidSerie As String
    Public vActivacion As String
    Public vFechaServidor As Date
End Structure
Structure datosCompras
    Public fecha As Date
    Public tipodocumento As String
    Public numerodoc As String
    Public total As Decimal
    Public idproveedor As Integer
    Public formapago As String
    Public dias As Integer
    Public tipo As Integer
    Public idcompra As Integer
    Public bonifiacion As Decimal
    Public observaciones As String
    Public foto As DevExpress.XtraEditors.PictureEdit
End Structure
Structure datosDetalleCompras
    Public cantidad As Integer
    Public subtotal As Decimal
    Public idproducto As Integer
    Public idcompra As Integer
    Public preciocosto As Decimal
    Public precioventa As Decimal
    Public preciocostof As Decimal
    Public precioventaf As Decimal
    Public tipo2 As String
    Public tipo As Integer
    Public descuento As Decimal
    Public bonificacion As Boolean
End Structure
Structure datosVehiculos
    Public marca As String
    Public tipo As String
    Public placa As String
    Public modelo As Integer
    Public cilindros As Integer
    Public puertas As Integer
    Public peso As Decimal
    Public nit As String
    Public nombre As String
    Public fecha As Date
    Public chasis As String
    Public motor As String
    Public kilometrajeinicial As Decimal
    Public codigo As String
    Public foto As DevExpress.XtraEditors.PictureEdit
    Public centimetrosc As Integer
    Public linea As String
    Public vin As String
    Public color As String
    Public combustible As String
    Public habilitado As Boolean
    Public volumen As Decimal
    Public tipomante As Integer
    Public idvehiculo As Integer
End Structure
Structure datosOrdenesEntrega
    Public idVehiculo As Integer
    Public idEmpleado As Integer
    Public fecha As Date
    Public kilometrajeinicial As Integer
    Public total As Decimal
End Structure
#End Region
Module mdlPrincipal
    Public configuracionReportes As datosReportes
    Public Const ENCRYPT = 1, DECRYPT = 2
    Public Cn As SqlConnection
    Dim cmNuevo As New SqlCommand
    Public vHayerror As Boolean = False
    Dim cmComand As SqlCommand
    Dim Trans As SqlTransaction
    Public vCADENAINSTRUCCION As String = ""
    Public vConexion As datosConexion
    Public vConexionPrincipal As datosConexion
    Public vPreferencias As datosPreferencia
    Public vDireccionDocumentos As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\Vinns\CuentasI"
    Public vDireccionHistorialTienda As String = "http://sistemasvinns.com/sitioflmovil/tiendas.aspx?idbodega="
    Public vTamanioM As Decimal = 100000
    Public WithEvents bwProcesoInicial As New BackgroundWorker
    Public WithEvents bwProcesoInicialTiendas As New BackgroundWorker
    Public WithEvents bwProcesoInicialFacturasCredito As New BackgroundWorker
    Public myXmlTextWriterCopia As XmlTextWriter






    Private Sub bwProcesoInicial_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwProcesoInicial.DoWork
        Dim Cn2 As SqlConnection
        Dim tmpNbdd As String = vConexion.vBdd
        Dim tmpSvbdd As String = vConexion.vServidor
        Dim tmpPsbdd = vConexion.vPasswordbdd
        Dim tmpUsbdd = vConexion.vUsuariobdd
        Dim cmComand As SqlCommand
        Cn2 = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA

        Try
            Cn2.Open()
            Dim daSelUno As New SqlDataAdapter
            Dim dsSelUno As New DataSet
            Dim pmPat As New SqlParameter("@para1", SqlDbType.NVarChar, 200)
            Dim pmPat2 As New SqlParameter("@para2", SqlDbType.NVarChar, 200)
            Dim pmPat3 As New SqlParameter("@para3", SqlDbType.NVarChar, 200)


            cmComand = New SqlCommand("paBProductos2", Cn2)
            cmComand.CommandType = CommandType.StoredProcedure
            cmComand.Parameters.Add(pmPat)
            cmComand.Parameters("@para1").Direction = ParameterDirection.Input
            cmComand.Parameters("@para1").Value = "2"
            cmComand.Parameters.Add(pmPat2)
            cmComand.Parameters("@para2").Direction = ParameterDirection.Input
            cmComand.Parameters("@para2").Value = vConexion.vidBodega
            cmComand.Parameters.Add(pmPat3)
            cmComand.Parameters("@para3").Direction = ParameterDirection.Input
            cmComand.Parameters("@para3").Value = "0"

            daSelUno.SelectCommand = cmComand
            daSelUno.Fill(dsSelUno, "Datos")
            DTProductos = Nothing
            DTProductos = dsSelUno.Tables(0)

            e.Result = "1"
            Cn2.Close()
            Cn2.Dispose()
            Cn2 = Nothing
        Catch ex As SqlException
            XtraMessageBox.Show("Número de error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Result = "0"
        End Try
    End Sub
    Public Sub AbrirConexion(Optional ByVal tipoC As Integer = 2, Optional ByVal vnServidor As String = "", Optional ByVal vUsuario As String = "", Optional ByVal vNBDD As String = "", Optional ByVal vConstrasenia As String = "")
        '  On Error GoTo MensajeC
        vHayerror = False
        Select Case tipoC
            Case 1
                Cn = New SqlConnection("Data Source=" & vnServidor & ";Initial Catalog=" & vNBDD & ";Integrated Security=true;user ID=" & vUsuario & ";password=" & vConstrasenia)
            Case Else


                Dim tmpNbdd As String = vConexion.vBdd 'conexionAct.vBdd
                Dim tmpSvbdd As String = vConexion.vServidor 'conexionAct.vServidor
                Dim tmpPsbdd = vConexion.vPasswordbdd
                Dim tmpUsbdd = vConexion.vUsuariobdd

                If tmpSvbdd = Nothing Then ' arreglar bien**************
                    tmpNbdd = "misaSQL"
                    tmpSvbdd = "localhost"
                    tmpPsbdd = "abeja"
                    tmpUsbdd = "sa"
                End If
                Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
                'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
                'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA
        End Select
        Try
            Cn.Open()
        Catch ex As SqlException
            MsgBox(ex.ErrorCode & " " & ex.Message)
            vHayerror = True

        End Try

        'MensajeC:
        '        If Err.Number <> 0 Then
        '            MsgBox("Error en conexion" & vbCrLf & Err.Description & " " & Err.Number, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "VINNS")
        '            Err.Number = 0
        '            Exit Sub
        '        End If
    End Sub

    Public Sub CerrarConexion()
        Cn.Close()
        Cn.Dispose()
        Cn = Nothing
    End Sub

    Public Function ObtenerDato(ByVal vTabla As String, ByVal vCampo As String, ByVal vCond As String) As String
        On Error GoTo MensajeC
        Err.Number = 0
        'Esta funcion obtiene un unico dato de una tabla devuelto en forma de string id,nombre,etc
        AbrirConexion()
        Dim cmObtenerdato As SqlCommand
        If vCond = "" And vCampo = "" Then
            cmObtenerdato = New SqlCommand("Select " & vTabla, Cn)
        Else
            cmObtenerdato = New SqlCommand("Select " & vCampo & " from " & vTabla & " where " & vCond.Trim & " ", Cn)
        End If

        Dim vVal As String
        cmObtenerdato.CommandType = CommandType.Text
        If Not IsDBNull(cmObtenerdato.ExecuteScalar) Then
            vVal = cmObtenerdato.ExecuteScalar()
        Else
            vVal = ""
        End If

        CerrarConexion()
        If vVal Is Nothing Then vVal = ""
        Return vVal

MensajeC:
        If Err.Number <> 0 Then
            If MsgBox("DESCRIPCION DE ERROR" & vbCrLf & Err.Description & vbCrLf & "ERROR NUMERO: " & Err.Number & vbCrLf & "¿Desea reintentar el proceso?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "VINNS") = MsgBoxResult.Yes Then
                Err.Number = 0
                Resume
            Else
                Err.Number = 0
                Resume Next
            End If


        End If

    End Function
    Public Sub leerXML(Optional ByVal vDireccion As String = "")
        Dim m_xmlr As XmlTextReader
        Dim mNombre As String = ""
        'Creamos el XML Reader
        Dim vArchivo As String = Nothing
        'Application.StartupPath & vDireccion
        If vDireccion = "" Then
            vDireccion = vDireccionDocumentos & "\config_server.xml"
        Else
            vArchivo = vDireccion & "\config_server.xml"
        End If
        If File.Exists(vArchivo) Then
            m_xmlr = New XmlTextReader(vArchivo)
            'Desabilitamos las lineas en blanco,
            'ya no las necesitamos
            m_xmlr.WhitespaceHandling = WhitespaceHandling.None
            'Leemos el archivo y avanzamos al tag de usuarios
            m_xmlr.Read()
            'Leemos el tag usuarios
            m_xmlr.Read()
            'Creamos la secuancia que nos permite
            'leer el archivo
            While Not m_xmlr.EOF
                'Avanzamos al siguiente tag
                m_xmlr.Read()
                'si no tenemos el elemento inicial
                'debemos salir del ciclo
                If Not m_xmlr.IsStartElement() Then
                    Exit While
                End If
                'Obtenemos el elemento codigo
                Dim mCodigo = m_xmlr.GetAttribute("conexionbdd")
                'Read elements firstname and lastname
                m_xmlr.Read()
                'Obtenemos el elemento del Nombre del Usuario
                m_xmlr.Read()
                vConexion.vServidor = m_xmlr.ReadElementString("source")
                vConexion.vBdd = m_xmlr.ReadElementString("bdd")
                vConexion.vUsuariobdd = m_xmlr.ReadElementString("usuario")
                vConexion.vPasswordbdd = EncryptString(m_xmlr.ReadElementString("clave"), "EJCGVINNS", DECRYPT)
                vConexion.vidBodega = m_xmlr.ReadElementString("idEmpresa")
                vConexion.vActivacion = m_xmlr.ReadElementString("numAct")
                'vConexion.vtmpServidor = vConexion.vServidor

            End While
            m_xmlr.Close()


        End If

    End Sub


    Public Function SelectScalar(ByVal vSel As String) As Integer 'Devuelve un unico valor sum,count, etc.
        AbrirConexion()
        cmComand = New SqlCommand(vSel, Cn)
        Dim vVal As String
        cmComand.CommandType = CommandType.Text
        vVal = cmComand.ExecuteScalar()
        CerrarConexion()
        Return vVal
    End Function

    Public Sub INSERTAR(ByVal vSel As String)
        'Esta funcion ejecuta un comando insert, update, delete, etc
        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSel, Cn)
        cmComand.CommandType = CommandType.Text
        cmComand.ExecuteNonQuery()
        CerrarConexion()
    End Sub
    Public Function buscarDatosDS(ByRef vTabla As DataTable, ByRef vBusqueda As String) As Boolean
        Dim vDRTmpo As DataRow()

        vDRTmpo = vTabla.Select(vBusqueda)
        If vDRTmpo.GetUpperBound(0) >= 0 Then

            Return True
        Else
            Return False
        End If

    End Function
    Public Function cargarTabla(ByVal vTabla As String, ByVal vCampos As String, ByRef vDataSet As DataSet) As DataSet
        AbrirConexion()
        Dim daUDatos As New SqlDataAdapter("Select " & vCampos & " from " & vTabla, Cn)
        daUDatos.Fill(vDataSet, vTabla)
        CerrarConexion()
        Return vDataSet

    End Function
    Public Function OBTENERTABLA(ByVal vSql As String) As DataTable
        Dim DTTmpo As DataSet
        DTTmpo = New DataSet
        Dim daVista As New SqlDataAdapter

        AbrirConexion()
        cmComand = New SqlCommand(vSql, Cn)
        cmComand.CommandType = CommandType.Text

        daVista.SelectCommand = cmComand
        daVista.Fill(DTTmpo)
        CerrarConexion()
        Return DTTmpo.Tables(0)
    End Function
    Public Function INICIARTRANSACCION(ByVal vDatos As datosInsertarInstruccion) As datosInsertarInstruccion
        'AbrirConexion()
        'If vHayerror Then Exit Sub
        'Trans = Cn.BeginTransaction(IsolationLevel.Serializable)
        'cmNuevo.Transaction = Trans
        vDatos = Nothing
        Return vDatos
    End Function
    Public Function AGREGARTRAN(ByVal vDatos As datosInsertarInstruccion, ByVal sp As String) As datosInsertarInstruccion
        'If vHayerror Then Exit Sub
        'cmNuevo.CommandText = sp
        'cmNuevo.Connection = Cn
        'cmNuevo.CommandType = CommandType.Text
        'cmNuevo.ExecuteNonQuery()
        vDatos.instruccion = vDatos.instruccion & sp & vbCrLf
        Return vDatos
    End Function
    Public Function TERMINARBIENTRAN(ByVal vDatos As datosInsertarInstruccion, ByVal vSp As String) As String
        'If vHayerror Then Exit Sub
        'Trans.Commit()
        'CerrarConexion()
        If vDatos.instruccion IsNot Nothing Then
            Dim pmPat1 = New SqlParameter("@instruccion", SqlDbType.NVarChar)

            AbrirConexion()
            If vHayerror Then Return ""
            cmComand = New SqlCommand(vSp, Cn)
            cmComand.CommandType = CommandType.StoredProcedure
            cmComand.Parameters.Add(pmPat1)
            cmComand.Parameters("@instruccion").Direction = ParameterDirection.Input
            cmComand.Parameters("@instruccion").Value = vDatos.instruccion

            Dim returnVal As Object
            returnVal = cmComand.ExecuteScalar
            ''daSelUno.SelectCommand = cmComand
            ''daSelUno.Fill(dsSelUno, "Datos")
            CerrarConexion()
            Return returnVal
        Else
            Return "NADA"
        End If
    End Function
    Public Sub TERMINARMALTRAN()

        'Trans.Rollback()
        'CerrarConexion()
        vCADENAINSTRUCCION = ""
    End Sub
    Public Function EjecutarProcedimientoP(ByVal vPar1 As String, ByVal vPar2 As String, ByVal vPar3 As String, ByVal vSp As String, Optional ByVal vPar4 As String = "") As DataTable
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim daSelUno As New SqlDataAdapter
        Dim dsSelUno As New DataSet
        Dim pmPat As New SqlParameter("@para1", SqlDbType.NVarChar, 200)
        Dim pmPat2 As New SqlParameter("@para2", SqlDbType.NVarChar, 200)
        Dim pmPat3 As New SqlParameter("@para3", SqlDbType.NVarChar, 200)
        Dim pmPat4 As New SqlParameter("@para4", SqlDbType.NVarChar, 200)
        AbrirConexion()
        If vHayerror Then Return Nothing
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat)
        cmComand.Parameters("@para1").Direction = ParameterDirection.Input
        cmComand.Parameters("@para1").Value = vPar1
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@para2").Direction = ParameterDirection.Input
        cmComand.Parameters("@para2").Value = vPar2
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@para3").Direction = ParameterDirection.Input
        cmComand.Parameters("@para3").Value = vPar3
        If vPar4 <> "" Then
            cmComand.Parameters.Add(pmPat4)
            cmComand.Parameters("@para4").Direction = ParameterDirection.Input
            cmComand.Parameters("@para4").Value = vPar4
        End If

        daSelUno.SelectCommand = cmComand
        daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        'Aqui me kede
        Return dsSelUno.Tables(0)
    End Function
    Public Function EjecutarVista(ByVal vVista As String) As DataSet
        'Esta función la uso para ejecuar Storeprocedures pero que retornan filas sin parametros de entrada.
        'vVista es el nombre del StoreProcedure
        Dim daVista As New SqlDataAdapter
        Dim dsVista As New DataSet

        AbrirConexion()
        If Not vHayerror Then
            cmComand = New SqlCommand(vVista, Cn)
            cmComand.CommandType = CommandType.StoredProcedure

            daVista.SelectCommand = cmComand
            daVista.Fill(dsVista)
            CerrarConexion()
            'Aqui me kede
            Return dsVista
        Else
            Return Nothing
        End If


    End Function
    Public Function EjecutarSelect(ByVal vSql As String) As DataTable
        'Este ejecuta un select y lo devuelve en forma de dataset
        'los criterios del where se dan en forma de variables.
        EjecutarSelect = New DataTable
        Dim daVista As New SqlDataAdapter

        AbrirConexion()
        If Not vHayerror Then
            cmComand = New SqlCommand(vSql, Cn)
            cmComand.CommandType = CommandType.Text
            daVista.SelectCommand = cmComand
            daVista.Fill(EjecutarSelect)
            CerrarConexion()
            Return EjecutarSelect
        Else
            Return Nothing
        End If
    End Function
    Public Function EjecutarProcedimientoPDinamico(ByVal spNombre As String, ByVal ParamArray vParametros() As String) As Boolean
        'Esta funcion ejecuta Inserts, Updates, Deletes con parametros de entrada

        Dim i As Integer

        Call AbrirConexion()
        cmComand = New SqlCommand(spNombre, Cn)
        cmComand.CommandType = CommandType.StoredProcedure

        'Cargar parametros antes de ejecutar
        SqlCommandBuilder.DeriveParameters(cmComand)
        'me sirve para ir a la BD y extraer los parametros que contiene el procedimiento almacenado 
        For i = 0 To vParametros.Length - 1
            CType(cmComand.Parameters(i + 1), SqlParameter).Value = vParametros(i)
        Next

        cmComand.ExecuteNonQuery()

        cmComand.Dispose()
        cmComand = Nothing
        CerrarConexion()
        Return True
    End Function
    Public Function EjecutarProcedimientoPDinamicoConResultado(ByVal spNombre As String, ByVal ParamArray vParametros() As String) As String
        'Esta funcion ejecuta Inserts, Updates, Deletes con parametros de entrada

        Dim i As Integer

        Call AbrirConexion()
        cmComand = New SqlCommand(spNombre, Cn)
        cmComand.CommandType = CommandType.StoredProcedure

        'Cargar parametros antes de ejecutar
        SqlCommandBuilder.DeriveParameters(cmComand)
        'me sirve para ir a la BD y extraer los parametros que contiene el procedimiento almacenado 
        For i = 0 To vParametros.Length - 1
            CType(cmComand.Parameters(i + 1), SqlParameter).Value = vParametros(i)
        Next

        ''cmComand.ExecuteNonQuery()
        Dim returnVal As Object
        returnVal = cmComand.ExecuteScalar
        cmComand.Dispose()
        cmComand = Nothing
        CerrarConexion()
        Return returnVal
        '' cmComand = New SqlCommand(vSql, Cn)
        'cmComand.CommandType = CommandType.Text
        'daVista.SelectCommand = cmComand
        'daVista.Fill(EjecutarSelect)
        'CerrarConexion()
    End Function
    Public Function EjecutarProcedimientoPDinamicoConResultadoTabla(ByVal spNombre As String, ByVal ParamArray vParametros() As String) As DataTable
        'Esta funcion ejecuta Inserts, Updates, Deletes con parametros de entrada

        Dim i As Integer

        Call AbrirConexion()
        cmComand = New SqlCommand(spNombre, Cn)
        cmComand.CommandType = CommandType.StoredProcedure

        'Cargar parametros antes de ejecutar
        SqlCommandBuilder.DeriveParameters(cmComand)
        'me sirve para ir a la BD y extraer los parametros que contiene el procedimiento almacenado 
        For i = 0 To vParametros.Length - 1
            CType(cmComand.Parameters(i + 1), SqlParameter).Value = vParametros(i)
        Next

        ''cmComand.ExecuteNonQuery()
        ''EjecutarSelect = New DataTable
        Dim daSelUno As New SqlDataAdapter
        Dim vDSResultado As New DataSet
        daSelUno.SelectCommand = cmComand
        daSelUno.Fill(vDSResultado, "Datos")

        'Dim returnVal As Object
        'returnVal = cmComand.ExecuteScalar
        'cmComand.Dispose()
        'cmComand = Nothing
        CerrarConexion()
        Return vDSResultado.Tables(0)
        '' cmComand = New SqlCommand(vSql, Cn)
        'cmComand.CommandType = CommandType.Text
        'daVista.SelectCommand = cmComand
        'daVista.Fill(EjecutarSelect)
        'CerrarConexion()
    End Function
    Public Sub INSERTARPAUSUARIOS(ByRef vDatos As datosUsuario, ByVal vSp As String, Optional ByVal vOp As Integer = 0)
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@idUsuario", SqlDbType.Int)
        Dim pmPat2 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat3 = New SqlParameter("@foto", SqlDbType.Image)
        Dim pmPat4 = New SqlParameter("@nombre", SqlDbType.NVarChar, 150)
        Dim pmPat5 = New SqlParameter("@usuario", SqlDbType.NVarChar, 100)
        Dim pmPat6 = New SqlParameter("@clave", SqlDbType.NVarChar, 100)
        Dim pmPat7 = New SqlParameter("@habilitado", SqlDbType.Int)
        Dim pmPat8 = New SqlParameter("@idGrupo", SqlDbType.Int)
        'Dim pmPat9 = New SqlParameter("@tipo2", SqlDbType.NVarChar, 50)
        'Dim pmPat10 = New SqlParameter("@descuento", SqlDbType.Int)
        'Dim pmPat11 = New SqlParameter("@tipo", SqlDbType.Int)
        'Dim pmPat12 = New SqlParameter("@bonificacion", SqlDbType.Int)
        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@idUsuario").Direction = ParameterDirection.Input
        cmComand.Parameters("@idUsuario").Value = vDatos.idUsuario
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo

        ''*************foto
        Dim fsFoto As FileStream
        If File.Exists(vDireccionDocumentos & "\fotochetmpo.jpg") Then
            Kill(vDireccionDocumentos & "\fotochetmpo.jpg")
        End If
        If vDatos.foto.Image IsNot Nothing Then
            Dim vPath As String = vDireccionDocumentos & "\fotochetmpo.jpg" '"C:\VINNS\Farmalider\bin\Debug"
            vDatos.foto.Image.Save(vPath, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim fiFoto As FileInfo = New FileInfo(vPath)

            Dim Temp As Long = fiFoto.Length
            Dim lung As Long = Convert.ToInt32(Temp)
            Dim picture(lung) As Byte
            fsFoto = New FileStream(vPath, FileMode.Open)
            fsFoto.Read(picture, 0, lung)
            fsFoto.Close()
            cmComand.Parameters.Add(pmPat3)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = picture
        Else
            cmComand.Parameters.Add(pmPat3)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = DBNull.Value
        End If
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@nombre").Direction = ParameterDirection.Input
        cmComand.Parameters("@nombre").Value = vDatos.nombre
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@usuario").Direction = ParameterDirection.Input
        cmComand.Parameters("@usuario").Value = vDatos.usuario

        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@clave").Direction = ParameterDirection.Input
        cmComand.Parameters("@clave").Value = vDatos.clave
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@habilitado").Direction = ParameterDirection.Input
        cmComand.Parameters("@habilitado").Value = vDatos.habilitado.GetHashCode

        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@idGrupo").Direction = ParameterDirection.Input
        cmComand.Parameters("@idGrupo").Value = vDatos.idGrupo
        'cmComand.Parameters.Add(pmPat9)
        'cmComand.Parameters("@tipo2").Direction = ParameterDirection.Input
        'cmComand.Parameters("@tipo2").Value = vDatos.tipo2

        'cmComand.Parameters.Add(pmPat10)
        'cmComand.Parameters("@descuento").Direction = ParameterDirection.Input
        'cmComand.Parameters("@descuento").Value = vDatos.descuento
        'cmComand.Parameters.Add(pmPat11)
        'cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        'cmComand.Parameters("@tipo").Value = vDatos.tipo
        'cmComand.Parameters.Add(pmPat12)
        'cmComand.Parameters("@bonificacion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@bonificacion").Value = vDatos.bonificacion.GetHashCode
        cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()

    End Sub
    Public Sub INSERTARPADETALLECOMPRA(ByRef vDatos As datosDetalleCompras, ByVal vSp As String, Optional ByVal vOp As Integer = 0)
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@cantidad", SqlDbType.Int)
        Dim pmPat2 = New SqlParameter("@subtotal", SqlDbType.Decimal)
        Dim pmPat3 = New SqlParameter("@idproducto", SqlDbType.Int)
        Dim pmPat4 = New SqlParameter("@idcompra", SqlDbType.Int)
        Dim pmPat5 = New SqlParameter("@preciocosto", SqlDbType.Decimal)
        Dim pmPat6 = New SqlParameter("@precioventa", SqlDbType.Decimal)
        Dim pmPat7 = New SqlParameter("@preciocostof", SqlDbType.Decimal)
        Dim pmPat8 = New SqlParameter("@precioventaf", SqlDbType.Decimal)
        Dim pmPat9 = New SqlParameter("@tipo2", SqlDbType.NVarChar, 50)
        Dim pmPat10 = New SqlParameter("@descuento", SqlDbType.Int)
        Dim pmPat11 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat12 = New SqlParameter("@bonificacion", SqlDbType.Int)
        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@cantidad").Direction = ParameterDirection.Input
        cmComand.Parameters("@cantidad").Value = vDatos.cantidad
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@subtotal").Direction = ParameterDirection.Input
        cmComand.Parameters("@subtotal").Value = vDatos.subtotal

        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@idproducto").Direction = ParameterDirection.Input
        cmComand.Parameters("@idproducto").Value = vDatos.idproducto
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@idcompra").Direction = ParameterDirection.Input
        cmComand.Parameters("@idcompra").Value = vDatos.idcompra
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@preciocosto").Direction = ParameterDirection.Input
        cmComand.Parameters("@preciocosto").Value = vDatos.preciocosto

        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@precioventa").Direction = ParameterDirection.Input
        cmComand.Parameters("@precioventa").Value = vDatos.precioventa
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@preciocostof").Direction = ParameterDirection.Input
        cmComand.Parameters("@preciocostof").Value = vDatos.preciocostof

        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@precioventaf").Direction = ParameterDirection.Input
        cmComand.Parameters("@precioventaf").Value = vDatos.precioventaf
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@tipo2").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo2").Value = vDatos.tipo2

        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@descuento").Direction = ParameterDirection.Input
        cmComand.Parameters("@descuento").Value = vDatos.descuento
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@bonificacion").Direction = ParameterDirection.Input
        cmComand.Parameters("@bonificacion").Value = vDatos.bonificacion.GetHashCode
        cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()

    End Sub
    Public Function INSERTARPADETALLEFACTURASCORTEORDENESENTREGA(ByRef vDatos As datosDetalleFacturasCorteOrdenesEntrega, ByVal vSp As String, Optional ByVal vOp As Integer = 0) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@idCorteOrdenEntrega", SqlDbType.Int)
        Dim pmPat2 = New SqlParameter("@idVenta", SqlDbType.Int)
        Dim pmPat3 = New SqlParameter("@anulada", SqlDbType.Int)
        Dim pmPat4 = New SqlParameter("@credito", SqlDbType.Int)
        Dim pmPat5 = New SqlParameter("@efectivo", SqlDbType.Int)
        Dim pmPat6 = New SqlParameter("@cheque", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@nopagada", SqlDbType.Int)
        Dim pmPat8 = New SqlParameter("@abono", SqlDbType.Decimal)
        Dim pmPat9 = New SqlParameter("@numfacturacambiaria", SqlDbType.NVarChar, 50)
        'Dim pmPat8 = New SqlParameter("@gastos", SqlDbType.Decimal)
        'Dim pmPat9 = New SqlParameter("@precio", SqlDbType.Decimal)
        'Dim pmPat10 = New SqlParameter("@promocion", SqlDbType.Int)
        'Dim pmPat11 = New SqlParameter("@nuevopedido", SqlDbType.Int)
        AbrirConexion()
        If vHayerror Then Return ""
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@idCorteOrdenEntrega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idCorteOrdenEntrega").Value = vDatos.idCorteOrdenesEntrega 'Format(vDatos.fecha, "dd/MM/yyyy") & " " & Format(vDatos.fecha, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@idVenta").Direction = ParameterDirection.Input
        cmComand.Parameters("@idVenta").Value = vDatos.idVenta

        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@anulada").Direction = ParameterDirection.Input
        cmComand.Parameters("@anulada").Value = vDatos.anulada.GetHashCode
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@credito").Direction = ParameterDirection.Input
        cmComand.Parameters("@credito").Value = vDatos.credito.GetHashCode
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@efectivo").Direction = ParameterDirection.Input
        cmComand.Parameters("@efectivo").Value = vDatos.pagadaefectivo.GetHashCode

        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@cheque").Direction = ParameterDirection.Input
        cmComand.Parameters("@cheque").Value = vDatos.cheque.GetHashCode
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@nopagada").Direction = ParameterDirection.Input
        cmComand.Parameters("@nopagada").Value = vDatos.nopagada.GetHashCode

        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@abono").Direction = ParameterDirection.Input
        cmComand.Parameters("@abono").Value = vDatos.abono

        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@numfacturacambiaria").Direction = ParameterDirection.Input
        cmComand.Parameters("@numfacturacambiaria").Value = vDatos.numfacturacambiaria

        'cmComand.Parameters.Add(pmPat8)
        'cmComand.Parameters("@gastos").Direction = ParameterDirection.Input
        'cmComand.Parameters("@gastos").Value = vDatos.gastos
        'cmComand.Parameters.Add(pmPat9)
        'cmComand.Parameters("@precio").Direction = ParameterDirection.Input
        'cmComand.Parameters("@precio").Value = vDatos.precio

        'cmComand.Parameters.Add(pmPat10)
        'cmComand.Parameters("@promocion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@promocion").Value = vDatos.promocion.GetHashCode
        'cmComand.Parameters.Add(pmPat11)
        'cmComand.Parameters("@nuevopedido").Direction = ParameterDirection.Input
        'cmComand.Parameters("@nuevopedido").Value = vDatos.nuevopedido.GetHashCode
        'cmComand.ExecuteNonQuery()
        Dim returnVal As Object
        returnVal = cmComand.ExecuteScalar
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return returnVal
    End Function
    Public Function INSERTARPACORTEORDENESENTREGA(ByRef vDatos As datosCorteOrdenesEntrega, ByVal vSp As String, Optional ByVal vOp As Integer = 0) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@fecha", SqlDbType.DateTime)
        Dim pmPat2 = New SqlParameter("@idOrdenEntrega", SqlDbType.Int)
        Dim pmPat3 = New SqlParameter("@efectivo", SqlDbType.Decimal)
        Dim pmPat4 = New SqlParameter("@cheques", SqlDbType.Decimal)
        Dim pmPat5 = New SqlParameter("@credito", SqlDbType.Decimal)
        Dim pmPat6 = New SqlParameter("@anuladas", SqlDbType.Decimal)
        Dim pmPat7 = New SqlParameter("@faltante", SqlDbType.Decimal)

        Dim pmPat8 = New SqlParameter("@gastos", SqlDbType.Decimal)
        Dim pmPat9 = New SqlParameter("@idEmpleado", SqlDbType.Int)
        Dim pmPat10 = New SqlParameter("@vales", SqlDbType.Decimal)
        Dim pmPat11 = New SqlParameter("@usuario", SqlDbType.NVarChar, 150)
        Dim pmPat12 = New SqlParameter("@depositos", SqlDbType.Decimal)
        Dim pmPat13 = New SqlParameter("@descuentos", SqlDbType.Decimal)

        AbrirConexion()
        If vHayerror Then Return ""
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = Format(vDatos.fecha, "dd/MM/yyyy") & " " & Format(vDatos.fecha, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@idOrdenEntrega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idOrdenEntrega").Value = vDatos.idOrdenEntrega

        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@efectivo").Direction = ParameterDirection.Input
        cmComand.Parameters("@efectivo").Value = vDatos.efectivo
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@cheques").Direction = ParameterDirection.Input
        cmComand.Parameters("@cheques").Value = vDatos.cheques
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@credito").Direction = ParameterDirection.Input
        cmComand.Parameters("@credito").Value = vDatos.credito

        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@anuladas").Direction = ParameterDirection.Input
        cmComand.Parameters("@anuladas").Value = vDatos.anuladas
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@faltante").Direction = ParameterDirection.Input
        cmComand.Parameters("@faltante").Value = vDatos.faltante

        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@gastos").Direction = ParameterDirection.Input
        cmComand.Parameters("@gastos").Value = vDatos.gastos
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@idEmpleado").Direction = ParameterDirection.Input
        cmComand.Parameters("@idEmpleado").Value = vDatos.idEmpleado

        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@vales").Direction = ParameterDirection.Input
        cmComand.Parameters("@vales").Value = vDatos.vales
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@usuario").Direction = ParameterDirection.Input
        cmComand.Parameters("@usuario").Value = vDatos.usuario

        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@depositos").Direction = ParameterDirection.Input
        cmComand.Parameters("@depositos").Value = vDatos.depositos

        cmComand.Parameters.Add(pmPat13)
        cmComand.Parameters("@descuentos").Direction = ParameterDirection.Input
        cmComand.Parameters("@descuentos").Value = vDatos.descuentos
        'cmComand.ExecuteNonQuery()
        Dim returnVal As Object
        returnVal = cmComand.ExecuteScalar
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return returnVal
    End Function

    Public Function INSERTARPADETALLEPEDIDO(ByRef vDatos As datoDetallePedido, ByVal vSp As String, Optional ByVal vOp As Integer = 0) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@cantidad", SqlDbType.Int)
        Dim pmPat2 = New SqlParameter("@existenciatienda", SqlDbType.Decimal)
        Dim pmPat3 = New SqlParameter("@idproducto", SqlDbType.Int)
        Dim pmPat4 = New SqlParameter("@idpedido", SqlDbType.Int)
        'Dim pmPat5 = New SqlParameter("@preciocosto", SqlDbType.Decimal)
        'Dim pmPat6 = New SqlParameter("@precioventa", SqlDbType.Decimal)
        Dim pmPat7 = New SqlParameter("@presentacion", SqlDbType.NVarChar, 50)
        ' Dim pmPat8 = New SqlParameter("@precioventaf", SqlDbType.Decimal)
        Dim pmPat9 = New SqlParameter("@precio", SqlDbType.Decimal)
        Dim pmPat10 = New SqlParameter("@promocion", SqlDbType.Int)
        Dim pmPat11 = New SqlParameter("@facturar", SqlDbType.Int)
        Dim pmPat12 = New SqlParameter("@montodescuento", SqlDbType.Decimal)
        Dim pmPat13 = New SqlParameter("@idProveedor", SqlDbType.Int)
        Dim pmPat14 = New SqlParameter("@motivodescuento", SqlDbType.NVarChar, 150)

        AbrirConexion()
        If vHayerror Then Return ""
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@cantidad").Direction = ParameterDirection.Input
        cmComand.Parameters("@cantidad").Value = CInt(vDatos.cantidad)
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@existenciatienda").Direction = ParameterDirection.Input
        cmComand.Parameters("@existenciatienda").Value = vDatos.existenciatienda

        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@idproducto").Direction = ParameterDirection.Input
        cmComand.Parameters("@idproducto").Value = vDatos.idproducto
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@idpedido").Direction = ParameterDirection.Input
        cmComand.Parameters("@idpedido").Value = vDatos.idpedido
        'cmComand.Parameters.Add(pmPat5)
        'cmComand.Parameters("@preciocosto").Direction = ParameterDirection.Input
        'cmComand.Parameters("@preciocosto").Value = vDatos.preciocosto

        'cmComand.Parameters.Add(pmPat6)
        'cmComand.Parameters("@precioventa").Direction = ParameterDirection.Input
        'cmComand.Parameters("@precioventa").Value = vDatos.precioventa
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@presentacion").Direction = ParameterDirection.Input
        cmComand.Parameters("@presentacion").Value = vDatos.presentacion

        'cmComand.Parameters.Add(pmPat8)
        'cmComand.Parameters("@precioventaf").Direction = ParameterDirection.Input
        'cmComand.Parameters("@precioventaf").Value = vDatos.precioventaf
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@precio").Direction = ParameterDirection.Input
        cmComand.Parameters("@precio").Value = vDatos.precio

        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@promocion").Direction = ParameterDirection.Input
        cmComand.Parameters("@promocion").Value = vDatos.promocion.GetHashCode
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@facturar").Direction = ParameterDirection.Input
        cmComand.Parameters("@facturar").Value = vDatos.facturar.GetHashCode

        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@montodescuento").Direction = ParameterDirection.Input
        cmComand.Parameters("@montodescuento").Value = vDatos.montodescuento

        cmComand.Parameters.Add(pmPat13)
        cmComand.Parameters("@idProveedor").Direction = ParameterDirection.Input
        cmComand.Parameters("@idProveedor").Value = vDatos.idProveedor

        cmComand.Parameters.Add(pmPat14)
        cmComand.Parameters("@motivodescuento").Direction = ParameterDirection.Input
        cmComand.Parameters("@motivodescuento").Value = vDatos.motivo





        'cmComand.ExecuteNonQuery()
        Dim returnVal As Object
        returnVal = cmComand.ExecuteScalar
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return returnVal
    End Function
    Public Sub INSERTARPABODEGA(ByRef vDatos As datosBodega, ByVal vSp As String, Optional ByVal vOp As Integer = 0)
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@bodega", SqlDbType.NVarChar, 50)
        Dim pmPat2 = New SqlParameter("@direccion", SqlDbType.NVarChar, 100)
        Dim pmPat3 = New SqlParameter("@departamento", SqlDbType.NVarChar, 50)
        Dim pmPat4 = New SqlParameter("@telefono", SqlDbType.NVarChar, 25)
        Dim pmPat5 = New SqlParameter("@latitud", SqlDbType.NVarChar, 200)
        Dim pmPat6 = New SqlParameter("@longitud", SqlDbType.NVarChar, 200)
        Dim pmPat7 = New SqlParameter("@idbodega", SqlDbType.Int)
        Dim pmPat8 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat9 = New SqlParameter("@habilitada", SqlDbType.Int)

        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@bodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@bodega").Value = vDatos.bodega
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@direccion").Direction = ParameterDirection.Input
        cmComand.Parameters("@direccion").Value = vDatos.direccion

        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@departamento").Direction = ParameterDirection.Input
        cmComand.Parameters("@departamento").Value = vDatos.departamento
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@telefono").Direction = ParameterDirection.Input
        cmComand.Parameters("@telefono").Value = vDatos.telefono
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@latitud").Direction = ParameterDirection.Input
        cmComand.Parameters("@latitud").Value = vDatos.latitud

        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@longitud").Direction = ParameterDirection.Input
        cmComand.Parameters("@longitud").Value = vDatos.longitud
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@idbodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idbodega").Value = vDatos.idbodega

        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo

        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@habilitada").Direction = ParameterDirection.Input
        cmComand.Parameters("@habilitada").Value = vDatos.habilitada.GetHashCode

        cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()

    End Sub
    Public Sub INSERTARPACHEQUESCLIENTES(ByRef vDatos As datosChequesClientes, ByVal vSp As String, Optional ByVal vOp As Integer = 0)
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@numero", SqlDbType.NVarChar, 50)
        Dim pmPat2 = New SqlParameter("@idBanco", SqlDbType.Int)
        Dim pmPat3 = New SqlParameter("@nombrecuenta", SqlDbType.NVarChar, 250)
        Dim pmPat4 = New SqlParameter("@foto", SqlDbType.Image)
        Dim pmPat5 = New SqlParameter("@idDetalleFacturaCorteOrdenEntrega", SqlDbType.Int)
        Dim pmPat6 = New SqlParameter("@fechacobrocheque", SqlDbType.Date)
        Dim pmPat7 = New SqlParameter("@total", SqlDbType.Decimal)
        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@numero").Direction = ParameterDirection.Input
        cmComand.Parameters("@numero").Value = vDatos.numero
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@idBanco").Direction = ParameterDirection.Input
        cmComand.Parameters("@idBanco").Value = vDatos.idBanco
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@nombrecuenta").Direction = ParameterDirection.Input
        cmComand.Parameters("@nombrecuenta").Value = vDatos.nombrecuenta
        'cmComand.Parameters.Add(pmPat4)
        'cmComand.Parameters("@modelo").Direction = ParameterDirection.Input
        'cmComand.Parameters("@modelo").Value = vDatos.modelo
        'cmComand.Parameters.Add(pmPat5)
        'cmComand.Parameters("@cilindros").Direction = ParameterDirection.Input
        'cmComand.Parameters("@cilindros").Value = vDatos.cilindros


        ''*************foto
        Dim fsFoto As FileStream
        If File.Exists(vDireccionDocumentos & "\fotochetmpo.jpg") Then
            Kill(vDireccionDocumentos & "\fotochetmpo.jpg")
        End If
        If vDatos.foto.Image IsNot Nothing Then
            Dim vPath As String = vDireccionDocumentos & "\fotochetmpo.jpg" '"C:\VINNS\Farmalider\bin\Debug"
            vDatos.foto.Image.Save(vPath, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim fiFoto As FileInfo = New FileInfo(vPath)

            Dim Temp As Long = fiFoto.Length
            Dim lung As Long = Convert.ToInt32(Temp)
            Dim picture(lung) As Byte
            fsFoto = New FileStream(vPath, FileMode.Open)
            fsFoto.Read(picture, 0, lung)
            fsFoto.Close()
            cmComand.Parameters.Add(pmPat4)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = picture
        Else
            cmComand.Parameters.Add(pmPat4)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = DBNull.Value
        End If
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@idDetalleFacturaCorteOrdenEntrega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idDetalleFacturaCorteOrdenEntrega").Value = vDatos.idDetalleFacturaCorteOrdenEntrega

        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@fechacobrocheque").Direction = ParameterDirection.Input
        cmComand.Parameters("@fechacobrocheque").Value = vDatos.fechacobrocheque

        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@total").Direction = ParameterDirection.Input
        cmComand.Parameters("@total").Value = vDatos.total

        cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()

    End Sub
    Public Sub INSERTARPAVEHICULO(ByRef vDatos As datosVehiculos, ByVal vSp As String, Optional ByVal vOp As Integer = 0)
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@marca", SqlDbType.NVarChar, 50)
        Dim pmPat2 = New SqlParameter("@tipo", SqlDbType.NVarChar, 50)
        Dim pmPat3 = New SqlParameter("@placa", SqlDbType.NVarChar, 50)
        Dim pmPat4 = New SqlParameter("@modelo", SqlDbType.Int)
        Dim pmPat5 = New SqlParameter("@cilindros", SqlDbType.Int)
        Dim pmPat6 = New SqlParameter("@puertas", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@peso", SqlDbType.Decimal)
        Dim pmPat8 = New SqlParameter("@nit", SqlDbType.NVarChar, 50)
        Dim pmPat9 = New SqlParameter("@nombre", SqlDbType.NVarChar, 250)
        Dim pmPat10 = New SqlParameter("@fecha", SqlDbType.Date)
        Dim pmPat11 = New SqlParameter("@chasis", SqlDbType.NVarChar, 150)
        Dim pmPat12 = New SqlParameter("@motor", SqlDbType.NVarChar, 150)
        Dim pmPat13 = New SqlParameter("@kilometrajeinicial", SqlDbType.Decimal)
        Dim pmPat14 = New SqlParameter("@codigo", SqlDbType.NVarChar, 50)
        Dim pmPat15 = New SqlParameter("@foto", SqlDbType.Image)
        Dim pmPat16 = New SqlParameter("@idbodega", SqlDbType.Int)
        Dim pmPat17 = New SqlParameter("@centimetrosc", SqlDbType.Int)
        Dim pmPat18 = New SqlParameter("@linea", SqlDbType.NVarChar, 150)
        'Dim pmPat19 = New SqlParameter("@peso", SqlDbType.Int)
        Dim pmPat20 = New SqlParameter("@vin", SqlDbType.NVarChar, 150)
        Dim pmPat21 = New SqlParameter("@color", SqlDbType.NVarChar, 50)
        Dim pmPat22 = New SqlParameter("@combustible", SqlDbType.NVarChar, 50)
        Dim pmPat23 = New SqlParameter("@habilitado", SqlDbType.Int)
        Dim pmPat24 = New SqlParameter("@tipomante", SqlDbType.Int)
        Dim pmPat25 = New SqlParameter("@idvehiculo", SqlDbType.Int)
        Dim pmPat26 = New SqlParameter("@volumen", SqlDbType.Decimal)

        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@marca").Direction = ParameterDirection.Input
        cmComand.Parameters("@marca").Value = vDatos.marca
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@placa").Direction = ParameterDirection.Input
        cmComand.Parameters("@placa").Value = vDatos.placa
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@modelo").Direction = ParameterDirection.Input
        cmComand.Parameters("@modelo").Value = vDatos.modelo
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@cilindros").Direction = ParameterDirection.Input
        cmComand.Parameters("@cilindros").Value = vDatos.cilindros
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@puertas").Direction = ParameterDirection.Input
        cmComand.Parameters("@puertas").Value = vDatos.puertas
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@peso").Direction = ParameterDirection.Input
        cmComand.Parameters("@peso").Value = vDatos.peso
        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@nit").Direction = ParameterDirection.Input
        cmComand.Parameters("@nit").Value = vDatos.nit
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@nombre").Direction = ParameterDirection.Input
        cmComand.Parameters("@nombre").Value = vDatos.nombre
        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = vDatos.fecha
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@chasis").Direction = ParameterDirection.Input
        cmComand.Parameters("@chasis").Value = vDatos.chasis

        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@motor").Direction = ParameterDirection.Input
        cmComand.Parameters("@motor").Value = vDatos.motor
        cmComand.Parameters.Add(pmPat13)
        cmComand.Parameters("@kilometrajeinicial").Direction = ParameterDirection.Input
        cmComand.Parameters("@kilometrajeinicial").Value = vDatos.kilometrajeinicial
        cmComand.Parameters.Add(pmPat14)
        cmComand.Parameters("@codigo").Direction = ParameterDirection.Input
        cmComand.Parameters("@codigo").Value = vDatos.codigo

        ''*************foto
        Dim fsFoto As FileStream
        If File.Exists(vDireccionDocumentos & "\fotovehtmpo.jpg") Then
            Kill(vDireccionDocumentos & "\fotovehtmpo.jpg")
        End If
        If vDatos.foto.Image IsNot Nothing Then
            Dim vPath As String = vDireccionDocumentos & "\fotovehtmpo.jpg" '"C:\VINNS\Farmalider\bin\Debug"
            vDatos.foto.Image.Save(vPath, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim fiFoto As FileInfo = New FileInfo(vPath)

            Dim Temp As Long = fiFoto.Length
            Dim lung As Long = Convert.ToInt32(Temp)
            Dim picture(lung) As Byte
            fsFoto = New FileStream(vPath, FileMode.Open)
            fsFoto.Read(picture, 0, lung)
            fsFoto.Close()
            cmComand.Parameters.Add(pmPat15)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = picture
        Else
            cmComand.Parameters.Add(pmPat15)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = DBNull.Value
        End If
        cmComand.Parameters.Add(pmPat16)
        cmComand.Parameters("@idbodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idbodega").Value = vConexion.vidBodega

        cmComand.Parameters.Add(pmPat17)
        cmComand.Parameters("@centimetrosc").Direction = ParameterDirection.Input
        cmComand.Parameters("@centimetrosc").Value = vDatos.centimetrosc
        cmComand.Parameters.Add(pmPat18)
        cmComand.Parameters("@linea").Direction = ParameterDirection.Input
        cmComand.Parameters("@linea").Value = vDatos.linea
        'cmComand.Parameters.Add(pmPat19)
        'cmComand.Parameters("@peso").Direction = ParameterDirection.Input
        'cmComand.Parameters("@peso").Value = vDatos.peso
        cmComand.Parameters.Add(pmPat20)
        cmComand.Parameters("@vin").Direction = ParameterDirection.Input
        cmComand.Parameters("@vin").Value = vDatos.vin
        cmComand.Parameters.Add(pmPat21)
        cmComand.Parameters("@color").Direction = ParameterDirection.Input
        cmComand.Parameters("@color").Value = vDatos.color
        cmComand.Parameters.Add(pmPat22)
        cmComand.Parameters("@combustible").Direction = ParameterDirection.Input
        cmComand.Parameters("@combustible").Value = vDatos.combustible
        cmComand.Parameters.Add(pmPat23)
        cmComand.Parameters("@habilitado").Direction = ParameterDirection.Input
        cmComand.Parameters("@habilitado").Value = vDatos.habilitado.GetHashCode
        cmComand.Parameters.Add(pmPat24)
        cmComand.Parameters("@tipomante").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipomante").Value = vDatos.tipomante
        cmComand.Parameters.Add(pmPat25)
        cmComand.Parameters("@idvehiculo").Direction = ParameterDirection.Input
        cmComand.Parameters("@idvehiculo").Value = vDatos.idvehiculo
        cmComand.Parameters.Add(pmPat26)
        cmComand.Parameters("@volumen").Direction = ParameterDirection.Input
        cmComand.Parameters("@volumen").Value = vDatos.volumen

        cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()

    End Sub
    Public Sub INSERTARPATIENDA(ByRef vDatos As datosTienda, ByVal vSp As String, Optional ByVal vOp As Integer = 0)
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat1 = New SqlParameter("@tienda", SqlDbType.NVarChar, 100)
        Dim pmPat2 = New SqlParameter("@codigo", SqlDbType.NVarChar, 50)
        Dim pmPat3 = New SqlParameter("@direccion", SqlDbType.NVarChar, 250)
        Dim pmPat4 = New SqlParameter("@telefono", SqlDbType.NVarChar, 50)
        Dim pmPat5 = New SqlParameter("@nit", SqlDbType.NVarChar, 50)
        Dim pmPat6 = New SqlParameter("@idruta", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@latitud", SqlDbType.NVarChar, 200)
        Dim pmPat8 = New SqlParameter("@distancia", SqlDbType.Decimal)
        Dim pmPat9 = New SqlParameter("@direccionf", SqlDbType.NVarChar, 250)
        Dim pmPat10 = New SqlParameter("@fechacreada", SqlDbType.DateTime)
        Dim pmPat11 = New SqlParameter("@longitud", SqlDbType.NVarChar, 200)
        Dim pmPat12 = New SqlParameter("@idtienda", SqlDbType.Int)
        Dim pmPat13 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat14 = New SqlParameter("@cliente", SqlDbType.NVarChar, 250)
        Dim pmPat15 = New SqlParameter("@idpropietario", SqlDbType.Int)
        Dim pmPat16 = New SqlParameter("@telefononoti", SqlDbType.NVarChar, 50)
        Dim pmPat17 = New SqlParameter("@correo", SqlDbType.NVarChar, 100)
        Dim pmPat18 = New SqlParameter("@notitelefono", SqlDbType.Int)
        Dim pmPat19 = New SqlParameter("@noticorreo", SqlDbType.Int)
        Dim pmPat20 = New SqlParameter("@idDepartamento", SqlDbType.Int)
        Dim pmPat21 = New SqlParameter("@idMunicipio", SqlDbType.Int)
        Dim pmPat22 = New SqlParameter("@codigointerno", SqlDbType.Int)
        Dim pmPat23 = New SqlParameter("@limitecredito", SqlDbType.Decimal)


        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@tienda").Direction = ParameterDirection.Input
        cmComand.Parameters("@tienda").Value = vDatos.tienda
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@codigo").Direction = ParameterDirection.Input
        cmComand.Parameters("@codigo").Value = vDatos.codigo

        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@direccion").Direction = ParameterDirection.Input
        cmComand.Parameters("@direccion").Value = vDatos.direccion
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@telefono").Direction = ParameterDirection.Input
        cmComand.Parameters("@telefono").Value = vDatos.telefono
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@nit").Direction = ParameterDirection.Input
        cmComand.Parameters("@nit").Value = vDatos.nit

        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@idruta").Direction = ParameterDirection.Input
        cmComand.Parameters("@idruta").Value = vDatos.idruta
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@latitud").Direction = ParameterDirection.Input
        cmComand.Parameters("@latitud").Value = vDatos.latitud

        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@distancia").Direction = ParameterDirection.Input
        cmComand.Parameters("@distancia").Value = vDatos.distancia
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@direccionf").Direction = ParameterDirection.Input
        cmComand.Parameters("@direccionf").Value = vDatos.direccionf
        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@fechacreada").Direction = ParameterDirection.Input
        cmComand.Parameters("@fechacreada").Value = Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@longitud").Direction = ParameterDirection.Input
        cmComand.Parameters("@longitud").Value = vDatos.longitud
        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@idtienda").Direction = ParameterDirection.Input
        cmComand.Parameters("@idtienda").Value = vDatos.idtienda
        cmComand.Parameters.Add(pmPat13)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat14)
        cmComand.Parameters("@cliente").Direction = ParameterDirection.Input
        cmComand.Parameters("@cliente").Value = vDatos.cliente
        cmComand.Parameters.Add(pmPat15)
        cmComand.Parameters("@idpropietario").Direction = ParameterDirection.Input
        cmComand.Parameters("@idpropietario").Value = vDatos.idPropietario
        cmComand.Parameters.Add(pmPat16)
        cmComand.Parameters("@telefononoti").Direction = ParameterDirection.Input
        cmComand.Parameters("@telefononoti").Value = vDatos.telefononoti
        cmComand.Parameters.Add(pmPat17)
        cmComand.Parameters("@correo").Direction = ParameterDirection.Input
        cmComand.Parameters("@correo").Value = vDatos.correo
        cmComand.Parameters.Add(pmPat18)
        cmComand.Parameters("@notitelefono").Direction = ParameterDirection.Input
        cmComand.Parameters("@notitelefono").Value = vDatos.notitele
        cmComand.Parameters.Add(pmPat19)
        cmComand.Parameters("@noticorreo").Direction = ParameterDirection.Input
        cmComand.Parameters("@noticorreo").Value = vDatos.noticorreo
        cmComand.Parameters.Add(pmPat20)
        cmComand.Parameters("@idDepartamento").Direction = ParameterDirection.Input
        cmComand.Parameters("@idDepartamento").Value = vDatos.idDepartamento
        cmComand.Parameters.Add(pmPat21)
        cmComand.Parameters("@idMunicipio").Direction = ParameterDirection.Input
        cmComand.Parameters("@idMunicipio").Value = vDatos.idMunicipio
        cmComand.Parameters.Add(pmPat22)
        cmComand.Parameters("@codigointerno").Direction = ParameterDirection.Input
        cmComand.Parameters("@codigointerno").Value = vDatos.codigointerno
        cmComand.Parameters.Add(pmPat23)
        cmComand.Parameters("@limitecredito").Direction = ParameterDirection.Input
        cmComand.Parameters("@limitecredito").Value = vDatos.limitecredito
        cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()

    End Sub
    Public Sub INSERTARPAPRODUCTO(ByRef vDatos As datosProductos, ByVal vSp As String, Optional ByVal vOp As Integer = 0)
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim pmPat0 = New SqlParameter("@idBodega", SqlDbType.Int)
        Dim pmPat1 = New SqlParameter("@Producto", SqlDbType.NVarChar, 250)
        Dim pmPat2 = New SqlParameter("@Productofac", SqlDbType.NVarChar, 250)
        Dim pmPat3 = New SqlParameter("@unidadxfardo", SqlDbType.Int)
        Dim pmPat4 = New SqlParameter("@unidadxpaquete", SqlDbType.Int)
        Dim pmPat5 = New SqlParameter("@preciocosto", SqlDbType.Decimal)
        Dim pmPat6 = New SqlParameter("@precioventa", SqlDbType.Decimal)
        Dim pmPat7 = New SqlParameter("@fechavencimiento", SqlDbType.Date)
        Dim pmPat8 = New SqlParameter("@idsubcategoria", SqlDbType.Int)
        Dim pmPat9 = New SqlParameter("@venta", SqlDbType.Int)
        Dim pmPat10 = New SqlParameter("@codigob", SqlDbType.NVarChar, 50)
        Dim pmPat11 = New SqlParameter("@codigobk", SqlDbType.NVarChar, 50)
        Dim pmPat12 = New SqlParameter("@fardo", SqlDbType.Int)
        Dim pmPat13 = New SqlParameter("@paquete", SqlDbType.Int)
        Dim pmPat14 = New SqlParameter("@unidad", SqlDbType.Int)
        Dim pmPat15 = New SqlParameter("@foto", SqlDbType.Image)
        Dim pmPat16 = New SqlParameter("@fechavencimientosi", SqlDbType.Int)
        Dim pmPat17 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat18 = New SqlParameter("@idProducto", SqlDbType.Int)
        Dim pmPat19 = New SqlParameter("@pesoneto", SqlDbType.Decimal)
        Dim pmPat20 = New SqlParameter("@pesobruto", SqlDbType.Decimal)
        Dim pmPat21 = New SqlParameter("@decimetroc", SqlDbType.Decimal)
        Dim pmPat22 = New SqlParameter("@codigo3", SqlDbType.NVarChar, 50)
        Dim pmPat23 = New SqlParameter("@idCasa", SqlDbType.Int)
        Dim pmPat24 = New SqlParameter("@idSegmento", SqlDbType.Int)
        AbrirConexion()
        If vHayerror Then Exit Sub
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat0)
        cmComand.Parameters("@idBodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idBodega").Value = vConexion.vidBodega
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@Producto").Direction = ParameterDirection.Input
        cmComand.Parameters("@Producto").Value = vDatos.descripcion
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@Productofac").Direction = ParameterDirection.Input
        cmComand.Parameters("@Productofac").Value = vDatos.descripcion2
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@unidadxfardo").Direction = ParameterDirection.Input
        cmComand.Parameters("@unidadxfardo").Value = vDatos.unidadxfardo
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@unidadxpaquete").Direction = ParameterDirection.Input
        cmComand.Parameters("@unidadxpaquete").Value = vDatos.unidadxpaquete
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@preciocosto").Direction = ParameterDirection.Input
        cmComand.Parameters("@preciocosto").Value = vDatos.preciocosto
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@precioventa").Direction = ParameterDirection.Input
        cmComand.Parameters("@precioventa").Value = vDatos.precioventa
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@fechavencimiento").Direction = ParameterDirection.Input
        cmComand.Parameters("@fechavencimiento").Value = vDatos.fechavencimiento
        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@idsubcategoria").Direction = ParameterDirection.Input
        cmComand.Parameters("@idsubcategoria").Value = vDatos.idsubcategoria
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@venta").Direction = ParameterDirection.Input
        cmComand.Parameters("@venta").Value = vDatos.venta.GetHashCode
        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@codigob").Direction = ParameterDirection.Input
        cmComand.Parameters("@codigob").Value = vDatos.codigo
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@codigobk").Direction = ParameterDirection.Input
        cmComand.Parameters("@codigobk").Value = vDatos.codigo2

        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@fardo").Direction = ParameterDirection.Input
        cmComand.Parameters("@fardo").Value = vDatos.fardo.GetHashCode
        cmComand.Parameters.Add(pmPat13)
        cmComand.Parameters("@paquete").Direction = ParameterDirection.Input
        cmComand.Parameters("@paquete").Value = vDatos.paquete.GetHashCode
        cmComand.Parameters.Add(pmPat14)
        cmComand.Parameters("@unidad").Direction = ParameterDirection.Input
        cmComand.Parameters("@unidad").Value = vDatos.unidad.GetHashCode

        ''*************foto
        Dim fsFoto As FileStream
        If File.Exists(vDireccionDocumentos & "\fotoprodtmpo.jpg") Then
            Kill(vDireccionDocumentos & "\fotoprodtmpo.jpg")
        End If
        If vDatos.foto.Image IsNot Nothing Then
            Dim vPath As String = vDireccionDocumentos & "\fotoprodtmpo.jpg" '"C:\VINNS\Farmalider\bin\Debug"
            vDatos.foto.Image.Save(vPath, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim fiFoto As FileInfo = New FileInfo(vPath)

            Dim Temp As Long = fiFoto.Length
            Dim lung As Long = Convert.ToInt32(Temp)
            Dim picture(lung) As Byte
            fsFoto = New FileStream(vPath, FileMode.Open)
            fsFoto.Read(picture, 0, lung)
            fsFoto.Close()
            cmComand.Parameters.Add(pmPat15)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = picture
        Else
            cmComand.Parameters.Add(pmPat15)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = DBNull.Value
        End If

        cmComand.Parameters.Add(pmPat16)
        cmComand.Parameters("@fechavencimientosi").Direction = ParameterDirection.Input
        cmComand.Parameters("@fechavencimientosi").Value = vDatos.fechavencimientosi.GetHashCode
        cmComand.Parameters.Add(pmPat17)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat18)
        cmComand.Parameters("@idProducto").Direction = ParameterDirection.Input
        cmComand.Parameters("@idProducto").Value = vDatos.idproducto
        cmComand.Parameters.Add(pmPat19)
        cmComand.Parameters("@pesoneto").Direction = ParameterDirection.Input
        cmComand.Parameters("@pesoneto").Value = vDatos.pesoneto
        cmComand.Parameters.Add(pmPat20)
        cmComand.Parameters("@pesobruto").Direction = ParameterDirection.Input
        cmComand.Parameters("@pesobruto").Value = vDatos.pesobruto
        cmComand.Parameters.Add(pmPat21)
        cmComand.Parameters("@decimetroc").Direction = ParameterDirection.Input
        cmComand.Parameters("@decimetroc").Value = vDatos.decimetroc
        cmComand.Parameters.Add(pmPat22)
        cmComand.Parameters("@codigo3").Direction = ParameterDirection.Input
        cmComand.Parameters("@codigo3").Value = vDatos.codigo3
        cmComand.Parameters.Add(pmPat23)
        cmComand.Parameters("@idCasa").Direction = ParameterDirection.Input
        cmComand.Parameters("@idCasa").Value = vDatos.idCasa
        cmComand.Parameters.Add(pmPat24)
        cmComand.Parameters("@idSegmento").Direction = ParameterDirection.Input
        cmComand.Parameters("@idSegmento").Value = vDatos.idSegmento
        cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()

    End Sub
    Public Function INSERTARPAACTUALIZARINVENTARIO(ByRef vDatos As datosActualizarInventario, ByVal vSp As String) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim returnVal As Object
        Dim pmPat1 = New SqlParameter("@motivo", SqlDbType.NVarChar, 250)
        Dim pmPat2 = New SqlParameter("@fecha", SqlDbType.DateTime)
        Dim pmPat3 = New SqlParameter("@existenciareal", SqlDbType.Int)
        Dim pmPat4 = New SqlParameter("@idBodega", SqlDbType.Int)
        'Dim pmPat5 = New SqlParameter("@kilometrajeinicial", SqlDbType.Decimal)
        'Dim pmPat6 = New SqlParameter("@total", SqlDbType.Decimal)
        'Dim pmPat7 = New SqlParameter("@idproducto", SqlDbType.Int)
        'Dim pmPat8 = New SqlParameter("@operador", SqlDbType.NVarChar, 10)
        'Dim pmPat9 = New SqlParameter("@cantidad2", SqlDbType.Int)
        'Dim pmPat10 = New SqlParameter("@operador2", SqlDbType.NVarChar, 10)
        'Dim pmPat11 = New SqlParameter("@precioventa", SqlDbType.Decimal)
        'Dim pmPat12 = New SqlParameter("@presentacion", SqlDbType.NVarChar, 50)
        'Dim pmPat13 = New SqlParameter("@habilitada", SqlDbType.Int)
        'Dim pmPat14 = New SqlParameter("@idpromocion", SqlDbType.Int)
        'Dim pmPat15 = New SqlParameter("@tipo", SqlDbType.Int)
        'Dim pmPat16 = New SqlParameter("@fecha", SqlDbType.DateTime)

        AbrirConexion()
        If vHayerror Then Return "ERROR"
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@motivo").Direction = ParameterDirection.Input
        cmComand.Parameters("@motivo").Value = vDatos.motivo 'Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = Format(vDatos.fecha, "dd/MM/yyyy") & " " & Format(vDatos.fecha, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@existenciareal").Direction = ParameterDirection.Input
        cmComand.Parameters("@existenciareal").Value = vDatos.existenciareal.GetHashCode
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@idBodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idBodega").Value = vConexion.vidBodega 'Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        'cmComand.Parameters.Add(pmPat5)
        'cmComand.Parameters("@kilometrajeinicial").Direction = ParameterDirection.Input
        'cmComand.Parameters("@kilometrajeinicial").Value = vDatos.kilometrajeinicial
        'cmComand.Parameters.Add(pmPat6)
        'cmComand.Parameters("@total").Direction = ParameterDirection.Input
        'cmComand.Parameters("@total").Value = vDatos.total
        'cmComand.Parameters.Add(pmPat7)
        'cmComand.Parameters("@idproducto").Direction = ParameterDirection.Input
        'cmComand.Parameters("@idproducto").Value = vDatos.idProducto
        'cmComand.Parameters.Add(pmPat8)
        'cmComand.Parameters("@operador").Direction = ParameterDirection.Input
        'cmComand.Parameters("@operador").Value = vDatos.operador
        'cmComand.Parameters.Add(pmPat9)
        'cmComand.Parameters("@cantidad2").Direction = ParameterDirection.Input
        'cmComand.Parameters("@cantidad2").Value = vDatos.cantidad2
        'cmComand.Parameters.Add(pmPat10)
        'cmComand.Parameters("@operador2").Direction = ParameterDirection.Input
        'cmComand.Parameters("@operador2").Value = vDatos.operador2
        'cmComand.Parameters.Add(pmPat11)
        'cmComand.Parameters("@precioventa").Direction = ParameterDirection.Input
        'cmComand.Parameters("@precioventa").Value = vDatos.precioventa
        'cmComand.Parameters.Add(pmPat12)
        'cmComand.Parameters("@presentacion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@presentacion").Value = vDatos.presentacion
        'cmComand.Parameters.Add(pmPat13)
        'cmComand.Parameters("@habilitada").Direction = ParameterDirection.Input
        'cmComand.Parameters("@habilitada").Value = vDatos.habilitada.GetHashCode
        'cmComand.Parameters.Add(pmPat14)
        'cmComand.Parameters("@idpromocion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@idpromocion").Value = vDatos.idPromocion
        'cmComand.Parameters.Add(pmPat15)
        'cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        'cmComand.Parameters("@tipo").Value = vDatos.tipo 'Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        'cmComand.Parameters.Add(pmPat16)
        'cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        'cmComand.Parameters("@fecha").Value = Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")

        returnVal = cmComand.ExecuteScalar

        'cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return (returnVal)
    End Function
    Public Function INSERTARPAORDENENTREGA(ByRef vDatos As datosOrdenesEntrega, ByVal vSp As String) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim returnVal As Object
        Dim pmPat1 = New SqlParameter("@idbodega", SqlDbType.Int)
        Dim pmPat2 = New SqlParameter("@idVehiculo", SqlDbType.Int)
        Dim pmPat3 = New SqlParameter("@idEmpleado", SqlDbType.Int)
        Dim pmPat4 = New SqlParameter("@fecha", SqlDbType.DateTime)
        Dim pmPat5 = New SqlParameter("@kilometrajeinicial", SqlDbType.Decimal)
        Dim pmPat6 = New SqlParameter("@total", SqlDbType.Decimal)
        'Dim pmPat7 = New SqlParameter("@idproducto", SqlDbType.Int)
        'Dim pmPat8 = New SqlParameter("@operador", SqlDbType.NVarChar, 10)
        'Dim pmPat9 = New SqlParameter("@cantidad2", SqlDbType.Int)
        'Dim pmPat10 = New SqlParameter("@operador2", SqlDbType.NVarChar, 10)
        'Dim pmPat11 = New SqlParameter("@precioventa", SqlDbType.Decimal)
        'Dim pmPat12 = New SqlParameter("@presentacion", SqlDbType.NVarChar, 50)
        'Dim pmPat13 = New SqlParameter("@habilitada", SqlDbType.Int)
        'Dim pmPat14 = New SqlParameter("@idpromocion", SqlDbType.Int)
        'Dim pmPat15 = New SqlParameter("@tipo", SqlDbType.Int)
        'Dim pmPat16 = New SqlParameter("@fecha", SqlDbType.DateTime)

        AbrirConexion()
        If vHayerror Then Return "ERROR"
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@idbodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idbodega").Value = vConexion.vidBodega 'Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@idVehiculo").Direction = ParameterDirection.Input
        cmComand.Parameters("@idVehiculo").Value = vDatos.idVehiculo
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@idEmpleado").Direction = ParameterDirection.Input
        cmComand.Parameters("@idEmpleado").Value = vDatos.idEmpleado
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@kilometrajeinicial").Direction = ParameterDirection.Input
        cmComand.Parameters("@kilometrajeinicial").Value = vDatos.kilometrajeinicial
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@total").Direction = ParameterDirection.Input
        cmComand.Parameters("@total").Value = vDatos.total
        'cmComand.Parameters.Add(pmPat7)
        'cmComand.Parameters("@idproducto").Direction = ParameterDirection.Input
        'cmComand.Parameters("@idproducto").Value = vDatos.idProducto
        'cmComand.Parameters.Add(pmPat8)
        'cmComand.Parameters("@operador").Direction = ParameterDirection.Input
        'cmComand.Parameters("@operador").Value = vDatos.operador
        'cmComand.Parameters.Add(pmPat9)
        'cmComand.Parameters("@cantidad2").Direction = ParameterDirection.Input
        'cmComand.Parameters("@cantidad2").Value = vDatos.cantidad2
        'cmComand.Parameters.Add(pmPat10)
        'cmComand.Parameters("@operador2").Direction = ParameterDirection.Input
        'cmComand.Parameters("@operador2").Value = vDatos.operador2
        'cmComand.Parameters.Add(pmPat11)
        'cmComand.Parameters("@precioventa").Direction = ParameterDirection.Input
        'cmComand.Parameters("@precioventa").Value = vDatos.precioventa
        'cmComand.Parameters.Add(pmPat12)
        'cmComand.Parameters("@presentacion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@presentacion").Value = vDatos.presentacion
        'cmComand.Parameters.Add(pmPat13)
        'cmComand.Parameters("@habilitada").Direction = ParameterDirection.Input
        'cmComand.Parameters("@habilitada").Value = vDatos.habilitada.GetHashCode
        'cmComand.Parameters.Add(pmPat14)
        'cmComand.Parameters("@idpromocion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@idpromocion").Value = vDatos.idPromocion
        'cmComand.Parameters.Add(pmPat15)
        'cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        'cmComand.Parameters("@tipo").Value = vDatos.tipo 'Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        'cmComand.Parameters.Add(pmPat16)
        'cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        'cmComand.Parameters("@fecha").Value = Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")

        returnVal = cmComand.ExecuteScalar

        'cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return (returnVal)
    End Function
    Public Function INSERTARPAPROMOCION(ByRef vDatos As datosPromocion, ByVal vSp As String) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim returnVal As Object
        Dim pmPat1 = New SqlParameter("@idbodega", SqlDbType.Int)
        Dim pmPat2 = New SqlParameter("@fechainicio", SqlDbType.Date)
        Dim pmPat3 = New SqlParameter("@fechafinal", SqlDbType.Date)
        Dim pmPat4 = New SqlParameter("@descripcion", SqlDbType.NVarChar, 250)
        Dim pmPat5 = New SqlParameter("@descripcionfac", SqlDbType.NVarChar, 250)
        Dim pmPat6 = New SqlParameter("@cantidad", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@idproducto", SqlDbType.Int)
        Dim pmPat8 = New SqlParameter("@operador", SqlDbType.NVarChar, 10)
        Dim pmPat9 = New SqlParameter("@cantidad2", SqlDbType.Int)
        Dim pmPat10 = New SqlParameter("@operador2", SqlDbType.NVarChar, 10)
        Dim pmPat11 = New SqlParameter("@precioventa", SqlDbType.Decimal)
        Dim pmPat12 = New SqlParameter("@presentacion", SqlDbType.NVarChar, 50)
        Dim pmPat13 = New SqlParameter("@habilitada", SqlDbType.Int)
        Dim pmPat14 = New SqlParameter("@idpromocion", SqlDbType.Int)
        Dim pmPat15 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat16 = New SqlParameter("@fecha", SqlDbType.DateTime)
        Dim pmPat17 = New SqlParameter("@codigo", SqlDbType.NVarChar, 50)

        AbrirConexion()
        If vHayerror Then Return "ERROR"
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@idbodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idbodega").Value = vConexion.vidBodega 'Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@fechainicio").Direction = ParameterDirection.Input
        cmComand.Parameters("@fechainicio").Value = vDatos.fechainicio
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@fechafinal").Direction = ParameterDirection.Input
        cmComand.Parameters("@fechafinal").Value = vDatos.fechafinal
        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@descripcion").Direction = ParameterDirection.Input
        cmComand.Parameters("@descripcion").Value = vDatos.descripcion
        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@descripcionfac").Direction = ParameterDirection.Input
        cmComand.Parameters("@descripcionfac").Value = vDatos.descripcionfac
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@cantidad").Direction = ParameterDirection.Input
        cmComand.Parameters("@cantidad").Value = vDatos.cantidad
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@idproducto").Direction = ParameterDirection.Input
        cmComand.Parameters("@idproducto").Value = vDatos.idProducto
        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@operador").Direction = ParameterDirection.Input
        cmComand.Parameters("@operador").Value = vDatos.operador
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@cantidad2").Direction = ParameterDirection.Input
        cmComand.Parameters("@cantidad2").Value = vDatos.cantidad2
        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@operador2").Direction = ParameterDirection.Input
        cmComand.Parameters("@operador2").Value = vDatos.operador2
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@precioventa").Direction = ParameterDirection.Input
        cmComand.Parameters("@precioventa").Value = vDatos.precioventa
        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@presentacion").Direction = ParameterDirection.Input
        cmComand.Parameters("@presentacion").Value = vDatos.presentacion
        cmComand.Parameters.Add(pmPat13)
        cmComand.Parameters("@habilitada").Direction = ParameterDirection.Input
        cmComand.Parameters("@habilitada").Value = vDatos.habilitada.GetHashCode
        cmComand.Parameters.Add(pmPat14)
        cmComand.Parameters("@idpromocion").Direction = ParameterDirection.Input
        cmComand.Parameters("@idpromocion").Value = vDatos.idPromocion
        cmComand.Parameters.Add(pmPat15)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo 'Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat16)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = Format(Date.Now, "dd/MM/yyyy") & " " & Format(Date.Now, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat17)
        cmComand.Parameters("@codigo").Direction = ParameterDirection.Input
        cmComand.Parameters("@codigo").Value = vDatos.codigo
        returnVal = cmComand.ExecuteScalar

        'cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return (returnVal)
    End Function
    Public Function INSERTARPAOBJETIVOS(ByRef vDatos As datosConfiguracionMes, ByVal vSp As String, Optional ByVal vOp As Integer = 0) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim returnVal As Object
        Dim pmPat1 = New SqlParameter("@descripcion", SqlDbType.NVarChar, 250)
        Dim pmPat2 = New SqlParameter("@fecha", SqlDbType.Date)
        Dim pmPat3 = New SqlParameter("@mes", SqlDbType.NVarChar, 50)
        Dim pmPat4 = New SqlParameter("@diasefectivos", SqlDbType.Decimal)
        Dim pmPat5 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat6 = New SqlParameter("@idConfiguracionMes", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@idBodega", SqlDbType.Int)
        'Dim pmPat8 = New SqlParameter("@dias", SqlDbType.Int)
        'Dim pmPat9 = New SqlParameter("@tipo", SqlDbType.Int)
        'Dim pmPat10 = New SqlParameter("@idcompra", SqlDbType.Int)
        'Dim pmPat11 = New SqlParameter("@observaciones", SqlDbType.NVarChar, 250)
        'Dim pmPat12 = New SqlParameter("@bonificacion", SqlDbType.Decimal)
        'Dim pmPat13 = New SqlParameter("@foto", SqlDbType.Image)

        AbrirConexion()
        If vHayerror Then Return "ERROR"
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@descripcion").Direction = ParameterDirection.Input
        cmComand.Parameters("@descripcion").Value = vDatos.descripcion
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = Format(vDatos.fecha, "dd/MM/yyyy") ''& " " & Format(vDatos.fecha, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@mes").Direction = ParameterDirection.Input
        cmComand.Parameters("@mes").Value = vDatos.mes

        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@diasefectivos").Direction = ParameterDirection.Input
        cmComand.Parameters("@diasefectivos").Value = vDatos.diasefectivos

        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@idConfiguracionMes").Direction = ParameterDirection.Input
        cmComand.Parameters("@idConfiguracionMes").Value = vDatos.idConfiguracionMes
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@idBodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idBodega").Value = vConexion.vidBodega
        'cmComand.Parameters.Add(pmPat8)
        'cmComand.Parameters("@dias").Direction = ParameterDirection.Input
        'cmComand.Parameters("@dias").Value = vDatos.dias
        'cmComand.Parameters.Add(pmPat9)
        'cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        'cmComand.Parameters("@tipo").Value = vDatos.tipo
        'cmComand.Parameters.Add(pmPat10)
        'cmComand.Parameters("@idcompra").Direction = ParameterDirection.Input
        'cmComand.Parameters("@idcompra").Value = vDatos.idcompra
        'cmComand.Parameters.Add(pmPat11)
        'cmComand.Parameters("@observaciones").Direction = ParameterDirection.Input
        'cmComand.Parameters("@observaciones").Value = vDatos.observaciones
        'cmComand.Parameters.Add(pmPat12)
        'cmComand.Parameters("@bonificacion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@bonificacion").Value = vDatos.bonifiacion

        returnVal = cmComand.ExecuteScalar

        'cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return (returnVal)
    End Function
    Public Function INSERTARPACONFIGURACIONMES(ByRef vDatos As datosConfiguracionMes, ByVal vSp As String, Optional ByVal vOp As Integer = 0) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim returnVal As Object
        Dim pmPat1 = New SqlParameter("@descripcion", SqlDbType.NVarChar, 250)
        Dim pmPat2 = New SqlParameter("@fecha", SqlDbType.Date)
        Dim pmPat3 = New SqlParameter("@mes", SqlDbType.NVarChar, 50)
        Dim pmPat4 = New SqlParameter("@diasefectivos", SqlDbType.Decimal)
        Dim pmPat5 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat6 = New SqlParameter("@idConfiguracionMes", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@idBodega", SqlDbType.Int)
        Dim pmPat8 = New SqlParameter("@idCasa", SqlDbType.Int)
        'Dim pmPat9 = New SqlParameter("@fardos", SqlDbType.Int)
        'Dim pmPat10 = New SqlParameter("@idcompra", SqlDbType.Int)
        'Dim pmPat11 = New SqlParameter("@observaciones", SqlDbType.NVarChar, 250)
        'Dim pmPat12 = New SqlParameter("@bonificacion", SqlDbType.Decimal)
        'Dim pmPat13 = New SqlParameter("@foto", SqlDbType.Image)

        AbrirConexion()
        If vHayerror Then Return "ERROR"
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@descripcion").Direction = ParameterDirection.Input
        cmComand.Parameters("@descripcion").Value = vDatos.descripcion
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = vDatos.fecha '' Format(vDatos.fecha, "dd/MM/yyyy") ''& " " & Format(vDatos.fecha, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@mes").Direction = ParameterDirection.Input
        cmComand.Parameters("@mes").Value = vDatos.mes

        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@diasefectivos").Direction = ParameterDirection.Input
        cmComand.Parameters("@diasefectivos").Value = vDatos.diasefectivos

        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@idConfiguracionMes").Direction = ParameterDirection.Input
        cmComand.Parameters("@idConfiguracionMes").Value = vDatos.idConfiguracionMes
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@idBodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idBodega").Value = vConexion.vidBodega
        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@idCasa").Direction = ParameterDirection.Input
        cmComand.Parameters("@idCasa").Value = vDatos.idCasa
        'cmComand.Parameters.Add(pmPat9)
        'cmComand.Parameters("@fardos").Direction = ParameterDirection.Input
        'cmComand.Parameters("@fardos").Value = vDatos.fardos
        'cmComand.Parameters.Add(pmPat10)
        'cmComand.Parameters("@idcompra").Direction = ParameterDirection.Input
        'cmComand.Parameters("@idcompra").Value = vDatos.idcompra
        'cmComand.Parameters.Add(pmPat11)
        'cmComand.Parameters("@observaciones").Direction = ParameterDirection.Input
        'cmComand.Parameters("@observaciones").Value = vDatos.observaciones
        'cmComand.Parameters.Add(pmPat12)
        'cmComand.Parameters("@bonificacion").Direction = ParameterDirection.Input
        'cmComand.Parameters("@bonificacion").Value = vDatos.bonifiacion

        returnVal = cmComand.ExecuteScalar

        'cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return (returnVal)
    End Function
    Public Function INSERTARPACOMPRA(ByRef vDatos As datosCompras, ByVal vSp As String, Optional ByVal vOp As Integer = 0) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim returnVal As Object
        Dim pmPat1 = New SqlParameter("@fecha", SqlDbType.DateTime)
        Dim pmPat2 = New SqlParameter("@tipodocumento", SqlDbType.NVarChar, 50)
        Dim pmPat3 = New SqlParameter("@numerodocumento", SqlDbType.NVarChar, 50)
        Dim pmPat4 = New SqlParameter("@total", SqlDbType.Decimal)
        Dim pmPat5 = New SqlParameter("@idbodega", SqlDbType.Int)
        Dim pmPat6 = New SqlParameter("@idproveedor", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@formapago", SqlDbType.NVarChar, 50)
        Dim pmPat8 = New SqlParameter("@dias", SqlDbType.Int)
        Dim pmPat9 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat10 = New SqlParameter("@idcompra", SqlDbType.Int)
        Dim pmPat11 = New SqlParameter("@observaciones", SqlDbType.NVarChar, 250)
        Dim pmPat12 = New SqlParameter("@bonificacion", SqlDbType.Decimal)
        Dim pmPat13 = New SqlParameter("@foto", SqlDbType.Image)

        AbrirConexion()
        If vHayerror Then Return "ERROR"
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = Format(vDatos.fecha, "dd/MM/yyyy") & " " & Format(vDatos.fecha, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@tipodocumento").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipodocumento").Value = vDatos.tipodocumento
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@numerodocumento").Direction = ParameterDirection.Input
        cmComand.Parameters("@numerodocumento").Value = vDatos.numerodoc

        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@total").Direction = ParameterDirection.Input
        cmComand.Parameters("@total").Value = vDatos.total

        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@idbodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idbodega").Value = vConexion.vidBodega
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@idproveedor").Direction = ParameterDirection.Input
        cmComand.Parameters("@idproveedor").Value = vDatos.idproveedor
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@formapago").Direction = ParameterDirection.Input
        cmComand.Parameters("@formapago").Value = vDatos.formapago
        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@dias").Direction = ParameterDirection.Input
        cmComand.Parameters("@dias").Value = vDatos.dias
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@idcompra").Direction = ParameterDirection.Input
        cmComand.Parameters("@idcompra").Value = vDatos.idcompra
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@observaciones").Direction = ParameterDirection.Input
        cmComand.Parameters("@observaciones").Value = vDatos.observaciones
        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@bonificacion").Direction = ParameterDirection.Input
        cmComand.Parameters("@bonificacion").Value = vDatos.bonifiacion
        ''*************foto
        Dim fsFoto As FileStream
        If File.Exists(vDireccionDocumentos & "\fotocomptmpo.jpg") Then
            Kill(vDireccionDocumentos & "\fotocomptmpo.jpg")
        End If
        If vDatos.foto.Image IsNot Nothing Then
            ''vDatos.foto.Image.Save(vDireccionDocumentos & "\fotocomptmpo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim vPath As String = vDireccionDocumentos & "\fotocomptmpo.jpg" '"C:\VINNS\Farmalider\bin\Debug"
            vDatos.foto.Image.Save(vPath, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim fiFoto As FileInfo = New FileInfo(vPath)

            Dim Temp As Long = fiFoto.Length
            Dim lung As Long = Convert.ToInt32(Temp)
            Dim picture(lung) As Byte
            fsFoto = New FileStream(vPath, FileMode.Open)
            fsFoto.Read(picture, 0, lung)
            fsFoto.Close()

            cmComand.Parameters.Add(pmPat13)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = picture
        Else
            cmComand.Parameters.Add(pmPat13)
            cmComand.Parameters("@foto").Direction = ParameterDirection.Input
            cmComand.Parameters("@foto").Value = DBNull.Value
        End If
        If File.Exists(vDireccionDocumentos & "\fotocomptmpo.jpg") Then
            Kill(vDireccionDocumentos & "\fotocomptmpo.jpg")
        End If
        returnVal = cmComand.ExecuteScalar

        'cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return (returnVal)
    End Function
    Public Function INSERTARPEDIDO(ByRef vDatos As datosPedido, ByVal vSp As String, Optional ByVal vOp As Integer = 0) As String
        'Esta funcion ejecuta una consulta Select con un parametro de entrada de un StoreProcedure
        ' y la devuelve como un datareader para llenar un dataset
        Dim returnVal As Object
        Dim pmPat1 = New SqlParameter("@fecha", SqlDbType.DateTime)
        Dim pmPat2 = New SqlParameter("@fechaentrega", SqlDbType.Date)
        Dim pmPat3 = New SqlParameter("@observaciones", SqlDbType.NVarChar, 255)
        Dim pmPat4 = New SqlParameter("@idempleado", SqlDbType.Int)
        Dim pmPat5 = New SqlParameter("@idtienda", SqlDbType.Int)
        Dim pmPat6 = New SqlParameter("@tipo", SqlDbType.Int)
        Dim pmPat7 = New SqlParameter("@idpedido", SqlDbType.Int)
        Dim pmPat8 = New SqlParameter("@idbodega", SqlDbType.Int)
        Dim pmPat9 = New SqlParameter("@total", SqlDbType.Decimal)
        Dim pmPat10 = New SqlParameter("@nuevopedido", SqlDbType.Int)


        Dim pmPat11 = New SqlParameter("@idPedidoDev", SqlDbType.Int)
        Dim pmPat12 = New SqlParameter("@autorizacion", SqlDbType.Int)
        AbrirConexion()
        If vHayerror Then Return "ERROR"
        cmComand = New SqlCommand(vSp, Cn)
        cmComand.CommandType = CommandType.StoredProcedure
        cmComand.Parameters.Add(pmPat1)
        cmComand.Parameters("@fecha").Direction = ParameterDirection.Input
        cmComand.Parameters("@fecha").Value = Format(vDatos.fechainicial, "dd/MM/yyyy") & " " & Format(vDatos.fechainicial, "HH:mm:ss")
        cmComand.Parameters.Add(pmPat2)
        cmComand.Parameters("@fechaentrega").Direction = ParameterDirection.Input
        cmComand.Parameters("@fechaentrega").Value = vDatos.fechaentrega
        cmComand.Parameters.Add(pmPat3)
        cmComand.Parameters("@observaciones").Direction = ParameterDirection.Input
        cmComand.Parameters("@observaciones").Value = vDatos.observaciones

        cmComand.Parameters.Add(pmPat4)
        cmComand.Parameters("@idempleado").Direction = ParameterDirection.Input
        cmComand.Parameters("@idempleado").Value = vDatos.idEmpleado

        cmComand.Parameters.Add(pmPat5)
        cmComand.Parameters("@idtienda").Direction = ParameterDirection.Input
        cmComand.Parameters("@idtienda").Value = vDatos.idtienda
        cmComand.Parameters.Add(pmPat6)
        cmComand.Parameters("@tipo").Direction = ParameterDirection.Input
        cmComand.Parameters("@tipo").Value = vDatos.tipo
        cmComand.Parameters.Add(pmPat7)
        cmComand.Parameters("@idpedido").Direction = ParameterDirection.Input
        cmComand.Parameters("@idpedido").Value = vDatos.idpedido
        cmComand.Parameters.Add(pmPat8)
        cmComand.Parameters("@idbodega").Direction = ParameterDirection.Input
        cmComand.Parameters("@idbodega").Value = vConexion.vidBodega
        cmComand.Parameters.Add(pmPat9)
        cmComand.Parameters("@total").Direction = ParameterDirection.Input
        cmComand.Parameters("@total").Value = vDatos.total
        cmComand.Parameters.Add(pmPat10)
        cmComand.Parameters("@nuevopedido").Direction = ParameterDirection.Input
        cmComand.Parameters("@nuevopedido").Value = vDatos.nuevopedido.GetHashCode
        cmComand.Parameters.Add(pmPat11)
        cmComand.Parameters("@idPedidoDev").Direction = ParameterDirection.Input
        cmComand.Parameters("@idPedidoDev").Value = vDatos.idPedidoDev
        cmComand.Parameters.Add(pmPat12)
        cmComand.Parameters("@autorizacion").Direction = ParameterDirection.Input
        cmComand.Parameters("@autorizacion").Value = vDatos.autorizacion.GetHashCode

        returnVal = cmComand.ExecuteScalar

        'cmComand.ExecuteNonQuery()
        ''daSelUno.SelectCommand = cmComand
        ''daSelUno.Fill(dsSelUno, "Datos")
        CerrarConexion()
        Return (returnVal)
    End Function

    Private Sub bwProcesoInicialTiendas_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwProcesoInicialTiendas.DoWork
        Dim Cn2 As SqlConnection
        Dim tmpNbdd As String = vConexion.vBdd
        Dim tmpSvbdd As String = vConexion.vServidor
        Dim tmpPsbdd = vConexion.vPasswordbdd
        Dim tmpUsbdd = vConexion.vUsuariobdd
        Dim cmComand As SqlCommand
        Cn2 = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA

        Try
            Cn2.Open()
            Dim daSelUno As New SqlDataAdapter
            Dim dsSelUno As New DataSet
            Dim pmPat As New SqlParameter("@para1", SqlDbType.NVarChar, 200)
            Dim pmPat2 As New SqlParameter("@para2", SqlDbType.NVarChar, 200)
            Dim pmPat3 As New SqlParameter("@para3", SqlDbType.NVarChar, 200)

            '//EjecutarProcedimientoP(1, vConexion.vidBodega, 0, "paBTiendas")
            cmComand = New SqlCommand("paBTiendas", Cn2)
            cmComand.CommandType = CommandType.StoredProcedure
            cmComand.Parameters.Add(pmPat)
            cmComand.Parameters("@para1").Direction = ParameterDirection.Input
            cmComand.Parameters("@para1").Value = "1"
            cmComand.Parameters.Add(pmPat2)
            cmComand.Parameters("@para2").Direction = ParameterDirection.Input
            cmComand.Parameters("@para2").Value = vConexion.vidBodega
            cmComand.Parameters.Add(pmPat3)
            cmComand.Parameters("@para3").Direction = ParameterDirection.Input
            cmComand.Parameters("@para3").Value = "0"
            cmComand.CommandTimeout = 0

            daSelUno.SelectCommand = cmComand
            daSelUno.Fill(dsSelUno, "Datos")
            DTTiendasTodas = Nothing
            DTTiendasTodas = dsSelUno.Tables(0)

            e.Result = "1"
            Cn2.Close()
            Cn2.Dispose()
            Cn2 = Nothing
        Catch ex As SqlException
            XtraMessageBox.Show("Número de error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Result = "0"
        End Try
    End Sub

    Private Sub bwProcesoInicialFacturasCredito_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwProcesoInicialFacturasCredito.DoWork
        Dim Cn2 As SqlConnection
        Dim tmpNbdd As String = vConexion.vBdd
        Dim tmpSvbdd As String = vConexion.vServidor
        Dim tmpPsbdd = vConexion.vPasswordbdd
        Dim tmpUsbdd = vConexion.vUsuariobdd
        Dim cmComand As SqlCommand
        Cn2 = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;Current Language=Spanish;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
        'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA

        Try
            Cn2.Open()
            Dim daSelUno As New SqlDataAdapter
            Dim dsSelUno As New DataSet
            Dim pmPat As New SqlParameter("@para1", SqlDbType.NVarChar, 200)
            Dim pmPat2 As New SqlParameter("@para2", SqlDbType.NVarChar, 200)
            Dim pmPat3 As New SqlParameter("@para3", SqlDbType.NVarChar, 200)


            cmComand = New SqlCommand("paBFacturas", Cn2)
            cmComand.CommandType = CommandType.StoredProcedure
            cmComand.Parameters.Add(pmPat)
            cmComand.Parameters("@para1").Direction = ParameterDirection.Input
            cmComand.Parameters("@para1").Value = vConexion.vidBodega
            cmComand.Parameters.Add(pmPat2)
            cmComand.Parameters("@para2").Direction = ParameterDirection.Input
            cmComand.Parameters("@para2").Value = 0
            cmComand.Parameters.Add(pmPat3)
            cmComand.Parameters("@para3").Direction = ParameterDirection.Input
            cmComand.Parameters("@para3").Value = 1

            daSelUno.SelectCommand = cmComand
            daSelUno.Fill(dsSelUno, "Datos")
            DTFacturasCredito = Nothing
            DTFacturasCredito = dsSelUno.Tables(0)

            e.Result = "1"
            Cn2.Close()
            Cn2.Dispose()
            Cn2 = Nothing
        Catch ex As SqlException
            XtraMessageBox.Show("Número de error: " & ex.ErrorCode & vbCrLf & "Descripción: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Result = "0"
        End Try
    End Sub


End Module
Module movRegistro
    Const vdireccionR As String = "HKEY_LOCAL_MACHINE\software\vinns\sistemamisa"
    Public Function leerRegistro(ByVal vCampo As String) As String
        leerRegistro = ""
        Dim vArchivo As String = Nothing
        vArchivo = vDireccionDocumentos & "\skin.xml"
        Dim m_xmlr As XmlTextReader
        Dim mNombre As String = ""
        'Creamos el XML Reader

        'Application.StartupPath & vDireccion

        If File.Exists(vArchivo) Then
            m_xmlr = New XmlTextReader(vArchivo)
            'Desabilitamos las lineas en blanco,
            'ya no las necesitamos
            m_xmlr.WhitespaceHandling = WhitespaceHandling.None
            'Leemos el archivo y avanzamos al tag de usuarios
            m_xmlr.Read()
            'Leemos el tag usuarios
            m_xmlr.Read()
            'Creamos la secuancia que nos permite
            'leer el archivo
            While Not m_xmlr.EOF
                'Avanzamos al siguiente tag
                m_xmlr.Read()
                'si no tenemos el elemento inicial
                'debemos salir del ciclo
                If Not m_xmlr.IsStartElement() Then
                    Exit While
                End If
                'Obtenemos el elemento codigo
                Dim mCodigo = m_xmlr.GetAttribute("sistema")
                'Read elements firstname and lastname
                m_xmlr.Read()
                'Obtenemos el elemento del Nombre del Usuario
                'leerRegistro = m_xmlr.ReadElementString("sistema")
                m_xmlr.Read()
                leerRegistro = m_xmlr.ReadElementString("skin")
                'vConexion.vipServidor = m_xmlr.ReadElementString("ipservidor")
                'vConexion.vDescripcion = m_xmlr.ReadElementString("descripcion")
                'vConexion.vBdd = m_xmlr.ReadElementString("bdd")
                'vConexion.vtmpServidor = vConexion.vServidor

            End While
            m_xmlr.Close()


        End If
        If leerRegistro = "" Then
            leerRegistro = "Caramel"
        End If
    End Function
    Public Function escribirRegistroFactura(ByVal vDSEncabezado As DataTable, ByVal vDTDetalle As DataTable, ByVal vBoni As Decimal, Optional ByVal vNombre As String = "", Optional ByVal vPrimeraVez As Boolean = True, Optional ByVal vTerminar As Boolean = True) As String


        Dim vArchivo As String = Nothing
        If vNombre = "" Then
            vArchivo = vDireccionDocumentos & "\" & vConexion.vidBodega & "tmpFac" & Now.Day & Now.Month & Now.Year & Now.Hour & Now.Minute & Now.Millisecond & ".xml"
            If File.Exists(vArchivo) Then
                Kill(vArchivo)
            End If
        Else
            If Not Directory.Exists(vDireccionDocumentos & "\XMLVarios") Then
                Directory.CreateDirectory(vDireccionDocumentos & "\XMLVarios")
            End If
            vArchivo = vDireccionDocumentos & "\XMLVarios\" & vNombre & ".xml"
            If vPrimeraVez Then

                If File.Exists(vArchivo) Then
                    Kill(vArchivo)
                End If
            End If
        End If
        Dim myXmlTextWriter As XmlTextWriter
        If vPrimeraVez Then
            myXmlTextWriter = New XmlTextWriter(vArchivo, System.Text.Encoding.UTF8)
        Else
            myXmlTextWriter = myXmlTextWriterCopia
        End If
        If vPrimeraVez Then

            myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
            myXmlTextWriter.WriteStartDocument(True)
            'myXmlTextWriter.WriteComment("VINNS Ideamos Informática")

            myXmlTextWriter.WriteStartElement("plantilla")
            'Crear el elemento de documento principal.


            'Lookup the prefix and then write the ISBN attribute.
            'Dim prefix As String = myXmlTextWriter.LookupPrefix("urn:samples")
            'myXmlTextWriter.WriteStartAttribute(prefix, "ISBN", "urn:samples")
            'myXmlTextWriter.WriteString("1-861003-78")
            myXmlTextWriter.WriteAttributeString("xmlns", "xsi", Nothing, "http://www.w3.org/2001/XMLSchema-instance")
            'myXmlTextWriter.WriteStartElement("item", "http://www.w3.org/2001/XMLSchema-instance")
            'myXmlTextWriter.WriteEndElement()
            'myXmlTextWriter.WriteEndAttribute()
        End If
        If vNombre = "" And vPrimeraVez And vTerminar Then
            vTerminar = False
        End If
        If Not vTerminar Then
            For Each fila In vDSEncabezado.Rows
                myXmlTextWriter.WriteStartElement("documento")
                myXmlTextWriter.WriteStartElement("minimo")

                ''********************ENCABEZADO

                myXmlTextWriter.WriteStartElement("resolucion")
                myXmlTextWriter.WriteString(fila("resolucionserie"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("serie")
                myXmlTextWriter.WriteString(fila("serie"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("numero")
                myXmlTextWriter.WriteString(fila("correlativo"))
                myXmlTextWriter.WriteEndElement()

                'myXmlTextWriter.WriteStartElement("moneda")
                'myXmlTextWriter.WriteString("1")
                'myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("moneda")
                myXmlTextWriter.WriteString("GTQ")
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("identificador")
                myXmlTextWriter.WriteString("FACE")
                myXmlTextWriter.WriteEndElement()

                Dim vNitFormato As String = ""
                ''For y As Integer = 1 To Len(fila("nit"))
                If UCase(fila("nit")) = "C.F." Or UCase(fila("nit")) = "C/F" Or UCase(fila("nit")) = "CF" Or UCase(fila("nit")) = "C.F" Then
                    vNitFormato = "CF"

                Else
                    vNitFormato = fila("nit")

                End If
                ''Next

                myXmlTextWriter.WriteStartElement("nit_contribuyente")
                myXmlTextWriter.WriteCData(vNitFormato)
                myXmlTextWriter.WriteEndElement()


                myXmlTextWriter.WriteStartElement("nombre_contribuyente")
                myXmlTextWriter.WriteCData(fila("cliente"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("direccion_contribuyente")
                myXmlTextWriter.WriteCData(fila("direccion"))
                myXmlTextWriter.WriteEndElement()

                Dim vFec As Date = fila("fecha")
                myXmlTextWriter.WriteStartElement("dia_emision")
                myXmlTextWriter.WriteString(Format(vFec, "dd"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("mes_emision")
                myXmlTextWriter.WriteString(Format(vFec, "MM"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("anio_emision")
                myXmlTextWriter.WriteString(Year(vFec))
                myXmlTextWriter.WriteEndElement()
                Dim vTotalBruto As Decimal = 0.0
                Dim vTotalBoni As Decimal = 0.0
                Dim vDRTmpo As DataRow()
                vDRTmpo = vDTDetalle.Select("correlativo=" & fila("idVenta"))
                For i As Integer = 0 To vDRTmpo.GetUpperBound(0)
                    vTotalBruto += vDRTmpo(i)("total")
                    If Mid(vDRTmpo(i)("productofactura"), 1, 1) = "*" Then
                        vTotalBoni += vDRTmpo(i)("total")
                    End If
                Next
                Dim vIvaTmpo As Decimal = Format(((vTotalBruto - vBoni) / 1.12) * 0.12, "#####0.00")
                vTotalBruto = FormatNumber(vTotalBruto, 2)
                vTotalBoni = FormatNumber(vTotalBoni, 2)
                myXmlTextWriter.WriteStartElement("valor_neto")
                myXmlTextWriter.WriteString(Format(vTotalBruto - vBoni - vIvaTmpo, "#####0.00"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("iva")
                myXmlTextWriter.WriteString(Format(vIvaTmpo))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("monto_exento")
                myXmlTextWriter.WriteString("0")
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("total")
                myXmlTextWriter.WriteString(Format((vTotalBruto - vBoni), "#####0.00"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("descuento")
                myXmlTextWriter.WriteString(vTotalBoni)
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("estado")
                myXmlTextWriter.WriteString("E")
                myXmlTextWriter.WriteEndElement()
                ''********************************DETALLE

                myXmlTextWriter.WriteStartElement("detalle")


                Dim vDRDatos As DataRow()
                vDRDatos = vDTDetalle.Select("correlativo=" & fila("idVenta"))
                For i As Integer = 0 To vDRDatos.GetUpperBound(0)


                    myXmlTextWriter.WriteStartElement("definicion")

                    myXmlTextWriter.WriteStartElement("cantidad")
                    myXmlTextWriter.WriteString(vDRDatos(i)("cantidad"))
                    myXmlTextWriter.WriteEndElement()

                    myXmlTextWriter.WriteStartElement("metrica")
                    myXmlTextWriter.WriteString(vDRDatos(i)("presentacion"))
                    myXmlTextWriter.WriteEndElement()

                    myXmlTextWriter.WriteStartElement("descripcion")
                    ''quitar los "*"
                    Dim vDEtalle As String = ""
                    Dim vDescip As String = vDRDatos(i)("productofactura")
                    If Mid(vDescip, 1, 2) = "**" Then
                        vDescip = Mid(vDescip, 3, vDescip.Length)
                        vDEtalle = "**"
                    ElseIf Mid(vDescip, 1, 1) = "*" Then
                        vDescip = Mid(vDescip, 2, vDescip.Length)
                        vDEtalle = "*"
                    End If
                    myXmlTextWriter.WriteString(vDescip)
                    myXmlTextWriter.WriteEndElement()

                    myXmlTextWriter.WriteStartElement("precio_unitario")
                    myXmlTextWriter.WriteString(Format(vDRDatos(i)("precioventa"), "#####0.00"))
                    myXmlTextWriter.WriteEndElement()

                    myXmlTextWriter.WriteStartElement("valor")
                    myXmlTextWriter.WriteString(Format(vDRDatos(i)("total"), "#####0.00"))
                    myXmlTextWriter.WriteEndElement()

                    myXmlTextWriter.WriteStartElement("impuesto")
                    myXmlTextWriter.WriteString("")
                    myXmlTextWriter.WriteEndElement()

                    myXmlTextWriter.WriteStartElement("detalle")
                    myXmlTextWriter.WriteString(vDEtalle)
                    myXmlTextWriter.WriteEndElement()
                    ''***********************FIN DETALLE
                    myXmlTextWriter.WriteEndElement() '' fin definicion -- en detalle
                Next


                myXmlTextWriter.WriteEndElement() '' fin detall ---  en detalle


                'Cerrar el elemento primario.
                myXmlTextWriter.WriteEndElement() '' fin de minimo -- en encabezado

                myXmlTextWriter.WriteStartElement("opcional")

                myXmlTextWriter.WriteStartElement("opcional1") '' codigo tienda
                myXmlTextWriter.WriteString(fila("codigot"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("opcional2") '' correlativo pedido y orden
                myXmlTextWriter.WriteString(fila("correlativo2"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("opcional3") ''nombre o codigo vendedor
                myXmlTextWriter.WriteString(fila("vendedor"))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("opcional4") ''pago
                myXmlTextWriter.WriteString("-")
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("opcional5") ''telefono
                myXmlTextWriter.WriteString("-")
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("opcional6") ''puntos de esta factura
                myXmlTextWriter.WriteString("0")
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("opcional7") ''acumulado
                myXmlTextWriter.WriteString("0")
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteStartElement("total_letras")
                myXmlTextWriter.WriteString(RegistroEnLetras(vTotalBruto - vBoni))
                myXmlTextWriter.WriteEndElement()

                myXmlTextWriter.WriteEndElement() ''fin de opcional

                myXmlTextWriter.WriteEndElement() '' fin de documento -- en encabezado
            Next
        End If
        'Cerrar el elemento book.
        'Cerrar el elemento book.
        'Cerrar el elemento primario bookstore.
        'If vPrimeraVez Then
        myXmlTextWriterCopia = Nothing
        myXmlTextWriterCopia = myXmlTextWriter
        'End If
        If vTerminar Then
            myXmlTextWriter.Flush()
            myXmlTextWriter.Close()
            myXmlTextWriterCopia = Nothing
        End If
        If vNombre = "" And vPrimeraVez And Not vTerminar Then
            myXmlTextWriter.Flush()
            myXmlTextWriter.Close()
        End If
        ' MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
        Return vArchivo
    End Function
    Public Sub escribirRegistro(ByVal vCampo As String, ByVal vValor As String)
        '' ''Dim user As String = Environment.UserDomainName & "\" & Environment.UserName

        '' ''Dim rs As New RegistrySecurity()

        ' '' '' Allow the current user to read and delete the key.
        ' '' ''
        '' ''rs.AddAccessRule(New RegistryAccessRule(user, _
        '' ''    RegistryRights.ReadKey Or RegistryRights.Delete Or RegistryRights.FullControl Or RegistryRights.ChangePermissions, _
        '' ''    InheritanceFlags.None, _
        '' ''    PropagationFlags.None, _
        '' ''    AccessControlType.Allow))

        ' '' '' Prevent the current user from writing or changing the
        ' '' '' permission set of the key. Note that if Delete permission
        ' '' '' were not allowed in the previous access rule, denying
        ' '' '' WriteKey permission would prevent the user from deleting the 
        ' '' '' key.
        '' ''rs.AddAccessRule(New RegistryAccessRule(user, _
        '' ''    RegistryRights.WriteKey Or RegistryRights.ChangePermissions, _
        '' ''    InheritanceFlags.None, _
        '' ''    PropagationFlags.None, _
        '' ''    AccessControlType.Deny))
        '' ''Dim rk As RegistryKey = Nothing
        '' ''Try
        '' ''    'Registry.LocalMachine.DeleteSubKey(vCampo)
        '' ''    rk = Registry.CurrentUser.CreateSubKey("vinns2", _
        '' ''        RegistryKeyPermissionCheck.Default, rs)
        '' ''    Console.WriteLine(vbCrLf & "Example key created.")
        '' ''    rk.SetValue(vCampo, vValor)
        '' ''Catch ex As Exception
        '' ''    Console.WriteLine(vbCrLf & "Unable to create the example key: {0}", ex)
        '' ''End Try

        '' ''If rk IsNot Nothing Then rk.Close()

        ' '' '' ''Dim a As RegistryKey = Registry.LocalMachine
        ' '' '' ''a = Registry.LocalMachine.OpenSubKey("software\vinns\farmalider", RegistryKeyPermissionCheck.Default)
        ' '' '' ''a.SetValue(vCampo, vValor)
        ' '' '' a.OpenSubKey("software\vinns\farmalider", True, rs)

        Dim vArchivo As String = Nothing
        vArchivo = vDireccionDocumentos & "\skin.xml"
        Kill(vArchivo)
        Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter(vArchivo, System.Text.Encoding.UTF8)
        myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
        myXmlTextWriter.WriteStartDocument(False)
        myXmlTextWriter.WriteComment("VINNS Ideamos Informática")
        'Crear el elemento de documento principal.
        myXmlTextWriter.WriteStartElement("vinns")
        myXmlTextWriter.WriteStartElement("sistema", "Twain", "id")

        'Crear un elemento llamado 'title' con un nodo de texto
        ' y cerrar el elemento.
        myXmlTextWriter.WriteStartElement("skin")
        myXmlTextWriter.WriteString(vValor)
        myXmlTextWriter.WriteEndElement()

        ''Crear un elemento llamado 'Author'.
        'myXmlTextWriter.WriteStartElement("Author")

        ''Crear un elemento llamado 'first-name' con un nodo de texto
        '' y cerrarlo en una línea.
        'myXmlTextWriter.WriteElementString("first-name", "Mark")

        ''Crear un elemento llamado 'first-name' con un nodo de texto.
        'myXmlTextWriter.WriteElementString("last-name", "Twain")

        'Cerrar el elemento primario.
        myXmlTextWriter.WriteEndElement()

        ''Crear un elemento llamado 'price' con un nodo de texto
        '' y cerrarlo en una línea.
        'myXmlTextWriter.WriteElementString("price", "7.99")

        'Cerrar el elemento book.
        'Cerrar el elemento book.
        'Cerrar el elemento primario bookstore.
        myXmlTextWriter.Flush()
        myXmlTextWriter.Close()
        ' MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.Personal))

    End Sub
    Public Sub configuracionINICIAL(ByVal vSource As String, ByVal vBdd As String, ByVal vUsuario As String, ByVal vClave As String, ByVal vIdEmpresa As String, ByVal vAct As String)

        If Not Directory.Exists(vDireccionDocumentos) Then
            Directory.CreateDirectory(vDireccionDocumentos)
            'Directory.CreateDirectory(vdireccionR)
        End If
        Dim vArchivo As String = Nothing
        vArchivo = vDireccionDocumentos & "\config_server.xml"

        If File.Exists(vArchivo) Then
            Kill(vArchivo)
        End If
        If File.Exists(vDireccionDocumentos & "\configserver.xml") Then
            Kill(vDireccionDocumentos & "\configserver.xml")
        End If
        Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter(vArchivo, System.Text.Encoding.UTF8)
        myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
        myXmlTextWriter.WriteStartDocument(False)
        myXmlTextWriter.WriteComment("VINNS Ideamos Informática")
        'Crear el elemento de documento principal.
        myXmlTextWriter.WriteStartElement("vinns")
        myXmlTextWriter.WriteStartElement("sistema", "Twain", "id")

        'Crear un elemento llamado 'title' con un nodo de texto
        ' y cerrar el elemento.
        myXmlTextWriter.WriteStartElement("source")
        myXmlTextWriter.WriteString(vSource)
        myXmlTextWriter.WriteEndElement()
        myXmlTextWriter.WriteStartElement("bdd")
        myXmlTextWriter.WriteString(vBdd)
        myXmlTextWriter.WriteEndElement()
        myXmlTextWriter.WriteStartElement("usuario")
        myXmlTextWriter.WriteString(vUsuario)
        myXmlTextWriter.WriteEndElement()
        myXmlTextWriter.WriteStartElement("clave")
        myXmlTextWriter.WriteString(vClave)
        myXmlTextWriter.WriteEndElement()
        myXmlTextWriter.WriteStartElement("idEmpresa")
        myXmlTextWriter.WriteString(vIdEmpresa)
        myXmlTextWriter.WriteEndElement()

        myXmlTextWriter.WriteStartElement("numAct")
        myXmlTextWriter.WriteString(vAct)
        myXmlTextWriter.WriteEndElement()

        myXmlTextWriter.Flush()
        myXmlTextWriter.Close()


    End Sub
    Public Sub configuracionCAJA(ByVal vID As String)

        If Not Directory.Exists(vDireccionDocumentos) Then
            Directory.CreateDirectory(vDireccionDocumentos)
            'Directory.CreateDirectory(vdireccionR)
        End If
        Dim vArchivo As String = Nothing
        vArchivo = vDireccionDocumentos & "\confcaja.xml"

        If File.Exists(vArchivo) Then
            Kill(vArchivo)
        End If
        Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter(vArchivo, System.Text.Encoding.UTF8)
        myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
        myXmlTextWriter.WriteStartDocument(False)
        myXmlTextWriter.WriteComment("VINNS Ideamos Informática")
        'Crear el elemento de documento principal.
        myXmlTextWriter.WriteStartElement("vinns")
        myXmlTextWriter.WriteStartElement("sistema", "Twain", "id")

        'Crear un elemento llamado 'title' con un nodo de texto
        ' y cerrar el elemento.
        myXmlTextWriter.WriteStartElement("caja")
        myXmlTextWriter.WriteString(vID)
        myXmlTextWriter.WriteEndElement()

        myXmlTextWriter.Flush()
        myXmlTextWriter.Close()


    End Sub
End Module
Module MD5Encriptar
    Function codificarHash(ByVal vValor As String) As String
        Dim md5obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytestoHash() As Byte = System.Text.Encoding.ASCII.GetBytes(vValor)
        bytestoHash = md5obj.ComputeHash(bytestoHash)
        Dim strResultado As String = ""
        For Each x As Byte In bytestoHash
            strResultado += x.ToString("x2")
        Next
        Return strResultado
    End Function
End Module
Module EncriptacionVinns
    Public Function EncryptString(ByVal Text As String, ByVal UserKey As String, ByVal Action As Single) As String
        Dim UserKeyX As String = ""
        Dim Temp As Integer
        Dim Times As Integer = 0
        Dim i As Integer
        Dim j As Integer
        Dim n As Integer
        Dim rtn As String = ""
        Dim UserKeyASCIIS()
        '//Obtiene el valor del caracter
        n = Len(UserKey)
        ReDim UserKeyASCIIS(n)
        For i = 1 To n
            UserKeyASCIIS(i) = Asc(Mid$(UserKey, i, 1))
        Next

        '//Obtiene el valor del texto
        Dim TextASCIIS() As Integer
        ReDim TextASCIIS(Len(Text))
        For i = 1 To Len(Text)
            TextASCIIS(i) = Asc(Mid$(Text, i, 1))
        Next

        '//Encriptar o desencriptar
        If Action = ENCRYPT Then
            For i = 1 To Len(Text)
                j = IIf(j + 1 >= n, 1, j + 1)
                Temp = TextASCIIS(i) + UserKeyASCIIS(j)
                If Temp > 255 Then
                    Temp = Temp - 255
                End If
                rtn = rtn + Chr(Temp)
            Next
        ElseIf Action = DECRYPT Then
            For i = 1 To Len(Text)
                j = IIf(j + 1 >= n, 1, j + 1)
                Temp = TextASCIIS(i) - UserKeyASCIIS(j)
                If Temp < 0 Then
                    Temp = Temp + 255
                End If
                rtn = rtn + Chr(Temp)
            Next
        End If


        EncryptString = rtn
    End Function
End Module
Module variablesG

    Public DTProductos As DataTable
    Public DTTiendasTodas As DataTable
    Public DTFacturasCredito As DataTable
    Public DTPermisos As DataTable
    Public DTUsuario As DataTable
    Public DTTiendaCredito As DataTable
    Public DTSeries As DataTable
    Public DTBodega As DataTable
    Public DTEMPRESAS As DataTable
End Module
Module llenarDataSet
    Public Sub llenarDTVersionAct()
        ' ''Dim dtVersionAct As DataTable
        ' ''dtVersionAct = Nothing
        ' ''dtVersionAct = EjecutarSelect("select * from tversiones where actual=1")
        ' ''If dtVersionAct.Rows.Count > 0 Then
        ' ''    vVERSIONACT.descripcion = dtVersionAct.Rows(0).Item("Descripcion")
        ' ''    vVERSIONACT.idversion = dtVersionAct.Rows(0).Item("idVersion")
        ' ''    If dtVersionAct.Rows(0).Item("compra") = 0 Then
        ' ''        vVERSIONACT.foto = convImagenBDD(dtVersionAct.Rows(0).Item("foto"))
        ' ''        vVERSIONACT.compra = 0
        ' ''    Else
        ' ''        vVERSIONACT.foto = convImagenBDD(dtVersionAct.Rows(0).Item("foto2"))
        ' ''        vVERSIONACT.compra = 1
        ' ''    End If
        ' ''End If
        ' ''Dim dtResolucion As DataTable = Nothing
        ' ''dtResolucion = EjecutarSelect("select * from tresoluciones where activa=1")
        ' ''If dtResolucion.Rows.Count > 0 Then
        ' ''    vVERSIONACT.idresolucion = dtResolucion.Rows(0).Item("idResolucion")
        ' ''    vVERSIONACT.numeroresolucion = dtResolucion.Rows(0).Item("descripcion")
        ' ''Else
        ' ''    vVERSIONACT.idresolucion = 0
        ' ''End If
    End Sub
    Public Sub llenarDTTiendaCredito(ByVal idTienda)
        Try

        
            DTTiendaCredito = Nothing
            DTTiendaCredito = EjecutarProcedimientoP(13, vConexion.vidBodega, idTienda, "paBTiendas")
        Catch ex As Exception
            DTTiendaCredito = Nothing
            XtraMessageBox.Show("Error: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub llenarDTPermisos(ByVal idG)
        DTPermisos = Nothing
        DTPermisos = EjecutarSelect("select * from tpermisos where idgrupo=" & idG)
    End Sub

    Public Sub llenarDTTiendas()
        DTTiendasTodas = Nothing
        If Not bwProcesoInicialTiendas.IsBusy Then

            bwProcesoInicialTiendas.RunWorkerAsync()
        End If

    End Sub
    Public Sub llenarDTProductos()
        DTProductos = Nothing
        'Try
        '    DTProductos = EjecutarProcedimientoP("2", vConexion.vidBodega, "0", "paBProductos")
        'Catch ex As Exception
        '    'DTProductos = EjecutarSelect("select top " & vNum & " * from tordenes where anulada=0 and operado=0")
        'End Try
        If Not bwProcesoInicial.IsBusy Then
            bwProcesoInicial.RunWorkerAsync()
        End If

    End Sub
    Public Sub llenarDTFactuasCredito()
        DTFacturasCredito = Nothing
        If Not bwProcesoInicialFacturasCredito.IsBusy Then
            bwProcesoInicialFacturasCredito.RunWorkerAsync()
        End If
    End Sub
    Public Sub llenarDTSeries()
        Try
            DTSeries = Nothing
            DTSeries = EjecutarSelect("select * from tseries where habilitada=1 and tipo=1")
        Catch ex As Exception
            DTSeries = Nothing
            XtraMessageBox.Show("Error: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
Module mdFORMAS
    Public Sub cargarFormulario(ByRef qFormulario As Form, ByRef vFormPrincipal As Form)

        'Dim doc As frmProductos = New frmProductos()
        qFormulario.Text = qFormulario.Text & " " & (vFormPrincipal.MdiChildren.Length + 1).ToString()
        qFormulario.MdiParent = vFormPrincipal
        qFormulario.WindowState = FormWindowState.Maximized
        qFormulario.ShowInTaskbar = False

        qFormulario.Show()
        qFormulario.Update()

        'qFormulario.Dispose()
    End Sub

    Public Function XtraInputBox(ByRef Etiqueta As String, ByRef vLabel As String, Optional ByRef vTexto As String = "", Optional ByVal vCaracter As String = "", Optional ByVal esNumero As Boolean = False) As String
        Dim frmTmpo As frmInputBox = New frmInputBox(Etiqueta, vLabel, vTexto, vCaracter, esNumero)
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then
            XtraInputBox = frmTmpo.resultadoInput
        Else
            XtraInputBox = ""
        End If
        frmTmpo.Dispose()
        Return XtraInputBox
    End Function
End Module
Module IMAGENES
    Public Sub GuardarImagen(ByVal vidAl As Integer, ByVal pbFoto1 As DevExpress.XtraEditors.PictureEdit)
        Dim fsFoto As FileStream
        Dim vPath As String = vDireccionDocumentos & "\fototmpo.jpg" '"C:\VINNS\Farmalider\bin\Debug"
        'vPath = pbFoto1.ImageLocation
        Dim curFilename As String
        curFilename = vPath

        pbFoto1.Image.Save(vPath)
        Dim fiFoto As FileInfo = New FileInfo(curFilename)
        Dim Temp As Long = fiFoto.Length
        Dim lung As Long = Convert.ToInt32(Temp)
        Dim picture(lung) As Byte

        Dim comando As New SqlClient.SqlCommand
        Dim parametro As New SqlClient.SqlParameter
        Dim idAl As New SqlClient.SqlParameter

        fsFoto = New FileStream(curFilename, FileMode.Open)
        fsFoto.Read(picture, 0, lung)
        fsFoto.Close()

        AbrirConexion()
        comando.Connection = Cn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "paGuardarImagen"
        parametro = comando.Parameters.Add("@foto", SqlDbType.Image)
        parametro.Value = picture
        idAl = comando.Parameters.Add("@idProducto", SqlDbType.Int)
        idAl.Value = vidAl
        comando.ExecuteNonQuery()
        CerrarConexion()
        On Error Resume Next
        Kill(vPath)
    End Sub
    Public Function CargarImagen(ByVal vCod As Integer) As Image
        Dim pbFoto As DevExpress.XtraEditors.PictureEdit = New DevExpress.XtraEditors.PictureEdit
        'Dim fototmpo As PictureBox = New PictureBox

        Try
            AbrirConexion()
            Dim cmImagen As New SqlCommand
            Dim vPar As New SqlParameter("@Pat", SqlDbType.Int)
            Dim daFoto As New SqlClient.SqlDataAdapter '("spCargarImagen", Cn)
            Dim dsFoto As New DataSet()

            cmImagen = New SqlCommand("paCargarImagen", Cn)
            cmImagen.CommandType = CommandType.StoredProcedure
            cmImagen.Parameters.Add(vPar)
            cmImagen.Parameters("@Pat").Direction = ParameterDirection.Input
            cmImagen.Parameters("@Pat").Value = vCod

            daFoto.SelectCommand = cmImagen
            daFoto.Fill(dsFoto, "imagen")
            If IsDBNull(dsFoto.Tables(0).Rows(0).Item(0)) Then
                Return Nothing
            End If

            Dim bits As Byte() = CType(dsFoto.Tables(0).Rows(0).Item(0), Byte())
            Dim memorybits As New MemoryStream(bits)
            Dim bitmap As New Bitmap(memorybits)



            'fototmpo.Image = bitmap
            pbFoto.Image = bitmap

            dsFoto.Dispose()
            daFoto.Dispose()
            CerrarConexion()
            Return pbFoto.Image
            'curFileName = pbFoto.ImageLocation
        Catch EX As Exception
            XtraMessageBox.Show(EX.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show(EX.Message) ', "No se puede mostrar fotografia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'pbFoto.Image = Nothing
            'pbFoto.Refresh()
            Return Nothing
        End Try
MensajeFoto:

        If Err.Number = 13 Then


        End If

    End Function
    Public Function convImagenBDD(ByVal vPic As Byte()) As Image
        If Not IsDBNull(vPic) Then
            Dim bits As Byte() = CType(vPic, Byte())
            Dim memorybits As New MemoryStream(bits)
            Dim bitmap As New Bitmap(memorybits)



            'fototmpo.Image = bitmap
            Return bitmap
            'picFoto.Image = DRModificarPersona("foto")
        Else
            Return My.Resources.farmalider
        End If
    End Function
    Public Sub guardarArchivobdd(ByVal direcF As String, ByVal vidAl As String, Optional ByVal vTipo As Integer = 1)

        Dim fsFoto As FileStream
        'Dim vPath As String = Nothing '"C:\VINNS\Farmalider\bin\Debug"
        'If vTipo = 1 Then
        '    vPath = Application.StartupPath & "\doctmpo.vns"
        'Else
        '    vPath = Application.StartupPath & "\docrtmpo.vns"
        'End If
        'vPath = pbFoto1.ImageLocation
        Dim curFilename As String
        curFilename = direcF

        'pbFoto1.Image.Save(vPath)
        Dim fiFoto As FileInfo = New FileInfo(curFilename)
        Dim Temp As Long = fiFoto.Length
        Dim lung As Long = Convert.ToInt32(Temp)
        Dim picture(lung) As Byte

        Dim comando As New SqlClient.SqlCommand
        Dim parametro As New SqlClient.SqlParameter
        Dim idAl As New SqlClient.SqlParameter
        Dim pvtipo As New SqlClient.SqlParameter
        fsFoto = New FileStream(curFilename, FileMode.Open)
        fsFoto.Read(picture, 0, lung)
        fsFoto.Close()

        AbrirConexion()


        comando.Connection = Cn
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "paGuardarArchivos"
        parametro = comando.Parameters.Add("@foto", SqlDbType.Image)
        parametro.Value = picture
        idAl = comando.Parameters.Add("@idHistorial", SqlDbType.Int)
        idAl.Value = vidAl
        pvtipo = comando.Parameters.Add("@vtipo", SqlDbType.Int)
        pvtipo.Value = vTipo
        comando.ExecuteNonQuery()
        CerrarConexion()
        If File.Exists(direcF) Then
            Kill(direcF)
        End If

    End Sub
    Public Sub cargarArchivobdd(ByVal idHisto As String, Optional ByVal vTipo As Integer = 1)

        AbrirConexion()
        Dim cmArchivo As New SqlCommand
        Dim vPar As New SqlParameter("@idHistorial", SqlDbType.Int)
        Dim vPar2 As New SqlParameter("@vtipo", SqlDbType.Int)
        Dim daFoto As New SqlClient.SqlDataAdapter '("spCargarImagen", Cn)
        Dim dsFoto As New DataSet()

        cmArchivo = New SqlCommand("paCargarArchivos", Cn)
        cmArchivo.CommandType = CommandType.StoredProcedure
        cmArchivo.Parameters.Add(vPar)
        cmArchivo.Parameters("@idHistorial").Direction = ParameterDirection.Input
        cmArchivo.Parameters("@idHistorial").Value = idHisto

        cmArchivo.Parameters.Add(vPar2)
        cmArchivo.Parameters("@vtipo").Direction = ParameterDirection.Input
        cmArchivo.Parameters("@vtipo").Value = vTipo

        daFoto.SelectCommand = cmArchivo
        daFoto.Fill(dsFoto, "documento")
        If IsDBNull(dsFoto.Tables(0).Rows(0).Item(0)) Then
            If File.Exists(vDireccionDocumentos & "\cargartmp.vns") Then
                Kill(vDireccionDocumentos & "\cargartmp.vns")
            End If
            If File.Exists(vDireccionDocumentos & "\recettmp.vns") Then
                Kill(vDireccionDocumentos & "\recettmp.vns")
            End If
            Exit Sub
        End If
        Dim bits As Byte() = CType(dsFoto.Tables(0).Rows(0).Item(0), Byte())
        Dim memorybits As New MemoryStream(bits)
        Select Case vTipo
            Case 1
                If File.Exists(vDireccionDocumentos & "\cargartmp.vns") Then
                    Kill(vDireccionDocumentos & "\cargartmp.vns")
                End If

                Dim f As FileStream = New FileStream(vDireccionDocumentos & "\cargartmp.vns", FileMode.CreateNew)
                f.Write(bits, 0, bits.Length)
                f.Close()

            Case 2
                If File.Exists(vDireccionDocumentos & "\recettmp.vns") Then
                    Kill(vDireccionDocumentos & "\recettmp.vns")
                End If

                Dim f As FileStream = New FileStream(vDireccionDocumentos & "\recettmp.vns", FileMode.CreateNew)
                f.Write(bits, 0, bits.Length)
                f.Close()
        End Select



        'Dim a As New DevExpress.XtraRichEdit.RichEditControl


        'Dim r As DevExpress.XtraRichEdit.RichEditControl = New DevExpress.XtraRichEdit.RichEditControl
        'r.LoadDocument(Application.StartupPath & "\cargartmp.vns", DevExpress.XtraRichEdit.DocumentFormat.Rtf)

        'Dim bitmap As New Bitmap(memorybits)



        'fototmpo.Image = bitmap
        'pbFoto.Image = bitmap

        dsFoto.Dispose()
        daFoto.Dispose()
        CerrarConexion()

        '        Return r

        '        On Error Resume Next
        'Kill(vPath)

    End Sub
End Module
Namespace namespace4BITS
    Friend NotInheritable Class PRINCIPAL
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread()> _
        Shared Sub Main()
            'DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Courier New", 12)

            'Dim vArchivo As String = vDireccionDocumentos & "\skin.xml" 'Application.StartupPath & "\skin.xml"
            'If Not Directory.Exists(vDireccionDocumentos) Then
            '    Directory.CreateDirectory(vDireccionDocumentos)
            'End If
            ''DevExpress.UserSkins.OfficeSkins.Register()
            ''DevExpress.UserSkins.BonusSkins.Register()
            'DevExpress.UserSkins.BonusSkins.Register()
            'DevExpress.Skins.SkinManager.EnableFormSkins()

            'Application.EnableVisualStyles()
            'Application.SetCompatibleTextRenderingDefault(False)

            'If Not File.Exists(vArchivo) Then
            '    Dim myXmlTextWriter As XmlTextWriter = New XmlTextWriter(vArchivo, System.Text.Encoding.UTF8)
            '    myXmlTextWriter.Formatting = System.Xml.Formatting.Indented
            '    myXmlTextWriter.WriteStartDocument(False)
            '    myXmlTextWriter.WriteComment("VINNS Ideamos Informática")
            '    'Crear el elemento de documento principal.
            '    myXmlTextWriter.WriteStartElement("vinns")
            '    myXmlTextWriter.WriteStartElement("sistema", "Twain", "id")

            '    'Crear un elemento llamado 'title' con un nodo de texto
            '    ' y cerrar el elemento.
            '    myXmlTextWriter.WriteStartElement("skin")
            '    myXmlTextWriter.WriteString("Caramel")
            '    myXmlTextWriter.WriteEndElement()

            '    myXmlTextWriter.WriteEndElement()
            '    myXmlTextWriter.Flush()
            '    myXmlTextWriter.Close()



            'End If




            '''' If dlg = DialogResult.OK Then
            Application.Run(New frmPrincipal())
            ''''End If


            ' Catch ex As Exception
            'Return
            ' End Try
        End Sub

    End Class

End Namespace
'Public Class vinnsDLG
'    Inherits DevExpress.XtraEditors.XtraForm

'    Private Dlg As DevExpress.Utils.WaitDialogForm = Nothing

'    Public Sub CreateWaitDialog()
'        Dlg = New DevExpress.Utils.WaitDialogForm("Cargando Componentes...")
'    End Sub

'    Public Sub SetWaitDialogCaption(ByVal fCaption As String)
'        If Dlg IsNot Nothing Then
'            Dlg.Caption = fCaption
'        End If
'    End Sub

'    Protected Overloads Overrides Sub OnLoad(ByVal e As EventArgs)
'        MyBase.OnLoad(e)
'        If Dlg IsNot Nothing Then
'            Dlg.Close()
'        End If
'    End Sub
'End Class