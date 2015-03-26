Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Imports LinqKit
Public Class sfRoute
    Implements IDisposable

    Private _RID As String
    Private _Name As String
    Private _LaunchDate As String
    Private _ExpiryDate As String
    Private _DateCreated As String
    Private _Authors As String
    Private _WMember As List(Of sfMember)

    Public Property WMember() As List(Of sfMember)
        Get
            Return _WMember
        End Get
        Set(ByVal value As List(Of sfMember))
            _WMember = value
        End Set
    End Property

    Public Property Authors() As String
        Get
            Return _Authors
        End Get
        Set(ByVal value As String)
            _Authors = value
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

    Public Property ExpiryDate() As String
        Get
            Return _ExpiryDate
        End Get
        Set(ByVal value As String)
            _ExpiryDate = value
        End Set
    End Property

    Public Property LaunchDate() As String
        Get
            Return _LaunchDate
        End Get
        Set(ByVal value As String)
            _LaunchDate = value
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
#Region "############################################# Route #####################################################"
    Function getRouteList(ByVal data As sfRoute) As IEnumerable(Of Route)
        Try
            Dim Predicate = PredicateBuilder.True(Of Route)()
            If data.RID IsNot Nothing And data.RID <> "" Then
                Predicate = Predicate.And(Function(p As Route) p.RID = data.RID)
            End If
            Dim query = Context.Routes.Where(Predicate)
            ' context.Dispose()
            Return query
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Sub RoutesAdd(ByVal R As Route)
        Try
            Context.Routes.InsertOnSubmit(R)
            Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub RoutesEdit(ByVal R As Route)
        Try
            Dim oldR As Route = (From c In Context.Routes Where c.RID = R.RID).FirstOrDefault
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
            Dim R As Route = (From c In Context.Routes Where c.RID = id).FirstOrDefault
            Context.Routes.DeleteOnSubmit(R)
            Save()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function GetRouteProcess(uid As String) As IEnumerable(Of sfRoute)
        Try
            Dim listsfRoute As New List(Of sfRoute)
            Dim myMember As New sMember
            Dim dtRoutes As DataTable = myMember.ListOfRoute(uid)
            If dtRoutes.Rows.Count > 0 Then
                For Each dr As DataRow In dtRoutes.Rows
                    Dim rid As String = dr("RID")
                    Dim query As IEnumerable(Of sfRoute) = (From p In context.Routes Where p.RID = rid Select New  _
                             sfRoute With {.Authors = p.Authors, .DateCreated = p.DateCreated, _
                             .ExpiryDate = p.ExpiryDate, .LaunchDate = p.LaunchDate, .Name = p.Name _
                             , .RID = p.RID, .WMember = (From n In context.Members Where n.RID = rid And n.UID = uid Order By n.UID _
                             Select New sfMember With {.PID = n.PID, .RID = n.RID, .UID = n.UID, .WProcess = (From k In context.Processes Where k.RID = rid And k.PID = n.PID _
                             Select New sfProcess With {.Description = k.Description, .Name = k.Name, .PID = k.PID, .RID = k.RID, .RegisterNo = k.RegisterNo, .Type = k.Type}).FirstOrDefault, _
                                                       .Notification = (From g In context.WorkInProcesses Where g.RID = n.RID And g.PID = n.PID).Count.ToString(), .Steps = (From xx In context.Steps Where xx.PID = n.PID Select xx.Step).FirstOrDefault})})
                    listsfRoute.Add(query.FirstOrDefault)
                Next
            End If
            Return listsfRoute
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
