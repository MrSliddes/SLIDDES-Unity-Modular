using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerInt))]
    public class VariableHandlerIntEditor : VariableHandlerEditor<int>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (IntVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(IntVariable), false);
        }
    }
}
