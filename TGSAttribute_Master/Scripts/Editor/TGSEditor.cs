using UnityEngine;
using UnityEditor;
using System.Reflection;
using System;

namespace TGSAttributes.Editor
{
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class TGSEditor : UnityEditor.Editor
    {
        // public override void OnInspectorGUI()
        // {
        // base.OnInspectorGUI();
        // var mono = target as MonoBehaviour;

        // var type = mono.GetType();
        // var flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
        // var fields = type.GetFields(flags);
        // foreach (var field in fields)
        // {
        //     foreach (Attribute attribute in field.GetCustomAttributes(true))
        //     {
        //         if (attribute is IFieldAttribute customAttribute)
        //         {
        //             customAttribute.Handle(mono, field, attribute);
        //         }
        //     }
        // }

        // var methods = type.GetMethods(flags);
        // foreach (var method in methods)
        // {
        //     foreach (Attribute attribute in method.GetCustomAttributes(true))
        //     {
        //         if (attribute is IMethodAttribute customAttribute)
        //         {
        //             customAttribute.Handle(mono, method, attribute);
        //         }
        //     }
        // }
        // }
    }
}