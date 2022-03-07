using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using System;

namespace WebApiToggle
{
    public static class UnleashFeatureManagementBuilder
    {
        public static IFeatureManagementBuilder UseUnleashFeatureManagement(this IServiceCollection service, Uri uri)
        {
            return new UnleashFeatureManagement(uri, service);
        }
    }
}
