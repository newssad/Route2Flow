Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection

Public Class sDepartment
    Function getDepartmentDatable() As DataTable
        Try
            Dim retData As List(Of Department) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Departments Order By c.DID).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getDepartmentDatable(ByVal id As String) As DataTable
        Try
            Dim retData As List(Of Department) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Departments Where c.DID = id Order By c.DID).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getDepartmentList() As List(Of Department)
        Try
            Dim retData As List(Of Department) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Departments Order By c.DID).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getDepartmentList(ByVal id As String) As List(Of Department)
        Try
            Dim retData As List(Of Department) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Departments Where c.DID = id Order By c.DID).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub Add(ByVal dep As Department)
        Try
            Dim db As New DataClassesDataContext
            db.Departments.InsertOnSubmit(dep)
            db.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Edit(ByVal dep As Department)
        Try
            Dim db As New DataClassesDataContext
            Dim olddata As Department = (From c In db.Departments Where c.DID = dep.DID).FirstOrDefault
            olddata.BU = dep.BU
            olddata.CLASS = dep.CLASS
            olddata.DID = dep.DID
            olddata.DocuName = dep.DocuName
            olddata.DSC = dep.DSC
            olddata.HomeDir = dep.HomeDir
            olddata.ItemNo = dep.ItemNo
            olddata.PASSWORD = dep.PASSWORD
            olddata.RegisterNo = dep.RegisterNo
            olddata.SendNo = dep.SendNo
            olddata.StateCode = dep.StateCode
            olddata.UserLogins = dep.UserLogins
            olddata.Wfdsc = dep.Wfdsc
            olddata.WFID = dep.WFID

            db.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id">primary key</param>
    ''' <remarks>primary key</remarks>
    Sub Delete(ByVal id As String)
        Try
            Dim db As New DataClassesDataContext
            Dim dep As Department = (From c In db.Departments Where c.DID = id).FirstOrDefault
            db.Departments.DeleteOnSubmit(dep)
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
End Class
