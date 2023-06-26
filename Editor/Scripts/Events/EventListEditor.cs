using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(ListEvent))]
    public class EventListEditor : EventEditor<List<ScriptableObject>>
    {
        private ListVariable testValue;

        public override void DrawTestValue()
        {
            base.DrawTestValue();

            testValue = EditorGUILayoutExtensions.ListVariableField(new GUIContent("Test Value", "The value to test the invoke with"), testValue);
            if(testValue != null && testValue.Value != null)
            {
                TestValue = testValue.Value;
            }
        }
    }
}
