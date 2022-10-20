using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerObject))]
    public class EventListenerObjectEditor : EventListenerEditor<object>
    {
        private EventListenerObject selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerObject)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<object>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(ObjectEvent), false);
        }
    }
}
