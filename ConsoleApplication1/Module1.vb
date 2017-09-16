Imports System
Imports System.IO
Imports System.Threading

Module Module1

    Sub Main()

        Console.WriteLine("홍성호")
        Console.WriteLine(12323)
        Console.WriteLine(True)

        Console.WriteLine()
        'Dim Test As Ex_1Day.Program = New Ex_1Day.Program
        'Ex_1Day.Program.csum(10, 20)
        'Dim db As sqlconn = New sqlconn(server)
        'Dim TestCs As TestNM = New TestNM(2, 3)
        'TestCs.Test()
        'Console.WriteLine(TestCs.TestFn("데이터"))

    End Sub

End Module

Class TestNM


    Public Sub New()
        Console.WriteLine("최기화")
    End Sub

    Public Sub New(ByVal iName As String)
        Console.WriteLine(iName)
    End Sub

    Public Sub New(ByVal iNo1 As Integer, ByVal iNo2 As Integer)
        Console.WriteLine(iNo1 + iNo2)
    End Sub

    Public Sub Test()
        Console.WriteLine("홍성호")
    End Sub

    Public Function TestFn(ByVal test As String)

        Return test

    End Function
End Class