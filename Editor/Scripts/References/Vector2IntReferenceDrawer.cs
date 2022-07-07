using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(Vector2IntReference))]
    public class Vector2IntReferenceDrawer : ReferenceDrawer
    {
        public override void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue)
        {
            if(isConstant)
            {
                sConstantValue.vector2IntValue = EditorGUI.Vector2IntField(position, "", sConstantValue.vector2IntValue);
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(Vector2IntVariable), GUIContent.none);
            }
        }
    }
}
