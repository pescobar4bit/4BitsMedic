Imports capaDatos.VINNS.conexiones


Namespace VINNS.MetodosConexiones

    Public Class clsEjemplo
        Private _tipoMetodo As New clsTiposMetodos
        Private gNombresProcedimientos() As String = {"[eje].[prEjemploProcedimiento]",
                                                      "[eje].[prEjemploProcedimiento]",
                                                      "[eje].[prEjemploProcedimiento]",
                                                      "[eje].[prEjemploProcedimiento]"
                                                     }


        Sub New()
            MyBase.New()
        End Sub

        Public Function ejecutarProcedimiento1() As DataTable
            Dim clsDatos As New clsMetodosSQL(gNombresProcedimientos(0), _tipoMetodo.metodoDevuelveTabla, 1, "hola", 23.12)
            Dim dtTabla As DataTable
            clsDatos.ejecutarProcedimientoAlmacenado()
            If clsDatos.existeError Then
                dtTabla = Nothing
                MsgBox(clsDatos.mensajeError)
            Else
                dtTabla = clsDatos.devolverDataSet.Tables(0)
            End If
           

            clsDatos.Dispose()
            Return dtTabla
        End Function



        Public Sub ejecutarProcedimiento2()
            Dim clsDatos As New clsMetodosSQL(gNombresProcedimientos(0), _tipoMetodo.metodoDevuelveNoFilasAfectadas, 1, "hola", 23.12)

            clsDatos.ejecutarProcedimientoAlmacenado()
            If clsDatos.existeError Then
                MsgBox(clsDatos.mensajeError)
            Else
                MsgBox("numero de filas afectadas: " & clsDatos.datoDevuelto)
            End If
            clsDatos.Dispose()
        End Sub



        Public Sub ejecutarProcedimiento3()
            Dim clsDatos As New clsMetodosSQL(gNombresProcedimientos(0), _tipoMetodo.metodoNoDevuelveUnDato, 1, "hola", 23.12)

            clsDatos.ejecutarProcedimientoAlmacenado()
            If clsDatos.existeError Then
                MsgBox(clsDatos.mensajeError)
            Else
                MsgBox("dato devuelto: " & clsDatos.datoDevuelto)
            End If
            clsDatos.Dispose()
        End Sub


        Public Sub obtenerDato()
            'Dim clsDatos As New clsMetodosSQL()
            'MsgBox("dato devuelto: " & clsDatos.obtenerDato("[dbo].[tConfiguraciones]", "Multa"))
            'clsDatos.Dispose()
        End Sub


    End Class

End Namespace