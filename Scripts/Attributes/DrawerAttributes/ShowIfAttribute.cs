using System;
using UnityEngine;

namespace TGSAttributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ShowIfAttribute : PropertyAttribute
    {
        public string ConditionFieldName;

        public ShowIfAttribute(string conditionFieldName)
        {
            ConditionFieldName = conditionFieldName;
        }
    }
}