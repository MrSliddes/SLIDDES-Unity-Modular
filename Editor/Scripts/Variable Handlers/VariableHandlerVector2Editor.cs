using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerVector2))]
    public class VariableHandlerVector2Editor : VariableHandlerEditor<Vector2>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (Vector2Variable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(Vector2Variable), false);
        }
    }
}
