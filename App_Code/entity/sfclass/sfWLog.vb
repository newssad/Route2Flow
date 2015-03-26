Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports iStringSystem
Public Class sfWLog
    Private _WID As String
    Private _ActionMsg As String
    Private _LogDate As String
    Private _LogTime As String
    Private _IP As String
    Private _UID As String
    Public Property UID() As String
        Get
            Return _UID
        End Get
        Set(ByVal value As String)
            _UID = value
        End Set
    End Property

    Public Property IP() As String
        Get
            Return _IP
        End Get
        Set(ByVal value As String)
            _IP = value
        End Set
    End Property

    Public Property LogTime() As String
        Get
            Return _LogTime
        End Get
        Set(ByVal value As String)
            _LogTime = value
        End Set
    End Property

    Public Property LogDate() As String
        Get
            Return _LogDate
        End Get
        Set(ByVal value As String)
            _LogDate = value
        End Set
    End Property


    Public Property ActionMsg() As String
        Get
            Return _ActionMsg
        End Get
        Set(ByVal value As String)
            _ActionMsg = value
        End Set
    End Property

    Public Property WID() As String
        Get
            Return _WID
        End Get
        Set(ByVal value As String)
            _WID = value
        End Set
    End Property


End Class
