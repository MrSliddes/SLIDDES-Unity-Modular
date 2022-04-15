using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(IntEvent))]
    public class EditorEventInt : EditorEvent<int>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.IntField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
