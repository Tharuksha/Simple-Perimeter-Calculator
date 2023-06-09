﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShapeClient.ShapeServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShapeServiceReference.ShapeServiceSoap")]
    public interface ShapeServiceSoap {
        
        // CODEGEN: Generating message contract since element name type from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComputePerimeter", ReplyAction="*")]
        ShapeClient.ShapeServiceReference.ComputePerimeterResponse ComputePerimeter(ShapeClient.ShapeServiceReference.ComputePerimeterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComputePerimeter", ReplyAction="*")]
        System.Threading.Tasks.Task<ShapeClient.ShapeServiceReference.ComputePerimeterResponse> ComputePerimeterAsync(ShapeClient.ShapeServiceReference.ComputePerimeterRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ComputePerimeterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ComputePerimeter", Namespace="http://tempuri.org/", Order=0)]
        public ShapeClient.ShapeServiceReference.ComputePerimeterRequestBody Body;
        
        public ComputePerimeterRequest() {
        }
        
        public ComputePerimeterRequest(ShapeClient.ShapeServiceReference.ComputePerimeterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ComputePerimeterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string type;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string length1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string length2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string length3;
        
        public ComputePerimeterRequestBody() {
        }
        
        public ComputePerimeterRequestBody(string type, string length1, string length2, string length3) {
            this.type = type;
            this.length1 = length1;
            this.length2 = length2;
            this.length3 = length3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ComputePerimeterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ComputePerimeterResponse", Namespace="http://tempuri.org/", Order=0)]
        public ShapeClient.ShapeServiceReference.ComputePerimeterResponseBody Body;
        
        public ComputePerimeterResponse() {
        }
        
        public ComputePerimeterResponse(ShapeClient.ShapeServiceReference.ComputePerimeterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ComputePerimeterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double ComputePerimeterResult;
        
        public ComputePerimeterResponseBody() {
        }
        
        public ComputePerimeterResponseBody(double ComputePerimeterResult) {
            this.ComputePerimeterResult = ComputePerimeterResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ShapeServiceSoapChannel : ShapeClient.ShapeServiceReference.ShapeServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShapeServiceSoapClient : System.ServiceModel.ClientBase<ShapeClient.ShapeServiceReference.ShapeServiceSoap>, ShapeClient.ShapeServiceReference.ShapeServiceSoap {
        
        public ShapeServiceSoapClient() {
        }
        
        public ShapeServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShapeServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShapeServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShapeServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ShapeClient.ShapeServiceReference.ComputePerimeterResponse ShapeClient.ShapeServiceReference.ShapeServiceSoap.ComputePerimeter(ShapeClient.ShapeServiceReference.ComputePerimeterRequest request) {
            return base.Channel.ComputePerimeter(request);
        }
        
        public double ComputePerimeter(string type, string length1, string length2, string length3) {
            ShapeClient.ShapeServiceReference.ComputePerimeterRequest inValue = new ShapeClient.ShapeServiceReference.ComputePerimeterRequest();
            inValue.Body = new ShapeClient.ShapeServiceReference.ComputePerimeterRequestBody();
            inValue.Body.type = type;
            inValue.Body.length1 = length1;
            inValue.Body.length2 = length2;
            inValue.Body.length3 = length3;
            ShapeClient.ShapeServiceReference.ComputePerimeterResponse retVal = ((ShapeClient.ShapeServiceReference.ShapeServiceSoap)(this)).ComputePerimeter(inValue);
            return retVal.Body.ComputePerimeterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ShapeClient.ShapeServiceReference.ComputePerimeterResponse> ShapeClient.ShapeServiceReference.ShapeServiceSoap.ComputePerimeterAsync(ShapeClient.ShapeServiceReference.ComputePerimeterRequest request) {
            return base.Channel.ComputePerimeterAsync(request);
        }
        
        public System.Threading.Tasks.Task<ShapeClient.ShapeServiceReference.ComputePerimeterResponse> ComputePerimeterAsync(string type, string length1, string length2, string length3) {
            ShapeClient.ShapeServiceReference.ComputePerimeterRequest inValue = new ShapeClient.ShapeServiceReference.ComputePerimeterRequest();
            inValue.Body = new ShapeClient.ShapeServiceReference.ComputePerimeterRequestBody();
            inValue.Body.type = type;
            inValue.Body.length1 = length1;
            inValue.Body.length2 = length2;
            inValue.Body.length3 = length3;
            return ((ShapeClient.ShapeServiceReference.ShapeServiceSoap)(this)).ComputePerimeterAsync(inValue);
        }
    }
}
