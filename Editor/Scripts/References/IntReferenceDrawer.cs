using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(IntReference))]
    public class IntReferenceDrawer : ReferenceDrawer
    {
        public override void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue)
        {
            if(isConstant)
            {
                sConstantValue.intValue = EditorGUI.IntField(position, sConstantValue.intValue);
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(IntVariable), GUIContent.none);
            }
        }
    }
}