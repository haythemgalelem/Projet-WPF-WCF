﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpFVItrine.Service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfSrvDll")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        string login(string Nom, string Prenom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<string> loginAsync(string Nom, string Prenom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListArticle", ReplyAction="http://tempuri.org/IService1/getListArticleResponse")]
        ClassLibDll.Article[] getListArticle();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListArticle", ReplyAction="http://tempuri.org/IService1/getListArticleResponse")]
        System.Threading.Tasks.Task<ClassLibDll.Article[]> getListArticleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPanier", ReplyAction="http://tempuri.org/IService1/getPanierResponse")]
        ClassLibDll.Article[] getPanier(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPanier", ReplyAction="http://tempuri.org/IService1/getPanierResponse")]
        System.Threading.Tasks.Task<ClassLibDll.Article[]> getPanierAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ElemAddInPani", ReplyAction="http://tempuri.org/IService1/ElemAddInPaniResponse")]
        void ElemAddInPani(ClassLibDll.Article produit, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ElemAddInPani", ReplyAction="http://tempuri.org/IService1/ElemAddInPaniResponse")]
        System.Threading.Tasks.Task ElemAddInPaniAsync(ClassLibDll.Article produit, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WpFVItrine.Service.CompositeType GetDataUsingDataContract(WpFVItrine.Service.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WpFVItrine.Service.CompositeType> GetDataUsingDataContractAsync(WpFVItrine.Service.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpFVItrine.Service.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpFVItrine.Service.IService1>, WpFVItrine.Service.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string login(string Nom, string Prenom) {
            return base.Channel.login(Nom, Prenom);
        }
        
        public System.Threading.Tasks.Task<string> loginAsync(string Nom, string Prenom) {
            return base.Channel.loginAsync(Nom, Prenom);
        }
        
        public ClassLibDll.Article[] getListArticle() {
            return base.Channel.getListArticle();
        }
        
        public System.Threading.Tasks.Task<ClassLibDll.Article[]> getListArticleAsync() {
            return base.Channel.getListArticleAsync();
        }
        
        public ClassLibDll.Article[] getPanier(string token) {
            return base.Channel.getPanier(token);
        }
        
        public System.Threading.Tasks.Task<ClassLibDll.Article[]> getPanierAsync(string token) {
            return base.Channel.getPanierAsync(token);
        }
        
        public void ElemAddInPani(ClassLibDll.Article produit, string id) {
            base.Channel.ElemAddInPani(produit, id);
        }
        
        public System.Threading.Tasks.Task ElemAddInPaniAsync(ClassLibDll.Article produit, string id) {
            return base.Channel.ElemAddInPaniAsync(produit, id);
        }
        
        public WpFVItrine.Service.CompositeType GetDataUsingDataContract(WpFVItrine.Service.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WpFVItrine.Service.CompositeType> GetDataUsingDataContractAsync(WpFVItrine.Service.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
