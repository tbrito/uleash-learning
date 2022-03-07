using Microsoft.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unleash;

namespace WebApiToggle
{
    public class CofidisFeature : IFeatureManager
    {
        private DefaultUnleash unleash;

        public CofidisFeature()
        {
            var settings = new UnleashSettings()
            {
                AppName = "CustomerAdd",
                UnleashApi = new Uri("http://unleash.herokuapp.com/"),
                ProjectId = "default"
            };
            
            unleash = new DefaultUnleash(settings);
        }

        public IAsyncEnumerable<string> GetFeatureNamesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEnabledAsync(string feature)
        {
            return Task.FromResult(unleash.IsEnabled(feature));
        }

        public Task<bool> IsEnabledAsync<TContext>(string feature, TContext context)
        {
            return Task.FromResult(unleash.IsEnabled(feature));
        }
    }
}
