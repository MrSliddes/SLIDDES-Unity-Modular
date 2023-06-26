using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(StringEvent))]
    public class EventStringEditor : EventEditor<string>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.TextField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
