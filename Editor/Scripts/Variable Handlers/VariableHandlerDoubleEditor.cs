using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerDouble))]
    public class VariableHandlerDoubleEditor : VariableHandlerEditor<double>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (DoubleVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(DoubleVariable), false);
        }
    }
}
