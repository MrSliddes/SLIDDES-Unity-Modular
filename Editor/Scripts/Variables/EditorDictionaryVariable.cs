using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(DictionaryVariable))]
    public class EditorDictionaryVariable : UnityEditor.Editor
    {
        protected DictionaryVariable selected;

        private bool editorFoldoutValues;

        protected virtual void OnEnable()
        {
            selected = (DictionaryVariable)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUILayout.Space(16);

            // Display dictionary values
            editorFoldoutValues = EditorGUILayout.Foldout(editorFoldoutValues, new GUIContent("Values", "The values contained in this dictionary"));
            if(editorFoldoutValues)
            {
                if(selected.Value != null)
                {
                    EditorGUILayout.BeginVertical();
                    foreach(var item in selected.Value)
                    {
                        EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField(item.Key.name, item.Value.name);
                        EditorGUILayout.EndHorizontal();
                    }
                    EditorGUILayout.EndVertical();
                }
            }
        }
    }
}
