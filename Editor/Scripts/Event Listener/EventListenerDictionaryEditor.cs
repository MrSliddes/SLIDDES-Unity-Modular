using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerDictionary))]
    public class EventListenerDictionaryEditor : EventListenerEditor<Dictionary<ScriptableObject, ScriptableObject>>
    {
        private EventListenerDictionary selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerDictionary)target;
        }

        public override void DrawEventCondition()
        {
            switch(selectedType.compareValue.referenceType)
            {
                case DictionaryVariableReference.ReferenceType.variable:
                    base.DrawEventCondition();
                    break;
                case DictionaryVariableReference.ReferenceType.key:
                    selected.eventCondition = (EventCondition)EventConditionInternal.DrawEventConditionOptions("Dictionary`2 KeyValue", (int)selected.eventCondition);
                    break;
                case DictionaryVariableReference.ReferenceType.value:
                    selected.eventCondition = (EventCondition)EventConditionInternal.DrawEventConditionOptions("Dictionary`2 KeyValue", (int)selected.eventCondition);
                    break;
                default:
                    break;
            }
        }

        public override void DrawEventObjectField()
        {            
            selectedType.Event = (EventSDS<Dictionary<ScriptableObject, ScriptableObject>>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(DictionaryEvent), false);
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(propertyDescription);
            EditorGUILayout.Space();

            DrawEventObjectField();
            EditorGUILayout.PropertyField(propertyAssociatedInvoker);

            // If the type allows for compare value
            if(propertyCompareValue != null)
            {
                EditorGUILayout.Space();                
                // Draw event condition options
                DrawEventCondition();
                EditorGUILayout.PropertyField(propertyCompareValue);
            }

            // Draw response
            if(selected.Event != null)
            {
                EditorGUILayout.Space();
                EditorGUILayout.PropertyField(propertyResponse);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
