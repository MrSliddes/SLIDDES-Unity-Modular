using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventSDS))]
    public class EventListenerEditor : EventListenerBaseEditor
    {

    }

    [CustomEditor(typeof(EventListener<>))]
    [CanEditMultipleObjects]
    public abstract class EventListenerEditor<T0> : EventListenerBaseEditor
    {
        protected EventListener<T0> selected;

        public override void OnEnable()
        {
            base.OnEnable();
            selected = (EventListener<T0>)target;
            propertyAssociatedInvoker = serializedObject.FindProperty("associatedInvoker");
        }

        public override void OnInspectorGUI()
        {
            DrawGUIEventObjectField();
            EditorGUILayout.PropertyField(propertyAssociatedInvoker);            

            // Draw response
            if(selected.Event != null)
            {
                EditorGUILayout.PropertyField(propertyResponse);
            }

            serializedObject.ApplyModifiedProperties();
        }

        public override void DrawGUIEventObjectField()
        {
            //selected.Event = (Event<T0>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selected.Event, typeof(T0), false);
        }

    }
}
