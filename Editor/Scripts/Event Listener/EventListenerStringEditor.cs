using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerString))]
    public class EventListenerStringEditor : EventListenerEditor<string>
    {
        private EventListenerString selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerString)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<string>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(StringEvent), false);
        }
    }
}
