﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="schedule", Namespace="http://schemas.datacontract.org/2004/07/BookingTicketService")]
    public partial class schedule : object
    {
        
        private string CountryFromField;
        
        private string CountryToField;
        
        private System.DateTime CreatedAtField;
        
        private int ScheduleIdField;
        
        private string SeatField;
        
        private string StationNameField;
        
        private ServiceReference1.ticket ticketField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryFrom
        {
            get
            {
                return this.CountryFromField;
            }
            set
            {
                this.CountryFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryTo
        {
            get
            {
                return this.CountryToField;
            }
            set
            {
                this.CountryToField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ScheduleId
        {
            get
            {
                return this.ScheduleIdField;
            }
            set
            {
                this.ScheduleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Seat
        {
            get
            {
                return this.SeatField;
            }
            set
            {
                this.SeatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StationName
        {
            get
            {
                return this.StationNameField;
            }
            set
            {
                this.StationNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ticket ticket
        {
            get
            {
                return this.ticketField;
            }
            set
            {
                this.ticketField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ticket", Namespace="http://schemas.datacontract.org/2004/07/BookingTicketService")]
    public partial class ticket : object
    {
        
        private int ScheduleIdField;
        
        private string UserIdField;
        
        private ServiceReference1.client clientField;
        
        private ServiceReference1.schedule scheduleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ScheduleId
        {
            get
            {
                return this.ScheduleIdField;
            }
            set
            {
                this.ScheduleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.client client
        {
            get
            {
                return this.clientField;
            }
            set
            {
                this.clientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.schedule schedule
        {
            get
            {
                return this.scheduleField;
            }
            set
            {
                this.scheduleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="client", Namespace="http://schemas.datacontract.org/2004/07/BookingTicketService")]
    public partial class client : object
    {
        
        private string AppClientIdField;
        
        private string EmailField;
        
        private string FullNameField;
        
        private string PasswordField;
        
        private string UsernameField;
        
        private ServiceReference1.ticket[] ticketsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AppClientId
        {
            get
            {
                return this.AppClientIdField;
            }
            set
            {
                this.AppClientIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName
        {
            get
            {
                return this.FullNameField;
            }
            set
            {
                this.FullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ticket[] tickets
        {
            get
            {
                return this.ticketsField;
            }
            set
            {
                this.ticketsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyService")]
    public interface IMyService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DoWork", ReplyAction="http://tempuri.org/IMyService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetAllSchedules", ReplyAction="http://tempuri.org/IMyService/GetAllSchedulesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.schedule[]> GetAllSchedulesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMyServiceChannel : ServiceReference1.IMyService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IMyService>, ServiceReference1.IMyService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyServiceClient() : 
                base(MyServiceClient.GetDefaultBinding(), MyServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMyService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MyServiceClient.GetBindingForEndpoint(endpointConfiguration), MyServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task DoWorkAsync()
        {
            return base.Channel.DoWorkAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.schedule[]> GetAllSchedulesAsync()
        {
            return base.Channel.GetAllSchedulesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:61751/MyService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMyService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMyService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMyService,
        }
    }
}