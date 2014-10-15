' NOTE: You can use the "Rename" command on the context menu to change the class name "Service" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.vb at the Solution Explorer and start debugging.
Public Class Service
    Implements IService

    Public Function SayHello() As String Implements IService.SayHello
        Return "Hello, world!"
    End Function

End Class
