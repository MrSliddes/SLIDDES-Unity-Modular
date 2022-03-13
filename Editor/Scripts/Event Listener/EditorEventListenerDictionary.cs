using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerDictionary))]
    public class EditorEventListenerDictionary : EditorEventListener<Dictionary<ScriptableObject, ScriptableObject>>
    {
        private EventListenerDictionary selectedType;

        protected SerializedProperty m_eventConditionProp;
        protected SerializedProperty m_eventConditionKeyValueProp;
        protected SerializedProperty m_compareValueProp;
        protected SerializedProperty m_compareIntProp;

        public override void OnEnable()
        {
            selectedType = (EventListenerDictionary)target;
            base.OnEnable();
            m_eventConditionProp = serializedObject.FindProperty("eventCondition");
            m_eventConditionKeyValueProp = serializedObject.FindProperty("eventConditionKeyValue");
            m_compareValueProp = serializedObject.FindProperty("compareValue");
            m_compareIntProp = serializedObject.FindProperty("compareInt");
        }

        public override void OnInspectorGUI()
        {
            DrawGUIEventObjectField();
            
            // Based on reference type show corresponding eventCondition
            switch(selectedType.compareValue.referenceType)
            {
                case DictionaryVariableReference.ReferenceType.variable:
                    if(selected.Event != null) EditorGUILayout.PropertyField(m_eventConditionProp);
                    if(selectedType.eventCondition != EventListenerDictionary.EventCondition.none)
                        EditorGUILayout.PropertyField(m_compareValueProp, new GUIContent("Compare Value"));
                    break;
                case DictionaryVariableReference.ReferenceType.key:
                    if(selected.Event != null) EditorGUILayout.PropertyField(m_eventConditionKeyValueProp);
                    if(selectedType.eventConditionKeyValue != EventListenerDictionary.EventConditionKeyValue.none)
                        EditorGUILayout.PropertyField(m_compareValueProp, new GUIContent("Compare Value Key"));
                    if(selectedType.eventConditionKeyValue == EventListenerDictionary.EventConditionKeyValue.equalTooIndex || selectedType.eventConditionKeyValue == EventListenerDictionary.EventConditionKeyValue.notEqualTooIndex)
                        EditorGUILayout.PropertyField(m_compareIntProp, new GUIContent("Compare Index"));
                    break;
                case DictionaryVariableReference.ReferenceType.value:
                    if(selected.Event != null) EditorGUILayout.PropertyField(m_eventConditionKeyValueProp);
                    if(selectedType.eventConditionKeyValue != EventListenerDictionary.EventConditionKeyValue.none)
                        EditorGUILayout.PropertyField(m_compareValueProp, new GUIContent("Compare Value Value"));
                    if(selectedType.eventConditionKeyValue == EventListenerDictionary.EventConditionKeyValue.equalTooIndex || selectedType.eventConditionKeyValue == EventListenerDictionary.EventConditionKeyValue.notEqualTooIndex)
                        EditorGUILayout.PropertyField(m_compareIntProp, new GUIContent("Compare Index"));
                    break;
                default:
                    break;
            }

            if(selected.Event != null)
                EditorGUILayout.PropertyField(m_ResponseProp);

            serializedObject.ApplyModifiedProperties();
        }

        public override void DrawGUIEventObjectField()
        {
            selected.Event = (Event<Dictionary<ScriptableObject, ScriptableObject>>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selected.Event, typeof(DictionaryEvent), false);
        }
    }
}
