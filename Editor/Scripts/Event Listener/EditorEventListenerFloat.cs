using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerFloat))]
    public class EditorEventListenerFloat : EditorEventListener<float>
    {
        private EventListenerFloat selectedType;

        protected SerializedProperty m_eventConditionProp;
        protected SerializedProperty m_compareValueProp;

        public override void OnEnable()
        {
            selectedType = (EventListenerFloat)target;
            base.OnEnable();
            m_eventConditionProp = serializedObject.FindProperty("eventCondition");
            m_compareValueProp = serializedObject.FindProperty("compareValue");
        }

        public override void OnInspectorGUI()
        {
            DrawGUIEventObjectField();
            if(selected.Event != null)
                EditorGUILayout.PropertyField(m_eventConditionProp);
            if(selectedType.eventCondition != EventListenerFloat.EventCondition.none)
                EditorGUILayout.PropertyField(m_compareValueProp);
            if(selected.Event != null)
                EditorGUILayout.PropertyField(m_ResponseProp);

            serializedObject.ApplyModifiedProperties();
        }

        public override void DrawGUIEventObjectField()
        {
            selected.Event = (Event<float>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selected.Event, typeof(FloatEvent), false);
        }
    }
}
