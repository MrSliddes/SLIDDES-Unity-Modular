using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerChar))]
    public class VariableHandlerCharEditor : VariableHandlerEditor<char>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (CharVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(CharVariable), false);
        }
    }
}
