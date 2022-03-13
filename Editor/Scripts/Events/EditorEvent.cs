using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    //[CustomEditor(typeof(Event<T>))]
    public abstract class EditorEvent<T> : UnityEditor.Editor
    {
        [SerializeField] private T testValue;

        protected Event<T> selected;

        protected virtual void OnEnable()
        {
            selected = (Event<T>)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUILayout.Space(16);

            // Invoke event
            if(GUILayout.Button(new GUIContent("Invoke", "Invokes the event to test it"), GUILayout.Height(32)))
            {
                selected.Invoke(testValue);
                Debug.Log("[SLIDDES Modular] Invoked event");
            }
        }
    }
}
