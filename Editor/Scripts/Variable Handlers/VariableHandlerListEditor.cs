using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerList))]
    public class VariableHandlerListEditor : VariableHandlerEditor<List<ScriptableObject>>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (ListVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(ListVariable), false);
        }
    }
}
