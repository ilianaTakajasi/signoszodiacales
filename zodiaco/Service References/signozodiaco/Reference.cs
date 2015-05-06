﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18449
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zodiaco.signozodiaco {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="signozodiaco.zodiacoSoap")]
    public interface zodiacoSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento signoResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/signo", ReplyAction="*")]
        zodiaco.signozodiaco.signoResponse signo(zodiaco.signozodiaco.signoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/signo", ReplyAction="*")]
        System.Threading.Tasks.Task<zodiaco.signozodiaco.signoResponse> signoAsync(zodiaco.signozodiaco.signoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class signoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="signo", Namespace="http://tempuri.org/", Order=0)]
        public zodiaco.signozodiaco.signoRequestBody Body;
        
        public signoRequest() {
        }
        
        public signoRequest(zodiaco.signozodiaco.signoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class signoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int dia;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int mes;
        
        public signoRequestBody() {
        }
        
        public signoRequestBody(int dia, int mes) {
            this.dia = dia;
            this.mes = mes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class signoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="signoResponse", Namespace="http://tempuri.org/", Order=0)]
        public zodiaco.signozodiaco.signoResponseBody Body;
        
        public signoResponse() {
        }
        
        public signoResponse(zodiaco.signozodiaco.signoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class signoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string signoResult;
        
        public signoResponseBody() {
        }
        
        public signoResponseBody(string signoResult) {
            this.signoResult = signoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface zodiacoSoapChannel : zodiaco.signozodiaco.zodiacoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class zodiacoSoapClient : System.ServiceModel.ClientBase<zodiaco.signozodiaco.zodiacoSoap>, zodiaco.signozodiaco.zodiacoSoap {
        
        public zodiacoSoapClient() {
        }
        
        public zodiacoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public zodiacoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public zodiacoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public zodiacoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        zodiaco.signozodiaco.signoResponse zodiaco.signozodiaco.zodiacoSoap.signo(zodiaco.signozodiaco.signoRequest request) {
            return base.Channel.signo(request);
        }
        
        public string signo(int dia, int mes) {
            zodiaco.signozodiaco.signoRequest inValue = new zodiaco.signozodiaco.signoRequest();
            inValue.Body = new zodiaco.signozodiaco.signoRequestBody();
            inValue.Body.dia = dia;
            inValue.Body.mes = mes;
            zodiaco.signozodiaco.signoResponse retVal = ((zodiaco.signozodiaco.zodiacoSoap)(this)).signo(inValue);
            return retVal.Body.signoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<zodiaco.signozodiaco.signoResponse> zodiaco.signozodiaco.zodiacoSoap.signoAsync(zodiaco.signozodiaco.signoRequest request) {
            return base.Channel.signoAsync(request);
        }
        
        public System.Threading.Tasks.Task<zodiaco.signozodiaco.signoResponse> signoAsync(int dia, int mes) {
            zodiaco.signozodiaco.signoRequest inValue = new zodiaco.signozodiaco.signoRequest();
            inValue.Body = new zodiaco.signozodiaco.signoRequestBody();
            inValue.Body.dia = dia;
            inValue.Body.mes = mes;
            return ((zodiaco.signozodiaco.zodiacoSoap)(this)).signoAsync(inValue);
        }
    }
}