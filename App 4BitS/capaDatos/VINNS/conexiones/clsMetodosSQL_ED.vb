Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Namespace VINNS.conexiones
    Public Class clsMetodosSQL_ED
        Implements IDisposable

#Region "Variables privadas/protegidas"
        Private gMSGError As String = String.Empty
        Private gEsError As Boolean = False
        Private gTransaccion As SqlTransaction
        Private gConexionSQL As New SqlConnection()
        Private gCMDsql1 As New SqlCommand()
        Private gCMDsql2 As New SqlCommand()
        Private dsRespuesta As New DataSet
        Private gDatoDevuelto As String = String.Empty

        Private gDisposed As Boolean = False
        Private gNombreProcedimiento1 As String = String.Empty
        Private gNombreProcedimiento2 As String = String.Empty

        Private gTablaDetalle As New DataTable
        Private gDatosOBJ() As Object
        Private gFilasAInsertar As Object
        Private gCadenaConexion As New clsDatosConexionSQL()


#End Region

#Region "Propiedades"

        ReadOnly Property mensajeError As String
            Get
                Return gMSGError
            End Get
        End Property

        ReadOnly Property existeError As Boolean
            Get
                Return gEsError
            End Get
        End Property

        ReadOnly Property datoDevuelto As String
            Get
                Return gDatoDevuelto
            End Get
        End Property

        ReadOnly Property devolverDataSet As DataSet
            Get
                Return dsRespuesta
            End Get
        End Property

#End Region

#Region "Métodos privados"

        Private Sub cerrarConexion(ByVal pTodoCorrecto As Boolean)
            If pTodoCorrecto Then
                If gTransaccion IsNot Nothing Then
                    If gTransaccion.Connection.State = ConnectionState.Open Then gTransaccion.Rollback()
                End If
                If gConexionSQL.State = ConnectionState.Open Then gConexionSQL.Close()
            Else
                If gTransaccion IsNot Nothing Then
                    If gTransaccion.Connection IsNot Nothing Then
                        If gTransaccion.Connection.State = ConnectionState.Open Then gTransaccion.Commit()
                    End If
                End If
                If gConexionSQL.State = ConnectionState.Open Then gConexionSQL.Close()
            End If
        End Sub

#End Region

#Region "Métodos públicos"

        Public Sub generoError(ByVal pMensajeDeError As String)
            Me.gMSGError = pMensajeDeError
            Me.gMSGError = True
        End Sub


        Protected Sub constructor()
            gNombreProcedimiento1 = String.Empty
            gNombreProcedimiento2 = String.Empty
            gDatosOBJ = Nothing
            gTablaDetalle = Nothing
            gFilasAInsertar = Nothing
        End Sub


        Public Sub New(ByVal pNombreProcedimientoUno As String, ByVal pNombreProcedimientoDos As String, ByVal pTablaDetalle As DataTable, ParamArray pParametrosPrimerProcedimiento() As Object)
            MyBase.New()
            constructor()
            gNombreProcedimiento1 = pNombreProcedimientoUno
            gNombreProcedimiento2 = pNombreProcedimientoDos
            gTablaDetalle = pTablaDetalle
            gDatosOBJ = pParametrosPrimerProcedimiento
        End Sub


        '-------------------------

        Public Sub reasignarDatosProcedimientos(ByVal pNombreProcedimientoUno As String, ByVal pNombreProcedimientoDos As String, ByVal pTablaDetalle As DataTable, ParamArray pParametrosPrimerProcedimiento() As Object)
            gNombreProcedimiento1 = pNombreProcedimientoUno
            gNombreProcedimiento2 = pNombreProcedimientoDos
            gTablaDetalle = pTablaDetalle
            gDatosOBJ = pParametrosPrimerProcedimiento
        End Sub


        Public Sub reasignarDatosProcedimientosDos(ByVal pNombreProcedimientoUno As String, ByVal pNombreProcedimientoDos As String, ByVal pTablaDetalle As DataTable, ParamArray pParametrosPrimerProcedimiento() As Object)
            gNombreProcedimiento1 = pNombreProcedimientoUno
            gNombreProcedimiento2 = pNombreProcedimientoDos
            gTablaDetalle = pTablaDetalle
            gDatosOBJ = pParametrosPrimerProcedimiento
        End Sub


        Public Sub reasignarDatosProcedimientoUno(ByVal pNombreProcedimientoDos As String, ByVal pTablaDetalle As DataTable)
            gNombreProcedimiento1 = pNombreProcedimientoDos
            gTablaDetalle = pTablaDetalle
        End Sub

        Public Sub asignarFilasAInsertar(ParamArray pNoDeFilasAInsertar() As Object)
            gFilasAInsertar = pNoDeFilasAInsertar
        End Sub

        '---------------------

        Private Function obtenerDato(ByVal pTabla As String, ByVal pCampo As String, Optional ByVal pCondicion As String = "1=1") As String
            Dim vDatoADevolver As String = String.Empty
            Dim vCon As SqlConnection = New SqlConnection(clsDatosConexionSQL.cadenaConexion())
            Dim vCadena As String = String.Format("SELECT TOP 1 {1} FROM {0} WHERE {2} ORDER BY {1} DESC", pTabla, pCampo, pCondicion)
            Dim vCMD As New SqlCommand(vCadena, vCon)
            Try
                vCon.Open()
                Dim vReader As SqlDataReader = vCMD.ExecuteReader()
                If vReader.FieldCount > 0 Then
                    While vReader.Read()
                        vDatoADevolver = vReader(0)
                    End While
                Else
                    vDatoADevolver = String.Empty
                End If
                vCon.Close()
            Catch ex As Exception
                If Not vCon Is Nothing Then
                    If vCon.State = ConnectionState.Open Then vCon.Close()
                End If
                vDatoADevolver = String.Empty
            End Try
            Return vDatoADevolver
        End Function


        Public Sub ejecutarProcedimientosAlmacenados()
            Dim dtTemp As New DataTable()
            Dim vDatoDevuelto As Integer
            Me.gConexionSQL = New SqlConnection(clsDatosConexionSQL.cadenaConexion())
            Dim vNombreProcedimiento = Me.gNombreProcedimiento1
            Try
                'Esta funcion ejecuta Inserts, Updates, Deletes con parametros de entrada
                Dim i As Integer = 0
                Me.gConexionSQL.Open()

                Me.gCMDsql1 = New SqlCommand(Me.gNombreProcedimiento1, Me.gConexionSQL, Me.gTransaccion)

                Me.gCMDsql1.CommandType = CommandType.StoredProcedure

                'Cargar parametros antes de ejecutar
                SqlCommandBuilder.DeriveParameters(Me.gCMDsql1)

                'Sirve para ir a la BD y extraer los parametros que contiene el procedimiento almacenado 
                For i = 0 To Me.gDatosOBJ.Length - 1
                    Me.gCMDsql1.Parameters(i + 1).Value = Me.gDatosOBJ(i)
                Next

                Me.gDatoDevuelto = Me.gCMDsql1.ExecuteScalar()


                If Me.gDatoDevuelto > 0 Then

                    vNombreProcedimiento = Me.gNombreProcedimiento2

                    Me.gCMDsql2 = New SqlCommand(Me.gNombreProcedimiento2, Me.gConexionSQL, Me.gTransaccion)

                    Me.gCMDsql2.CommandType = CommandType.StoredProcedure

                    'Cargar parametros antes de ejecutar
                    SqlCommandBuilder.DeriveParameters(Me.gCMDsql2)

                    'Verificación de datos de la tabla de detalle
                    If Me.gTablaDetalle Is Nothing Then
                        GoTo gManejarError
                    ElseIf Me.gTablaDetalle.Rows.Count = 0 Then
                        GoTo gManejarError
                    End If

                    For vX As Integer = 0 To gTablaDetalle.Rows.Count - 1

                        If Me.gFilasAInsertar Is Nothing Then

                            Me.gCMDsql2.Parameters(1).Value = Me.gDatoDevuelto
                            For vY As Integer = 0 To gTablaDetalle.Columns.Count - 1
                                'Sirve para ir a la BD y extraer los parametros que contiene el procedimiento almacenado 
                                Me.gCMDsql2.Parameters(vY + 2).Value = Me.gTablaDetalle.Rows(vX)(vY)
                            Next

                            vDatoDevuelto = Me.gCMDsql2.ExecuteScalar()

                            If vDatoDevuelto <= 0 Then
                                GoTo gManejarError
                            End If

                            Me.gCMDsql2.Parameters.Clear()

                        Else

                            Me.gCMDsql2.Parameters(1).Value = Me.gDatoDevuelto
                            For vY = 0 To Me.gFilasAInsertar - 1
                                'Sirve para ir a la BD y extraer los parametros que contiene el procedimiento almacenado 
                                Me.gCMDsql2.Parameters(vY + 2).Value = Me.gTablaDetalle.Rows(vX)(Me.gFilasAInsertar(vY))
                            Next

                            vDatoDevuelto = Me.gCMDsql2.ExecuteScalar()

                            If vDatoDevuelto <= 0 Then
                                GoTo gManejarError
                            End If

                            Me.gCMDsql2.Parameters.Clear()

                        End If

                    Next
                Else
                    GoTo gManejarError
                End If

                cerrarConexion(True)

            Catch ex As SqlException
                generoError(ex.Message.ToString())
                cerrarConexion(False)
                Exit Sub

            Catch ex As Exception
                generoError(ex.Message.ToString())
                cerrarConexion(False)
            End Try

            Exit Sub

gManejarError:
            generoError(String.Format("No se pueden almacenar los datos.  Procedimiento [{0}].  Verifique la información", vNombreProcedimiento))
            cerrarConexion(False)

        End Sub




        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub


        Public Overloads Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
            If gTransaccion IsNot Nothing Then
                gTransaccion.Dispose()
                gTransaccion = Nothing
            End If
            If gConexionSQL IsNot Nothing Then
                gConexionSQL.Dispose()
                gConexionSQL = Nothing
            End If
            If gCMDsql1 IsNot Nothing Then
                gCMDsql1.Dispose()
                gCMDsql1 = Nothing
            End If
            If gCMDsql2 IsNot Nothing Then
                gCMDsql2.Dispose()
                gCMDsql2 = Nothing
            End If
            If dsRespuesta IsNot Nothing Then
                dsRespuesta.Dispose()
                dsRespuesta = Nothing
            End If
        End Sub

        Protected Overridable Overloads Sub Dispose(ByVal pDisposing As Boolean)
            If Not Me.gDisposed Then
                'If pDisposing Then
                '    If Me.gTransaccion IsNot Nothing Then
                '        If Not Me.gTransaccion.Connection Is Nothing Then
                '            If Me.gTransaccion.Connection.State = ConnectionState.Open Then Me.gTransaccion.Rollback()
                '        End If
                '    End If
                '    If Me.gConexionSQL.State = ConnectionState.Open Then Me.gConexionSQL.Close()
                'End If
                ' Dispose de cualquier recurso.
                ' Llamar a MyBase.Finalize si es una clase derivada ,
                ' y la clase base  no ejecuta Dispose.
                MyBase.Finalize()
            End If
            Me.gDisposed = True
        End Sub

#End Region









    End Class
End Namespace
