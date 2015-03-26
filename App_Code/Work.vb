Imports Microsoft.VisualBasic

Public Class Work
    Implements IDisposable
    Dim context As New DataClassesDataContext()

#Region "################################### Connection ####################################################"
    Sub New()
        context = New DataClassesDataContext
    End Sub
    Public Sub Dispose() Implements System.IDisposable.Dispose
        context.Dispose()
    End Sub
    Sub Save()
        context.SubmitChanges()
    End Sub
#End Region
    Public Sub crateWork(data As sfmCreatework)
        Try
            context.SOFTFLOW_sp_CreateRouteWork(data.wid, data.rid, data.pid, data.fid, data.wsubject, data.worigin, data.wowner, data.wdate, data.wdsc, data.seclevcode, data.prioritycode _
                                                , data.registerdep, data.registeruid, data.registerno, data.dateregistered, data.timeregistered, data.datecompleted, data.timecompleted, data.maxtime, data.refwork, data.expiredate, data.location, data.status, data.ip)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
