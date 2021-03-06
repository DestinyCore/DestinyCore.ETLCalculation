﻿using AspectCore.Configuration;
using AspectCore.DynamicProxy;
using AspectCore.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using DestinyCore.WorkNode.Shared.Extensions;
using DestinyCore.WorkNode.Shared.SuktReflection;

namespace DestinyCore.WorkNode.Shared.AOP
{
    /// <summary>
    ///
    /// </summary>
    public class AopManager : IAopManager
    {
        public void AutoLoadAops(IServiceCollection services)
        {
            var typefinder = services.GetOrAddSingletonService<ITypeFinder, TypeFinder>();
            typefinder.NotNull(nameof(typefinder));
            var typs = typefinder.Find(o => o.IsClass && !o.IsAbstract && !o.IsInterface && o.IsSubclassOf(typeof(AbstractInterceptorAttribute)));
            if (typs?.Length > 0)
            {
                foreach (var item in typs)
                {
                    services.AddTransient(item);
                    services.ConfigureDynamicProxy(cof =>
                    {
                        cof.Interceptors.AddTyped(item);
                    });
                }
            }
        }
    }
}