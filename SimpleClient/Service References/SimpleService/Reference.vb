﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace SimpleService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="SimpleService.IService")>  _
    Public Interface IService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/SayHello", ReplyAction:="http://tempuri.org/IService/SayHelloResponse")>  _
        Function SayHello() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/SayHello", ReplyAction:="http://tempuri.org/IService/SayHelloResponse")>  _
        Function SayHelloAsync() As System.Threading.Tasks.Task(Of String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IServiceChannel
        Inherits SimpleService.IService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceClient
        Inherits System.ServiceModel.ClientBase(Of SimpleService.IService)
        Implements SimpleService.IService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function SayHello() As String Implements SimpleService.IService.SayHello
            Return MyBase.Channel.SayHello
        End Function
        
        Public Function SayHelloAsync() As System.Threading.Tasks.Task(Of String) Implements SimpleService.IService.SayHelloAsync
            Return MyBase.Channel.SayHelloAsync
        End Function
    End Class
End Namespace
