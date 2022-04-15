using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    //[CustomEditor(typeof(Event<T0>))]
    public abstract class EditorEvent<T0> : UnityEditor.Editor
    {
        /// <summary>
        /// Value to test the Invoke event with
        /// </summary>
        public T0 TestValue { get; protected set; }

        protected Event<T0> selected;

        public virtual void OnEnable()
        {
            selected = (Event<T0>)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUILayout.Space(16);

            // Invoke event
            EditorGUILayout.LabelField("Testing");
            if(GUILayout.Button(new GUIContent("Invoke", "Invokes the event to test it"), GUILayout.Height(32)))
            {
                if(TestValue == null)
                {
                    Debug.LogWarning("Cannot test Invoke() as the test value (or its content) is null. Did you forget to assign it?");
                    return;
                }
                selected.Invoke(TestValue);
                Debug.Log("[SLIDDES Modular] Invoked event");
            }
        }
    }
}
