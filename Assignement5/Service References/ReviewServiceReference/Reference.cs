﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignement5.ReviewServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reviews", Namespace="http://schemas.datacontract.org/2004/07/ReviewService")]
    [System.SerializableAttribute()]
    public partial class Reviews : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Assignement5.ReviewServiceReference.Review[] reviewsField;
        
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
        public Assignement5.ReviewServiceReference.Review[] reviews {
            get {
                return this.reviewsField;
            }
            set {
                if ((object.ReferenceEquals(this.reviewsField, value) != true)) {
                    this.reviewsField = value;
                    this.RaisePropertyChanged("reviews");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Review", Namespace="http://schemas.datacontract.org/2004/07/ReviewService")]
    [System.SerializableAttribute()]
    public partial class Review : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string commentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ratingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Assignement5.ReviewServiceReference.Reviewer[] reviewerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int skuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string submissionTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
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
        public string comment {
            get {
                return this.commentField;
            }
            set {
                if ((object.ReferenceEquals(this.commentField, value) != true)) {
                    this.commentField = value;
                    this.RaisePropertyChanged("comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float rating {
            get {
                return this.ratingField;
            }
            set {
                if ((this.ratingField.Equals(value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Assignement5.ReviewServiceReference.Reviewer[] reviewer {
            get {
                return this.reviewerField;
            }
            set {
                if ((object.ReferenceEquals(this.reviewerField, value) != true)) {
                    this.reviewerField = value;
                    this.RaisePropertyChanged("reviewer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sku {
            get {
                return this.skuField;
            }
            set {
                if ((this.skuField.Equals(value) != true)) {
                    this.skuField = value;
                    this.RaisePropertyChanged("sku");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string submissionTime {
            get {
                return this.submissionTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.submissionTimeField, value) != true)) {
                    this.submissionTimeField = value;
                    this.RaisePropertyChanged("submissionTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reviewer", Namespace="http://schemas.datacontract.org/2004/07/ReviewService")]
    [System.SerializableAttribute()]
    public partial class Reviewer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReviewServiceReference.ReviewService")]
    public interface ReviewService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReviewService/getReviews", ReplyAction="http://tempuri.org/ReviewService/getReviewsResponse")]
        Assignement5.ReviewServiceReference.Reviews getReviews(string skuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReviewService/getReviews", ReplyAction="http://tempuri.org/ReviewService/getReviewsResponse")]
        System.Threading.Tasks.Task<Assignement5.ReviewServiceReference.Reviews> getReviewsAsync(string skuID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ReviewServiceChannel : Assignement5.ReviewServiceReference.ReviewService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReviewServiceClient : System.ServiceModel.ClientBase<Assignement5.ReviewServiceReference.ReviewService>, Assignement5.ReviewServiceReference.ReviewService {
        
        public ReviewServiceClient() {
        }
        
        public ReviewServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReviewServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Assignement5.ReviewServiceReference.Reviews getReviews(string skuID) {
            return base.Channel.getReviews(skuID);
        }
        
        public System.Threading.Tasks.Task<Assignement5.ReviewServiceReference.Reviews> getReviewsAsync(string skuID) {
            return base.Channel.getReviewsAsync(skuID);
        }
    }
}
