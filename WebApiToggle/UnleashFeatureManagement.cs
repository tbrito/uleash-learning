using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using System;

namespace WebApiToggle
{
    public class UnleashFeatureManagement : IFeatureManagementBuilder
    {
        private readonly IServiceCollection service;
        
        public UnleashFeatureManagement(Uri uri, IServiceCollection service)
        {
            this.service = service;
            this.service.AddScoped<IFeatureManager, CofidisFeature>();
        }

        public IServiceCollection Services => this.service;

        public IFeatureManagementBuilder AddFeatureFilter<T>() where T : IFeatureFilterMetadata
        {
            return this;
        }

        public IFeatureManagementBuilder AddSessionManager<T>() where T : ISessionManager
        {
            return this;
        }
    }
}
