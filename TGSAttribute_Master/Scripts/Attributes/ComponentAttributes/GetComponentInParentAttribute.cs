using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    /// <summary>
    /// Attribute used to automatically get and assign references to components or interfaces in MonoBehaviour scripts from the parent of the GameObject.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class GetComponentInParentAttribute : Attribute, IFieldAttribute
    {
        public void Handle(MonoBehaviour target, FieldInfo fieldInfo, Attribute attribute)
        {
            if (typeof(Component).IsAssignableFrom(fieldInfo.FieldType) || fieldInfo.FieldType.IsInterface)
            {
                var component = target.GetComponentInParent(fieldInfo.FieldType);
                if (component != null)
                {
                    fieldInfo.SetValue(target, component);
                }
                else
                {
                    Debug.LogError($"Component of type {fieldInfo.FieldType.Name} not found on {target.transform.parent.name}!");
                }
            }
            else
            {
                Debug.LogError($"GetComponentAttribute can only be used with Component or interface types, but used with: {fieldInfo.FieldType.Name} on {target.name}");
            }
        }
    }
}