Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports Softvibe.xDatabase
Public Class sMember
    Dim IPWebserver As String = ConfigurationManager.AppSettings("IPWebserver")
    Dim IPDBserver As String = ConfigurationManager.AppSettings("IPDBserver")
    Dim dbuser As String = ConfigurationManager.AppSettings("dbuser")
    Dim dbpwd As String = ConfigurationManager.AppSettings("dbpwd")
    Dim DatabaseName As String = ConfigurationManager.AppSettings("DatabaseName")
    Dim xsql As New XSqlSeverInterfacer(IPDBserver, DatabaseName, dbuser, dbpwd)
    Function getAllRoute(ByVal uid As String) As DataTable
        Try
            Dim retData As List(Of Member) = Nothing

            Dim db As New DataClassesDataContext()
            retData = (From c In db.Members Where c.UID = uid Order By c.RID).ToList

            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)

            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Function getMemberDataTable(ByVal rid As String, ByVal pid As String) As DataTable
        Try
            Dim retData As List(Of Member) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Members Where c.RID = rid And c.PID = pid Order By c.UID).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function getAllProcessDataTable(ByVal rid As String, ByVal uid As String) As DataTable
        Try
            Dim retData As List(Of Member) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Members Where c.RID = rid And c.UID = uid Order By c.UID).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function getMemberList(ByVal rid As String, ByVal pid As String) As List(Of Member)
        Try
            Dim retData As List(Of Member) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Members Where c.RID = rid And c.PID = pid Order By c.UID).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub Add(ByVal mem As Member)
        Try
            Dim db As New DataClassesDataContext
            db.Members.InsertOnSubmit(mem)
            db.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Delete(ByVal rid As String, ByVal pid As String, ByVal uid As String)
        Try
            Dim db As New DataClassesDataContext
            Dim mem As Member = (From c In db.Members Where c.RID = rid And c.PID = pid And c.UID = uid).FirstOrDefault
            db.Members.DeleteOnSubmit(mem)
            db.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub DeleteAll(ByVal rid As String, ByVal pid As String)
        Try
            Dim db As New DataClassesDataContext
            Dim mem As Member = (From c In db.Members Where c.RID = rid And c.PID = pid).FirstOrDefault
            db.Members.DeleteOnSubmit(mem)
            db.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function ListToDataTable(Of T)(ByVal list As List(Of T)) As DataTable
        Try
            Dim dt As New DataTable()
            Dim myList As List(Of T) = list
            For Each info As PropertyInfo In GetType(T).GetProperties()
                If info IsNot Nothing Then
                    dt.Columns.Add(New DataColumn(info.Name, info.PropertyType))
                End If
            Next
            For Each tt As T In list
                Dim row As DataRow = dt.NewRow()
                For Each info As PropertyInfo In GetType(T).GetProperties()
                    row(info.Name) = info.GetValue(tt, Nothing)
                Next
                dt.Rows.Add(row)
            Next
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function ListOfRoute(ByVal strUID As String) As DataTable
        Try
            If Not xsql.Connected Then xsql.Open()
            Dim strSQL As String = "select distinct(rid) from member where uid='" & strUID & "'"

            Dim dt As DataTable = Nothing
            dt = xsql.GetDataSet(strSQL).Tables(0)
            xsql.Close()
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function getWorkInBasket(ByVal strRid As String, ByVal strPid As String, ByVal strUID As String) As DataTable
        Try
            Dim retData As List(Of WorkInProcess) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.WorkInProcesses Where c.RID = strRid And c.PID = strPid And c.UID = strUID And c.Action = "02" Order By c.DateIn Descending).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function getWorkInProcess(ByVal strRid As String, ByVal strPid As String) As DataTable
        Try
            Dim retData As List(Of WorkInProcess) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.WorkInProcesses Where c.RID = strRid And c.PID = strPid And c.Action = "00" Order By c.DateIn Descending).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function getWorkInRoute(ByVal strRid As String) As DataTable
        Try
            Dim retData As List(Of WorkInProcess) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.WorkInProcesses Where c.RID = strRid Order By c.DateIn Descending).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
