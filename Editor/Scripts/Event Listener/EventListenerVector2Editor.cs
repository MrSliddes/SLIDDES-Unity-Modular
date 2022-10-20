using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerVector2))]
    public class EventListenerVector2Editor : EventListenerEditor<Vector2>
    {
        private EventListenerVector2 selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerVector2)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<Vector2>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(Vector2Event), false);
        }
    }
}
