using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    /// <summary>
    /// Attribute used to automatically find and assign references to components or interfaces in MonoBehaviour scripts.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class FindObjectOfTypeAttribute : Attribute, IFieldAttribute
    {
        public void Handle(MonoBehaviour target, FieldInfo fieldInfo, Attribute attribute)
        {
            if (typeof(Component).IsAssignableFrom(fieldInfo.FieldType) || fieldInfo.FieldType.IsInterface)
            {
                var component = Transform.FindAnyObjectByType(fieldInfo.FieldType);
                if (component != null)
                {
                    fieldInfo.SetValue(target, component);
                }
            }
        }
    }
}