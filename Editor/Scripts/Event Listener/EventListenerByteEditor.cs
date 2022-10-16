using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerByte))]
    public class EventListenerByteEditor : EventListenerEditor<byte>
    {
        private EventListenerByte selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerByte)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<byte>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(ByteEvent), false);
        }
    }
}
