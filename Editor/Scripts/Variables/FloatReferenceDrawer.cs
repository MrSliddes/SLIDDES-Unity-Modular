using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(FloatReference))]
    public class FloatReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            bool useConstant = property.FindPropertyRelative("useConstant").boolValue;

            // Draw label
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            Rect rect = new Rect(position.position, Vector2.one * 20);

            // Clicking the dropdown menu
            if(EditorGUI.DropdownButton(rect, new GUIContent("", EditorGUIUtility.IconContent("d_icon dropdown").image, "Select Value Type"), FocusType.Keyboard, 
                new GUIStyle()
                { 
                    fixedWidth = 50f, border = new RectOffset(1, 1, 1, 1)
                }))
            {
                GenericMenu menu = new GenericMenu();
                menu.AddItem(new GUIContent("Constant"), useConstant, () => SetProperty(property, true));
                menu.AddItem(new GUIContent("Variable"), !useConstant, () => SetProperty(property, false));
                menu.ShowAsContext();
            }

            position.position += Vector2.right * 16;
            float value = property.FindPropertyRelative("constantValue").floatValue;

            if(useConstant)
            {
                string newValue = EditorGUI.TextField(position, value.ToString());
                float.TryParse(newValue, out value);
                property.FindPropertyRelative("constantValue").floatValue = value;
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(FloatVariable), GUIContent.none);
            }

            EditorGUI.EndProperty();
        }

        private void SetProperty(SerializedProperty property, bool value)
        {
            var propRelative = property.FindPropertyRelative("useConstant");
            propRelative.boolValue = value;
            property.serializedObject.ApplyModifiedProperties();
        }
    }
}