Imports Microsoft.VisualBasic

Public Class sfmCreatework
    Private _wid As String
    Private _pid As String
    Private _rid As String
    Private _fid As String
    Private _wsubject As String
    Private _wdsc As String
    Private _maxtime As String
    Private _refwork As String
    Private _expiredate As String
    Private _location As String
    Public Property location() As String
        Get
            Return _location
        End Get
        Set(ByVal value As String)
            _location = value
        End Set
    End Property

    Public Property expiredate() As String
        Get
            Return _expiredate
        End Get
        Set(ByVal value As String)
            _expiredate = value
        End Set
    End Property

    Public Property refwork() As String
        Get
            Return _refwork
        End Get
        Set(ByVal value As String)
            _refwork = value
        End Set
    End Property

    Public Property maxtime() As String
        Get
            Return _maxtime
        End Get
        Set(ByVal value As String)
            _maxtime = value
        End Set
    End Property

    Public Property wdsc() As String
        Get
            Return _wdsc
        End Get
        Set(ByVal value As String)
            _wdsc = value
        End Set
    End Property

    Private _worigin As String
    Private _wowner As String
    Private _wdate As String
    Private _seclevcode As String
    Private _prioritycode As String
    Private _registerdep As String
    Private _registeruid As String
    Private _registerno As String
    Private _dateregistered As String
    Private _timeregistered As String
    Private _datecompleted As String
    Private _timecompleted As String
    Private _status As String
    Private _ip As String
    Public Property ip() As String
        Get
            Return _ip
        End Get
        Set(ByVal value As String)
            _ip = value
        End Set
    End Property

    Public Property status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Public Property timecompleted() As String
        Get
            Return _timecompleted
        End Get
        Set(ByVal value As String)
            _timecompleted = value
        End Set
    End Property

    Public Property datecompleted() As String
        Get
            Return _datecompleted
        End Get
        Set(ByVal value As String)
            _datecompleted = value
        End Set
    End Property

    Public Property timeregistered() As String
        Get
            Return _timeregistered
        End Get
        Set(ByVal value As String)
            _timeregistered = value
        End Set
    End Property

    Public Property dateregistered() As String
        Get
            Return _dateregistered
        End Get
        Set(ByVal value As String)
            _dateregistered = value
        End Set
    End Property

    Public Property registerno() As String
        Get
            Return _registerno
        End Get
        Set(ByVal value As String)
            _registerno = value
        End Set
    End Property

    Public Property registeruid() As String
        Get
            Return _registeruid
        End Get
        Set(ByVal value As String)
            _registeruid = value
        End Set
    End Property

    Public Property registerdep() As String
        Get
            Return _registerdep
        End Get
        Set(ByVal value As String)
            _registerdep = value
        End Set
    End Property

    Public Property prioritycode() As String
        Get
            Return _prioritycode
        End Get
        Set(ByVal value As String)
            _prioritycode = value
        End Set
    End Property

    Public Property seclevcode() As String
        Get
            Return _seclevcode
        End Get
        Set(ByVal value As String)
            _seclevcode = value
        End Set
    End Property

    Public Property wdate() As String
        Get
            Return _wdate
        End Get
        Set(ByVal value As String)
            _wdate = value
        End Set
    End Property

    Public Property wowner() As String
        Get
            Return _wowner
        End Get
        Set(ByVal value As String)
            _wowner = value
        End Set
    End Property

    Public Property worigin() As String
        Get
            Return _worigin
        End Get
        Set(ByVal value As String)
            _worigin = value
        End Set
    End Property

    Public Property wsubject() As String
        Get
            Return _wsubject
        End Get
        Set(ByVal value As String)
            _wsubject = value
        End Set
    End Property

    Public Property fid() As String
        Get
            Return _fid
        End Get
        Set(ByVal value As String)
            _fid = value
        End Set
    End Property

    Public Property rid() As String
        Get
            Return _rid
        End Get
        Set(ByVal value As String)
            _rid = value
        End Set
    End Property


    Public Property pid() As String
        Get
            Return _pid
        End Get
        Set(ByVal value As String)
            _pid = value
        End Set
    End Property

    Public Property wid() As String
        Get
            Return _wid
        End Get
        Set(ByVal value As String)
            _wid = value
        End Set
    End Property


End Class
