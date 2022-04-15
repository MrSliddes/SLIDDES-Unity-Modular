using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(UShortEvent))]
    public class EditorEventUShort : EditorEvent<ushort>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = (ushort)EditorGUILayout.IntField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
