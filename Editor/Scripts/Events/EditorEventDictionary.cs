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

        public override void DrawTestValue()
        {
            base.DrawTestValue();
            testValue = EditorGUILayoutExtensions.DictionaryVariableField(new GUIContent("Test Value", "The value to test the invoke with"), testValue);
            if(testValue != null && testValue.Value != null)
            {
                TestValue = testValue.Value;
            }
        }
    }
}
