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

        public override void DrawGUIEventObjectField()
        {
            
            selectedType.Event = (EventSDS<Dictionary<ScriptableObject, ScriptableObject>>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(DictionaryEvent), false);
        }
    }
}
