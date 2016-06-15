Imports capaDatos.VINNS.conexiones

'Autor: Jans Calderon

Namespace namespace4BITS.Conexiones

    Public Class clsEspecialidades
        Private _tipoMetodo As New clsTiposMetodos
        Private gNombresProcedimientos() As String = {"[dr].[pEspecialidadesListar]",
                                                      "[dr].[pEspecialidadesCUD]"
                                                     }



        'Listar datos de especialidades
        Public Function pListarEspecialidades() As DataTable
            Dim clsDatos As New clsMetodosSQL(gNombresProcedimientos(0), _tipoMetodo.metodoDevuelveTabla, False)
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





    End Class

End Namespace