Public Class katalogenUserDAL
    Private _connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=dnndev_v902.me;Persist Security Info=True;User ID=dnndev_v902.me;Password=L0rda1f"
    'Private _connectionString As String = "Data Source=DE-1896;Initial Catalog=kulturkatalogenDB;User ID=kulturkatalogenDB;Password=L0rda1f"
    Private _linqObj As New kk_aj_katalogenUserLinqDataContext(_connectionString)

#Region "användardata"


    Public Function getUserData(userid As Integer) As katalogenUserInfo
        Dim takefirst As Boolean = True
        Dim tmpobj As New katalogenUserInfo

        Dim usrinfolist = From p In _linqObj.kk_aj_proc_getuserdata(userid)
                          Select p

        For Each t In usrinfolist
            If takefirst Then
                tmpobj.Userid = t.UserID
                tmpobj.Username = t.Username
                tmpobj.userfornamn = t.FirstName
                tmpobj.userefternamn = t.LastName
                tmpobj.userepost = t.Email
                takefirst = False
            End If

            Select Case t.PropertyDefinitionID
                Case 22 ' Prefix
                    tmpobj.userinfoheader = t.PropertyValue
                Case 28 'contact Telephone
                    tmpobj.usertel = t.PropertyValue
                Case 26 'basic Biography
                    tmpobj.userinfotext = t.PropertyValue
                Case 29 ' contact Cell
                    tmpobj.usermobil = t.PropertyValue
                Case 31 'contact Website
                    tmpobj.userwebsite = t.PropertyValue
                Case 37 'location unit
                    tmpobj.useravdelning = t.PropertyValue
                Case 38 'location street
                    tmpobj.useradress = t.PropertyValue
                Case 39 'location city
                    tmpobj.userort = t.PropertyValue
                Case 42 'location postalcode
                    tmpobj.userpostnr = t.PropertyValue
                Case 45 'avatar
                    tmpobj.useravatar = t.PropertyValue
            End Select
        Next
        tmpobj.userrollList = getuserRollList(userid)


        Return tmpobj

    End Function


    Public Function getuserRollList(userid As Integer) As List(Of userRollInfo)

        Dim retobj = New List(Of userRollInfo)

        Dim usrRollist = From p In _linqObj.kk_aj_proc_getuserrolls(userid)
                         Select p

        For Each t In usrRollist
            Dim tmp As New userRollInfo

            tmp.userrollid = t.RoleID
            tmp.userrollname = t.RoleName
            retobj.Add(tmp)
        Next

        Return retobj
    End Function
#End Region

#Region "notifieringar och messages"
    Public Function getnotifieringar(userid As Integer, notetyp As Integer) As List(Of notifieringsInfo)
        Dim retobj As New List(Of notifieringsInfo)

        Dim mess = From i In _linqObj.kk_aj_tbl_Notifieringars
                   Where i.noteTypId = notetyp And (i.userid = userid Or i.userid = 0)

        For Each t In mess
            Dim tmpobj As New notifieringsInfo
            tmpobj.NoteID = t.noteID
            tmpobj.NoteTypID = t.noteTypId
            tmpobj.UserID = t.userid
            tmpobj.Title = t.title
            tmpobj.Url = t.url
            tmpobj.Datum = t.date
            tmpobj.ExtraNote = t.extranote
            retobj.Add(tmpobj)
        Next

        Return retobj
    End Function



#End Region
End Class
