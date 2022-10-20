using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerFloat))]
    public class EventListenerFloatEditor : EventListenerEditor<float>
    {
        private EventListenerFloat selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerFloat)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<float>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(FloatEvent), false);
        }
    }
}
