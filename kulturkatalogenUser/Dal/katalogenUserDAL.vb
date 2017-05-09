Public Class katalogenUserDAL
    'Private _connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=dnndev_v902.me;Persist Security Info=True;User ID=dnndev_v902.me;Password=L0rda1f"
    Private _connectionString As String = "Data Source=DE-1896;Initial Catalog=kulturkatalogenDB;User ID=kulturkatalogenDB;Password=L0rda1f"
    Private _linqObj As New kk_aj_katalogenUserLinqDataContext(_connectionString)

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
                Case 22
                    tmpobj.userinfoheader = t.PropertyValue
                Case 28
                    tmpobj.usertel = t.PropertyValue
                Case 26
                    tmpobj.userinfotext = t.PropertyValue
                Case 29
                    tmpobj.usermobil = t.PropertyValue
                Case 31
                    tmpobj.userwebsite = t.PropertyValue
                Case 37
                    tmpobj.useravdelning = t.PropertyValue
                Case 38
                    tmpobj.useradress = t.PropertyValue
                Case 39
                    tmpobj.userort = t.PropertyValue
                Case 42
                    tmpobj.userpostnr = t.PropertyValue
                Case 45
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
End Class
