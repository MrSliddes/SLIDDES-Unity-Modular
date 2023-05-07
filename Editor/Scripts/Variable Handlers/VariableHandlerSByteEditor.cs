using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerSByte))]
    public class VariableHandlerSByteEditor : VariableHandlerEditor<sbyte>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (SByteVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(SByteVariable), false);
        }
    }
}
