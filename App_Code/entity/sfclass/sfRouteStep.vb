Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Imports LinqKit
Public Class sfRouteStep
    Implements IDisposable
    Private _RID As String
    Private _StepNo As String
    Private _Action As String
    Private _PID As String
    Public Property PID() As String
        Get
            Return _PID
        End Get
        Set(ByVal value As String)
            _PID = value
        End Set
    End Property

    Public Property Action() As String
        Get
            Return _Action
        End Get
        Set(ByVal value As String)
            _Action = value
        End Set
    End Property

    Public Property StepNo() As String
        Get
            Return _StepNo
        End Get
        Set(ByVal value As String)
            _StepNo = value
        End Set
    End Property

    Public Property RID() As String
        Get
            Return _RID
        End Get
        Set(ByVal value As String)
            _RID = value
        End Set
    End Property

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
