﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18449
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecursosHumanos.CarreraServicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Carrera", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProyectoUniversidad.Estructuras" +
        "")]
    [System.SerializableAttribute()]
    public partial class Carrera : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_CarreraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_CarreraField;
        
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
        public int Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Carrera {
            get {
                return this.ID_CarreraField;
            }
            set {
                if ((this.ID_CarreraField.Equals(value) != true)) {
                    this.ID_CarreraField = value;
                    this.RaisePropertyChanged("ID_Carrera");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Carrera {
            get {
                return this.Nombre_CarreraField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_CarreraField, value) != true)) {
                    this.Nombre_CarreraField = value;
                    this.RaisePropertyChanged("Nombre_Carrera");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Adminstrador", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProyectoUniversidad.Estructuras" +
        "")]
    [System.SerializableAttribute()]
    public partial class Adminstrador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
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
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarreraServicio.ICarreraService")]
    public interface ICarreraService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/InsertarCarrera", ReplyAction="http://tempuri.org/ICarreraService/InsertarCarreraResponse")]
        string InsertarCarrera(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/InsertarCarrera", ReplyAction="http://tempuri.org/ICarreraService/InsertarCarreraResponse")]
        System.Threading.Tasks.Task<string> InsertarCarreraAsync(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/ModificarCarrera", ReplyAction="http://tempuri.org/ICarreraService/ModificarCarreraResponse")]
        string ModificarCarrera(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/ModificarCarrera", ReplyAction="http://tempuri.org/ICarreraService/ModificarCarreraResponse")]
        System.Threading.Tasks.Task<string> ModificarCarreraAsync(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/EliminarCarrera", ReplyAction="http://tempuri.org/ICarreraService/EliminarCarreraResponse")]
        string EliminarCarrera(int id_carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/EliminarCarrera", ReplyAction="http://tempuri.org/ICarreraService/EliminarCarreraResponse")]
        System.Threading.Tasks.Task<string> EliminarCarreraAsync(int id_carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/TraerCarreras", ReplyAction="http://tempuri.org/ICarreraService/TraerCarrerasResponse")]
        RecursosHumanos.CarreraServicio.Carrera[] TraerCarreras(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/TraerCarreras", ReplyAction="http://tempuri.org/ICarreraService/TraerCarrerasResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.CarreraServicio.Carrera[]> TraerCarrerasAsync(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/ObtenerCarrera", ReplyAction="http://tempuri.org/ICarreraService/ObtenerCarreraResponse")]
        RecursosHumanos.CarreraServicio.Carrera ObtenerCarrera(int id_ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarreraService/ObtenerCarrera", ReplyAction="http://tempuri.org/ICarreraService/ObtenerCarreraResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.CarreraServicio.Carrera> ObtenerCarreraAsync(int id_ciudad);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarreraServiceChannel : RecursosHumanos.CarreraServicio.ICarreraService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarreraServiceClient : System.ServiceModel.ClientBase<RecursosHumanos.CarreraServicio.ICarreraService>, RecursosHumanos.CarreraServicio.ICarreraService {
        
        public CarreraServiceClient() {
        }
        
        public CarreraServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarreraServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarreraServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarreraServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertarCarrera(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador) {
            return base.Channel.InsertarCarrera(carrera, administrador);
        }
        
        public System.Threading.Tasks.Task<string> InsertarCarreraAsync(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador) {
            return base.Channel.InsertarCarreraAsync(carrera, administrador);
        }
        
        public string ModificarCarrera(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador) {
            return base.Channel.ModificarCarrera(carrera, administrador);
        }
        
        public System.Threading.Tasks.Task<string> ModificarCarreraAsync(RecursosHumanos.CarreraServicio.Carrera carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador) {
            return base.Channel.ModificarCarreraAsync(carrera, administrador);
        }
        
        public string EliminarCarrera(int id_carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador) {
            return base.Channel.EliminarCarrera(id_carrera, administrador);
        }
        
        public System.Threading.Tasks.Task<string> EliminarCarreraAsync(int id_carrera, RecursosHumanos.CarreraServicio.Adminstrador administrador) {
            return base.Channel.EliminarCarreraAsync(id_carrera, administrador);
        }
        
        public RecursosHumanos.CarreraServicio.Carrera[] TraerCarreras(string filtro) {
            return base.Channel.TraerCarreras(filtro);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.CarreraServicio.Carrera[]> TraerCarrerasAsync(string filtro) {
            return base.Channel.TraerCarrerasAsync(filtro);
        }
        
        public RecursosHumanos.CarreraServicio.Carrera ObtenerCarrera(int id_ciudad) {
            return base.Channel.ObtenerCarrera(id_ciudad);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.CarreraServicio.Carrera> ObtenerCarreraAsync(int id_ciudad) {
            return base.Channel.ObtenerCarreraAsync(id_ciudad);
        }
    }
}
