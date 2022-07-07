using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(BoolReference))]
    public class BoolReferenceDrawer : ReferenceDrawer
    {
        public override void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue)
        {
            if(isConstant)
            {
                sConstantValue.boolValue = EditorGUI.Toggle(position, sConstantValue.boolValue);
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(BoolVariable), GUIContent.none);
            }
        }
    }
}
