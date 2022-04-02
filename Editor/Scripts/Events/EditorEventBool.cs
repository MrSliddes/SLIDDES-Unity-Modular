using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(BoolEvent))]
    public class EditorEventBool : EditorEvent<bool>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            TestValue = EditorGUILayout.Toggle(new GUIContent("Test Value", "The value to test with"), TestValue);
        }
    }
}
