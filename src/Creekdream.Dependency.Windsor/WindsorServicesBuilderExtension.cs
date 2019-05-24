﻿using Castle.Windsor;
using Creekdream.Dependency.Windsor;
using Microsoft.Extensions.DependencyInjection;

namespace Creekdream.Dependency
{
    /// <summary>
    /// Windsor specific extension methods for <see cref="ServicesBuilderOptions" />.
    /// </summary>
    public static class WindsorServicesBuilderExtension
    {
        /// <summary>
        /// Use Autofac as an injection container
        /// </summary>
        public static ServicesBuilderOptions UseWindsor(this ServicesBuilderOptions options)
        {
            var container = new WindsorContainer();
            options.Services.AddSingleton((IServiceProviderFactory<IWindsorContainer>)new WindsorServiceProviderFactory(container));
            return options;
        }
    }
}

