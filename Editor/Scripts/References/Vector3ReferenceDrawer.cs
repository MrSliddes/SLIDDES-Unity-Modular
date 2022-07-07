using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(Vector3Reference))]
    public class Vector3ReferenceDrawer : ReferenceDrawer
    {
        public override void DrawValue(Rect position, bool isConstant, SerializedProperty property, SerializedProperty sConstantValue)
        {
            if(isConstant)
            {
                sConstantValue.vector3Value = EditorGUI.Vector3Field(position, "", sConstantValue.vector3Value);
            }
            else
            {
                EditorGUI.ObjectField(new Rect(position.x, position.y, position.width - 16, position.height), property.FindPropertyRelative("variable"), typeof(Vector3Variable), GUIContent.none);
            }
        }
    }
}
