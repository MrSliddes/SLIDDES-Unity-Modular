using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(Vector3IntEvent))]
    public class EditorEventVector3Int : EditorEvent<Vector3Int>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.Vector3IntField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
