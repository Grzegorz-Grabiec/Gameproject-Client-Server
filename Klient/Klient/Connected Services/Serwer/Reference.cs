﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klient.Serwer {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gracz", Namespace="http://schemas.datacontract.org/2004/07/Gameservice")]
    [System.SerializableAttribute()]
    public partial class Gracz : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double KierunekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double VField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool gazField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool hamluecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool lewoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool prawoField;
        
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
        public double Kierunek {
            get {
                return this.KierunekField;
            }
            set {
                if ((this.KierunekField.Equals(value) != true)) {
                    this.KierunekField = value;
                    this.RaisePropertyChanged("Kierunek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nick {
            get {
                return this.NickField;
            }
            set {
                if ((object.ReferenceEquals(this.NickField, value) != true)) {
                    this.NickField = value;
                    this.RaisePropertyChanged("Nick");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double V {
            get {
                return this.VField;
            }
            set {
                if ((this.VField.Equals(value) != true)) {
                    this.VField = value;
                    this.RaisePropertyChanged("V");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool gaz {
            get {
                return this.gazField;
            }
            set {
                if ((this.gazField.Equals(value) != true)) {
                    this.gazField = value;
                    this.RaisePropertyChanged("gaz");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool hamluec {
            get {
                return this.hamluecField;
            }
            set {
                if ((this.hamluecField.Equals(value) != true)) {
                    this.hamluecField = value;
                    this.RaisePropertyChanged("hamluec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool lewo {
            get {
                return this.lewoField;
            }
            set {
                if ((this.lewoField.Equals(value) != true)) {
                    this.lewoField = value;
                    this.RaisePropertyChanged("lewo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool prawo {
            get {
                return this.prawoField;
            }
            set {
                if ((this.prawoField.Equals(value) != true)) {
                    this.prawoField = value;
                    this.RaisePropertyChanged("prawo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Serwer.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Rejestruj", ReplyAction="http://tempuri.org/IService1/RejestrujResponse")]
        void Rejestruj(string nick);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Rejestruj", ReplyAction="http://tempuri.org/IService1/RejestrujResponse")]
        System.Threading.Tasks.Task RejestrujAsync(string nick);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/idz", ReplyAction="http://tempuri.org/IService1/idzResponse")]
        void idz(string nick, int dx, int dy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/idz", ReplyAction="http://tempuri.org/IService1/idzResponse")]
        System.Threading.Tasks.Task idzAsync(string nick, int dx, int dy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Gaz", ReplyAction="http://tempuri.org/IService1/GazResponse")]
        void Gaz(string nick, int dx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Gaz", ReplyAction="http://tempuri.org/IService1/GazResponse")]
        System.Threading.Tasks.Task GazAsync(string nick, int dx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Dzialaj", ReplyAction="http://tempuri.org/IService1/DzialajResponse")]
        void Dzialaj(string nick, double dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Dzialaj", ReplyAction="http://tempuri.org/IService1/DzialajResponse")]
        System.Threading.Tasks.Task DzialajAsync(string nick, double dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListaGraczy", ReplyAction="http://tempuri.org/IService1/ListaGraczyResponse")]
        Klient.Serwer.Gracz[] ListaGraczy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListaGraczy", ReplyAction="http://tempuri.org/IService1/ListaGraczyResponse")]
        System.Threading.Tasks.Task<Klient.Serwer.Gracz[]> ListaGraczyAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Klient.Serwer.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Klient.Serwer.IService1>, Klient.Serwer.IService1 {
        
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
        
        public void Rejestruj(string nick) {
            base.Channel.Rejestruj(nick);
        }
        
        public System.Threading.Tasks.Task RejestrujAsync(string nick) {
            return base.Channel.RejestrujAsync(nick);
        }
        
        public void idz(string nick, int dx, int dy) {
            base.Channel.idz(nick, dx, dy);
        }
        
        public System.Threading.Tasks.Task idzAsync(string nick, int dx, int dy) {
            return base.Channel.idzAsync(nick, dx, dy);
        }
        
        public void Gaz(string nick, int dx) {
            base.Channel.Gaz(nick, dx);
        }
        
        public System.Threading.Tasks.Task GazAsync(string nick, int dx) {
            return base.Channel.GazAsync(nick, dx);
        }
        
        public void Dzialaj(string nick, double dt) {
            base.Channel.Dzialaj(nick, dt);
        }
        
        public System.Threading.Tasks.Task DzialajAsync(string nick, double dt) {
            return base.Channel.DzialajAsync(nick, dt);
        }
        
        public Klient.Serwer.Gracz[] ListaGraczy() {
            return base.Channel.ListaGraczy();
        }
        
        public System.Threading.Tasks.Task<Klient.Serwer.Gracz[]> ListaGraczyAsync() {
            return base.Channel.ListaGraczyAsync();
        }
    }
}
