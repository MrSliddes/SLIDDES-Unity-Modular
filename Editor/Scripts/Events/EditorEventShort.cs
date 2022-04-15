using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(ShortEvent))]
    public class EditorEventShort : EditorEvent<short>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = (short)EditorGUILayout.IntField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
