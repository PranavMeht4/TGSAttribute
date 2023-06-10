using UnityEditor;
using UnityEngine;

namespace TGSAttributes
{
    [CustomPropertyDrawer(typeof(ShowIfAttribute))]
    public class ShowIfDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ShowIfAttribute showIfAttribute = attribute as ShowIfAttribute;
            SerializedProperty conditionProperty = property.serializedObject.FindProperty(showIfAttribute.ConditionFieldName);

            // Draw the property only if the condition is true
            if (conditionProperty != null && conditionProperty.boolValue)
            {
                EditorGUI.PropertyField(position, property, label, true);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            ShowIfAttribute showIfAttribute = attribute as ShowIfAttribute;
            SerializedProperty conditionProperty = property.serializedObject.FindProperty(showIfAttribute.ConditionFieldName);

            // If the condition is false, return 0 to avoid leaving empty space
            if (conditionProperty != null && !conditionProperty.boolValue)
            {
                return 0;
            }

            // Otherwise return the default property height
            return base.GetPropertyHeight(property, label);
        }
    }
}