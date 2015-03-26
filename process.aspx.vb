Imports System.Web.Services

Partial Class process
    Inherits System.Web.UI.Page
    Private Shared strCurUid As String = String.Empty
    Private Shared strCurDid As String = String.Empty
    Private Shared LocalHostaddress As String
    Public strCurFullName As String = String.Empty
    Public strCurEmail As String = String.Empty
    Public strCurSSN As String = String.Empty
    Public strCurSec As String = String.Empty
    Public strCurUserType As String = String.Empty
    Private Shared pageProcessID As String = String.Empty
    Private Shared pageRouteID As String = String.Empty
    Private Shared pagestepID As String = String.Empty
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
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
                Dim host As String = System.Net.Dns.GetHostName()
                '  LocalHostaddress = System.Net.Dns.GetHostByName(host).AddressList(1).ToString()
                pageProcessID = Request.QueryString("id")
                pageRouteID = Request.QueryString("rid")
                pagestepID = Request.QueryString("step")
                If pagestepID = 0 Then
                    bindgridstep0()
                    bindgridstep00()
                Else
                    bindgridstep1()
                    bindgridstep11()
                End If
            Catch ex As Exception

            End Try
        End If


        If strCurUid = Nothing Then Response.Redirect("signin.aspx")
        'Call ListAllRoute()
    End Sub
    Public Overloads Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)


    End Sub
    Sub bindgridstep0()
        Dim sfprocess As New sfWork
        Dim dt = sfprocess.listWork(New sfWorkInProcess With {.PID = pageProcessID, .RID = pageRouteID, .SenderUID = "all"})
        GridView7.DataSource = dt
        GridView7.DataBind()
    End Sub
    Sub bindgridstep00()
        Dim sfprocess As New sfWork
        Dim dt = sfprocess.listWork(New sfWorkInProcess With {.PID = pageProcessID, .RID = pageRouteID, .UID = strCurUid})
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
    Sub bindgridstep1()
        Dim sfprocess As New sfWork
        Dim dt = sfprocess.listWorkCheckout(New sfWorkInProcess With {.PID = pageProcessID, .RID = pageRouteID, .SenderUID = "all"})
        GridView7.DataSource = dt
        GridView7.DataBind()
    End Sub
    Sub bindgridstep11()
        Dim sfprocess As New sfWork
        Dim dt = sfprocess.listWorkCheckaudit(New sfWorkInProcess With {.PID = pageProcessID, .RID = pageRouteID, .UID = strCurUid})
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

    <WebMethod()> _
    Public Shared Function creatework(subject As String, dsc As String, sdate As String, refwork As String, expiredate As String, location As String)
        ' Dim data As IEnumerable(Of District) = repository.GetDistic(id)

        Dim sfrm As New sfmCreatework
        Dim sfr As New sfRoute
        Dim data = sfr.GetRouteProcess(strCurUid)
        Dim items = data.FirstOrDefault
        sfrm.wid = items.RID & Date.Now.Millisecond & Date.Now.Year
        sfrm.rid = items.RID
        sfrm.pid = items.WMember.FirstOrDefault.PID
        sfrm.fid = "001"
        sfrm.wsubject = subject
        sfrm.worigin = strCurUid
        sfrm.wowner = strCurUid
        sfrm.wdate = sfFunc.currentDateyyyymmdd()
        sfrm.seclevcode = "00"
        sfrm.prioritycode = "0"
        sfrm.registerdep = strCurDid
        sfrm.registeruid = strCurUid
        sfrm.registerno = ""
        sfrm.dateregistered = sfFunc.currentDateyyyymmdd()
        sfrm.timeregistered = sfFunc.currentTime
        sfrm.status = "02"
        sfrm.ip = "127.0.0.1"
        sfrm.datecompleted = "-"
        sfrm.timecompleted = "-"
        sfrm.maxtime = sdate
        sfrm.wdsc = dsc
        sfrm.refwork = refwork
        sfrm.expiredate = expiredate
        sfrm.location = location
        Dim _adds As New Work()
        Try
            _adds.crateWork(sfrm)
            Return "Success"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    <WebMethod()> _
    Public Shared Function nextstep(ByVal wid As String, ByVal pid As String, ByVal rid As String, setpss As String)
        Try

            Dim sfwip As New sfWorkInProcess
            Dim _add As New WorkInProcess
            _add.Action = "02"
            _add.DateIn = sfFunc.currentDateyyyymmdd
            _add.DateModified = "-"
            _add.Dep = ""
            _add.PID = sfwip.getnext(setpss)
            _add.RegisterNo = ""
            _add.RID = rid
            _add.SenderDep = strCurDid
            _add.SenderPID = pid
            _add.SenderUID = strCurUid
            _add.TimeIn = sfFunc.currentTime
            _add.WID = wid
            _add.UID = ""
            _add.TimeModified = "-"

            sfwip.insert(_add)
            Return "Success"
        Catch ex As Exception
            Return ""
        End Try
    End Function
    <WebMethod()> _
    Public Shared Function checkout(ByVal wid As String, ByVal pid As String, ByVal rid As String, setpss As String)
        Try

            Dim sfwip As New sfWorkInProcess
            sfwip.updateCheckOut(wid, strCurUid, strCurDid)
            Return "Success"
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class
