﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiExpress.WebServiceLoginUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://servicios/", ConfigurationName="WebServiceLoginUsuario.WebServiceLogin")]
    public interface WebServiceLogin {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/WebServiceLogin/ValidarLoginRequest", ReplyAction="http://servicios/WebServiceLogin/ValidarLoginResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiExpress.WebServiceLoginUsuario.ValidarLoginResponse ValidarLogin(ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://servicios/WebServiceLogin/ValidarLoginRequest", ReplyAction="http://servicios/WebServiceLogin/ValidarLoginResponse")]
        System.Threading.Tasks.Task<ServiExpress.WebServiceLoginUsuario.ValidarLoginResponse> ValidarLoginAsync(ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidarLogin", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class ValidarLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string contraseña;
        
        public ValidarLoginRequest() {
        }
        
        public ValidarLoginRequest(string usuario, string contraseña) {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ValidarLoginResponse", WrapperNamespace="http://servicios/", IsWrapped=true)]
    public partial class ValidarLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://servicios/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] @return;
        
        public ValidarLoginResponse() {
        }
        
        public ValidarLoginResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceLoginChannel : ServiExpress.WebServiceLoginUsuario.WebServiceLogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceLoginClient : System.ServiceModel.ClientBase<ServiExpress.WebServiceLoginUsuario.WebServiceLogin>, ServiExpress.WebServiceLoginUsuario.WebServiceLogin {
        
        public WebServiceLoginClient() {
        }
        
        public WebServiceLoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceLoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceLoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiExpress.WebServiceLoginUsuario.ValidarLoginResponse ServiExpress.WebServiceLoginUsuario.WebServiceLogin.ValidarLogin(ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest request) {
            return base.Channel.ValidarLogin(request);
        }
        
        public string[] ValidarLogin(string usuario, string contraseña) {
            ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest inValue = new ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest();
            inValue.usuario = usuario;
            inValue.contraseña = contraseña;
            ServiExpress.WebServiceLoginUsuario.ValidarLoginResponse retVal = ((ServiExpress.WebServiceLoginUsuario.WebServiceLogin)(this)).ValidarLogin(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiExpress.WebServiceLoginUsuario.ValidarLoginResponse> ServiExpress.WebServiceLoginUsuario.WebServiceLogin.ValidarLoginAsync(ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest request) {
            return base.Channel.ValidarLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiExpress.WebServiceLoginUsuario.ValidarLoginResponse> ValidarLoginAsync(string usuario, string contraseña) {
            ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest inValue = new ServiExpress.WebServiceLoginUsuario.ValidarLoginRequest();
            inValue.usuario = usuario;
            inValue.contraseña = contraseña;
            return ((ServiExpress.WebServiceLoginUsuario.WebServiceLogin)(this)).ValidarLoginAsync(inValue);
        }
    }
}
