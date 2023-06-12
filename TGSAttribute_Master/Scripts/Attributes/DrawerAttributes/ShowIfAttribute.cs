using System;
using UnityEngine;

namespace TGSAttributes
{
    /// <summary>
    /// Attribute used to conditionally show fields in the Unity inspector based on the value of another field.
    /// </summary>
    /// <param name="conditionFieldName">The name of the field in the target class that will be used to determine if the target field should be shown.</param>
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