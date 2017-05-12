Public Class usernotifieringHandler
    Private _dalobj As New katalogenUserDAL

    Public Function getallnotifications(userid As Integer) As notifieringarMainInfo
        Dim retobj As New notifieringarMainInfo
        Try
            retobj.MessList = _dalobj.getnotifieringar(userid, 1)
            retobj.NotifyList = _dalobj.getnotifieringar(userid, 2)
            retobj.TaskList = _dalobj.getnotifieringar(userid, 3)
            retobj.Userinfo = _dalobj.getUserData(userid)
            retobj.Status = "notifieringar ok!"
        Catch ex As Exception
            retobj.Status = "Fel vid hämtning av notifieringar!"
        End Try


        Return retobj

    End Function

End Class
