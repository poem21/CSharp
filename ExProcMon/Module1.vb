Imports System
Imports System.IO
Imports System.Threading

Module Module1

    Private iProc1 As Process = New Process

    Sub Main(ByVal Args() As String)

        'ProcResultRead()

        If My.Computer.Network.Ping("10.10.1.1") = False Then Console.WriteLine("네트워크 오류") Else Console.WriteLine("네트워크 정상")

        'For Each iParam As String In Args
        '    Console.WriteLine(iParam)
        'Next

        'Do While True

        '    CHKproc("NotePad")
        '    Thread.Sleep(2000)
        '    ProcStart()

        '    Thread.Sleep(2000)
        'Loop

    End Sub

    Private Sub CHKproc(ByVal ProcName As String)

        Try
            For Each iProc As Process In Process.GetProcessesByName(ProcName.ToUpper)
                Try
                    iProc.Kill()

                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ProcStart()

        'Dim iProc As Process = New Process

        iProc1.StartInfo.FileName = "c:\windows\system32\notepad.exe"
        iProc1.StartInfo.Arguments = "C:\dir.txt"
        iProc1.StartInfo.WorkingDirectory = "c:\windows\system32"
        iProc1.Start()


    End Sub

    Private Sub ProcResultRead()

        Dim iProc As Process = New Process
        Dim temp() As String
        Dim iNo As Integer = 0
        iProc.StartInfo.FileName = "cmd.exe"
        iProc.StartInfo.Arguments = "/C dir c:\"
        iProc.StartInfo.UseShellExecute = False
        iProc.StartInfo.RedirectStandardOutput = True
        iProc.Start()

        temp = iProc.StandardOutput.ReadToEnd().Split(vbCrLf) '"\n\r"

        iProc.WaitForExit()

        For Each iLine As String In temp
            iNo += 1
            Console.WriteLine("Line : {0}  - {1}", iNo, iLine)
        Next
        iProc.Dispose()
        iProc = Nothing

    End Sub

End Module
