using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(DoubleEvent))]
    public class EditorEventDouble : EditorEvent<double>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.DoubleField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
