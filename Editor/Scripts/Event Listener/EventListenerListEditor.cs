using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerList))]
    public class EventListenerListEditor : EventListenerEditor<List<ScriptableObject>>
    {
        private EventListenerList selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerList)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<List<ScriptableObject>>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(ListEvent), false);
        }
    }
}
