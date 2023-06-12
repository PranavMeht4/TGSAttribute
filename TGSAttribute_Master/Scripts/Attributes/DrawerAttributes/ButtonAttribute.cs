using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    /// <summary>
    /// <c>Attribute</c> used to create a button in the Unity inspector that invokes a method when clicked.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ButtonAttribute : Attribute, IMethodAttribute
    {
        public string Name;

        /// <param name="name">The name of the button. If not specified, the method name will be used.</param>
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