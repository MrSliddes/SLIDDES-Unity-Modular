using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(ULongEvent))]
    public class EventULongEditor : EventEditor<ulong>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = (ulong)EditorGUILayout.LongField(new GUIContent("Test Value", "The value to test the invoke with"), (long)TestValue);
        }
    }
}
