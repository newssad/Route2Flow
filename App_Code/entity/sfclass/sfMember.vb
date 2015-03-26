Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports Softvibe.xDatabase
Public Class sfMember
    Private _RID As String
    Private _PID As String
    Private _UID As String
    Private _Notification As String
    Private _WProcess As sfProcess
    Private _Step As String
    Public Property Steps() As String
        Get
            Return _Step
        End Get
        Set(ByVal value As String)
            _Step = value
        End Set
    End Property

    Public Property WProcess() As sfProcess
        Get
            Return _WProcess
        End Get
        Set(ByVal value As sfProcess)
            _WProcess = value
        End Set
    End Property

    Public Property Notification() As String
        Get
            Return _Notification
        End Get
        Set(ByVal value As String)
            _Notification = value
        End Set
    End Property

    Public Property UID() As String
        Get
            Return _UID
        End Get
        Set(ByVal value As String)
            _UID = value
        End Set
    End Property

    Public Property PID() As String
        Get
            Return _PID
        End Get
        Set(ByVal value As String)
            _PID = value
        End Set
    End Property

    Public Property RID() As String
        Get
            Return _RID
        End Get
        Set(ByVal value As String)
            _RID = value
        End Set
    End Property


End Class
