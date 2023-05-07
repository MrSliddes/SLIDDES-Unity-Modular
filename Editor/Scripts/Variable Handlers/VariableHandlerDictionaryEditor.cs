using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerDictionary))]
    public class VariableHandlerDictionaryEditor : VariableHandlerEditor<Dictionary<ScriptableObject, ScriptableObject>>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (DictionaryVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(DictionaryVariable), false);
        }
    }
}
