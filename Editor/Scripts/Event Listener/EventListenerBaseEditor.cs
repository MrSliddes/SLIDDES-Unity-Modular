using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerBase))]
    public class EventListenerBaseEditor : UnityEditor.Editor
    {
        protected SerializedProperty propertyDescription;
        protected SerializedProperty propertyEvent;
        protected SerializedProperty propertyResponse;
        protected SerializedProperty propertyAssociatedInvoker;

        public virtual void OnEnable()
        {
            propertyDescription = serializedObject.FindProperty("description");
            propertyEvent = serializedObject.FindProperty("Event");
            propertyResponse = serializedObject.FindProperty("Response");
            propertyAssociatedInvoker = serializedObject.FindProperty("associatedInvoker");
        }

        public virtual void DrawEventObjectField()
        {
            //selected.Event = (Event<T0>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selected.Event, typeof(T0), false);
        }
    }
}
