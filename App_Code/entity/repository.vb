Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Imports System.Data.Linq.DataContext
Imports LinqKit
Imports System.Data.Common

Public Class repository
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

    Function test() As IEnumerable(Of Member)
        Dim results As IEnumerable(Of Member) = context.ExecuteQuery(Of Member)("SELECT * FROM contexto.Member")
        Dim da = context.ExecuteQuery(Of DataTable)("SELECT * FROM Member")
        Using cmd = context.Connection.CreateCommand()
            cmd.CommandText = "SELECT * FROM Member "
            Dim result = cmd.ExecuteReader()

            If result.Read Then
                Dim aa = result(0)
            End If

            '  Dim a = DataContextExtensions.ExecuteQuery(context, "SELECT * FROM Member", )

        End Using

        Return results
    End Function

#Region "############################################# Route #####################################################"
    Function getRouteList(ByVal data As sfRoute) As IEnumerable(Of Route)
        Try
            Dim Predicate = PredicateBuilder.True(Of Route)()
            If data.RID IsNot Nothing And data.RID <> "" Then
                Predicate = Predicate.And(Function(p As Route) p.RID = data.RID)
            End If
            Dim query = context.Routes.Where(Predicate)
            ' context.Dispose()
            Return query
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Sub RoutesAdd(ByVal R As Route)
        Try
            context.Routes.InsertOnSubmit(R)
            Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub RoutesEdit(ByVal R As Route)
        Try
            Dim oldR As Route = (From c In context.Routes Where c.RID = R.RID).FirstOrDefault
            oldR.RID = R.RID
            oldR.Name = R.Name
            oldR.LaunchDate = R.LaunchDate
            oldR.ExpiryDate = R.ExpiryDate
            oldR.DateCreated = R.DateCreated
            oldR.Authors = R.Authors
            Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub RoutesDelete(ByVal id As String)
        Try
            Dim R As Route = (From c In context.Routes Where c.RID = id).FirstOrDefault
            context.Routes.DeleteOnSubmit(R)
            Save()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region
#Region "############################################# Proocess #####################################################"

    Function getProcessDatable(ByVal data As sfProcess) As DataTable
        Try

            Dim Predicate = PredicateBuilder.True(Of Process)()
            If data.RID IsNot Nothing And data.RID <> "" Then
                Predicate = Predicate.And(Function(p As Process) p.PID = data.PID)
            End If
            Dim retData = context.Processes.Where(Predicate)
            Dim dt As DataTable = Nothing
            dt = sfFunc.ListToDataTable(retData.ToList())
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getProcessList(ByVal data As sfProcess) As IEnumerable(Of Process)
        Try
            Dim Predicate = PredicateBuilder.True(Of Process)()
            If data.RID IsNot Nothing And data.RID <> "" Then
                Predicate = Predicate.And(Function(p As Process) p.PID = data.PID)
            End If
            Dim retData = context.Processes.Where(Predicate)
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub ProcessAdd(ByVal proc As Process)
        Try
            context.Processes.InsertOnSubmit(proc)
            Save()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub ProcessEdit(ByVal proc As Process)
        Try

            Dim oldProc As Process = (From c In context.Processes Where c.PID = proc.PID).FirstOrDefault
            oldProc.PID = proc.PID
            oldProc.RID = proc.RID
            oldProc.Name = proc.Name
            oldProc.Description = proc.Description
            oldProc.Type = proc.Type
            Save()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub ProcessDelete(ByVal id As String)
        Try
            Dim proc As Process = (From c In context.Processes Where c.PID = id).FirstOrDefault
            context.Processes.DeleteOnSubmit(proc)
            Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "############################################# Route Step #####################################################"
    Function getRouteStepDatable(ByVal data As sfRouteStep) As DataTable
        Try
            'Dim retData As List(Of [Step]) = Nothing
            Dim Predicate = PredicateBuilder.True(Of [Step])()
            If data.RID IsNot Nothing And data.RID <> "" Then
                Predicate = Predicate.And(Function(p As [Step]) p.RID = data.RID)
            End If
            Dim retData = context.Steps.Where(Predicate).ToList()
            Dim dt As DataTable = Nothing
            dt = sfFunc.ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function getRouteStepList(ByVal data As sfRouteStep) As IEnumerable(Of [Step])
        Try
            Dim Predicate = PredicateBuilder.True(Of [Step])()
            If Data.RID IsNot Nothing And Data.RID <> "" Then
                Predicate = Predicate.And(Function(p As [Step]) p.RID = Data.RID)
            End If
            Dim retData = context.Steps.Where(Predicate).ToList()
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub RouteStepAdd(ByVal obj As [Step])
        Try
            Dim context As New DataClassesDataContext
            Dim LastId = (From c In context.Steps Where c.RID = obj.RID Select c.Step Order By [Step] Descending).FirstOrDefault
            obj.Step = frontzero((LastId + 1), 2)
            context.Steps.InsertOnSubmit(obj)
            Save()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub RouteStepEdit(ByVal obj As [Step])
        Try
            Dim context As New DataClassesDataContext
            Dim oldObj As [Step] = (From c In context.Steps Where c.RID = obj.RID And c.Step = obj.Step).FirstOrDefault
            oldObj.RID = obj.RID
            oldObj.PID = obj.PID
            oldObj.Step = obj.Step
            oldObj.Action = obj.Action
            Save()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub RouteStepDelete(ByVal rid As String, ByVal [Step] As String, ByVal Action As String, ByVal PID As String)
        Try
            Dim context As New DataClassesDataContext
            Dim obj As [Step] = (From c In context.Steps Where c.RID = rid And c.Step = [Step] And c.Action = Action And c.PID = PID).FirstOrDefault
            context.Steps.DeleteOnSubmit(obj)
            Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class



