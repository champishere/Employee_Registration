﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Razin.Web.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IRazinService")]
    public interface IRazinService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRazinService/SaveEmployee", ReplyAction="http://tempuri.org/IRazinService/SaveEmployeeResponse")]
        void SaveEmployee(Razin.Bo.BaseEmployee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRazinService/SaveEmployee", ReplyAction="http://tempuri.org/IRazinService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task SaveEmployeeAsync(Razin.Bo.BaseEmployee emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRazinServiceChannel : Razin.Web.Service.IRazinService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RazinServiceClient : System.ServiceModel.ClientBase<Razin.Web.Service.IRazinService>, Razin.Web.Service.IRazinService {
        
        public RazinServiceClient() {
        }
        
        public RazinServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RazinServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RazinServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RazinServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveEmployee(Razin.Bo.BaseEmployee emp) {
            base.Channel.SaveEmployee(emp);
        }
        
        public System.Threading.Tasks.Task SaveEmployeeAsync(Razin.Bo.BaseEmployee emp) {
            return base.Channel.SaveEmployeeAsync(emp);
        }
    }
}