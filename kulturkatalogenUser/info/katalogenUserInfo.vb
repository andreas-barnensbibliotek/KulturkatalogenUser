Public Class katalogenUserInfo

    Private _userid As Integer
    Public Property Userid() As Integer
        Get
            Return _userid
        End Get
        Set(ByVal value As Integer)
            _userid = value
        End Set
    End Property

    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Private _userfornamn As String
    Public Property userfornamn() As String
        Get
            Return _userfornamn
        End Get
        Set(ByVal value As String)
            _userfornamn = value
        End Set
    End Property

    Private _userefternamn As String
    Public Property userefternamn() As String
        Get
            Return _userefternamn
        End Get
        Set(ByVal value As String)
            _userefternamn = value
        End Set
    End Property

    Private _userepost As String
    Public Property userepost() As String
        Get
            Return _userepost
        End Get
        Set(ByVal value As String)
            _userepost = value
        End Set
    End Property

    Private _userinfoheader As String
    Public Property userinfoheader() As String
        Get
            Return _userinfoheader
        End Get
        Set(ByVal value As String)
            _userinfoheader = value
        End Set
    End Property

    Private _usertel As String
    Public Property usertel() As String
        Get
            Return _usertel
        End Get
        Set(ByVal value As String)
            _usertel = value
        End Set
    End Property
    Private _usermobil As String
    Public Property usermobil() As String
        Get
            Return _usermobil
        End Get
        Set(ByVal value As String)
            _usermobil = value
        End Set
    End Property

    Private _userinfotext As String
    Public Property userinfotext() As String
        Get
            Return _userinfotext
        End Get
        Set(ByVal value As String)
            _userinfotext = value
        End Set
    End Property

    Private _userwebsite As String
    Public Property userwebsite() As String
        Get
            Return _userwebsite
        End Get
        Set(ByVal value As String)
            _userwebsite = value
        End Set
    End Property
    Private _useravdelning As String
    Public Property useravdelning() As String
        Get
            Return _useravdelning
        End Get
        Set(ByVal value As String)
            _useravdelning = value
        End Set
    End Property
    Private _useradress As String
    Public Property useradress() As String
        Get
            Return _useradress
        End Get
        Set(ByVal value As String)
            _useradress = value
        End Set
    End Property
    Private _userort As String
    Public Property userort() As String
        Get
            Return _userort
        End Get
        Set(ByVal value As String)
            _userort = value
        End Set
    End Property
    Private _userpostnr As String
    Public Property userpostnr() As String
        Get
            Return _userpostnr
        End Get
        Set(ByVal value As String)
            _userpostnr = value
        End Set
    End Property
    Private _useravatar As String
    Public Property useravatar() As String
        Get
            Return _useravatar
        End Get
        Set(ByVal value As String)
            _useravatar = value
        End Set
    End Property

    Private _userrolls As List(Of userRollInfo)
    Public Property userrollList() As List(Of userRollInfo)
        Get
            Return _userrolls
        End Get
        Set(ByVal value As List(Of userRollInfo))
            _userrolls = value
        End Set
    End Property
End Class
