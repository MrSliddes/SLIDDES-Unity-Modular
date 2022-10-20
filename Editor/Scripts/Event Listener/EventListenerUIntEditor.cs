using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerUInt))]
    public class EventListenerUIntEditor : EventListenerEditor<uint>
    {
        private EventListenerUInt selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerUInt)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<uint>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(UIntEvent), false);
        }
    }
}
