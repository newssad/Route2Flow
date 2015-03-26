Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports Softvibe.xDatabase
Public Class sfFunc
    Public Shared Function ListToDataTable(Of T)(list As List(Of T)) As DataTable
        Dim dt As New DataTable()
        For Each info As PropertyInfo In GetType(T).GetProperties()
            dt.Columns.Add(New DataColumn(info.Name, info.PropertyType))
        Next
        For Each n As T In list
            Dim row As DataRow = dt.NewRow()
            For Each info As PropertyInfo In GetType(T).GetProperties()
                row(info.Name) = info.GetValue(n, Nothing)
            Next
            dt.Rows.Add(row)
        Next
        Return dt
    End Function
    Public Shared Function currentDateddmmyyyy() As String
        Dim pdate As String = Date.Now.ToString("dd-MM-yyyy")
        Dim arr As String()
        arr = pdate.Split("-")
        If arr(2) + 543 < 2558 Then
            pdate = arr(0) & "-" & arr(1) & "-" & arr(2) + 543
        End If
        '  Dim strFormat As String = "{0:00-1:00-2:0000}"
        Return pdate
    End Function
    Public Shared Function currentDateyyyymmdd() As String
        Dim pdate As String = Date.Now.ToString("yyyy-MM-dd")
        Dim arr As String()
        arr = pdate.Split("-")
        If arr(0) + 543 < 2558 Then
            pdate = arr(0) + 543 & "/" & arr(1) & "/" & arr(2)
        End If
        Return pdate
    End Function
    Public Shared Function currentTime() As String
        Return TimeOfDay.ToString("hh:mm:ss")
    End Function
    Public Shared Function convetDateddmmyyyy(s As String) As String
        If s <> "" Then
            Dim arr = s.Split("-")
            Return arr(2) & "-" & arr(1) & "-" & arr(0)
        Else
            Return ""
        End If
    End Function
End Class
