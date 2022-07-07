using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(FloatReference))]
    public class FloatReferenceDrawer : ReferenceDrawer
    {
        public override void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue)
        {
            if(isConstant)
            {
                sConstantValue.floatValue = EditorGUI.FloatField(position, sConstantValue.floatValue);
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(FloatVariable), GUIContent.none);
            }
        }
    }
}