using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerList))]
    public class EditorEventListenerList : EditorEventListener<List<ScriptableObject>>
    {
        private EventListenerList selectedType;

        protected SerializedProperty m_eventConditionProp;
        protected SerializedProperty m_eventConditionItemProp;
        protected SerializedProperty m_compareValueProp;
        protected SerializedProperty m_compareIntProp;

        public override void OnEnable()
        {
            selectedType = (EventListenerList)target;
            base.OnEnable();
            m_eventConditionProp = serializedObject.FindProperty("eventCondition");
            m_eventConditionItemProp = serializedObject.FindProperty("eventConditionItem");
            m_compareValueProp = serializedObject.FindProperty("compareValue");
            m_compareIntProp = serializedObject.FindProperty("compareInt");
        }

        public override void OnInspectorGUI()
        {
            DrawGUIEventObjectField();
            
            // Based on reference type show corresponding eventCondition
            switch(selectedType.compareValue.referenceType)
            {
                case ListVariableReference.ReferenceType.variable:
                    if(selected.Event != null) EditorGUILayout.PropertyField(m_eventConditionProp);
                    if(selectedType.eventCondition != EventListenerList.EventCondition.none)
                        EditorGUILayout.PropertyField(m_compareValueProp, new GUIContent("Compare Value"));
                    break;
                case ListVariableReference.ReferenceType.item:
                    if(selected.Event != null) EditorGUILayout.PropertyField(m_eventConditionItemProp);
                    if(selectedType.eventConditionItem != EventListenerList.EventConditionItem.none)
                        EditorGUILayout.PropertyField(m_compareValueProp, new GUIContent("Compare Value Item"));
                    if(selectedType.eventConditionItem == EventListenerList.EventConditionItem.equalTooIndex || selectedType.eventConditionItem == EventListenerList.EventConditionItem.notEqualTooIndex)
                        EditorGUILayout.PropertyField(m_compareIntProp, new GUIContent("Compare Index"));
                    break;
                default: break;
            }

            if(selected.Event != null)
                EditorGUILayout.PropertyField(m_ResponseProp);

            serializedObject.ApplyModifiedProperties();
        }

        public override void DrawGUIEventObjectField()
        {
            selected.Event = (Event<List<ScriptableObject>>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selected.Event, typeof(ListEvent), false);
        }
    }
}
