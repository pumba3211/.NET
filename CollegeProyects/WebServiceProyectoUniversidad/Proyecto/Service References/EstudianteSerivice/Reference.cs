﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18449
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecursosHumanos.EstudianteSerivice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProyectoUniversidad.Estructuras" +
        "")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cedula {
            get {
                return this.CedulaField;
            }
            set {
                if ((this.CedulaField.Equals(value) != true)) {
                    this.CedulaField = value;
                    this.RaisePropertyChanged("Cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Estudiante", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProyectoUniversidad.Estructuras" +
        "")]
    [System.SerializableAttribute()]
    public partial class Estudiante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_nacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_CarreraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_EstudianteField;
        
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
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_nacimiento {
            get {
                return this.Fecha_nacimientoField;
            }
            set {
                if ((this.Fecha_nacimientoField.Equals(value) != true)) {
                    this.Fecha_nacimientoField = value;
                    this.RaisePropertyChanged("Fecha_nacimiento");
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
        public int ID_Estudiante {
            get {
                return this.ID_EstudianteField;
            }
            set {
                if ((this.ID_EstudianteField.Equals(value) != true)) {
                    this.ID_EstudianteField = value;
                    this.RaisePropertyChanged("ID_Estudiante");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstudiantePerson", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProyectoUniversidad.Estructuras" +
        "")]
    [System.SerializableAttribute()]
    public partial class EstudiantePerson : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fecha_nacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_CarreraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_EstudianteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cedula {
            get {
                return this.CedulaField;
            }
            set {
                if ((this.CedulaField.Equals(value) != true)) {
                    this.CedulaField = value;
                    this.RaisePropertyChanged("Cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha_nacimiento {
            get {
                return this.Fecha_nacimientoField;
            }
            set {
                if ((this.Fecha_nacimientoField.Equals(value) != true)) {
                    this.Fecha_nacimientoField = value;
                    this.RaisePropertyChanged("Fecha_nacimiento");
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
        public int ID_Estudiante {
            get {
                return this.ID_EstudianteField;
            }
            set {
                if ((this.ID_EstudianteField.Equals(value) != true)) {
                    this.ID_EstudianteField = value;
                    this.RaisePropertyChanged("ID_Estudiante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EstudianteSerivice.IEstudianteService")]
    public interface IEstudianteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/InsertarEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/InsertarEstudianteResponse")]
        string InsertarEstudiante(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/InsertarEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/InsertarEstudianteResponse")]
        System.Threading.Tasks.Task<string> InsertarEstudianteAsync(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/ModificarEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/ModificarEstudianteResponse")]
        string ModificarEstudiante(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/ModificarEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/ModificarEstudianteResponse")]
        System.Threading.Tasks.Task<string> ModificarEstudianteAsync(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/ElminarEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/ElminarEstudianteResponse")]
        string ElminarEstudiante(int ID_Estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/ElminarEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/ElminarEstudianteResponse")]
        System.Threading.Tasks.Task<string> ElminarEstudianteAsync(int ID_Estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/TraerEstudiantes", ReplyAction="http://tempuri.org/IEstudianteService/TraerEstudiantesResponse")]
        RecursosHumanos.EstudianteSerivice.EstudiantePerson[] TraerEstudiantes(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/TraerEstudiantes", ReplyAction="http://tempuri.org/IEstudianteService/TraerEstudiantesResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.EstudianteSerivice.EstudiantePerson[]> TraerEstudiantesAsync(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/ObtenerEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/ObtenerEstudianteResponse")]
        RecursosHumanos.EstudianteSerivice.EstudiantePerson ObtenerEstudiante(int ID_Estudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstudianteService/ObtenerEstudiante", ReplyAction="http://tempuri.org/IEstudianteService/ObtenerEstudianteResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.EstudianteSerivice.EstudiantePerson> ObtenerEstudianteAsync(int ID_Estudiante);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstudianteServiceChannel : RecursosHumanos.EstudianteSerivice.IEstudianteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstudianteServiceClient : System.ServiceModel.ClientBase<RecursosHumanos.EstudianteSerivice.IEstudianteService>, RecursosHumanos.EstudianteSerivice.IEstudianteService {
        
        public EstudianteServiceClient() {
        }
        
        public EstudianteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstudianteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstudianteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstudianteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertarEstudiante(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador) {
            return base.Channel.InsertarEstudiante(persona, estudiante, administrador);
        }
        
        public System.Threading.Tasks.Task<string> InsertarEstudianteAsync(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador) {
            return base.Channel.InsertarEstudianteAsync(persona, estudiante, administrador);
        }
        
        public string ModificarEstudiante(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador) {
            return base.Channel.ModificarEstudiante(persona, estudiante, administrador);
        }
        
        public System.Threading.Tasks.Task<string> ModificarEstudianteAsync(RecursosHumanos.EstudianteSerivice.Persona persona, RecursosHumanos.EstudianteSerivice.Estudiante estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador) {
            return base.Channel.ModificarEstudianteAsync(persona, estudiante, administrador);
        }
        
        public string ElminarEstudiante(int ID_Estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador) {
            return base.Channel.ElminarEstudiante(ID_Estudiante, administrador);
        }
        
        public System.Threading.Tasks.Task<string> ElminarEstudianteAsync(int ID_Estudiante, RecursosHumanos.EstudianteSerivice.Adminstrador administrador) {
            return base.Channel.ElminarEstudianteAsync(ID_Estudiante, administrador);
        }
        
        public RecursosHumanos.EstudianteSerivice.EstudiantePerson[] TraerEstudiantes(string filtro) {
            return base.Channel.TraerEstudiantes(filtro);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.EstudianteSerivice.EstudiantePerson[]> TraerEstudiantesAsync(string filtro) {
            return base.Channel.TraerEstudiantesAsync(filtro);
        }
        
        public RecursosHumanos.EstudianteSerivice.EstudiantePerson ObtenerEstudiante(int ID_Estudiante) {
            return base.Channel.ObtenerEstudiante(ID_Estudiante);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.EstudianteSerivice.EstudiantePerson> ObtenerEstudianteAsync(int ID_Estudiante) {
            return base.Channel.ObtenerEstudianteAsync(ID_Estudiante);
        }
    }
}