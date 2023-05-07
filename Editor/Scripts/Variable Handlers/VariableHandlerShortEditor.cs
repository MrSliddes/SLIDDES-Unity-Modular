using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerShort))]
    public class VariableHandlerShortEditor : VariableHandlerEditor<short>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (ShortVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(ShortVariable), false);
        }
    }
}
