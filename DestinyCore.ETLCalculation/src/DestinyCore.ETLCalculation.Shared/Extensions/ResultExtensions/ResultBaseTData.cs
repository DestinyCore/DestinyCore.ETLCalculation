﻿using System.Collections.Generic;

namespace DestinyCore.ETLCalculation.Shared.Extensions.ResultExtensions
{
    public abstract class ResultBaseTData<TData> : ResultBase, IResultData<TData>
    {
        public virtual IEnumerable<TData> Data { get; set; }
    }
}