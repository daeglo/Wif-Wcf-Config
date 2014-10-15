Module Module1

    Sub Main()
        Dim svc As New SimpleService.ServiceClient()

        Dim result = svc.SayHello()

        Console.WriteLine(result)
        Console.ReadKey()
    End Sub

End Module
