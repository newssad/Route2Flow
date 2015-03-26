
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        Dim myMem As New sMember
        Dim dt As Data.DataTable = myMem.ListOfRoute("admin")
        GridView1.DataSource = dt
        GridView1.DataBind()

        Dim myRoute As New sRoute()
        Dim objroute As Route = myRoute.getRouteProperties("001")

    End Sub
End Class
