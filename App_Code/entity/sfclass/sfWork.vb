Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Imports LinqKit
Public Class sfWork
    Implements IDisposable
    Private _WID As String
    Private _RID As String
    Private _FID As String
    Private _WType As String
    Private _WSubtype As String
    Private _WSubject As String
    Private _WOrigin As String
    Private _WOwner As String
    Private _DateCreated As String
    Private _SecLevCode As String
    Private _PriorityCode As String
    Private _RegisterDep As String
    Private _RegisterUID As String
    Private _RegisterNo As String
    Private _DateRegistered As String
    Private _TimeRegistered As String
    Private _DateCompleted As String
    Private _TimeCompleted As String
    Private _Status As String
    Private _PID As String
    Public Property PID() As String
        Get
            Return _PID
        End Get
        Set(ByVal value As String)
            _PID = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return _Status
        End Get
        Set(ByVal value As String)
            _Status = value
        End Set
    End Property

    Public Property TimeCompleted() As String
        Get
            Return _TimeCompleted
        End Get
        Set(ByVal value As String)
            _TimeCompleted = value
        End Set
    End Property

    Public Property DateCompleted() As String
        Get
            Return _DateCompleted
        End Get
        Set(ByVal value As String)
            _DateCompleted = value
        End Set
    End Property

    Public Property TimeRegistered() As String
        Get
            Return _TimeRegistered
        End Get
        Set(ByVal value As String)
            _TimeRegistered = value
        End Set
    End Property

    Public Property DateRegistered() As String
        Get
            Return _DateRegistered
        End Get
        Set(ByVal value As String)
            _DateRegistered = value
        End Set
    End Property

    Public Property RegisterNo() As String
        Get
            Return _RegisterNo
        End Get
        Set(ByVal value As String)
            _RegisterNo = value
        End Set
    End Property

    Public Property RegisterUID() As String
        Get
            Return _RegisterUID
        End Get
        Set(ByVal value As String)
            _RegisterUID = value
        End Set
    End Property

    Public Property RegisterDep() As String
        Get
            Return _RegisterDep
        End Get
        Set(ByVal value As String)
            _RegisterDep = value
        End Set
    End Property

    Public Property PriorityCode() As String
        Get
            Return _PriorityCode
        End Get
        Set(ByVal value As String)
            _PriorityCode = value
        End Set
    End Property

    Public Property SecLevCode() As String
        Get
            Return _SecLevCode
        End Get
        Set(ByVal value As String)
            _SecLevCode = value
        End Set
    End Property

    Public Property DateCreated() As String
        Get
            Return _DateCreated
        End Get
        Set(ByVal value As String)
            _DateCreated = value
        End Set
    End Property

    Public Property WOwner() As String
        Get
            Return _WOwner
        End Get
        Set(ByVal value As String)
            _WOwner = value
        End Set
    End Property

    Public Property WOrigin() As String
        Get
            Return _WOrigin
        End Get
        Set(ByVal value As String)
            _WOrigin = value
        End Set
    End Property

    Public Property WSubject() As String
        Get
            Return _WSubject
        End Get
        Set(ByVal value As String)
            _WSubject = value
        End Set
    End Property

    Public Property WSubtype() As String
        Get
            Return _WSubtype
        End Get
        Set(ByVal value As String)
            _WSubtype = value
        End Set
    End Property

    Public Property WType() As String
        Get
            Return _WType
        End Get
        Set(ByVal value As String)
            _WType = value
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
#Region "################################### Work ####################################################"
    Function listWork(data As sfWorkInProcess) As IEnumerable(Of sfWork)
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
            Dim query As IEnumerable(Of sfWork) = (From p In retData Select New sfWork With {.RegisterUID = p.UID, .WSubject = translateLink((From g In context.Works Where g.WID = p.WID And g.RID = p.RID Select g), p.PID), .DateCreated = p.DateIn, _
                                                                                             .RID = p.RID, .PID = p.PID, .WID = p.WID})
            Return query
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function listWorkCheckout(data As sfWorkInProcess) As IEnumerable(Of sfWork)
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
            Dim query As IEnumerable(Of sfWork) = (From p In retData Select New sfWork With {.RegisterUID = p.UID, .WSubject = translateLinkCheckOut((From g In context.Works Where g.WID = p.WID And g.RID = p.RID Select g), p.ID), .DateCreated = p.DateIn, _
                                                                                             .RID = p.RID, .PID = p.PID, .WID = p.WID})
            Return query
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function listWorkCheckaudit(data As sfWorkInProcess) As IEnumerable(Of sfWork)
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
            Dim query As IEnumerable(Of sfWork) = (From p In retData Select New sfWork With {.RegisterUID = p.UID, .WSubject = translateLinkCheckOutReturnAudit((From g In context.Works Where g.WID = p.WID And g.RID = p.RID Select g), p.ID), .DateCreated = p.DateIn, _
                                                                                             .RID = p.RID, .PID = p.PID, .WID = p.WID})
            Return query
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function translateLink(data As [Work], pid As String) As String

        Return "<a data-toggle='modal' id='" + data.WID + "'  name='" & data.WSubject & "||" & data.WDsc & "||" & data.Maxtime & "||" & data.RefWork & "||" & data.Location & "||" & data.ExpireDate & "||" & data.RID & "||" & pid & "'  href='#myModal'  data-target='#edit-modal'>" & data.WSubject & "</a>"
    End Function
    Function translateLinkCheckOut(data As [Work], strid As String) As String

        Return "<a data-toggle='modal' id='" + strid + "'  name='" & data.WSubject & "||" & data.WDsc & "||" & data.Maxtime & "||" & data.RefWork & "||" & data.Location & "||" & data.ExpireDate & "||" & data.RID & "||" & PID & "'  href='#myModalcheckout'  data-target='#edit-modal2'>" & data.WSubject & "</a>"
    End Function
    Function translateLinkCheckOutReturnAudit(data As [Work], strid As String) As String

        Return "<a data-toggle='modal' id='" + strid + "'  name='" & data.WSubject & "||" & data.WDsc & "||" & data.Maxtime & "||" & data.RefWork & "||" & data.Location & "||" & data.ExpireDate & "||" & data.RID & "||" & PID & "'  href='#myModalcheckoutaudit'  data-target='#edit-modal3'>" & data.WSubject & "</a>"
    End Function
#End Region
End Class
