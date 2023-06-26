using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(Vector2Event))]
    public class EventVector2Editor : EventEditor<Vector2>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.Vector2Field(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
