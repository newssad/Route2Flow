Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Reflection
Imports Softvibe.xDatabase
Public Class sfUser
    Private _UID As String
    Private _DID As String
    Private _DepType As String
    Private _Name As String
    Private _Surname As String
    Private _Password As String
    Private _Email As String
    Private _SSN As String
    Private _Address As String
    Private _Tel1 As String
    Private _Tel2 As String
    Private _Role As String
    Private _SecCode As String
    Private _UserType As String
    Public Property UserType() As String
        Get
            Return _UserType
        End Get
        Set(ByVal value As String)
            _UserType = value
        End Set
    End Property

    Public Property SecCode() As String
        Get
            Return _SecCode
        End Get
        Set(ByVal value As String)
            _SecCode = value
        End Set
    End Property

    Public Property Role() As String
        Get
            Return _Role
        End Get
        Set(ByVal value As String)
            _Role = value
        End Set
    End Property

    Public Property Tel2() As String
        Get
            Return _Tel2
        End Get
        Set(ByVal value As String)
            _Tel2 = value
        End Set
    End Property
    Public Property Tel1() As String
        Get
            Return _Tel1
        End Get
        Set(ByVal value As String)
            _Tel1 = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property

    Public Property SSN() As String
        Get
            Return _SSN
        End Get
        Set(ByVal value As String)
            _SSN = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property Surname() As String
        Get
            Return _Surname
        End Get
        Set(ByVal value As String)
            _Surname = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property


    Public Property DepType() As String
        Get
            Return _DepType
        End Get
        Set(ByVal value As String)
            _DepType = value
        End Set
    End Property

    Public Property DID() As String
        Get
            Return _DID
        End Get
        Set(ByVal value As String)
            _DID = value
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

End Class
