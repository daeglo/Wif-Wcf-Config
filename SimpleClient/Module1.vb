Module Module1

    Sub Main()
        Dim result As String

        Using svc As New SimpleService.ServiceClient()
            svc.ChannelFactory.Credentials.SupportInteractive = False
            svc.ChannelFactory.Credentials.UserName.UserName = "user"
            svc.ChannelFactory.Credentials.UserName.Password = "password"

            result = svc.SayHello()
        End Using

        Console.WriteLine(result)
        Console.ReadKey()
    End Sub

End Module
