using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerObject))]
    public class VariableHandlerObjectEditor : VariableHandlerEditor<object>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (ObjectVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(ObjectVariable), false);
        }
    }
}
