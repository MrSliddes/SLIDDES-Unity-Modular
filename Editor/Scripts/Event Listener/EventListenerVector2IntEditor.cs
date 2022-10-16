using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerVector2Int))]
    public class EventListenerVector2IntEditor : EventListenerEditor<Vector2Int>
    {
        private EventListenerVector2Int selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerVector2Int)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<Vector2Int>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(Vector2IntEvent), false);
        }
    }
}
