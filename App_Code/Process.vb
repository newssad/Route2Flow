Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection

Public Class sProcess
    Function getProcessDatable() As DataTable
        Try
            Dim retData As List(Of Process) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Processes Order By c.PID).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getProcessDatable(ByVal id As String) As DataTable
        Try
            Dim retData As List(Of Process) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Processes Where c.PID = id Order By c.PID).ToList
            Dim dt As DataTable = Nothing
            dt = ListToDataTable(retData)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getProcessList() As List(Of Process)
        Try
            Dim retData As List(Of Process) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Processes Order By c.PID).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function getProcessList(ByVal id As Process) As List(Of Process)
        Try
            Dim retData As List(Of Process) = Nothing
            Dim db As New DataClassesDataContext()
            retData = (From c In db.Processes Where c.PID = id.PID Order By c.PID).ToList
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub Add(ByVal proc As Process)
        Try
            Dim db As New DataClassesDataContext
            db.Processes.InsertOnSubmit(proc)
            db.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Edit(ByVal proc As Process)
        Try
            Dim db As New DataClassesDataContext
            Dim oldProc As Process = (From c In db.Processes Where c.PID = proc.PID).FirstOrDefault
            oldProc.PID = proc.PID
            oldProc.RID = proc.RID
            oldProc.Name = proc.Name
            oldProc.Description = proc.Description
            oldProc.Type = proc.Type
            db.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Delete(ByVal id As String)
        Try
            Dim db As New DataClassesDataContext
            Dim proc As Process = (From c In db.Processes Where c.PID = id).FirstOrDefault
            db.Processes.DeleteOnSubmit(proc)
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
    Function getProcessProperties(ByVal PID As String) As Process
        Dim db As New DataClassesDataContext
        Dim myProcess As Process = (From c In db.Processes Where c.PID = PID).First
        Return myProcess
    End Function
End Class
