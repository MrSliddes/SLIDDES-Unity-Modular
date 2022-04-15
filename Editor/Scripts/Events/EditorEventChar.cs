using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(CharEvent))]
    public class EditorEventChar : EditorEvent<char>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayoutExtensions.CharField(new GUIContent("Test Value", "The value to test with"), TestValue);
        }
    }
}
