//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18449
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecursosHumanos.GrupoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Grupo", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProyectoUniversidad.Estructuras" +
        "")]
    [System.SerializableAttribute()]
    public partial class Grupo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_AulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_CarreraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_GrupoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_ProfesorField;
        
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
        public int ID_Aula {
            get {
                return this.ID_AulaField;
            }
            set {
                if ((this.ID_AulaField.Equals(value) != true)) {
                    this.ID_AulaField = value;
                    this.RaisePropertyChanged("ID_Aula");
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
        public int ID_Grupo {
            get {
                return this.ID_GrupoField;
            }
            set {
                if ((this.ID_GrupoField.Equals(value) != true)) {
                    this.ID_GrupoField = value;
                    this.RaisePropertyChanged("ID_Grupo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Profesor {
            get {
                return this.ID_ProfesorField;
            }
            set {
                if ((this.ID_ProfesorField.Equals(value) != true)) {
                    this.ID_ProfesorField = value;
                    this.RaisePropertyChanged("ID_Profesor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Grupo_Entero", Namespace="http://schemas.datacontract.org/2004/07/WebServiceProyectoUniversidad.Estructuras" +
        "")]
    [System.SerializableAttribute()]
    public partial class Grupo_Entero : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_AulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_CarreraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_GrupoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_ProfesorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_AulaField;
        
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
        public int ID_Aula {
            get {
                return this.ID_AulaField;
            }
            set {
                if ((this.ID_AulaField.Equals(value) != true)) {
                    this.ID_AulaField = value;
                    this.RaisePropertyChanged("ID_Aula");
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
        public int ID_Grupo {
            get {
                return this.ID_GrupoField;
            }
            set {
                if ((this.ID_GrupoField.Equals(value) != true)) {
                    this.ID_GrupoField = value;
                    this.RaisePropertyChanged("ID_Grupo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Profesor {
            get {
                return this.ID_ProfesorField;
            }
            set {
                if ((this.ID_ProfesorField.Equals(value) != true)) {
                    this.ID_ProfesorField = value;
                    this.RaisePropertyChanged("ID_Profesor");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Aula {
            get {
                return this.Nombre_AulaField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_AulaField, value) != true)) {
                    this.Nombre_AulaField = value;
                    this.RaisePropertyChanged("Nombre_Aula");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GrupoService.IGrupoServicio")]
    public interface IGrupoServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/InsertarGrupo", ReplyAction="http://tempuri.org/IGrupoServicio/InsertarGrupoResponse")]
        string InsertarGrupo(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/InsertarGrupo", ReplyAction="http://tempuri.org/IGrupoServicio/InsertarGrupoResponse")]
        System.Threading.Tasks.Task<string> InsertarGrupoAsync(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/Modificargrupo", ReplyAction="http://tempuri.org/IGrupoServicio/ModificargrupoResponse")]
        string Modificargrupo(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/Modificargrupo", ReplyAction="http://tempuri.org/IGrupoServicio/ModificargrupoResponse")]
        System.Threading.Tasks.Task<string> ModificargrupoAsync(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/EliminarGrupo", ReplyAction="http://tempuri.org/IGrupoServicio/EliminarGrupoResponse")]
        string EliminarGrupo(int id_grupo, RecursosHumanos.GrupoService.Adminstrador Administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/EliminarGrupo", ReplyAction="http://tempuri.org/IGrupoServicio/EliminarGrupoResponse")]
        System.Threading.Tasks.Task<string> EliminarGrupoAsync(int id_grupo, RecursosHumanos.GrupoService.Adminstrador Administrador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/CargarGrupos", ReplyAction="http://tempuri.org/IGrupoServicio/CargarGruposResponse")]
        RecursosHumanos.GrupoService.Grupo_Entero[] CargarGrupos(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/CargarGrupos", ReplyAction="http://tempuri.org/IGrupoServicio/CargarGruposResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.GrupoService.Grupo_Entero[]> CargarGruposAsync(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/ObtenerGrupo", ReplyAction="http://tempuri.org/IGrupoServicio/ObtenerGrupoResponse")]
        RecursosHumanos.GrupoService.Grupo_Entero ObtenerGrupo(int id_grupo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGrupoServicio/ObtenerGrupo", ReplyAction="http://tempuri.org/IGrupoServicio/ObtenerGrupoResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.GrupoService.Grupo_Entero> ObtenerGrupoAsync(int id_grupo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGrupoServicioChannel : RecursosHumanos.GrupoService.IGrupoServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GrupoServicioClient : System.ServiceModel.ClientBase<RecursosHumanos.GrupoService.IGrupoServicio>, RecursosHumanos.GrupoService.IGrupoServicio {
        
        public GrupoServicioClient() {
        }
        
        public GrupoServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GrupoServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GrupoServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GrupoServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertarGrupo(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador) {
            return base.Channel.InsertarGrupo(Grupo, Administrador);
        }
        
        public System.Threading.Tasks.Task<string> InsertarGrupoAsync(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador) {
            return base.Channel.InsertarGrupoAsync(Grupo, Administrador);
        }
        
        public string Modificargrupo(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador) {
            return base.Channel.Modificargrupo(Grupo, Administrador);
        }
        
        public System.Threading.Tasks.Task<string> ModificargrupoAsync(RecursosHumanos.GrupoService.Grupo Grupo, RecursosHumanos.GrupoService.Adminstrador Administrador) {
            return base.Channel.ModificargrupoAsync(Grupo, Administrador);
        }
        
        public string EliminarGrupo(int id_grupo, RecursosHumanos.GrupoService.Adminstrador Administrador) {
            return base.Channel.EliminarGrupo(id_grupo, Administrador);
        }
        
        public System.Threading.Tasks.Task<string> EliminarGrupoAsync(int id_grupo, RecursosHumanos.GrupoService.Adminstrador Administrador) {
            return base.Channel.EliminarGrupoAsync(id_grupo, Administrador);
        }
        
        public RecursosHumanos.GrupoService.Grupo_Entero[] CargarGrupos(string filtro) {
            return base.Channel.CargarGrupos(filtro);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.GrupoService.Grupo_Entero[]> CargarGruposAsync(string filtro) {
            return base.Channel.CargarGruposAsync(filtro);
        }
        
        public RecursosHumanos.GrupoService.Grupo_Entero ObtenerGrupo(int id_grupo) {
            return base.Channel.ObtenerGrupo(id_grupo);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.GrupoService.Grupo_Entero> ObtenerGrupoAsync(int id_grupo) {
            return base.Channel.ObtenerGrupoAsync(id_grupo);
        }
    }
}
