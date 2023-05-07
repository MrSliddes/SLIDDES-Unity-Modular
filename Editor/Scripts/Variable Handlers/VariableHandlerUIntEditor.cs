using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerUInt))]
    public class VariableHandlerUIntEditor : VariableHandlerEditor<uint>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (UIntVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(UIntVariable), false);
        }
    }
}
