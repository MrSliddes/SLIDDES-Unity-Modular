using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(ByteEvent))]
    public class EditorEventByte : EditorEvent<byte>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            TestValue = (byte)EditorGUILayout.IntField(new GUIContent("Test Value", "The value to test with"), TestValue);
        }
    }
}
