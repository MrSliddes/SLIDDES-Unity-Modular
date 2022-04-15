using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(DecimalEvent))]
    public class EditorEventDecimal : EditorEvent<decimal>
    {
        public override void DrawTestValue()
        {
            base.DrawTestValue();
            TestValue = EditorGUILayoutExtensions.DecimalField(new GUIContent("Test Value", "The value to test the invoke with"), TestValue);
        }
    }
}
