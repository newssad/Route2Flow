Imports System.Data

Partial Class signin
    Inherits System.Web.UI.Page

    Dim myUserLogin As New sUserLogin()
    Dim strUsername As String = ""
    Dim strPassword As String = ""

    Protected Sub btSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btSubmit.Click

        strUsername = Me.tbName.Text
        strPassword = Me.tbPassword.Text

 Dim dt As IEnumerable(Of UserLogin) = myUserLogin.LoginDatable(strUsername, strPassword)
        Dim fod = dt.FirstOrDefault
        If Not fod Is Nothing Then

            Session("UserLogin") = fod
            'Dim dr As DataRow = dt.Rows(0)
            'Response.Cookies("UserLogin")("UID") = dr("UID")
            'Response.Cookies("UserLogin")("DID") = dr("DID")
            'Response.Cookies("UserLogin")("FULLNAME") = dr("Name") & " " & dr("Surname")
            'Response.Cookies("UserLogin")("EMAIL") = dr("Email")
            'Response.Cookies("UserLogin")("SSN") = dr("SSN")
            'Response.Cookies("UserLogin")("SEC") = dr("SecCode")
            'Response.Cookies("UserLogin")("UserType") = dr("UserType")
            Response.Redirect("default.aspx")
            Response.End()
        Else
            Response.Redirect("signin.aspx")
            Response.End()
        End If

    End Sub
End Class
