using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerLong))]
    public class EventListenerLongEditor : EventListenerEditor<long>
    {
        private EventListenerLong selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerLong)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<long>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(LongEvent), false);
        }
    }
}
