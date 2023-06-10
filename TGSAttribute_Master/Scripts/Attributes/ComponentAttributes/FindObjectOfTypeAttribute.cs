using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
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