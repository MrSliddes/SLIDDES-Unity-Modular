using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(ObjectEvent))]
    public class EditorEventObject : EventEditor<object>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayout.ObjectField(new GUIContent("Test Value", "The value to test with"), (Object)TestValue, typeof(object), false);
        }
    }
}
