using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(ByteEvent))]
    public class EditorEventByte : EditorEvent<byte>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = (byte)EditorGUILayout.IntField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
