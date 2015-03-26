Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Public Class sWStatus
    Function getWstatusDatable() As DataTable
        Try
            Dim retData As List(Of WStatus) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.WStatus Order By c.Code).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getWstatusDatable(ByVal id As String) As DataTable
        Try
            Dim retData As List(Of WStatus) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.WStatus Where c.Code = id Order By c.Code).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getWstatusList() As List(Of WStatus)
        Try
            Dim retData As List(Of WStatus) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.WStatus Order By c.Code).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getWstatusList(ByVal id As String) As List(Of WStatus)
        Try
            Dim retData As List(Of WStatus) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.WStatus Where c.Code = id Order By c.Code).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub Add(ByVal obj As WStatus)
        Try
            Dim db As New DataClassesDataContext
            Dim LastId = (From c In db.WStatus Select c.Code Order By Code Descending).FirstOrDefault
            obj.Code = frontzero((LastId + 1), 2)
            db.WStatus.InsertOnSubmit(obj)
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Edit(ByVal obj As WStatus)
        Try
            Dim db As New DataClassesDataContext
            Dim oldObj As WStatus = (From c In db.WStatus Where c.Code = obj.Code).FirstOrDefault
            oldObj.Code = obj.Code
            oldObj.Dsc = obj.Dsc
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Delete(ByVal id As String)
        Try
            Dim db As New DataClassesDataContext
            Dim obj As WStatus = (From c In db.WStatus Where c.Code = id).FirstOrDefault
            db.WStatus.DeleteOnSubmit(obj)
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
