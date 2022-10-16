using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerSByte))]
    public class EventListenerSByteEditor : EventListenerEditor<sbyte>
    {
        private EventListenerSByte selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerSByte)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<sbyte>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(SByteEvent), false);
        }
    }
}
