Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Namespace VINNS.conexiones

    Public Class clsMetodosSQL
        Implements IDisposable

#Region "Variables privadas/protegidas"
        Private gMSGError As String = String.Empty
        Private gEsError As Boolean = False
        Private gTransaccion As SqlTransaction
        Private gConexionSQL As New SqlConnection()
        Private gCMDsql As New SqlCommand()
        Private dsRespuesta As New DataSet
        Private gTipoSP As Byte
        Private gDatoDevuelto As String

        Private gDisposed As Boolean = False
        Private gNombreProcedimiento As String
        Private gDatosOBJ() As Object
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
            Me.gEsError = True
        End Sub


        Protected Sub constructor()
            gTipoSP = 1
            gNombreProcedimiento = String.Empty
            gDatosOBJ = Nothing
        End Sub


        Public Sub New(ByVal pNombreProcedimientoAlmacenado As String, ParamArray pParametros() As Object)
            MyBase.New()
            constructor()
            gNombreProcedimiento = pNombreProcedimientoAlmacenado
            gDatosOBJ = pParametros
        End Sub


        Public Sub New(ByVal pNombreProcedimientoAlmacenado As String, ByVal pTipoProcedimientoAlmacenado As Byte, ParamArray pParametros() As Object)
            MyBase.New()
            constructor()
            gNombreProcedimiento = pNombreProcedimientoAlmacenado
            gDatosOBJ = pParametros
            gTipoSP = pTipoProcedimientoAlmacenado
        End Sub


        '-------------------------
        Public Sub reasignarDatosProcedimientoAlmacenado(ByVal pNombreProcedimientoAlmacenado As String, ParamArray pParametros() As Object)
            gNombreProcedimiento = pNombreProcedimientoAlmacenado
            gDatosOBJ = pParametros
        End Sub


        Public Sub reasignarDatosSP(pNombreProcedimientoAlmacenado As String, ByVal pTipoProcedimientoAlmacenado As Byte, ParamArray pParametros() As Object)
            gNombreProcedimiento = pNombreProcedimientoAlmacenado
            gTipoSP = pTipoProcedimientoAlmacenado
            gDatosOBJ = pParametros
        End Sub


        Public Sub cambiarTipoProcedimiento(ByVal pTipoProcedimientoAlmacenado As Byte)
            gTipoSP = pTipoProcedimientoAlmacenado
        End Sub


        Public Function obtenerDato(ByVal pTabla As String, ByVal pCampo As String, Optional ByVal pCondicion As String = "1=1") As String
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


        '---------------------
        Public Sub ejecutarProcedimientoAlmacenado()
            Dim dtTemp As New DataTable()
            Me.gConexionSQL = New SqlConnection(clsDatosConexionSQL.cadenaConexion)

            Try
                'Esta funcion ejecuta Inserts, Updates, Deletes con parametros de entrada
                Me.gConexionSQL.Open()

                If gTipoSP = 1 Then Me.gCMDsql = New SqlCommand(Me.gNombreProcedimiento, Me.gConexionSQL) Else Me.gTransaccion = Me.gConexionSQL.BeginTransaction : Me.gCMDsql = New SqlCommand(Me.gNombreProcedimiento, Me.gConexionSQL, Me.gTransaccion)

                Me.gCMDsql.CommandType = CommandType.StoredProcedure

                'Cargar parametros antes de ejecutar
                SqlCommandBuilder.DeriveParameters(Me.gCMDsql)

                'Sirve para ir a la BD y extraer los parametros que contiene el procedimiento almacenado 
                For i As Integer = 0 To Me.gDatosOBJ.Length - 1
                    Me.gCMDsql.Parameters(i + 1).Value = Me.gDatosOBJ(i)
                Next

                Select Case Me.gTipoSP
                    Case 1
                        Dim vDataAdapter As New SqlDataAdapter() With {.SelectCommand = Me.gCMDsql}
                        vDataAdapter.Fill(Me.dsRespuesta)
                    Case 2
                        Me.gDatoDevuelto = Me.gCMDsql.ExecuteNonQuery()

                    Case Else
                        Me.gDatoDevuelto = Me.gCMDsql.ExecuteScalar()

                End Select

                cerrarConexion(True)

            Catch ex As SqlException
                generoError(ex.Message.ToString())
                cerrarConexion(False)

            Catch ex As Exception
                generoError(ex.Message.ToString())
                cerrarConexion(False)
            End Try
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
            If gCMDsql IsNot Nothing Then
                gCMDsql.Dispose()
                gCMDsql = Nothing
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