using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerULong))]
    public class VariableHandlerULongEditor : VariableHandlerEditor<ulong>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (ULongVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(ULongVariable), false);
        }
    }
}
