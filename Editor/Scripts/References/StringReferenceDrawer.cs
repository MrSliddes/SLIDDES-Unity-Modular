using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(StringReference))]
    public class StringReferenceDrawer : ReferenceDrawer
    {
        public override void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue)
        {
            if(isConstant)
            {
                sConstantValue.stringValue = EditorGUI.TextField(position, sConstantValue.stringValue);
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(StringVariable), GUIContent.none);
            }
        }
    }
}