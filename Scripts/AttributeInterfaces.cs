using System;
using System.Reflection;
using UnityEngine;

namespace TGSAttributes
{
    public interface IFieldAttribute
    {
        void Handle(MonoBehaviour target, FieldInfo fieldInfo, Attribute attribute);
    }

    public interface IMethodAttribute
    {
        void Handle(MonoBehaviour target, MethodInfo methodInfo, Attribute attribute);
    }
}