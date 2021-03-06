﻿using Microsoft.Extensions.DependencyInjection;

namespace DestinyCore.WorkNode.Shared.AOP
{
    public interface IAopManager
    {
        /// <summary>
        /// 自动注入AOP
        /// </summary>
        /// <param name="services"></param>
        void AutoLoadAops(IServiceCollection services);
    }
}