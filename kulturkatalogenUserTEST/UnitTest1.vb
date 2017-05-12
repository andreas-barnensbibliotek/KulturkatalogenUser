Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports kulturkatalogenUser

<TestClass()> Public Class UnitTest1
    Private _obj As New kk_aj_katalogenUsers
    <TestMethod()> Public Sub TestMethod1()


        _obj.getUserdata(2)


    End Sub
    <TestMethod()> Public Sub testnotify()
        _obj.getallaNoteifieringar(2)

    End Sub
End Class