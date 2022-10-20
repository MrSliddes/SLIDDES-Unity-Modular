using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListener))]
    public class EventListenerEditor : EventListenerBaseEditor
    {
        protected EventListener selected;

        public override void OnEnable()
        {
            base.OnEnable();
            selected = (EventListener)target;
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(propertyDescription);
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(propertyEvent);
            EditorGUILayout.PropertyField(propertyAssociatedInvoker);

            // Draw response
            if(selected.Event != null)
            {
                EditorGUILayout.Space();
                EditorGUILayout.PropertyField(propertyResponse);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }

    [CustomEditor(typeof(EventListener<>))]
    [CanEditMultipleObjects]
    public abstract class EventListenerEditor<T0> : EventListenerBaseEditor
    {
        protected EventListener<T0> selected;
        protected SerializedProperty propertyCompareValue;

        public override void OnEnable()
        {
            base.OnEnable();
            selected = (EventListener<T0>)target;
            propertyCompareValue = serializedObject.FindProperty("compareValue");
        }

        public virtual void DrawEventCondition()
        {
            selected.eventCondition = (EventCondition)EventConditionInternal.DrawEventConditionOptions(typeof(T0).Name, (int)selected.eventCondition);
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
                if(selected.eventCondition != EventCondition.none) EditorGUILayout.PropertyField(propertyCompareValue);
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
