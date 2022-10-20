using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerChar))]
    public class EventListenerCharEditor : EventListenerEditor<char>
    {
        private EventListenerChar selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerChar)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<char>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(CharEvent), false);
        }
    }
}
