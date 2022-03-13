using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    //[CustomEditor(typeof())]
    [CanEditMultipleObjects]
    public abstract class EditorEventListener<T> : UnityEditor.Editor
    {
        protected EventListener<T> selected;

        protected SerializedProperty m_EventProp;
        protected SerializedProperty m_ResponseProp;

        public virtual void OnEnable()
        {
            selected = (EventListener<T>)target;
            m_EventProp = serializedObject.FindProperty("Event");
            m_ResponseProp = serializedObject.FindProperty("Response");
        }

        public override void OnInspectorGUI()
        {
            DrawGUIEventObjectField();
            if(selected.Event != null)
                EditorGUILayout.PropertyField(m_ResponseProp);

            serializedObject.ApplyModifiedProperties();
        }

        public virtual void DrawGUIEventObjectField()
        {
            selected.Event = (Event<T>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selected.Event, typeof(T), false);
        }
    }
}
