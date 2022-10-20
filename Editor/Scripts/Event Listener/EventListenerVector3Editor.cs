using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerVector3))]
    public class EventListenerVector3Editor : EventListenerEditor<Vector3>
    {
        private EventListenerVector3 selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerVector3)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<Vector3>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(Vector3Event), false);
        }
    }
}
