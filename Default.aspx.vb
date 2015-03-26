Imports System.Data
Imports System.Web.Services

Partial Class _Default
    Inherits System.Web.UI.Page
    Private Shared strCurUid As String = String.Empty
    Public strCurDid As String = String.Empty
    Public strCurFullName As String = String.Empty
    Public strCurEmail As String = String.Empty
    Public strCurSSN As String = String.Empty
    Public strCurSec As String = String.Empty
    Public strCurUserType As String = String.Empty

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Try
                Dim usr As UserLogin = Session("UserLogin")
                strCurUid = usr.UID 'Request.Cookies("UserLogin")("UID")
                strCurDid = usr.DID 'Request.Cookies("UserLogin")("DID")
                strCurFullName = usr.Name 'Request.Cookies("UserLogin")("FULLNAME")
                strCurEmail = usr.Email 'Request.Cookies("UserLogin")("EMAIL")
                strCurSSN = usr.SSN 'Request.Cookies("UserLogin")("SSN")
                strCurSec = usr.SecCode 'Request.Cookies("UserLogin")("SEC")
                strCurUserType = usr.UserType 'Request.Cookies("UserLogin")("UserType")
            Catch ex As Exception

            End Try
        End If


        If strCurUid = Nothing Then Response.Redirect("signin.aspx")
        'Call ListAllRoute()

    End Sub

    
    <WebMethod()> _
    Public Shared Function getroute()
        ' Dim data As IEnumerable(Of District) = repository.GetDistic(id)
        Dim sfr As New sfroute
        Dim data = sfr.GetRouteProcess(strCurUid)
        HttpContext.Current.Session("routeprocess") = data
        If data.Count > 0 Then
            Dim jSearializer As New System.Web.Script.Serialization.JavaScriptSerializer()
            Return jSearializer.Serialize(data)
        Else
            Dim jSearializer As New System.Web.Script.Serialization.JavaScriptSerializer()
            Return jSearializer.Serialize(New List(Of sfRoute))
        End If
    End Function



End Class
