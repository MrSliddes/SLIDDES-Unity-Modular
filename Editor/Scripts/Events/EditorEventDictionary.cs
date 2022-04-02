using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(DictionaryEvent))]
    public class EditorEventDictionary : EditorEvent<Dictionary<ScriptableObject, ScriptableObject>>
    {
        private DictionaryVariable testValue;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            testValue = EditorGUILayoutExtensions.DictionaryVariableField(testValue, "Test Value");
            if(testValue != null && testValue.Value != null)
            {
                TestValue = testValue.Value;
            }
        }
    }
}
