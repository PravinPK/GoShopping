﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignement5.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherService.IWeatherSolar")]
    public interface IWeatherSolar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherSolar/GetWeatherDetails", ReplyAction="http://tempuri.org/IWeatherSolar/GetWeatherDetailsResponse")]
        string[] GetWeatherDetails(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherSolar/GetWeatherDetails", ReplyAction="http://tempuri.org/IWeatherSolar/GetWeatherDetailsResponse")]
        System.Threading.Tasks.Task<string[]> GetWeatherDetailsAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherSolar/GetSolarIntensity", ReplyAction="http://tempuri.org/IWeatherSolar/GetSolarIntensityResponse")]
        float GetSolarIntensity(string latitude, string longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherSolar/GetSolarIntensity", ReplyAction="http://tempuri.org/IWeatherSolar/GetSolarIntensityResponse")]
        System.Threading.Tasks.Task<float> GetSolarIntensityAsync(string latitude, string longitude);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherSolarChannel : Assignement5.WeatherService.IWeatherSolar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherSolarClient : System.ServiceModel.ClientBase<Assignement5.WeatherService.IWeatherSolar>, Assignement5.WeatherService.IWeatherSolar {
        
        public WeatherSolarClient() {
        }
        
        public WeatherSolarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherSolarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherSolarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherSolarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetWeatherDetails(int value) {
            return base.Channel.GetWeatherDetails(value);
        }
        
        public System.Threading.Tasks.Task<string[]> GetWeatherDetailsAsync(int value) {
            return base.Channel.GetWeatherDetailsAsync(value);
        }
        
        public float GetSolarIntensity(string latitude, string longitude) {
            return base.Channel.GetSolarIntensity(latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<float> GetSolarIntensityAsync(string latitude, string longitude) {
            return base.Channel.GetSolarIntensityAsync(latitude, longitude);
        }
    }
}
