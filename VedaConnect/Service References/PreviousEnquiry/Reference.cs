﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VedaConnect.PreviousEnquiry {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://vedaxml.com/vxml2/previous-enquiry-v1.wsdl", ConfigurationName="PreviousEnquiry.previousEnquiryPortType")]
    public interface previousEnquiryPortType {
        
        // CODEGEN: Generating message contract since the operation previousEnquiryOperation is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://vedaxml.com/previousEnquiry/ServiceRequest", ReplyAction="http://vedaxml.com/previousEnquiry/ServiceResult")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(base64Binary))]
        VedaConnect.PreviousEnquiry.previousEnquiryOperationResponse previousEnquiryOperation(VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vedaxml.com/previousEnquiry/ServiceRequest", ReplyAction="http://vedaxml.com/previousEnquiry/ServiceResult")]
        System.Threading.Tasks.Task<VedaConnect.PreviousEnquiry.previousEnquiryOperationResponse> previousEnquiryOperationAsync(VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vedaxml.com/vxml2/previous-enquiry-v1-0.xsd")]
    public partial class previousEnquiryRequestType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object enquiryIdField;
        
        private string[] contentTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public object enquiryId {
            get {
                return this.enquiryIdField;
            }
            set {
                this.enquiryIdField = value;
                this.RaisePropertyChanged("enquiryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contentType", DataType="token", Order=1)]
        public string[] contentType {
            get {
                return this.contentTypeField;
            }
            set {
                this.contentTypeField = value;
                this.RaisePropertyChanged("contentType");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2005/05/xmlmime")]
    public partial class base64Binary : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string contentTypeField;
        
        private byte[] valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string contentType {
            get {
                return this.contentTypeField;
            }
            set {
                this.contentTypeField = value;
                this.RaisePropertyChanged("contentType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://vedaxml.com/vxml2/previous-enquiry-v1-0.xsd")]
    public partial class previousEnquiryResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string enquiryIdField;
        
        private System.DateTime enquiryTimeField;
        
        private previousEnquiryResponseTypeBinaryData[] binaryDataField;
        
        private object[] xmlDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string enquiryId {
            get {
                return this.enquiryIdField;
            }
            set {
                this.enquiryIdField = value;
                this.RaisePropertyChanged("enquiryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime enquiryTime {
            get {
                return this.enquiryTimeField;
            }
            set {
                this.enquiryTimeField = value;
                this.RaisePropertyChanged("enquiryTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binaryData", Order=2)]
        public previousEnquiryResponseTypeBinaryData[] binaryData {
            get {
                return this.binaryDataField;
            }
            set {
                this.binaryDataField = value;
                this.RaisePropertyChanged("binaryData");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("xmlData", Order=3)]
        public object[] xmlData {
            get {
                return this.xmlDataField;
            }
            set {
                this.xmlDataField = value;
                this.RaisePropertyChanged("xmlData");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://vedaxml.com/vxml2/previous-enquiry-v1-0.xsd")]
    public partial class previousEnquiryResponseTypeBinaryData : base64Binary {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class previousEnquiryOperationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://vedaxml.com/vxml2/previous-enquiry-v1-0.xsd", Order=0)]
        public VedaConnect.PreviousEnquiry.previousEnquiryRequestType request;
        
        public previousEnquiryOperationRequest() {
        }
        
        public previousEnquiryOperationRequest(VedaConnect.PreviousEnquiry.previousEnquiryRequestType request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class previousEnquiryOperationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://vedaxml.com/vxml2/previous-enquiry-v1-0.xsd", Order=0)]
        public VedaConnect.PreviousEnquiry.previousEnquiryResponseType response;
        
        public previousEnquiryOperationResponse() {
        }
        
        public previousEnquiryOperationResponse(VedaConnect.PreviousEnquiry.previousEnquiryResponseType response) {
            this.response = response;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface previousEnquiryPortTypeChannel : VedaConnect.PreviousEnquiry.previousEnquiryPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class previousEnquiryPortTypeClient : System.ServiceModel.ClientBase<VedaConnect.PreviousEnquiry.previousEnquiryPortType>, VedaConnect.PreviousEnquiry.previousEnquiryPortType {
        
        public previousEnquiryPortTypeClient() {
        }
        
        public previousEnquiryPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public previousEnquiryPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public previousEnquiryPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public previousEnquiryPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VedaConnect.PreviousEnquiry.previousEnquiryOperationResponse VedaConnect.PreviousEnquiry.previousEnquiryPortType.previousEnquiryOperation(VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest request) {
            return base.Channel.previousEnquiryOperation(request);
        }
        
        public VedaConnect.PreviousEnquiry.previousEnquiryResponseType previousEnquiryOperation(VedaConnect.PreviousEnquiry.previousEnquiryRequestType request) {
            VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest inValue = new VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest();
            inValue.request = request;
            VedaConnect.PreviousEnquiry.previousEnquiryOperationResponse retVal = ((VedaConnect.PreviousEnquiry.previousEnquiryPortType)(this)).previousEnquiryOperation(inValue);
            return retVal.response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VedaConnect.PreviousEnquiry.previousEnquiryOperationResponse> VedaConnect.PreviousEnquiry.previousEnquiryPortType.previousEnquiryOperationAsync(VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest request) {
            return base.Channel.previousEnquiryOperationAsync(request);
        }
        
        public System.Threading.Tasks.Task<VedaConnect.PreviousEnquiry.previousEnquiryOperationResponse> previousEnquiryOperationAsync(VedaConnect.PreviousEnquiry.previousEnquiryRequestType request) {
            VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest inValue = new VedaConnect.PreviousEnquiry.previousEnquiryOperationRequest();
            inValue.request = request;
            return ((VedaConnect.PreviousEnquiry.previousEnquiryPortType)(this)).previousEnquiryOperationAsync(inValue);
        }
    }
}
