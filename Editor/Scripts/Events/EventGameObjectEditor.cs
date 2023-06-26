using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(GameObjectEvent))]
    public class EventGameObjectEditor : EventEditor<GameObject>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = (GameObject)EditorGUILayout.ObjectField(new GUIContent("Test Value", "The value to test with"), (GameObject)TestValue, typeof(GameObject), true);
        }
    }
}
