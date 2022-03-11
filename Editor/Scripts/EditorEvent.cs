using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(Event))]
    public class EditorEvent : UnityEditor.Editor
    {
        private Event selected;

        private void OnEnable()
        {
            selected = (Event)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUILayout.Space(16);

            // Invoke event
            if(GUILayout.Button(new GUIContent("Invoke", "Invokes the event to test it"), GUILayout.Height(32)))
            {
                selected.Invoke();
            }
        }
    }
}
