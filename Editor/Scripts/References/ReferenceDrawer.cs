using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    /// <summary>
    /// Base class for reference drawers
    /// </summary>
    public abstract class ReferenceDrawer : PropertyDrawer
    {
        /// <summary>
        /// Draw the value of the reference
        /// </summary>
        /// <remarks>
        /// The user interacts with this value and when edited in the inspector it should apply it to the script
        /// </remarks>
        /// <param name="sConstantValue"></param>
        public abstract void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue);

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            bool isConstant = property.FindPropertyRelative("isConstant").boolValue;

            // Draw label
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            Rect rect = new Rect(position.position, Vector2.one * 20);

            // Clicking the dropdown menu
            if(EditorGUI.DropdownButton(rect, new GUIContent("", EditorGUIUtility.IconContent("d_icon dropdown").image, "Select Value Type"), FocusType.Keyboard,
                new GUIStyle()
                {
                    fixedWidth = 50f,
                    border = new RectOffset(1, 1, 1, 1)
                }))
            {
                GenericMenu menu = new GenericMenu();
                menu.AddItem(new GUIContent("Constant"), isConstant, () => SetPropertyIsConstant(property, true));
                menu.AddItem(new GUIContent("Variable"), !isConstant, () => SetPropertyIsConstant(property, false));
                menu.ShowAsContext();
            }

            position.position += Vector2.right * 16;

            SerializedProperty sConstantValue = property.FindPropertyRelative("constantValue");
            DrawValue(position, isConstant, property, sConstantValue);

            EditorGUI.EndProperty();
        }

        /// <summary>
        /// Set the property value of isConstant
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        private void SetPropertyIsConstant(SerializedProperty property, bool value)
        {
            var propRelative = property.FindPropertyRelative("isConstant");
            propRelative.boolValue = value;
            property.serializedObject.ApplyModifiedProperties();
        }
    }
}
