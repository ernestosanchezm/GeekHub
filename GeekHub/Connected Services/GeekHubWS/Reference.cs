//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeekHub.GeekHubWS {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GeekHubWS.GeekHubWSSoap")]
    public interface GeekHubWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProductosPorVendedor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GeekHub.GeekHubWS.ItProducto[] ListarProductosPorVendedor(int idVendedor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProductosPorVendedor", ReplyAction="*")]
        System.Threading.Tasks.Task<GeekHub.GeekHubWS.ItProducto[]> ListarProductosPorVendedorAsync(int idVendedor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProductosPorCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GeekHub.GeekHubWS.ItProducto[] ListarProductosPorCategoria(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProductosPorCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<GeekHub.GeekHubWS.ItProducto[]> ListarProductosPorCategoriaAsync(int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarCategorias", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GeekHub.GeekHubWS.ItCategoria[] ListarCategorias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarCategorias", ReplyAction="*")]
        System.Threading.Tasks.Task<GeekHub.GeekHubWS.ItCategoria[]> ListarCategoriasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FiltroSkus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet FiltroSkus(string categoriaId, string nombre, string precioMin, string precioMax, string orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FiltroSkus", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> FiltroSkusAsync(string categoriaId, string nombre, string precioMin, string precioMax, string orden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/loginFindByEmailAndPassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GeekHub.GeekHubWS.UserLogin loginFindByEmailAndPassword(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/loginFindByEmailAndPassword", ReplyAction="*")]
        System.Threading.Tasks.Task<GeekHub.GeekHubWS.UserLogin> loginFindByEmailAndPasswordAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool registerUser(string idUser, string idRole, string password, string name, string lastName, string sex, string email, string admin, string register, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerUser", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> registerUserAsync(string idUser, string idRole, string password, string name, string lastName, string sex, string email, string admin, string register, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendEmail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendEmail(string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendEmail", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendEmailAsync(string subject, string body);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ItProducto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nProductoField;
        
        private int productoIdField;
        
        private decimal priceField;
        
        private int categoriaIdField;
        
        private string nCategoriaField;
        
        private string uRL_ImageField;
        
        private System.Nullable<System.DateTime> fRegistroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NProducto {
            get {
                return this.nProductoField;
            }
            set {
                this.nProductoField = value;
                this.RaisePropertyChanged("NProducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int ProductoId {
            get {
                return this.productoIdField;
            }
            set {
                this.productoIdField = value;
                this.RaisePropertyChanged("ProductoId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public decimal Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
                this.RaisePropertyChanged("Price");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int CategoriaId {
            get {
                return this.categoriaIdField;
            }
            set {
                this.categoriaIdField = value;
                this.RaisePropertyChanged("CategoriaId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string NCategoria {
            get {
                return this.nCategoriaField;
            }
            set {
                this.nCategoriaField = value;
                this.RaisePropertyChanged("NCategoria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string URL_Image {
            get {
                return this.uRL_ImageField;
            }
            set {
                this.uRL_ImageField = value;
                this.RaisePropertyChanged("URL_Image");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<System.DateTime> FRegistro {
            get {
                return this.fRegistroField;
            }
            set {
                this.fRegistroField = value;
                this.RaisePropertyChanged("FRegistro");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UserLogin : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string lastNameField;
        
        private string emailField;
        
        private int roleIdField;
        
        private int usuarioIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
                this.RaisePropertyChanged("LastName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int RoleId {
            get {
                return this.roleIdField;
            }
            set {
                this.roleIdField = value;
                this.RaisePropertyChanged("RoleId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int UsuarioId {
            get {
                return this.usuarioIdField;
            }
            set {
                this.usuarioIdField = value;
                this.RaisePropertyChanged("UsuarioId");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ItCategoria : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nCategoriaField;
        
        private int cateogoriaIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NCategoria {
            get {
                return this.nCategoriaField;
            }
            set {
                this.nCategoriaField = value;
                this.RaisePropertyChanged("NCategoria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int CateogoriaId {
            get {
                return this.cateogoriaIdField;
            }
            set {
                this.cateogoriaIdField = value;
                this.RaisePropertyChanged("CateogoriaId");
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
    public interface GeekHubWSSoapChannel : GeekHub.GeekHubWS.GeekHubWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GeekHubWSSoapClient : System.ServiceModel.ClientBase<GeekHub.GeekHubWS.GeekHubWSSoap>, GeekHub.GeekHubWS.GeekHubWSSoap {
        
        public GeekHubWSSoapClient() {
        }
        
        public GeekHubWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GeekHubWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeekHubWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeekHubWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GeekHub.GeekHubWS.ItProducto[] ListarProductosPorVendedor(int idVendedor) {
            return base.Channel.ListarProductosPorVendedor(idVendedor);
        }
        
        public System.Threading.Tasks.Task<GeekHub.GeekHubWS.ItProducto[]> ListarProductosPorVendedorAsync(int idVendedor) {
            return base.Channel.ListarProductosPorVendedorAsync(idVendedor);
        }
        
        public GeekHub.GeekHubWS.ItProducto[] ListarProductosPorCategoria(int categoryId) {
            return base.Channel.ListarProductosPorCategoria(categoryId);
        }
        
        public System.Threading.Tasks.Task<GeekHub.GeekHubWS.ItProducto[]> ListarProductosPorCategoriaAsync(int categoryId) {
            return base.Channel.ListarProductosPorCategoriaAsync(categoryId);
        }
        
        public GeekHub.GeekHubWS.ItCategoria[] ListarCategorias() {
            return base.Channel.ListarCategorias();
        }
        
        public System.Threading.Tasks.Task<GeekHub.GeekHubWS.ItCategoria[]> ListarCategoriasAsync() {
            return base.Channel.ListarCategoriasAsync();
        }
        
        public System.Data.DataSet FiltroSkus(string categoriaId, string nombre, string precioMin, string precioMax, string orden) {
            return base.Channel.FiltroSkus(categoriaId, nombre, precioMin, precioMax, orden);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FiltroSkusAsync(string categoriaId, string nombre, string precioMin, string precioMax, string orden) {
            return base.Channel.FiltroSkusAsync(categoriaId, nombre, precioMin, precioMax, orden);
        }
        
        public GeekHub.GeekHubWS.UserLogin loginFindByEmailAndPassword(string email, string password) {
            return base.Channel.loginFindByEmailAndPassword(email, password);
        }
        
        public System.Threading.Tasks.Task<GeekHub.GeekHubWS.UserLogin> loginFindByEmailAndPasswordAsync(string email, string password) {
            return base.Channel.loginFindByEmailAndPasswordAsync(email, password);
        }
        
        public bool registerUser(string idUser, string idRole, string password, string name, string lastName, string sex, string email, string admin, string register, string status) {
            return base.Channel.registerUser(idUser, idRole, password, name, lastName, sex, email, admin, register, status);
        }
        
        public System.Threading.Tasks.Task<bool> registerUserAsync(string idUser, string idRole, string password, string name, string lastName, string sex, string email, string admin, string register, string status) {
            return base.Channel.registerUserAsync(idUser, idRole, password, name, lastName, sex, email, admin, register, status);
        }
        
        public string SendEmail(string subject, string body) {
            return base.Channel.SendEmail(subject, body);
        }
        
        public System.Threading.Tasks.Task<string> SendEmailAsync(string subject, string body) {
            return base.Channel.SendEmailAsync(subject, body);
        }
    }
}
