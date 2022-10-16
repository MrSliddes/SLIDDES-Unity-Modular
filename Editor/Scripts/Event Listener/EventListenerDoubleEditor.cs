using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerDouble))]
    public class EventListenerDoubleEditor : EventListenerEditor<double>
    {
        private EventListenerDouble selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerDouble)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<double>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(DoubleEvent), false);
        }
    }
}
