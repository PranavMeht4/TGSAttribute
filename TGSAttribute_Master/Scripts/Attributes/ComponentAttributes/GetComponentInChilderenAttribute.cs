using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    public class GetComponentInChilderenAttribute : Attribute, IFieldAttribute
    {
        public void Handle(MonoBehaviour target, FieldInfo fieldInfo, Attribute attribute)
        {
            if (typeof(Component).IsAssignableFrom(fieldInfo.FieldType) || fieldInfo.FieldType.IsInterface)
            {
                var component = target.GetComponentInChildren(fieldInfo.FieldType);
                if (component != null)
                {
                    fieldInfo.SetValue(target, component);
                }
                else
                {
                    Debug.LogError($"Component of type {fieldInfo.FieldType.Name} not found on {target.name}!");
                }
            }
            else
            {
                Debug.LogError($"GetComponentAttribute can only be used with Component or interface types, but used with: {fieldInfo.FieldType.Name} on {target.name}");
            }
        }
    }
}