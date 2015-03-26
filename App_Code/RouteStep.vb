Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Public Class sRouteStep

    Function getRouteStepDatable(ByVal rid As String) As DataTable
        Try
            Dim retData As List(Of [Step]) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Steps Where c.RID = rid Order By c.Step).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function getRouteStepList(ByVal rid As String) As List(Of [Step])
        Try
            Dim retData As List(Of [Step]) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Steps Where c.RID = rid Order By c.Step).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub Add(ByVal obj As [Step])
        Try
            Dim db As New DataClassesDataContext
            Dim LastId = (From c In db.Steps Where c.RID = obj.RID Select c.Step Order By [Step] Descending).FirstOrDefault
            obj.Step = frontzero((LastId + 1), 2)
            db.Steps.InsertOnSubmit(obj)
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Edit(ByVal obj As [Step])
        Try
            Dim db As New DataClassesDataContext
            Dim oldObj As [Step] = (From c In db.Steps Where c.RID = obj.RID And c.Step = obj.Step).FirstOrDefault
            oldObj.RID = obj.RID
            oldObj.PID = obj.PID
            oldObj.Step = obj.Step
            oldObj.Action = obj.Action
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Delete(ByVal rid As String, ByVal [Step] As String, ByVal Action As String, ByVal PID As String)
        Try
            Dim db As New DataClassesDataContext
            Dim obj As [Step] = (From c In db.Steps Where c.RID = rid And c.Step = [Step] And c.Action = Action And c.PID = PID).FirstOrDefault
            db.Steps.DeleteOnSubmit(obj)
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
