using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(DoubleReference))]
    public class DoubleReferenceDrawer : ReferenceDrawer
    {
        public override void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue)
        {
            if(isConstant)
            {
                sConstantValue.doubleValue = EditorGUI.DoubleField(position, sConstantValue.doubleValue);
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(DoubleVariable), GUIContent.none);
            }
        }
    }
}