using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerUShort))]
    public class EventListenerUShortEditor : EventListenerEditor<ushort>
    {
        private EventListenerUShort selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerUShort)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<ushort>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(UShortEvent), false);
        }
    }
}
