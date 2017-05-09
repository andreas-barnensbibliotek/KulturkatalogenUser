Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports kulturkatalogenUser

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()

        Dim obj As New kk_aj_katalogenUsers
        obj.getUserdata(2)


    End Sub

End Class