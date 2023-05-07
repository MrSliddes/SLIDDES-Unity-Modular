using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerUShort))]
    public class VariableHandlerUShortEditor : VariableHandlerEditor<ushort>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (UShortVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(UShortVariable), false);
        }
    }
}
