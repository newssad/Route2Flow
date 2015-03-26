Imports Microsoft.VisualBasic

Public Class sfmRoute
    Private _routeID As String
    Private _Mprocess As sfmProcess
    Public Property routeID() As String
        Get
            Return _routeID
        End Get
        Set(ByVal value As String)
            _routeID = value
        End Set
    End Property
    Public Property Mprocess() As sfmProcess
        Get
            Return _Mprocess
        End Get
        Set(ByVal value As sfmProcess)
            _Mprocess = value
        End Set
    End Property

End Class
