using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(Vector3Event))]
    public class EditorEventVector3 : EditorEvent<Vector3>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.Vector3Field(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
