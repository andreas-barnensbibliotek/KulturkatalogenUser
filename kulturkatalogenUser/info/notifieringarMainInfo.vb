Public Class notifieringarMainInfo
    Private _messtyplist As List(Of notifieringsInfo)
    Public Property MessList() As List(Of notifieringsInfo)
        Get
            Return _messtyplist
        End Get
        Set(ByVal value As List(Of notifieringsInfo))
            _messtyplist = value
        End Set
    End Property

    Private _notifytyplist As List(Of notifieringsInfo)
    Public Property NotifyList() As List(Of notifieringsInfo)
        Get
            Return _notifytyplist
        End Get
        Set(ByVal value As List(Of notifieringsInfo))
            _notifytyplist = value
        End Set
    End Property

    Private _tasttyplist As List(Of notifieringsInfo)
    Public Property TaskList() As List(Of notifieringsInfo)
        Get
            Return _tasttyplist
        End Get
        Set(ByVal value As List(Of notifieringsInfo))
            _tasttyplist = value
        End Set
    End Property

    Private _userinfo As katalogenUserInfo
    Public Property Userinfo() As katalogenUserInfo
        Get
            Return _userinfo
        End Get
        Set(ByVal value As katalogenUserInfo)
            _userinfo = value
        End Set
    End Property

    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property
End Class
