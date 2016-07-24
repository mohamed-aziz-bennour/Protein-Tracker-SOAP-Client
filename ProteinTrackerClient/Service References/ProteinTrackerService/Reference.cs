﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProteinTrackerClient.ProteinTrackerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int GoalField;
        
        private int TotalField;
        
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Goal {
            get {
                return this.GoalField;
            }
            set {
                if ((this.GoalField.Equals(value) != true)) {
                    this.GoalField = value;
                    this.RaisePropertyChanged("Goal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProteinTrackerService.ProteinTrackingServiceSoap")]
    public interface ProteinTrackingServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ProteinTrackerClient.ProteinTrackerService.HelloWorldResponse HelloWorld(ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.HelloWorldResponse> HelloWorldAsync(ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddProtein", ReplyAction="*")]
        int AddProtein(int amount, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddProtein", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddProteinAsync(int amount, int userId);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddUser", ReplyAction="*")]
        ProteinTrackerClient.ProteinTrackerService.AddUserResponse AddUser(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddUser", ReplyAction="*")]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddUserResponse> AddUserAsync(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request);
        
        // CODEGEN: Generating message contract since element name ListUsersResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListUsers", ReplyAction="*")]
        ProteinTrackerClient.ProteinTrackerService.ListUsersResponse ListUsers(ProteinTrackerClient.ProteinTrackerService.ListUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListUsers", ReplyAction="*")]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.ListUsersResponse> ListUsersAsync(ProteinTrackerClient.ProteinTrackerService.ListUsersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ProteinTrackerClient.ProteinTrackerService.HelloWorldRequestBody Body) {
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
        public ProteinTrackerClient.ProteinTrackerService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ProteinTrackerClient.ProteinTrackerService.HelloWorldResponseBody Body) {
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
    public partial class AddUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddUser", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody Body;
        
        public AddUserRequest() {
        }
        
        public AddUserRequest(ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int goal;
        
        public AddUserRequestBody() {
        }
        
        public AddUserRequestBody(string name, int goal) {
            this.name = name;
            this.goal = goal;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.AddUserResponseBody Body;
        
        public AddUserResponse() {
        }
        
        public AddUserResponse(ProteinTrackerClient.ProteinTrackerService.AddUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddUserResult;
        
        public AddUserResponseBody() {
        }
        
        public AddUserResponseBody(int AddUserResult) {
            this.AddUserResult = AddUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListUsersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListUsers", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.ListUsersRequestBody Body;
        
        public ListUsersRequest() {
        }
        
        public ListUsersRequest(ProteinTrackerClient.ProteinTrackerService.ListUsersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListUsersRequestBody {
        
        public ListUsersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListUsersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListUsersResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.ListUsersResponseBody Body;
        
        public ListUsersResponse() {
        }
        
        public ListUsersResponse(ProteinTrackerClient.ProteinTrackerService.ListUsersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListUsersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.User[] ListUsersResult;
        
        public ListUsersResponseBody() {
        }
        
        public ListUsersResponseBody(ProteinTrackerClient.ProteinTrackerService.User[] ListUsersResult) {
            this.ListUsersResult = ListUsersResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProteinTrackingServiceSoapChannel : ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProteinTrackingServiceSoapClient : System.ServiceModel.ClientBase<ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap>, ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap {
        
        public ProteinTrackingServiceSoapClient() {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackingServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProteinTrackerClient.ProteinTrackerService.HelloWorldResponse ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.HelloWorld(ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest inValue = new ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.HelloWorldRequestBody();
            ProteinTrackerClient.ProteinTrackerService.HelloWorldResponse retVal = ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.HelloWorldResponse> ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.HelloWorldAsync(ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.HelloWorldResponse> HelloWorldAsync() {
            ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest inValue = new ProteinTrackerClient.ProteinTrackerService.HelloWorldRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.HelloWorldRequestBody();
            return ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int AddProtein(int amount, int userId) {
            return base.Channel.AddProtein(amount, userId);
        }
        
        public System.Threading.Tasks.Task<int> AddProteinAsync(int amount, int userId) {
            return base.Channel.AddProteinAsync(amount, userId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProteinTrackerClient.ProteinTrackerService.AddUserResponse ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.AddUser(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request) {
            return base.Channel.AddUser(request);
        }
        
        public int AddUser(string name, int goal) {
            ProteinTrackerClient.ProteinTrackerService.AddUserRequest inValue = new ProteinTrackerClient.ProteinTrackerService.AddUserRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody();
            inValue.Body.name = name;
            inValue.Body.goal = goal;
            ProteinTrackerClient.ProteinTrackerService.AddUserResponse retVal = ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).AddUser(inValue);
            return retVal.Body.AddUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddUserResponse> ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.AddUserAsync(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request) {
            return base.Channel.AddUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddUserResponse> AddUserAsync(string name, int goal) {
            ProteinTrackerClient.ProteinTrackerService.AddUserRequest inValue = new ProteinTrackerClient.ProteinTrackerService.AddUserRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody();
            inValue.Body.name = name;
            inValue.Body.goal = goal;
            return ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).AddUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProteinTrackerClient.ProteinTrackerService.ListUsersResponse ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.ListUsers(ProteinTrackerClient.ProteinTrackerService.ListUsersRequest request) {
            return base.Channel.ListUsers(request);
        }
        
        public ProteinTrackerClient.ProteinTrackerService.User[] ListUsers() {
            ProteinTrackerClient.ProteinTrackerService.ListUsersRequest inValue = new ProteinTrackerClient.ProteinTrackerService.ListUsersRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.ListUsersRequestBody();
            ProteinTrackerClient.ProteinTrackerService.ListUsersResponse retVal = ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).ListUsers(inValue);
            return retVal.Body.ListUsersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.ListUsersResponse> ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.ListUsersAsync(ProteinTrackerClient.ProteinTrackerService.ListUsersRequest request) {
            return base.Channel.ListUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.ListUsersResponse> ListUsersAsync() {
            ProteinTrackerClient.ProteinTrackerService.ListUsersRequest inValue = new ProteinTrackerClient.ProteinTrackerService.ListUsersRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.ListUsersRequestBody();
            return ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).ListUsersAsync(inValue);
        }
    }
}
