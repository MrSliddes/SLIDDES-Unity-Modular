using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(Vector2IntEvent))]
    public class EventVector2IntEditor : EventEditor<Vector2Int>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.Vector2IntField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
