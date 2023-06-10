using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ButtonAttribute : Attribute, IMethodAttribute
    {
        public string Name;

        public ButtonAttribute(string name = null)
        {
            Name = name;
        }

        public void Handle(MonoBehaviour target, MethodInfo methodInfo, Attribute attribute)
        {
            if (GUILayout.Button(Name ?? methodInfo.Name))
            {
                try
                {
                    methodInfo.Invoke(target, null);
                }
                catch (Exception ex)
                {
                    Debug.LogError($"Error when calling {methodInfo.Name} on {target.name}: {ex}");
                }
            }
        }
    }
}