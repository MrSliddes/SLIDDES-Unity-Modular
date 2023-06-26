using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(FloatEvent))]
    public class EventFloatEditor : EventEditor<float>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.FloatField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
