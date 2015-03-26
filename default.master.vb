Imports System.Data

Partial Class _default
    Inherits System.Web.UI.MasterPage
    Public strCurUid As String = String.Empty
    Public strCurDid As String = String.Empty
    Public strCurFullName As String = String.Empty
    Public strCurEmail As String = String.Empty
    Public strCurSSN As String = String.Empty
    Public strCurSec As String = String.Empty
    Public strCurUserType As String = String.Empty
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        If strCurUid = Nothing Then Response.Redirect("signin.aspx")
    End Sub

    'Sub FindAllRoute()
    '    Dim myMember As New sMember
    '    'Dim dtRoutes As DataTable = myRoutes.getAllRoute(strCurUid)
    '    Dim dtRoutes As DataTable = myMember.ListOfRoute(strCurUid)

    '    Dim inti As Integer = 1

    '    If dtRoutes.Rows.Count > 0 Then
    '        For Each dr As DataRow In dtRoutes.Rows
    '            Dim myRoute As New sRoute()
    '            Dim objRoute As Route = myRoute.getRouteProperties(dr("RID"))

    '            Dim newLi As New HtmlGenericControl
    '            newLi.ID = "ctrlLi" & inti
    '            newLi.TagName = "li"

    '            Dim strInnerHtml As String = "<a href='#layout' ><i class='fa fa-code-fork icon'><b class='bg-warning'></b></i><span class='pull-right'><i class='fa fa-angle-down text'></i><i class='fa fa-angle-up text-active'></i></span><span>" & objRoute.Name & "</span></a>"

    '            'list all process
    '            Dim ProcessDT As DataTable = myMember.getAllProcessDataTable(dr("RID"), strCurUid)

    '            If ProcessDT.Rows.Count > 0 Then
    '                strInnerHtml = strInnerHtml & "<ul class='nav lt'>"
    '                For Each drP As DataRow In ProcessDT.Rows
    '                    Dim myProcess As New sProcess()
    '                    Dim objProcess As Process = myProcess.getProcessProperties(drP("PID"))
    '                    If objProcess.Type = "N" Then
    '                        strInnerHtml = strInnerHtml & "<li ><a href='process.aspx' ><b class='badge bg-danger pull-right'>3</b><p class='pull-right'>&nbsp;</p><b class='badge bg-info pull-right'>20</b><i class='fa fa-angle-right'></i><span>" & objProcess.Name & "</span>"
    '                    Else
    '                        strInnerHtml = strInnerHtml & "<li ><a href='layout-c.html' ><b class='badge bg-warning pull-right'>1</b><i class='fa fa-exclamation-circle'></i><span>" & objProcess.Name & "</span>"
    '                    End If

    '                Next
    '                strInnerHtml = strInnerHtml & "</ul>"
    '            End If

    '            newLi.InnerHtml = strInnerHtml

    '            'Panel1.Controls.Add(newLi)
    '            inti = inti + 1

    '            'Me.Literal1.Controls.Add(newLi)
    '            Me.ulBottom.Controls.Add(newLi)

    '        Next
    '    End If





    'End Sub
End Class

