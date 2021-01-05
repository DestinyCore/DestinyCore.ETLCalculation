﻿using DestinyCore.ETLCalculation.Shared.Attributes.Dependency;

namespace DestinyCore.ETLCalculation.Shared
{
    /// <summary>
    /// 实现此接口的类型将自动注册为<see cref="ServiceLifetime.Transient"/>模式
    /// </summary>
    [IgnoreDependency]
    public interface ITransientDependency
    {
    }
}