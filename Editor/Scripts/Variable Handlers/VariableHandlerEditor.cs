using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandler<>))]
    public class VariableHandlerEditor<T0> : UnityEditor.Editor
    {
        protected VariableHandler<T0> selected;

        protected SerializedProperty propertyDescription;
        protected SerializedProperty propertyGetValueOn;
        protected SerializedProperty propertyOnGetValue;

        private void OnEnable()
        {
            selected = (VariableHandler<T0>)target;

            propertyDescription = serializedObject.FindProperty("description");
            propertyGetValueOn = serializedObject.FindProperty("getValueOn");
            propertyOnGetValue = serializedObject.FindProperty("onGetValue");
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(propertyDescription);
            EditorGUILayout.Space();

            DrawVariableObjectField();
            EditorGUILayout.PropertyField(propertyGetValueOn);
            EditorGUILayout.Space();
            EditorGUILayout.PropertyField(propertyOnGetValue);

            serializedObject.ApplyModifiedProperties();
        }

        public virtual void DrawVariableObjectField()
        {
            selected.variable = (Variable<T0>)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(T0), false);
        }
    }
}
