﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceConsumer.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ExampleWSSoap")]
    public interface ExampleWSSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ServiceConsumer.ServiceReference1.HelloWorldResponse HelloWorld(ServiceConsumer.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ServiceConsumer.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hello", ReplyAction="*")]
        ServiceConsumer.ServiceReference1.HelloResponse Hello(ServiceConsumer.ServiceReference1.HelloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hello", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.HelloResponse> HelloAsync(ServiceConsumer.ServiceReference1.HelloRequest request);
        
        // CODEGEN: Generating message contract since element name getDateResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDate", ReplyAction="*")]
        ServiceConsumer.ServiceReference1.getDateResponse getDate(ServiceConsumer.ServiceReference1.getDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDate", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.getDateResponse> getDateAsync(ServiceConsumer.ServiceReference1.getDateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ServiceConsumer.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ServiceConsumer.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceConsumer.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ServiceConsumer.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Hello", Namespace="http://tempuri.org/", Order=0)]
        public ServiceConsumer.ServiceReference1.HelloRequestBody Body;
        
        public HelloRequest() {
        }
        
        public HelloRequest(ServiceConsumer.ServiceReference1.HelloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public HelloRequestBody() {
        }
        
        public HelloRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceConsumer.ServiceReference1.HelloResponseBody Body;
        
        public HelloResponse() {
        }
        
        public HelloResponse(ServiceConsumer.ServiceReference1.HelloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloResult;
        
        public HelloResponseBody() {
        }
        
        public HelloResponseBody(string HelloResult) {
            this.HelloResult = HelloResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getDate", Namespace="http://tempuri.org/", Order=0)]
        public ServiceConsumer.ServiceReference1.getDateRequestBody Body;
        
        public getDateRequest() {
        }
        
        public getDateRequest(ServiceConsumer.ServiceReference1.getDateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getDateRequestBody {
        
        public getDateRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getDateResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceConsumer.ServiceReference1.getDateResponseBody Body;
        
        public getDateResponse() {
        }
        
        public getDateResponse(ServiceConsumer.ServiceReference1.getDateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getDateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getDateResult;
        
        public getDateResponseBody() {
        }
        
        public getDateResponseBody(string getDateResult) {
            this.getDateResult = getDateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExampleWSSoapChannel : ServiceConsumer.ServiceReference1.ExampleWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExampleWSSoapClient : System.ServiceModel.ClientBase<ServiceConsumer.ServiceReference1.ExampleWSSoap>, ServiceConsumer.ServiceReference1.ExampleWSSoap {
        
        public ExampleWSSoapClient() {
        }
        
        public ExampleWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExampleWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExampleWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExampleWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceConsumer.ServiceReference1.HelloWorldResponse ServiceConsumer.ServiceReference1.ExampleWSSoap.HelloWorld(ServiceConsumer.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ServiceConsumer.ServiceReference1.HelloWorldRequest inValue = new ServiceConsumer.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ServiceConsumer.ServiceReference1.HelloWorldRequestBody();
            ServiceConsumer.ServiceReference1.HelloWorldResponse retVal = ((ServiceConsumer.ServiceReference1.ExampleWSSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.HelloWorldResponse> ServiceConsumer.ServiceReference1.ExampleWSSoap.HelloWorldAsync(ServiceConsumer.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ServiceConsumer.ServiceReference1.HelloWorldRequest inValue = new ServiceConsumer.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ServiceConsumer.ServiceReference1.HelloWorldRequestBody();
            return ((ServiceConsumer.ServiceReference1.ExampleWSSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceConsumer.ServiceReference1.HelloResponse ServiceConsumer.ServiceReference1.ExampleWSSoap.Hello(ServiceConsumer.ServiceReference1.HelloRequest request) {
            return base.Channel.Hello(request);
        }
        
        public string Hello(string nombre) {
            ServiceConsumer.ServiceReference1.HelloRequest inValue = new ServiceConsumer.ServiceReference1.HelloRequest();
            inValue.Body = new ServiceConsumer.ServiceReference1.HelloRequestBody();
            inValue.Body.nombre = nombre;
            ServiceConsumer.ServiceReference1.HelloResponse retVal = ((ServiceConsumer.ServiceReference1.ExampleWSSoap)(this)).Hello(inValue);
            return retVal.Body.HelloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.HelloResponse> ServiceConsumer.ServiceReference1.ExampleWSSoap.HelloAsync(ServiceConsumer.ServiceReference1.HelloRequest request) {
            return base.Channel.HelloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.HelloResponse> HelloAsync(string nombre) {
            ServiceConsumer.ServiceReference1.HelloRequest inValue = new ServiceConsumer.ServiceReference1.HelloRequest();
            inValue.Body = new ServiceConsumer.ServiceReference1.HelloRequestBody();
            inValue.Body.nombre = nombre;
            return ((ServiceConsumer.ServiceReference1.ExampleWSSoap)(this)).HelloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceConsumer.ServiceReference1.getDateResponse ServiceConsumer.ServiceReference1.ExampleWSSoap.getDate(ServiceConsumer.ServiceReference1.getDateRequest request) {
            return base.Channel.getDate(request);
        }
        
        public string getDate() {
            ServiceConsumer.ServiceReference1.getDateRequest inValue = new ServiceConsumer.ServiceReference1.getDateRequest();
            inValue.Body = new ServiceConsumer.ServiceReference1.getDateRequestBody();
            ServiceConsumer.ServiceReference1.getDateResponse retVal = ((ServiceConsumer.ServiceReference1.ExampleWSSoap)(this)).getDate(inValue);
            return retVal.Body.getDateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.getDateResponse> ServiceConsumer.ServiceReference1.ExampleWSSoap.getDateAsync(ServiceConsumer.ServiceReference1.getDateRequest request) {
            return base.Channel.getDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceConsumer.ServiceReference1.getDateResponse> getDateAsync() {
            ServiceConsumer.ServiceReference1.getDateRequest inValue = new ServiceConsumer.ServiceReference1.getDateRequest();
            inValue.Body = new ServiceConsumer.ServiceReference1.getDateRequestBody();
            return ((ServiceConsumer.ServiceReference1.ExampleWSSoap)(this)).getDateAsync(inValue);
        }
    }
}
