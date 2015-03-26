Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Imports LinqKit
Public Class sfWorkInProcess
    Implements IDisposable
    Private _WID As String
    Private _RID As String
    Private _FID As String
    Private _SenderPID As String
    Private _SenderDep As String
    Private _Dep As String
    Private _SenderUID As String
    Private _UID As String
    Private _Action As String
    Private _DateIn As String
    Private _TimeIn As String
    Private _DateModified As String
    Private _TimeModified As String
    Private _PID As String
    Public Property PID() As String
        Get
            Return _PID
        End Get
        Set(ByVal value As String)
            _PID = value
        End Set
    End Property

    Public Property TimeModified() As String
        Get
            Return _TimeModified
        End Get
        Set(ByVal value As String)
            _TimeModified = value
        End Set
    End Property

    Public Property DateModified() As String
        Get
            Return _DateModified
        End Get
        Set(ByVal value As String)
            _DateModified = value
        End Set
    End Property


    Public Property TimeIn() As String
        Get
            Return _TimeIn
        End Get
        Set(ByVal value As String)
            _TimeIn = value
        End Set
    End Property

    Public Property DateIn() As String
        Get
            Return _DateIn
        End Get
        Set(ByVal value As String)
            _DateIn = value
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

    Public Property UID() As String
        Get
            Return _UID
        End Get
        Set(ByVal value As String)
            _UID = value
        End Set
    End Property

    Public Property SenderUID() As String
        Get
            Return _SenderUID
        End Get
        Set(ByVal value As String)
            _SenderUID = value
        End Set
    End Property

    Public Property Dep() As String
        Get
            Return _Dep
        End Get
        Set(ByVal value As String)
            _Dep = value
        End Set
    End Property

    Public Property SenderDep() As String
        Get
            Return _SenderDep
        End Get
        Set(ByVal value As String)
            _SenderDep = value
        End Set
    End Property

    Public Property SenderPID() As String
        Get
            Return _SenderPID
        End Get
        Set(ByVal value As String)
            _SenderPID = value
        End Set
    End Property

    Public Property FID() As String
        Get
            Return _FID
        End Get
        Set(ByVal value As String)
            _FID = value
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

    Public Property WID() As String
        Get
            Return _WID
        End Get
        Set(ByVal value As String)
            _WID = value
        End Set
    End Property
    Dim context As New DataClassesDataContext()
#Region "################################### Connection ####################################################"
    Sub New()
        Context = New DataClassesDataContext
    End Sub
    Public Sub Dispose() Implements System.IDisposable.Dispose
        Context.Dispose()
    End Sub
    Sub Save()
        Context.SubmitChanges()
    End Sub
#End Region
#Region "################################### WorkInProcess ####################################################"
    Function listWorkinprocess(data As sfWorkInProcess) As IEnumerable(Of sfWork)
        Try
            Dim Predicate = PredicateBuilder.True(Of WorkInProcess)()
            If data.PID IsNot Nothing And data.PID <> "" Then
                Predicate = Predicate.And(Function(p As WorkInProcess) p.PID = data.PID)
            End If
            If data.RID IsNot Nothing And data.RID <> "" Then
                Predicate = Predicate.And(Function(p As WorkInProcess) p.RID = data.RID)
            End If
            If data.UID IsNot Nothing And data.UID <> "" Then
                Predicate = Predicate.And(Function(p As WorkInProcess) p.UID = data.UID)
            End If
            If data.SenderUID IsNot Nothing And data.SenderUID <> "" Then
                Predicate = Predicate.And(Function(p As WorkInProcess) p.UID = "")
            End If
            Dim retData = context.WorkInProcesses.Where(Predicate)
            Dim ifunc As New sfFunc
            Dim query As IEnumerable(Of sfWork) = (From p In retData Select New sfWork With {.RegisterUID = p.UID, .WSubject = translateLink((From g In context.Works Where g.WID = p.WID And g.RID = p.RID Select g)), .DateCreated = p.DateIn, _
                                                                                             .RID = p.RID, .PID = p.PID, .WID = p.WID})
            Return query
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function translateLink(data As [Work]) As String

        Return "<a data-toggle='modal' id='" + data.WID + "'  name='" & data.WSubject & "||" & data.WDsc & "||" & data.Maxtime & "||" & data.RefWork & "||" & data.Location & "||" & data.ExpireDate & "'  href='#myModal'  data-target='#edit-modal'>" & data.WSubject & "</a>"
    End Function
    Function insert(data As WorkInProcess) As String
        Try
            context.WorkInProcesses.InsertOnSubmit(data)
            Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function getnext(stepx As String) As String
        Dim data = (From p In context.Steps Where p.Step = CInt(stepx) + 1 Select p.PID Order By CInt(PID) Ascending).FirstOrDefault
        Return data
    End Function
    Function updateCheckin(strid As String) As String
        Try
            Dim data = (From p In context.WorkInProcesses Where p.ID = strid)
            Dim d = data.FirstOrDefault
            If Not d Is Nothing Then
                d.UID = ""
                d.Dep = ""
                d.DateModified = sfFunc.currentDateyyyymmdd
                d.TimeModified = sfFunc.currentTime
                Save()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function updateCheckOut(strid As String, uid As String, dept As String) As String
        Try
            Dim data = (From p In context.WorkInProcesses Where p.ID = strid)
            Dim d = data.FirstOrDefault
            If Not d Is Nothing Then
                d.UID = uid
                d.Dep = dept
                d.DateModified = sfFunc.currentDateyyyymmdd
                d.TimeModified = sfFunc.currentTime
                Save()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
