using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Event = SLIDDES.Modular.EventSDS;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventSDS))]
    public class EditorEvent : UnityEditor.Editor
    {
        protected EventSDS selected;

        public virtual void OnEnable()
        {
            selected = (EventSDS)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUILayout.Space(16);

            // Invoke event
            EditorGUILayout.LabelField("Testing");
            if(GUILayout.Button(new GUIContent("Invoke", "Invokes the event to test it"), GUILayout.Height(32)))
            {
                selected.Invoke();
                Debug.Log("[SLIDDES Modular] Invoked event");
            }
        }
    }

    //[CustomEditor(typeof(Event<T0>))]
    public abstract class EditorEvent<T0> : UnityEditor.Editor
    {
        /// <summary>
        /// Value to test the Invoke event with
        /// </summary>
        public T0 TestValue { get; protected set; }

        protected EventSDS<T0> selected;

        public virtual void OnEnable()
        {
            selected = (EventSDS<T0>)target;
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
            DrawTestValue();
        }

        /// <summary>
        /// Draw the test value field
        /// </summary>
        public virtual void DrawTestValue() { }
    }
}
