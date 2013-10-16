﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.544.
// 
#pragma warning disable 1591

namespace ConnectSensorConsole.Telemetry {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TelemetrySoap", Namespace="http://sens4/")]
    public partial class Telemetry : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOTGSMLatestLevelsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOTGSMLatestLevels_V2OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Telemetry() {
            this.Url = global::ConnectSensorConsole.Properties.Settings.Default.ConnectSensorConsole_Telemetry_Telemetry;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event GetOTGSMLatestLevelsCompletedEventHandler GetOTGSMLatestLevelsCompleted;
        
        /// <remarks/>
        public event GetOTGSMLatestLevels_V2CompletedEventHandler GetOTGSMLatestLevels_V2Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sens4/HelloWorld", RequestNamespace="http://sens4/", ResponseNamespace="http://sens4/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sens4/GetOTGSMLatestLevels", RequestNamespace="http://sens4/", ResponseNamespace="http://sens4/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LatestLevel[] GetOTGSMLatestLevels(string userID, string password) {
            object[] results = this.Invoke("GetOTGSMLatestLevels", new object[] {
                        userID,
                        password});
            return ((LatestLevel[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOTGSMLatestLevelsAsync(string userID, string password) {
            this.GetOTGSMLatestLevelsAsync(userID, password, null);
        }
        
        /// <remarks/>
        public void GetOTGSMLatestLevelsAsync(string userID, string password, object userState) {
            if ((this.GetOTGSMLatestLevelsOperationCompleted == null)) {
                this.GetOTGSMLatestLevelsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOTGSMLatestLevelsOperationCompleted);
            }
            this.InvokeAsync("GetOTGSMLatestLevels", new object[] {
                        userID,
                        password}, this.GetOTGSMLatestLevelsOperationCompleted, userState);
        }
        
        private void OnGetOTGSMLatestLevelsOperationCompleted(object arg) {
            if ((this.GetOTGSMLatestLevelsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOTGSMLatestLevelsCompleted(this, new GetOTGSMLatestLevelsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sens4/GetOTGSMLatestLevels_V2", RequestNamespace="http://sens4/", ResponseNamespace="http://sens4/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LatestLevel_V2[] GetOTGSMLatestLevels_V2(string userID, string password) {
            object[] results = this.Invoke("GetOTGSMLatestLevels_V2", new object[] {
                        userID,
                        password});
            return ((LatestLevel_V2[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOTGSMLatestLevels_V2Async(string userID, string password) {
            this.GetOTGSMLatestLevels_V2Async(userID, password, null);
        }
        
        /// <remarks/>
        public void GetOTGSMLatestLevels_V2Async(string userID, string password, object userState) {
            if ((this.GetOTGSMLatestLevels_V2OperationCompleted == null)) {
                this.GetOTGSMLatestLevels_V2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOTGSMLatestLevels_V2OperationCompleted);
            }
            this.InvokeAsync("GetOTGSMLatestLevels_V2", new object[] {
                        userID,
                        password}, this.GetOTGSMLatestLevels_V2OperationCompleted, userState);
        }
        
        private void OnGetOTGSMLatestLevels_V2OperationCompleted(object arg) {
            if ((this.GetOTGSMLatestLevels_V2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOTGSMLatestLevels_V2Completed(this, new GetOTGSMLatestLevels_V2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestLevel_V2))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sens4/")]
    public partial class LatestLevel {
        
        private int levelField;
        
        private System.DateTime levelDateField;
        
        private long signalmanNoField;
        
        private int triggerPointField;
        
        private int capacityField;
        
        private string alertsField;
        
        private string accountRefField;
        
        private System.DateTime expectedCallTimeField;
        
        /// <remarks/>
        public int Level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime LevelDate {
            get {
                return this.levelDateField;
            }
            set {
                this.levelDateField = value;
            }
        }
        
        /// <remarks/>
        public long SignalmanNo {
            get {
                return this.signalmanNoField;
            }
            set {
                this.signalmanNoField = value;
            }
        }
        
        /// <remarks/>
        public int TriggerPoint {
            get {
                return this.triggerPointField;
            }
            set {
                this.triggerPointField = value;
            }
        }
        
        /// <remarks/>
        public int Capacity {
            get {
                return this.capacityField;
            }
            set {
                this.capacityField = value;
            }
        }
        
        /// <remarks/>
        public string Alerts {
            get {
                return this.alertsField;
            }
            set {
                this.alertsField = value;
            }
        }
        
        /// <remarks/>
        public string AccountRef {
            get {
                return this.accountRefField;
            }
            set {
                this.accountRefField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ExpectedCallTime {
            get {
                return this.expectedCallTimeField;
            }
            set {
                this.expectedCallTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sens4/")]
    public partial class LatestLevel_V2 : LatestLevel {
        
        private string nameField;
        
        private string fuelField;
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string townField;
        
        private string postcodeField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Fuel {
            get {
                return this.fuelField;
            }
            set {
                this.fuelField = value;
            }
        }
        
        /// <remarks/>
        public string AddressLine1 {
            get {
                return this.addressLine1Field;
            }
            set {
                this.addressLine1Field = value;
            }
        }
        
        /// <remarks/>
        public string AddressLine2 {
            get {
                return this.addressLine2Field;
            }
            set {
                this.addressLine2Field = value;
            }
        }
        
        /// <remarks/>
        public string Town {
            get {
                return this.townField;
            }
            set {
                this.townField = value;
            }
        }
        
        /// <remarks/>
        public string Postcode {
            get {
                return this.postcodeField;
            }
            set {
                this.postcodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetOTGSMLatestLevelsCompletedEventHandler(object sender, GetOTGSMLatestLevelsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOTGSMLatestLevelsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOTGSMLatestLevelsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LatestLevel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LatestLevel[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetOTGSMLatestLevels_V2CompletedEventHandler(object sender, GetOTGSMLatestLevels_V2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOTGSMLatestLevels_V2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOTGSMLatestLevels_V2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LatestLevel_V2[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LatestLevel_V2[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591