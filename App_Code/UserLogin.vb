Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection

Public Class sUserLogin
   Implements IDisposable
    Dim context As New DataClassesDataContext()

#Region "################################### Connection ####################################################"
    Sub New()
        context = New DataClassesDataContext
    End Sub
    Public Sub Dispose() Implements System.IDisposable.Dispose
        context.Dispose()
    End Sub
    Sub Save()
        context.SubmitChanges()
    End Sub
#End Region
    Function LoginDatable(ByVal user As String, ByVal password As String) As IEnumerable(Of UserLogin)
        Try
            Dim retData As List(Of UserLogin) = Nothing

            '  Dim db As New DataClassesDataContext()
            retData = (From c In context.UserLogins Where c.UID = user And c.Password = password And c.DepType = "0" Order By c.UID).ToList

            ' Dim dt As DataTable = Nothing
            'dt = ListToDataTable(retData)
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
