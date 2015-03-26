Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection

Public Class sRoute

    Function getRouteList() As List(Of Route)
        Try
            Dim retData As List(Of Route) = Nothing
            Dim db As New DataClassesDataContext
            retData = (From c In db.Routes Order By c.RID).ToList
            db.Dispose()
            Return retData
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function getRouteList(ByVal id As String) As List(Of Route)
        Try
            Dim retData As List(Of Route) = Nothing
            Dim db As New DataClassesDataContext
            retData = (From c In db.Routes Where c.RID = id).ToList
            db.Dispose()
            Return retData
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Sub Add(ByVal R As Route)
        Try
            Dim db As New DataClassesDataContext
            db.Routes.InsertOnSubmit(R)
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Edit(ByVal R As Route)
        Try
            Dim db As New DataClassesDataContext
            Dim oldR As Route = (From c In db.Routes Where c.RID = R.RID).FirstOrDefault
            oldR.RID = R.RID
            oldR.Name = R.Name
            oldR.LaunchDate = R.LaunchDate
            oldR.ExpiryDate = R.ExpiryDate
            oldR.DateCreated = R.DateCreated
            oldR.Authors = R.Authors
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Delete(ByVal id As String)
        Try
            Dim db As New DataClassesDataContext
            Dim R As Route = (From c In db.Routes Where c.RID = id).FirstOrDefault
            db.Routes.DeleteOnSubmit(R)
            db.SubmitChanges()
            db.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Function getRouteProperties(ByVal rid As String) As Route
        Dim db As New DataClassesDataContext
        Dim myRoute As Route = (From c In db.Routes Where c.RID = rid).First
        Return myRoute
    End Function
End Class
