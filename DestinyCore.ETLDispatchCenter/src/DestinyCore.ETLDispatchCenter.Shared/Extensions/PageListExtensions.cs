﻿using DestinyCore.ETLDispatchCenter.Shared.AjaxResult;
using DestinyCore.ETLDispatchCenter.Shared.Extensions.ResultExtensions;

namespace DestinyCore.ETLDispatchCenter.Shared.Extensions
{
    /// <summary>
    /// 分页集合Dto扩展
    /// </summary>
    public static class PageListExtensions
    {
        /// <summary>
        /// 分页集合Dto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pageResult"></param>
        /// <returns></returns>
        public static PageList<T> PageList<T>(this IPageResult<T> pageResult)
        {
            var result = pageResult;
            return new PageList<T>() { Data = result.Data, Message = result.Message, Total = result.Total, Success = result.Success };
        }
    }
}