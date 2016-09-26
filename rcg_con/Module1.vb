Module Module1
    'jkelly@ksd.ie
    'generate a random string v1
    Sub Main(ByVal sArgs() As String)
        On Error GoTo Main_Err
        System.Threading.Thread.Sleep(1) 'force the system to wait so as to avoid having this routine being called too quickly
        Dim strlen As Integer = 5
        If sArgs.Length <> 0 Then
            If sArgs(0) = "/?" Or sArgs(0) = "?" Or sArgs(0) = "help" Or sArgs(0) = "HELP" Then
                Console.WriteLine("rcg_con <length of string>")
                Exit Sub
            End If
            strlen = sArgs(0)
        End If
        Console.Write(GenerateRandomString(strlen))
Main_Exit:
        Exit Sub
Main_Err:
        Console.WriteLine(Err.Description)
        Resume Main_Exit
    End Sub

    Public Function GenerateRandomString(ByRef iLength As Integer) As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim sResult As String = ""

        For i As Integer = 0 To iLength - 1
            sResult += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return sResult
    End Function
End Module