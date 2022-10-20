using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerShort))]
    public class EventListenerShortEditor : EventListenerEditor<short>
    {
        private EventListenerShort selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerShort)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<short>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(ShortEvent), false);
        }
    }
}
