using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(ListVariableReference))]
    public class ListVariableReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            int referenceTypeIndex = property.FindPropertyRelative("referenceType").enumValueIndex;

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
                menu.AddItem(new GUIContent("Variable"), referenceTypeIndex == 0, () => SetProperty(property, 0));
                menu.AddItem(new GUIContent("Item"), referenceTypeIndex == 1, () => SetProperty(property, 1));
                menu.ShowAsContext();
            }

            position.position += Vector2.right * 16;

            switch(referenceTypeIndex)
            {
                default:
                    EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(DictionaryVariable), GUIContent.none);
                    break;
                case 1:
                    EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("item"), typeof(Variable<>), GUIContent.none);
                    break;
            }

            EditorGUI.EndProperty();
        }

        private void SetProperty(SerializedProperty property, int value)
        {
            var propRelative = property.FindPropertyRelative("referenceType");
            propRelative.enumValueIndex = value;
            property.serializedObject.ApplyModifiedProperties();
        }
    }
}
