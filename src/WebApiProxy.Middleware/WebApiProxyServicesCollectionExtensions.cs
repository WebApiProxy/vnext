﻿namespace Microsoft.Extensions.DependencyInjection
{
    using System;
    using WebApiProxy.Middleware;

    public static class WebApiProxyServicesCollectionExtensions
    {
        public static IServiceCollection AddWebApiProxy(
            this IServiceCollection services,
            Action<WebApiProxyProviderOptions> setupAction = null
            )
        {
            WebApiProxySetup.ConfigureDefaultServices(services, setupAction);

            return services;
        }
        
    }
}
