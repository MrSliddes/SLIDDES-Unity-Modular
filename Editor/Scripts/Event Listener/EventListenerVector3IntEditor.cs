using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerVector3Int))]
    public class EventListenerVector3IntEditor : EventListenerEditor<Vector3Int>
    {
        private EventListenerVector3Int selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerVector3Int)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<Vector3Int>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(Vector3IntEvent), false);
        }
    }
}
