﻿using DestinyCore.WorkNode.Shared.Enums;
using System;

namespace DestinyCore.WorkNode.Shared.Attributes.AutoMapper
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SuktAutoMapFromAttribute : SuktAutoMapperAttribute
    {
        public override SuktAutoMapDirection MapDirection
        {
            get { return SuktAutoMapDirection.From; }
        }

        public SuktAutoMapFromAttribute(params Type[] targetTypes)
            : base(targetTypes)
        {
        }
    }
}