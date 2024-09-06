using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Tectum.TectumLNodeClient.Config;

namespace Tectum.TectumLNodeClient.Registries
{
    public static class ClientRegistry
    {
        public static IServiceCollection AddLiteNodeClient(this IServiceCollection services,
            IConfiguration configuration,
            string configName = "TectumLNodeClientConfig")
        {
            services.Configure<TectumLNodeClientConfig>(configuration.GetSection(configName).Bind);
            services
                .AddHttpClient<ITectumLNodeClient, TectumLNodeClient>(
                    (client, service) =>
                    {
                        var config = service.GetService<IOptions<TectumLNodeClientConfig>>();
                        if (config == null)
                        {
                            throw new AggregateException("Configuration is disabled");
                        }

                        client.BaseAddress = new Uri(config.Value.BaseUrl);
                        return new TectumLNodeClient(client);
                    });

            return services;
        }
    }
}