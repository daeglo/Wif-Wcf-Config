﻿Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService" in both code and config file together.
<ServiceContract()>
Public Interface IService

    <OperationContract()>
    Function SayHello() As String

End Interface
