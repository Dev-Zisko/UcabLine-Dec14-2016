﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioBatch.ServicioData {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Administrador", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Administrador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Linea", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Linea : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ServicioBatch.ServicioData.Estacion[] estacionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numeroTrenesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipoField;
        
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
        public ServicioBatch.ServicioData.Estacion[] estaciones {
            get {
                return this.estacionesField;
            }
            set {
                if ((object.ReferenceEquals(this.estacionesField, value) != true)) {
                    this.estacionesField = value;
                    this.RaisePropertyChanged("estaciones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                if ((object.ReferenceEquals(this.estadoField, value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numeroTrenes {
            get {
                return this.numeroTrenesField;
            }
            set {
                if ((this.numeroTrenesField.Equals(value) != true)) {
                    this.numeroTrenesField = value;
                    this.RaisePropertyChanged("numeroTrenes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipo {
            get {
                return this.tipoField;
            }
            set {
                if ((object.ReferenceEquals(this.tipoField, value) != true)) {
                    this.tipoField = value;
                    this.RaisePropertyChanged("tipo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Estacion", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Estacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreEstacionField;
        
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
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                if ((object.ReferenceEquals(this.estadoField, value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreEstacion {
            get {
                return this.nombreEstacionField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreEstacionField, value) != true)) {
                    this.nombreEstacionField = value;
                    this.RaisePropertyChanged("nombreEstacion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TrasbordoDoble", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class TrasbordoDoble : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estacion1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estacion2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string linea1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string linea2Field;
        
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
        public string estacion1 {
            get {
                return this.estacion1Field;
            }
            set {
                if ((object.ReferenceEquals(this.estacion1Field, value) != true)) {
                    this.estacion1Field = value;
                    this.RaisePropertyChanged("estacion1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estacion2 {
            get {
                return this.estacion2Field;
            }
            set {
                if ((object.ReferenceEquals(this.estacion2Field, value) != true)) {
                    this.estacion2Field = value;
                    this.RaisePropertyChanged("estacion2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string linea1 {
            get {
                return this.linea1Field;
            }
            set {
                if ((object.ReferenceEquals(this.linea1Field, value) != true)) {
                    this.linea1Field = value;
                    this.RaisePropertyChanged("linea1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string linea2 {
            get {
                return this.linea2Field;
            }
            set {
                if ((object.ReferenceEquals(this.linea2Field, value) != true)) {
                    this.linea2Field = value;
                    this.RaisePropertyChanged("linea2");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TrasbordoSimple", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class TrasbordoSimple : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] lineasField;
        
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
        public string estacion {
            get {
                return this.estacionField;
            }
            set {
                if ((object.ReferenceEquals(this.estacionField, value) != true)) {
                    this.estacionField = value;
                    this.RaisePropertyChanged("estacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] lineas {
            get {
                return this.lineasField;
            }
            set {
                if ((object.ReferenceEquals(this.lineasField, value) != true)) {
                    this.lineasField = value;
                    this.RaisePropertyChanged("lineas");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioData.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/obtenerAdministrador", ReplyAction="http://tempuri.org/IService/obtenerAdministradorResponse")]
        ServicioBatch.ServicioData.Administrador obtenerAdministrador();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarAdministrador", ReplyAction="http://tempuri.org/IService/modificarAdministradorResponse")]
        void modificarAdministrador(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/estadoServicio", ReplyAction="http://tempuri.org/IService/estadoServicioResponse")]
        bool estadoServicio();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/actualizarLlegadas", ReplyAction="http://tempuri.org/IService/actualizarLlegadasResponse")]
        void actualizarLlegadas(string tiempo, string nombreLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/verificarUsuario", ReplyAction="http://tempuri.org/IService/verificarUsuarioResponse")]
        bool verificarUsuario(string usuario, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/crearLinea", ReplyAction="http://tempuri.org/IService/crearLineaResponse")]
        bool crearLinea(string nombreLinea, int trenes, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/crearEstacion", ReplyAction="http://tempuri.org/IService/crearEstacionResponse")]
        bool crearEstacion(string nombreLinea, string estacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarLinea", ReplyAction="http://tempuri.org/IService/modificarLineaResponse")]
        bool modificarLinea(string nombreLinea, string nuevoNombre, int trenes, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarEstacion", ReplyAction="http://tempuri.org/IService/modificarEstacionResponse")]
        bool modificarEstacion(string nombreLinea, string nombreEstacion, string nuevaEstacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarEstadoLinea", ReplyAction="http://tempuri.org/IService/modificarEstadoLineaResponse")]
        bool modificarEstadoLinea(string nombreLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarEstadoEstacion", ReplyAction="http://tempuri.org/IService/modificarEstadoEstacionResponse")]
        bool modificarEstadoEstacion(string nombreEstacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/eliminarLinea", ReplyAction="http://tempuri.org/IService/eliminarLineaResponse")]
        bool eliminarLinea(string nombreLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/eliminarEstacion", ReplyAction="http://tempuri.org/IService/eliminarEstacionResponse")]
        bool eliminarEstacion(string nombreLinea, string nombreEstacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/buscarLinea", ReplyAction="http://tempuri.org/IService/buscarLineaResponse")]
        bool buscarLinea(string nombreLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/buscarEstacion", ReplyAction="http://tempuri.org/IService/buscarEstacionResponse")]
        bool buscarEstacion(string nombreLinea, string nombreEstacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/generarListaLinea", ReplyAction="http://tempuri.org/IService/generarListaLineaResponse")]
        ServicioBatch.ServicioData.Linea[] generarListaLinea();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/generarListaEstaciones", ReplyAction="http://tempuri.org/IService/generarListaEstacionesResponse")]
        ServicioBatch.ServicioData.Estacion[] generarListaEstaciones(string nombreLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/obtenerLinea", ReplyAction="http://tempuri.org/IService/obtenerLineaResponse")]
        ServicioBatch.ServicioData.Linea obtenerLinea(string nombreLinea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/obtenerEstacion", ReplyAction="http://tempuri.org/IService/obtenerEstacionResponse")]
        ServicioBatch.ServicioData.Estacion obtenerEstacion(string nombreLinea, string nombreEstacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/verificarEstadoLinea", ReplyAction="http://tempuri.org/IService/verificarEstadoLineaResponse")]
        void verificarEstadoLinea();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/crearTrasbordoSimple", ReplyAction="http://tempuri.org/IService/crearTrasbordoSimpleResponse")]
        bool crearTrasbordoSimple(string estacion, string[] lineas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/crearTrasbordoDoble", ReplyAction="http://tempuri.org/IService/crearTrasbordoDobleResponse")]
        bool crearTrasbordoDoble(string linea1, string estacion1, string linea2, string estacion2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/eliminarTrasbordoGeneral", ReplyAction="http://tempuri.org/IService/eliminarTrasbordoGeneralResponse")]
        bool eliminarTrasbordoGeneral(string linea, string estacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/eliminarTrasbordoLineasGeneral", ReplyAction="http://tempuri.org/IService/eliminarTrasbordoLineasGeneralResponse")]
        bool eliminarTrasbordoLineasGeneral(string linea);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/eliminarTrasbordoSimple", ReplyAction="http://tempuri.org/IService/eliminarTrasbordoSimpleResponse")]
        bool eliminarTrasbordoSimple(string estacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/eliminarTrasbordoDoble", ReplyAction="http://tempuri.org/IService/eliminarTrasbordoDobleResponse")]
        bool eliminarTrasbordoDoble(string estacion1, string estacion2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarTrasbordoGeneralEstacion", ReplyAction="http://tempuri.org/IService/modificarTrasbordoGeneralEstacionResponse")]
        bool modificarTrasbordoGeneralEstacion(string estacion, string nuevaEstacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/generarListaTrasbordoD", ReplyAction="http://tempuri.org/IService/generarListaTrasbordoDResponse")]
        ServicioBatch.ServicioData.TrasbordoDoble[] generarListaTrasbordoD();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/generarListaTrasbordoS", ReplyAction="http://tempuri.org/IService/generarListaTrasbordoSResponse")]
        ServicioBatch.ServicioData.TrasbordoSimple[] generarListaTrasbordoS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarTrasbordoGeneralLinea", ReplyAction="http://tempuri.org/IService/modificarTrasbordoGeneralLineaResponse")]
        bool modificarTrasbordoGeneralLinea(string linea, string nuevaLinea);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ServicioBatch.ServicioData.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ServicioBatch.ServicioData.IService>, ServicioBatch.ServicioData.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServicioBatch.ServicioData.Administrador obtenerAdministrador() {
            return base.Channel.obtenerAdministrador();
        }
        
        public void modificarAdministrador(string username, string password) {
            base.Channel.modificarAdministrador(username, password);
        }
        
        public bool estadoServicio() {
            return base.Channel.estadoServicio();
        }
        
        public void actualizarLlegadas(string tiempo, string nombreLinea) {
            base.Channel.actualizarLlegadas(tiempo, nombreLinea);
        }
        
        public bool verificarUsuario(string usuario, string contraseña) {
            return base.Channel.verificarUsuario(usuario, contraseña);
        }
        
        public bool crearLinea(string nombreLinea, int trenes, string tipo) {
            return base.Channel.crearLinea(nombreLinea, trenes, tipo);
        }
        
        public bool crearEstacion(string nombreLinea, string estacion) {
            return base.Channel.crearEstacion(nombreLinea, estacion);
        }
        
        public bool modificarLinea(string nombreLinea, string nuevoNombre, int trenes, string tipo) {
            return base.Channel.modificarLinea(nombreLinea, nuevoNombre, trenes, tipo);
        }
        
        public bool modificarEstacion(string nombreLinea, string nombreEstacion, string nuevaEstacion) {
            return base.Channel.modificarEstacion(nombreLinea, nombreEstacion, nuevaEstacion);
        }
        
        public bool modificarEstadoLinea(string nombreLinea) {
            return base.Channel.modificarEstadoLinea(nombreLinea);
        }
        
        public bool modificarEstadoEstacion(string nombreEstacion) {
            return base.Channel.modificarEstadoEstacion(nombreEstacion);
        }
        
        public bool eliminarLinea(string nombreLinea) {
            return base.Channel.eliminarLinea(nombreLinea);
        }
        
        public bool eliminarEstacion(string nombreLinea, string nombreEstacion) {
            return base.Channel.eliminarEstacion(nombreLinea, nombreEstacion);
        }
        
        public bool buscarLinea(string nombreLinea) {
            return base.Channel.buscarLinea(nombreLinea);
        }
        
        public bool buscarEstacion(string nombreLinea, string nombreEstacion) {
            return base.Channel.buscarEstacion(nombreLinea, nombreEstacion);
        }
        
        public ServicioBatch.ServicioData.Linea[] generarListaLinea() {
            return base.Channel.generarListaLinea();
        }
        
        public ServicioBatch.ServicioData.Estacion[] generarListaEstaciones(string nombreLinea) {
            return base.Channel.generarListaEstaciones(nombreLinea);
        }
        
        public ServicioBatch.ServicioData.Linea obtenerLinea(string nombreLinea) {
            return base.Channel.obtenerLinea(nombreLinea);
        }
        
        public ServicioBatch.ServicioData.Estacion obtenerEstacion(string nombreLinea, string nombreEstacion) {
            return base.Channel.obtenerEstacion(nombreLinea, nombreEstacion);
        }
        
        public void verificarEstadoLinea() {
            base.Channel.verificarEstadoLinea();
        }
        
        public bool crearTrasbordoSimple(string estacion, string[] lineas) {
            return base.Channel.crearTrasbordoSimple(estacion, lineas);
        }
        
        public bool crearTrasbordoDoble(string linea1, string estacion1, string linea2, string estacion2) {
            return base.Channel.crearTrasbordoDoble(linea1, estacion1, linea2, estacion2);
        }
        
        public bool eliminarTrasbordoGeneral(string linea, string estacion) {
            return base.Channel.eliminarTrasbordoGeneral(linea, estacion);
        }
        
        public bool eliminarTrasbordoLineasGeneral(string linea) {
            return base.Channel.eliminarTrasbordoLineasGeneral(linea);
        }
        
        public bool eliminarTrasbordoSimple(string estacion) {
            return base.Channel.eliminarTrasbordoSimple(estacion);
        }
        
        public bool eliminarTrasbordoDoble(string estacion1, string estacion2) {
            return base.Channel.eliminarTrasbordoDoble(estacion1, estacion2);
        }
        
        public bool modificarTrasbordoGeneralEstacion(string estacion, string nuevaEstacion) {
            return base.Channel.modificarTrasbordoGeneralEstacion(estacion, nuevaEstacion);
        }
        
        public ServicioBatch.ServicioData.TrasbordoDoble[] generarListaTrasbordoD() {
            return base.Channel.generarListaTrasbordoD();
        }
        
        public ServicioBatch.ServicioData.TrasbordoSimple[] generarListaTrasbordoS() {
            return base.Channel.generarListaTrasbordoS();
        }
        
        public bool modificarTrasbordoGeneralLinea(string linea, string nuevaLinea) {
            return base.Channel.modificarTrasbordoGeneralLinea(linea, nuevaLinea);
        }
    }
}
