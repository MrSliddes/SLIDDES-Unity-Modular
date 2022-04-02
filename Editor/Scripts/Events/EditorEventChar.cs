using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(CharEvent))]
    public class EditorEventChar : EditorEvent<char>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            TestValue = EditorGUILayoutExtensions.CharField(TestValue, "Test Value", "The value to test with");
        }
    }
}
