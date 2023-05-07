using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerLong))]
    public class VariableHandlerLongEditor : VariableHandlerEditor<long>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (LongVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(LongVariable), false);
        }
    }
}
