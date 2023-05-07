using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerByte))]
    public class VariableHandlerByteEditor : VariableHandlerEditor<byte>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (ByteVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(ByteVariable), false);
        }
    }
}
