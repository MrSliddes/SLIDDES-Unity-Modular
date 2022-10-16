using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerULong))]
    public class EventListenerULongEditor : EventListenerEditor<ulong>
    {
        private EventListenerULong selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerULong)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<ulong>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(ULongEvent), false);
        }
    }
}
