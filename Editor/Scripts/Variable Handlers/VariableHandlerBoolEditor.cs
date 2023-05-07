using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerBool))]
    public class VariableHandlerBoolEditor : VariableHandlerEditor<bool>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (BoolVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(BoolVariable), false);
        }
    }
}
