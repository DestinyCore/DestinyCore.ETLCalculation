﻿using DestinyCore.ETLDispatchCenter.Shared.Attributes;
using System;

namespace DestinyCore.ETLDispatchCenter.Shared.Filter
{
    /// <summary>
    ///
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class FilterCodeAttribute : AttributeBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="code"></param>
        public FilterCodeAttribute(string code)
        {
            Code = code;
        }

        /// <summary>
        /// 过滤操作器
        /// </summary>
        public string Code { get; set; }

        public override string Description()
        {
            return this.Code;
        }
    }
}