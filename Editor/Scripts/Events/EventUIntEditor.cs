using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(UIntEvent))]
    public class EventUIntEditor : EventEditor<uint>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = (uint)EditorGUILayout.IntField(new GUIContent("Test Value", "The value to test the invoke with"), (int)TestValue);
        }
    }
}
