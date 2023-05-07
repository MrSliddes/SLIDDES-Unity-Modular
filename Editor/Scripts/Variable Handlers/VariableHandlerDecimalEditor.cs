using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerDecimal))]
    public class VariableHandlerDecimalEditor : VariableHandlerEditor<decimal>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (DecimalVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(DecimalVariable), false);
        }
    }
}
