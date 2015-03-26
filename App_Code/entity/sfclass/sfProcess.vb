Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports LinqKit
Public Class sfProcess
    Implements IDisposable
    Private _PID As String
    Private _RID As String
    Private _Name As String
    Private _Description As String
    Private _Type As String
    Private _Notification As String
    Private _NewNotfication As String
    Private _RegisterNo As String
    Public Property RegisterNo() As String
        Get
            Return _RegisterNo
        End Get
        Set(ByVal value As String)
            _RegisterNo = value
        End Set
    End Property

    Public Property NewNotfication() As String
        Get
            Return _NewNotfication
        End Get
        Set(ByVal value As String)
            _NewNotfication = value
        End Set
    End Property

    Public Property Notification() As String
        Get
            Return _Notification
        End Get
        Set(ByVal value As String)
            _Notification = value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
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


    Public Property PID() As String
        Get
            Return _PID
        End Get
        Set(ByVal value As String)
            _PID = value
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
End Class
