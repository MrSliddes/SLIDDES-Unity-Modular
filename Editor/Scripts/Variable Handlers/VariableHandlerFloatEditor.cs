using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerFloat))]
    public class VariableHandlerFloatEditor : VariableHandlerEditor<float>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (FloatVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(FloatVariable), false);
        }
    }
}
