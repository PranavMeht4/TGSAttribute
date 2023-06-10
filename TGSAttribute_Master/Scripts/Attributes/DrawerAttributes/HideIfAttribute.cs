using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class HideIfAttribute : PropertyAttribute
    {
        public string ConditionFieldName;

        public HideIfAttribute(string conditionFieldName)
        {
            ConditionFieldName = conditionFieldName;
        }
    }
}
