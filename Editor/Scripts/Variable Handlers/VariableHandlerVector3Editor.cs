using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerVector3))]
    public class VariableHandlerVector3Editor : VariableHandlerEditor<Vector3>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (Vector3Variable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(Vector3Variable), false);
        }
    }
}
