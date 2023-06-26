using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(SByteEvent))]
    public class EventSByteEditor : EventEditor<sbyte>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = (sbyte)EditorGUILayout.IntField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
