//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Testador.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoapSoap")]
    public interface WebServiceSoapSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Testador.ServiceReference1.HelloWorldResponse HelloWorld(Testador.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Testador.ServiceReference1.HelloWorldResponse> HelloWorldAsync(Testador.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name ConsumindoResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Consumindo", ReplyAction="*")]
        Testador.ServiceReference1.ConsumindoResponse Consumindo(Testador.ServiceReference1.ConsumindoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Consumindo", ReplyAction="*")]
        System.Threading.Tasks.Task<Testador.ServiceReference1.ConsumindoResponse> ConsumindoAsync(Testador.ServiceReference1.ConsumindoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Testador.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Testador.ServiceReference1.HelloWorldRequestBody Body) {
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
        public Testador.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Testador.ServiceReference1.HelloWorldResponseBody Body) {
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
    public partial class ConsumindoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Consumindo", Namespace="http://tempuri.org/", Order=0)]
        public Testador.ServiceReference1.ConsumindoRequestBody Body;
        
        public ConsumindoRequest() {
        }
        
        public ConsumindoRequest(Testador.ServiceReference1.ConsumindoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ConsumindoRequestBody {
        
        public ConsumindoRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsumindoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsumindoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Testador.ServiceReference1.ConsumindoResponseBody Body;
        
        public ConsumindoResponse() {
        }
        
        public ConsumindoResponse(Testador.ServiceReference1.ConsumindoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConsumindoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConsumindoResult;
        
        public ConsumindoResponseBody() {
        }
        
        public ConsumindoResponseBody(string ConsumindoResult) {
            this.ConsumindoResult = ConsumindoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapSoapChannel : Testador.ServiceReference1.WebServiceSoapSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapSoapClient : System.ServiceModel.ClientBase<Testador.ServiceReference1.WebServiceSoapSoap>, Testador.ServiceReference1.WebServiceSoapSoap {
        
        public WebServiceSoapSoapClient() {
        }
        
        public WebServiceSoapSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Testador.ServiceReference1.HelloWorldResponse Testador.ServiceReference1.WebServiceSoapSoap.HelloWorld(Testador.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Testador.ServiceReference1.HelloWorldRequest inValue = new Testador.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Testador.ServiceReference1.HelloWorldRequestBody();
            Testador.ServiceReference1.HelloWorldResponse retVal = ((Testador.ServiceReference1.WebServiceSoapSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Testador.ServiceReference1.HelloWorldResponse> Testador.ServiceReference1.WebServiceSoapSoap.HelloWorldAsync(Testador.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Testador.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            Testador.ServiceReference1.HelloWorldRequest inValue = new Testador.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Testador.ServiceReference1.HelloWorldRequestBody();
            return ((Testador.ServiceReference1.WebServiceSoapSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Testador.ServiceReference1.ConsumindoResponse Testador.ServiceReference1.WebServiceSoapSoap.Consumindo(Testador.ServiceReference1.ConsumindoRequest request) {
            return base.Channel.Consumindo(request);
        }
        
        public string Consumindo() {
            Testador.ServiceReference1.ConsumindoRequest inValue = new Testador.ServiceReference1.ConsumindoRequest();
            inValue.Body = new Testador.ServiceReference1.ConsumindoRequestBody();
            Testador.ServiceReference1.ConsumindoResponse retVal = ((Testador.ServiceReference1.WebServiceSoapSoap)(this)).Consumindo(inValue);
            return retVal.Body.ConsumindoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Testador.ServiceReference1.ConsumindoResponse> Testador.ServiceReference1.WebServiceSoapSoap.ConsumindoAsync(Testador.ServiceReference1.ConsumindoRequest request) {
            return base.Channel.ConsumindoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Testador.ServiceReference1.ConsumindoResponse> ConsumindoAsync() {
            Testador.ServiceReference1.ConsumindoRequest inValue = new Testador.ServiceReference1.ConsumindoRequest();
            inValue.Body = new Testador.ServiceReference1.ConsumindoRequestBody();
            return ((Testador.ServiceReference1.WebServiceSoapSoap)(this)).ConsumindoAsync(inValue);
        }
    }
}
