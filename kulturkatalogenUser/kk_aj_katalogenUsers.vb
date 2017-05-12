Public Class kk_aj_katalogenUsers

    Private _dalobj As New katalogenUserDAL
    Public Function getUserdata(userid As Integer) As katalogenUserInfo

        Return _dalobj.getUserData(userid)

    End Function

    Public Function getallaNoteifieringar(userid As Integer) As notifieringarMainInfo
        Dim notobj As New usernotifieringHandler
        Return notobj.getallnotifications(userid)
    End Function
End Class
