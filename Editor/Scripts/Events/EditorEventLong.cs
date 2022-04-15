using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(LongEvent))]
    public class EditorEventLong : EditorEvent<long>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.LongField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
