using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerString))]
    public class VariableHandlerStringEditor : VariableHandlerEditor<string>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (StringVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(StringVariable), false);
        }
    }
}
