Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Public Class sBU

    Function getBuDatable() As DataTable
        Try
            Dim retData As List(Of BusinessUnit) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.BusinessUnits Order By c.BU).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getBuDatable(ByVal id As String) As DataTable
        Try
            Dim retData As List(Of BusinessUnit) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.BusinessUnits Where c.BU = id Order By c.BU).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getBuList() As List(Of BusinessUnit)
        Try
            Dim retData As List(Of BusinessUnit) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.BusinessUnits Order By c.BU).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getBuList(ByVal id As String) As List(Of BusinessUnit)
        Try
            Dim retData As List(Of BusinessUnit) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.BusinessUnits Where c.BU = id Order By c.BU).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub Add(ByVal obj As BusinessUnit)
        Try
            Dim db As New DataClassesDataContext
            Dim LastBu = (From c In db.BusinessUnits Select c.BU Order By BU Descending).FirstOrDefault
            obj.BU = frontzero((LastBu + 1), 4)
            db.BusinessUnits.InsertOnSubmit(obj)
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Edit(ByVal obj As BusinessUnit)
        Try
            Dim db As New DataClassesDataContext
            Dim oldBu As BusinessUnit = (From c In db.BusinessUnits Where c.BU = obj.BU).FirstOrDefault
            oldBu.BU = obj.BU
            oldBu.Name = obj.Name
            oldBu.outnumber = obj.outnumber
            oldBu.password = obj.password
            oldBu.prefix = obj.prefix
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Delete(ByVal id As String)
        Try
            Dim db As New DataClassesDataContext
            Dim obj As BusinessUnit = (From c In db.BusinessUnits Where c.BU = id).FirstOrDefault
            db.BusinessUnits.DeleteOnSubmit(obj)
            db.SubmitChanges()
            db.Dispose()
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
