using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerVector3Int))]
    public class VariableHandlerVector3IntEditor : VariableHandlerEditor<Vector3Int>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (Vector3IntVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(Vector3IntVariable), false);
        }
    }
}
