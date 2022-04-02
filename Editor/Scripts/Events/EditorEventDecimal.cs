using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(DecimalEvent))]
    public class EditorEventDecimal : EditorEvent<decimal>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            TestValue = EditorGUILayoutExtensions.DecimalField(TestValue, "Test Value");
        }
    }
}
