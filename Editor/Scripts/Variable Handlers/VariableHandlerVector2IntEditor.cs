using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerVector2Int))]
    public class VariableHandlerVector2IntEditor : VariableHandlerEditor<Vector2Int>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (Vector2IntVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(Vector2IntVariable), false);
        }
    }
}
